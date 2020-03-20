Imports System.Data.SqlClient
Imports System.IO
Public Class employeeForm
    Inherits UserControl
    Private Shared _instance As employeeForm

    Public Shared ReadOnly Property instance() As employeeForm
        Get
            If _instance Is Nothing Then
                _instance = New employeeForm

            End If
            Return _instance
        End Get

    End Property
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Public Sub disp_data()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from employees"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


        con.Close()

    End Sub
    Private Sub buttonAdd_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("  INSERT INTO [dbo].[employees] ([fname],[lname])VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "')", con)
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully added the employee.", MsgBoxStyle.Information, "Success")
            TextBox1.Clear()
        End If
        con.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles Button3.Click
        disp_data()
    End Sub

    Private Sub employeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
    End Sub
End Class
