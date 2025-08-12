Imports System.Web.Services
Imports System.Web.Script.Services
Imports System.Data.SqlClient
Imports System.Configuration

Public Class WebForm1
    Inherits System.Web.UI.Page

    Shared cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <ScriptMethod()>
    <WebMethod()>
    Public Shared Function GetCompletional(prefixText As String, count As Integer) As List(Of String)
        ' TODO: Implement your logic here

        Dim CityName As New List(Of String)()

        ' Open SQL connection
        Using con As New SqlConnection(cs)
            Dim Query As String = "SELECT * FROM city_tbl WHERE cityname LIKE @name + '%'"
            Using cmd As New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@name", prefixText)

                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        CityName.Add(dr("cityName").ToString())
                    End While
                End Using
            End Using
        End Using

        Return CityName
    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim Con As New SqlConnection(cs)
        'Dim query As String = "SELECT * FROM zdsemployee where id = @id"
        'Dim sda As New SqlDataAdapter(query, Con)

        Dim Con As New SqlConnection(cs)
        Dim query As String = "SELECT * FROM city_tbl"
        Dim sda As New SqlDataAdapter(query, Con)
        Dim data As New DataTable()
        sda.Fill(data)
        If Not data Is Nothing Then
            If data.Rows.Count > 0 Then
                Dim id As String = data.Rows(0)("Id")
                ' Display TextBox text and the ID from DB
                Response.Write("city name Value: " & TextBox1.Text & "<br>")
                Response.Write("City ID from DB: " & id & "<br>")
            Else
                Response.Write("No data found in cityname table.<br>")
            End If
        End If



    End Sub

End Class