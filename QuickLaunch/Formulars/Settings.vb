Public Class Settings2
    Public Hotkey As System.Windows.Forms.KeyEventArgs
    Public pmkeys As Integer
    Public lngStartInt As Integer

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            '################## Einstellungen speichern ##################
            MainWindow.SetConfigValue("autocompletemode", ctlAutocomplete.SelectedIndex)
            MainWindow.SetConfigValue("position", ctlPosition.SelectedIndex)
            MainWindow.SetConfigValue("width", ctlWidth.Value)
            MainWindow.SetConfigValue("opacity", ctlTransparency.Value)

            If ctlLanguage.SelectedIndex = 0 Then
                MainWindow.SetConfigValue("language", "DEF")
            ElseIf ctlLanguage.SelectedIndex = 1 Then
                MainWindow.SetConfigValue("language", "DE")
            ElseIf ctlLanguage.SelectedIndex = 2 Then
                MainWindow.SetConfigValue("language", "EN")
            End If

            If Not ctlLanguage.SelectedIndex = lngStartInt Then
                MsgBox(l("msg_needsrestart"), MsgBoxStyle.Information)
            End If

            If cbStdShortcut.SelectedItem = l("cbStdShortcutNone") Then
                MainWindow.SetConfigValue("defaultshortcut", "-1")
            Else
                MainWindow.SetConfigValue("defaultshortcut", MainWindow.scdict(cbStdShortcut.SelectedItem.ToString.Split("(")(1).Split(")")(0)).Shortcut)
            End If

            MainWindow.SetConfigValue("hotkey", Hotkey.KeyValue)

            MainWindow.SetConfigValue("hkmods", pmkeys)

            MainWindow.SetConfigValue("acceptqllinks", ToInteger(ctlOpenLinks.Checked))

            MainWindow.SetConfigValue("hideonfocuslose", ToInteger(ctlCloseCommandwindow.Checked))
            MainWindow.SetConfigValue("populatestartmenu", ToInteger(ctlPopulateStartMenu.Checked))
            MainWindow.SetConfigValue("opensimpleurls", ToInteger(cbOpenSimpleURLs.Checked))

            MainWindow.xdoc.<appconfig>.<shortcuts>.Descendants.Remove()

            Try
                MainWindow.Autostart(ctlAutostart.Checked)
            Catch ex As Exception
                ctlAutostart.Enabled = False
                Debug.Print(ex.ToString)
            End Try

            For Each item As ListViewItem In ListView1.Items
                Dim xem As New XElement("sc")
                xem.Add(New XAttribute("title", MainWindow.doReverseReplace(item.SubItems(0).Text)))
                xem.Add(New XAttribute("term", MainWindow.doReverseReplace(item.SubItems(1).Text)))
                xem.Add(New XAttribute("path", MainWindow.doReverseReplace(item.SubItems(2).Text)))
                xem.Add(New XAttribute("icon", MainWindow.doReverseReplace(item.SubItems(3).Text)))
                MainWindow.xdoc.Element("appconfig").Element("shortcuts").Add(xem)
            Next

            MainWindow.xdoc.Save(MainWindow.ConfigPath)
            Me.Close()
            MainWindow.Initialize()
            MainWindow.Invalidate()
        Catch ex As Exception
            ExceptionTracker.TrackException(ex, True)
        End Try
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsBarSC.Visible = True

        '################# Sprache ##################
        Me.Text = l("settings_title")

        ctlOpenConfig.Text = l("ctlOpenConfig")
        tabGeneral.Text = l("tabGeneral")
        tabShortcuts.Text = l("tabCommands")
        tabAbout.Text = l("tabAbout")
        tabCommandWindow.Text = l("tabCommandwindow")
        tabTools.Text = l("tabTools")

        lblAutocomplete.Text = l("lblACM")
        lblHotkey.Text = l("lblHotkey")
        lblLanguage.Text = l("lblLanguage")
        lblPosition.Text = l("lblPosition")
        lblTransparency.Text = l("lblTransparency")
        lblWidth.Text = l("lblWidth")
        lblAutostart.Text = l("lblAutostart")
        lblOpenLinks.Text = l("lblOpenLinks")
        lbStdShortcut.Text = l("lblStdShortcut")
        lblHideCommandwindow.Text = l("lblCloseCMDWin")
        lblPopulateStartMenu.Text = l("lblPopulateStartMenu")
        ctlOpenLinks.Text = l("ctlOpenLinks")
        ctlAutostart.Text = l("ctlAutostart")
        lblOpenSimpleURLs.Text = l("lblOpenSimpleURLs")
        cbOpenSimpleURLs.Text = l("cbOpenSimpleURLs")

        cbStdShortcut.Items.Clear()
        cbStdShortcut.Items.Add(l("cbStdShortcutNone"))

        ctlPosition.Items.Add(l("ctlPositionTop"))
        ctlPosition.Items.Add(l("ctlPositionCenter"))

        ctlAutocomplete.Items.Add(l("ctlACMNone"))
        ctlAutocomplete.Items.Add(l("ctlACMSuggest"))
        ctlAutocomplete.Items.Add(l("ctlACMAppend"))
        ctlAutocomplete.Items.Add(l("ctlACMSuggestAppend"))

        tbCredits.Text = l("credits")

        btnSCAdd.Text = l("addSC")
        btnSCDelete.Text = l("deleteSC")
        btnSCEdit.Text = l("editSC")
        btnSCGetOnline.Text = l("getnewSC")

        lblQLToolsetIntro.Text = l("toolsIntro")
        gbAutostart.Text = l("gbAutostart")
        gbQLProtocol.Text = l("gbProtocol")
        gbConfigFile.Text = l("gbConfig")
        btnTSAddAutostart.Text = l("toolsAddAutostart")
        btnTSRemoveAutostart.Text = l("toolsDeleteAutostart")
        btnTSRegisterProtocol.Text = l("toolsRegisterProtocol")
        btnTSRemoveProtocol.Text = l("toolsUnregisterProtocol")
        btnTSRestoreConfig.Text = l("toolsRestoreConfig")

        btnHelp.Text = l("help")

        lblVersion.Text = "QuExeCute - Version " & MainWindow.version

        '################# Einstellungen laden ##################
        ctlAutocomplete.SelectedIndex = MainWindow.GetConfigValue("autocompletemode", 1)
        ctlPosition.SelectedIndex = MainWindow.GetConfigValue("position", 0)
        ctlWidth.Value = MainWindow.GetConfigValue("width", 620)
        ctlTransparency.Value = MainWindow.GetConfigValue("opacity", 90)
        ctlOpenLinks.Checked = MainWindow.GetConfigValue("acceptqllinks", True)
        ctlCloseCommandwindow.Checked = MainWindow.GetConfigValue("hideonfocuslose", 1)
        ctlPopulateStartMenu.Checked = MainWindow.GetConfigValue("populatestartmenu", True)

        For Each sc As MainWindow.Shortcut In MainWindow.scdict.Values
            Try
                cbStdShortcut.Items.Add(sc.Title & " (" & sc.Shortcut & ")")
            Catch ex As Exception

            End Try
        Next

        If MainWindow.GetConfigValue("defaultshortcut", "-1") = "-1" Then
            cbStdShortcut.SelectedIndex = 0
        Else
            If MainWindow.scdict.ContainsKey(MainWindow.GetConfigValue("defaultshortcut", "-1")) Then
                cbStdShortcut.SelectedItem = MainWindow.scdict(MainWindow.GetConfigValue("defaultshortcut", "-1")).Title & " (" & MainWindow.scdict(MainWindow.GetConfigValue("defaultshortcut", "-1")).Shortcut & ")"
            Else
                cbStdShortcut.SelectedIndex = 0
            End If
        End If

        cbOpenSimpleURLs.Checked = MainWindow.GetConfigValue("opensimpleurls", 1)

        Hotkey = New System.Windows.Forms.KeyEventArgs(MainWindow.GetConfigValue("hotkey", 220))
        pmkeys = MainWindow.GetConfigValue("hkmods", 4)
        UpdateHotkeyLabel()

        If MainWindow.GetConfigValue("language", "DEF") = "DEF" Then
            ctlLanguage.SelectedIndex = 0
        ElseIf MainWindow.GetConfigValue("language", "DEF") = "DE" Then
            ctlLanguage.SelectedIndex = 1
        ElseIf MainWindow.GetConfigValue("language", "DEF") = "EN" Then
            ctlLanguage.SelectedIndex = 2
        End If

        lngStartInt = ctlLanguage.SelectedIndex

        If Not My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\config.xml") Then
            ctlOpenConfig.Enabled = False
        End If

        '######################### Shortcuts Panel initialisieren ######################
        ListView1.Columns.Item(0).Text = l("cll_name")
        ListView1.Columns.Item(1).Text = l("cll_shortcut")
        ListView1.Columns.Item(2).Text = l("cll_path")
        Try
            ctlAutostart.Checked = MainWindow.CheckAutostart()
        Catch ex As Exception
            ctlAutostart.Enabled = False
        End Try

        ctlOpenLinks.Enabled = MainWindow.GetConfigValue("acceptqllinks", 1)

        For Each sc As MainWindow.Shortcut In MainWindow.scdict.Values
            Try
                Dim lvi As New ListViewItem
                lvi.Text = sc.Title
                lvi.SubItems.Add(sc.Shortcut)
                If Not Join(sc.AutoComplete, "") = "" Then
                    lvi.SubItems.Add(sc.ExecPath & " %(" & Join(sc.AutoComplete, ",") & ")%")
                Else
                    lvi.SubItems.Add(sc.ExecPath)
                End If
                lvi.SubItems.Add(sc.IconPath)
                If Not sc.IconPath = Nothing And My.Computer.FileSystem.FileExists(MainWindow.doReplace(sc.IconPath)) Then ImageList1.Images.Add(sc.Shortcut, Image.FromFile(MainWindow.doReplace(sc.IconPath)))
                lvi.ImageKey = sc.Shortcut

                ListView1.Items.Add(lvi)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Public Sub UpdateHotkeyLabel()
        Dim kint As Integer = pmkeys
        Dim mkeys As String = ""

        If kint - 8 >= 0 Then
            mkeys &= "Win + "
            kint = kint - 8
        End If

        If kint - 4 >= 0 Then
            mkeys &= "Shift + "
            kint = kint - 4
        End If

        If kint - 2 >= 0 Then
            mkeys &= "Control + "
            kint = kint - 2
        End If

        If kint - 1 >= 0 Then
            mkeys &= "Alt + "
            kint = kint - 1
        End If

        ctlHotKey.Text = l("ctlHotkey", mkeys & Hotkey.KeyCode.ToString)
    End Sub

