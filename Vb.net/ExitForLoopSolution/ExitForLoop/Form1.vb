Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim A As String

        For i As Integer = 1 To 3

            A = InputBox("What is the capital of India? Opt: Mumbai, New Delhi, Goa, Pune")

            If A.ToUpper = "NEW DELHI" Then
                MessageBox.Show("Correct! New Delhi is the capital of India")
                Exit For
            Else
                MessageBox.Show("Incorrect! Try again!")
            End If

        Next

    End Sub

End Class
