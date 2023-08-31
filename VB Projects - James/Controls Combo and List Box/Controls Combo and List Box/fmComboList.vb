Public Class fmComboList
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If Not lstSelectedSubjects.Items.Contains(cboAllSubjects.Text) Then
            ' It is not already in the list box so add it
            lstSelectedSubjects.Items.Add(cboAllSubjects.Text)
        End If

    End Sub
End Class
