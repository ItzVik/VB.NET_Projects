Imports System.Data.SqlClient
Public Class CategoryForm
    Inherits UserControl
    Private Shared _instance As CategoryForm
    Public Shared ReadOnly Property Instance() As CategoryForm
        Get
            If _instance Is Nothing Then
                _instance = New CategoryForm()
            End If
            Return _instance
        End Get
    End Property
    Dim rdr As SqlDataReader = Nothing
    Dim con As SqlConnection = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"
    Sub clear()
        txtID.Text = ""
        txtCategoryName.Text = ""
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        clear()
    End Sub
    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = "Select Max(CategoryID+1) From CategoryTable"
        cmd = New SqlCommand(sql)
        cmd.Connection = con

        If Convert.IsDBNull(cmd.ExecuteScalar()) Then
            Num = 1
            lblID.Text = Convert.ToString(Num)
            txtID.Text = Convert.ToString("Cat-" & Num)
        Else
            Num = CInt((cmd.ExecuteScalar()))
            lblID.Text = Convert.ToString(Num)
            txtID.Text = Convert.ToString("Cat-" & Num)
        End If

        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim(txtCategoryName.Text)) = 0 Then
            MessageBox.Show("Please enter category name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategoryName.Focus()
            Exit Sub
        End If
        Try
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select CategoryName from CategoryTable where CategoryName=@find"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CategoryName"))
            cmd.Parameters("@find").Value = txtCategoryName.Text
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Category Name Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "insert into CategoryTable(CategoryID,CategoryName) VALUES (@d1,@d2)"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 50, "CategoryID"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 50, "CategoryName"))
                cmd.Parameters("@d1").Value = txtID.Text
                cmd.Parameters("@d2").Value = txtCategoryName.Text
                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Category Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
                clear()
                btnDelete.Visible = True
                btnEdit.Visible = True
                btnView.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        CategoryViewForm.DataGridView1.DataSource = Nothing
        CategoryViewForm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update CategoryTable set CategoryName=@d2 where CategoryID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.VarChar, 50, "CategoryID"))
            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 50, "CategoryName"))
            cmd.Parameters("@d1").Value = txtID.Text
            cmd.Parameters("@d2").Value = txtCategoryName.Text
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Category Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            btnDelete.Visible = True
            btnEdit.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If txtID.Text = "" Then
                MessageBox.Show("Please select user name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                delete_records()
                btnEdit.Visible = False
                btnDelete.Visible = False
                btnView.Visible = False
                btnSave.Enabled = True
                clear()
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
            Dim cq As String = "delete from CategoryTable where CategoryID=@DELETE1;"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 30, "CategoryID"))
            cmd.Parameters("@DELETE1").Value = Trim(txtID.Text)
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
End Class
