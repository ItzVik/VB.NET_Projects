<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Expense
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fw = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.hm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ff = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pg = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 54)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Expense"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(17, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 257)
        Me.Panel2.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(672, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Expense"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(16, 40)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(731, 199)
        Me.DataGridView2.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pg)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.ff)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.hm)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.fw)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.fname)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lname)
        Me.Panel4.Location = New System.Drawing.Point(17, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(658, 177)
        Me.Panel4.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(284, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(348, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "For what :"
        '
        'fw
        '
        Me.fw.Location = New System.Drawing.Point(468, 53)
        Me.fw.Name = "fw"
        Me.fw.Size = New System.Drawing.Size(156, 20)
        Me.fw.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(348, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "How much :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "First name :"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(137, 15)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(156, 20)
        Me.fname.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Last name :"
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(137, 55)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(156, 20)
        Me.lname.TabIndex = 19
        '
        'hm
        '
        Me.hm.Location = New System.Drawing.Point(468, 16)
        Me.hm.Name = "hm"
        Me.hm.Size = New System.Drawing.Size(156, 20)
        Me.hm.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "For / From :"
        '
        'ff
        '
        Me.ff.FormattingEnabled = True
        Me.ff.Items.AddRange(New Object() {"Student", "School", "Employee"})
        Me.ff.Location = New System.Drawing.Point(137, 95)
        Me.ff.Name = "ff"
        Me.ff.Size = New System.Drawing.Size(154, 21)
        Me.ff.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(348, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 25)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Pay / Give :"
        '
        'pg
        '
        Me.pg.FormattingEnabled = True
        Me.pg.Items.AddRange(New Object() {"Pay", "Give"})
        Me.pg.Location = New System.Drawing.Point(468, 90)
        Me.pg.Name = "pg"
        Me.pg.Size = New System.Drawing.Size(155, 21)
        Me.pg.TabIndex = 35
        '
        'Expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Expense"
        Me.Size = New System.Drawing.Size(796, 557)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pg As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ff As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents hm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents fw As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lname As TextBox
End Class
