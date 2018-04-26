<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wbChangelog = New System.Windows.Forms.WebBrowser()
        Me.gbChangelog = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnLater = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbUpdate = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BGUpdateChecker = New System.ComponentModel.BackgroundWorker()
        Me.gbChangelog.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A new version of QuExeCute is available!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Version X.X.X is now available, you have Version X.X.X"
        '
        'wbChangelog
        '
        Me.wbChangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbChangelog.IsWebBrowserContextMenuEnabled = False
        Me.wbChangelog.Location = New System.Drawing.Point(1, 1)
        Me.wbChangelog.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbChangelog.Name = "wbChangelog"
        Me.wbChangelog.ScriptErrorsSuppressed = True
        Me.wbChangelog.Size = New System.Drawing.Size(395, 240)
        Me.wbChangelog.TabIndex = 3
        Me.wbChangelog.Url = New System.Uri("http://updates.leolabs.org/quexecute/changelog_de.html", System.UriKind.Absolute)
        '
        'gbChangelog
        '
        Me.gbChangelog.Controls.Add(Me.Panel1)
        Me.gbChangelog.Location = New System.Drawing.Point(85, 57)
        Me.gbChangelog.Name = "gbChangelog"
        Me.gbChangelog.Size = New System.Drawing.Size(405, 263)
        Me.gbChangelog.TabIndex = 4
        Me.gbChangelog.TabStop = False
        Me.gbChangelog.Text = "Changelog"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.wbChangelog)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(399, 244)
        Me.Panel1.TabIndex = 0
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(398, 326)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(92, 23)
        Me.btnInstall.TabIndex = 5
        Me.btnInstall.Text = "Installieren"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnLater
        '
        Me.btnLater.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLater.Location = New System.Drawing.Point(293, 326)
        Me.btnLater.Name = "btnLater"
        Me.btnLater.Size = New System.Drawing.Size(99, 23)
        Me.btnLater.TabIndex = 6
        Me.btnLater.Text = "Später erinnern"
        Me.btnLater.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(86, 326)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(116, 23)
        Me.btnSkip.TabIndex = 7
        Me.btnSkip.Text = "Version überspringen"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuExeCute.My.Resources.Resources.QuickLaunch_Logo512
        Me.PictureBox1.Location = New System.Drawing.Point(19, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbUpdate
        '
        Me.gbUpdate.Controls.Add(Me.Label3)
        Me.gbUpdate.Controls.Add(Me.ProgressBar1)
        Me.gbUpdate.Location = New System.Drawing.Point(85, 57)
        Me.gbUpdate.Name = "gbUpdate"
        Me.gbUpdate.Size = New System.Drawing.Size(405, 79)
        Me.gbUpdate.TabIndex = 8
        Me.gbUpdate.TabStop = False
        Me.gbUpdate.Tag = ""
        Me.gbUpdate.Text = "Update"
        Me.gbUpdate.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Downloading Updater - Downloaded XXXXXX of YYYYYY (XXX %)"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 21)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(388, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        'BGUpdateChecker
        '
        Me.BGUpdateChecker.WorkerReportsProgress = True
        '
        'Updater
        '
        Me.AcceptButton = Me.btnInstall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLater
        Me.ClientSize = New System.Drawing.Size(502, 360)
        Me.Controls.Add(Me.gbUpdate)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnLater)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.gbChangelog)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Updater"
        Me.Text = "QuExeCute Updater"
        Me.gbChangelog.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUpdate.ResumeLayout(False)
        Me.gbUpdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents wbChangelog As System.Windows.Forms.WebBrowser
    Friend WithEvents gbChangelog As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnLater As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents gbUpdate As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BGUpdateChecker As System.ComponentModel.BackgroundWorker
End Class
