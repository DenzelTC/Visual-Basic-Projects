Public Class frmFactorial
    Dim i As Integer
    Dim num As Integer

    Private Sub btnCalulate_Click(sender As Object, e As EventArgs) Handles btnCalulate.Click
        Dim fact As Integer = 1 'initialise within to reset it everytime
        num = InputBox("Enter your number: ")
        For i = 1 To num
            fact *= i
        Next

        MessageBox.Show("The factorial of " & num & " is " & fact)

    End Sub
End Class
