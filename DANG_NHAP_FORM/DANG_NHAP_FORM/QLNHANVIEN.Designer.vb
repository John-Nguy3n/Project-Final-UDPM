<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLNhanVien
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.mtpThongTinNV = New MetroFramework.Controls.MetroTabPage()
        Me.dtgNhanVien = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoCMND = New MetroFramework.Controls.MetroRadioButton()
        Me.txbTimkiem = New MetroFramework.Controls.MetroTextBox()
        Me.rdoNhanVien = New MetroFramework.Controls.MetroRadioButton()
        Me.mbtnXoa = New MetroFramework.Controls.MetroButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.mtpThemMoi = New MetroFramework.Controls.MetroTabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.mcbChucVu = New MetroFramework.Controls.MetroComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.mdtNgayLam = New MetroFramework.Controls.MetroDateTime()
        Me.mcbGioiTinh = New MetroFramework.Controls.MetroComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mtbMatKhau = New MetroFramework.Controls.MetroTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mtbTaiKhoan = New MetroFramework.Controls.MetroTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.mtbLuong = New MetroFramework.Controls.MetroTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtbEmail = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtbSDT = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtbDiaChi = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbCMND = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mdtNgaySinh = New MetroFramework.Controls.MetroDateTime()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbTenNV = New MetroFramework.Controls.MetroTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.mtpThongTinNV.SuspendLayout()
        CType(Me.dtgNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.mtpThemMoi.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.mtpThongTinNV)
        Me.MetroTabControl1.Controls.Add(Me.mtpThemMoi)
        Me.MetroTabControl1.Location = New System.Drawing.Point(8, 15)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1248, 614)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'mtpThongTinNV
        '
        Me.mtpThongTinNV.Controls.Add(Me.MetroButton2)
        Me.mtpThongTinNV.Controls.Add(Me.dtgNhanVien)
        Me.mtpThongTinNV.Controls.Add(Me.GroupBox1)
        Me.mtpThongTinNV.Controls.Add(Me.mbtnXoa)
        Me.mtpThongTinNV.Controls.Add(Me.ShapeContainer1)
        Me.mtpThongTinNV.HorizontalScrollbarBarColor = True
        Me.mtpThongTinNV.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpThongTinNV.HorizontalScrollbarSize = 2
        Me.mtpThongTinNV.Location = New System.Drawing.Point(4, 38)
        Me.mtpThongTinNV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtpThongTinNV.Name = "mtpThongTinNV"
        Me.mtpThongTinNV.Size = New System.Drawing.Size(1240, 572)
        Me.mtpThongTinNV.TabIndex = 0
        Me.mtpThongTinNV.Text = "Thông tin nhân viên"
        Me.mtpThongTinNV.VerticalScrollbarBarColor = True
        Me.mtpThongTinNV.VerticalScrollbarHighlightOnWheel = False
        Me.mtpThongTinNV.VerticalScrollbarSize = 3
        '
        'dtgNhanVien
        '
        Me.dtgNhanVien.AllowUserToAddRows = False
        Me.dtgNhanVien.AllowUserToDeleteRows = False
        Me.dtgNhanVien.BackgroundColor = System.Drawing.Color.White
        Me.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNhanVien.Location = New System.Drawing.Point(0, 92)
        Me.dtgNhanVien.Name = "dtgNhanVien"
        Me.dtgNhanVien.ReadOnly = True
        Me.dtgNhanVien.Size = New System.Drawing.Size(1236, 426)
        Me.dtgNhanVien.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.rdoCMND)
        Me.GroupBox1.Controls.Add(Me.txbTimkiem)
        Me.GroupBox1.Controls.Add(Me.rdoNhanVien)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 88)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'rdoCMND
        '
        Me.rdoCMND.AutoSize = True
        Me.rdoCMND.Location = New System.Drawing.Point(664, 17)
        Me.rdoCMND.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoCMND.Name = "rdoCMND"
        Me.rdoCMND.Size = New System.Drawing.Size(75, 15)
        Me.rdoCMND.TabIndex = 16
        Me.rdoCMND.Text = "Số CMND"
        Me.rdoCMND.UseSelectable = True
        '
        'txbTimkiem
        '
        '
        '
        '
        Me.txbTimkiem.CustomButton.Image = Nothing
        Me.txbTimkiem.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txbTimkiem.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.txbTimkiem.CustomButton.Name = ""
        Me.txbTimkiem.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.txbTimkiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbTimkiem.CustomButton.TabIndex = 1
        Me.txbTimkiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbTimkiem.CustomButton.UseSelectable = True
        Me.txbTimkiem.CustomButton.Visible = False
        Me.txbTimkiem.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txbTimkiem.Lines = New String(-1) {}
        Me.txbTimkiem.Location = New System.Drawing.Point(478, 42)
        Me.txbTimkiem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbTimkiem.MaxLength = 32767
        Me.txbTimkiem.Name = "txbTimkiem"
        Me.txbTimkiem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTimkiem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbTimkiem.SelectedText = ""
        Me.txbTimkiem.SelectionLength = 0
        Me.txbTimkiem.SelectionStart = 0
        Me.txbTimkiem.ShortcutsEnabled = True
        Me.txbTimkiem.Size = New System.Drawing.Size(261, 29)
        Me.txbTimkiem.TabIndex = 9
        Me.txbTimkiem.UseSelectable = True
        Me.txbTimkiem.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbTimkiem.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rdoNhanVien
        '
        Me.rdoNhanVien.AutoSize = True
        Me.rdoNhanVien.Checked = True
        Me.rdoNhanVien.Location = New System.Drawing.Point(478, 17)
        Me.rdoNhanVien.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoNhanVien.Name = "rdoNhanVien"
        Me.rdoNhanVien.Size = New System.Drawing.Size(77, 15)
        Me.rdoNhanVien.TabIndex = 0
        Me.rdoNhanVien.TabStop = True
        Me.rdoNhanVien.Text = "Nhân viên"
        Me.rdoNhanVien.UseSelectable = True
        '
        'mbtnXoa
        '
        Me.mbtnXoa.Location = New System.Drawing.Point(1640, 850)
        Me.mbtnXoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mbtnXoa.Name = "mbtnXoa"
        Me.mbtnXoa.Size = New System.Drawing.Size(171, 61)
        Me.mbtnXoa.TabIndex = 26
        Me.mbtnXoa.Text = "Thoát"
        Me.mbtnXoa.UseSelectable = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1240, 572)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.Location = New System.Drawing.Point(210, 86)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(820, 1)
        '
        'mtpThemMoi
        '
        Me.mtpThemMoi.Controls.Add(Me.Label16)
        Me.mtpThemMoi.Controls.Add(Me.Label28)
        Me.mtpThemMoi.Controls.Add(Me.MetroTextBox1)
        Me.mtpThemMoi.Controls.Add(Me.MetroTextBox2)
        Me.mtpThemMoi.Controls.Add(Me.Label25)
        Me.mtpThemMoi.Controls.Add(Me.Label23)
        Me.mtpThemMoi.Controls.Add(Me.MetroButton1)
        Me.mtpThemMoi.Controls.Add(Me.mcbChucVu)
        Me.mtpThemMoi.Controls.Add(Me.Label26)
        Me.mtpThemMoi.Controls.Add(Me.txtGhiChu)
        Me.mtpThemMoi.Controls.Add(Me.Label27)
        Me.mtpThemMoi.Controls.Add(Me.mdtNgayLam)
        Me.mtpThemMoi.Controls.Add(Me.mcbGioiTinh)
        Me.mtpThemMoi.Controls.Add(Me.Label24)
        Me.mtpThemMoi.Controls.Add(Me.mtbMatKhau)
        Me.mtpThemMoi.Controls.Add(Me.Label22)
        Me.mtpThemMoi.Controls.Add(Me.mtbTaiKhoan)
        Me.mtpThemMoi.Controls.Add(Me.Label20)
        Me.mtpThemMoi.Controls.Add(Me.mtbLuong)
        Me.mtpThemMoi.Controls.Add(Me.Label21)
        Me.mtpThemMoi.Controls.Add(Me.Label18)
        Me.mtpThemMoi.Controls.Add(Me.Label19)
        Me.mtpThemMoi.Controls.Add(Me.Label14)
        Me.mtpThemMoi.Controls.Add(Me.Label17)
        Me.mtpThemMoi.Controls.Add(Me.Label12)
        Me.mtpThemMoi.Controls.Add(Me.mtbEmail)
        Me.mtpThemMoi.Controls.Add(Me.Label13)
        Me.mtpThemMoi.Controls.Add(Me.Label10)
        Me.mtpThemMoi.Controls.Add(Me.mtbSDT)
        Me.mtpThemMoi.Controls.Add(Me.Label11)
        Me.mtpThemMoi.Controls.Add(Me.Label8)
        Me.mtpThemMoi.Controls.Add(Me.Label9)
        Me.mtpThemMoi.Controls.Add(Me.Label6)
        Me.mtpThemMoi.Controls.Add(Me.mtbDiaChi)
        Me.mtpThemMoi.Controls.Add(Me.Label7)
        Me.mtpThemMoi.Controls.Add(Me.Label4)
        Me.mtpThemMoi.Controls.Add(Me.mtbCMND)
        Me.mtpThemMoi.Controls.Add(Me.Label5)
        Me.mtpThemMoi.Controls.Add(Me.mdtNgaySinh)
        Me.mtpThemMoi.Controls.Add(Me.Label2)
        Me.mtpThemMoi.Controls.Add(Me.Label3)
        Me.mtpThemMoi.Controls.Add(Me.Label1)
        Me.mtpThemMoi.Controls.Add(Me.mtbTenNV)
        Me.mtpThemMoi.Controls.Add(Me.Label15)
        Me.mtpThemMoi.HorizontalScrollbarBarColor = True
        Me.mtpThemMoi.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpThemMoi.HorizontalScrollbarSize = 2
        Me.mtpThemMoi.Location = New System.Drawing.Point(4, 38)
        Me.mtpThemMoi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtpThemMoi.Name = "mtpThemMoi"
        Me.mtpThemMoi.Size = New System.Drawing.Size(1240, 572)
        Me.mtpThemMoi.TabIndex = 1
        Me.mtpThemMoi.Text = "Thêm nhân viên"
        Me.mtpThemMoi.VerticalScrollbarBarColor = True
        Me.mtpThemMoi.VerticalScrollbarHighlightOnWheel = False
        Me.mtpThemMoi.VerticalScrollbarSize = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1045, 67)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 20)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1045, 31)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 20)
        Me.Label28.TabIndex = 74
        Me.Label28.Text = ":"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(1067, 24)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(152, 29)
        Me.MetroTextBox1.TabIndex = 73
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.MetroTextBox2.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(1067, 63)
        Me.MetroTextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(152, 29)
        Me.MetroTextBox2.TabIndex = 72
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(968, 69)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 20)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Mật khẩu"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(964, 28)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 20)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Tài khoản"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(876, 512)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(152, 45)
        Me.MetroButton1.TabIndex = 71
        Me.MetroButton1.Text = "Thêm mới"
        Me.MetroButton1.UseSelectable = True
        '
        'mcbChucVu
        '
        Me.mcbChucVu.FormattingEnabled = True
        Me.mcbChucVu.ItemHeight = 23
        Me.mcbChucVu.Items.AddRange(New Object() {"Thu Ngân", "Nhân Viên"})
        Me.mcbChucVu.Location = New System.Drawing.Point(675, 102)
        Me.mcbChucVu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mcbChucVu.Name = "mcbChucVu"
        Me.mcbChucVu.Size = New System.Drawing.Size(261, 29)
        Me.mcbChucVu.TabIndex = 70
        Me.mcbChucVu.UseSelectable = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(643, 69)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 20)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = ":"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(196, 219)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(832, 285)
        Me.txtGhiChu.TabIndex = 66
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(18, 219)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 20)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "Ghi chú"
        '
        'mdtNgayLam
        '
        Me.mdtNgayLam.Location = New System.Drawing.Point(675, 141)
        Me.mdtNgayLam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mdtNgayLam.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgayLam.Name = "mdtNgayLam"
        Me.mdtNgayLam.Size = New System.Drawing.Size(261, 29)
        Me.mdtNgayLam.TabIndex = 64
        '
        'mcbGioiTinh
        '
        Me.mcbGioiTinh.FormattingEnabled = True
        Me.mcbGioiTinh.ItemHeight = 23
        Me.mcbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.mcbGioiTinh.Location = New System.Drawing.Point(196, 180)
        Me.mcbGioiTinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mcbGioiTinh.Name = "mcbGioiTinh"
        Me.mcbGioiTinh.Size = New System.Drawing.Size(261, 29)
        Me.mcbGioiTinh.TabIndex = 63
        Me.mcbGioiTinh.UseSelectable = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1419, 141)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 20)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = ":"
        '
        'mtbMatKhau
        '
        '
        '
        '
        Me.mtbMatKhau.CustomButton.Image = Nothing
        Me.mtbMatKhau.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.mtbMatKhau.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbMatKhau.CustomButton.Name = ""
        Me.mtbMatKhau.CustomButton.Size = New System.Drawing.Size(30, 28)
        Me.mtbMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbMatKhau.CustomButton.TabIndex = 1
        Me.mtbMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbMatKhau.CustomButton.UseSelectable = True
        Me.mtbMatKhau.CustomButton.Visible = False
        Me.mtbMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbMatKhau.Lines = New String(-1) {}
        Me.mtbMatKhau.Location = New System.Drawing.Point(1467, 132)
        Me.mtbMatKhau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbMatKhau.MaxLength = 32767
        Me.mtbMatKhau.Name = "mtbMatKhau"
        Me.mtbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbMatKhau.SelectedText = ""
        Me.mtbMatKhau.SelectionLength = 0
        Me.mtbMatKhau.SelectionStart = 0
        Me.mtbMatKhau.ShortcutsEnabled = True
        Me.mtbMatKhau.Size = New System.Drawing.Size(309, 47)
        Me.mtbMatKhau.TabIndex = 61
        Me.mtbMatKhau.UseSelectable = True
        Me.mtbMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbMatKhau.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1419, 63)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 20)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = ":"
        '
        'mtbTaiKhoan
        '
        '
        '
        '
        Me.mtbTaiKhoan.CustomButton.Image = Nothing
        Me.mtbTaiKhoan.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.mtbTaiKhoan.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbTaiKhoan.CustomButton.Name = ""
        Me.mtbTaiKhoan.CustomButton.Size = New System.Drawing.Size(30, 28)
        Me.mtbTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTaiKhoan.CustomButton.TabIndex = 1
        Me.mtbTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTaiKhoan.CustomButton.UseSelectable = True
        Me.mtbTaiKhoan.CustomButton.Visible = False
        Me.mtbTaiKhoan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbTaiKhoan.Lines = New String(-1) {}
        Me.mtbTaiKhoan.Location = New System.Drawing.Point(1467, 55)
        Me.mtbTaiKhoan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbTaiKhoan.MaxLength = 32767
        Me.mtbTaiKhoan.Name = "mtbTaiKhoan"
        Me.mtbTaiKhoan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTaiKhoan.SelectedText = ""
        Me.mtbTaiKhoan.SelectionLength = 0
        Me.mtbTaiKhoan.SelectionStart = 0
        Me.mtbTaiKhoan.ShortcutsEnabled = True
        Me.mtbTaiKhoan.Size = New System.Drawing.Size(309, 47)
        Me.mtbTaiKhoan.TabIndex = 58
        Me.mtbTaiKhoan.UseSelectable = True
        Me.mtbTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTaiKhoan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(643, 183)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 20)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = ":"
        '
        'mtbLuong
        '
        '
        '
        '
        Me.mtbLuong.CustomButton.Image = Nothing
        Me.mtbLuong.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbLuong.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbLuong.CustomButton.Name = ""
        Me.mtbLuong.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbLuong.CustomButton.TabIndex = 1
        Me.mtbLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbLuong.CustomButton.UseSelectable = True
        Me.mtbLuong.CustomButton.Visible = False
        Me.mtbLuong.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbLuong.Lines = New String(-1) {}
        Me.mtbLuong.Location = New System.Drawing.Point(675, 180)
        Me.mtbLuong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbLuong.MaxLength = 32767
        Me.mtbLuong.Name = "mtbLuong"
        Me.mtbLuong.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbLuong.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbLuong.SelectedText = ""
        Me.mtbLuong.SelectionLength = 0
        Me.mtbLuong.SelectionStart = 0
        Me.mtbLuong.ShortcutsEnabled = True
        Me.mtbLuong.Size = New System.Drawing.Size(261, 29)
        Me.mtbLuong.TabIndex = 55
        Me.mtbLuong.UseSelectable = True
        Me.mtbLuong.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbLuong.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(485, 183)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 20)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Lương"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(643, 141)
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
        Me.Label19.Location = New System.Drawing.Point(485, 141)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 20)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Ngày bắt đầu"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(643, 105)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 20)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(485, 106)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Chức vụ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(174, 222)
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
        Me.mtbEmail.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbEmail.CustomButton.Name = ""
        Me.mtbEmail.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEmail.CustomButton.TabIndex = 1
        Me.mtbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEmail.CustomButton.UseSelectable = True
        Me.mtbEmail.CustomButton.Visible = False
        Me.mtbEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbEmail.Lines = New String(-1) {}
        Me.mtbEmail.Location = New System.Drawing.Point(675, 63)
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
        Me.Label13.Location = New System.Drawing.Point(485, 69)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(643, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = ":"
        '
        'mtbSDT
        '
        '
        '
        '
        Me.mtbSDT.CustomButton.Image = Nothing
        Me.mtbSDT.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbSDT.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbSDT.CustomButton.Name = ""
        Me.mtbSDT.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbSDT.CustomButton.TabIndex = 1
        Me.mtbSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbSDT.CustomButton.UseSelectable = True
        Me.mtbSDT.CustomButton.Visible = False
        Me.mtbSDT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbSDT.Lines = New String(-1) {}
        Me.mtbSDT.Location = New System.Drawing.Point(675, 24)
        Me.mtbSDT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbSDT.MaxLength = 32767
        Me.mtbSDT.Name = "mtbSDT"
        Me.mtbSDT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbSDT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbSDT.SelectedText = ""
        Me.mtbSDT.SelectionLength = 0
        Me.mtbSDT.SelectionStart = 0
        Me.mtbSDT.ShortcutsEnabled = True
        Me.mtbSDT.Size = New System.Drawing.Size(261, 29)
        Me.mtbSDT.TabIndex = 43
        Me.mtbSDT.UseSelectable = True
        Me.mtbSDT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbSDT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(485, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Số điện thoại"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 183)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 183)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Giới tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = ":"
        '
        'mtbDiaChi
        '
        '
        '
        '
        Me.mtbDiaChi.CustomButton.Image = Nothing
        Me.mtbDiaChi.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbDiaChi.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbDiaChi.CustomButton.Name = ""
        Me.mtbDiaChi.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDiaChi.CustomButton.TabIndex = 1
        Me.mtbDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDiaChi.CustomButton.UseSelectable = True
        Me.mtbDiaChi.CustomButton.Visible = False
        Me.mtbDiaChi.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbDiaChi.Lines = New String(-1) {}
        Me.mtbDiaChi.Location = New System.Drawing.Point(196, 141)
        Me.mtbDiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbDiaChi.MaxLength = 32767
        Me.mtbDiaChi.Name = "mtbDiaChi"
        Me.mtbDiaChi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDiaChi.SelectedText = ""
        Me.mtbDiaChi.SelectionLength = 0
        Me.mtbDiaChi.SelectionStart = 0
        Me.mtbDiaChi.ShortcutsEnabled = True
        Me.mtbDiaChi.Size = New System.Drawing.Size(261, 29)
        Me.mtbDiaChi.TabIndex = 37
        Me.mtbDiaChi.UseSelectable = True
        Me.mtbDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDiaChi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 141)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 106)
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
        Me.mtbCMND.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbCMND.CustomButton.Name = ""
        Me.mtbCMND.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbCMND.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCMND.CustomButton.TabIndex = 1
        Me.mtbCMND.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCMND.CustomButton.UseSelectable = True
        Me.mtbCMND.CustomButton.Visible = False
        Me.mtbCMND.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbCMND.Lines = New String(-1) {}
        Me.mtbCMND.Location = New System.Drawing.Point(196, 102)
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
        Me.Label5.Location = New System.Drawing.Point(18, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Số CMND"
        '
        'mdtNgaySinh
        '
        Me.mdtNgaySinh.Location = New System.Drawing.Point(196, 63)
        Me.mdtNgaySinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mdtNgaySinh.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgaySinh.Name = "mdtNgaySinh"
        Me.mdtNgaySinh.Size = New System.Drawing.Size(261, 29)
        Me.mdtNgaySinh.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Ngày sinh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = ":"
        '
        'mtbTenNV
        '
        '
        '
        '
        Me.mtbTenNV.CustomButton.Image = Nothing
        Me.mtbTenNV.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.mtbTenNV.CustomButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mtbTenNV.CustomButton.Name = ""
        Me.mtbTenNV.CustomButton.Size = New System.Drawing.Size(18, 17)
        Me.mtbTenNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTenNV.CustomButton.TabIndex = 1
        Me.mtbTenNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTenNV.CustomButton.UseSelectable = True
        Me.mtbTenNV.CustomButton.Visible = False
        Me.mtbTenNV.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbTenNV.Lines = New String(-1) {}
        Me.mtbTenNV.Location = New System.Drawing.Point(196, 24)
        Me.mtbTenNV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtbTenNV.MaxLength = 32767
        Me.mtbTenNV.Name = "mtbTenNV"
        Me.mtbTenNV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTenNV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTenNV.SelectedText = ""
        Me.mtbTenNV.SelectionLength = 0
        Me.mtbTenNV.SelectionStart = 0
        Me.mtbTenNV.ShortcutsEnabled = True
        Me.mtbTenNV.Size = New System.Drawing.Size(261, 29)
        Me.mtbTenNV.TabIndex = 27
        Me.mtbTenNV.UseSelectable = True
        Me.mtbTenNV.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTenNV.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 28)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Tên nhân viên"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(1084, 524)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(152, 45)
        Me.MetroButton2.TabIndex = 72
        Me.MetroButton2.Text = "Cập nhật"
        Me.MetroButton2.UseSelectable = True
        '
        'frmQLNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 682)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("Calibri Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQLNhanVien"
        Me.Padding = New System.Windows.Forms.Padding(30, 48, 30, 32)
        Me.Resizable = False
        Me.Text = "Quản lý nhân viên"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.mtpThongTinNV.ResumeLayout(False)
        CType(Me.dtgNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mtpThemMoi.ResumeLayout(False)
        Me.mtpThemMoi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents mtpThongTinNV As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtpThemMoi As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoCMND As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txbTimkiem As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rdoNhanVien As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mbtnXoa As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbTenNV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mdtNgaySinh As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label24 As Label
    Friend WithEvents mtbMatKhau As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents mtbTaiKhoan As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents mtbLuong As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents mtbEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbSDT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbDiaChi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbCMND As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents mdtNgayLam As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mcbGioiTinh As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents mcbChucVu As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtgNhanVien As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label16 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
