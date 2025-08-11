Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim L1 As New ListItem("Select", "1")
            Dim L2 As New ListItem("Noida", "2")
            Dim L3 As New ListItem("Delhi", "3")
            Dim L4 As New ListItem("Japan", "4", False)
            Dim L5 As New ListItem("USA", "5", False)

            DropDownList1.Items.Add(L1)
            DropDownList1.Items.Add(L2)
            DropDownList1.Items.Add(L3)
            DropDownList1.Items.Add(L4)
            DropDownList1.Items.Add(L5)
            DropDownList1.Items(1).Selected = True

        End If




    End Sub

End Class