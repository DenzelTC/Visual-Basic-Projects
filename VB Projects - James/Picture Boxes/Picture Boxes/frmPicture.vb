Public Class frmPicture
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        picBx2.Image = picBx1.Image
        picBx1.Image = Nothing
        btnPrev.Enabled = True
        btnNext.Enabled = False
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        picBx1.Image = picBx2.Image
        picBx2.Image = Nothing
        btnNext.Enabled = True
        btnPrev.Enabled = False

    End Sub
End Class
