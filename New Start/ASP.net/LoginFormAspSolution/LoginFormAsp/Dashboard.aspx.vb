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

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs)
        'SqlDataSource1.InsertParameters("name").DefaultValue =
        '    ((TextBox)GridView1.FooterRow.FindControl("FooterName")).Text

        SqlDataSource1.InsertParameters("name").DefaultValue =
    CType(GridView1.FooterRow.FindControl("FooterName1"), TextBox).Text

        SqlDataSource1.InsertParameters("gender").DefaultValue =
    CType(GridView1.FooterRow.FindControl("FooterDd1Gender"), DropDownList).SelectedValue

        SqlDataSource1.InsertParameters("class").DefaultValue =
    CType(GridView1.FooterRow.FindControl("FooterClass"), TextBox).Text

        Dim a As Integer = SqlDataSource1.Insert()

        If a > 0 Then
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('Insertion Sucessfully !!!')</script>")
        End If

    End Sub

End Class