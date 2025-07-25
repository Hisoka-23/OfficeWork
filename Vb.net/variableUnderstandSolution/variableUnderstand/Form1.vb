Public Class Form1

    Private Sub BtnVariable_Click(sender As Object, e As EventArgs) Handles BtnVariable.Click

        Dim FirstName As String
        Dim LastName As String

        FirstName = "Prakash"
        LastName = "Chaurasiya"

        MessageBox.Show("Good Morning " & FirstName & " " & LastName & ". How are you?")

        FirstName = "Stayam"
        LastName = "Mishra"

        MessageBox.Show("Good Morning " & FirstName & " " & LastName & ". How are you?")

    End Sub

End Class
