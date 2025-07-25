Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iLow As Integer
        Dim iMax As Integer
        Dim i As Integer

        Dim evenCounter As Integer
        Dim oddCounter As Integer

        iLow = InputBox("Enter the Lower Number")
        iMax = InputBox("Enter the Max Number")

        For i = iLow To iMax
            If i Mod 2 = 0 Then
                evenCounter += 1
            Else
                oddCounter += 1
            End If
        Next

        MessageBox.Show(evenCounter & " :even numbers found")
        MessageBox.Show(oddCounter & " : odd numbers found")

    End Sub

End Class
