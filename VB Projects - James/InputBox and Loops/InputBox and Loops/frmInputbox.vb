Public Class frmInputbox
    Dim max As Integer
    Dim num As Integer = 1
    Dim strMsg As String = ""

    Private Sub frmInputbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max = InputBox("Enter a number: ")

        Do
            If num Mod 2 = 0 Then
                strMsg &= num & vbTab
            End If
            num += 1
        Loop While num <= max 'Until num > max  

        MessageBox.Show(strMsg)
    End Sub

End Class
