Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Web
Imports NCalc

Public Class MainWindow
#Region "Deklarationen"
    Public Declare Auto Function GetSystemMetrics Lib "user32.dll" (ByVal smIndex As Integer) As Integer
    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Declare Sub UnregisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer)
    Private Const Key_NONE As Integer = &H0
    Private Const WM_HOTKEY As Integer = &H312
    Private Const Key_ALT As Integer = &H1 'Alt
    Private Const Key_CTRL As Integer = &H2 'Strg
    Private Const Key_SHIFT As Integer = &H4 'Shift
    Private Const Key_WIN As Integer = &H8 'Win
#End Region

#Region "# VERSION #"
    Public Const build As String = "20130120"
    Public Const version As String = "2.2.3"
#End Region

#Region "Globale Variablen"
    Public Structure Shortcut
        Dim Shortcut As String
        Dim Title As String
        Dim ExecPath As String
        Dim IconPath As String
        Dim AutoComplete() As String
    End Structure

    Public Enum MsgIcon
        Warning = 0
        Critical = 1
        Info = 2
    End Enum

    Public scdict As New Dictionary(Of String, Shortcut)
    Public xdoc As XDocument = Nothing
    Public ConfigPath As String
    Public ExitApp As Boolean = False
    Public IsMsg As Boolean = False
    Dim lastInput As String = ""
    Dim justShown As Boolean = False
    Public appguid As String = ""
    Dim startList As New List(Of String)
    Dim startLinks As New List(Of String)
    Dim TickCount As Integer = 0
    Dim MS As Integer = 3000
    Dim fileTypesAndIcons As Hashtable = FileTypeAndIcon.RegisteredFileType.GetFileTypeAndIcon
    Dim URLChecker As New StringChecker.URL()
    Dim MathChecker As New StringChecker.Math()

    Dim WidthOffset As Integer = 0
    Dim WindowWidthOffset As Integer = 0
    Dim HeightOffset As Integer = 0
    Dim TopOffset As Integer = -8
#End Region

