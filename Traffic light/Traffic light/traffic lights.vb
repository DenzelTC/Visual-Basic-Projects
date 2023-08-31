Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdngreen.CheckedChanged

        BackColor = Color.Green
        rdnamber.Enabled = True
        rdngreen.Enabled = False

    End Sub

    Private Sub rdnamber_CheckedChanged(sender As Object, e As EventArgs) Handles rdnamber.CheckedChanged

        BackColor = Color.DarkOrange
        rdnamber.Enabled = False
        rdngreen.Enabled = False
        rdnred.Enabled = True

    End Sub

    Private Sub rdnred_CheckedChanged(sender As Object, e As EventArgs) Handles rdnred.CheckedChanged

        BackColor = Color.Red
        rdnamber.Enabled = False
        rdngreen.Enabled = True
        rdnred.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Green
    End Sub
End Class
