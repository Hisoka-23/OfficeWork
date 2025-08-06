Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Not IsPostBack Then
        '    Response.Write("This is post back request !!")
        'End If

        If Not IsPostBack Then
            AddListBoxItems()
        End If

    End Sub

    Private Sub AddListBoxItems()
        ListBox1.Items.Add("Item 1")
        ListBox1.Items.Add("Item 2")
        ListBox1.Items.Add("Item 3")
        ListBox1.Items.Add("Item 4")
    End Sub


End Class