#Region "Form Events"
    Private Sub TextBox1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1.Image = My.Resources.loader

            ' Eingegebenen Text der History hinzufügen
            If Not xdoc.Element("appconfig").Descendants("history").Any() Then
                xdoc.Element("appconfig").Add(New XElement("history"))
            End If

            Try
                If Not xdoc.Element("appconfig").Element("history").ToString().Contains("<term>" & TextBox1.Text & "</term>") Then
                    Dim xem As New XElement("term")
                    xem.Value = TextBox1.Text

                    xdoc.Element("appconfig").Element("history").AddFirst(xem)

                    If xdoc.Element("appconfig").Element("history").Descendants().Count > 50 Then
                        xdoc.Element("appconfig").Element("history").LastNode.Remove()
                    End If

                    xdoc.Save(ConfigPath)
                End If
            Catch
                logstr("Error while trying to write the last input to the history Tag!")
            End Try

            ' Prüfen, ob eingegebener Text ein Startmenüeintrag ist
            If startList.Contains(TextBox1.Text) Then
                Try
                    Me.Hide()
                    Process.Start(startLinks(startList.IndexOf(TextBox1.Text)))
                    PictureBox1.Image = My.Resources.QuickLaunch_Logo32
                    TextBox1.Clear()
                Catch
                    PictureBox1.Image = My.Resources.QuickLaunch_Logo32
                    ShowMsg(l("msg_path_failed_title"), l("msg_path_failed_text"), MsgIcon.Warning, False, 3000)
                End Try
            Else


                ' Eingegebener Text muss ein Shortcut o.ä. sein
                appguid = Guid.NewGuid().ToString.Replace("-", "")

                ' Befehl und Argumente festlegen
                Dim command As String = TextBox1.Text.Split(" ")(0)
                Dim arguments As String = ""

                If TextBox1.Text.Length > command.Length Then
                    arguments = TextBox1.Text.Substring(TextBox1.Text.Split(" ")(0).Length + 1)
                End If

                If scdict.ContainsKey(command) Then
                    If ExecuteCommand(command, arguments, appguid) = False Then
                        Me.Visible = False
                        ExecuteProcess(TextBox1.Text, appguid)
                    End If
                Else
                    Me.Visible = False
                    If URLChecker.isDomain(TextBox1.Text, 3) And GetConfigValue("opensimpleurls", "1") = "1" Then
                        Try
                            Process.Start(GetDefaultBrowser(), TextBox1.Text)
                        Catch
                            ExecuteProcess(TextBox1.Text, appguid)
                        End Try
                    Else
                        ExecuteProcess(TextBox1.Text, appguid)
                    End If
                End If
            End If

            PictureBox1.Image.Dispose()
            PictureBox1.Image = My.Resources.QuickLaunch_Logo32
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Visible = False
        End If

        System.GC.Collect()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Label1.ForeColor = Color.DimGray
            Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset

            If scdict.ContainsKey(TextBox1.Text.Split(" ")(0)) Then
                Me.Text = "QuExeCute - " & scdict(TextBox1.Text.Split(" ")(0)).Title
                Label1.Text = scdict(TextBox1.Text.Split(" ")(0)).Title
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Image.FromFile(doReplace(scdict(TextBox1.Text.Split(" ")(0)).IconPath))

            ElseIf TextBox1.Text = "" Then
                Me.Text = "QuExeCute - Version " & version
                Label1.Text = "QuExeCute " & version
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                PictureBox1.Image.Dispose()
                PictureBox1.Image = My.Resources.QuickLaunch_Logo32

            ElseIf startList.Contains(TextBox1.Text) Then
                Label1.Text = l("startmenu")
                Me.Text = "QuExeCute - " & l("startmenu")
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                PictureBox1.Image.Dispose()
                Dim wshLink, strPath, wshShell
                strPath = startLinks(startList.IndexOf(TextBox1.Text))
                wshShell = CreateObject("WScript.Shell")
                wshLink = wshShell.CreateShortcut(strPath)
                wshShell = Nothing
                PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(wshLink.TargetPath).ToBitmap

            ElseIf MathChecker.isMath(TextBox1.Text) Then
                Me.Text = "QuExeCute - Term"
                PictureBox1.Image.Dispose()
                PictureBox1.Image = My.Resources.calc
                Try
                    If MathChecker.isValid(TextBox1.Text) Then
                        Dim expr As New Expression(TextBox1.Text.ToLower.Replace(",", "."), EvaluateOptions.IgnoreCase + EvaluateOptions.RoundAwayFromZero)
                        expr.Parameters.Add("pi", Math.PI)
                        expr.Parameters.Add("tao", 2 * Math.PI)
                        expr.Parameters.Add("e", Math.E)

                        Label1.Text = expr.Evaluate()
                        Label1.ForeColor = Color.Black
                        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                    End If
                Catch ex As Exception
                    ExceptionTracker.TrackException(ex, False)
                End Try

            ElseIf URLChecker.isDomain(TextBox1.Text, 1) Then
                Label1.Text = l("title_openadress")
                Me.Text = "QuExeCute - " & l("title_openadress")
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                PictureBox1.Image.Dispose()
                PictureBox1.Image = FileTypeAndIcon.RegisteredFileType.ExtractIconFromFile(GetDefaultBrowser(), 1).ToBitmap

            ElseIf TextBox1.Text.Contains(".") Then ' fileTypesAndIcons.ContainsKey("." & TextBox1.Text.Split(".").Last()) And
                Label1.Text = l("title_openfile")
                Me.Text = "QuExeCute - " & l("title_openfile")
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                Try
                    If My.Computer.FileSystem.FileExists(TextBox1.Text) Then
                        PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(TextBox1.Text).ToBitmap 'fileTypesAndIcons("." & TextBox1.Text.Split(".").Last())
                    End If
                Catch
                End Try

            Else
                Me.Text = "QuExeCute - " & l("title_openpath")
                Label1.Text = l("title_openpath")
                Label1.Left = Me.Width - Label1.Width - 26 + WidthOffset
                PictureBox1.Image.Dispose()
                PictureBox1.Image = My.Resources.QuickLaunch_Logo32
            End If
        Catch ex As Exception
            Try
                PictureBox1.Image.Dispose()
                PictureBox1.Image = My.Resources.QuickLaunch_Logo32
            Catch ex2 As Exception

            End Try
        End Try

        Dim gtitle As Graphics = lblMsgText.CreateGraphics()
        Dim wtitle As Integer = Label1.Width

        Dim gtb As Graphics = lblMsgText.CreateGraphics()
        Dim wtb As Integer = TextBox1.Width
        If lblMsgText.Text <> "" Then
            wtb = CInt(gtb.MeasureString(TextBox1.Text, TextBox1.Font, TextBox1.Width).Width)
            gtb.Dispose()
        End If

        If TextBox1.Width - wtitle > wtb Then
            Label1.Show()
        Else
            Label1.Hide()
        End If

        Try
            doAutoComplete()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MainWindow_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox1.Image.Dispose()
        PictureBox1.Image = My.Resources.QuickLaunch_Logo32
    End Sub

    Private Sub MainWindow_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        If Not IsMsg And GetConfigValue("hideonfocuslose", "1") = "1" Then
            Me.Visible = False
        End If
    End Sub

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.CloseReason = CloseReason.WindowsShutDown Then
            e.Cancel = True
            Me.Visible = False
        Else
            UnregisterHotKey(Me.Handle, 1)
        End If
    End Sub

    Public Sub MainWindow_Load() Handles MyBase.Load
        If Not Debugger.IsAttached Then
            WidthOffset = +8
            WindowWidthOffset = -10
            HeightOffset = -9
            TopOffset = -3
        End If
        
        Me.Height = 94 + HeightOffset

        Initialize()

        If Environment.GetCommandLineArgs().Length > 1 Then
            AddExternalShortcut(Environment.GetCommandLineArgs(1))
        End If
    End Sub

    Public Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Opacity = GetConfigValue("opacity", 100) / 100
        Me.Visible = True
        Me.Activate()
    End Sub

    Private Sub MainWindow_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If Not IsMsg Then
            Me.Visible = False
        End If

        Updater.CheckForUpdates(False)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        UnregisterHotKey(Me.Handle, 1)
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub EingabefensterÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EingabefensterÖffnenToolStripMenuItem.Click
        HotKeys_HotKeyPressed("OpenWindow")
    End Sub

    Private Sub VerfügbareBegriffeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerfügbareBegriffeToolStripMenuItem.Click
        AvailableFunctions.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TickCount += 1
        If Not TickCount * Timer1.Interval > MS Then
            ProgressBar.Width = TickCount * (Timer1.Interval / MS) * Panel1.Width
        Else
            Timer1.Stop()
            ProgressBar.Hide()
            TickCount = 0

            ProgressBar.Width = Panel1.Width
            For i As Integer = Me.Height To 94 + HeightOffset Step -1
                Me.Height = i
                Threading.Thread.Sleep(1)
            Next

            IsMsg = False

            If ExitApp Then
                ExitApp = False
                Application.ExitThread()
                Application.Exit()
            End If
        End If
    End Sub

    Public Sub HotKeys_HotKeyPressed(ByVal HotKeyID As String)
        If Not Me.Visible Then
            Me.Opacity = GetConfigValue("opacity", 100) / 100
            Me.Visible = True
            Me.Activate()
        Else
            Me.Visible = False
        End If

        If xdoc.<appconfig>.<position>.Value() = "0" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Try
                Me.Top = -GetSystemMetrics(4) + TopOffset
            Catch ex As Exception
                Me.Top = -25 + TopOffset
            End Try
        End If

        Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Me.Visible = False
        Settings2.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ContextMenuStrip2.Show(PictureBox1, 0, PictureBox1.Height)
    End Sub

    Private Sub pbMsgIcon_Click(sender As System.Object, e As System.EventArgs) Handles pbMsgIcon.Click
        Timer1.Stop()
        ProgressBar.Hide()

        For i As Integer = Me.Height To 94 + HeightOffset Step -1
            Me.Height = i
            Threading.Thread.Sleep(1)
        Next

        If ExitApp Then
            Application.ExitThread()
            Application.Exit()
        End If
    End Sub

    Private Sub AufUpdatesPrüfenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AufUpdatesPrüfenToolStripMenuItem.Click
        Updater.CheckForUpdates(True)
    End Sub

    Private Sub OnlineHilfeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OnlineHilfeToolStripMenuItem.Click
        openWebsitePath("help") 'Process.Start("http://qc.leolabs.org/help/")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        TextBox1.Focus()
    End Sub
