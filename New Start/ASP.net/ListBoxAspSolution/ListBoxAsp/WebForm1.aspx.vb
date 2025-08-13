Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindListBox()
        End If
    End Sub

    Private Sub BindListBox()
        Dim con As New SqlConnection(cs)
        Dim query As String = "SELECT * FROM ListOfEmployee"
        Dim sda As New SqlDataAdapter(query, con)
        Dim data As New DataTable()
        sda.Fill(data)
        ListBox1.DataSource = data
        ListBox1.DataTextField = "name"
        ListBox1.DataValueField = "id"
        ListBox1.DataBind()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = "-1" Then
            Response.Write("Please select any name...!")
        Else
            For Each li As ListItem In ListBox1.Items
                If li.Selected Then
                    Response.Write("Selected Item Text is: " + li.Text + "<br>")
                    Response.Write("Selected Item Value is: " + li.Value + "<br>")
                    Response.Write("Selected Item Index is: " + ListBox1.Items.IndexOf(li).ToString + "<br>")
                    Response.Write("---------------------------------------------------------------" + "<br>")
                End If
            Next
        End If
    End Sub

End Class