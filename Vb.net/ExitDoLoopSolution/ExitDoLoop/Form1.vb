Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim A As String

        Do
            A = InputBox("What is the capital of India? opt: Mumbai, New Delhi, Goa, Pune")

            If A.ToUpper = "NEW DELHI" Then
                MessageBox.Show("Correct! New Delhi is the Capital of India")
                Exit Do
            Else
                MessageBox.Show("Incorrect! Try again!")
            End If

        Loop

    End Sub

End Class
