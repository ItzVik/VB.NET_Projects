Imports System.Data.SqlClient
Imports System.IO

Public Class classForm
    Inherits UserControl
    Private Shared _instance As classForm

    Public Shared ReadOnly Property instance() As classForm
        Get
            If _instance Is Nothing Then
                _instance = New classForm

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
        cmd.CommandText = "select * from classes"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


        con.Close()

    End Sub
    Private Sub classForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO [dbo].[classes] ([class]) VALUES ('" + TextBox1.Text + "')", con)
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully added the class.", MsgBoxStyle.Information, "Success")
            TextBox1.Clear()
        End If
        con.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        disp_data()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        disp_data()

    End Sub
End Class
