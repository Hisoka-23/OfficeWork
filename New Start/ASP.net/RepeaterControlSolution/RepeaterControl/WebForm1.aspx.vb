Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As DataTable = GetData()

        GridView1.DataSource = dt 'provide data
        GridView1.DataBind() 'merge data with gridview

        Repeater1.DataSource = dt 'provide data
        Repeater1.DataBind() 'merge data with gridview

    End Sub

    Function GetData() As DataTable
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString
        Using con As New SqlConnection(cs)
            Dim query As String = "SELECT * FROM Emp"
            Dim sda As New SqlDataAdapter(query, con)
            Dim data As New DataTable()
            sda.Fill(data)
            Return data
        End Using
    End Function


End Class