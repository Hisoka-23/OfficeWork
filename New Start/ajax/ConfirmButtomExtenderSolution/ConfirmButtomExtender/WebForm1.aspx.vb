Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Drawing

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim con As New SqlConnection(cs)
        Dim query As String = "SELECT * FROM temp WHERE id = @id"
        Dim sda As New SqlDataAdapter(query, con)
        sda.SelectCommand.Parameters.AddWithValue("@id", SearchTextBox.Text)
        Dim data As New DataTable()
        sda.Fill(data)

        If data.Rows.Count > 0 Then
            NameTextBox.Text = data.Rows(0)("name").ToString()
            ProfileTextBox.Text = data.Rows(0)("profile").ToString()

            Label1.Text = "Record found !!"
            Label1.ForeColor = Color.Green
            Label1.Visible = True
        Else
            Label1.Text = "Record not found !!"
            Label1.ForeColor = Color.Red
            Label1.Visible = True
            NameTextBox.Text = ""
            ProfileTextBox.Text = ""
        End If
    End Sub

    Protected Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim con As New SqlConnection(cs)
        Dim query As String = "update temp set name = @name, profile = @profile where id = @id"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@profile", ProfileTextBox.Text)
        cmd.Parameters.AddWithValue("@id", SearchTextBox.Text)
        con.Open()
        Dim a As Integer = cmd.ExecuteNonQuery()
        If a > 0 Then
            Response.Write("<script>alert(Updated Successfully!!!)</script>")
            NameTextBox.Text = ""
            ProfileTextBox.Text = ""
        Else
            Response.Write("<script>alert(Updated falid!!!)</script>")
            NameTextBox.Text = ""
            ProfileTextBox.Text = ""
        End If
        con.Close()
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim con As New SqlConnection(cs)
        Dim query As String = "delete from temp where id = @id"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", SearchTextBox.Text)
        con.Open()
        Dim a As Integer = cmd.ExecuteNonQuery()
        If a > 0 Then
            Response.Write("<script>alert(delete Successfully!!!)</script>")
            NameTextBox.Text = ""
            ProfileTextBox.Text = ""
        Else
            Response.Write("<script>alert(delete falid!!!)</script>")
            NameTextBox.Text = ""
            ProfileTextBox.Text = ""
        End If
        con.Close()
    End Sub

End Class