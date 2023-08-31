Public Class frmTimer
    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = Now
        lblCounter.Text = Format(Now, "ss")

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnStop.Enabled = True
        tmrTimer.Enabled = True
        'tmrTimer.Start()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False
        tmrTimer.Enabled = False
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblTime.Text = Now
        lblCounter.Text = Format(Now, "ss")
    End Sub

    Private Sub btnBeginEnd_Click(sender As Object, e As EventArgs) Handles btnBeginEnd.Click
        If btnBeginEnd.Text = "Begin" Then
            btnBeginEnd.Text = "End"
            tmrTimer.Start()
        Else
            btnBeginEnd.Text = "Begin"
            tmrTimer.Stop()
        End If
    End Sub

    Private Sub lblCounter_Click(sender As Object, e As EventArgs) Handles lblCounter.Click

    End Sub
End Class
