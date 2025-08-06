Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("user") IsNot Nothing Then
            Response.Write("welcome " + Session("user").ToString())
        Else
            Response.Redirect("webForm1.aspx")
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Session("user") IsNot Nothing Then
            Session("user") = Nothing
            Response.Redirect("WebForm1.aspx")
        End If

    End Sub
End Class