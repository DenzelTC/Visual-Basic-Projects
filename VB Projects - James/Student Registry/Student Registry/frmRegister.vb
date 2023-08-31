Public Class frmRegister

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        fName = txtName.Text
        surname = txtSurname.Text

        If chkMathematics.Checked = True And chkGeography.Checked = True And chkScience.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Sciences : " & vbNewLine & "Geography " & ", MAthematics and " & "Science")
        ElseIf chkAccounts.Checked = True And chkCommerce.Checked = True And chkMathematics.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Commercials: " & vbNewLine & "Accounts " & ", Commerce and " & "Mathematics")
        ElseIf chkEnglish.Checked = True And chkHistory.Checked = True And chkShona.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Arts: " & vbNewLine & "English " & ", History and " & "Shona")
        Else
            MessageBox.Show("Sorry. That combination of subjects is not possible")
        End If

    End Sub

End Class
