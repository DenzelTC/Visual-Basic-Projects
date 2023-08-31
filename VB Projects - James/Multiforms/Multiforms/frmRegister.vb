Imports System.ComponentModel

Public Class frmRegister
    Private cbChecked As Integer = 0

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccounts.CheckedChanged, chkCommerce.CheckedChanged, chkEnglish.CheckedChanged, chkGeography.CheckedChanged, chkHistory.CheckedChanged, chkMathematics.CheckedChanged, chkScience.CheckedChanged, chkShona.CheckedChanged

        Dim cb As CheckBox = TryCast(sender, CheckBox)
        If cb.Checked Then
            cbChecked += 1
        Else
            cbChecked -= 1
        End If
        If cbChecked = 3 Then
            For Each cbx As CheckBox In Me.Controls.OfType(Of CheckBox)
                If Not cbx.Checked Then
                    cbx.Enabled = False
                End If
            Next
        Else
            For Each cbx As CheckBox In Me.Controls.OfType(Of CheckBox)
                cbx.Enabled = True
            Next
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        fName = txtName.Text
        surname = txtSurname.Text

        If chkMathematics.Checked = True And chkGeography.Checked = True And chkScience.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Sciences : " & vbNewLine & "Geography " & ", MAthematics and " & "Science")
        ElseIf chkAccounts.Checked = True And chkCommerce.Checked = True And chkMathematics.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Commercials: " & vbNewLine & "Accounts " & ", Commerce and " & "Mathematics")
        ElseIf chkEnglish.Checked = True And chkHistory.Checked = True And chkShona.Checked = True Then
            MessageBox.Show("Welcome " & fName & " " & surname & "!" & vbNewLine & vbNewLine & "You will be doing Arts: " & vbNewLine & "English " & ", History and " & "Shona")
        Else
            MessageBox.Show("Sorry. That combination of subjects is not possible")
        End If

    End Sub

    Private Sub frmRegister_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
