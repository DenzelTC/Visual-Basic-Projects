Public Class Form1
    Private Sub chared_CheckedChanged(sender As Object, e As EventArgs) Handles chared.CheckedChanged
        If chared.Checked = False And chablue.Checked = False And chagreen.Checked = False Then
            pnlPanel1.BackColor = Color.Black

        ElseIf chared.Checked = False And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Blue

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Green

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Cyan

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Red

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Magenta

        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Yellow


        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.White
        End If


    End Sub

    Private Sub chagreen_CheckedChanged(sender As Object, e As EventArgs) Handles chagreen.CheckedChanged
        If chared.Checked = False And chablue.Checked = False And chagreen.Checked = False Then
            pnlPanel1.BackColor = Color.Black

        ElseIf chared.Checked = False And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Blue

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Green

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Cyan

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Red

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Magenta

        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Yellow


        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.White
        End If
    End Sub

    Private Sub chablue_CheckedChanged(sender As Object, e As EventArgs) Handles chablue.CheckedChanged
        If chared.Checked = False And chablue.Checked = False And chagreen.Checked = False Then
            pnlPanel1.BackColor = Color.Black

        ElseIf chared.Checked = False And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Blue

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Green

        ElseIf chared.Checked = False And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Cyan

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Red

        ElseIf chared.Checked = True And chagreen.Checked = False And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.Magenta

        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = False Then
            pnlPanel1.BackColor = Color.Yellow


        ElseIf chared.Checked = True And chagreen.Checked = True And chablue.Checked = True Then
            pnlPanel1.BackColor = Color.White
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPanel1.BackColor = Color.White
    End Sub
End Class
