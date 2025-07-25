Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim A As Boolean = True
        Dim B As Boolean = False

        '1. And (Logical And):
        'The And operator returns True if both conditions are true.
        'If either Or both conditions are false, it returns false.

        '2. Or (Logical OR):
        'The Or operator returns True if at least one condition is True.
        'If both Then conditions are false, it returns false

        '3. Not (Logical NOt):
        'The Not operator reverse the Boolean value of a condition.
        'It returns True If the condition Is False,
        'And False if the codition Is True.

        '4. AndAlso (Short-circuiting AND):
        'The AndAlso operator behave Like And but has an importand difference:
        'if Short - circuits
        'This means that if the first condition is False,
        'it does Not evaluate the second condition, because the result will alway be false.

        '5. OrElse (Short-Circiting OR):
        'The OrElse operator behaves Like Or but also short-circuits
        'If the first condition Is True, if does Not evaluate second codition,
        'becuase the result will always be true

        '6. Xor (Logical Exclusive OR):
        'The Xor operator returns True if one of the conditions is True, but Not both
        'If both conditions are the same (True Or False), it returns false.

        Dim result As Boolean = A AndAlso B
        MessageBox.Show(result)

    End Sub

End Class
