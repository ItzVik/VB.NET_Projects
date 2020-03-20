Imports System.Data.SqlClient
Imports System.Data
Public Class BillForm
    Inherits UserControl
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private Shared _instance As BillForm
    Public Shared ReadOnly Property Instance() As BillForm
        Get
            If _instance Is Nothing Then
                _instance = New BillForm()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Autocomplete()
    End Sub

    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = "Select Max(ID+1) From BillTable"
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If Convert.IsDBNull(cmd.ExecuteScalar()) Then
            Num = 1
            lblBillNo.Text = Convert.ToString(Num)
            txtBillNo.Text = Convert.ToString("Bill-" & Num)
        Else
            Num = CInt((cmd.ExecuteScalar()))
            lblBillNo.Text = Convert.ToString(Num)
            txtBillNo.Text = Convert.ToString("Bill-" & Num)
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub

    Private Sub Autocomplete()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT OrderNo FROM OrderTable Where Status Is Null", con)
            Dim ds As DataSet = New DataSet()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds, "OrderNo")
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            Dim i As Integer = 0

            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("OrderNo").ToString())
            Next

            txtOrderNo.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtOrderNo.AutoCompleteCustomSource = col
            txtOrderNo.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Autocomplete()
    End Sub

    Private Sub txtOrderNo_TextChanged(sender As Object, e As EventArgs) Handles txtOrderNo.TextChanged
        Try
            txtOrderNo.Text = txtOrderNo.Text.TrimEnd()
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()

            cmd.CommandText = "SELECT * from OrderTable where OrderNo ='" & txtOrderNo.Text & "'"
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                txtPrice.Text = (rdr.GetString(6).Trim())
            End If

            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Public Sub Calculate()
        Try
            Dim val1 As Double = 0
            Dim val2 As Double = 0
            Dim val3 As Double = 0
            Dim val4 As Double = 0

            If txtVat.Text <> "" Then
                val1 = Convert.ToDouble((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtVat.Text) / 100))
                val1 = Math.Round(val1, 2)
                txtTaxAmt.Text = val1.ToString()
            End If

            If txtDiscount.Text <> "" Then
                val3 = Convert.ToDouble(((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(txtTaxAmt.Text)) * Convert.ToDouble(txtDiscount.Text) / 100))
                val3 = Math.Round(val3, 2)
                txtDiscountAmount.Text = val3.ToString()
            End If

            Double.TryParse(txtTaxAmt.Text, val1)
            Double.TryParse(txtPrice.Text, val2)
            Double.TryParse(txtDiscountAmount.Text, val3)
            Double.TryParse(txtTotalPrice.Text, val4)
            val1 = Math.Round(val1, 2)
            val2 = Math.Round(val2, 2)
            val3 = Math.Round(val3, 2)
            val4 = val1 + val2 - val3
            val4 = Math.Round(val4, 2)
            txtTotalPrice.Text = val4.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub txtVat_TextChanged(sender As Object, e As EventArgs) Handles txtVat.TextChanged
        Try

            If String.IsNullOrEmpty(txtVat.Text) Then
                txtTaxAmt.Text = ""
                txtTotalPrice.Text = ""
                Return
            End If

            Calculate()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        Calculate()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim(txtOrderNo.Text)) = 0 Then
            MessageBox.Show("Please enter order number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrderNo.Focus()
            Exit Sub
        End If
        Try
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select OrderNo from BillTable where OrderNo=@find"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "OrderNo"))
            cmd.Parameters("@find").Value = txtOrderNo.Text
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Order Number Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "insert into BillTable(BillNo,OrderNo,Price,Discount,Totaltax,TotalPrice) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 50, "BillNo"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 50, "OrderNo"))
                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 50, "Price"))
                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.VarChar, 50, "Discount"))
                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.VarChar, 50, "Totaltax"))
                cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.VarChar, 50, "TotalPrice"))
                cmd.Parameters("@d1").Value = txtBillNo.Text
                cmd.Parameters("@d2").Value = txtOrderNo.Text
                cmd.Parameters("@d3").Value = txtPrice.Text
                cmd.Parameters("@d4").Value = txtDiscountAmount.Text
                cmd.Parameters("@d5").Value = txtTaxAmt.Text
                cmd.Parameters("@d6").Value = txtTotalPrice.Text
                cmd.ExecuteReader()


                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "Update OrderTable set Status='Paid' Where OrderNo ='" & txtOrderNo.Text & "'"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                MessageBox.Show("Successfully saved", "Bill Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
                clear()
                btnDelete.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub clear()
        txtBillNo.Text = ""
        txtDiscount.Text = ""
        txtDiscountAmount.Text = ""
        txtOrderNo.Text = ""
        txtPrice.Text = ""
        txtTaxAmt.Text = ""
        txtTotalPrice.Text = ""
        txtVat.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If txtBillNo.Text = "" Then
                MessageBox.Show("Please select Bill No", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                delete_records()
                btnDelete.Visible = False
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
            Dim cq As String = "delete from BillTable where BillNo=@DELETE1;"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NVarChar, 30, "BillNo"))
            cmd.Parameters("@DELETE1").Value = Trim(txtBillNo.Text)
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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        BillViewForm.DataGridView1.DataSource = Nothing
        BillViewForm.ShowDialog()
    End Sub
End Class
