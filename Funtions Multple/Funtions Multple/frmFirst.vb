Imports System.ComponentModel

Public Class frmFirst
    Private Sub Display1()
        MessageBox.Show("I belong to the form frmFirst")
    End Sub

    Private Sub frmFirst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display() 'can still be called without keyword
        'Call frmSecond.Display()
    End Sub

    Private Sub frmFirst_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub
End Class