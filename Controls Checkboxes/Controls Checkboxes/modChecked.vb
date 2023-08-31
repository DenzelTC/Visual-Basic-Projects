Module modChecked

    Public Sub Checked(pnlScreen As Panel, chkRed As CheckBox, chkGreen As CheckBox, chkBlue As CheckBox)
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
End Module
