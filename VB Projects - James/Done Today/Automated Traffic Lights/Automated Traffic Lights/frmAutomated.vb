Public Class frmAutomated
    Dim counter As Integer = Format(Now, "ss")

    Private Sub frmAutomated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTimer.Enabled = True
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        If counter >= 0 And counter <= 30 Then
            Me.BackColor = Color.Green
        ElseIf counter > +31 And counter <= 50 Then
            Me.BackColor = Color.Orange
        ElseIf counter > 50 Then
            Me.BackColor = Color.Red
        Else
            counter = 0
        End If
        counter += 1
    End Sub
End Class
