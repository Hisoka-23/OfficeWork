Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim a As String, b As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        ViewState("user") = UserTextBox.Text
        ViewState("pass") = PassTextBox.Text

        UserTextBox.Text = ""
        PassTextBox.Text = ""

        Response.Redirect("WebForm2.aspx")

    End Sub

    Protected Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click

        If ViewState("user") IsNot Nothing Then
            UserTextBox.Text = ViewState("user").ToString()
        End If

        If ViewState("pass") IsNot Nothing Then
            PassTextBox.Text = ViewState("pass").ToString()
        End If


    End Sub

End Class