#Region "Clicks & Events"
    Private Sub ctlHotKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlHotKey.Click
        SetHotKey.ShowDialog(Me)
    End Sub

    Private Sub btnSCGetOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCGetOnline.Click
        MainWindow.openWebsitePath("gallery") 'Process.Start("http://qc.leolabs.org/gallery/")
    End Sub

    Private Sub btnSCAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCAdd.Click
        AddShortcut.ShowDialog(Me)
    End Sub

    Private Sub btnSCDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCDelete.Click
        ListView1.SelectedItems(0).Remove()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ctlOpenConfig_Click(sender As System.Object, e As System.EventArgs) Handles ctlOpenConfig.Click
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\config.xml")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1() Handles btnSCEdit.Click
        If ListView1.SelectedIndices.Count > 0 Then
            AddShortcut.editItem = ListView1.SelectedIndices(0)
            AddShortcut.ShowDialog(Me)
        End If
    End Sub

    Private Sub ctlWebsite_Click(sender As System.Object, e As System.EventArgs) Handles ctlWebsite.Click
        MainWindow.openWebsitePath("") 'Process.Start("http://qc.leolabs.org/")
    End Sub

    Private Sub ctlForum_Click(sender As System.Object, e As System.EventArgs) Handles ctlForum.Click
        Process.Start("http://qc.leolabs.org/forum/")
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        ToolStripButton1_Click_1()
    End Sub
