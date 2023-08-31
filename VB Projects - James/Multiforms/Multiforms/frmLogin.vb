Imports System.ComponentModel

Public Class frmLogin
    Dim username As String
    Dim passcode As String
    Dim counter As Integer = 1
    Dim attempt As Integer = 3
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        username = txtUser.Text
        passcode = txtPass.Text

        If username = "Denzel" And passcode = "asbestos" Then
            Me.Hide()
            frmMain.Show()
        Else
            MessageBox.Show("Incorrect Username or Password! You have " & attempt - 1 & " attmpts left")
            counter += 1
            attempt -= 1

        End If

        If counter > 3 Then
            MessageBox.Show("Very very sorry and sorry. No hackers allowed!")
            End
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class