Public Class frmControlCheckbox
    Private Sub frmControlCheckbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkRed.Checked = False
        chkGreen.Checked = False
        chkBlue.Checked = False
        pnlScreen.BackColor = Color.Black

    End Sub
    Private Sub chkRed_CheckedChanged(sender As Object, e As EventArgs) Handles chkRed.CheckedChanged
        If chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Black
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Red
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Green
        ElseIf chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Blue
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Cyan
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Magenta
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Yellow
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.White
        End If


    End Sub

    Private Sub chkBlue_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlue.CheckedChanged
        If chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Black
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Red
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Green
        ElseIf chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Blue
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Cyan
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Magenta
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Yellow
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.White
        End If

    End Sub

    Private Sub chkGreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkGreen.CheckedChanged
        If chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Black
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Red
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Green
        ElseIf chkRed.Checked = False And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Blue
        ElseIf chkRed.Checked = False And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Cyan
        ElseIf chkRed.Checked = True And chkGreen.Checked = False And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.Magenta
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = False Then
            pnlScreen.BackColor = Color.Yellow
        ElseIf chkRed.Checked = True And chkGreen.Checked = True And chkBlue.Checked = True Then
            pnlScreen.BackColor = Color.White
        End If

    End Sub

End Class
