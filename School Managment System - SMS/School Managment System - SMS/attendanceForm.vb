Imports System.Data.SqlClient
Imports System.IO

Public Class attendanceForm
    Inherits UserControl
    Private Shared _instance As attendanceForm

    Public Shared ReadOnly Property instance() As attendanceForm
        Get
            If _instance Is Nothing Then
                _instance = New attendanceForm

            End If
            Return _instance
        End Get

    End Property
    Public Sub disp_data()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from attendance"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


        con.Close()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand(" INSERT INTO [dbo].[attendance] ([fname],[lname],[all]) VALUES ('" + fname.Text + "', '" + lname.Text + "', '" + "No" + "')", con)
        If (fname.Text = "" And lname.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully evidented the attendance.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()
        End If
        con.Close()

    End Sub

    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand(" INSERT INTO [dbo].[attendance] ([fname],[lname],[all]) VALUES ('" + "..." + "', '" + "..." + "', '" + "Yes" + "')", con)
        cmd.ExecuteNonQuery()
            MsgBox("Succerssfully evidented the attendance.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()

        con.Close()

    End Sub

    Private Sub attendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand(" INSERT INTO [dbo].[attendance] ([fname],[lname],[all]) VALUES ('" + "..." + "', '" + "..." + "', '" + count.Text + "')", con)
        If (count.Text = "") Then
            MessageBox.Show("Please enter the count of students.")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully evidented the attendance.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()
        End If
        con.Close()
    End Sub
End Class
