Public Class AvailableFunctions

    Private Sub AvailableFunctions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = l("lbl_intro")
        ListView1.Columns.Item(0).Text = l("cll_name")
        ListView1.Columns.Item(1).Text = l("cll_shortcut")
        ListView1.Columns.Item(2).Text = l("cll_path")
        Button1.Text = l("manage_shortcuts")
        Me.Text = l("ac_title")

        For Each sc As MainWindow.Shortcut In MainWindow.scdict.Values
            Try
                Dim lvi As New ListViewItem
                lvi.Text = sc.Title
                lvi.SubItems.Add(sc.Shortcut)
                lvi.SubItems.Add(sc.ExecPath)
                If Not sc.IconPath = Nothing And My.Computer.FileSystem.FileExists(MainWindow.doReplace(sc.IconPath)) Then ImageList1.Images.Add(sc.Shortcut, Image.FromFile(MainWindow.doReplace(sc.IconPath)))
                lvi.ImageKey = sc.Shortcut

                ListView1.Items.Add(lvi)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MainWindow.openShortcutEditor()
        Me.Close()
    End Sub
End Class