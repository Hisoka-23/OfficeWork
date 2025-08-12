Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Drawing

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            BindDropDownList()
        End If

    End Sub

    Private Sub BindDropDownList()
        Dim Con As New SqlConnection(cs)
        Dim query As String = "SELECT * FROM zdsemployee"
        Dim sda As New SqlDataAdapter(query, Con)
        Dim data As New DataTable()
        sda.Fill(data)
        DropDownList1.DataSource = data
        DropDownList1.DataTextField = "name"
        DropDownList1.DataValueField = "id"
        DropDownList1.DataBind()

        Dim SelectItem As New ListItem("Select Employee", "-1")
        SelectItem.Selected = True
        DropDownList1.Items.Insert(0, SelectItem)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DropDownList1.SelectedValue = "-1" Then
            Response.Write("Please select an employee")
        Else
            'Response.Write("Select Item Text is: " & DropDownList1.SelectedItem.Text + "<br>")
            'Response.Write("Select Item value is: " & DropDownList1.SelectedItem.Value + "<br>")
            'Response.Write("Select Item Text is: " & DropDownList1.SelectedIndex)

            Dim Con As New SqlConnection(cs)
            Dim query As String = "SELECT * FROM zdsemployee where name = @name"
            Dim sda As New SqlDataAdapter(query, Con)
            sda.SelectCommand.Parameters.AddWithValue("@name", DropDownList1.SelectedItem.Text)
            Dim data As New DataTable()
            sda.Fill(data)
            GridView1.DataSource = data
            GridView1.DataBind()
            Label1.Text = "Rows Found"
            Label1.ForeColor = Color.Green
            Label1.Visible = True

        End If

    End Sub
End Class