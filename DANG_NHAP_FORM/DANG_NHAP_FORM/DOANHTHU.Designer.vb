<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOANHTHU
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTienGV = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtgDV = New System.Windows.Forms.DataGridView()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.dtgP = New System.Windows.Forms.DataGridView()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LàmMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InBáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐóngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtgDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(442, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Đến ngày"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(206, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Từ ngày"
        '
        'txtTienGV
        '
        Me.txtTienGV.Enabled = False
        Me.txtTienGV.Location = New System.Drawing.Point(1089, 534)
        Me.txtTienGV.Multiline = True
        Me.txtTienGV.Name = "txtTienGV"
        Me.txtTienGV.Size = New System.Drawing.Size(161, 29)
        Me.txtTienGV.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(904, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Tiền dịch vụ"
        '
        'dtgDV
        '
        Me.dtgDV.AllowUserToAddRows = False
        Me.dtgDV.AllowUserToDeleteRows = False
        Me.dtgDV.AllowUserToResizeColumns = False
        Me.dtgDV.AllowUserToResizeRows = False
        Me.dtgDV.BackgroundColor = System.Drawing.Color.White
        Me.dtgDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDV.Location = New System.Drawing.Point(869, 101)
        Me.dtgDV.Name = "dtgDV"
        Me.dtgDV.ReadOnly = True
        Me.dtgDV.Size = New System.Drawing.Size(381, 364)
        Me.dtgDV.TabIndex = 52
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime2.Location = New System.Drawing.Point(527, 65)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(131, 29)
        Me.MetroDateTime2.TabIndex = 50
        '
        'dtgP
        '
        Me.dtgP.AllowUserToAddRows = False
        Me.dtgP.AllowUserToDeleteRows = False
        Me.dtgP.BackgroundColor = System.Drawing.Color.White
        Me.dtgP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgP.Location = New System.Drawing.Point(33, 100)
        Me.dtgP.Name = "dtgP"
        Me.dtgP.ReadOnly = True
        Me.dtgP.Size = New System.Drawing.Size(824, 452)
        Me.dtgP.TabIndex = 51
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(280, 65)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(131, 29)
        Me.MetroDateTime1.TabIndex = 49
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(332, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 18)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Đến ngày :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(119, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 18)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Từ ngày :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Đến ngày :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Từ ngày :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(676, 604)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 23)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Label9"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 604)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 23)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 604)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 23)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Label5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1040, 537)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 20)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(577, 603)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Doanh Thu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 603)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Giảm giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 603)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Tổng Cộng"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LàmMớiToolStripMenuItem, Me.InBáoCáoToolStripMenuItem, Me.ĐóngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(33, 27)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1217, 24)
        Me.MenuStrip1.TabIndex = 64
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LàmMớiToolStripMenuItem
        '
        Me.LàmMớiToolStripMenuItem.Name = "LàmMớiToolStripMenuItem"
        Me.LàmMớiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LàmMớiToolStripMenuItem.Text = "Làm mới"
        '
        'InBáoCáoToolStripMenuItem
        '
        Me.InBáoCáoToolStripMenuItem.Name = "InBáoCáoToolStripMenuItem"
        Me.InBáoCáoToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.InBáoCáoToolStripMenuItem.Text = "In báo cáo"
        '
        'ĐóngToolStripMenuItem
        '
        Me.ĐóngToolStripMenuItem.Name = "ĐóngToolStripMenuItem"
        Me.ĐóngToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ĐóngToolStripMenuItem.Text = "Đóng "
        '
        'DOANHTHU
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTienGV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtgDV)
        Me.Controls.Add(Me.MetroDateTime2)
        Me.Controls.Add(Me.dtgP)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DOANHTHU"
        Me.Padding = New System.Windows.Forms.Padding(30, 97, 30, 32)
        Me.Resizable = False
        CType(Me.dtgDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTienGV As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtgDV As DataGridView
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtgP As DataGridView
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LàmMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InBáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐóngToolStripMenuItem As ToolStripMenuItem
End Class
