Public Class Form1

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Dim StrFirstName As String
        Dim StrLastName As String
        Dim StrEmail As String
        Dim StrSelectedGame As String

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmail.Text
        StrSelectedGame = LstBoxSelectGames.SelectedItem

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName & " , it is your emial : " & StrEmail & " and would like to play " & StrSelectedGame)

        TxtBoxFirstName.Text = ""
        TxtBoxLastName.Text = ""
        TxtBoxEmail.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LstBoxSelectedGames.Items.Add(LstBoxSelectGames.SelectedItem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        LstBoxSelectedGames.Items.Remove(LstBoxSelectGames.SelectedItem)

    End Sub
End Class
