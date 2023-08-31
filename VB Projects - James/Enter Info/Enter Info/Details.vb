Public Class Details
    Private Sub btnConfrim_Click(sender As Object, e As EventArgs) Handles btnConfrim.Click
        MessageBox.Show("You are " & txtName.Text & " " & txtSurname.Text & ". You live at " + txtAddress.Text)
    End Sub
End Class
