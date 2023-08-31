Public Class frmAutomated
    'Dim counter As Integer = Format(Now, "ss")
    Dim counter As Integer = 0

    Private Sub frmAutomated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTimer.Enabled = True
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        If counter >= 0 And counter <= 30 Then
            Me.BackColor = Color.Green
            lblLeft.Text = 30 - counter
        ElseIf counter > 30 And counter <= 40 Then
            Me.BackColor = Color.Orange
            lblLeft.Text = 40 - counter
        ElseIf counter > 40 And counter <= 60 Then
            Me.BackColor = Color.Red
            lblLeft.Text = 60 - counter
        Else
            'counter = format(Now, "ss")
            counter = 0
        End If
        counter += 1
        'lblLeft.Text = Format(Now, "ssss")
        'lblLeft.Text = lblLeft.Text - 1

    End Sub
End Class
