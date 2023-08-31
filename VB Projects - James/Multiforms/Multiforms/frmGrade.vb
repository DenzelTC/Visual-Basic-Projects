Imports System.ComponentModel

Public Class frmGrade
    Dim avg As Double
    Dim counter As Integer = 0
    Dim total As Integer = 0
    Dim grade As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        grade = InputBox("Enter garde or -1 to terminate")

        While grade <> -1 'terminal condition
            total += grade
            counter += 1

            grade = InputBox("Enter garde or -1 to terminate")
        End While
        'when  -1 is entered exit loop and calculate 
        avg = CDbl(total / counter)
        MessageBox.Show("The average grade is " & avg)
    End Sub

    Private Sub frmGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmGrade_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub
End Class
