Imports System.Data.SqlClient
Imports System.Data
Public Class OrderForm
    Inherits UserControl
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private Shared _instance As OrderForm
    Public Shared ReadOnly Property Instance() As OrderForm
        Get
            If _instance Is Nothing Then
                _instance = New OrderForm()
            End If
            Return _instance
        End Get
    End Property

    Sub Clear()
        txtCustomerName.Text = ""
        GrandTotal.Text = ""
        txtContactNo.Text = ""
        txtItemName.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        txtLocation.Text = ""
        txtSubPrice.Text = ""
        listView1.Items.Clear()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Autocomplete()
        Clear()
    End Sub
    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = "Select Max(ID+1) From OrderTable"
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If Convert.IsDBNull(cmd.ExecuteScalar()) Then
            Num = 1
            lblOrderNo.Text = Convert.ToString(Num)
            txtOrderNo.Text = Convert.ToString("Order-" & Num)
        Else
            Num = CInt((cmd.ExecuteScalar()))
            lblOrderNo.Text = Convert.ToString(Num)
            txtOrderNo.Text = Convert.ToString("Order-" & Num)
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub Autocomplete()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT ItemName FROM MenuItemTable", con)
            Dim ds As DataSet = New DataSet()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds, "ItemName")
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            Dim i As Integer = 0

            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("ItemName").ToString())
            Next

            txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtItemName.AutoCompleteCustomSource = col
            txtItemName.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Len(Trim(txtItemName.Text)) = 0 Then
                MessageBox.Show("Please Enter Item Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtItemName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtQuantity.Text)) = 0 Then
                MessageBox.Show("Please Enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQuantity.Focus()
                Exit Sub
            End If
            Dim temp As Integer
            temp = listView1.Items.Count()
            If temp = 0 Then
                Dim i As Integer
                Dim lst As New ListViewItem(i)
                lst.SubItems.Add(txtItemName.Text)
                lst.SubItems.Add(txtSubPrice.Text)
                lst.SubItems.Add(txtQuantity.Text)
                lst.SubItems.Add(txtPrice.Text)
                listView1.Items.Add(lst)
                i = i + 1
                GrandTotal.Text = subtot()
                txtItemName.Text = ""
                txtSubPrice.Text = ""
                txtQuantity.Text = ""
                txtPrice.Text = ""
                Exit Sub
            End If

            For j = 0 To temp - 1
                If (listView1.Items(j).SubItems(1).Text = txtItemName.Text) Then
                    MessageBox.Show("Product Code already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtItemName.Text = ""
                    txtSubPrice.Text = ""
                    txtQuantity.Text = ""
                    txtPrice.Text = ""
                    Exit Sub

                End If
            Next j
            Dim k As Integer
            Dim lst1 As New ListViewItem(k)

            lst1.SubItems.Add(txtItemName.Text)
            lst1.SubItems.Add(txtSubPrice.Text)
            lst1.SubItems.Add(txtQuantity.Text)
            lst1.SubItems.Add(txtPrice.Text)
            listView1.Items.Add(lst1)
            k = k + 1
            GrandTotal.Text = subtot()
            txtItemName.Text = ""
            txtSubPrice.Text = ""
            txtQuantity.Text = ""
            txtPrice.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtCustomerName.Text)) = 0 Then
                MessageBox.Show("Please Enter Customer Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCustomerName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtContactNo.Text)) = 0 Then
                MessageBox.Show("Please Enter Customer Contact No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContactNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtLocation.Text)) = 0 Then
                MessageBox.Show("Please Enter Customer Location", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLocation.Focus()
                Exit Sub
            End If
            If listView1.Items.Count = 0 Then
                MessageBox.Show("sorry no product added", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select OrderNo from OrderTable where OrderNo=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NVarChar, 20, "OrderNo"))
            cmd.Parameters("@find").Value = txtOrderNo.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Order No. Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else

                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into OrderTable(OrderNo,CustomerName,ContactNo,Location,OrderDate,GrandTotal) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NVarChar, 20, "OrderNo"))

                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NVarChar, 50, "CustomerName"))

                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.NVarChar, 20, "ContactNo"))

                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NVarChar, 100, "Location"))

                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NVarChar, 10, "OrderDate"))

                cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NVarChar, 10, "OrderDate"))

                cmd.Parameters("@d1").Value = txtOrderNo.Text

                cmd.Parameters("@d2").Value = txtCustomerName.Text

                cmd.Parameters("@d3").Value = txtContactNo.Text

                cmd.Parameters("@d4").Value = txtLocation.Text

                cmd.Parameters("@d5").Value = DateTimePicker2.Text

                cmd.Parameters("@d6").Value = GrandTotal.Text

                cmd.ExecuteReader()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()

                For i = 0 To listView1.Items.Count - 1

                    con = New SqlConnection(cs)

                    Dim cd As String = "insert into OrderDetailsTable(OrderNo,ItemName,Price,Quantity,Total) VALUES (@OrderNo,@ItemName,@Price,@Quantity,@Total)"

                    cmd = New SqlCommand(cd)

                    cmd.Connection = con

                    cmd.Parameters.AddWithValue("OrderNo", txtOrderNo.Text)
                    cmd.Parameters.AddWithValue("ItemName", listView1.Items(i).SubItems(1).Text)
                    cmd.Parameters.AddWithValue("Price", listView1.Items(i).SubItems(2).Text)
                    cmd.Parameters.AddWithValue("Quantity", listView1.Items(i).SubItems(3).Text)
                    cmd.Parameters.AddWithValue("Total", listView1.Items(i).SubItems(4).Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                Next

                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Autocomplete()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If listView1.Items.Count = 0 Then
                MsgBox("No items to remove", MsgBoxStyle.Critical, "Error")
            Else
                Dim itmCnt, i, t As Integer
                listView1.FocusedItem.Remove()
                itmCnt = listView1.Items.Count
                t = 1
                For i = 1 To itmCnt + 1
                    t = t + 1
                Next
                GrandTotal.Text = subtot()
            End If
            btnRemove.Visible = False
            If listView1.Items.Count = 0 Then
                GrandTotal.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listView1.SelectedIndexChanged
        btnRemove.Visible = True
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        Try
            txtItemName.Text = txtItemName.Text.TrimEnd()
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()

            cmd.CommandText = "SELECT * from MenuItemTable where ItemName ='" & txtItemName.Text & "'"
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                txtSubPrice.Text = (rdr.GetString(8).Trim())
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

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Try
            Dim val1 As Double = 0
            Dim val2 As Double = 0
            Double.TryParse(txtSubPrice.Text, val1)
            Double.TryParse(txtQuantity.Text, val2)
            val1 = Math.Round(val1, 2)
            val2 = Math.Round(val2, 2)
            Dim I As Double = (val1 * val2)
            I = Math.Round(I, 2)
            txtPrice.Text = I.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        OrderViewForm.DataGridView1.DataSource = Nothing
        OrderViewForm.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If txtOrderNo.Text = "" Then
                MessageBox.Show("Please select Order No", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                delete_records()
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
            Dim cq As String = "delete from OrderTable where OrderNo=@DELETE1;"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 30, "OrderNo"))
            cmd.Parameters("@DELETE1").Value = Trim(txtOrderNo.Text)
            RowsAffected = cmd.ExecuteNonQuery()

            con = New SqlConnection(cs)
            con.Open()

            Dim cb2 As String = "delete from OrderDetailsTable where OrderNo ='" & txtOrderNo.Text & "'"

            cmd = New SqlCommand(cb2)

            cmd.Connection = con


            cmd.ExecuteReader()
            con.Close()

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

    Public Function subtot() As Double
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0
        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + CInt(listView1.Items(i).SubItems(4).Text)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k
    End Function
End Class
