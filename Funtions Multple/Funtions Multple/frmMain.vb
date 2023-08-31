Public Class frmMain
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.Hide()
        frmFirst.Show()
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As EventArgs) Handles btnSecond.Click
        Me.Hide()
        frmSecond.Show()
    End Sub

    Private Sub btnThird_Click(sender As Object, e As EventArgs) Handles btnThird.Click
        Me.Hide()
        frmThird.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
