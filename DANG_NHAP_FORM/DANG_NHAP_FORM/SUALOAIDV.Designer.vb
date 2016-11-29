<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuaLoaiDV
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
        Me.mbtXoaDV = New MetroFramework.Controls.MetroButton()
        Me.mbtThemDV = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenLoaiDV = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMaLoaiDV = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mbtXoaDV
        '
        Me.mbtXoaDV.Location = New System.Drawing.Point(356, 182)
        Me.mbtXoaDV.Name = "mbtXoaDV"
        Me.mbtXoaDV.Size = New System.Drawing.Size(86, 31)
        Me.mbtXoaDV.TabIndex = 39
        Me.mbtXoaDV.Text = "Hủy"
        Me.mbtXoaDV.UseSelectable = True
        '
        'mbtThemDV
        '
        Me.mbtThemDV.Location = New System.Drawing.Point(217, 182)
        Me.mbtThemDV.Name = "mbtThemDV"
        Me.mbtThemDV.Size = New System.Drawing.Size(85, 31)
        Me.mbtThemDV.TabIndex = 38
        Me.mbtThemDV.Text = "Lưu"
        Me.mbtThemDV.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = ":"
        '
        'txtTenLoaiDV
        '
        '
        '
        '
        Me.txtTenLoaiDV.CustomButton.Image = Nothing
        Me.txtTenLoaiDV.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtTenLoaiDV.CustomButton.Name = ""
        Me.txtTenLoaiDV.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTenLoaiDV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTenLoaiDV.CustomButton.TabIndex = 1
        Me.txtTenLoaiDV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTenLoaiDV.CustomButton.UseSelectable = True
        Me.txtTenLoaiDV.CustomButton.Visible = False
        Me.txtTenLoaiDV.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTenLoaiDV.Lines = New String(-1) {}
        Me.txtTenLoaiDV.Location = New System.Drawing.Point(217, 123)
        Me.txtTenLoaiDV.MaxLength = 32767
        Me.txtTenLoaiDV.Name = "txtTenLoaiDV"
        Me.txtTenLoaiDV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenLoaiDV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTenLoaiDV.SelectedText = ""
        Me.txtTenLoaiDV.SelectionLength = 0
        Me.txtTenLoaiDV.SelectionStart = 0
        Me.txtTenLoaiDV.ShortcutsEnabled = True
        Me.txtTenLoaiDV.Size = New System.Drawing.Size(225, 29)
        Me.txtTenLoaiDV.TabIndex = 36
        Me.txtTenLoaiDV.UseSelectable = True
        Me.txtTenLoaiDV.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTenLoaiDV.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tên loại dịch vụ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(197, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 21)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = ":"
        '
        'txtMaLoaiDV
        '
        '
        '
        '
        Me.txtMaLoaiDV.CustomButton.Image = Nothing
        Me.txtMaLoaiDV.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtMaLoaiDV.CustomButton.Name = ""
        Me.txtMaLoaiDV.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMaLoaiDV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMaLoaiDV.CustomButton.TabIndex = 1
        Me.txtMaLoaiDV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMaLoaiDV.CustomButton.UseSelectable = True
        Me.txtMaLoaiDV.CustomButton.Visible = False
        Me.txtMaLoaiDV.Enabled = False
        Me.txtMaLoaiDV.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMaLoaiDV.Lines = New String(-1) {}
        Me.txtMaLoaiDV.Location = New System.Drawing.Point(217, 76)
        Me.txtMaLoaiDV.MaxLength = 32767
        Me.txtMaLoaiDV.Name = "txtMaLoaiDV"
        Me.txtMaLoaiDV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaLoaiDV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMaLoaiDV.SelectedText = ""
        Me.txtMaLoaiDV.SelectionLength = 0
        Me.txtMaLoaiDV.SelectionStart = 0
        Me.txtMaLoaiDV.ShortcutsEnabled = True
        Me.txtMaLoaiDV.Size = New System.Drawing.Size(225, 29)
        Me.txtMaLoaiDV.TabIndex = 33
        Me.txtMaLoaiDV.UseSelectable = True
        Me.txtMaLoaiDV.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMaLoaiDV.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Mã loại dịch vụ"
        '
        'frmSuaLoaiDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 230)
        Me.Controls.Add(Me.mbtXoaDV)
        Me.Controls.Add(Me.mbtThemDV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTenLoaiDV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMaLoaiDV)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Calibri Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaLoaiDV"
        Me.Padding = New System.Windows.Forms.Padding(30, 97, 30, 32)
        Me.Resizable = False
        Me.ShowInTaskbar = False
        Me.Text = "Cập nhật loại dịch vụ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mbtXoaDV As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtThemDV As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenLoaiDV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMaLoaiDV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
End Class
