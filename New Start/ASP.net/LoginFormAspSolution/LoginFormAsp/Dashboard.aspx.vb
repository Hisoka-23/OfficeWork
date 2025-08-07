Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("username") IsNot Nothing Then
            Response.Write("Welcome to my site " + Session("username").ToString)
        Else
            Response.Redirect("Login.aspx")
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Session("username") IsNot Nothing Then
            Session("username") = Nothing
            Response.Redirect("Login.aspx")
        End If

    End Sub
End Class