#End Region

    Private Sub callQCToolset(ByVal argument As String)
        Try
            Shell("""" & Application.StartupPath & "\QCToolset.exe"" " & argument, AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(l("msg_qctoolsetfail_text"), MsgBoxStyle.Information, l("msg_qctoolsetfail_title"))
        End Try
    End Sub

    Private Sub btnTSAddAutostart_Click(sender As System.Object, e As System.EventArgs) Handles btnTSAddAutostart.Click
        callQCToolset("/setAutostart")
    End Sub

    Private Sub btnTSRemoveAutostart_Click(sender As System.Object, e As System.EventArgs) Handles btnTSRemoveAutostart.Click
        callQCToolset("/deleteAutostart")
    End Sub

    Private Sub btnTSRegisterProtocol_Click(sender As System.Object, e As System.EventArgs) Handles btnTSRegisterProtocol.Click
        callQCToolset("/registerProtocol")
    End Sub

    Private Sub btnTSRemoveProtocol_Click(sender As System.Object, e As System.EventArgs) Handles btnTSRemoveProtocol.Click
        callQCToolset("/unregisterProtocol")
    End Sub

    Private Sub btnTSRestoreConfig_Click(sender As System.Object, e As System.EventArgs) Handles btnTSRestoreConfig.Click
        callQCToolset("/restoreConfig")
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MainWindow.openWebsitePath("help/interface/#settings") 'Process.Start("http://qc.leolabs.org/help/interface/#settings")
    End Sub

    Private Function ToInteger(ByVal bool As Boolean) As Integer
        If bool Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class