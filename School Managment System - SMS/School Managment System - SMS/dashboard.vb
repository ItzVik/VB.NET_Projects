Imports System.Data.SqlClient

Public Class dashboard
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        loginForm.Show()

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not fillpanel.Controls.Contains(classForm.instance) Then
            fillpanel.Controls.Add(classForm.instance)
            classForm.instance.Dock = DockStyle.Fill
            classForm.instance.BringToFront()
        End If
        classForm.instance.BringToFront()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click

        If Not fillpanel.Controls.Contains(classForm.instance) Then
            fillpanel.Controls.Add(classForm.instance)
            classForm.instance.Dock = DockStyle.Fill
            classForm.instance.BringToFront()
        End If
        classForm.instance.BringToFront()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        If Not fillpanel.Controls.Contains(studentForm.instance) Then
            fillpanel.Controls.Add(studentForm.instance)
            studentForm.instance.Dock = DockStyle.Fill
            studentForm.instance.BringToFront()
        End If
        studentForm.instance.BringToFront()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        If Not fillpanel.Controls.Contains(employeeForm.instance) Then
            fillpanel.Controls.Add(employeeForm.instance)
            employeeForm.instance.Dock = DockStyle.Fill
            employeeForm.instance.BringToFront()
        End If
        employeeForm.instance.BringToFront()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        If Not fillpanel.Controls.Contains(attendanceForm.instance) Then
            fillpanel.Controls.Add(attendanceForm.instance)
            attendanceForm.instance.Dock = DockStyle.Fill
            attendanceForm.instance.BringToFront()
        End If
        attendanceForm.instance.BringToFront()
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        If Not fillpanel.Controls.Contains(Expense.instance) Then
            fillpanel.Controls.Add(Expense.instance)
            Expense.instance.Dock = DockStyle.Fill
            Expense.instance.BringToFront()
        End If
        Expense.instance.BringToFront()
    End Sub

    Private Sub btnPAM_Click(sender As Object, e As EventArgs) Handles btnPAM.Click
        If Not fillpanel.Controls.Contains(praisesAndMeasuresForm.instance) Then
            fillpanel.Controls.Add(praisesAndMeasuresForm.instance)
            praisesAndMeasuresForm.instance.Dock = DockStyle.Fill
            praisesAndMeasuresForm.instance.BringToFront()
        End If
        praisesAndMeasuresForm.instance.BringToFront()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Label1.Text = "Welcome, " + My.Settings.username
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

    End Sub
End Class