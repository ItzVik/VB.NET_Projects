Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Panel1.Width += 1
            If Panel1.Width = 177 Then
                Timer1.Stop()
                Me.Hide()
                loginForm.Show()

            End If

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class