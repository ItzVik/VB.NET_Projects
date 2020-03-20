Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class LoginForm
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "" Then
            MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtUserName.Focus()
            Return
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtPassword.Focus()
            Return
        End If

        Try
            Dim myConnection As SqlConnection = Nothing
            myConnection = New SqlConnection(cs)
            Dim myCommand As SqlCommand = Nothing
            myCommand = New SqlCommand("SELECT UserName,Password FROM UserTable WHERE UserName = @username AND Password = @UserPassword", myConnection)
            Dim uName As SqlParameter = New SqlParameter("@username", SqlDbType.VarChar)
            Dim uPassword As SqlParameter = New SqlParameter("@UserPassword", SqlDbType.VarChar)
            uName.Value = txtUserName.Text
            uPassword.Value = txtPassword.Text
            myCommand.Parameters.Add(uName)
            myCommand.Parameters.Add(uPassword)
            myCommand.Connection.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            If myReader.Read() = True Then
                Me.Hide()
                Dim frm As HomeForm = New HomeForm()
                frm.Show()
            Else
                MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUserName.Clear()
                txtPassword.Clear()
                txtUserName.Focus()
            End If

            If myConnection.State = ConnectionState.Open Then
                myConnection.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.Exit()
    End Sub
End Class