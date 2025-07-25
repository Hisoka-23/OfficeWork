Public Class Form1

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Dim StrFirstName As String
        Dim StrLastName As String
        Dim StrEmail As String

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmail.Text

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName &
                        ", your email id is : " & StrEmail)

        TxtBoxFirstName.Text = ""
        TxtBoxLastName.Text = ""
        TxtBoxEmail.Text = ""

    End Sub

End Class
