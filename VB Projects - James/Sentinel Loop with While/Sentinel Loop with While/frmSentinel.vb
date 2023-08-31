Public Class frmSentinel
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim pass As String = InputBox("What is the password?:")
        While pass <> "event"
            pass = InputBox("What is the password?:")
        End While
        MessageBox.Show("Welcome!")
    End Sub
End Class
