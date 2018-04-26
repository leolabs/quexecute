Public Class AddWebShortcut

    Private Sub AddWebShortcut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnCancel.Text = l("cancel")
        btnHelp.Text = l("help")
        Me.Text = l("addsc_title")

        lblSCCommand.Text = l("addsc_command")
        lblSCIconPath.Text = l("addsc_iconpath")
        lblSCName.Text = l("addsc_scname")
        lblSCPath.Text = l("addsc_execpath")
    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If Not MainWindow.scdict.ContainsKey(tbSCCommand.Text) Then
            If Not tbSCCommand.Text.Contains(" ") Then
                btnAccept.Text = l("loading")
                Dim IconURL As String = ""
                Try
                    Dim wc As New System.Net.WebClient
                    Dim uri As New Uri(tbSCIconPath.Text)
                    IconURL = MainWindow.doReplace("%iconpath%\") & tbSCName.Text & " - " & Guid.NewGuid().ToString.Replace("-", "").Substring(0, 10) & ".png"
                    wc.DownloadFile(uri, IconURL)
                Catch ex As Exception
                    If MsgBox(l("msg_icondownloadfailed"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Me.Close()
                        Exit Sub
                    Else
                        IconURL = ""
                    End If
                End Try
                Dim xem As New XElement("sc")
                xem.Add(New XAttribute("title", tbSCName.Text))
                xem.Add(New XAttribute("term", tbSCCommand.Text))
                xem.Add(New XAttribute("path", tbSCPath.Text))
                xem.Add(New XAttribute("icon", MainWindow.doReverseReplace(IconURL)))
                MainWindow.xdoc.Element("appconfig").Element("shortcuts").Add(xem)
                MainWindow.xdoc.Save(MainWindow.ConfigPath)
                Me.Close()
                MainWindow.Initialize()
            Else
                MsgBox(l("msg_nospaces"), MsgBoxStyle.Information, l("msg_deffailtitle"))
            End If
        Else
            MsgBox(l("msg_duplicateCommand", tbSCCommand.Text, MainWindow.scdict(tbSCCommand.Text).Title), MsgBoxStyle.Information, l("msg_deffailtitle"))
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        Process.Start("http://qc.leolabs.org/help/interface/#settings-shortcuts-add")
    End Sub
End Class