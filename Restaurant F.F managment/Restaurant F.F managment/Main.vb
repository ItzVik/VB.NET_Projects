Public Class Main


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        worker.Text = My.Settings.fname + " " + My.Settings.lname

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        calculator.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()
        register.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        order.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class