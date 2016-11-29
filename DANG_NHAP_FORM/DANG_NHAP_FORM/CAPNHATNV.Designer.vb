<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCapNhatNV
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
        Me.mdtNgayLam = New MetroFramework.Controls.MetroDateTime()
        Me.mcbGioiTinh = New MetroFramework.Controls.MetroComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mtbMatKhau = New MetroFramework.Controls.MetroTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mtbTaiKhoan = New MetroFramework.Controls.MetroTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.mcbMaNV = New MetroFramework.Controls.MetroComboBox()
        Me.mcbChucVu = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'mdtNgayLam
        '
        Me.mdtNgayLam.Location = New System.Drawing.Point(608, 222)
        Me.mdtNgayLam.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgayLam.Name = "mdtNgayLam"
        Me.mdtNgayLam.Size = New System.Drawing.Size(206, 29)
        Me.mdtNgayLam.TabIndex = 103
        '
        'mcbGioiTinh
        '
        Me.mcbGioiTinh.FormattingEnabled = True
        Me.mcbGioiTinh.ItemHeight = 23
        Me.mcbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.mcbGioiTinh.Location = New System.Drawing.Point(177, 317)
        Me.mcbGioiTinh.Name = "mcbGioiTinh"
        Me.mcbGioiTinh.Size = New System.Drawing.Size(261, 29)
        Me.mcbGioiTinh.TabIndex = 102
        Me.mcbGioiTinh.UseSelectable = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(576, 133)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 20)
        Me.Label24.TabIndex = 101
        Me.Label24.Text = ":"
        '
        'mtbMatKhau
        '
        '
        '
        '
        Me.mtbMatKhau.CustomButton.Image = Nothing
        Me.mtbMatKhau.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.mtbMatKhau.CustomButton.Name = ""
        Me.mtbMatKhau.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbMatKhau.CustomButton.TabIndex = 1
        Me.mtbMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbMatKhau.CustomButton.UseSelectable = True
        Me.mtbMatKhau.CustomButton.Visible = False
        Me.mtbMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbMatKhau.Lines = New String(-1) {}
        Me.mtbMatKhau.Location = New System.Drawing.Point(608, 128)
        Me.mtbMatKhau.MaxLength = 32767
        Me.mtbMatKhau.Name = "mtbMatKhau"
        Me.mtbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbMatKhau.SelectedText = ""
        Me.mtbMatKhau.SelectionLength = 0
        Me.mtbMatKhau.SelectionStart = 0
        Me.mtbMatKhau.ShortcutsEnabled = True
        Me.mtbMatKhau.Size = New System.Drawing.Size(206, 29)
        Me.mtbMatKhau.TabIndex = 100
        Me.mtbMatKhau.UseSelectable = True
        Me.mtbMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbMatKhau.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(462, 133)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 20)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "Mật khẩu"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(576, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 20)
        Me.Label22.TabIndex = 98
        Me.Label22.Text = ":"
        '
        'mtbTaiKhoan
        '
        '
        '
        '
        Me.mtbTaiKhoan.CustomButton.Image = Nothing
        Me.mtbTaiKhoan.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.mtbTaiKhoan.CustomButton.Name = ""
        Me.mtbTaiKhoan.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTaiKhoan.CustomButton.TabIndex = 1
        Me.mtbTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTaiKhoan.CustomButton.UseSelectable = True
        Me.mtbTaiKhoan.CustomButton.Visible = False
        Me.mtbTaiKhoan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbTaiKhoan.Lines = New String(-1) {}
        Me.mtbTaiKhoan.Location = New System.Drawing.Point(608, 85)
        Me.mtbTaiKhoan.MaxLength = 32767
        Me.mtbTaiKhoan.Name = "mtbTaiKhoan"
        Me.mtbTaiKhoan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTaiKhoan.SelectedText = ""
        Me.mtbTaiKhoan.SelectionLength = 0
        Me.mtbTaiKhoan.SelectionStart = 0
        Me.mtbTaiKhoan.ShortcutsEnabled = True
        Me.mtbTaiKhoan.Size = New System.Drawing.Size(206, 29)
        Me.mtbTaiKhoan.TabIndex = 97
        Me.mtbTaiKhoan.UseSelectable = True
        Me.mtbTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTaiKhoan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(462, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 20)
        Me.Label23.TabIndex = 96
        Me.Label23.Text = "Tài khoản"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(576, 274)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 20)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = ":"
        '
        'mtbLuong
        '
        '
        '
        '
        Me.mtbLuong.CustomButton.Image = Nothing
        Me.mtbLuong.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.mtbLuong.CustomButton.Name = ""
        Me.mtbLuong.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbLuong.CustomButton.TabIndex = 1
        Me.mtbLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbLuong.CustomButton.UseSelectable = True
        Me.mtbLuong.CustomButton.Visible = False
        Me.mtbLuong.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbLuong.Lines = New String(-1) {}
        Me.mtbLuong.Location = New System.Drawing.Point(608, 269)
        Me.mtbLuong.MaxLength = 32767
        Me.mtbLuong.Name = "mtbLuong"
        Me.mtbLuong.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbLuong.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbLuong.SelectedText = ""
        Me.mtbLuong.SelectionLength = 0
        Me.mtbLuong.SelectionStart = 0
        Me.mtbLuong.ShortcutsEnabled = True
        Me.mtbLuong.Size = New System.Drawing.Size(206, 29)
        Me.mtbLuong.TabIndex = 94
        Me.mtbLuong.UseSelectable = True
        Me.mtbLuong.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbLuong.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(462, 274)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 20)
        Me.Label21.TabIndex = 93
        Me.Label21.Text = "Lương"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(576, 227)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 20)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(462, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 20)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "Ngày bắt đầu"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(576, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 20)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(462, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 20)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Chức vụ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(145, 415)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 20)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = ":"
        '
        'mtbEmail
        '
        '
        '
        '
        Me.mtbEmail.CustomButton.Image = Nothing
        Me.mtbEmail.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.mtbEmail.CustomButton.Name = ""
        Me.mtbEmail.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEmail.CustomButton.TabIndex = 1
        Me.mtbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEmail.CustomButton.UseSelectable = True
        Me.mtbEmail.CustomButton.Visible = False
        Me.mtbEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbEmail.Lines = New String(-1) {}
        Me.mtbEmail.Location = New System.Drawing.Point(177, 410)
        Me.mtbEmail.MaxLength = 32767
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEmail.SelectedText = ""
        Me.mtbEmail.SelectionLength = 0
        Me.mtbEmail.SelectionStart = 0
        Me.mtbEmail.ShortcutsEnabled = True
        Me.mtbEmail.Size = New System.Drawing.Size(206, 29)
        Me.mtbEmail.TabIndex = 86
        Me.mtbEmail.UseSelectable = True
        Me.mtbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(145, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 20)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = ":"
        '
        'mtbSDT
        '
        '
        '
        '
        Me.mtbSDT.CustomButton.Image = Nothing
        Me.mtbSDT.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.mtbSDT.CustomButton.Name = ""
        Me.mtbSDT.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbSDT.CustomButton.TabIndex = 1
        Me.mtbSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbSDT.CustomButton.UseSelectable = True
        Me.mtbSDT.CustomButton.Visible = False
        Me.mtbSDT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbSDT.Lines = New String(-1) {}
        Me.mtbSDT.Location = New System.Drawing.Point(177, 362)
        Me.mtbSDT.MaxLength = 32767
        Me.mtbSDT.Name = "mtbSDT"
        Me.mtbSDT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbSDT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbSDT.SelectedText = ""
        Me.mtbSDT.SelectionLength = 0
        Me.mtbSDT.SelectionStart = 0
        Me.mtbSDT.ShortcutsEnabled = True
        Me.mtbSDT.Size = New System.Drawing.Size(206, 29)
        Me.mtbSDT.TabIndex = 83
        Me.mtbSDT.UseSelectable = True
        Me.mtbSDT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbSDT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Số điện thoại"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(145, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 20)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Giới tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 20)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = ":"
        '
        'mtbDiaChi
        '
        '
        '
        '
        Me.mtbDiaChi.CustomButton.Image = Nothing
        Me.mtbDiaChi.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.mtbDiaChi.CustomButton.Name = ""
        Me.mtbDiaChi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDiaChi.CustomButton.TabIndex = 1
        Me.mtbDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDiaChi.CustomButton.UseSelectable = True
        Me.mtbDiaChi.CustomButton.Visible = False
        Me.mtbDiaChi.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbDiaChi.Lines = New String(-1) {}
        Me.mtbDiaChi.Location = New System.Drawing.Point(177, 269)
        Me.mtbDiaChi.MaxLength = 32767
        Me.mtbDiaChi.Name = "mtbDiaChi"
        Me.mtbDiaChi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDiaChi.SelectedText = ""
        Me.mtbDiaChi.SelectionLength = 0
        Me.mtbDiaChi.SelectionStart = 0
        Me.mtbDiaChi.ShortcutsEnabled = True
        Me.mtbDiaChi.Size = New System.Drawing.Size(261, 29)
        Me.mtbDiaChi.TabIndex = 78
        Me.mtbDiaChi.UseSelectable = True
        Me.mtbDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDiaChi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = ":"
        '
        'mtbCMND
        '
        '
        '
        '
        Me.mtbCMND.CustomButton.Image = Nothing
        Me.mtbCMND.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.mtbCMND.CustomButton.Name = ""
        Me.mtbCMND.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbCMND.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCMND.CustomButton.TabIndex = 1
        Me.mtbCMND.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCMND.CustomButton.UseSelectable = True
        Me.mtbCMND.CustomButton.Visible = False
        Me.mtbCMND.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbCMND.Lines = New String(-1) {}
        Me.mtbCMND.Location = New System.Drawing.Point(177, 222)
        Me.mtbCMND.MaxLength = 32767
        Me.mtbCMND.Name = "mtbCMND"
        Me.mtbCMND.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCMND.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCMND.SelectedText = ""
        Me.mtbCMND.SelectionLength = 0
        Me.mtbCMND.SelectionStart = 0
        Me.mtbCMND.ShortcutsEnabled = True
        Me.mtbCMND.Size = New System.Drawing.Size(261, 29)
        Me.mtbCMND.TabIndex = 75
        Me.mtbCMND.UseSelectable = True
        Me.mtbCMND.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCMND.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Số CMND"
        '
        'mdtNgaySinh
        '
        Me.mdtNgaySinh.Location = New System.Drawing.Point(177, 175)
        Me.mdtNgaySinh.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtNgaySinh.Name = "mdtNgaySinh"
        Me.mdtNgaySinh.Size = New System.Drawing.Size(261, 29)
        Me.mdtNgaySinh.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Ngày sinh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = ":"
        '
        'mtbTenNV
        '
        '
        '
        '
        Me.mtbTenNV.CustomButton.Image = Nothing
        Me.mtbTenNV.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.mtbTenNV.CustomButton.Name = ""
        Me.mtbTenNV.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtbTenNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTenNV.CustomButton.TabIndex = 1
        Me.mtbTenNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTenNV.CustomButton.UseSelectable = True
        Me.mtbTenNV.CustomButton.Visible = False
        Me.mtbTenNV.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtbTenNV.Lines = New String(-1) {}
        Me.mtbTenNV.Location = New System.Drawing.Point(177, 128)
        Me.mtbTenNV.MaxLength = 32767
        Me.mtbTenNV.Name = "mtbTenNV"
        Me.mtbTenNV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTenNV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTenNV.SelectedText = ""
        Me.mtbTenNV.SelectionLength = 0
        Me.mtbTenNV.SelectionStart = 0
        Me.mtbTenNV.ShortcutsEnabled = True
        Me.mtbTenNV.Size = New System.Drawing.Size(261, 29)
        Me.mtbTenNV.TabIndex = 69
        Me.mtbTenNV.UseSelectable = True
        Me.mtbTenNV.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTenNV.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 20)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Tên nhân viên"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(145, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 20)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = ":"
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.BackColor = System.Drawing.Color.Transparent
        Me.lblMaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaNV.Location = New System.Drawing.Point(31, 85)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(108, 20)
        Me.lblMaNV.TabIndex = 65
        Me.lblMaNV.Text = "Mã nhân viên"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(552, 620)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(114, 38)
        Me.MetroButton1.TabIndex = 107
        Me.MetroButton1.Text = "Cập nhật"
        Me.MetroButton1.UseSelectable = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(145, 460)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 20)
        Me.Label26.TabIndex = 106
        Me.Label26.Text = ":"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(177, 460)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(637, 148)
        Me.txtGhiChu.TabIndex = 105
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(31, 460)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 20)
        Me.Label27.TabIndex = 104
        Me.Label27.Text = "Ghi chú"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(700, 620)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(114, 38)
        Me.MetroButton2.TabIndex = 108
        Me.MetroButton2.Text = "Đóng"
        Me.MetroButton2.UseSelectable = True
        '
        'mcbMaNV
        '
        Me.mcbMaNV.FormattingEnabled = True
        Me.mcbMaNV.ItemHeight = 23
        Me.mcbMaNV.Location = New System.Drawing.Point(177, 85)
        Me.mcbMaNV.Name = "mcbMaNV"
        Me.mcbMaNV.Size = New System.Drawing.Size(261, 29)
        Me.mcbMaNV.TabIndex = 110
        Me.mcbMaNV.UseSelectable = True
        '
        'mcbChucVu
        '
        Me.mcbChucVu.FormattingEnabled = True
        Me.mcbChucVu.ItemHeight = 23
        Me.mcbChucVu.Items.AddRange(New Object() {"Admin", "Thu ngân", "Tạp vụ"})
        Me.mcbChucVu.Location = New System.Drawing.Point(608, 175)
        Me.mcbChucVu.Name = "mcbChucVu"
        Me.mcbChucVu.Size = New System.Drawing.Size(206, 29)
        Me.mcbChucVu.TabIndex = 111
        Me.mcbChucVu.UseSelectable = True
        '
        'frmCapNhatNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.mcbChucVu)
        Me.Controls.Add(Me.mcbMaNV)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.mdtNgayLam)
        Me.Controls.Add(Me.mcbGioiTinh)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.mtbMatKhau)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.mtbTaiKhoan)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.mtbLuong)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mtbEmail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.mtbSDT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mtbDiaChi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtbCMND)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mdtNgaySinh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtbTenNV)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblMaNV)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCapNhatNV"
        Me.Resizable = False
        Me.Text = "Cập nhật "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mdtNgayLam As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mcbGioiTinh As MetroFramework.Controls.MetroComboBox
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
    Friend WithEvents mdtNgaySinh As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbTenNV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblMaNV As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label26 As Label
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents mcbMaNV As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mcbChucVu As MetroFramework.Controls.MetroComboBox
End Class
