Imports System.Data.SqlClient

Public Class Form1

    Sub view()

        Dim connect As New SqlConnection("Data Source=MELIODAS\SQLEXPRESS2K14;Initial Catalog=ZDS_Office_practise;Persist Security Info=True;User ID=Prakash;Password=1234")

        connect.Open()

        Dim adp As New SqlDataAdapter("select * from Employee_info", connect)
        Dim ds As New DataSet
        adp.Fill(ds, "Employee")
        DataGridView1.DataSource = ds.Tables("Employee")

        connect.Close()

    End Sub

    Public Sub ShowData(ByVal CurrentRow)

        Try

            TextBox1.Text = ds.Tables("Employee").Rows(CurrentRow)("EmpId")
            TextBox2.Text = ds.Tables("Employee").Rows(CurrentRow)("EmpName")
            TextBox3.Text = ds.Tables("Employee").Rows(CurrentRow)("EmpAddress")
            TextBox4.Text = ds.Tables("Employee").Rows(CurrentRow)("EmpeProfile")

        Catch ex As Exception


            MessageBox.Show(ex.Message, "error")
            'MsgBox(ex.Message, "error")

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) Then

            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connect As New SqlConnection("Data Source=MELIODAS\SQLEXPRESS2K14;Initial Catalog=ZDS_Office_practise;Persist Security Info=True;User ID=Prakash;Password=1234")

        Dim EmpId As Integer = TextBox1.Text
        Dim EmpName As String = TextBox2.Text
        Dim EmpAddress As String = TextBox3.Text
        Dim EmpProfile As String = TextBox4.Text

        connect.Open()

        Dim command As New SqlCommand()
        command.Connection = connect
        command.CommandType = CommandType.Text
        command.CommandText = "insert into Employee_info values (" & EmpId & ", '" & EmpName & "', '" & EmpAddress & "', '" & EmpProfile & "')"
        command.ExecuteNonQuery()

        connect.Close()

        MsgBox("Record Saved Successfully", MsgBoxStyle.Information, "Message")

        view()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        view()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        view()

        Dim connect As New SqlConnection("Data Source=MELIODAS\SQLEXPRESS2K14;Initial Catalog=ZDS_Office_practise;Persist Security Info=True;User ID=Prakash;Password=1234")

        CurrentRow = 0

        connect.Open()

        adp = New SqlDataAdapter("Select * from Employee_info", connect)
        adp.Fill(ds, "Employee")
        ShowData(CurrentRow)

        connect.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) Then

            MessageBox.Show("Please fill in Employee Id and Updating information fields before Updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connect As New SqlConnection("Data Source=MELIODAS\SQLEXPRESS2K14;Initial Catalog=ZDS_Office_practise;Persist Security Info=True;User ID=Prakash;Password=1234")

        Dim EmpId As Integer = TextBox1.Text
        Dim EmpName As String = TextBox2.Text
        Dim EmpAddress As String = TextBox3.Text
        Dim EmpProfile As String = TextBox4.Text

        connect.Open()

        Dim command As New SqlCommand()
        command.Connection = connect
        command.CommandType = CommandType.Text
        command.CommandText = "update Employee_info set EmpName='" & EmpName & "', EmpAddress= '" & EmpAddress & "', EmpeProfile= '" & EmpProfile & "' where EmpId= " & EmpId & " "
        command.ExecuteNonQuery()

        connect.Close()

        MsgBox("Record Updated Successfully")

        view()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then

            MessageBox.Show("Please fill in Employee Id fields before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connect As New SqlConnection("Data Source=MELIODAS\SQLEXPRESS2K14;Initial Catalog=ZDS_Office_practise;Persist Security Info=True;User ID=Prakash;Password=1234")

        Dim EmpId As Integer = TextBox1.Text

        connect.Open()

        Dim command As New SqlCommand()
        command.Connection = connect
        command.CommandType = CommandType.Text
        command.CommandText = "delete from Employee_info where EmpId= " & EmpId & " "
        command.ExecuteNonQuery()

        connect.Close()

        MsgBox("Record delete successfully")

        view()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        CurrentRow = 0
        ShowData(CurrentRow)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        CurrentRow = ds.Tables("Employee").Rows.Count - 1
        ShowData(CurrentRow)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If CurrentRow <> 0 Then
            CurrentRow -= 1
            ShowData(CurrentRow)
        Else
            MsgBox("First Record is Reached!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If CurrentRow = ds.Tables("Employee").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!", MsgBoxStyle.Exclamation)
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""



    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        If String.IsNullOrEmpty(TextBox1.Text) = True Then
            TextBox1.Focus()
            ErrorProvider1.SetError(Me.TextBox1, "Pls Enter ID")
        Else
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave

        If String.IsNullOrEmpty(TextBox2.Text) = True Then
            TextBox1.Focus()
            ErrorProvider2.SetError(Me.TextBox2, "Pls Enter Name")
        Else
            ErrorProvider2.Clear()
        End If

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave

        If String.IsNullOrEmpty(TextBox3.Text) = True Then
            TextBox1.Focus()
            ErrorProvider3.SetError(Me.TextBox3, "Pls Enter Address")
        Else
            ErrorProvider3.Clear()
        End If

    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave

        If String.IsNullOrEmpty(TextBox4.Text) = True Then
            TextBox1.Focus()
            ErrorProvider4.SetError(Me.TextBox4, "Pls Enter Profile")
        Else
            ErrorProvider4.Clear()
        End If

    End Sub

End Class
