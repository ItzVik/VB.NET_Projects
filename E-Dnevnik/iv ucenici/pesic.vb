
Imports System.IO
Public Class pesic
    Dim a As Integer = 0
    Dim path As String = "c:\Dnevnik"
    Dim path1 As String = "c:\Dnevnik\pesic"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
        login.Close()
        register.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a = 1 Then

        End If

        If TextBox1.Text = "" Then
            MessageBox.Show("Molim vas upisite ocenu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Molim vas upisite razlog!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Molim vas upisite predmet!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckBox1.Checked = True Then
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If

            CheckBox1.Enabled = False




            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\pesic\Ocena.txt", TextBox1.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\pesic\Opis.txt", TextBox2.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\pesic\Predmet.txt", TextBox3.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Procitaj me.txt", "Znaci da vam objasnim. Ako je prva ocena(naprimer:5), a prvi ucenik(naprimer:Leo),a prvi predmet(naprimer:Srpski Jezik), a prvi opis(Naprimer:Grupni Rad) to znaci da je sve to od tog prvog ucenika. Pokusavam da to poboljsam. I sve ce vam verovatno biti spojeno tako da preporucujem da uvek kad nesto upisujete da na kraju stavite razmak. Nadam se da vam je ovo pomoglo!!", True)


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

            MessageBox.Show("Uspesno ste upisali ocenu. Ocena je upisana u fajlu.", "Uspeh!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""


            MessageBox.Show("Uspesno ste upisali ocenu. Ocena nije upisana u fajlu.", "Uspeh!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        IV.Show()

    End Sub
End Class