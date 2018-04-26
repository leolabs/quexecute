Public Class AddShortcut
    Public editItem As Integer = -2

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        OpenFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\icons\"
        OpenFileDialog1.Filter = "PNG-Files (*.png) | *.png"
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then tbSCIconPath.Text = MainWindow.doReverseReplace(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnSearchApp_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchApp.Click
        OpenFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        OpenFileDialog1.Filter = "(*.*)|*"
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then tbSCPath.Text = MainWindow.doReverseReplace(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        tbSCCommand.Text = ""
        tbSCIconPath.Text = ""
        tbSCName.Text = ""
        tbSCPath.Text = ""

        editItem = -2

        Me.Close()
    End Sub

    Private Sub AddShortcut_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        editItem = -2

        tbSCCommand.Text = ""
        tbSCIconPath.Text = ""
        tbSCName.Text = ""
        tbSCPath.Text = ""
    End Sub

    Private Sub AddShortcut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbSCCommand.Text = ""
        tbSCIconPath.Text = ""
        tbSCName.Text = ""
        tbSCPath.Text = ""

        btnCancel.Text = l("cancel")
        btnHelp.Text = l("help")
        btnSearch.Text = l("search")
        btnSearchApp.Text = l("search")
        Me.Text = l("addsc_title")

        lblSCCommand.Text = l("addsc_command")
        lblSCIconPath.Text = l("addsc_iconpath")
        lblSCName.Text = l("addsc_scname")
        lblSCPath.Text = l("addsc_execpath")

        If Not editItem = -2 Then
            tbSCCommand.Text = Settings2.ListView1.Items(editItem).SubItems(1).Text
            tbSCName.Text = Settings2.ListView1.Items(editItem).SubItems(0).Text
            tbSCPath.Text = Settings2.ListView1.Items(editItem).SubItems(2).Text
            tbSCIconPath.Text = Settings2.ListView1.Items(editItem).SubItems(3).Text
        End If
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        If Not MainWindow.scdict.ContainsKey(tbSCCommand.Text) Or editItem <> -2 Then
            If Not tbSCCommand.Text.Contains(" ") Then
                Dim lvi As New ListViewItem

                If tbSCIconPath.Text Like "http*://*.*/*" Then
                    Try
                        Dim wc As New System.Net.WebClient
                        Dim uri As New Uri(tbSCIconPath.Text)
                        tbSCIconPath.Text = MainWindow.doReplace("%iconpath%\") & tbSCName.Text & " - " & Guid.NewGuid().ToString.Replace("-", "").Substring(0, 10) & ".png"
                        wc.DownloadFile(uri, tbSCIconPath.Text)
                    Catch ex As Exception
                        If MsgBox(l("msg_icondownloadfailed"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            Me.Close()
                            Exit Sub
                        Else
                            tbSCIconPath.Text = ""
                        End If
                    End Try
                End If

                Try
                    If Settings2.ImageList1.Images.Keys.Contains(tbSCCommand.Text) Then
                        Settings2.ImageList1.Images.RemoveByKey(tbSCCommand.Text)
                    End If

                    Settings2.ImageList1.Images.Add(tbSCCommand.Text, Image.FromFile(MainWindow.doReplace(tbSCIconPath.Text)))
                Catch ex As Exception
                End Try

                If editItem = -2 Then
                    lvi.Text = tbSCName.Text
                    lvi.SubItems.Add(tbSCCommand.Text)
                    lvi.SubItems.Add(tbSCPath.Text)
                    lvi.SubItems.Add(tbSCIconPath.Text)
                    lvi.ImageKey = tbSCCommand.Text
                    Settings2.ListView1.Items.Add(lvi)
                Else
                    lvi.Text = tbSCName.Text
                    lvi.SubItems.Add(tbSCCommand.Text)
                    lvi.SubItems.Add(tbSCPath.Text)
                    lvi.SubItems.Add(tbSCIconPath.Text)
                    lvi.ImageKey = tbSCCommand.Text
                    Settings2.ListView1.Items.RemoveAt(editItem)
                    Settings2.ListView1.Items.Insert(editItem, lvi)
                End If

                editItem = -2

                tbSCCommand.Text = ""
                tbSCIconPath.Text = ""
                tbSCName.Text = ""
                tbSCPath.Text = ""

                Me.Close()
            Else
                MsgBox(l("msg_nospaces"), MsgBoxStyle.Information, l("msg_deffailtitle"))
            End If
        Else
            MsgBox(l("msg_duplicateCommand", tbSCCommand.Text, MainWindow.scdict(tbSCCommand.Text).Title), MsgBoxStyle.Information, l("msg_deffailtitle"))
        End If
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        Process.Start("http://qc.leolabs.org/help/interface/#settings-shortcuts-add")
    End Sub


End Class
