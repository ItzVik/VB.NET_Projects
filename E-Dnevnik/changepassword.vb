Public Class changepassword
    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            a += 1
        ElseIf TextBox3.Text = My.Settings.email Then
            a += 1
        ElseIf Not a = 2 Then
            MessageBox.Show("Ili niste dobro ponovili lozinku, ili niste ponovili lozinku.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf a = 2 Then
            My.Settings.Password = TextBox1.Text
            My.Settings.Save()
            MessageBox.Show("Lozinka je uspesno promenjena!", "Uspeh!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


End Class