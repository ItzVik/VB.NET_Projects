Public Class register
    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "" Then
            a += 1
        End If
        If Not TextBox2.Text = "" Then
            a += 1
        End If
        If Not TextBox3.Text = "" Then
            a += 1
        End If
        If Not TextBox4.Text = "" Then
            a += 1
        End If
        If Not TextBox5.Text = "" Then
            a += 1
        End If
        If Not TextBox6.Text = "" Then
            a += 1
        End If

        If a = 6 Then
            My.Settings.username = TextBox1.Text
            My.Settings.password = TextBox2.Text
            My.Settings.email = TextBox4.Text
            My.Settings.phoneNumber = TextBox4.Text
            My.Settings.fname = TextBox5.Text
            My.Settings.lname = TextBox6.Text
            My.Settings.restaurantName = TextBox7.Text

            My.Settings.Save()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""


            MessageBox.Show("Successfuly registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Please fill out all of the fields.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()

    End Sub
End Class