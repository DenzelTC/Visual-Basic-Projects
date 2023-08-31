Public Class Calculator
    Dim first As String
    Dim second As String
    Dim op As Char = "#"
    Dim answer As Integer
    Dim result As Integer


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnnum6.Click
        If op = "#" Then
            first &= btnnum6.Text

        Else
            second &= btnnum6.Text

        End If
        txtAnswer.Text &= btnnum6.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        Select Case op
            Case "+"
                answer = CInt(first) + CInt(second)

            Case "-"
                answer = CInt(first) - CInt(second)

            Case "*"
                answer = CInt(first) * CInt(second)

            Case "/"
                answer = CInt(first) / CInt(second)

        End Select
        txtAnswer.Text &= "=" & answer


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnum1.Click
        If op = "#" Then
            first &= btnnum1.Text

        Else
            second &= btnnum1.Text

        End If
        txtAnswer.Text &= btnnum1.Text
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        op = btndivide.Text
        txtAnswer.Text &= op
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtAnswer.Clear()
        first = ""
        second = ""
        op = "#"
    End Sub

    Private Sub btnnum2_Click(sender As Object, e As EventArgs) Handles btnnum2.Click
        If op = "#" Then
            first &= btnnum2.Text

        Else
            second &= btnnum2.Text

        End If
        txtAnswer.Text &= btnnum2.Text
    End Sub

    Private Sub btnnum3_Click(sender As Object, e As EventArgs) Handles btnnum3.Click
        If op = "#" Then
            first &= btnnum3.Text

        Else
            second &= btnnum3.Text

        End If
        txtAnswer.Text &= btnnum3.Text
    End Sub

    Private Sub btnnum4_Click(sender As Object, e As EventArgs) Handles btnnum4.Click
        If op = "#" Then
            first &= btnnum4.Text

        Else
            second &= btnnum4.Text

        End If
        txtAnswer.Text &= btnnum4.Text
    End Sub

    Private Sub btnnum5_Click(sender As Object, e As EventArgs) Handles btnnum5.Click
        If op = "#" Then
            first &= btnnum5.Text

        Else
            second &= btnnum5.Text

        End If
        txtAnswer.Text &= btnnum5.Text
    End Sub

    Private Sub btnnum7_Click(sender As Object, e As EventArgs) Handles btnnum7.Click
        If op = "#" Then
            first &= btnnum7.Text

        Else
            second &= btnnum7.Text

        End If
        txtAnswer.Text &= btnnum7.Text

    End Sub

    Private Sub btnnum8_Click(sender As Object, e As EventArgs) Handles btnnum8.Click
        If op = "#" Then
            first &= btnnum8.Text

        Else
            second &= btnnum8.Text

        End If
        txtAnswer.Text &= btnnum8.Text
    End Sub

    Private Sub btnnum9_Click(sender As Object, e As EventArgs) Handles btnnum9.Click
        If op = "#" Then
            first &= btnnum9.Text

        Else
            second &= btnnum9.Text

        End If
        txtAnswer.Text &= btnnum9.Text
    End Sub

    Private Sub btnnum0_Click(sender As Object, e As EventArgs) Handles btnnum0.Click
        If op = "#" Then
            first &= btnnum0.Text

        Else
            second &= btnnum0.Text

        End If
        txtAnswer.Text &= btnnum0.Text
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        op = btnadd.Text
        txtAnswer.Text &= op
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        op = btnsub.Text
        txtAnswer.Text &= op
    End Sub

    Private Sub btnmult_Click(sender As Object, e As EventArgs) Handles btnmult.Click
        op = btnmult.Text
        txtAnswer.Text &= op
    End Sub
End Class
