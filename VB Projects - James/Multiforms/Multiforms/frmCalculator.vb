Imports System.ComponentModel

Public Class frmCalculator
    Dim first As String = ""
    Dim second As String = ""
    Dim result As Integer
    Dim op As Char = "#"

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'txtOutput.Text &= btnOne.Text
        If op = "#" Then
            first &= btnOne.Text
        Else
            second &= btnOne.Text
        End If
        txtOutput.Text &= btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If op = "#" Then
            first &= btnTwo.Text
        Else
            second &= btnTwo.Text
        End If
        txtOutput.Text &= btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'txtOutput.Text &= btnThree.Text
        If op = "#" Then
            first &= btnThree.Text
        Else
            second &= btnThree.Text
        End If
        txtOutput.Text &= btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'txtOutput.Text &= btnFour.Text
        If op = "#" Then
            first &= btnFour.Text
        Else
            second &= btnFour.Text
        End If
        txtOutput.Text &= btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'txtOutput.Text &= btnFive.Text
        If op = "#" Then
            first &= btnFive.Text
        Else
            second &= btnFive.Text
        End If
        txtOutput.Text &= btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        'txtOutput.Text &= btnSix.Text
        If op = "#" Then
            first &= btnSix.Text
        Else
            second &= btnSix.Text
        End If
        txtOutput.Text &= btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        'txtOutput.Text &= btnSeven.Text
        If op = "#" Then
            first &= btnSeven.Text
        Else
            second &= btnSeven.Text
        End If
        txtOutput.Text &= btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        'txtOutput.Text &= btnEight.Text
        If op = "#" Then
            first &= btnEight.Text
        Else
            second &= btnEight.Text
        End If
        txtOutput.Text &= btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        'txtOutput.Text &= btnNine.Text
        If op = "#" Then
            first &= btnNine.Text
        Else
            second &= btnNine.Text
        End If
        txtOutput.Text &= btnNine.Text
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        'txtOutput.Text &= btnZero.Text
        If op = "#" Then
            first &= btnZero.Text
        Else
            second &= btnZero.Text
        End If
        txtOutput.Text &= btnZero.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Clear()
        first = ""
        second = ""
        op = "#"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        op = btnAdd.Text
        txtOutput.Text &= op
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        op = btnDivide.Text
        txtOutput.Text &= op
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        op = btnSubtract.Text
        txtOutput.Text &= op
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        op = btnMultiply.Text
        txtOutput.Text &= op
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Select Case op
            Case "+"
                result = CInt(first) + CInt(second)
            Case "-"
                result = CInt(first) - CInt(second)
            Case "X"
                result = CInt(first) * CInt(second)
            Case "÷"
                result = CInt(first) / CInt(second)
        End Select
        txtOutput.Text &= "=" & result
    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmCalculator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub
End Class
