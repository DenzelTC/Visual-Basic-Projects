Public Class frmControlCheckbox
    Private Sub frmControlCheckbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkRed.Checked = False
        chkGreen.Checked = False
        chkBlue.Checked = False
        pnlScreen.BackColor = Color.Black

    End Sub

    Private Sub chkRed_CheckedChanged(sender As Object, e As EventArgs) Handles chkRed.CheckedChanged
        Call Checked(pnlScreen, chkRed, chkGreen, chkBlue)
    End Sub

    Private Sub chkBlue_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlue.CheckedChanged
        Call Checked(pnlScreen, chkRed, chkGreen, chkBlue)
    End Sub

    Private Sub chkGreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkGreen.CheckedChanged
        Call Checked(pnlScreen, chkRed, chkGreen, chkBlue)
    End Sub

End Class
