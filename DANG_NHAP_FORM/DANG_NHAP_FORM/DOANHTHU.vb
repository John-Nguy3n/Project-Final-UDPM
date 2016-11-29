Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class DOANHTHU
    Public Sub dinhdang()
        dtgP.MultiSelect = True
        dtgP.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgP.AllowUserToDeleteRows = True
        dtgP.AllowUserToAddRows = True
        dtgP.AllowUserToResizeColumns = True
        dtgP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtgP.Columns(0).HeaderText = "Tên khách hàng"
        dtgP.Columns(1).HeaderText = "Tên nhân viên"
        dtgP.Columns(2).HeaderText = "Số phòng"
        dtgP.Columns(3).HeaderText = "Mã phiếu quản lý"
        dtgP.Columns(4).HeaderText = "Ngày thuê"
        dtgP.Columns(5).HeaderText = "Ngày lập"
        dtgP.Columns(6).HeaderText = "Tổng tiền"
        dtgP.Columns(7).HeaderText = "Giảm giá"
    End Sub
    Public Sub dinhdang2()
        dtgDV.MultiSelect = True
        dtgDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgDV.AllowUserToDeleteRows = True
        dtgDV.AllowUserToAddRows = True
        dtgDV.AllowUserToResizeColumns = True
        dtgDV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtgDV.Columns(0).HeaderText = "Tên dịch vụ"
        dtgDV.Columns(1).HeaderText = "Giá dịch vụ"
        dtgDV.Columns(2).HeaderText = "Số lượng"
        dtgDV.Columns(3).HeaderText = "Đơn vị"
    End Sub

    Private Sub mdtNgayDi_ValueChanged(sender As Object, e As EventArgs)

        Dim str As String = "SELECT     KHACH_HANG.TenKH, NHAN_VIEN.TenNV, CT_PHIEU_QL.MaPhong, CT_PHIEU_QL.MaPhieuQL, PHIEU_QL.NgayThue, HOA_DON.NgayLap, HOA_DON.TongTien, Hoa_DON.GiamGia FROM         HOA_DON INNER JOIN KHACH_HANG ON HOA_DON.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON HOA_DON.MaNV = NHAN_VIEN.MaNV INNER JOIN PHIEU_QL ON HOA_DON.MaPhieuQL = PHIEU_QL.MaPhieuQL INNER JOIN CT_PHIEU_QL ON PHIEU_QL.MaPhieuQL = CT_PHIEU_QL.MaPhieuQL where NgayLap between CONVERT(DATETIME, '" & MetroDateTime1.Value & "', 102) and CONVERT(DATETIME, '" & MetroDateTime2.Value & "', 102) group by KHACH_HANG.TenKH, NHAN_VIEN.TenNV, CT_PHIEU_QL.MaPhong,CT_PHIEU_QL.MaPhieuQL, PHIEU_QL.NgayThue, HOA_DON.NgayLap, HOA_DON.TongTien, Hoa_DON.GiamGia"
        dtgP.DataSource = LayDuLieu(str)
        Dim TongTien, GiamGia As Double
        Dim lenh As New SqlCommand(str, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            TongTien += Val(doc.Item(6).ToString)
            GiamGia += Val(doc.Item(7).ToString)
        Loop
        doc.Close()

        str = "SELECT     DICH_VU.TenDV, t1.GiaDV, sum(CT_PHIEU_QL.SoLuong), DICH_VU.DVT FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN CT_PHIEU_QL ON DICH_VU.MaDV = CT_PHIEU_QL.MaDV where MaPhieuQL in (select MaPhieuQL from HOA_DON where NgayLap between CONVERT(DATETIME, '" & MetroDateTime1.Value & "', 102) and CONVERT(DATETIME, '" & MetroDateTime2.Value & "', 102)) GROUP BY DICH_VU.TenDV, DICH_VU.DVT, t1.GiaDV"
        dtgDV.DataSource = LayDuLieu(str)
        Dim lenh1 As New SqlCommand(str, KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Dim TienDV As Double
        Do While doc1.Read
            TienDV += Val(doc1.Item(1).ToString) * Val(doc1.Item(2).ToString)
        Loop
        doc1.Close()
        txtTienGV.Text = Format(TienDV, "#,##0 VNĐ")
        Label5.Text = Format(TongTien + GiamGia, "#,##0 VNĐ")
        Label7.Text = Format(GiamGia, "#,##0 VNĐ")
        Label9.Text = Format(TongTien, "#,##0 VNĐ")


    End Sub

    Private Sub dtgP_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim str As String
        str = "SELECT     DICH_VU.TenDV, t1.GiaDV, SUM(CT_PHIEU_QL.SoLuong) AS Expr1, DICH_VU.DVT FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN CT_PHIEU_QL ON DICH_VU.MaDV = CT_PHIEU_QL.MaDV GROUP BY DICH_VU.TenDV, DICH_VU.DVT, t1.GiaDV, CT_PHIEU_QL.MaPhieuQL HAVING      (CT_PHIEU_QL.MaPhieuQL = '" & dtgP.Rows(dtgP.SelectedCells.Item(0).RowIndex).Cells(3).Value.ToString & "')"
        dtgDV.DataSource = LayDuLieu(str)
        Dim lenh1 As New SqlCommand(str, KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Dim TienDV As Double
        Do While doc1.Read
            TienDV += Val(doc1.Item(1).ToString) * Val(doc1.Item(2).ToString)
        Loop
        doc1.Close()
        txtTienGV.Text = Format(TienDV, "#,##0 VNĐ")
    End Sub

    Private Sub DOANHTHU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "SELECT     KHACH_HANG.TenKH, NHAN_VIEN.TenNV, CT_PHIEU_QL.MaPhong, CT_PHIEU_QL.MaPhieuQL, PHIEU_QL.NgayThue, HOA_DON.NgayLap, HOA_DON.TongTien, Hoa_DON.GiamGia FROM         HOA_DON INNER JOIN KHACH_HANG ON HOA_DON.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON HOA_DON.MaNV = NHAN_VIEN.MaNV INNER JOIN PHIEU_QL ON HOA_DON.MaPhieuQL = PHIEU_QL.MaPhieuQL INNER JOIN CT_PHIEU_QL ON PHIEU_QL.MaPhieuQL = CT_PHIEU_QL.MaPhieuQL group by KHACH_HANG.TenKH, NHAN_VIEN.TenNV, CT_PHIEU_QL.MaPhong,CT_PHIEU_QL.MaPhieuQL, PHIEU_QL.NgayThue, HOA_DON.NgayLap, HOA_DON.TongTien, Hoa_DON.GiamGia"
        dtgP.DataSource = LayDuLieu(str)
        Dim TongTien, GiamGia As Double
        Dim lenh As New SqlCommand(str, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            TongTien += Val(doc.Item(6).ToString)
            GiamGia += Val(doc.Item(7).ToString)
        Loop
        doc.Close()

        str = "SELECT     DICH_VU.TenDV, t1.GiaDV, sum(CT_PHIEU_QL.SoLuong), DICH_VU.DVT FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN CT_PHIEU_QL ON DICH_VU.MaDV = CT_PHIEU_QL.MaDV GROUP BY DICH_VU.TenDV, DICH_VU.DVT, t1.GiaDV"
        dtgDV.DataSource = LayDuLieu(str)
        Dim lenh1 As New SqlCommand(str, KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Dim TienDV As Double
        Do While doc1.Read
            TienDV += Val(doc1.Item(1).ToString) * Val(doc1.Item(2).ToString)
        Loop
        doc1.Close()
        txtTienGV.Text = Format(TienDV, "#,##0 VNĐ")
        Label5.Text = Format(TongTien + GiamGia, "#,##0 VNĐ")
        Label7.Text = Format(GiamGia, "#,##0 VNĐ")
        Label9.Text = Format(TongTien, "#,##0 VNĐ")
        dinhdang()
        dinhdang2()
    End Sub

    Private Sub ĐóngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐóngToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class