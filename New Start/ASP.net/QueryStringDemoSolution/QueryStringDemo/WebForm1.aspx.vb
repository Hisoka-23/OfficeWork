Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Response.Redirect("WebForm2.aspx?id=" + Server.UrlEncode(IdTextBox.Text) + "&name=" + Server.UrlEncode(NameTextBox.Text) + "&age=" + Server.UrlEncode(AgeTextBox.Text))

    End Sub

End Class