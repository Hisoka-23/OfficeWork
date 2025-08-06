Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TextBox2.Text = Request.QueryString("id")
        TextBox3.Text = Request.QueryString("name")
        TextBox4.Text = Request.QueryString("age")


    End Sub

End Class