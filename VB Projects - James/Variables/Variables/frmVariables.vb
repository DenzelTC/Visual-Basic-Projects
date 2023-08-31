Public Class frmVariables
    Dim height As Double 'class variable;can be accessed by any event within the class

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim weight As Double 'method variable; can only be accessed within this method

        age = txtAge.Text
        height = txtHeight.Text
        weight = txtWeight.Text

        MessageBox.Show("You are " & age & " years old. You are " & height & " cm tall. You weigh " & weight & " kgs")
    End Sub
End Class
