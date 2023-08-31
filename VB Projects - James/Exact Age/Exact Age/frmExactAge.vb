Public Class frmExactAge
    Dim days As Long
    Dim yy As Integer
    Dim mm As Integer
    Dim dd As Integer
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        days = DateDiff(DateInterval.Day, dtpAge.Value, Today)
        yy = days \ 365
        mm = (days Mod 365) \ 30
        dd = (days Mod 365) Mod 30

        lblExactAge.Text = "You are: " & vbNewLine & vbNewLine & yy & " years " & mm & " months and " & dd & " days old"
    End Sub
End Class
