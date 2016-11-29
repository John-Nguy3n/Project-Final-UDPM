<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDoiLoaiPhong
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mbtnDoiLoaiPhong = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mcbLoaiMoi = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mcbTenPhong = New MetroFramework.Controls.MetroComboBox()
        Me.mcbLoaiCu = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 86)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 20)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Tên phòng"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(326, 86)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 20)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Loại phòng hiện tại"
        '
        'mbtnDoiLoaiPhong
        '
        Me.mbtnDoiLoaiPhong.Location = New System.Drawing.Point(394, 239)
        Me.mbtnDoiLoaiPhong.Name = "mbtnDoiLoaiPhong"
        Me.mbtnDoiLoaiPhong.Size = New System.Drawing.Size(114, 38)
        Me.mbtnDoiLoaiPhong.TabIndex = 28
        Me.mbtnDoiLoaiPhong.Text = "Đổi loại phòng"
        Me.mbtnDoiLoaiPhong.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(546, 239)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(114, 38)
        Me.MetroButton1.TabIndex = 29
        Me.MetroButton1.Text = "Hủy"
        Me.MetroButton1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Đổi sang loại phòng"
        '
        'mcbLoaiMoi
        '
        Me.mcbLoaiMoi.FormattingEnabled = True
        Me.mcbLoaiMoi.ItemHeight = 23
        Me.mcbLoaiMoi.Location = New System.Drawing.Point(259, 180)
        Me.mcbLoaiMoi.Name = "mcbLoaiMoi"
        Me.mcbLoaiMoi.Size = New System.Drawing.Size(164, 29)
        Me.mcbLoaiMoi.TabIndex = 31
        Me.mcbLoaiMoi.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(469, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = ":"
        '
        'mcbTenPhong
        '
        Me.mcbTenPhong.FormattingEnabled = True
        Me.mcbTenPhong.ItemHeight = 23
        Me.mcbTenPhong.Location = New System.Drawing.Point(130, 82)
        Me.mcbTenPhong.Name = "mcbTenPhong"
        Me.mcbTenPhong.Size = New System.Drawing.Size(164, 29)
        Me.mcbTenPhong.TabIndex = 34
        Me.mcbTenPhong.UseSelectable = True
        '
        'mcbLoaiCu
        '
        Me.mcbLoaiCu.FormattingEnabled = True
        Me.mcbLoaiCu.ItemHeight = 23
        Me.mcbLoaiCu.Location = New System.Drawing.Point(489, 82)
        Me.mcbLoaiCu.Name = "mcbLoaiCu"
        Me.mcbLoaiCu.Size = New System.Drawing.Size(164, 29)
        Me.mcbLoaiCu.TabIndex = 35
        Me.mcbLoaiCu.UseSelectable = True
        '
        'frmDoiLoaiPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.mcbLoaiCu)
        Me.Controls.Add(Me.mcbTenPhong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mcbLoaiMoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.mbtnDoiLoaiPhong)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDoiLoaiPhong"
        Me.Padding = New System.Windows.Forms.Padding(30, 97, 30, 32)
        Me.Resizable = False
        Me.Text = "Đổi loại phòng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mbtnDoiLoaiPhong As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents mcbLoaiMoi As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mcbTenPhong As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mcbLoaiCu As MetroFramework.Controls.MetroComboBox
End Class
