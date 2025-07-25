Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim A As Integer
        'Dim B As Integer

        '<> is not(unequal)
        '< lessThen
        '> greaterThen
        'Less Than equal <=
        'greater Than equal >=

        'If A = B Then
        'MessageBox.Show("A is equal to B")
        'Else
        'MessageBox.Show("A is not equal to B")
        'End If

        Dim Car1 As Object = 123456
        Dim Car2 As Object = Car1
        Dim Car3 As Object = "HondaWhiteCar"

        'If Car1 IsNot Car2 Then
        'MessageBox.Show("Car1 and Car refers to the same object")
        'ElseIf Car3 IsNot Car1 Then
        'MessageBox.Show("Car1 and Car3 refers to the different object")
        'End If

        If TypeOf Car1 Is String Then
            MessageBox.Show("Car1 is a string type")
        Else
            MessageBox.Show("Car1 is not a string type")
        End If

    End Sub

End Class
