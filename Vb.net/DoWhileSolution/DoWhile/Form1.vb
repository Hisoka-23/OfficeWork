Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Do While Loop Learning
        Dim x As Integer

        x = 0

        'while loop
        Do While x <= 5
            MessageBox.Show(x)
            x += 1
        Loop


        'Do while
        'Do
        'MessageBox.Show(x)
        'x += 1
        'Loop While x <= 5

        MessageBox.Show("Loop closed")

    End Sub

End Class
