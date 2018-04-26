Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Updater
    Dim websiteloaded As Boolean = False
    Dim ManuallyOpened As Boolean = False
    Dim ActDownload As String = "Update"
    Dim updateDict As New Dictionary(Of String, String)
    Dim UpdateChecker As New System.Net.WebClient
    Dim WithEvents UpdateLoader As New System.Net.WebClient
    Dim udguid As String = Guid.NewGuid().ToString

    Public Function MD5FileHash(ByVal sFile As String) As String
        Dim MD5 As New MD5CryptoServiceProvider
        Dim Hash As Byte()
        Dim Result As String = ""
        Dim Tmp As String = ""

        Dim FN As New FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        MD5.ComputeHash(FN)
        FN.Close()

        Hash = MD5.Hash
        For i As Integer = 0 To Hash.Length - 1
            Tmp = Hex(Hash(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function

    Public Sub CheckForUpdates(Optional ByVal manual As Boolean = False)
        Debug.Print("---------------Start Updater----------------")
        ManuallyOpened = manual
        Debug.Print("[UPDATER] Checking for Updates (" & manual & ")...")
        If My.Computer.Network.Ping("leolabs.org") And My.Computer.Network.Ping("mlsrv.de") Then
            Debug.Print("[UPDATER] Servers are online!")
            Debug.Print("")
            Try
                MainWindow.AufUpdatesPrüfenToolStripMenuItem.Enabled = False
                BGUpdateChecker.RunWorkerAsync()
            Catch
                MainWindow.logstr("[ERROR] (Updater, L40) Couldn't run BackgroundWorker, it's already running!", 2)
            End Try
        Else
            If ManuallyOpened Then
                MsgBox(l("msg_noping"), MsgBoxStyle.Information, l("msg_deffailtitle"))
            End If
        End If
    End Sub

    Private Sub wbChangelog_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wbChangelog.DocumentCompleted
        websiteloaded = True
    End Sub

    Private Sub wbChangelog_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles wbChangelog.Navigating
        If websiteloaded And Not e.Url.AbsoluteUri Like "http://updates.leolabs.org/quexecute/changelog_??.html" And e.Url.AbsoluteUri <> "about:blank" Then
            wbChangelog.GoBack()
            Debug.Print("[UPDATER] Opened external URL - " & e.Url.AbsoluteUri)
            Process.Start(e.Url.AbsoluteUri)
        End If
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        My.Settings.UpdaterSkippedVersion = updateDict("latestversion")
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub btnLater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLater.Click
        Me.Hide()
    End Sub

    Private Sub btnInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstall.Click
        MainWindow.logstr("[UPDATE] Updater initialized...")
        gbUpdate.Show()
        gbChangelog.Hide()
        Me.Height = 186
        MainWindow.logstr("[UPDATE] Downloading Update to """ & System.IO.Path.GetTempPath & "quexecute_update_" & udguid & ".exe" & """...")
        UpdateLoader.DownloadFileAsync(New Uri(updateDict("latestdownload")), System.IO.Path.GetTempPath & "quexecute_update_" & udguid & ".exe")
    End Sub

    Private Sub UpdateLoader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles UpdateLoader.DownloadFileCompleted
        MainWindow.logstr("[UPDATE] Update downloaded...")
        ProgressBar1.Value = 100

        If MD5FileHash(System.IO.Path.GetTempPath & "quexecute_update_" & udguid & ".exe") = updateDict("updatehash") Then
runupdater:
            Try
                MainWindow.logstr("[UPDATE] Trying to start """ & System.IO.Path.GetTempPath & "quexecute_update_" & udguid & ".exe /SILENT" & """...")
                Shell("""" & System.IO.Path.GetTempPath & "quexecute_update_" & udguid & ".exe "" /SILENT", AppWinStyle.NormalFocus)
                Application.ExitThread()
                Application.Exit()
            Catch ex As Exception
                MainWindow.logstr("[UPDATE] Starting Update failed: " & ex.ToString)
                Me.Hide()
                MainWindow.ShowMsg(l("msg_error_title"), l("msg_error_text", ex.Message.ToString, ex.InnerException.ToString), MainWindow.MsgIcon.Critical, True, 5000)
            End Try
        Else
            MainWindow.logstr("[UPDATE] Wrong Update Hash, asking user what to do...")
            If MsgBox(l("u_wronghash"), MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MainWindow.logstr("[UPDATE] User agrees, continueing...")
                GoTo runupdater
            Else
                MainWindow.logstr("[UPDATE] User disagrees, quitting Updater...")
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub UpdateLoader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles UpdateLoader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label3.Text = l("u_downstat", "Update", Math.Round(e.BytesReceived / 1024 / 1024, 2), Math.Round(e.TotalBytesToReceive / 1024 / 1024, 2), e.ProgressPercentage)
    End Sub

    Private Sub Updater_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnInstall.Text = l("u_install")
        btnLater.Text = l("u_remindlater")
        btnSkip.Text = l("u_skipversion")
    End Sub

    Private Sub BGUpdateChecker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGUpdateChecker.DoWork
        Try
            Dim int As Integer = ManuallyOpened
            Debug.Print("[UPDATER] Checking on " & "http://qc.leolabs.org/getUpdates.php?manual=" & int & "&v=" & MainWindow.version & "&l=" & System.Globalization.CultureInfo.CurrentCulture.Name)
            Dim text As String = UpdateChecker.DownloadString(New Uri("http://qc.leolabs.org/getUpdates.php?manual=" & int & "&v=" & MainWindow.version & "&l=" & System.Globalization.CultureInfo.CurrentCulture.Name))
            e.Result = text
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub BGUpdateChecker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGUpdateChecker.RunWorkerCompleted
        MainWindow.AufUpdatesPrüfenToolStripMenuItem.Enabled = True
        Try
            updateDict.Clear()
            For Each a As String In e.Result.Split(vbLf)
                If Not a.StartsWith("#") Then
                    Debug.Print("[UPDATER] " & a.Trim().Trim(vbNewLine))
                    updateDict.Add(a.Split("=")(0).Trim(" "), a.Split("=")(1).Trim(" ").Trim(vbCrLf).Trim(vbCr).Trim(vbLf))
                End If
            Next

        Catch ex As Exception
            Me.Hide()
            Debug.Print("[UPDATER] Syntax error in Update file!")
            MainWindow.logstr("[ERROR] (Updater, L133) Syntax error in Update file!", 2)
            Debug.Print("[UPDATER] " & ex.Message)
            If ManuallyOpened Then
                MsgBox(l("u_serverfail"))
            End If
            Exit Sub
        End Try
        Try
            If updateDict("latestversion") > MainWindow.build And (Not My.Settings.UpdaterSkippedVersion = updateDict("latestversion") Or ManuallyOpened) Then
                Label1.Text = l("u_newversion_title") 'Entry.L.l("updater_newversion")
                Label2.Text = l("u_newversion_text", updateDict("latestversionstring"), MainWindow.version)  'Entry.L.l("updater_desc", updateDict("latestversionstring"), Application.ProductVersion.Substring(0, 5))
                Me.Show()
            Else
                If ManuallyOpened Then
                    MsgBox(l("u_newestversion")) 'Entry.L.l("updater_noupdates")
                End If
            End If
        Catch ex As Exception
            Debug.Print("[UPDATER] Syntax error in Update file!")
            MainWindow.logstr("[ERROR] (Updater, L133) Syntax error in Update file!", 2)
            Debug.Print("[UPDATER] " & ex.Message)
            If ManuallyOpened Then
                MsgBox(l("u_serverfail"))
            End If
        End Try
        Debug.Print("----------------End Updater-----------------")
    End Sub
End Class