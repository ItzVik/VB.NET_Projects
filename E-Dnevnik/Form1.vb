Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Dobrodosli u Dnevnik! Mozda i ponovo?"
        NotifyIcon1.BalloonTipTitle = "Dnevnik"
        NotifyIcon1.ShowBalloonTip(2000)

    End Sub


    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs)
        MessageBox.Show("Zdravo, Ovo je E-Dnevnik. Uglavnom, isti je kao svi. Ali ovaj nije na internetu vec na kompijeteru. Nadam se da ce te se snaci.", "Informacije", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.Show()
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Me.Show()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        MessageBox.Show("Nemojte tako, samo jednom kliknite!", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        MessageBox.Show("Nemojte tako, samo jednom kliknite!", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Close()
        register.Close()
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        IV.Show()

    End Sub
End Class
