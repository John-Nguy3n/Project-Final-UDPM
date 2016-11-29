<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblDangNhap = New System.Windows.Forms.Label()
        Me.lblThoat = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtMatKhau = New DANG_NHAP_FORM.WaterMark_LOGIN()
        Me.txtTaiKhoan = New DANG_NHAP_FORM.WaterMark_LOGIN()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UTM Micra", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(22, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.DANG_NHAP_FORM.My.Resources.Resources.Password
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(235, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DANG_NHAP_FORM.My.Resources.Resources.Account
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(235, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(20, 30)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(442, 218)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.Location = New System.Drawing.Point(335, 185)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(1, 25)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.Location = New System.Drawing.Point(234, 115)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(194, 1)
        '
        'lblDangNhap
        '
        Me.lblDangNhap.AutoSize = True
        Me.lblDangNhap.Font = New System.Drawing.Font("UTM Daxline Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDangNhap.ForeColor = System.Drawing.Color.Gray
        Me.lblDangNhap.Location = New System.Drawing.Point(231, 216)
        Me.lblDangNhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.Size = New System.Drawing.Size(87, 23)
        Me.lblDangNhap.TabIndex = 8
        Me.lblDangNhap.Text = "Đăng nhập"
        '
        'lblThoat
        '
        Me.lblThoat.AutoSize = True
        Me.lblThoat.Font = New System.Drawing.Font("UTM Daxline Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThoat.ForeColor = System.Drawing.Color.Gray
        Me.lblThoat.Location = New System.Drawing.Point(405, 216)
        Me.lblThoat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThoat.Name = "lblThoat"
        Me.lblThoat.Size = New System.Drawing.Size(51, 23)
        Me.lblThoat.TabIndex = 9
        Me.lblThoat.Text = "Thoát"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.DANG_NHAP_FORM.My.Resources.Resources.Account
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(26, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(165, 159)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'txtMatKhau
        '
        Me.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMatKhau.Font = New System.Drawing.Font("UTM Daxline Medium", 12.75!)
        Me.txtMatKhau.Location = New System.Drawing.Point(263, 153)
        Me.txtMatKhau.Multiline = True
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtMatKhau.Size = New System.Drawing.Size(195, 25)
        Me.txtMatKhau.TabIndex = 12
        Me.txtMatKhau.WatermarkColor = System.Drawing.Color.Gray
        Me.txtMatKhau.WatermarkText = "Mật khẩu"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTaiKhoan.Font = New System.Drawing.Font("UTM Daxline Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaiKhoan.Location = New System.Drawing.Point(263, 114)
        Me.txtTaiKhoan.Multiline = True
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(195, 25)
        Me.txtTaiKhoan.TabIndex = 11
        Me.txtTaiKhoan.WatermarkColor = System.Drawing.Color.Gray
        Me.txtTaiKhoan.WatermarkText = "Tài khoản"
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 268)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblThoat)
        Me.Controls.Add(Me.lblDangNhap)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("UTM BryantLG", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDangNhap"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents lblDangNhap As Label
    Friend WithEvents lblThoat As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents txtTaiKhoan As WaterMark_LOGIN
    Friend WithEvents txtMatKhau As WaterMark_LOGIN
End Class
