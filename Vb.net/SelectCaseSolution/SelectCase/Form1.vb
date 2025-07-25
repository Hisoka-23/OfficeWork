Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim UserInput As Integer = InputBox("Enter your mark:", "User Input Box", "Enter Number Only")

        Select Case UserInput
            Case Is >= 90
                MessageBox.Show("Excellent, You have got an A")
            Case Is >= 80
                MessageBox.Show("Good Job!, You have got a B")
            Case Is >= 70
                MessageBox.Show("You got a C, try harder next time!")
            Case Is >= 60
                MessageBox.Show("You got a D grade")
            Case Else
                MessageBox.Show("You have failed and got a grade F")
        End Select

    End Sub

End Class
