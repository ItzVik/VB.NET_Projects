Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Molim vas popunite sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Molim vas popunite sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Molim vas popunite sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Molim vas popunite sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckBox1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Ocene.txt", TextBox1.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Opisi.txt", TextBox2.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Ucenici.txt", TextBox3.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Predmeti.txt", TextBox4.Text, True)
            My.Computer.FileSystem.WriteAllText("c:\Dnevnik\Procitaj me.txt", "Znaci da vam objasnim. Ako je prva ocena(naprimer:5), a prvi ucenik(naprimer:Leo),a prvi predmet(naprimer:Srpski Jezik), a prvi opis(Naprimer:Grupni Rad) to znaci da je sve to od tog prvog ucenika. Pokusavam da to poboljsam. I sve ce vam verovatno biti spojeno tako da preporucujem da uvek kad nesto upisujete da na kraju stavite razmak. Nadam se da vam je ovo pomoglo!!", True)

            Dim x As Integer
            x = Integer.Parse(TextBox1.Text)
            Label5.Text = x

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        Else
            Dim x As Integer
            x = Integer.Parse(TextBox1.Text)
            Label5.Text = x

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Dobrodosli u Dnevnik! Mozda i ponovo?"
        NotifyIcon1.BalloonTipTitle = "Dnevnik"
        NotifyIcon1.ShowBalloonTip(2000)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        MessageBox.Show("U redu. Svaka naredna uneta ocenaa bice sacuvana u fajlu. Ali nemozete iskljuciti ovo dok ne ugasite program.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CheckBox1.Enabled = False

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
End Class
