Imports System.Configuration
Imports System.Data.SqlClient

Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cs As String = ConfigurationManager.ConnectionStrings("docs2").ConnectionString

        Dim con As New SqlConnection(cs)
        Dim query As String = "insert into signup values(@fname, @lname, @gender, @email, @address, @username, @password)"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@fname", FirstName.Text)
        cmd.Parameters.AddWithValue("@lname", LastName.Text)
        cmd.Parameters.AddWithValue("@gender", DropDownList1.Text)
        cmd.Parameters.AddWithValue("@email", Email.Text)
        cmd.Parameters.AddWithValue("@address", Address.Text)
        cmd.Parameters.AddWithValue("@username", UserName.Text)
        cmd.Parameters.AddWithValue("@password", Password.Text)
        con.Open()
        Dim a As Integer = cmd.ExecuteNonQuery()
        Dim script As String = "alert('Signup Successful! Username is: " + UserName.Text + " and Password : " + Password.Text + " ');"
        If a > 0 Then
            ClientScript.RegisterStartupScript(Me.GetType(), "SignupAlert", script, True)
            ClearControls()
        Else
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('Signup Falied !!')</script>")
        End If
        con.Close()

    End Sub

    Private Sub ClearControls()
        FirstName.Text = ""
        LastName.Text = ""
        Email.Text = ""
        Address.Text = ""
        UserName.Text = ""
        Password.Text = ""
        ConfirmPassword.Text = ""
        DropDownList1.ClearSelection()
    End Sub


End Class