Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'InputBox Function:
        'Syntax : InputBox(prompt, title, defaultResponse):
        'promt:
        'The message that prompts the user for input.

        'title:
        'the title of the input box window

        'default Response:
        'the default text that appears in the input box (optional)

        Dim UserInput As String = InputBox("Enter Your Name", "User Input Box", "Type your name here")

        MessageBox.Show(UserInput)

    End Sub

End Class
