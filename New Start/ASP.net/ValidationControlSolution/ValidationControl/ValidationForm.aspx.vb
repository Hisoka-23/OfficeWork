Public Class ValidationForm
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "Scripts", "<script>alert('YOUR FORM HAS BEEN SUBMIT')</script>")
    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate

        If MaleRadioButton.Checked OrElse FemaleRadioButton.Checked Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If

    End Sub

End Class