Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate

        Dim value As Integer = Integer.Parse(args.Value)

        If value Mod 2 = 0 Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If

    End Sub

End Class