Imports System.IO
Imports System.Collections.Generic

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Check if any files were uploaded in the request
        If Request.Files.Count > 0 Then
            Dim statusMessages As New List(Of String)
            Dim folderName As String = "UploadedFiles"
            Dim folderPath As String = Server.MapPath("~/" & folderName)

            ' Create the target directory if it doesn't already exist
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            ' Loop through each file in the request
            For Each postedFile As String In Request.Files
                Dim file = Request.Files(postedFile)

                ' Ensure the file has content
                If file IsNot Nothing AndAlso file.ContentLength > 0 Then
                    Dim fileName As String = Path.GetFileName(file.FileName)
                    Dim fileExtension As String = Path.GetExtension(fileName).ToLower()

                    ' Validate the file extension
                    If fileExtension = ".pdf" Or fileExtension = ".csv" Then
                        Try
                            ' Combine path and filename and save the file
                            Dim savePath As String = Path.Combine(folderPath, fileName)
                            file.SaveAs(savePath)
                            statusMessages.Add("Successfully uploaded: " & fileName)
                        Catch ex As Exception
                            statusMessages.Add("Error uploading " & fileName & ": " & ex.Message)
                        End Try
                    Else
                        statusMessages.Add("Skipped (not a PDF/CSV): " & fileName)
                    End If
                End If
            Next

            ' Display the results to the user
            If statusMessages.Count > 0 Then
                lblStatus.Text = String.Join("<br />", statusMessages)
            Else
                lblStatus.Text = "No valid files were selected or uploaded."
            End If
        Else
            lblStatus.Text = "Please select one or more files to upload."
        End If
    End Sub

End Class