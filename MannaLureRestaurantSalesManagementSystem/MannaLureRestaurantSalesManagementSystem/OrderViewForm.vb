Imports System.Data.SqlClient
Public Class OrderViewForm
    Dim rdr As SqlDataReader = Nothing
    Dim con As SqlConnection = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim cs As String = "Data Source=DESKTOP-U9SLC0V;Initial Catalog=MannaLureRestaurantSalesManagementSystem;User ID=sa;Password=Ramjanam@123"

    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(cs)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        Dim SelectQry = "Select OrderTable.OrderNo,OrderTable.CustomerName,OrderTable.ContactNo,OrderTable.Location,OrderDetailsTable.ItemName,OrderDetailsTable.Price,OrderDetailsTable.Quantity,OrderDetailsTable.Total From OrderTable Inner Join OrderDetailsTable On OrderTable.OrderNo= OrderDetailsTable.OrderNo"

        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New SqlCommand()
            Dim SampleDataAdapter = New SqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function

    Private Sub OrderViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            OrderForm.Instance.Show()
            OrderForm.Instance.txtOrderNo.Text = dr.Cells(0).Value.ToString()
            OrderForm.Instance.txtCustomerName.Text = dr.Cells(1).Value.ToString()
            OrderForm.Instance.txtContactNo.Text = dr.Cells(2).Value.ToString()
            OrderForm.Instance.txtLocation.Text = dr.Cells(3).Value.ToString()
            OrderForm.Instance.btnDelete.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class