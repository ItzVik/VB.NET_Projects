Imports System.Data.SqlClient
Imports System.IO

Public Class studentForm
    Inherits UserControl
    Private Shared _instance As studentForm

    Public Shared ReadOnly Property instance() As studentForm
        Get
            If _instance Is Nothing Then
                _instance = New studentForm

            End If
            Return _instance
        End Get

    End Property
    Public Sub disp_data1()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from students"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


        con.Close()

    End Sub

    Public Sub disp_data2()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from grades"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt


        con.Close()

    End Sub
    Private Sub studentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dwts1.Checked = True
        disp_data1()
        disp_data2()
        Timer1.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO [dbo].[grades] ([fname],[lname],[grade],[subject]) VALUES ('" + fname2.Text + "', '" + lname2.Text + "', '" + grade.Text + "', '" + subject.Text + "')", con)
        If (fname2.Text = "" And lname2.Text = "" And grade.Text = "" And subject.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully added the grade.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()
        End If
        con.Close()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO [dbo].[students] ([flname]) VALUES ('" & fname.Text & " " & lname.Text & "')", con)
        If (fname.Text = "" And lname.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully added the class.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()
        End If
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data1()
        disp_data2()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        disp_data1()
        disp_data2()
    End Sub
End Class
