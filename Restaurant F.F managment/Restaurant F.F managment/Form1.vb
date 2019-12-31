Public Class Form1
    Dim a As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.username Then
            a += 1
        End If
        If TextBox2.Text = My.Settings.password Then
            a += 1

        End If
        If a = 2 Then
            MessageBox.Show("You are successfuly logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Main.Show()
        Else
            MessageBox.Show("Either username or password is incorrect!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        register.Show()

    End Sub
End Class
