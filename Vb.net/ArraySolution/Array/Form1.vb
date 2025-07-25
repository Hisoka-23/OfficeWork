Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Fruits() As String = {"Orange", "Banana", "APPle"}

        MessageBox.Show(Fruits(2))

        MessageBox.Show(Fruits.Length)

        For i As Integer = 0 To Fruits.Length - 1
            MessageBox.Show(Fruits(i))
        Next

    End Sub

End Class
