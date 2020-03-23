<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExamination = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnPAM = New System.Windows.Forms.Button()
        Me.btnFee = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.fillpanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExamination)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnStudent)
        Me.Panel1.Controls.Add(Me.btnEmployee)
        Me.Panel1.Controls.Add(Me.btnClass)
        Me.Panel1.Controls.Add(Me.btnAttendance)
        Me.Panel1.Controls.Add(Me.btnPAM)
        Me.Panel1.Controls.Add(Me.btnFee)
        Me.Panel1.Controls.Add(Me.btnExpense)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 557)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "date + time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 495)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Welcome, username"
        '
        'btnExamination
        '
        Me.btnExamination.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnExamination.Enabled = False
        Me.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExamination.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamination.ForeColor = System.Drawing.Color.White
        Me.btnExamination.Location = New System.Drawing.Point(12, 386)
        Me.btnExamination.Name = "btnExamination"
        Me.btnExamination.Size = New System.Drawing.Size(215, 35)
        Me.btnExamination.TabIndex = 12
        Me.btnExamination.Text = "Examination"
        Me.btnExamination.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(12, 445)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(215, 31)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.Location = New System.Drawing.Point(12, 155)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(215, 35)
        Me.btnStudent.TabIndex = 10
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Location = New System.Drawing.Point(12, 198)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(215, 32)
        Me.btnEmployee.TabIndex = 9
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClass.ForeColor = System.Drawing.Color.White
        Me.btnClass.Location = New System.Drawing.Point(12, 116)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(215, 35)
        Me.btnClass.TabIndex = 4
        Me.btnClass.Text = "Class"
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.Location = New System.Drawing.Point(12, 346)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(215, 34)
        Me.btnAttendance.TabIndex = 7
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnPAM
        '
        Me.btnPAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnPAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPAM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPAM.ForeColor = System.Drawing.Color.White
        Me.btnPAM.Location = New System.Drawing.Point(12, 309)
        Me.btnPAM.Name = "btnPAM"
        Me.btnPAM.Size = New System.Drawing.Size(215, 31)
        Me.btnPAM.TabIndex = 6
        Me.btnPAM.Text = "Praises and Measures"
        Me.btnPAM.UseVisualStyleBackColor = False
        '
        'btnFee
        '
        Me.btnFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnFee.Enabled = False
        Me.btnFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFee.ForeColor = System.Drawing.Color.White
        Me.btnFee.Location = New System.Drawing.Point(12, 274)
        Me.btnFee.Name = "btnFee"
        Me.btnFee.Size = New System.Drawing.Size(215, 29)
        Me.btnFee.TabIndex = 8
        Me.btnFee.Text = "Fee"
        Me.btnFee.UseVisualStyleBackColor = False
        '
        'btnExpense
        '
        Me.btnExpense.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpense.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpense.ForeColor = System.Drawing.Color.White
        Me.btnExpense.Location = New System.Drawing.Point(12, 236)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(215, 32)
        Me.btnExpense.TabIndex = 5
        Me.btnExpense.Text = "Expense"
        Me.btnExpense.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 100)
        Me.Panel2.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 48.75!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(34, 4)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(171, 87)
        Me.label2.TabIndex = 2
        Me.label2.Text = "SMS"
        '
        'fillpanel
        '
        Me.fillpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fillpanel.Location = New System.Drawing.Point(243, 0)
        Me.fillpanel.Name = "fillpanel"
        Me.fillpanel.Size = New System.Drawing.Size(796, 557)
        Me.fillpanel.TabIndex = 2
        '
        'Timer1
        '
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1039, 557)
        Me.Controls.Add(Me.fillpanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents label2 As Label
    Friend WithEvents btnExamination As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnPAM As Button
    Friend WithEvents btnFee As Button
    Friend WithEvents btnExpense As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents fillpanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
