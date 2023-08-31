Imports System.ComponentModel

Public Class frmSecond
    Public Sub Display()
        MessageBox.Show("I belong to the form frmSecond")
    End Sub

    Private Sub frmSecond_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmSecond_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub
End Class