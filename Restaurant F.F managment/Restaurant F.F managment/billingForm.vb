Imports System.IO

Public Class billingForm

    Inherits UserControl
    Private Shared _instance As billingForm

    Public Shared ReadOnly Property instance() As billingForm
        Get
            If _instance Is Nothing Then
                _instance = New billingForm

            End If
            Return _instance
        End Get

    End Property

    Private Sub billingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restaurantname.Enabled = False
        restaurantname.Text = My.Settings.restaurantName
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        My.Computer.FileSystem.CreateDirectory("C:\Restaurant Managment Service\Billing")
        Dim strFile As String = "C:\Restaurant Managment Service\Billing\billing_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt"

        Dim sw As StreamWriter
        Dim fs As FileStream = Nothing

        If (Not File.Exists(strFile)) Then
            Try
                fs = File.Create(strFile)
                sw = File.AppendText(strFile)
                sw.WriteLine("Start Error Log for today")

            Catch ex As Exception
                MsgBox("Created Save File, but nothing saved! Please try again!", "Save Failed!")
            End Try
        Else
            sw = File.AppendText(strFile)
            sw.WriteLine("")
            sw.WriteLine("First Name : ")
            sw.WriteLine(fname.Text)
            sw.WriteLine("Last Name : ")
            sw.WriteLine(lname.Text)
            sw.WriteLine("Middle Name : ")
            sw.WriteLine(mname.Text)
            sw.WriteLine("Phone Number : ")
            sw.WriteLine(pnumber.Text)
            sw.WriteLine("Email : ")
            sw.WriteLine(email.Text)
            sw.WriteLine("Address : ")
            sw.WriteLine(address.Text)
            sw.WriteLine("Product : ")
            sw.WriteLine(product.Text)
            sw.WriteLine("Seller : ")
            sw.WriteLine(seller.Text)
            sw.WriteLine("Restaurant Name : ")
            sw.WriteLine(restaurantname.Text)
            sw.WriteLine("")


            sw.Close()
        End If

        product.Text = ""
        fname.Text = ""
        address.Text = ""
        email.Text = ""
        pnumber.Text = ""
        mname.Text = ""
        lname.Text = ""
        seller.Text = ""

        MessageBox.Show("You have saved the billing details!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
