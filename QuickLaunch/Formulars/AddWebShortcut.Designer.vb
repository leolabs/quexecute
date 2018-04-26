<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWebShortcut
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
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.tbSCIconPath = New System.Windows.Forms.TextBox()
        Me.lblSCIconPath = New System.Windows.Forms.Label()
        Me.tbSCPath = New System.Windows.Forms.TextBox()
        Me.lblSCPath = New System.Windows.Forms.Label()
        Me.tbSCCommand = New System.Windows.Forms.TextBox()
        Me.lblSCCommand = New System.Windows.Forms.Label()
        Me.tbSCName = New System.Windows.Forms.TextBox()
        Me.lblSCName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHelp.Location = New System.Drawing.Point(12, 134)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 23
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(215, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccept.Location = New System.Drawing.Point(296, 134)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 21
        Me.btnAccept.Text = "OK"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'tbSCIconPath
        '
        Me.tbSCIconPath.Location = New System.Drawing.Point(122, 91)
        Me.tbSCIconPath.Name = "tbSCIconPath"
        Me.tbSCIconPath.Size = New System.Drawing.Size(249, 20)
        Me.tbSCIconPath.TabIndex = 19
        '
        'lblSCIconPath
        '
        Me.lblSCIconPath.AutoSize = True
        Me.lblSCIconPath.Location = New System.Drawing.Point(12, 94)
        Me.lblSCIconPath.Name = "lblSCIconPath"
        Me.lblSCIconPath.Size = New System.Drawing.Size(74, 13)
        Me.lblSCIconPath.TabIndex = 18
        Me.lblSCIconPath.Text = "Shortcut Icon:"
        '
        'tbSCPath
        '
        Me.tbSCPath.Location = New System.Drawing.Point(122, 65)
        Me.tbSCPath.Name = "tbSCPath"
        Me.tbSCPath.Size = New System.Drawing.Size(249, 20)
        Me.tbSCPath.TabIndex = 17
        '
        'lblSCPath
        '
        Me.lblSCPath.AutoSize = True
        Me.lblSCPath.Location = New System.Drawing.Point(12, 68)
        Me.lblSCPath.Name = "lblSCPath"
        Me.lblSCPath.Size = New System.Drawing.Size(80, 13)
        Me.lblSCPath.TabIndex = 16
        Me.lblSCPath.Text = "Executed Path:"
        '
        'tbSCCommand
        '
        Me.tbSCCommand.Location = New System.Drawing.Point(122, 39)
        Me.tbSCCommand.Name = "tbSCCommand"
        Me.tbSCCommand.Size = New System.Drawing.Size(249, 20)
        Me.tbSCCommand.TabIndex = 15
        '
        'lblSCCommand
        '
        Me.lblSCCommand.AutoSize = True
        Me.lblSCCommand.Location = New System.Drawing.Point(12, 42)
        Me.lblSCCommand.Name = "lblSCCommand"
        Me.lblSCCommand.Size = New System.Drawing.Size(105, 13)
        Me.lblSCCommand.TabIndex = 14
        Me.lblSCCommand.Text = "Command (e.g. ""yt""):"
        '
        'tbSCName
        '
        Me.tbSCName.Location = New System.Drawing.Point(122, 13)
        Me.tbSCName.Name = "tbSCName"
        Me.tbSCName.Size = New System.Drawing.Size(249, 20)
        Me.tbSCName.TabIndex = 13
        '
        'lblSCName
        '
        Me.lblSCName.AutoSize = True
        Me.lblSCName.Location = New System.Drawing.Point(12, 16)
        Me.lblSCName.Name = "lblSCName"
        Me.lblSCName.Size = New System.Drawing.Size(81, 13)
        Me.lblSCName.TabIndex = 12
        Me.lblSCName.Text = "Shortcut Name:"
        '
        'AddWebShortcut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 169)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.tbSCIconPath)
        Me.Controls.Add(Me.lblSCIconPath)
        Me.Controls.Add(Me.tbSCPath)
        Me.Controls.Add(Me.lblSCPath)
        Me.Controls.Add(Me.tbSCCommand)
        Me.Controls.Add(Me.lblSCCommand)
        Me.Controls.Add(Me.tbSCName)
        Me.Controls.Add(Me.lblSCName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddWebShortcut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddWebShortcut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents tbSCIconPath As System.Windows.Forms.TextBox
    Friend WithEvents lblSCIconPath As System.Windows.Forms.Label
    Friend WithEvents tbSCPath As System.Windows.Forms.TextBox
    Friend WithEvents lblSCPath As System.Windows.Forms.Label
    Friend WithEvents tbSCCommand As System.Windows.Forms.TextBox
    Friend WithEvents lblSCCommand As System.Windows.Forms.Label
    Friend WithEvents tbSCName As System.Windows.Forms.TextBox
    Friend WithEvents lblSCName As System.Windows.Forms.Label
End Class
