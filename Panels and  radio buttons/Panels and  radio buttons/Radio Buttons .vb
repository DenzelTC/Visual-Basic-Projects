Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlPanel1.Paint

    End Sub

    Private Sub rdnred_CheckedChanged(sender As Object, e As EventArgs) Handles rdnred.CheckedChanged
        pnlPanel1.BackColor = rdnred.ForeColor
    End Sub

    Private Sub rdngreen_CheckedChanged(sender As Object, e As EventArgs) Handles rdngreen.CheckedChanged
        pnlPanel1.BackColor = rdngreen.ForeColor
    End Sub

    Private Sub rdnblue_CheckedChanged(sender As Object, e As EventArgs) Handles rdnblue.CheckedChanged
        pnlPanel1.BackColor = rdnblue.ForeColor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdnblue.Checked = False
        rdngreen.Checked = False
        rdnred.Checked = False
    End Sub

End Class
