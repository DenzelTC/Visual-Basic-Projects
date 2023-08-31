Public Class frmIdenity
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        picBx.Visible = True
        MessageBox.Show("ID Number: " + vbTab + txtID.Text + vbNewLine + "Name: " + vbTab + vbTab + txtName.Text + vbNewLine + "Surname: " + vbTab + txtSurname.Text)

        btnOK.Enabled = False
        btnClear.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picBx.Visible = False

        txtID.Text = Nothing
        txtID.Enabled = True

        txtName.Text = Nothing
        txtName.Enabled = True

        txtSurname.Text = Nothing
        txtSurname.Enabled = True

        btnOK.Enabled = True
        btnClear.Enabled = False
    End Sub

    Private Sub txtID_Validated(sender As Object, e As EventArgs) Handles txtID.Validated
        txtID.Enabled = False
    End Sub

    Private Sub txtName_Validated(sender As Object, e As EventArgs) Handles txtName.Validated
        txtName.Enabled = False
    End Sub

    Private Sub txtSurname_Validated(sender As Object, e As EventArgs) Handles txtSurname.Validated
        txtSurname.Enabled = False
    End Sub
End Class
