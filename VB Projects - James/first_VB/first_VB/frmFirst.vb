Public Class frmFirst

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        lblDisplay.Text = "Hello " & txtName.Text
    End Sub

    Private Sub btnGreet_DoubleClick(sender As Object, e As EventArgs) Handles btnGreet.DoubleClick
        lblDisplay.Text = txtName.Text & " has double clicked me"
    End Sub

    Private Sub btnGreet_MouseHover(sender As Object, e As EventArgs) Handles btnGreet.MouseHover
        lblDisplay.Text = "You are hovering over me"
    End Sub

    Private Sub btnAction_MouseEnter(sender As Object, e As EventArgs) Handles btnAction.MouseEnter
        lblDisplay.Text = " You've entered my bounds"
    End Sub

    Private Sub btnAction_MouseUp(sender As Object, e As MouseEventArgs) Handles btnAction.MouseUp
        lblDisplay.Text = "You have performed a mouse down"
    End Sub

    Private Sub btnAction_MouseWheel(sender As Object, e As MouseEventArgs) Handles btnAction.MouseWheel
        lblDisplay.Text = txtName.Text & " has used the mouse wheel"
    End Sub

    Private Sub btnAction_MouseLeave(sender As Object, e As EventArgs) Handles btnAction.MouseLeave
        lblDisplay.Text = " You've left my bounds"
    End Sub

    'Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    'Handles btnGreet.MouseDown
    ' If e.Clicks = 2 Then
    '      MessageBox.Show("The button was double-clicked.")
    '   End If
    'End Sub

End Class
