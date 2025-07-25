Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim FirstNumber As Integer
        'Dim SecondNumber As Integer
        'Dim Result As Integer

        'FirstNumber = 2
        'SecondNumber = 3

        'Add: *'
        'Result = FirstNumber + SecondNumber
        'subtract: *
        'Result = FirstNumber - SecondNumber
        'Negation
        'Result = -FirstNumber + SecondNumber
        'Multiple
        'Result = FirstNumber * SecondNumber
        'Divide
        'Result = FirstNumber / SecondNumber
        'Quotient *:
        'Result = FirstNumber \ SecondNumber
        'Mod :
        'Result = FirstNumber Mod SecondNumber
        'power
        'Result = FirstNumber ^ SecondNumber

        'MessageBox.Show(Result)


        ''bit shift
        Dim MyNumber As Integer
        Dim Result As Integer

        MyNumber = 5
        MyNumber = MyNumber >> 1
        Result = Convert.ToString(MyNumber, 2)
        MessageBox.Show(Result)

    End Sub

End Class
