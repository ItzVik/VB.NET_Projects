<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class praisesAndMeasuresForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.reason = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Praises And Measures"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 54)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(17, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 257)
        Me.Panel2.TabIndex = 18
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
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Praises and measures"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Last name :"
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(137, 53)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(156, 20)
        Me.lname.TabIndex = 19
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(348, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(348, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Reason :"
        '
        'reason
        '
        Me.reason.Location = New System.Drawing.Point(437, 54)
        Me.reason.Name = "reason"
        Me.reason.Size = New System.Drawing.Size(156, 20)
        Me.reason.TabIndex = 25
        '
        'type
        '
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"Praise", "Measure"})
        Me.type.Location = New System.Drawing.Point(437, 13)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(156, 21)
        Me.type.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(253, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Add praise or measure"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.type)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.reason)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.fname)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lname)
        Me.Panel4.Location = New System.Drawing.Point(9, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(630, 138)
        Me.Panel4.TabIndex = 29
        '
        'praisesAndMeasuresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "praisesAndMeasuresForm"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents reason As TextBox
    Friend WithEvents type As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
End Class
