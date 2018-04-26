<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EingabefensterÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerfügbareBegriffeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AufUpdatesPrüfenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMsgText = New System.Windows.Forms.Label()
        Me.pbMsgIcon = New System.Windows.Forms.PictureBox()
        Me.lblMsgTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbMsgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(45, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(562, 20)
        Me.TextBox1.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "QuExeCute"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EingabefensterÖffnenToolStripMenuItem, Me.HilfeToolStripMenuItem, Me.AufUpdatesPrüfenToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeendenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 120)
        '
        'EingabefensterÖffnenToolStripMenuItem
        '
        Me.EingabefensterÖffnenToolStripMenuItem.Name = "EingabefensterÖffnenToolStripMenuItem"
        Me.EingabefensterÖffnenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EingabefensterÖffnenToolStripMenuItem.Text = "Eingabefenster öffnen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerfügbareBegriffeToolStripMenuItem, Me.OnlineHilfeToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'VerfügbareBegriffeToolStripMenuItem
        '
        Me.VerfügbareBegriffeToolStripMenuItem.Name = "VerfügbareBegriffeToolStripMenuItem"
        Me.VerfügbareBegriffeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VerfügbareBegriffeToolStripMenuItem.Text = "Verfügbare Befehle"
        '
        'OnlineHilfeToolStripMenuItem
        '
        Me.OnlineHilfeToolStripMenuItem.Name = "OnlineHilfeToolStripMenuItem"
        Me.OnlineHilfeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OnlineHilfeToolStripMenuItem.Text = "Online-Hilfe"
        '
        'AufUpdatesPrüfenToolStripMenuItem
        '
        Me.AufUpdatesPrüfenToolStripMenuItem.Name = "AufUpdatesPrüfenToolStripMenuItem"
        Me.AufUpdatesPrüfenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AufUpdatesPrüfenToolStripMenuItem.Text = "Auf Updates prüfen"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'lblMsgText
        '
        Me.lblMsgText.AutoEllipsis = True
        Me.lblMsgText.Location = New System.Drawing.Point(45, 74)
        Me.lblMsgText.Name = "lblMsgText"
        Me.lblMsgText.Size = New System.Drawing.Size(562, 116)
        Me.lblMsgText.TabIndex = 2
        Me.lblMsgText.Text = "°"
        '
        'pbMsgIcon
        '
        Me.pbMsgIcon.ErrorImage = Nothing
        Me.pbMsgIcon.InitialImage = Nothing
        Me.pbMsgIcon.Location = New System.Drawing.Point(3, 57)
        Me.pbMsgIcon.Name = "pbMsgIcon"
        Me.pbMsgIcon.Size = New System.Drawing.Size(32, 32)
        Me.pbMsgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMsgIcon.TabIndex = 3
        Me.pbMsgIcon.TabStop = False
        '
        'lblMsgTitle
        '
        Me.lblMsgTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgTitle.Location = New System.Drawing.Point(45, 57)
        Me.lblMsgTitle.Name = "lblMsgTitle"
        Me.lblMsgTitle.Size = New System.Drawing.Size(562, 15)
        Me.lblMsgTitle.TabIndex = 4
        Me.lblMsgTitle.Text = "MsgTitle"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.QuExeCute.My.Resources.Resources.QuickLaunch_Logo32
        Me.PictureBox1.Image = Global.QuExeCute.My.Resources.Resources.QuickLaunch_Logo32
        Me.PictureBox1.Location = New System.Drawing.Point(7, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(543, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "QuExeCute"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 3)
        Me.Panel1.TabIndex = 7
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProgressBar.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(200, 3)
        Me.ProgressBar.TabIndex = 0
        Me.ProgressBar.Visible = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 57)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbMsgIcon)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMsgTitle)
        Me.Controls.Add(Me.lblMsgText)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 81)
        Me.Name = "MainWindow"
        Me.Opacity = 0.01R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuExeCute"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbMsgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EingabefensterÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerfügbareBegriffeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMsgText As System.Windows.Forms.Label
    Friend WithEvents pbMsgIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsgTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AufUpdatesPrüfenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar As System.Windows.Forms.Panel

End Class
