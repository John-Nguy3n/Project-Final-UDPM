<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLDichVu
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tất cả")
        Me.TwDichVu = New System.Windows.Forms.TreeView()
        Me.dtwThuocTinh = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LọcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.tsmThemSL = New System.Windows.Forms.ToolStripMenuItem()
        Me.SửaLoạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtwThuocTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TwDichVu
        '
        Me.TwDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TwDichVu.Location = New System.Drawing.Point(6, 59)
        Me.TwDichVu.Name = "TwDichVu"
        TreeNode1.Name = "twTatCa"
        TreeNode1.Text = "Tất cả"
        Me.TwDichVu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TwDichVu.Size = New System.Drawing.Size(262, 531)
        Me.TwDichVu.TabIndex = 1
        '
        'dtwThuocTinh
        '
        Me.dtwThuocTinh.BackgroundColor = System.Drawing.Color.White
        Me.dtwThuocTinh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtwThuocTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtwThuocTinh.Location = New System.Drawing.Point(6, 59)
        Me.dtwThuocTinh.Name = "dtwThuocTinh"
        Me.dtwThuocTinh.Size = New System.Drawing.Size(862, 531)
        Me.dtwThuocTinh.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.dtwThuocTinh)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 596)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "THÔNG TIN CÁC DỊCH VỤ"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.InToolStripMenuItem, Me.LọcToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(285, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.Insert
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripMenuItem1.Text = "Thêm mới"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.Editing_Edit_icon
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(88, 20)
        Me.ToolStripMenuItem2.Text = "Chính sửa"
        '
        'InToolStripMenuItem
        '
        Me.InToolStripMenuItem.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.copy_icon_1_
        Me.InToolStripMenuItem.Name = "InToolStripMenuItem"
        Me.InToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.InToolStripMenuItem.Text = "In"
        '
        'LọcToolStripMenuItem
        '
        Me.LọcToolStripMenuItem.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.filter_icon_14
        Me.LọcToolStripMenuItem.Name = "LọcToolStripMenuItem"
        Me.LọcToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.LọcToolStripMenuItem.Text = "Lọc"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmThemSL, Me.SửaLoạiToolStripMenuItem, Me.XóaToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(4, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip2.Size = New System.Drawing.Size(321, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tsmThemSL
        '
        Me.tsmThemSL.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.Insert
        Me.tsmThemSL.Name = "tsmThemSL"
        Me.tsmThemSL.Size = New System.Drawing.Size(90, 20)
        Me.tsmThemSL.Text = "Thêm mới"
        '
        'SửaLoạiToolStripMenuItem
        '
        Me.SửaLoạiToolStripMenuItem.BackgroundImage = Global.DANG_NHAP_FORM.My.Resources.Resources.Editing_Edit_icon
        Me.SửaLoạiToolStripMenuItem.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.Editing_Edit_icon
        Me.SửaLoạiToolStripMenuItem.Name = "SửaLoạiToolStripMenuItem"
        Me.SửaLoạiToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SửaLoạiToolStripMenuItem.Text = "Sửa loại"
        '
        'XóaToolStripMenuItem1
        '
        Me.XóaToolStripMenuItem1.BackgroundImage = Global.DANG_NHAP_FORM.My.Resources.Resources.Cancel
        Me.XóaToolStripMenuItem1.Image = Global.DANG_NHAP_FORM.My.Resources.Resources.Cancel
        Me.XóaToolStripMenuItem1.Name = "XóaToolStripMenuItem1"
        Me.XóaToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.XóaToolStripMenuItem1.Text = "Xóa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Controls.Add(Me.TwDichVu)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 596)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOẠI DỊCH VỤ"
        '
        'frmQLDichVu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("Calibri Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQLDichVu"
        Me.Padding = New System.Windows.Forms.Padding(30, 48, 30, 32)
        Me.Resizable = False
        Me.Text = "Quản lý dịch vụ"
        CType(Me.dtwThuocTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TwDichVu As TreeView
    Friend WithEvents dtwThuocTinh As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents tsmThemSL As ToolStripMenuItem
    Friend WithEvents SửaLoạiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents XóaToolStripMenuItem1 As ToolStripMenuItem
End Class
