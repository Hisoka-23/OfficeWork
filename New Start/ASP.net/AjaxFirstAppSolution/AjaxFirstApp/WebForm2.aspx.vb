Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

        Dim num1 As Integer = Int32.Parse(TextBox1.Text)
        Dim num2 As Integer = Int32.Parse(TextBox1.Text)
        Dim result As Integer = num1 + num2

        Label3.Text = result.ToString()
        Label3.Visible = True

    End Sub
End Class