Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Dim connect As New SqlConnection("Data Source=AZIEN\SQLEXPRESS;Initial Catalog=CRUDTutorial_DB;Integrated Security=True")

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim productId As Integer = TxtProductID.Text
        Dim itemName As String = TxtItemName.Text
        Dim specification As String = TxtSpecification.Text
        Dim unit As String = DropUnit.SelectedValue
        Dim colour As String = RadioButtom.SelectedValue
        Dim insertdate As DateTime = TxtDate.Text
        Dim opening As Double = TxtOpeningQty.Text
        Dim status As String = ""
        If CheckRegular.Checked = True Then
            status = "Regular"
        Else
            status = "Irregular"
        End If

        connect.Open()
        Dim Command As New SqlCommand("Insert into ProductInfo_Tab values ('" & productId & "', '" & itemName & "', '" & specification & "', '" & unit & "', '" & colour & "', '" & insertdate & "', '" & opening & "', '" & status & "')", connect)
        Command.ExecuteNonQuery()
        MsgBox("Successfully Inserted", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Private Sub ListProduct()

        Dim Command As New SqlCommand("select * from ProductInfo_Tab", connect)
        Dim sd As New SqlDataAdapter(Command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim productId As Integer = TxtProductID.Text
        Dim itemName As String = TxtItemName.Text
        Dim specification As String = TxtSpecification.Text
        Dim unit As String = DropUnit.SelectedValue
        Dim colour As String = RadioButtom.SelectedValue
        Dim insertdate As DateTime = TxtDate.Text
        Dim opening As Double = TxtOpeningQty.Text
        Dim status As String = ""
        If CheckRegular.Checked = True Then
            status = "Regular"
        Else
            status = "Irregular"
        End If

        connect.Open()
        Dim Command As New SqlCommand("Update ProductInfo_Tab set ItemName =  '" & itemName & "', Specification = '" & specification & "', Unit = '" & unit & "', Color = '" & colour & "', InsertDate = '" & insertdate & "', Opening = '" & opening & "', Status = '" & status & "' where ProductID = '" & productId & "' ", connect)
        Command.ExecuteNonQuery()
        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        ListProduct()

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim productId As Integer = TxtProductID.Text

        connect.Open()
        Dim Command As New SqlCommand("Delete ProductInfo_Tab where ProductID = '" & productId & "' ", connect)
        Command.ExecuteNonQuery()
        MsgBox("Successfully Delete", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim productId As Integer = TxtProductID.Text

        Dim Command As New SqlCommand("select * from ProductInfo_Tab where ProductID = '" & productId & "'", connect)
        Dim sd As New SqlDataAdapter(Command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim productId As Integer = TxtProductID.Text
        Dim itemName As String = TxtItemName.Text
        Dim specification As String = TxtSpecification.Text
        Dim unit As String = DropUnit.SelectedValue
        Dim colour As String = RadioButtom.SelectedValue
        Dim insertdate As DateTime = TxtDate.Text
        Dim opening As Double = TxtOpeningQty.Text
        Dim status As String = ""
        If CheckRegular.Checked = True Then
            status = "Regular"
        Else
            status = "Irregular"
        End If

        TxtProductID.Text = ""
        TxtItemName.Text = ""
        TxtSpecification.Text = ""
        DropUnit.SelectedValue = "Select"
        RadioButtom.ClearSelection()
        TxtDate.Text = "dd-mm-yyyy"
        TxtOpeningQty.Text = ""
        CheckRegular.Checked= False

        ListProduct()

    End Sub

End Class