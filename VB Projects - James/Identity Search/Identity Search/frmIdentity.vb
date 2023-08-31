Public Class frmIdentity
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        picBx.Visible = True

        MessageBox.Show("ID Number: " + txtID.Text + vbNewLine + "Name: " + txtName.Text + vbNewLine + "Surname: " + txtSurname.Text)
    End Sub
End Class
