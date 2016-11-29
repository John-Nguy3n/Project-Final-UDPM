<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.mtpThongTinNV = New MetroFramework.Controls.MetroTabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.mbtnXoa = New MetroFramework.Controls.MetroButton()
        Me.mtpThemMoi = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.mdtNgaySinh = New MetroFramework.Controls.MetroDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mcbGioiTinh = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbNoiCap = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.mdtNgayCap = New MetroFramework.Controls.MetroDateTime()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtbEmail = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbCMND = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbTenKH = New MetroFramework.Controls.MetroTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.mtpThongTinNV.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.mtpThemMoi.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.mtpThongTinNV)
        Me.MetroTabControl1.Controls.Add(Me.mtpThemMoi)
        Me.MetroTabControl1.Location = New System.Drawing.Point(4, 10)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1253, 682)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'mtpThongTinNV
        '
        Me.mtpThongTinNV.Controls.Add(Me.DataGridView2)
        Me.mtpThongTinNV.Controls.Add(Me.GroupBox1)
        Me.mtpThongTinNV.Controls.Add(Me.mbtnXoa)
        Me.mtpThongTinNV.HorizontalScrollbarBarColor = True
        Me.mtpThongTinNV.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpThongTinNV.HorizontalScrollbarSize = 4
        Me.mtpThongTinNV.Location = New System.Drawing.Point(4, 38)
        Me.mtpThongTinNV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtpThongTinNV.Name = "mtpThongTinNV"
        Me.mtpThongTinNV.Size = New System.Drawing.Size(1245, 640)
        Me.mtpThongTinNV.TabIndex = 0
        Me.mtpThongTinNV.Text = "Thông tin khách hàng"
        Me.mtpThongTinNV.VerticalScrollbarBarColor = True
        Me.mtpThongTinNV.VerticalScrollbarHighlightOnWheel = False
        Me.mtpThongTinNV.VerticalScrollbarSize = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(0, 92)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1245, 444)
        Me.DataGridView2.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroRadioButton2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroRadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1245, 92)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox2.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(637, 53)
        Me.MetroTextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(261, 29)
        Me.MetroTextBox2.TabIndex = 17
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(732, 28)
        Me.MetroRadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(75, 15)
        Me.MetroRadioButton2.TabIndex = 16
        Me.MetroRadioButton2.Text = "Số CMND"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(262, 53)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(261, 29)
        Me.MetroTextBox1.TabIndex = 9
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Checked = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(355, 28)
        Me.MetroRadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(86, 15)
        Me.MetroRadioButton1.TabIndex = 0
        Me.MetroRadioButton1.TabStop = True
        Me.MetroRadioButton1.Text = "Khách hàng"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'mbtnXoa
        '
        Me.mbtnXoa.Location = New System.Drawing.Point(1131, 546)
        Me.mbtnXoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mbtnXoa.Name = "mbtnXoa"
        Me.mbtnXoa.Size = New System.Drawing.Size(114, 38)
        Me.mbtnXoa.TabIndex = 26
        Me.mbtnXoa.Text = "Cập nhật"
        Me.mbtnXoa.UseSelectable = True
        '
        'mtpThemMoi
        '
        Me.mtpThemMoi.Controls.Add(Me.MetroButton2)
        Me.mtpThemMoi.Controls.Add(Me.MetroButton1)
        Me.mtpThemMoi.Controls.Add(Me.mdtNgaySinh)
        Me.mtpThemMoi.Controls.Add(Me.Label3)
        Me.mtpThemMoi.Controls.Add(Me.Label6)
        Me.mtpThemMoi.Controls.Add(Me.mcbGioiTinh)
        Me.mtpThemMoi.Controls.Add(Me.Label2)
        Me.mtpThemMoi.Controls.Add(Me.mtbNoiCap)
        Me.mtpThemMoi.Controls.Add(Me.Label10)
        Me.mtpThemMoi.Controls.Add(Me.Label11)
        Me.mtpThemMoi.Controls.Add(Me.Label26)
        Me.mtpThemMoi.Controls.Add(Me.txtGhiChu)
        Me.mtpThemMoi.Controls.Add(Me.Label27)
        Me.mtpThemMoi.Controls.Add(Me.mdtNgayCap)
        Me.mtpThemMoi.Controls.Add(Me.Label18)
        Me.mtpThemMoi.Controls.Add(Me.Label19)
        Me.mtpThemMoi.Controls.Add(Me.Label12)
        Me.mtpThemMoi.Controls.Add(Me.mtbEmail)
        Me.mtpThemMoi.Controls.Add(Me.Label13)
        Me.mtpThemMoi.Controls.Add(Me.Label9)
        Me.mtpThemMoi.Controls.Add(Me.Label4)
        Me.mtpThemMoi.Controls.Add(Me.mtbCMND)
        Me.mtpThemMoi.Controls.Add(Me.Label5)
        Me.mtpThemMoi.Controls.Add(Me.Label1)
        Me.mtpThemMoi.Controls.Add(Me.mtbTenKH)
        Me.mtpThemMoi.Controls.Add(Me.Label15)
        Me.mtpThemMoi.HorizontalScrollbarBarColor = True
        Me.mtpThemMoi.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpThemMoi.HorizontalScrollbarSize = 4
        Me.mtpThemMoi.Location = New System.Drawing.Point(4, 38)
        Me.mtpThemMoi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtpThemMoi.Name = "mtpThemMoi"
        Me.mtpThemMoi.Size = New System.Drawing.Size(1245, 640)
        Me.mtpThemMoi.TabIndex = 1
        Me.mtpThemMoi.Text = "Thêm khách hàng "
        Me.mtpThemMoi.VerticalScrollbarBarColor = True
        Me.mtpThemMoi.VerticalScrollbarHighlightOnWheel = False
        Me.mtpThemMoi.VerticalScrollbarSize = 5
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(807, 545)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(114, 38)
        Me.MetroButton2.TabIndex = 82
        Me.MetroButton2.Text = "Làm mới"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(944, 545)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(114, 38)
        Me.MetroButton1.TabIndex = 81
        Me.MetroButton1.Text = "Thêm mới"
        Me.MetroButton1.UseSelectable = True
        '
        'mdtNgaySinh
        '
        Me.mdtNgaySinh.Location = New System.Drawing.Point(311, 199)
        Me.mdtNgaySinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mdtNgaySinh.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgaySinh.Name = "mdtNgaySinh"
        Me.mdtNgaySinh.Size = New System.Drawing.Size(261, 29)
        Me.mdtNgaySinh.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Ngày Sinh"
        '
        'mcbGioiTinh
        '
        Me.mcbGioiTinh.FormattingEnabled = True
        Me.mcbGioiTinh.ItemHeight = 23
        Me.mcbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.mcbGioiTinh.Location = New System.Drawing.Point(311, 159)
        Me.mcbGioiTinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mcbGioiTinh.Name = "mcbGioiTinh"
        Me.mcbGioiTinh.Size = New System.Drawing.Size(261, 29)
        Me.mcbGioiTinh.TabIndex = 77
        Me.mcbGioiTinh.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 163)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = ":"
        '
        'mtbNoiCap
        '
        '
        '
        '
        Me.mtbNoiCap.CustomButton.Image = Nothing
        Me.mtbNoiCap.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbNoiCap.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbNoiCap.CustomButton.Name = ""
        Me.mtbNoiCap.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbNoiCap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNoiCap.CustomButton.TabIndex = 1
        Me.mtbNoiCap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNoiCap.CustomButton.UseSelectable = True
        Me.mtbNoiCap.CustomButton.Visible = False
        Me.mtbNoiCap.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbNoiCap.Lines = New String(-1) {}
        Me.mtbNoiCap.Location = New System.Drawing.Point(797, 120)
        Me.mtbNoiCap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbNoiCap.MaxLength = 32767
        Me.mtbNoiCap.Name = "mtbNoiCap"
        Me.mtbNoiCap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNoiCap.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNoiCap.SelectedText = ""
        Me.mtbNoiCap.SelectionLength = 0
        Me.mtbNoiCap.SelectionStart = 0
        Me.mtbNoiCap.ShortcutsEnabled = True
        Me.mtbNoiCap.Size = New System.Drawing.Size(261, 29)
        Me.mtbNoiCap.TabIndex = 75
        Me.mtbNoiCap.UseSelectable = True
        Me.mtbNoiCap.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNoiCap.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(764, 125)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 20)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(672, 125)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Nơi cấp"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(284, 239)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 20)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = ":"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(311, 239)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(747, 298)
        Me.txtGhiChu.TabIndex = 66
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(106, 239)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 20)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "Ghi chú"
        '
        'mdtNgayCap
        '
        Me.mdtNgayCap.Location = New System.Drawing.Point(797, 159)
        Me.mdtNgayCap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mdtNgayCap.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgayCap.Name = "mdtNgayCap"
        Me.mdtNgayCap.Size = New System.Drawing.Size(261, 29)
        Me.mdtNgayCap.TabIndex = 64
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(764, 165)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 20)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(672, 165)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 20)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Ngày cấp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(764, 86)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 20)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = ":"
        '
        'mtbEmail
        '
        '
        '
        '
        Me.mtbEmail.CustomButton.Image = Nothing
        Me.mtbEmail.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbEmail.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbEmail.CustomButton.Name = ""
        Me.mtbEmail.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEmail.CustomButton.TabIndex = 1
        Me.mtbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEmail.CustomButton.UseSelectable = True
        Me.mtbEmail.CustomButton.Visible = False
        Me.mtbEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbEmail.Lines = New String(-1) {}
        Me.mtbEmail.Location = New System.Drawing.Point(797, 81)
        Me.mtbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbEmail.MaxLength = 32767
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEmail.SelectedText = ""
        Me.mtbEmail.SelectionLength = 0
        Me.mtbEmail.SelectionStart = 0
        Me.mtbEmail.ShortcutsEnabled = True
        Me.mtbEmail.Size = New System.Drawing.Size(261, 29)
        Me.mtbEmail.TabIndex = 46
        Me.mtbEmail.UseSelectable = True
        Me.mtbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(672, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 163)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = ":"
        '
        'mtbCMND
        '
        '
        '
        '
        Me.mtbCMND.CustomButton.Image = Nothing
        Me.mtbCMND.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbCMND.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbCMND.CustomButton.Name = ""
        Me.mtbCMND.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbCMND.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCMND.CustomButton.TabIndex = 1
        Me.mtbCMND.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCMND.CustomButton.UseSelectable = True
        Me.mtbCMND.CustomButton.Visible = False
        Me.mtbCMND.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbCMND.Lines = New String(-1) {}
        Me.mtbCMND.Location = New System.Drawing.Point(311, 120)
        Me.mtbCMND.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbCMND.MaxLength = 32767
        Me.mtbCMND.Name = "mtbCMND"
        Me.mtbCMND.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCMND.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCMND.SelectedText = ""
        Me.mtbCMND.SelectionLength = 0
        Me.mtbCMND.SelectionStart = 0
        Me.mtbCMND.ShortcutsEnabled = True
        Me.mtbCMND.Size = New System.Drawing.Size(261, 29)
        Me.mtbCMND.TabIndex = 34
        Me.mtbCMND.UseSelectable = True
        Me.mtbCMND.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCMND.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Số CMND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = ":"
        '
        'mtbTenKH
        '
        '
        '
        '
        Me.mtbTenKH.CustomButton.Image = Nothing
        Me.mtbTenKH.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbTenKH.CustomButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbTenKH.CustomButton.Name = ""
        Me.mtbTenKH.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbTenKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTenKH.CustomButton.TabIndex = 1
        Me.mtbTenKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTenKH.CustomButton.UseSelectable = True
        Me.mtbTenKH.CustomButton.Visible = False
        Me.mtbTenKH.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbTenKH.Lines = New String(-1) {}
        Me.mtbTenKH.Location = New System.Drawing.Point(311, 81)
        Me.mtbTenKH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbTenKH.MaxLength = 32767
        Me.mtbTenKH.Name = "mtbTenKH"
        Me.mtbTenKH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTenKH.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTenKH.SelectedText = ""
        Me.mtbTenKH.SelectionLength = 0
        Me.mtbTenKH.SelectionStart = 0
        Me.mtbTenKH.ShortcutsEnabled = True
        Me.mtbTenKH.Size = New System.Drawing.Size(261, 29)
        Me.mtbTenKH.TabIndex = 27
        Me.mtbTenKH.UseSelectable = True
        Me.mtbTenKH.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTenKH.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(106, 86)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Tên khách hàng"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 682)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("Calibri Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKhachHang"
        Me.Padding = New System.Windows.Forms.Padding(30, 48, 30, 32)
        Me.Resizable = False
        Me.Text = "Quản lý khách hàng"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.mtpThongTinNV.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mtpThemMoi.ResumeLayout(False)
        Me.mtpThemMoi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents mtpThongTinNV As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mbtnXoa As MetroFramework.Controls.MetroButton
    Friend WithEvents mtpThemMoi As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtbNoiCap As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents mdtNgayCap As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents mtbEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbCMND As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbTenKH As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mcbGioiTinh As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mdtNgaySinh As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
