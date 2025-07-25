Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' & : Specifically for string concatenation, automatically converts numbers to strings , and is the safest option when working with both strings and numeric values.

        ' + : Can be used for both string concatenation and numeric addition, but can lead to ambiguity if you're mixing numbers and strings
        Dim A As String = 123
        Dim B As String = "456"

        Dim Result As String = A & B

        MessageBox.Show(Result)

    End Sub

End Class
