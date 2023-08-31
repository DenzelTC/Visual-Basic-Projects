Public Class frmArrays
    Dim letters(20) As Char

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        Dim i As Integer = 0
        If btnBegin.Text = "Start" Then
            btnBegin.Text = "Display"
            ' For i = 1 To 20
            'letters(i) = InputBox("Enter letter character " & i+1)
            'Next
            Do
                letters(i) = InputBox("Please enter letter " & i + 1)
                i += 1
            Loop Until letters(i - 1) = vbNullChar
        Else
            btnBegin.Visible = False
            'For i = 1 To 20 Step 1
            'lblOutput.Text = letters(i)
            'Next
            Dim word As New String(letters)
            lblOutput.Text = word
        End If

    End Sub
End Class
