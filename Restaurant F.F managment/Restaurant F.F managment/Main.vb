Public Class Main
    Dim dt As Date = Today

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        worker.Text = "Welcome, " + My.Settings.fname + " " + My.Settings.lname

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()
        register.Close()

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

 

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()

    End Sub



    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Me.Close()
        Form1.Close()

    End Sub


    Private Sub btnDashboard_click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        sidepanel.Height = btnDashboard.Height
        sidepanel.Top = btnDashboard.Top
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        sidepanel.Height = btnMaster.Height
        sidepanel.Top = btnMaster.Top
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        sidepanel.Height = btnBilling.Height
        sidepanel.Top = btnBilling.Top
    End Sub

    Private Sub btnAdministration_Click(sender As Object, e As EventArgs) Handles btnAdministration.Click
        sidepanel.Height = btnAdministration.Height
        sidepanel.Top = btnAdministration.Top
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        sidepanel.Height = btnReports.Height
        sidepanel.Top = btnReports.Top
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        sidepanel.Height = btnRecords.Height
        sidepanel.Top = btnRecords.Top
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        sidepanel.Height = btnTools.Height
        sidepanel.Top = btnTools.Top
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        timer1.enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = DateAndTime.Now
    End Sub
End Class