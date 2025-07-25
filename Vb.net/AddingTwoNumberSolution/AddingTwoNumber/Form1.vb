Public Class Form1

    REM This program is for adding 2 number

    'This program is for adding 2 number

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        'These are the variables to hold values entered by user'
        Dim IntNumber1 As Integer
        Dim IntNumber2 As Integer 'this is to hold the second value'
        Dim IntSum As Integer

        IntNumber1 = TxtBoxNumber1.Text
        IntNumber2 = TxtBoxNumber2.Text

        IntSum = IntNumber1 + IntNumber2

        TxtBoxSum.Text = IntSum

    End Sub
End Class
