Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Application("user") = UserTextBox.Text

        'Session.Add("user", UserTextBox.Text)
        Session("user") = UserTextBox.Text
        Response.Redirect("WebForm2.aspx")

        'Session.Add("pass", PassTextBox.Text)
        Session("pass") = PassTextBox.Text
        Response.Redirect("WebForm2.aspx")

    End Sub
End Class