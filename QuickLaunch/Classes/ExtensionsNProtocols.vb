Imports System.Collections.Generic
Imports System.Collections
Imports System.Text
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Drawing

Namespace FileTypeAndIcon
    Public Structure Reg
        Dim Icon As Image
        Dim Name As String
    End Structure
    ''' <summary>
    ''' Structure that encapsulates basic information of icon embedded in a file.
    ''' </summary>
    Public Structure EmbeddedIconInfo
        Public FileName As String
        Public IconIndex As Integer
    End Structure

    Public Class RegisteredFileType
#Region "APIs"

        Private Declare Ansi Function ExtractIcon Lib "shell32.dll" Alias "ExtractIconA" (hInst As Integer, lpszExeFileName As String, nIconIndex As Integer) As IntPtr

        <DllImport("shell32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function ExtractIconEx(szFileName As String, nIconIndex As Integer, phiconLarge As IntPtr(), phiconSmall As IntPtr(), nIcons As UInteger) As UInteger
        End Function

        <DllImport("user32.dll", EntryPoint:="DestroyIcon", SetLastError:=True)> _
        Private Shared Function DestroyIcon(hIcon As IntPtr) As Integer
        End Function

#End Region

#Region "CORE METHODS"

        ''' <summary>
        ''' Gets registered file types and their associated icon in the system.
        ''' </summary>
        ''' <returns>Returns a hash table which contains the file extension as keys, the icon file and param as values.</returns>
        Public Shared Function GetFileTypeAndIcon() As Hashtable
            Try
                ' Create a registry key object to represent the HKEY_CLASSES_ROOT registry section
                Dim rkRoot As RegistryKey = Registry.ClassesRoot

                'Gets all sub keys' names.
                Dim keyNames As String() = rkRoot.GetSubKeyNames()
                Dim iconsInfo As New Hashtable()

                'Find the file icon.
                For Each keyName As String In keyNames
                    If [String].IsNullOrEmpty(keyName) Then
                        Continue For
                    End If
                    Dim indexOfPoint As Integer = keyName.IndexOf(".")

                    If indexOfPoint <> 0 Then
                        Continue For
                    End If

                    Dim rkFileType As RegistryKey = rkRoot.OpenSubKey(keyName)
                    If rkFileType Is Nothing Then
                        Continue For
                    End If

                    'Gets the default value of this key that contains the information of file type.
                    Dim defaultValue As Object = rkFileType.GetValue("")
                    If defaultValue Is Nothing Then
                        Continue For
                    End If

                    'Go to the key that specifies the default icon associates with this file type.
                    Dim defaultIcon As String = defaultValue.ToString() & "\DefaultIcon"
                    Dim rkFileIcon As RegistryKey = rkRoot.OpenSubKey(defaultIcon)
                    If rkFileIcon IsNot Nothing Then
                        'Get the file contains the icon and the index of the icon in that file.
                        Dim value As Object = rkFileIcon.GetValue("")
                        If value IsNot Nothing Then
                            'Clear all unecessary " sign in the string to avoid error.
                            Dim fileParam As String = value.ToString().Replace("""", "")
                            iconsInfo.Add(keyName, fileParam)
                        End If
                        rkFileIcon.Close()
                    End If
                    rkFileType.Close()
                Next
                rkRoot.Close()
                Return iconsInfo
            Catch exc As Exception
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Extract the icon from file.
        ''' </summary>
        ''' <param name="fileAndParam">The params string, 
        ''' such as ex: "C:\\Program Files\\NetMeeting\\conf.exe,1".</param>
        ''' <returns>This method always returns the large size of the icon (may be 32x32 px).</returns>
        Public Shared Function ExtractIconFromFile(fileAndParam As String) As Icon
            Try
                Dim embeddedIcon As EmbeddedIconInfo = getEmbeddedIconInfo(fileAndParam)

                'Gets the handle of the icon.
                Dim lIcon As IntPtr = ExtractIcon(0, embeddedIcon.FileName, embeddedIcon.IconIndex)

                'Gets the real icon.
                Return Icon.FromHandle(lIcon)
            Catch exc As Exception
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Extract the icon from file.
        ''' </summary>
        ''' <param name="fileAndParam">The params string, 
        ''' such as ex: "C:\\Program Files\\NetMeeting\\conf.exe,1".</param>
        ''' <param name="isLarge">
        ''' Determines the returned icon is a large (may be 32x32 px) 
        ''' or small icon (16x16 px).</param>
        Public Shared Function ExtractIconFromFile(fileAndParam As String, isLarge As Boolean) As Icon
            Dim readIconCount As UInteger = 0
            Dim hDummy As IntPtr() = New IntPtr(0) {IntPtr.Zero}
            Dim hIconEx As IntPtr() = New IntPtr(0) {IntPtr.Zero}

            Try
                Dim embeddedIcon As EmbeddedIconInfo = getEmbeddedIconInfo(fileAndParam)

                If isLarge Then
                    readIconCount = ExtractIconEx(embeddedIcon.FileName, 0, hIconEx, hDummy, 1)
                Else
                    readIconCount = ExtractIconEx(embeddedIcon.FileName, 0, hDummy, hIconEx, 1)
                End If

                If readIconCount > 0 AndAlso hIconEx(0) <> IntPtr.Zero Then
                    ' Get first icon.
                    Dim extractedIcon As Icon = DirectCast(Icon.FromHandle(hIconEx(0)).Clone(), Icon)

                    Return extractedIcon
                Else
                    ' No icon read
                    Return Nothing
                End If
            Catch exc As Exception
                ' Extract icon error.
                Throw New ApplicationException("Could not extract icon", exc)
            Finally
                ' Release resources.
                For Each ptr As IntPtr In hIconEx
                    If ptr <> IntPtr.Zero Then
                        DestroyIcon(ptr)
                    End If
                Next

                For Each ptr As IntPtr In hDummy
                    If ptr <> IntPtr.Zero Then
                        DestroyIcon(ptr)
                    End If
                Next
            End Try
        End Function

#End Region

        Protected Shared Function getEmbeddedIconInfo(fileAndParam As String) As EmbeddedIconInfo
            Dim embeddedIcon As New EmbeddedIconInfo()

            If [String].IsNullOrEmpty(fileAndParam) Then
                Return embeddedIcon
            End If

            'Use to store the file contains icon.
            Dim fileName As String = [String].Empty

            'The index of the icon in the file.
            Dim iconIndex As Integer = 0
            Dim iconIndexString As String = [String].Empty

            Dim commaIndex As Integer = fileAndParam.IndexOf(",")
            'if fileAndParam is some thing likes that: "C:\\Program Files\\NetMeeting\\conf.exe,1".
            If commaIndex > 0 Then
                fileName = fileAndParam.Substring(0, commaIndex)
                iconIndexString = fileAndParam.Substring(commaIndex + 1)
            Else
                fileName = fileAndParam
            End If

            If Not [String].IsNullOrEmpty(iconIndexString) Then
                'Get the index of icon.
                iconIndex = Integer.Parse(iconIndexString)
                If iconIndex < 0 Then
                    iconIndex = 0
                    'To avoid the invalid index.
                End If
            End If

            embeddedIcon.FileName = fileName
            embeddedIcon.IconIndex = iconIndex

            Return embeddedIcon
        End Function
    End Class
End Namespace
