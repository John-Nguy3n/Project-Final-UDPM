<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemSP
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
        Me.components = New System.ComponentModel.Container()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemSP))
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mrbTenDV = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbLoaiDV = New MetroFramework.Controls.MetroRadioButton()
        Me.wmlTK = New DANG_NHAP_FORM.WaterMark_LOGIN()
        Me.dtgDichVu = New System.Windows.Forms.DataGridView()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "HOTEL_MANAGEMENTConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "TenLoaiDichVu"
        Table1.MetaSerializable = "30|30|125|100"
        Table1.Name = "LOAI_DICH_VU"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "TenDichVu"
        Table2.MetaSerializable = "185|30|125|120"
        Table2.Name = "DICH_VU"
        ColumnExpression2.Table = Table2
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "DonVi"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Name = "LOAI_DICH_VU"
        RelationColumnInfo1.NestedKeyColumn = "MaLoaiDichVu"
        RelationColumnInfo1.ParentKeyColumn = "MaLoaiDichVu"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table2
        Join1.Parent = Table1
        SelectQuery1.Relations.Add(Join1)
        SelectQuery1.Tables.Add(Table1)
        SelectQuery1.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mrbTenDV)
        Me.GroupBox1.Controls.Add(Me.mrbLoaiDV)
        Me.GroupBox1.Controls.Add(Me.wmlTK)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 93)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'mrbTenDV
        '
        Me.mrbTenDV.AutoSize = True
        Me.mrbTenDV.Location = New System.Drawing.Point(25, 61)
        Me.mrbTenDV.Name = "mrbTenDV"
        Me.mrbTenDV.Size = New System.Drawing.Size(85, 15)
        Me.mrbTenDV.TabIndex = 10
        Me.mrbTenDV.Text = "Tên dịch vụ"
        Me.mrbTenDV.UseSelectable = True
        '
        'mrbLoaiDV
        '
        Me.mrbLoaiDV.AutoSize = True
        Me.mrbLoaiDV.Checked = True
        Me.mrbLoaiDV.Location = New System.Drawing.Point(25, 33)
        Me.mrbLoaiDV.Name = "mrbLoaiDV"
        Me.mrbLoaiDV.Size = New System.Drawing.Size(87, 15)
        Me.mrbLoaiDV.TabIndex = 9
        Me.mrbLoaiDV.TabStop = True
        Me.mrbLoaiDV.Text = "Loại dịch vụ"
        Me.mrbLoaiDV.UseSelectable = True
        '
        'wmlTK
        '
        Me.wmlTK.Location = New System.Drawing.Point(158, 38)
        Me.wmlTK.Name = "wmlTK"
        Me.wmlTK.Size = New System.Drawing.Size(396, 27)
        Me.wmlTK.TabIndex = 2
        Me.wmlTK.WatermarkColor = System.Drawing.Color.Gray
        Me.wmlTK.WatermarkText = "Tìm kiếm"
        '
        'dtgDichVu
        '
        Me.dtgDichVu.AllowUserToAddRows = False
        Me.dtgDichVu.AllowUserToDeleteRows = False
        Me.dtgDichVu.AllowUserToResizeColumns = False
        Me.dtgDichVu.AllowUserToResizeRows = False
        Me.dtgDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgDichVu.BackgroundColor = System.Drawing.Color.White
        Me.dtgDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dtgDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDichVu.Location = New System.Drawing.Point(23, 159)
        Me.dtgDichVu.Name = "dtgDichVu"
        Me.dtgDichVu.ReadOnly = True
        Me.dtgDichVu.Size = New System.Drawing.Size(594, 195)
        Me.dtgDichVu.TabIndex = 9
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(453, 360)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(164, 38)
        Me.MetroButton1.TabIndex = 12
        Me.MetroButton1.Text = "Đóng"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(259, 360)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(164, 38)
        Me.MetroButton5.TabIndex = 11
        Me.MetroButton5.Text = "Thêm sản phẩm"
        Me.MetroButton5.UseSelectable = True
        '
        'frmThemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgDichVu)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton5)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemSP"
        Me.Resizable = False
        Me.Text = "Thêm dịch vụ "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mrbTenDV As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbLoaiDV As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents wmlTK As DANG_NHAP_FORM.WaterMark_LOGIN
    Friend WithEvents dtgDichVu As System.Windows.Forms.DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
End Class
