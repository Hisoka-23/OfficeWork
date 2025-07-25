Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim table(,) As Integer = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        }

        MessageBox.Show(table(0, 0))

    End Sub

End Class
