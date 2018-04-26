<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbOpenSimpleURLs = New System.Windows.Forms.CheckBox()
        Me.lblOpenSimpleURLs = New System.Windows.Forms.Label()
        Me.lbStdShortcut = New System.Windows.Forms.Label()
        Me.lblHotkey = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.lblAutocomplete = New System.Windows.Forms.Label()
        Me.ctlAutocomplete = New System.Windows.Forms.ComboBox()
        Me.ctlLanguage = New System.Windows.Forms.ComboBox()
        Me.ctlHotKey = New System.Windows.Forms.Button()
        Me.lblAutostart = New System.Windows.Forms.Label()
        Me.ctlAutostart = New System.Windows.Forms.CheckBox()
        Me.ctlOpenLinks = New System.Windows.Forms.CheckBox()
        Me.lblOpenLinks = New System.Windows.Forms.Label()
        Me.cbStdShortcut = New System.Windows.Forms.ComboBox()
        Me.tabCommandWindow = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPopulateStartMenu = New System.Windows.Forms.Label()
        Me.lblHideCommandwindow = New System.Windows.Forms.Label()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ctlTransparency = New System.Windows.Forms.TrackBar()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.ctlPosition = New System.Windows.Forms.ComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ctlWidth = New System.Windows.Forms.NumericUpDown()
        Me.ctlCloseCommandwindow = New System.Windows.Forms.CheckBox()
        Me.ctlPopulateStartMenu = New System.Windows.Forms.CheckBox()
        Me.tabShortcuts = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tsBarSC = New System.Windows.Forms.ToolStrip()
        Me.btnSCAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnSCDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSCGetOnline = New System.Windows.Forms.ToolStripButton()
        Me.btnSCEdit = New System.Windows.Forms.ToolStripButton()
        Me.tabTools = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.gbConfigFile = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTSRestoreConfig = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.gbQLProtocol = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTSRemoveProtocol = New System.Windows.Forms.Button()
        Me.btnTSRegisterProtocol = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.gbAutostart = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTSRemoveAutostart = New System.Windows.Forms.Button()
        Me.btnTSAddAutostart = New System.Windows.Forms.Button()
        Me.lblQLToolsetIntro = New System.Windows.Forms.Label()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbCredits = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.ctlForum = New System.Windows.Forms.Button()
        Me.ctlWebsite = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlGenral = New System.Windows.Forms.Panel()
        Me.pnlShortcuts = New System.Windows.Forms.Panel()
        Me.ctlOpenConfig = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabCommandWindow.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ctlTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctlWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShortcuts.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.tsBarSC.SuspendLayout()
        Me.tabTools.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.gbConfigFile.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.gbQLProtocol.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.gbAutostart.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlShortcuts.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabCommandWindow)
        Me.TabControl1.Controls.Add(Me.tabShortcuts)
        Me.TabControl1.Controls.Add(Me.tabTools)
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 317)
        Me.TabControl1.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.TableLayoutPanel1)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(434, 291)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "Allgemein"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbOpenSimpleURLs, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOpenSimpleURLs, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbStdShortcut, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHotkey, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLanguage, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAutocomplete, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ctlAutocomplete, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ctlLanguage, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ctlHotKey, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAutostart, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ctlAutostart, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ctlOpenLinks, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOpenLinks, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbStdShortcut, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 285)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbOpenSimpleURLs
        '
        Me.cbOpenSimpleURLs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbOpenSimpleURLs.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbOpenSimpleURLs.Location = New System.Drawing.Point(217, 83)
        Me.cbOpenSimpleURLs.Name = "cbOpenSimpleURLs"
        Me.cbOpenSimpleURLs.Size = New System.Drawing.Size(208, 24)
        Me.cbOpenSimpleURLs.TabIndex = 20
        Me.cbOpenSimpleURLs.Text = "Öffne einfache URLs im Browser"
        Me.cbOpenSimpleURLs.UseVisualStyleBackColor = True
        '
        'lblOpenSimpleURLs
        '
        Me.lblOpenSimpleURLs.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOpenSimpleURLs.Location = New System.Drawing.Point(3, 80)
        Me.lblOpenSimpleURLs.Name = "lblOpenSimpleURLs"
        Me.lblOpenSimpleURLs.Size = New System.Drawing.Size(208, 23)
        Me.lblOpenSimpleURLs.TabIndex = 19
        Me.lblOpenSimpleURLs.Text = "Einfache URLs im Browser öffnen:"
        Me.lblOpenSimpleURLs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStdShortcut
        '
        Me.lbStdShortcut.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbStdShortcut.Location = New System.Drawing.Point(3, 120)
        Me.lbStdShortcut.Name = "lbStdShortcut"
        Me.lbStdShortcut.Size = New System.Drawing.Size(208, 23)
        Me.lbStdShortcut.TabIndex = 17
        Me.lbStdShortcut.Text = "Standard-Shortcut:"
        Me.lbStdShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHotkey
        '
        Me.lblHotkey.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHotkey.Location = New System.Drawing.Point(3, 240)
        Me.lblHotkey.Name = "lblHotkey"
        Me.lblHotkey.Size = New System.Drawing.Size(208, 24)
        Me.lblHotkey.TabIndex = 11
        Me.lblHotkey.Text = "Hotkey zum Öffnen des Hauptfensters:"
        Me.lblHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLanguage
        '
        Me.lblLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLanguage.Location = New System.Drawing.Point(3, 200)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(208, 24)
        Me.lblLanguage.TabIndex = 10
        Me.lblLanguage.Text = "Sprache:"
        Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAutocomplete
        '
        Me.lblAutocomplete.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAutocomplete.Location = New System.Drawing.Point(3, 160)
        Me.lblAutocomplete.Name = "lblAutocomplete"
        Me.lblAutocomplete.Size = New System.Drawing.Size(208, 24)
        Me.lblAutocomplete.TabIndex = 6
        Me.lblAutocomplete.Text = "Autovervollständigungs-Modus:"
        Me.lblAutocomplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctlAutocomplete
        '
        Me.ctlAutocomplete.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlAutocomplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctlAutocomplete.FormattingEnabled = True
        Me.ctlAutocomplete.Location = New System.Drawing.Point(217, 163)
        Me.ctlAutocomplete.Name = "ctlAutocomplete"
        Me.ctlAutocomplete.Size = New System.Drawing.Size(208, 21)
        Me.ctlAutocomplete.TabIndex = 3
        '
        'ctlLanguage
        '
        Me.ctlLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctlLanguage.FormattingEnabled = True
        Me.ctlLanguage.Items.AddRange(New Object() {"System", "Deutsch", "English"})
        Me.ctlLanguage.Location = New System.Drawing.Point(217, 203)
        Me.ctlLanguage.Name = "ctlLanguage"
        Me.ctlLanguage.Size = New System.Drawing.Size(208, 21)
        Me.ctlLanguage.TabIndex = 4
        '
        'ctlHotKey
        '
        Me.ctlHotKey.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlHotKey.Location = New System.Drawing.Point(217, 243)
        Me.ctlHotKey.Name = "ctlHotKey"
        Me.ctlHotKey.Size = New System.Drawing.Size(208, 23)
        Me.ctlHotKey.TabIndex = 12
        Me.ctlHotKey.Text = "Festlegen"
        Me.ctlHotKey.UseVisualStyleBackColor = True
        '
        'lblAutostart
        '
        Me.lblAutostart.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAutostart.Location = New System.Drawing.Point(3, 0)
        Me.lblAutostart.Name = "lblAutostart"
        Me.lblAutostart.Size = New System.Drawing.Size(208, 37)
        Me.lblAutostart.TabIndex = 13
        Me.lblAutostart.Text = "Autostart:"
        Me.lblAutostart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctlAutostart
        '
        Me.ctlAutostart.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlAutostart.Location = New System.Drawing.Point(217, 3)
        Me.ctlAutostart.Name = "ctlAutostart"
        Me.ctlAutostart.Size = New System.Drawing.Size(208, 34)
        Me.ctlAutostart.TabIndex = 14
        Me.ctlAutostart.Text = "QuickLaunch mit Windows Starten"
        Me.ctlAutostart.UseVisualStyleBackColor = True
        '
        'ctlOpenLinks
        '
        Me.ctlOpenLinks.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlOpenLinks.Location = New System.Drawing.Point(217, 43)
        Me.ctlOpenLinks.Name = "ctlOpenLinks"
        Me.ctlOpenLinks.Size = New System.Drawing.Size(208, 24)
        Me.ctlOpenLinks.TabIndex = 16
        Me.ctlOpenLinks.Text = "Auf QuickLaunch-Links reagieren"
        Me.ctlOpenLinks.UseVisualStyleBackColor = True
        '
        'lblOpenLinks
        '
        Me.lblOpenLinks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOpenLinks.Location = New System.Drawing.Point(3, 40)
        Me.lblOpenLinks.Name = "lblOpenLinks"
        Me.lblOpenLinks.Size = New System.Drawing.Size(208, 23)
        Me.lblOpenLinks.TabIndex = 15
        Me.lblOpenLinks.Text = "QuickLaunch-Links akzeptieren:"
        Me.lblOpenLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbStdShortcut
        '
        Me.cbStdShortcut.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbStdShortcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStdShortcut.FormattingEnabled = True
        Me.cbStdShortcut.Location = New System.Drawing.Point(217, 123)
        Me.cbStdShortcut.Name = "cbStdShortcut"
        Me.cbStdShortcut.Size = New System.Drawing.Size(208, 21)
        Me.cbStdShortcut.TabIndex = 18
        '
        'tabCommandWindow
        '
        Me.tabCommandWindow.Controls.Add(Me.TableLayoutPanel2)
        Me.tabCommandWindow.Location = New System.Drawing.Point(4, 22)
        Me.tabCommandWindow.Name = "tabCommandWindow"
        Me.tabCommandWindow.Size = New System.Drawing.Size(434, 291)
        Me.tabCommandWindow.TabIndex = 3
        Me.tabCommandWindow.Text = "Eingabefenster"
        Me.tabCommandWindow.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblPopulateStartMenu, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHideCommandwindow, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTransparency, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ctlTransparency, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPosition, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ctlPosition, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblWidth, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ctlWidth, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ctlCloseCommandwindow, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ctlPopulateStartMenu, 1, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(434, 291)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblPopulateStartMenu
        '
        Me.lblPopulateStartMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPopulateStartMenu.Location = New System.Drawing.Point(8, 231)
        Me.lblPopulateStartMenu.Name = "lblPopulateStartMenu"
        Me.lblPopulateStartMenu.Size = New System.Drawing.Size(206, 41)
        Me.lblPopulateStartMenu.TabIndex = 18
        Me.lblPopulateStartMenu.Text = "Programme aus dem Startmenü automatisch hinzufügen:"
        Me.lblPopulateStartMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHideCommandwindow
        '
        Me.lblHideCommandwindow.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHideCommandwindow.Location = New System.Drawing.Point(8, 177)
        Me.lblHideCommandwindow.Name = "lblHideCommandwindow"
        Me.lblHideCommandwindow.Size = New System.Drawing.Size(206, 41)
        Me.lblHideCommandwindow.TabIndex = 16
        Me.lblHideCommandwindow.Text = "Eingabefenster schließen, wenn es den Fokus verliert:"
        Me.lblHideCommandwindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransparency
        '
        Me.lblTransparency.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTransparency.Location = New System.Drawing.Point(8, 15)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(206, 35)
        Me.lblTransparency.TabIndex = 6
        Me.lblTransparency.Text = "Transparenz des Hauptfensters:"
        Me.lblTransparency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctlTransparency
        '
        Me.ctlTransparency.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ctlTransparency.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlTransparency.LargeChange = 10
        Me.ctlTransparency.Location = New System.Drawing.Point(220, 18)
        Me.ctlTransparency.Maximum = 100
        Me.ctlTransparency.Name = "ctlTransparency"
        Me.ctlTransparency.Size = New System.Drawing.Size(206, 45)
        Me.ctlTransparency.TabIndex = 5
        Me.ctlTransparency.TickFrequency = 10
        '
        'lblPosition
        '
        Me.lblPosition.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPosition.Location = New System.Drawing.Point(8, 69)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(206, 24)
        Me.lblPosition.TabIndex = 8
        Me.lblPosition.Text = "Position des Hauptfensters:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctlPosition
        '
        Me.ctlPosition.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctlPosition.FormattingEnabled = True
        Me.ctlPosition.Location = New System.Drawing.Point(220, 72)
        Me.ctlPosition.Name = "ctlPosition"
        Me.ctlPosition.Size = New System.Drawing.Size(206, 21)
        Me.ctlPosition.TabIndex = 7
        '
        'lblWidth
        '
        Me.lblWidth.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWidth.Location = New System.Drawing.Point(8, 123)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(206, 23)
        Me.lblWidth.TabIndex = 10
        Me.lblWidth.Text = "Breite des Hauptfensters:"
        Me.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctlWidth
        '
        Me.ctlWidth.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlWidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ctlWidth.Location = New System.Drawing.Point(220, 126)
        Me.ctlWidth.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.ctlWidth.Minimum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.ctlWidth.Name = "ctlWidth"
        Me.ctlWidth.Size = New System.Drawing.Size(206, 20)
        Me.ctlWidth.TabIndex = 15
        Me.ctlWidth.Value = New Decimal(New Integer() {350, 0, 0, 0})
        '
        'ctlCloseCommandwindow
        '
        Me.ctlCloseCommandwindow.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlCloseCommandwindow.Location = New System.Drawing.Point(220, 180)
        Me.ctlCloseCommandwindow.Name = "ctlCloseCommandwindow"
        Me.ctlCloseCommandwindow.Size = New System.Drawing.Size(206, 38)
        Me.ctlCloseCommandwindow.TabIndex = 17
        Me.ctlCloseCommandwindow.UseVisualStyleBackColor = True
        '
        'ctlPopulateStartMenu
        '
        Me.ctlPopulateStartMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlPopulateStartMenu.Location = New System.Drawing.Point(220, 234)
        Me.ctlPopulateStartMenu.Name = "ctlPopulateStartMenu"
        Me.ctlPopulateStartMenu.Size = New System.Drawing.Size(206, 38)
        Me.ctlPopulateStartMenu.TabIndex = 19
        Me.ctlPopulateStartMenu.UseVisualStyleBackColor = True
        '
        'tabShortcuts
        '
        Me.tabShortcuts.Controls.Add(Me.ToolStripContainer1)
        Me.tabShortcuts.Location = New System.Drawing.Point(4, 22)
        Me.tabShortcuts.Name = "tabShortcuts"
        Me.tabShortcuts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShortcuts.Size = New System.Drawing.Size(434, 291)
        Me.tabShortcuts.TabIndex = 1
        Me.tabShortcuts.Text = "Shortcuts"
        Me.tabShortcuts.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ListView1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(428, 285)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(428, 285)
        Me.ToolStripContainer1.TabIndex = 3
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tsBarSC)
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(428, 285)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Shortcut"
        Me.ColumnHeader2.Width = 52
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Pfad"
        Me.ColumnHeader3.Width = 255
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'tsBarSC
        '
        Me.tsBarSC.BackColor = System.Drawing.Color.White
        Me.tsBarSC.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBarSC.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBarSC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSCAdd, Me.btnSCDelete, Me.btnSCGetOnline, Me.btnSCEdit})
        Me.tsBarSC.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsBarSC.Location = New System.Drawing.Point(0, 0)
        Me.tsBarSC.Name = "tsBarSC"
        Me.tsBarSC.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBarSC.Size = New System.Drawing.Size(282, 25)
        Me.tsBarSC.Stretch = True
        Me.tsBarSC.TabIndex = 2
        Me.tsBarSC.Visible = False
        '
        'btnSCAdd
        '
        Me.btnSCAdd.Image = Global.QuExeCute.My.Resources.Resources.add
        Me.btnSCAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSCAdd.Name = "btnSCAdd"
        Me.btnSCAdd.Size = New System.Drawing.Size(49, 22)
        Me.btnSCAdd.Text = "Add"
        '
        'btnSCDelete
        '
        Me.btnSCDelete.Image = Global.QuExeCute.My.Resources.Resources.delete
        Me.btnSCDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSCDelete.Name = "btnSCDelete"
        Me.btnSCDelete.Size = New System.Drawing.Size(60, 22)
        Me.btnSCDelete.Text = "Delete"
        '
        'btnSCGetOnline
        '
        Me.btnSCGetOnline.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSCGetOnline.Image = Global.QuExeCute.My.Resources.Resources.group
        Me.btnSCGetOnline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSCGetOnline.Name = "btnSCGetOnline"
        Me.btnSCGetOnline.Size = New System.Drawing.Size(123, 22)
        Me.btnSCGetOnline.Text = "Get new Shortcuts"
        '
        'btnSCEdit
        '
        Me.btnSCEdit.Image = Global.QuExeCute.My.Resources.Resources.edit
        Me.btnSCEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSCEdit.Name = "btnSCEdit"
        Me.btnSCEdit.Size = New System.Drawing.Size(47, 22)
        Me.btnSCEdit.Text = "Edit"
        '
        'tabTools
        '
        Me.tabTools.Controls.Add(Me.Panel7)
        Me.tabTools.Controls.Add(Me.lblQLToolsetIntro)
        Me.tabTools.Location = New System.Drawing.Point(4, 22)
        Me.tabTools.Name = "tabTools"
        Me.tabTools.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTools.Size = New System.Drawing.Size(434, 291)
        Me.tabTools.TabIndex = 4
        Me.tabTools.Text = "Tools"
        Me.tabTools.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.Controls.Add(Me.gbConfigFile)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.gbQLProtocol)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.gbAutostart)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 61)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(428, 227)
        Me.Panel7.TabIndex = 1
        '
        'gbConfigFile
        '
        Me.gbConfigFile.Controls.Add(Me.TableLayoutPanel5)
        Me.gbConfigFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbConfigFile.Location = New System.Drawing.Point(5, 157)
        Me.gbConfigFile.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gbConfigFile.Name = "gbConfigFile"
        Me.gbConfigFile.Padding = New System.Windows.Forms.Padding(8)
        Me.gbConfigFile.Size = New System.Drawing.Size(418, 61)
        Me.gbConfigFile.TabIndex = 3
        Me.gbConfigFile.TabStop = False
        Me.gbConfigFile.Text = "Konfigurationsdatei"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnTSRestoreConfig, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(8, 21)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(402, 32)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnTSRestoreConfig
        '
        Me.btnTSRestoreConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTSRestoreConfig.Location = New System.Drawing.Point(3, 3)
        Me.btnTSRestoreConfig.Name = "btnTSRestoreConfig"
        Me.btnTSRestoreConfig.Size = New System.Drawing.Size(396, 26)
        Me.btnTSRestoreConfig.TabIndex = 1
        Me.btnTSRestoreConfig.Text = "Wiederherstellen"
        Me.btnTSRestoreConfig.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(5, 142)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(418, 15)
        Me.Panel9.TabIndex = 4
        '
        'gbQLProtocol
        '
        Me.gbQLProtocol.Controls.Add(Me.TableLayoutPanel4)
        Me.gbQLProtocol.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbQLProtocol.Location = New System.Drawing.Point(5, 81)
        Me.gbQLProtocol.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gbQLProtocol.Name = "gbQLProtocol"
        Me.gbQLProtocol.Padding = New System.Windows.Forms.Padding(8)
        Me.gbQLProtocol.Size = New System.Drawing.Size(418, 61)
        Me.gbQLProtocol.TabIndex = 1
        Me.gbQLProtocol.TabStop = False
        Me.gbQLProtocol.Text = "QuickLaunch-Protokoll"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnTSRemoveProtocol, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnTSRegisterProtocol, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(8, 21)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(402, 32)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btnTSRemoveProtocol
        '
        Me.btnTSRemoveProtocol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTSRemoveProtocol.Location = New System.Drawing.Point(204, 3)
        Me.btnTSRemoveProtocol.Name = "btnTSRemoveProtocol"
        Me.btnTSRemoveProtocol.Size = New System.Drawing.Size(195, 26)
        Me.btnTSRemoveProtocol.TabIndex = 0
        Me.btnTSRemoveProtocol.Text = "QuickLaunch Protokoll entfernen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnTSRemoveProtocol.UseVisualStyleBackColor = True
        '
        'btnTSRegisterProtocol
        '
        Me.btnTSRegisterProtocol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTSRegisterProtocol.Location = New System.Drawing.Point(3, 3)
        Me.btnTSRegisterProtocol.Name = "btnTSRegisterProtocol"
        Me.btnTSRegisterProtocol.Size = New System.Drawing.Size(195, 26)
        Me.btnTSRegisterProtocol.TabIndex = 1
        Me.btnTSRegisterProtocol.Text = "QuickLaunch Protokoll registrieren"
        Me.btnTSRegisterProtocol.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(5, 66)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(418, 15)
        Me.Panel8.TabIndex = 2
        '
        'gbAutostart
        '
        Me.gbAutostart.Controls.Add(Me.TableLayoutPanel3)
        Me.gbAutostart.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbAutostart.Location = New System.Drawing.Point(5, 5)
        Me.gbAutostart.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gbAutostart.Name = "gbAutostart"
        Me.gbAutostart.Padding = New System.Windows.Forms.Padding(8)
        Me.gbAutostart.Size = New System.Drawing.Size(418, 61)
        Me.gbAutostart.TabIndex = 0
        Me.gbAutostart.TabStop = False
        Me.gbAutostart.Text = "Autostart (wenn möglich, bitte unter ""Allgemein"" ändern)"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnTSRemoveAutostart, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTSAddAutostart, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 21)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(402, 32)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnTSRemoveAutostart
        '
        Me.btnTSRemoveAutostart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTSRemoveAutostart.Location = New System.Drawing.Point(204, 3)
        Me.btnTSRemoveAutostart.Name = "btnTSRemoveAutostart"
        Me.btnTSRemoveAutostart.Size = New System.Drawing.Size(195, 26)
        Me.btnTSRemoveAutostart.TabIndex = 0
        Me.btnTSRemoveAutostart.Text = "Aus dem Autostart entfernen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnTSRemoveAutostart.UseVisualStyleBackColor = True
        '
        'btnTSAddAutostart
        '
        Me.btnTSAddAutostart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTSAddAutostart.Location = New System.Drawing.Point(3, 3)
        Me.btnTSAddAutostart.Name = "btnTSAddAutostart"
        Me.btnTSAddAutostart.Size = New System.Drawing.Size(195, 26)
        Me.btnTSAddAutostart.TabIndex = 1
        Me.btnTSAddAutostart.Text = "In den Autostart eintragen"
        Me.btnTSAddAutostart.UseVisualStyleBackColor = True
        '
        'lblQLToolsetIntro
        '
        Me.lblQLToolsetIntro.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQLToolsetIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLToolsetIntro.Location = New System.Drawing.Point(3, 3)
        Me.lblQLToolsetIntro.Name = "lblQLToolsetIntro"
        Me.lblQLToolsetIntro.Padding = New System.Windows.Forms.Padding(5)
        Me.lblQLToolsetIntro.Size = New System.Drawing.Size(428, 58)
        Me.lblQLToolsetIntro.TabIndex = 0
        Me.lblQLToolsetIntro.Text = resources.GetString("lblQLToolsetIntro.Text")
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.Panel2)
        Me.tabAbout.Controls.Add(Me.Panel1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(434, 291)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "Info/Credits"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbCredits)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(131, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(300, 285)
        Me.Panel2.TabIndex = 2
        '
        'tbCredits
        '
        Me.tbCredits.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCredits.Location = New System.Drawing.Point(10, 50)
        Me.tbCredits.Multiline = True
        Me.tbCredits.Name = "tbCredits"
        Me.tbCredits.ReadOnly = True
        Me.tbCredits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCredits.ShortcutsEnabled = False
        Me.tbCredits.Size = New System.Drawing.Size(280, 190)
        Me.tbCredits.TabIndex = 2
        Me.tbCredits.Text = resources.GetString("tbCredits.Text")
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(280, 10)
        Me.Panel6.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnHelp)
        Me.Panel5.Controls.Add(Me.ctlForum)
        Me.Panel5.Controls.Add(Me.ctlWebsite)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 250)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(280, 25)
        Me.Panel5.TabIndex = 2
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHelp.Location = New System.Drawing.Point(130, 0)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 25)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'ctlForum
        '
        Me.ctlForum.Dock = System.Windows.Forms.DockStyle.Right
        Me.ctlForum.Location = New System.Drawing.Point(205, 0)
        Me.ctlForum.Name = "ctlForum"
        Me.ctlForum.Size = New System.Drawing.Size(75, 25)
        Me.ctlForum.TabIndex = 1
        Me.ctlForum.Text = "Forum"
        Me.ctlForum.UseVisualStyleBackColor = True
        '
        'ctlWebsite
        '
        Me.ctlWebsite.Dock = System.Windows.Forms.DockStyle.Left
        Me.ctlWebsite.Location = New System.Drawing.Point(0, 0)
        Me.ctlWebsite.Name = "ctlWebsite"
        Me.ctlWebsite.Size = New System.Drawing.Size(75, 25)
        Me.ctlWebsite.TabIndex = 0
        Me.ctlWebsite.Text = "Website"
        Me.ctlWebsite.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 10)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblVersion)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 30)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "developed by Leo Bernard"
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVersion.Location = New System.Drawing.Point(0, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(280, 13)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "QuExeCute - Version 1.6 Beta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel1.Size = New System.Drawing.Size(128, 285)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.QuExeCute.My.Resources.Resources.Avatar_128
        Me.PictureBox2.Location = New System.Drawing.Point(0, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.QuExeCute.My.Resources.Resources.QuickLaunch_Logo512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlGenral
        '
        Me.pnlGenral.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlGenral.Location = New System.Drawing.Point(10, 327)
        Me.pnlGenral.Name = "pnlGenral"
        Me.pnlGenral.Size = New System.Drawing.Size(442, 10)
        Me.pnlGenral.TabIndex = 1
        '
        'pnlShortcuts
        '
        Me.pnlShortcuts.Controls.Add(Me.ctlOpenConfig)
        Me.pnlShortcuts.Controls.Add(Me.btnCancel)
        Me.pnlShortcuts.Controls.Add(Me.btnAccept)
        Me.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlShortcuts.Location = New System.Drawing.Point(10, 337)
        Me.pnlShortcuts.Name = "pnlShortcuts"
        Me.pnlShortcuts.Size = New System.Drawing.Size(442, 25)
        Me.pnlShortcuts.TabIndex = 2
        '
        'ctlOpenConfig
        '
        Me.ctlOpenConfig.Location = New System.Drawing.Point(0, 0)
        Me.ctlOpenConfig.Name = "ctlOpenConfig"
        Me.ctlOpenConfig.Size = New System.Drawing.Size(165, 25)
        Me.ctlOpenConfig.TabIndex = 2
        Me.ctlOpenConfig.Text = "Advanced: Open config.xml"
        Me.ctlOpenConfig.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(276, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccept.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAccept.Location = New System.Drawing.Point(359, 0)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(83, 25)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "OK"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'Settings2
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(462, 372)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlGenral)
        Me.Controls.Add(Me.pnlShortcuts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(470, 406)
        Me.Name = "Settings2"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabCommandWindow.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ctlTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctlWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShortcuts.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.tsBarSC.ResumeLayout(False)
        Me.tsBarSC.PerformLayout()
        Me.tabTools.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.gbConfigFile.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.gbQLProtocol.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.gbAutostart.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlShortcuts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabShortcuts As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlGenral As System.Windows.Forms.Panel
    Friend WithEvents pnlShortcuts As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents lblAutocomplete As System.Windows.Forms.Label
    Friend WithEvents ctlAutocomplete As System.Windows.Forms.ComboBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents ctlLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCredits As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHotkey As System.Windows.Forms.Label
    Friend WithEvents ctlHotKey As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tsBarSC As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSCAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSCDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSCGetOnline As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblAutostart As System.Windows.Forms.Label
    Friend WithEvents ctlAutostart As System.Windows.Forms.CheckBox
    Friend WithEvents ctlOpenConfig As System.Windows.Forms.Button
    Friend WithEvents btnSCEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ctlForum As System.Windows.Forms.Button
    Friend WithEvents ctlWebsite As System.Windows.Forms.Button
    Friend WithEvents tabCommandWindow As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblTransparency As System.Windows.Forms.Label
    Friend WithEvents ctlTransparency As System.Windows.Forms.TrackBar
    Friend WithEvents ctlPosition As System.Windows.Forms.ComboBox
    Friend WithEvents ctlWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOpenLinks As System.Windows.Forms.Label
    Friend WithEvents ctlOpenLinks As System.Windows.Forms.CheckBox
    Friend WithEvents tabTools As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents gbQLProtocol As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTSRemoveProtocol As System.Windows.Forms.Button
    Friend WithEvents btnTSRegisterProtocol As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents gbAutostart As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTSRemoveAutostart As System.Windows.Forms.Button
    Friend WithEvents btnTSAddAutostart As System.Windows.Forms.Button
    Friend WithEvents lblQLToolsetIntro As System.Windows.Forms.Label
    Friend WithEvents gbConfigFile As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTSRestoreConfig As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblHideCommandwindow As System.Windows.Forms.Label
    Friend WithEvents ctlCloseCommandwindow As System.Windows.Forms.CheckBox
    Friend WithEvents lblPopulateStartMenu As System.Windows.Forms.Label
    Friend WithEvents ctlPopulateStartMenu As System.Windows.Forms.CheckBox
    Friend WithEvents lbStdShortcut As System.Windows.Forms.Label
    Friend WithEvents cbStdShortcut As System.Windows.Forms.ComboBox
    Friend WithEvents lblOpenSimpleURLs As System.Windows.Forms.Label
    Friend WithEvents cbOpenSimpleURLs As System.Windows.Forms.CheckBox
End Class
