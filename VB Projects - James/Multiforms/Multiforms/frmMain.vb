Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Hide()
        frmRegister.Show()
    End Sub



    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Me.Hide()
        frmGrade.Show()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Me.Hide()
        frmCalculator.Show()
    End Sub
End Class
