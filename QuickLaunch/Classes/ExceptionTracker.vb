Module ExceptionTracker
    Public Sub TrackException(ByVal ex As Exception, Optional ByVal AskUser As Boolean = False)
        Try
            Dim ExceptionMessage As String = ex.Message
            Dim ExceptionInner As String = ""
            If Not IsNothing(ex.InnerException) Then ExceptionInner = ex.InnerException.ToString
            Dim StackTrace As String = ""
            If Not IsNothing(ex.StackTrace) Then StackTrace = ex.StackTrace
            Dim ErrorMethod As String = ex.TargetSite.ToString
            Dim UserDescription As String = "Nicht gefragt"

            If AskUser Then
                If ExceptionUserDetails.ShowDialog(MainWindow) = DialogResult.OK Then
                    UserDescription = ExceptionUserDetails.TextBox1.Text
                Else
                    UserDescription = "Beschreibung übersprungen."
                End If
            End If

            Dim AppID As String = "0"
            Dim Version As String = MainWindow.version & " - " & MainWindow.build
            Dim NETFramework As String = System.Environment.Version.ToString
            Dim InstalledOS As String = System.Environment.OSVersion.VersionString

            Dim args As String = "em=" & ExceptionMessage & _
                                 "&ei=" & ExceptionInner & _
                                 "&st=" & StackTrace & _
                                 "&eme=" & ErrorMethod & _
                                 "&udesc=" & UserDescription & _
                                 "&appid=" & AppID & _
                                 "&v=" & Version & _
                                 "&net=" & NETFramework & _
                                 "&os=" & InstalledOS

            If My.Computer.Network.Ping("leolabs.org") Then
                Dim result As String = PostURL("http://track.leolabs.org/api/addException.php", args)
                MainWindow.logstr("[INFO] Sent error report to the developer.")
            End If
        Catch ex2 As Exception
            ' Throw ex2 // Das gibt ne dumme Fehlerschleife 
        End Try
    End Sub

    Public Function PostURL(ByVal url As String, ByVal arguments As String) As String
        Try
            Dim oWeb As New System.Net.WebClient()

            oWeb.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

            Dim bytArguments As Byte() = System.Text.Encoding.UTF8.GetBytes(arguments)
            Dim bytRetData As Byte() = oWeb.UploadData(url, "POST", bytArguments)

            Return System.Text.Encoding.UTF8.GetString(bytRetData)
        Catch ex As Exception
            Return "0;Couldn't connect to server!"
        End Try
    End Function
End Module
