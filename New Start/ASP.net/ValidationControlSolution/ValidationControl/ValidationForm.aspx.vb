Public Class ValidationForm
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('YOUR FORM HAS BEEN SUBMIT')</script>")
    End Sub

End Class