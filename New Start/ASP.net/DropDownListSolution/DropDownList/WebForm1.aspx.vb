Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            'DropDownList1.SelectedIndex = 1
            DropDownList1.SelectedValue = "1"

        End If

        'If Not IsPostBack Then

        '    'Dim L1 As New ListItem("Select", "1")
        '    'Dim L2 As New ListItem("Noida", "2")
        '    'Dim L3 As New ListItem("Delhi", "3")
        '    'Dim L4 As New ListItem("Japan", "4", False)
        '    'Dim L5 As New ListItem("USA", "5", False)

        '    'DropDownList1.Items.Add(L1)
        '    'DropDownList1.Items.Add(L2)
        '    'DropDownList1.Items.Add(L3)
        '    'DropDownList1.Items.Add(L4)
        '    'DropDownList1.Items.Add(L5)
        '    'DropDownList1.Items(1).Selected = True

        'End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DropDownList1.SelectedValue = "-1" Then
            Response.Write("Please select a city")
        Else
            Response.Write("Selected Item Text is: " & DropDownList1.SelectedItem.Text + "<br>")
            Response.Write("Selected Item values is: " & DropDownList1.SelectedItem.Value + "<br>")
            Response.Write("Selected Item values is: " & DropDownList1.SelectedValue + "<br>")
            Response.Write("Selected Item index is: " & DropDownList1.SelectedIndex)
        End If

    End Sub

End Class