Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ViewState("user") IsNot Nothing Then
            TextBox1.Text = ViewState("user").ToString()
        End If

        If ViewState("pass") IsNot Nothing Then
            TextBox2.Text = ViewState("pass").ToString()
        End If

    End Sub

End Class