Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If FileUpload1.HasFile Then
            ' Get the uploaded file's extension
            Dim fileExtension As String = IO.Path.GetExtension(FileUpload1.FileName).ToLower()

            ' Check if the file is a PDF or CSV
            If fileExtension = ".pdf" Or fileExtension = ".csv" Then
                ' Specify target folder (here, within the application, e.g., "~/UploadedFiles")
                Dim folderName As String = "UploadedFiles"
                Dim folderPath As String = Server.MapPath("~/" & folderName)

                ' Create the folder if it doesn't exist
                If Not IO.Directory.Exists(folderPath) Then
                    IO.Directory.CreateDirectory(folderPath)
                End If

                ' Get filename and path
                Dim fileName As String = IO.Path.GetFileName(FileUpload1.PostedFile.FileName)
                Dim savePath As String = IO.Path.Combine(folderPath, fileName)

                ' Save the file
                FileUpload1.SaveAs(savePath)
                lblStatus.Text = "File uploaded successfully: " & fileName
            Else
                lblStatus.Text = "Only PDF and CSV files are allowed."
            End If
        Else
            lblStatus.Text = "Please select a file to upload."
        End If
    End Sub


End Class