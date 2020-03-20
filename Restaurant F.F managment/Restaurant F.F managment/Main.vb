Public Class Main
    Dim dt As Date = Today

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        worker.Text = "Welcome, " + My.Settings.fname + " " + My.Settings.lname
        sidepanel.Height = btnDashboard.Height
        sidepanel.Top = btnDashboard.Top
        If Not fillpanel.Controls.Contains(dashboardForm.instance) Then
            fillpanel.Controls.Add(dashboardForm.instance)
            dashboardForm.instance.Dock = DockStyle.Fill
            dashboardForm.instance.BringToFront()
        End If
        dashboardForm.instance.BringToFront()
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
        If Not fillpanel.Controls.Contains(dashboardForm.instance) Then
            fillpanel.Controls.Add(dashboardForm.instance)
            dashboardForm.instance.Dock = DockStyle.Fill
            dashboardForm.instance.BringToFront()
        End If
        dashboardForm.instance.BringToFront()
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        sidepanel.Height = btnMaster.Height
        sidepanel.Top = btnMaster.Top

        If Not fillpanel.Controls.Contains(MasterForm.instance) Then
            fillpanel.Controls.Add(MasterForm.instance)
            MasterForm.instance.Dock = DockStyle.Fill
            MasterForm.instance.BringToFront()
        End If
        MasterForm.instance.bringtofront()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        sidepanel.Height = btnBilling.Height
        sidepanel.Top = btnBilling.Top
        If Not fillpanel.Controls.Contains(billingForm.instance) Then
            fillpanel.Controls.Add(billingForm.instance)
            billingForm.instance.Dock = DockStyle.Fill
            billingForm.instance.BringToFront()
        End If
        billingForm.instance.BringToFront()
    End Sub

    Private Sub btnAdministration_Click(sender As Object, e As EventArgs) Handles btnAdministration.Click
        sidepanel.Height = btnAdministration.Height
        sidepanel.Top = btnAdministration.Top
        If Not fillpanel.Controls.Contains(administrationForm.instance) Then
            fillpanel.Controls.Add(administrationForm.instance)
            administrationForm.instance.Dock = DockStyle.Fill
            administrationForm.instance.BringToFront()
        End If
        administrationForm.instance.BringToFront()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        sidepanel.Height = btnReports.Height
        sidepanel.Top = btnReports.Top
        If Not fillpanel.Controls.Contains(reportsForm.instance) Then
            fillpanel.Controls.Add(reportsForm.instance)
            reportsForm.instance.Dock = DockStyle.Fill
            reportsForm.instance.BringToFront()
        End If
        reportsForm.instance.BringToFront()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        sidepanel.Height = btnRecords.Height
        sidepanel.Top = btnRecords.Top
        If Not fillpanel.Controls.Contains(recordsForm.instance) Then
            fillpanel.Controls.Add(recordsForm.instance)
            recordsForm.instance.Dock = DockStyle.Fill
            recordsForm.instance.BringToFront()
        End If
        recordsForm.instance.BringToFront()
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        sidepanel.Height = btnTools.Height
        sidepanel.Top = btnTools.Top
        If Not fillpanel.Controls.Contains(toolsForm.instance) Then
            fillpanel.Controls.Add(toolsForm.instance)
            toolsForm.instance.Dock = DockStyle.Fill
            toolsForm.instance.BringToFront()
        End If
        toolsForm.instance.BringToFront()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        timer1.enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = DateAndTime.Now
    End Sub

    Private Sub fillpanel_Paint(sender As Object, e As PaintEventArgs) Handles fillpanel.Paint

    End Sub

    Private Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click

    End Sub

    Private Sub worker_Click(sender As Object, e As EventArgs) Handles worker.Click

    End Sub

    Private Sub toppanel_Paint(sender As Object, e As PaintEventArgs) Handles toppanel.Paint

    End Sub
End Class