Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("user") IsNot Nothing Then
            Response.Write("welcome " + Session("user").ToString())
        Else
            Response.Redirect("webForm1.aspx")
        End If

    End Sub

End Class