Public Class frmControlsTV
    Private Sub frmControlsTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlScreen.BackColor = Color.Empty

        radRed.Checked = False
        radBlue.Checked = False
        radGreen.Checked = False

    End Sub
    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        pnlScreen.BackColor = Color.Red

    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        pnlScreen.BackColor = Color.Blue
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        pnlScreen.BackColor = Color.Green
    End Sub


End Class
