Imports System.Data.SqlClient
Imports System.Data

Public Class MenuItemForm

    Inherits UserControl
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private Shared _instance As MenuItemForm
    Public Shared ReadOnly Property Instance() As MenuItemForm
        Get
            If _instance Is Nothing Then
                _instance = New MenuItemForm()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Hide()
        fillcombo()
        Clear()
    End Sub
    Sub Clear()
        txtHSNCode.Text = ""
        txtItemCode.Text = ""
        txtItemDescription.Text = ""
        txtItemName.Text = ""
        txtRate.Text = ""
        txtTotal.Text = ""
        txtTaxRate.Text = ""
        txtPrice.Text = ""
    End Sub
    Sub fillcombo()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(CategoryName) FROM CategoryTable", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCategory.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCategory.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = "Select Max(ID+1) From MenuItemTable"
        cmd = New SqlCommand(sql)
        cmd.Connection = con

        If Convert.IsDBNull(cmd.ExecuteScalar()) Then
            Num = 1
            lblItemCode.Text = Convert.ToString(Num)
            txtItemCode.Text = Convert.ToString("Item-" & Num)
        Else
            Num = CInt((cmd.ExecuteScalar()))
            lblItemCode.Text = Convert.ToString(Num)
            txtItemCode.Text = Convert.ToString("Item-" & Num)
        End If

        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Len(Trim(txtItemName.Text)) = 0 Then
            MessageBox.Show("Please Enter Item Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItemName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtItemDescription.Text)) = 0 Then
            MessageBox.Show("Please Enter Item Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItemDescription.Focus()
            Exit Sub
        End If
        If Len(Trim(txtHSNCode.Text)) = 0 Then
            MessageBox.Show("Please Enter HSN Code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHSNCode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtRate.Text)) = 0 Then
            MessageBox.Show("Please Enter Rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRate.Focus()
            Exit Sub
        End If
        If Len(Trim(txtTaxRate.Text)) = 0 Then
            MessageBox.Show("Please Enter Tax Rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTaxRate.Focus()
            Exit Sub
        End If
        If Len(Trim(txtTotal.Text)) = 0 Then
            MessageBox.Show("Please Enter Total", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotal.Focus()
            Exit Sub
        End If
        Try

            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select ItemName from MenuItemTable where ItemName=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "ItemName"))
            cmd.Parameters("@find").Value = txtItemName.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Item Name Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtItemName.Text = ""
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
            Else
                auto()
                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into MenuItemTable VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 50, "ItemCode"))

                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 50, "Category"))

                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.NChar, 50, "ItemName"))

                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NVarChar, 500, "ItemDesc"))

                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NChar, 50, "HSNCode"))

                cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NChar, 50, "Rate"))

                cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.NChar, 50, "TaxRate"))

                cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.NChar, 50, "Total"))

                cmd.Parameters("@d1").Value = Trim(txtItemCode.Text)

                cmd.Parameters("@d2").Value = Trim(cmbCategory.Text)

                cmd.Parameters("@d3").Value = Trim(txtItemName.Text)

                cmd.Parameters("@d4").Value = Trim(txtItemDescription.Text)

                cmd.Parameters("@d5").Value = Trim(txtHSNCode.Text)

                cmd.Parameters("@d6").Value = Trim(txtRate.Text)

                cmd.Parameters("@d7").Value = Trim(txtTaxRate.Text)

                cmd.Parameters("@d8").Value = Trim(txtPrice.Text)

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con = New SqlConnection(cs)
                con.Open()
                fillcombo()
                Clear()
                btnDelete.Visible = True
                btnEdit.Visible = True
                btnView.Visible = True
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItemForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        MenuItemViewForm.DataGridView1.DataSource = Nothing
        MenuItemViewForm.ShowDialog()
    End Sub

    Private Sub txtTaxRate_TextChanged(sender As Object, e As EventArgs) Handles txtTaxRate.TextChanged
        Try
            If txtTaxRate.Text = "" Then
                txtRate.Text = ""
                txtTotal.Text = ""
                Exit Sub
            End If
            txtTotal.Text = CInt((Val(txtRate.Text) * Val(txtTaxRate.Text)) / 100)
            txtPrice.Text = Val(txtRate.Text) + Val(txtTotal.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If txtItemCode.Text = "" Then
                MessageBox.Show("Please select Item Code", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                delete_records()
                btnEdit.Visible = False
                btnDelete.Visible = False
                btnSave.Enabled = True
                Clear()
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
            Dim cq As String = "delete from MenuItemTable where ItemCode=@DELETE1;"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 30, "ItemCode"))
            cmd.Parameters("@DELETE1").Value = Trim(txtItemCode.Text)
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update MenuItemTable set Category=@d2,ItemName=@d3,ItemDesc=@d4,HSNCode=@d5,Rate=@d6,TaxRate=@d7,Total=@d8 Where ItemCode=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.VarChar, 50, "ItemCode"))
            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 50, "Category"))
            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 50, "ItemName"))
            cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.VarChar, 50, "ItemDesc"))
            cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.VarChar, 50, "HSNCode"))
            cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.VarChar, 50, "Rate"))
            cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.VarChar, 50, "TaxRate"))
            cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.VarChar, 50, "Total"))
            cmd.Parameters("@d1").Value = txtItemCode.Text
            cmd.Parameters("@d2").Value = cmbCategory.Text
            cmd.Parameters("@d3").Value = txtItemName.Text
            cmd.Parameters("@d4").Value = txtItemDescription.Text
            cmd.Parameters("@d5").Value = txtHSNCode.Text
            cmd.Parameters("@d6").Value = txtRate.Text
            cmd.Parameters("@d7").Value = txtTaxRate.Text
            cmd.Parameters("@d8").Value = txtTotal.Text
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Menu Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Clear()
            btnDelete.Visible = False
            btnEdit.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
