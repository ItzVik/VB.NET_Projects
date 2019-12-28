Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(500, "click me!", "I'm here!", ToolTipIcon.Info)
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
        NotifyIcon1.ShowBalloonTip(500, "Hello", "Im back!", ToolTipIcon.Info)
    End Sub
End Class
