Public Class frmTrafficLight
    Dim counter As Integer = 1
    Private Sub frmTrafficLight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        radGreen.Enabled = True
        radAmber.Enabled = False
        radRed.Enabled = False
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        Me.BackColor = Color.Green
        If radGreen.Checked = True Then
            radAmber.Enabled = True
            radRed.Enabled = False
        End If
    End Sub

    Private Sub radAmber_CheckedChanged(sender As Object, e As EventArgs) Handles radAmber.CheckedChanged
        Me.BackColor = Color.DarkOrange
        If radAmber.Checked = True Then
            radGreen.Enabled = False
            radRed.Enabled = True
        End If
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        Me.BackColor = Color.Red
        If radRed.Checked = True Then
            radAmber.Enabled = False
            radGreen.Enabled = True
        End If
    End Sub

    Private Sub frmTrafficLight_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick


        Select Case counter
            Case 1
                Me.BackColor = Color.Green
            Case 2
                Me.BackColor = Color.DarkOrange
            Case 3
                Me.BackColor = Color.Red
            Case Else
                counter = 0
        End Select
        counter += 1
        Me.Text = counter





    End Sub
End Class
