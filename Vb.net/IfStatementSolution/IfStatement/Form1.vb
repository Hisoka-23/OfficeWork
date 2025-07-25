Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim StrCountryName As String
        StrCountryName = TextBox1.Text

        If StrCountryName.ToUpper = "INDIA" Then
            MessageBox.Show("Namaste")
        ElseIf StrCountryName.ToUpper = "FRANCE" Then
            MessageBox.Show("Bonjour")
        Else
            MessageBox.Show("Hello")
        End If

    End Sub

End Class
