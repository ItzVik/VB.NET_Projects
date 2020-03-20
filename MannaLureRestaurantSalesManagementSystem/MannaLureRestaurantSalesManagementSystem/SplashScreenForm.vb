Public Class SplashScreenForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
