Public Class SetHotKey
    Public extraKey As Keys = Nothing
    Private Sub SetHotKey_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If Not e.KeyCode.ToString = "ControlKey" Then
            Settings2.Hotkey = e

            Dim modcode As Integer = 0

            If e.Alt Then
                modcode += 1
            End If

            If e.Control Then
                modcode += 2
            End If

            If e.Shift Then
                modcode += 4
            End If

            If withWin.Checked Then
                modcode += 8
            End If

            Settings2.pmkeys = modcode
            Settings2.UpdateHotkeyLabel()
            Me.Close()
            withWin.Checked = False
        End If
    End Sub

    Private Sub SetHotKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = l("sethotkey_title")
        Label1.Text = l("sethotkey_intro")
    End Sub
End Class