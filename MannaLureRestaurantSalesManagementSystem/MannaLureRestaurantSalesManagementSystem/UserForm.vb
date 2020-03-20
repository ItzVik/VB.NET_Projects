Imports System.Data.SqlClient
Imports System.Data

Public Class UserForm

    Inherits UserControl
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private Shared _instance As UserForm
    Public Shared ReadOnly Property Instance() As UserForm
        Get
            If _instance Is Nothing Then
                _instance = New UserForm()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim(cmbUserName.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUserName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFirstName.Text)) = 0 Then
            MessageBox.Show("Please enter First Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtLastName.Text)) = 0 Then
            MessageBox.Show("Please enter Last Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please enter contact no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If
        If Len(Trim(txtMail.Text)) = 0 Then
            MessageBox.Show("Please enter Mail", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMail.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select UserName from UserTable where UserName=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "UserName"))
            cmd.Parameters("@find").Value = cmbUserName.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("User Name Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbUserName.Text = ""
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
            Else

                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into UserTable VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 50, "UserName"))

                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 50, "Password"))

                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.NChar, 50, "FirstName"))

                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 50, "LastName"))

                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NChar, 50, "DOB"))

                cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NChar, 50, "Location"))

                cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.NChar, 50, "ContactNo"))

                cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.NChar, 50, "Mail"))

                cmd.Parameters.Add(New SqlParameter("@d9", System.Data.SqlDbType.NChar, 50, "UserType"))

                cmd.Parameters("@d1").Value = Trim(cmbUserName.Text)

                cmd.Parameters("@d2").Value = Trim(txtPassword.Text)

                cmd.Parameters("@d3").Value = Trim(txtFirstName.Text)

                cmd.Parameters("@d4").Value = Trim(txtLastName.Text)

                cmd.Parameters("@d5").Value = Trim(dateTimePicker1.Text)

                cmd.Parameters("@d6").Value = Trim(txtLocation.Text)

                cmd.Parameters("@d7").Value = Trim(txtContactNo.Text)

                cmd.Parameters("@d8").Value = Trim(txtMail.Text)

                cmd.Parameters("@d9").Value = Trim(cmbUserType.Text)

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con = New SqlConnection(cs)
                con.Open()
                fillcombo()
                Clear()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Clear()
        txtContactNo.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtLocation.Text = ""
        txtMail.Text = ""
        txtPassword.Text = ""
        fillcombo()
        cmbUserType.Items.Clear()
    End Sub
    Sub fillcombo()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(UserName) FROM UserTable", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbUserName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbUserName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If cmbUserName.Text = "" Then
                MessageBox.Show("Please select user name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If cmbUserName.Items.Count > 0 Then
                If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    delete_records()
                    btnEdit.Visible = False
                    btnDelete.Visible = False
                    btnView.Visible = False
                    btnSave.Enabled = True
                    Clear()
                    cmbUserName.Text = ""
                    cmbUserType.Text = ""
                    fillcombo()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub delete_records()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from UserTable where UserName=@DELETE1;"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 30, "UserName"))
            cmd.Parameters("@DELETE1").Value = Trim(cmbUserName.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("sorry no record deleted")
                Clear()
                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
            Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserName.SelectedIndexChanged
        Try
            btnDelete.Visible = True
            btnEdit.Visible = True
            btnView.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select * from UserTable where UserName=@find"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "UserName"))
            cmd.Parameters("@find").Value = Trim(cmbUserName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                txtPassword.Text = Trim(rdr.GetString(2))
                txtFirstName.Text = Trim(rdr.GetString(3))
                txtLastName.Text = Trim(rdr.GetString(4))
                dateTimePicker1.Text = Trim(rdr.GetString(5))
                txtLocation.Text = Trim(rdr.GetString(6))
                txtContactNo.Text = Trim(rdr.GetString(7))
                txtMail.Text = Trim(rdr.GetString(8))
                cmbUserType.Text = Trim(rdr.GetString(9))
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If cmbUserName.Text = "" Then
                MessageBox.Show("Please select user name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "update UserTable set Password=@d2,FirstName=@d3,LastName=@d4,DOB=@d5,Location=@d6,ContactNo=@d7,Mail=@d8,UserType=@d9 where UserName=@d1"

            cmd = New SqlCommand(cb)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 50, "UserName"))

            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 50, "Password"))

            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.NChar, 50, "FirstName"))

            cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 50, "LastName"))

            cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NChar, 50, "DOB"))

            cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NChar, 50, "Location"))

            cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.NChar, 50, "ContactNo"))

            cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.NChar, 50, "Mail"))

            cmd.Parameters.Add(New SqlParameter("@d9", System.Data.SqlDbType.NChar, 50, "UserType"))

            cmd.Parameters("@d1").Value = Trim(cmbUserName.Text)

            cmd.Parameters("@d2").Value = Trim(txtPassword.Text)

            cmd.Parameters("@d3").Value = Trim(txtFirstName.Text)

            cmd.Parameters("@d4").Value = Trim(txtLastName.Text)

            cmd.Parameters("@d5").Value = Trim(dateTimePicker1.Text)

            cmd.Parameters("@d6").Value = Trim(txtLocation.Text)

            cmd.Parameters("@d7").Value = Trim(txtContactNo.Text)

            cmd.Parameters("@d8").Value = Trim(txtMail.Text)

            cmd.Parameters("@d9").Value = Trim(cmbUserType.Text)

            cmd.ExecuteReader()
            MessageBox.Show("Successfully Updated", "User details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnEdit.Visible = False
            btnDelete.Visible = False
            btnView.Visible = False
            btnSave.Enabled = True
            Clear()
            cmbUserName.Text = ""
            cmbUserType.Text = ""
            fillcombo()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        UserViewForm.ShowDialog()
    End Sub
End Class
