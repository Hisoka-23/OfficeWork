Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cs As String = ConfigurationManager.ConnectionStrings("docs2").ConnectionString

        Dim con As New SqlConnection(cs)
        Dim Query As String = "select * from login where username = @username and password = @password"
        Dim cmd As New SqlCommand(Query, con)
        cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        cmd.Parameters.AddWithValue("@password", TextBox2.Text)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.HasRows Then
            Session("username") = TextBox1.Text
            'Session("password") = PassTextBox.Text
            'Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('Login Successfull !!')</script>")
            Response.Redirect("Dashboard.aspx")
        Else
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('Login Falied !!')</script>")
        End If
        con.Close()

    End Sub

End Class