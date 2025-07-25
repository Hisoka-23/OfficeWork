Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer
        Dim output As String

        For i = 10 To 0 Step -2
            output = output & i.ToString & Environment.NewLine
        Next
        MessageBox.Show(output)

    End Sub

End Class
