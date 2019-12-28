Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Hello, This program was made by Hystel™, A.K.A Hystel Studios", "Info")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        MessageBox.Show("Thanks for clicking me, LOSER!", "HAHAHAHA")

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.Text = "Terms of service ACCEPTED!"
        CheckBox1.Enabled = False
        MessageBox.Show("Now that you accepted Terms of Service, You CANNOT uncheck it! Now you CANNOT report us, becuase you accepted!", "Info")
        Button1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        MessageBox.Show("This is an basic program, it may have some weird things, but its fun! By Hystel™, A.K.A Hystel Studios.", "Information")
    End Sub
End Class
