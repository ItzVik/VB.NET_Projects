Imports System.Data
Imports System.Data.SqlClient
Public Class registerForm

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HYSTEL\HYSTELSQL;Initial Catalog=master;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO [dbo].[info] ([username] ,[password]  ,[email]) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + TextBox3.Text + "')", con)
        If (textBox1.Text = "" And textBox2.Text = "" And TextBox3.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    textBox1.Clear()
                    textBox2.Clear()
                    TextBox3.Clear()
                End If
        con.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        loginForm.Show()

    End Sub

    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub
End Class