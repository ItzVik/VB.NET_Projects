Public Class Main
    Dim dt As Date = Today

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        worker.Text = "Welcome, " + My.Settings.fname + " " + My.Settings.lname
        Time.Text = dt

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()
        register.Close()

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

 

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Me.Hide()
        Form1.Show()
    End Sub



    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Me.Close()
        Form1.Close()

    End Sub
End Class