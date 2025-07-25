Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        If String.IsNullOrEmpty(TextBox1.Text) = True Then
            TextBox1.Focus()
            ErrorProvider1.SetError(Me.TextBox1, "Pls Enter ID")
        Else
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        Dim pattern As String = "prakash"

        If Regex.IsMatch(TextBox2.Text, pattern) = False Then
            TextBox2.Focus()
            ErrorProvider2.SetError(Me.TextBox2, "Pls Enter Valid Email ID")
        Else
            ErrorProvider2.Clear()
        End If

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave

        Dim pass As String = "123123"

        If Regex.IsMatch(TextBox3.Text, pass) = False Then
            TextBox3.Focus()
            ErrorProvider3.SetError(Me.TextBox3, "Pls Enter valid password")
        Else
            ErrorProvider3.Clear()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("Data Validation Completed")

    End Sub

End Class
