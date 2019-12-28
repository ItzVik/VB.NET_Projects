Public Class login
    Dim a As Integer = 0
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        register.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username Then
            a += 1
        End If
        If TextBox2.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MessageBox.Show("Uspesno ste se ulogovali!", "Uspeh!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Podaci koji su uneti nisu tacni!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
        IV.Close()
        register.Close()

    End Sub
End Class