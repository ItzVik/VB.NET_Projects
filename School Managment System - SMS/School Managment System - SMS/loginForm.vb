Imports System.Data
Imports System.Data.SqlClient
Public Class loginForm
    Dim a As Integer
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        My.Settings.username = textBox1.Text
        My.Settings.Save()
        Dim con As New SqlConnection


        con.ConnectionString = "Data Source=192.168.56.1,49804;Initial Catalog=master;Integrated Security=True"

        Dim command As New SqlCommand("select * from info where username = @username and password = @password", con)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = textBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBox2.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Something went wrong! Details aren't correct! Try again!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            MessageBox.Show("Successfully logged in! Redirecting you to dashboard!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            dashboard.Show()

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        registerForm.Show()

    End Sub

    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Close()
        splashScreen.Close()

    End Sub
End Class
