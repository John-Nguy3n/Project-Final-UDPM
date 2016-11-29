Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmQLDichVu
    Dim MaLoaiDV As String
    Dim Ngay As Date
    Public Sub DinhDang()
        dtwThuocTinh.MultiSelect = True
        dtwThuocTinh.AllowUserToDeleteRows = True
        dtwThuocTinh.AllowUserToAddRows = True
        dtwThuocTinh.AllowUserToResizeColumns = True
        dtwThuocTinh.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtwThuocTinh.MultiSelect = True
        dtwThuocTinh.AllowUserToDeleteRows = True
        dtwThuocTinh.AllowUserToAddRows = True
        dtwThuocTinh.AllowUserToResizeColumns = True
        dtwThuocTinh.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtwThuocTinh.Columns(0).HeaderText = "Mã Dịch Vụ"
        dtwThuocTinh.Columns(1).HeaderText = "Tên Dịch Vụ"
        dtwThuocTinh.Columns(2).HeaderText = "Đơn Vị Tính"
        dtwThuocTinh.Columns(3).HeaderText = "Giá Dịch Vụ"
        dtwThuocTinh.Columns(4).HeaderText = "Ngày"
        dtwThuocTinh.Columns(0).Width = 150
        dtwThuocTinh.Columns(1).Width = 210
        dtwThuocTinh.Columns(2).Width = 150
        dtwThuocTinh.Columns(3).Width = 150
        dtwThuocTinh.Columns(4).Width = 150
    End Sub

    Private Sub frmQLDichVu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String
        str = "select TenLoaiDV from LOAI_DV"
        Dim lenh As New SqlCommand(str, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            Me.TwDichVu.Nodes.Add(doc.Item(0).ToString)
        Loop
        doc.Close()

    End Sub

    Private Sub TwDichVu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TwDichVu.AfterSelect

        Dim str As String
        MaLoaiDV = LayMa("MaLoaiDV", "Loai_DV", "TenLoaiDV=N'" & TwDichVu.SelectedNode.Text & "'")
        If MaLoaiDV = "" Then
            str = "SELECT        DICH_VU.MaDV, DICH_VU.TenDV, DICH_VU.DVT, GIA_DV.GiaDV, GIA_DV.Ngay
FROM            DICH_VU INNER JOIN
                         GIA_DV ON DICH_VU.MaDV = GIA_DV.MaDV "
            dtwThuocTinh.DataSource = LayDuLieu(str)
        Else
            str = "SELECT        DICH_VU.MaDV, DICH_VU.TenDV, DICH_VU.DVT, GIA_DV.GiaDV, GIA_DV.Ngay
FROM            DICH_VU INNER JOIN
                         GIA_DV ON DICH_VU.MaDV = GIA_DV.MaDV where MaLoaiDV='" & MaLoaiDV & "'"
            dtwThuocTinh.DataSource = LayDuLieu(str)
        End If
        DinhDang()
        MaLoaiDVPL = MaLoaiDV
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TwDichVu.NodeMouseClick

    End Sub

    Private Sub tsmThemSL_Click(sender As Object, e As EventArgs) Handles tsmThemSL.Click
        frmThemLoaiDV.Show()
    End Sub

    Private Sub XóaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles XóaToolStripMenuItem1.Click
        Try
            Dim str As String
            Dim MaLoaiDV As String = LayMa("MaLoaiDV", "Loai_DV", "TenLoaiDV=N'" & TwDichVu.SelectedNode.Text & "'")
            If MaLoaiDV = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Chọn loại dịch vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                str = "delete from LOAI_DV where MaLoaiDV = '" & MaLoaiDV & "'"
                Dim lenh As New SqlCommand(str, KetNoi)
                lenh.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Loại dịch vụ chưa được sử dụng, bạn có thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TwDichVu.Nodes.Clear()
            Me.TwDichVu.Nodes.Add("Tất cả")
            str = "select TenLoaiDV from LOAI_DV"
            Dim lenh1 As New SqlCommand(str, KetNoi)
            Dim doc As SqlDataReader = lenh1.ExecuteReader
            Do While doc.Read
                Me.TwDichVu.Nodes.Add(doc.Item(0).ToString)
            Loop
            doc.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Bạn không thể xóa loại dịch vụ này vì loại dịch vụ này đang được sử dung", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmThemMoiDV.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmCapNhatDV.Show()
    End Sub
    Private Sub dtwThuocTinh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwThuocTinh.CellClick
        Try
            MaDVPL = dtwThuocTinh.Rows(dtwThuocTinh.SelectedCells.Item(0).RowIndex).Cells(0).Value.ToString()
            Ngay = dtwThuocTinh.Rows(dtwThuocTinh.SelectedCells.Item(0).RowIndex).Cells(4).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SửaLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaLoạiToolStripMenuItem.Click
        frmSuaLoaiDV.Show()
    End Sub
End Class