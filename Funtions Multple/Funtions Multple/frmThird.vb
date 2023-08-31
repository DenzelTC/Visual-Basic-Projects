Imports System.ComponentModel

Public Class frmThird
    Private Sub Display()
        MessageBox.Show("I belong to the form frmThird")
    End Sub

    Private Sub frmThird_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmThird_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub
End Class