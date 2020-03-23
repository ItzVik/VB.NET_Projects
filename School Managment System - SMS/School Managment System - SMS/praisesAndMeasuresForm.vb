Imports System.Data.SqlClient
Imports System.IO
Public Class praisesAndMeasuresForm
    Inherits UserControl
    Private Shared _instance As praisesAndMeasuresForm

    Public Shared ReadOnly Property instance() As praisesAndMeasuresForm
        Get
            If _instance Is Nothing Then
                _instance = New praisesAndMeasuresForm

            End If
            Return _instance
        End Get

    End Property
    Public Sub disp_data()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=192.168.56.1,49804;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from pam"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt


        con.Close()

    End Sub
    Private Sub praisesAndMeasuresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=192.168.56.1,49804;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO [dbo].[pam] ([fname],[lname],[type],[reason]) VALUES ('" + fname.Text + "', '" + lname.Text + "', '" + type.SelectedItem.ToString + "', '" + reason.Text + "')", con)
        If (fname.Text = "" And lname.Text = "" And reason.Text = "") Then
            MessageBox.Show("Please enter the details of student.")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Succerssfully evidented the Praise or Measure.", MsgBoxStyle.Information, "Success")
            fname.Clear()
            lname.Clear()
            reason.Clear()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disp_data()
    End Sub
End Class
