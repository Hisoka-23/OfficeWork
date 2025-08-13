Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.IO

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim cs As String = ConfigurationManager.ConnectionStrings("dbcs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            fillGridView()
        End If

        If IsPostBack Then
            fillGridView()
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(cs)
        Dim mappath As String = Server.MapPath("images/")

        If FileUpload1.HasFile Then
            Dim fileName As String = Path.GetFileName(FileUpload1.FileName)
            Dim extension As String = Path.GetExtension(fileName)
            Dim postedFile As HttpPostedFile = FileUpload1.PostedFile
            Dim length As Integer = postedFile.ContentLength

            If extension.ToLower() = ".jpg" Or extension.ToLower() = ".png" Or extension.ToLower() = ".jpeg" Then
                If length <= 10000000 Then ' 10 MB
                    FileUpload1.SaveAs(mappath & fileName)
                    Dim name As String = "images/" & fileName

                    Dim query As String = "INSERT INTO image VALUES(@image)"
                    Dim cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@image", name)

                    con.Open()
                    Dim a As Integer = cmd.ExecuteNonQuery()

                    If a > 0 Then
                        Label1.Text = "Image inserted successfully....!"
                        Label1.ForeColor = System.Drawing.Color.Green
                        Label1.Visible = True
                        fillGridView()
                    Else
                        Label1.Text = "Inserting failed!"
                        Label1.ForeColor = System.Drawing.Color.Red
                        Label1.Visible = True
                    End If

                    con.Close()
                Else
                    Label1.Text = "Image file should not be greater than 10MB"
                    Label1.ForeColor = System.Drawing.Color.Red
                    Label1.Visible = True
                End If
            Else
                Label1.Text = "Image format is not supported"
                Label1.ForeColor = System.Drawing.Color.Red
                Label1.Visible = True
            End If
        Else
            Label1.Text = "Please upload an image"
            Label1.ForeColor = System.Drawing.Color.Red
            Label1.Visible = True
        End If
    End Sub

    Private Sub fillGridView()
        Dim con As New SqlConnection(cs)
        Dim query As String = "select * from image"
        Dim sda As New SqlDataAdapter(query, con)
        Dim data As New DataTable()
        sda.Fill(data)
        GridView1.DataSource = data
        GridView1.DataBind()
    End Sub

End Class