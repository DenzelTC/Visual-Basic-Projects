Public Class frmAdd
    'Dim first As Integer
    'Dim second As Integer
    'Dim sum As Integer
    Private Function Addition(first As Integer, second As Integer) As Integer

        'Addition = first + second
        Return first + second
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MessageBox.Show(txtFirst.Text & " + " & txtSecond.Text & " = " & Addition(txtFirst.Text, txtSecond.Text))
        'Call Addition(first, second)
        'MessageBox.Show("The total is " & sum)

    End Sub
End Class
