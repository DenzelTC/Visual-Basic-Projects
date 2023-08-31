Public Class frmVars
    Dim da As Date
    Dim c As Char


    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim age As Integer
        fName = txtName.Text
        age = txtAge.Text

        c = fName(0)

        If age > 16 Then
            choice = True
        Else
            MsgBox("Sorry, you cannot use this application")
        End If
        If choice = True Then
            MessageBox.Show("Accepted!")

        End If
        lblOutput.Text = "Name: " + fName + vbNewLine + "Age: " + age + vbNewLine + "First characeterof name: " & c


    End Sub
End Class
