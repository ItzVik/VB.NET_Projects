Public Class register

    Dim a As Integer = 0

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Me.Hide()
        login.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "" Then
            a += 1
        End If

        If Not TextBox2.Text = "" Then
            a += 1
        End If

        If a = 2 Then
            My.Settings.Username = TextBox1.Text
            My.Settings.Password = TextBox2.Text
            My.Settings.Save()

            Me.Hide()
            login.Show()

            MessageBox.Show("Registracija uspesna!!", "Uspesno!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
        login.Close()
        IV.Close()

    End Sub
End Class