#End Region

#Region "Eigene Funktionen"
    Public Sub DoRestart()
        Application.Restart()
    End Sub

    Public Sub ExecuteProcess(ByVal ProcessPath, Optional ByVal AppGUID = "")
        PictureBox1.Image = My.Resources.QuickLaunch_Logo32

        Try
            Process.Start(doReplace(ProcessPath, "", AppGUID))
        Catch ex As Exception
            Try
                Shell(doReplace(ProcessPath, "", AppGUID), AppWinStyle.NormalFocus)
            Catch ex2 As Exception
                If GetConfigValue("defaultshortcut", "-1") <> "-1" Then
                    If ExecuteCommand(GetConfigValue("defaultshortcut", "-1"), ProcessPath, AppGUID) = False Then
                        ShowMsg(l("bubble_notfound_title"), l("bubble_notfound_text", ProcessPath), MsgIcon.Warning, False, 3000)
                    End If
                End If
            End Try
        End Try
    End Sub

    Public Function ExecuteCommand(ByVal Shortcut As String, Optional ByVal Arguments As String = "", Optional ByVal AppGUID As String = "") As Boolean
        PictureBox1.Image = My.Resources.QuickLaunch_Logo32

        If scdict.ContainsKey(Shortcut) Then
            If Not scdict(Shortcut).ExecPath.Contains("%guid%") Then
                Me.Visible = False
            End If

            Try
                If Not scdict(Shortcut).ExecPath = Nothing Then
                    Try
                        Process.Start(doReplace(scdict(Shortcut).ExecPath, Arguments, AppGUID))
                    Catch ex2 As Exception
                        Shell(doReplace(scdict(Shortcut).ExecPath, Arguments, AppGUID), AppWinStyle.NormalFocus)
                    End Try
                    TextBox1.Clear()
                Else
                    ShowMsg(l("msg_deffailtitle"), l("msg_nopathdefined"), MsgIcon.Warning)
                End If

                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Sub Initialize()
        logstr("[INFO] Initializing QuExecute...")

        'ShortcutDictionary leeren
        scdict.Clear()
        UnregisterHotKey(Me.Handle, 1)
        ContextMenuStrip1.Enabled = False
        ContextMenuStrip2.Enabled = False
        'Config Datei Laden
        ConfigPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\config.xml"
        Try
            If My.Computer.FileSystem.FileExists(ConfigPath) Then xdoc = XDocument.Load(ConfigPath) Else Shell(Application.StartupPath & "\QCToolset.exe /restoreConfig /s")
        Catch ex As Exception
            'ShowMsg(l("msg_deffailtitle"), l("msg_configloadfail"), MsgIcon.Critical, True, 5000)
        End Try

        'Einstellungen auslesen
        Try
            TextBox1.AutoCompleteMode = xdoc.<appconfig>.<autocompletemode>.Value()
            InitLang(xdoc.<appconfig>.<language>.Value())
            Me.Width = (xdoc.<appconfig>.<width>.Value()) + WindowWidthOffset
            TextBox1.Width = Me.Width - 70 + WidthOffset
            lblMsgText.Width = Me.Width - 70 + WidthOffset
            lblMsgTitle.Width = Me.Width - 70 + WidthOffset

            If xdoc.<appconfig>.<position>.Value() = "0" Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Try
                    Me.Top = -GetSystemMetrics(4) + TopOffset
                Catch ex As Exception
                    Me.Top = -25 + TopOffset
                    Throw ex
                End Try
            Else
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
                Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - Me.Height / 2
            End If
            Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2
            RegisterHotKey(Me.Handle, 1, xdoc.<appconfig>.<hkmods>.Value, xdoc.<appconfig>.<hotkey>.Value)
        Catch ex As Exception
            InitLang("EN")
            ShowMsg(l("msg_configerror_title"), l("msg_configerror_text"), MsgIcon.Critical, True, 5000)
            Exit Sub
        End Try

        'Verknüpfungen laden
        For Each sc As XElement In xdoc.<appconfig>.<shortcuts>.Elements()
            Try
                logstr("[INFO] Loading " & sc.Attribute("title").Value & "...")
                Dim regex As New Regex("%\((?<autocomplete>(.*))\)%")
                Dim ls As New List(Of String)
                For Each e As Match In regex.Matches(sc.Attribute("path"))
                    ls.AddRange(Split(e.Groups("autocomplete").Value, ","))
                Next

                scdict.Add(sc.Attribute("term").Value, New Shortcut With {.Title = sc.Attribute("title").Value, .Shortcut = sc.Attribute("term").Value.Replace(" ", ""), .IconPath = sc.Attribute("icon").Value, .ExecPath = regex.Replace(sc.Attribute("path"), ""), .AutoComplete = ls.ToArray})
            Catch ex As Exception
                ShowMsg(l("msg_scexists_title", sc.Attribute("term")), l("msg_scexists_text", sc.Attribute("term"), scdict(sc.Attribute("term")).Title), MsgIcon.Warning, False, 3000)
                scdict.Add(sc.Attribute("term").Value & " (2)", New Shortcut With {.Title = sc.Attribute("title"), .Shortcut = sc.Attribute("term"), .IconPath = sc.Attribute("icon"), .ExecPath = sc.Attribute("path")})
            End Try
        Next

        'DEBUG
        For Each s As Shortcut In scdict.Values
            Debug.Print(s.ExecPath & " - " & Join(s.AutoComplete, ", "))
        Next

        startList.Clear()
        startLinks.Clear()

        If GetConfigValue("populatestartmenu", "1") = "1" Then
            For Each File As String In My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Programs), FileIO.SearchOption.SearchAllSubDirectories)
                startList.Add("#" & My.Computer.FileSystem.GetName(File).Split(".")(0))
                startLinks.Add(File)
            Next

            For Each File As String In My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms), FileIO.SearchOption.SearchAllSubDirectories)
                startList.Add("#" & My.Computer.FileSystem.GetName(File).Split(".")(0))
                startLinks.Add(File)
            Next

            TextBox1.AutoCompleteCustomSource.AddRange(startList.ToArray)
        End If

        ContextMenuStrip2.Items.Clear()
        TextBox1.AutoCompleteCustomSource.Clear()

        For Each sc As MainWindow.Shortcut In scdict.Values
            Try
                If My.Computer.FileSystem.FileExists(doReplace(sc.IconPath)) Then
                    ContextMenuStrip2.Items.Add(sc.Shortcut & " - " & sc.Title, Image.FromFile(doReplace(sc.IconPath)), AddressOf SetInputBox)
                Else
                    ContextMenuStrip2.Items.Add(sc.Shortcut & " - " & sc.Title, Nothing, AddressOf SetInputBox)
                End If

                TextBox1.AutoCompleteCustomSource.Add(sc.Shortcut)
            Catch ex As Exception
                ExceptionTracker.TrackException(ex, False)
            End Try
        Next

        TextBox1_TextChanged("", Nothing)

        ContextMenuStrip2.Items.Add("-")

        ContextMenuStrip2.Items.Add(l("manage_shortcuts"), My.Resources.edit, AddressOf openShortcutEditor)

        EingabefensterÖffnenToolStripMenuItem.Text = l("m_opencmdwindow")
        VerfügbareBegriffeToolStripMenuItem.Text = l("m_available_commands")
        OnlineHilfeToolStripMenuItem.Text = l("m_onlinehelp")
        AufUpdatesPrüfenToolStripMenuItem.Text = l("m_checkupdates")
        EinstellungenToolStripMenuItem.Text = l("m_settings")
        BeendenToolStripMenuItem.Text = l("m_quit")
        HilfeToolStripMenuItem.Text = l("help")

        ContextMenuStrip1.Enabled = True
        ContextMenuStrip2.Enabled = True
    End Sub

    Public Sub openShortcutEditor()
        Settings2.Show()
        Settings2.TabControl1.SelectedTab = Settings2.tabShortcuts
    End Sub

    Public Sub openWebsitePath(ByVal SubPage As String)
        If GetConfigValue("language", "def").ToString.ToLower = "def" Then
            Process.Start("http://qc.leolabs.org/" & System.Globalization.CultureInfo.InstalledUICulture.TwoLetterISOLanguageName & "/" & SubPage)
        ElseIf GetConfigValue("language", "def").ToString.Length = 2 Then
            Process.Start("http://qc.leolabs.org/" & GetConfigValue("language", "en") & "/" & SubPage)
        End If
    End Sub

    Public Function GetDefaultBrowser() As String
        Dim browser As String = [String].Empty
        Dim key As Microsoft.Win32.RegistryKey = Nothing
        Dim Quote As String = Chr(34)
        Try

            key = My.Computer.Registry.ClassesRoot.OpenSubKey("HTTP\shell\open\command", False)

            ' trim off quotes
            browser = key.GetValue(Nothing).ToString().ToLower().Replace(Quote, "")
            If Not browser.EndsWith("exe") Then
                ' get rid of everything after the 'exe'
                browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4)

            End If

        Finally
            If key IsNot Nothing Then
                key.Close()
            End If
        End Try

        Return browser

    End Function

    ' Die Keyboard-Shortcuts abhören und auswerten
    Protected Overrides Sub WndProc(ByRef m As Message)
        'die messages auswerten
        If m.Msg = WM_HOTKEY Then
            'hier wird entschieden welcher hotkey es war
            'einfach die übergebene id auswerten
            Select Case m.WParam
                Case 1
                    HotKeys_HotKeyPressed("OpenWindow")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Public Shared Sub logstr(ByVal msg As String, Optional ByVal file As Integer = 1)
        Try
            If file = 1 Then
                My.Computer.FileSystem.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\quexecute.log", "[" & Date.Now.ToString & "] " & msg & vbCrLf, True)
            ElseIf file = 2 Then
                My.Computer.FileSystem.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\error.log", "[" & Date.Now.ToString & "] " & msg & vbCrLf, True)
            End If
        Catch ex As Exception
            ExceptionTracker.TrackException(ex, False)
        End Try
    End Sub

    Public Sub SetConfigValue(ByVal Value As String, ByVal val As Object)
        If xdoc.Element("appconfig").Descendants(Value).Any() Then
            xdoc.Element("appconfig").Element(Value).Value = val
        Else
            xdoc.Element("appconfig").AddFirst(New XElement(Value, val))
        End If
    End Sub

    Public Function GetConfigValue(ByVal Key As String, ByVal def As Object)
        Try
            Return xdoc.Element("appconfig").Element(Key).Value
        Catch ex As Exception
            Return def
        End Try
    End Function

    Private Sub doAutoComplete()
        Dim ls As New List(Of String)
        Dim t As String = doReplace(TextBox1.Text)
        Dim query As String = ""

        If Not TextBox1.AutoCompleteCustomSource.Contains(TextBox1.Text) Or lastInput = "" Then
            If scdict.Keys.Contains(t.Split(" ")(0)) Then
                If t.Contains("\") Then
                    query = doReplace(TextBox1.Text.Substring(TextBox1.Text.Split(" ")(0).Length + 1))
                    For Each e As String In My.Computer.FileSystem.GetDirectories(query.Substring(0, query.Length - query.Split("\")(UBound(query.Split("\"))).Length), FileIO.SearchOption.SearchTopLevelOnly)
                        ls.Add(t.Split(" ")(0) & " " & e)
                        ls.Add(t.Split(" ")(0) & " " & doReverseReplace(e))
                    Next
                    For Each e As String In My.Computer.FileSystem.GetFiles(query.Substring(0, query.Length - query.Split("\")(UBound(query.Split("\"))).Length), FileIO.SearchOption.SearchTopLevelOnly)
                        ls.Add(t.Split(" ")(0) & " " & e)
                        ls.Add(t.Split(" ")(0) & " " & doReverseReplace(e))
                    Next
                End If
            Else
                If t.Contains("\") Then
                    For Each e As String In My.Computer.FileSystem.GetDirectories(t.Substring(0, t.Length - t.Split("\")(UBound(t.Split("\"))).Length), FileIO.SearchOption.SearchTopLevelOnly)
                        ls.Add(e)
                        ls.Add(doReverseReplace(e))
                    Next
                    For Each e As String In My.Computer.FileSystem.GetFiles(t.Substring(0, t.Length - t.Split("\")(UBound(t.Split("\"))).Length), FileIO.SearchOption.SearchTopLevelOnly)
                        ls.Add(e)
                        ls.Add(doReverseReplace(e))
                    Next
                Else
                    ls.AddRange(scdict.Keys)
                End If
            End If

            For Each term As XElement In xdoc.<appconfig>.<history>.Descendants()
                ls.Add(term.Value)
            Next

            If scdict.Keys.Contains(t.Split(" ")(0)) Then
                For Each ac As String In scdict(t.Split(" ")(0)).AutoComplete
                    ls.Add(t.Split(" ")(0) & " " & ac)
                Next
            End If

            ls.AddRange(startList)
        End If

        If Not lastInput = TextBox1.Text Then
            If Not ls.Contains(t) And Not ls.Count = 0 Or lastInput = "" Then
                If TextBox1.Text.EndsWith(" ") Or TextBox1.Text.EndsWith("\") Or TextBox1.Text.EndsWith("/") Or TextBox1.Text.EndsWith("#") Or TextBox1.Text.Length = 1 Then
                    TextBox1.AutoCompleteCustomSource.Clear()
                    TextBox1.AutoCompleteCustomSource.AddRange(ls.ToArray)
                    lastInput = TextBox1.Text
                End If
            End If
        End If
        ls = Nothing

    End Sub

    Public Sub AddExternalShortcut(ByVal url As String)
        If url.StartsWith("quexecute://") Then
            If xdoc.<appconfig>.<acceptqllinks>.Value = True Then
                Try
                    Dim sc As Shortcut = decryptURL(url)

                    If MessageBox.Show(Me, l("msg_addwebsc_text", sc.Title, sc.Shortcut, sc.ExecPath, sc.IconPath), l("msg_addwebsc_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        AddWebShortcut.tbSCPath.Text = sc.ExecPath
                        AddWebShortcut.tbSCName.Text = sc.Title
                        AddWebShortcut.tbSCIconPath.Text = sc.IconPath
                        AddWebShortcut.tbSCCommand.Text = sc.Shortcut
                        AddWebShortcut.Show()
                    End If
                Catch ex As Exception
                    MsgBox(l("msg_addwebscfail_text"), MsgBoxStyle.Exclamation, l("msg_addwebscfail_title"))
                End Try
            End If
        ElseIf Environment.GetCommandLineArgs().Contains("/updateComplete") Then
            ShowMsg(l("msg_updatecomplete_title"), l("msg_updatecomplete_text", version, build), MsgIcon.Info, False, 10000)
        Else
            Settings2.Show()
        End If
    End Sub

    Public Function decryptURL(ByVal url As String)
        Dim args As String = doURLreplace(url)
        Dim sc As New Shortcut
        Dim argregex As New System.Text.RegularExpressions.Regex("^quexecute\://(?<title>(.*))/-/(?<shortcut>(.*))/-/(?<execpath>(.*))/-/(?<iconpath>(.*))/add(.{0,1})")
        If argregex.IsMatch(args) Then
            sc.Title = doURLreplace(argregex.Match(args).Groups("title").Value)
            sc.Shortcut = (argregex.Match(args).Groups("shortcut").Value)
            sc.ExecPath = (argregex.Match(args).Groups("execpath").Value)
            sc.IconPath = (argregex.Match(args).Groups("iconpath").Value)
            Return sc
        Else
            Throw New Exception("URL has wrong format! - " & url)
        End If
    End Function

    Public Function Autostart(ByVal AutostartEnable As Boolean)
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If AutostartEnable = True Then
            key.SetValue(My.Application.Info.AssemblyName, System.Reflection.Assembly.GetEntryAssembly.Location)
        Else
            key.DeleteValue(My.Application.Info.AssemblyName, False)
        End If
        key.Close()
        Return AutostartEnable
    End Function

    Public Function CheckAutostart()
        Dim regkey As RegistryKey = Nothing
        Dim value As Object = Nothing

        regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")

        value = regkey.GetValue(My.Application.Info.AssemblyName, "NOPE")

        If value.ToString = "NOPE" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function doReplace(ByVal inputString As String, Optional ByVal textbox As String = "", Optional ByVal guid As String = "")
        Dim str As String = inputString

        ' Lowercase the Variables for better Replacement
        Dim rg As New Regex("%(.*)%")

        For Each Match As Match In rg.Matches(inputString)
            str = str.Replace(Match.Value, Match.Value.ToLower)
        Next


        str = str.Replace("%mydocs%", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        str = str.Replace("%user%", Environment.GetFolderPath(Environment.SpecialFolder.Personal).Substring(0, System.Environment.GetFolderPath(Environment.SpecialFolder.Personal).Split("\")(UBound(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal).Split("\"))).Length - 1))

        Try
            str = str.Replace("%programfiles%", System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
        Catch ex As Exception
            str = str.Replace("%programfiles%", System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86))
            logstr("[ERROR] (Main, L473) Couldn't get FolderPath for SpecialFolder.ProgramFiles, using SpecialFolder.ProgramFilesX86 instead!", 2)
        End Try

        Try
            str = str.Replace("%programfilesx86%", System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86))
        Catch ex As Exception
            logstr("[ERROR] (Main, L479) Couldn't get FolderPath for SpecialFolder.ProgramFilesX86, continuing!", 2)
        End Try

        str = str.Replace("%windows%", System.Environment.GetFolderPath(Environment.SpecialFolder.Windows))

        str = str.Replace("%query%", textbox)
        str = str.Replace("%querywplus%", URLEncode(textbox, True))
        str = str.Replace("%iconpath%", System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\icons")
        str = str.Replace("%execpath%", """" & Application.ExecutablePath & """")
        str = str.Replace("%guid%", guid)

        'ENVIRONMENT VARIABLES
        str = str.Replace("%appdata%", Environ("APPDATA"))
        str = str.Replace("%windir%", Environ("WINDIR"))
        str = str.Replace("%temp%", Environ("TEMP"))
        str = str.Replace("%tmp%", Environ("TMP"))
        str = str.Replace("%comspec%", Environ("COMSPEC"))
        Return str
    End Function

    Public Function doReverseReplace(ByVal inputString As String, Optional ByVal textbox As String = "Query")
        Dim str As String = inputString

        str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuExeCute\icons", "%iconpath%")
        str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "%mydocs%")
        str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal).Substring(0, System.Environment.GetFolderPath(Environment.SpecialFolder.Personal).Split("\")(UBound(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal).Split("\"))).Length - 1), "%user%")

        'ENVIRONMENT VARIABLES
        str = str.Replace(Environ("APPDATA"), "%appdata%")
        str = str.Replace(Environ("WINDIR"), "%windir%")
        str = str.Replace(Environ("TEMP"), "%temp%")
        str = str.Replace(Environ("TMP"), "%tmp%")
        str = str.Replace(Environ("COMSPEC"), "%comspec%")

        Try
            str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "%programfiles%")
        Catch ex As Exception
            logstr("[ERROR] (Main, L498) Couldn't get FolderPath for SpecialFolder.ProgramFiles, continuing!", 2)
        End Try

        Try
            str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "%programfilesx86%")
        Catch ex As Exception
            logstr("[ERROR] (Main, L504) Couldn't get FolderPath for SpecialFolder.ProgramFiles, continuing!", 2)
        End Try
        str = str.Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.Windows), "%windows%")
        str = str.Replace("""" & Application.ExecutablePath & """", "%execpath%")

        Return str
    End Function

    Public Function doURLreplace(StringToDecode As String) As String
        Dim TempAns As String = ""
        Dim CurChr As Integer

        CurChr = 1
        Do Until CurChr - 1 = Len(StringToDecode)
            Select Case Mid$(StringToDecode, CurChr, 1)
                Case "+"
                    TempAns = TempAns & " "
                Case "%"
                    TempAns = TempAns & Chr(Val("&h" & _
                      Mid$(StringToDecode, CurChr + 1, 2)))
                    CurChr = CurChr + 2
                Case Else
                    TempAns = TempAns & Mid$(StringToDecode, CurChr, 1)
            End Select
            CurChr = CurChr + 1
        Loop
        doURLreplace = TempAns
    End Function

    Public Function URLEncode(StringToEncode As String, Optional UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String = Nothing
        Dim CurChr As Integer

        CurChr = 1
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid$(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid$(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    TempAns = TempAns & "%" & Hex(Asc(Mid$(StringToEncode, _
                      CurChr, 1)))
            End Select
            CurChr = CurChr + 1
        Loop
        URLEncode = TempAns
    End Function

    Public Sub ShowMsg(ByVal title As String, ByVal msg As String, Optional ByVal icon As MsgIcon = MsgIcon.Info, Optional ByVal quitapp As Boolean = False, Optional ByVal timeout As Integer = 3000)
        Try
            IsMsg = True
            Me.Visible = True
            Me.Opacity = GetConfigValue("opacity", 100)

            TickCount = 0
            MS = timeout

            Timer1.Stop()

            ExitApp = quitapp

            lblMsgText.Text = msg
            lblMsgTitle.Text = title

            Select Case icon
                Case MsgIcon.Warning
                    pbMsgIcon.Image = My.Resources.img_warning
                Case MsgIcon.Info
                    pbMsgIcon.Image = My.Resources.img_info
                Case MsgIcon.Critical
                    pbMsgIcon.Image = My.Resources.img_error
                Case Else
                    pbMsgIcon.Image = My.Resources.img_info
            End Select

            Dim g As Graphics = lblMsgText.CreateGraphics()
            If lblMsgText.Text <> "" Then
                lblMsgText.Height = CInt(g.MeasureString(lblMsgText.Text, lblMsgText.Font, lblMsgText.Width).Height)
                g.Dispose()
            End If

            lblMsgText.Invalidate()
            lblMsgTitle.Invalidate()
            pbMsgIcon.Invalidate()

            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow Then
                Me.Height = 94 + 30 + lblMsgText.Height + HeightOffset
            Else
                Me.Height = 94 + 35 + lblMsgText.Height + HeightOffset
            End If

            ProgressBar.Visible = True

            Timer1.Start()
            logstr("[MESSAGE] " & title & " - " & msg)
        Catch ex As Exception
            logstr("[ERROR] (Main, L521) Couldn't get FolderPath for SpecialFolder.ProgramFiles, continuing!", 2)
            MsgBox(msg, MsgBoxStyle.Information, title)
        End Try
    End Sub

    Public Sub SetInputBox(ByVal sender As Object, ByVal e As System.EventArgs)
        TextBox1.Text = sender.ToString.Split("-")(0)
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    Public Function getFavicon(ByVal path As String)
        Dim iconURL = "http://www.google.com/s2/u/0/favicons?domain=" & path
        Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim stream As System.IO.Stream = response.GetResponseStream()
        Dim favicon = Image.FromStream(stream)

        Return favicon
    End Function
#End Region
End Class