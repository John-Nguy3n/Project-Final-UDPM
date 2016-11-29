Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime

Public Class frmTrangChinhCon

#Region "Khai báo"
    Dim TinhTrang As Boolean
    Dim TenPhong As String
    Dim LoaiPhong As String
    Dim MauNen As String
    Dim NgayDen As Date = Now()
    Dim NgayDi As Date = Now()
    Dim MaDV As String
    Dim TienDV As String
    Dim TienThue As String
    Dim MaPDat As String
    Public TongTienGio, TongTienDV, GiamGio, GiamDV As String
    Dim KTSoLuong As Byte
#End Region
#Region "Biến"
    Public Sub XoaTT()
        wtmLoaiPhong.Text = ""
        wtmPhong.Text = ""
        wtmSoKhach.Text = ""
        cbbKhachHang.Text = ""
        cbbCMND.Text = ""
        wtmTienCoc.Text = ""
        wtmNoiCap.Text = ""
        txtTenNV.Text = LayMa("TenNV", "NHAN_VIEN", "MaNV='" & MaNVPL & "'")
    End Sub

    Public Sub DinhDangDV()
        dtgDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Cho phép trõ chuột bất kì thì sẽ chọn hết 1 dòng
        dtgDichVu.MultiSelect = True
        dtgDichVu.AllowUserToDeleteRows = True
        dtgDichVu.AllowUserToAddRows = True
        dtgDichVu.AllowUserToResizeColumns = True
        dtgDichVu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtgDichVu.Columns(0).HeaderText = "Tên Dịch Vụ"
        dtgDichVu.Columns(1).HeaderText = "Đơn Giá"
        dtgDichVu.Columns(2).HeaderText = "Số Lượng"
        dtgDichVu.Columns(3).HeaderText = "Đơn Vị"
    End Sub
    Public Sub DinhDangDSDP()
        dtgDSDatPhong.MultiSelect = True
        dtgDSDatPhong.AllowUserToDeleteRows = True
        dtgDSDatPhong.AllowUserToAddRows = True
        dtgDSDatPhong.AllowUserToResizeColumns = True
        dtgDSDatPhong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtgDSDatPhong.Columns(0).HeaderText = "Mã Phiếu Đặt"
        dtgDSDatPhong.Columns(1).HeaderText = "Tên Khách Hàng"
        dtgDSDatPhong.Columns(2).HeaderText = "Số CMND"
        dtgDSDatPhong.Columns(3).HeaderText = "Nơi Cấp"
        dtgDSDatPhong.Columns(4).HeaderText = "Ngày Cấp"
        dtgDSDatPhong.Columns(5).HeaderText = "Ngày Nhận"
        dtgDSDatPhong.Columns(6).HeaderText = "Ngày Đi"
        dtgDSDatPhong.Columns(7).HeaderText = "Tiền Cọc"
        dtgDSDatPhong.Columns(8).HeaderText = "Số Người"
        dtgDSDatPhong.Columns(9).HeaderText = "Tên Nhân Viên"
        dtgDSDatPhong.Columns(10).HeaderText = "Tên Loại"
        dtgDSDatPhong.Columns(11).HeaderText = "Phòng"

    End Sub

    Public Sub XoaDl()
        mtbCMNDsd.Text = ""
        mtbNoiCapsd.Text = ""
        mtbTenKHsd.Text = ""
        mtbNhanViensd.Text = ""
        mdtNgayNhan.Value = Now()
        mdtNgayTraCT.Value = Now()
        mbtNgayCapsd.Value = Now()
        mbtNgaySinhsd.Value = Now()
        lbxSoKhachsd.Text = 1
        mtbGiaDichVu.Text = ""
        mtbGiaPhong.Text = ""
        cbbGiamDV.SelectedIndex = 0
        cbbGiamPhong.SelectedIndex = 0
    End Sub
    Public Sub loadDuLieu(MaPhong As String)
        'khai bao
        Dim NgayThue As Date = Now()
        Dim NgayTra As Date = Now()
        Dim NgayCap As Date = Now()
        Dim NgaySinh As Date = Now()
        Dim CMND, NoiCap, TenKH, NhanVien As String
        Dim sql1, sql2, sql3 As String
        sql2 = "select MaTinhTrang from phong where MaPhong=" & MaPhong
        sql1 = "SELECT  top 1   KHACH_HANG.TenKH, KHACH_HANG.CMND, KHACH_HANG.NoiCap, KHACH_HANG.NgaySinh, PHIEU_DAT.NgayDat, NHAN_VIEN.TenNV, KHACH_HANG.NgayCap, PHIEU_DAT.NgayDi, PHIEU_DAT.SoNguoi, CT_PHIEU_DAT.MaPhong, PHIEU_DAT.NgayLap FROM         NHAN_VIEN INNER JOIN PHIEU_DAT ON NHAN_VIEN.MaNV = PHIEU_DAT.MaNV INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN CT_PHIEU_DAT ON PHIEU_DAT.MaPDat = CT_PHIEU_DAT.MaPDAT WHERE(CT_PHIEU_DAT.MaPhong = " & MaPhong & ") ORDER BY PHIEU_DAT.NgayLap DESC"

        sql3 = "select DICH_VU.TenDV, t1.GiaDV, CT_PHIEU_QL.SoLuong, DICH_VU.DVT from GIA_DV t1 join(select	madv,MAX(Ngay) NgayBan from GIA_DV group by madv) t2 on	t1.madv = t2.madv and t1.Ngay = t2.Ngayban INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN CT_PHIEU_QL ON DICH_VU.MaDV = CT_PHIEU_QL.MaDV where CT_PHIEU_QL.MaPhong=" & MaPhong & " and MaPhieuQL="
        If LayDuLieu(sql2).Rows(0).Item(0).ToString = "DD" Then 'khi phòng đã đặt
            XoaDl()
            Me.mtlChuyenDoi.Text = "Nhận Phòng " & MaPhong
            TenKH = LayDuLieu(sql1).Rows(0).Item(0)
            CMND = LayDuLieu(sql1).Rows(0).Item(1)
            NoiCap = LayDuLieu(sql1).Rows(0).Item(2)
            Try
                NgaySinh = LayDuLieu(sql1).Rows(0).Item(3)
            Catch ex As Exception
                NgaySinh = Now()
            End Try
            NgayThue = LayDuLieu(sql1).Rows(0).Item(4)
            NhanVien = LayDuLieu(sql1).Rows(0).Item(5)
            NgayCap = LayDuLieu(sql1).Rows(0).Item(6)
            NgayTra = LayDuLieu(sql1).Rows(0).Item(7)

            lbxSoKhachsd.Text = LayDuLieu(sql1).Rows(0).Item(8)
            mdtNgayNhan.Value = NgayThue
            mbtNgaySinhsd.Value = NgaySinh
            mdtNgayTraCT.Value = NgayTra
            mbtNgayCapsd.Value = NgayCap
            mtbCMNDsd.Text = CMND
            mtbNoiCapsd.Text = NoiCap
            mtbTenKHsd.Text = TenKH
            mtbNhanViensd.Text = NhanVien
            dtgDichVu.DataSource = ""
            mtbTienDichVu.Text = ""
            mtbTienGio.Text = ""
            mbtThemDV.Enabled = True
            mbtXoaDV.Enabled = True
            mbtThanhToan.Enabled = True
            mbtSuaChua.Enabled = False
        ElseIf LayDuLieu(sql2).Rows(0).Item(0).ToString = "SD" Then 'Khi Phòng có khách

            'mtlChuyenDoi.Enabled = False
            XoaDl()
            Me.mtlChuyenDoi.Text = "Phòng " & MaPhong
            TenKH = LayDuLieu(sql1).Rows(0).Item(0)
            CMND = LayDuLieu(sql1).Rows(0).Item(1)
            NoiCap = LayDuLieu(sql1).Rows(0).Item(2)
            Try
                NgaySinh = LayDuLieu(sql1).Rows(0).Item(3)
            Catch ex As Exception
                NgaySinh = Now()
            End Try
            NgayThue = LayDuLieu(sql1).Rows(0).Item(4)
            NhanVien = LayDuLieu(sql1).Rows(0).Item(5)
            NgayCap = LayDuLieu(sql1).Rows(0).Item(6)
            NgayTra = LayDuLieu(sql1).Rows(0).Item(7)

            lbxSoKhachsd.Text = LayDuLieu(sql1).Rows(0).Item(8)
            mdtNgayNhan.Value = NgayThue
            mbtNgaySinhsd.Value = NgaySinh
            mdtNgayTraCT.Value = NgayTra
            mbtNgayCapsd.Value = NgayCap
            mtbCMNDsd.Text = CMND
            mtbNoiCapsd.Text = NoiCap
            mtbTenKHsd.Text = TenKH
            mtbNhanViensd.Text = NhanVien



            mbtThemDV.Enabled = True
            mbtXoaDV.Enabled = True
            mbtThanhToan.Enabled = True

            Dim MaKH As String
            MaKH = LayMa("MaKH", "KHACH_HANG", "CMND='" & mtbCMNDsd.Text & "'")

            'Lấy Mã phiếu đặt
            Dim MaPDat As String
            MaPDat = LayMa("MaPDat", "Phieu_dat", "NgayDat=CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102) and MaKH='" & MaKH & "'")

            'Lấy Mã Phiếu Quản Lý
            MaPhieuQLPL = LayMa("MaPhieuQL", "PHIEU_QL", "MaPDat=" & MaPDat & " and NgayThue=CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102)")

            dtgDichVu.DataSource = LayDuLieu(sql3 & MaPhieuQLPL)
            DinhDangDV()
            'Lấy tiền dịch vụ
            Dim str As String = "select sum(TienDV),MaPhong,MaPhieuQL from (select DICH_VU.TenDV, t1.GiaDV, CT_PHIEU_QL.SoLuong, DICH_VU.DVT,CT_PHIEU_QL.MaPhieuQL,CT_PHIEU_QL.MaPhong, CT_PHIEU_QL.SoLuong *t1.GiaDV as TienDV from GIA_DV t1 inner join (select	madv,MAX(Ngay) NgayBan from GIA_DV group by madv) t2 on	t1.madv = t2.madv and t1.Ngay = t2.Ngayban INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN CT_PHIEU_QL ON DICH_VU.MaDV = CT_PHIEU_QL.MaDV)  as t3 where MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & vb.Right(mtlChuyenDoi.Text, 3) & "group by MaPhieuQL, MaPhong "
            Dim lenh As New SqlCommand(str, KetNoi)
            Dim doc As SqlDataReader = lenh.ExecuteReader

            Do While doc.Read
                TienDV = doc.Item(0).ToString
            Loop
            doc.Close()
            TongTienDV = TienDV
            mtbTienDichVu.Text = Format(Val(TienDV), "#,##0 VNĐ")

            'Lấy tiền giờ
            str = "select phong.MaPhong, GiaGio, GiaNgay from PHONG inner join (select t1.MaLoai, GiaGio, GiaNgay  from Gia_Phong t1 inner join (select MaLoai, MAX(Ngay) NgayDat from GIA_PHONG group by MaLoai) t2 on t1.MaLoai=t2.MaLoai and t1.Ngay=t2.NgayDat) t3 on phong.MaLoai= t3.MaLoai where Phong.MaPhong=" & vb.Right(mtlChuyenDoi.Text, 3)
            Dim lenh1 As New SqlCommand(str, KetNoi)
            Dim doc1 As SqlDataReader = lenh1.ExecuteReader
            Dim TienPhong, TienGio As String

            Do While doc1.Read
                TienGio = doc1.Item(1).ToString
                TienPhong = doc1.Item(2).ToString
            Loop
            doc1.Close()

            Dim SoNgay As String = DateDiff(DateInterval.Day, mdtNgayNhan.Value, Now())
            If SoNgay = 0 Then
                TienThue = TienGio
            Else
                TienThue = SoNgay * TienPhong
            End If

            TongTienGio = TienThue
            mtbTienGio.Text = Format(Val(TienThue), "#,##0 VNĐ")
            mbtSuaChua.Enabled = False



        ElseIf LayDuLieu(sql2).Rows(0).Item(0).ToString = "TB" Then 'Khi Phòng đang sửa
            XoaDl()
            Me.mtlChuyenDoi.Text = "Đã Sửa Xong Phòng " & MaPhong
            mtbCMNDsd.Enabled = False
            mtbNoiCapsd.Enabled = False
            mtbTenKHsd.Enabled = False
            mtbNhanViensd.Enabled = False
            dtgDichVu.DataSource = ""

            mbtThemDV.Enabled = False
            mbtXoaDV.Enabled = False
            mbtThanhToan.Enabled = False
            mbtSuaChua.Enabled = False
        Else 'Khi Phòng Trông
            XoaDl()
            Me.mtlChuyenDoi.Text = "Đặt Phòng " & MaPhong
            dtgDichVu.DataSource = ""

            mbtThemDV.Enabled = False
            mbtXoaDV.Enabled = False
            mbtThanhToan.Enabled = False
            mbtSuaChua.Enabled = True
        End If

    End Sub
    Public Sub LoadMau()
        DoiMau(mttP101)
        DoiMau(mttP102)
        DoiMau(mttP103)
        DoiMau(mttP104)
        DoiMau(mttP105)
        DoiMau(mttP106)
        DoiMau(mttP107)
        DoiMau(mttP108)
        DoiMau(mttP201)
        DoiMau(mttP202)
        DoiMau(mttP203)
        DoiMau(mttP204)
        DoiMau(mttP205)
        DoiMau(mttP206)
        DoiMau(mttP207)
        DoiMau(mttP208)
        DoiMau(mttP301)
        DoiMau(mttP302)
        DoiMau(mttP303)
        DoiMau(mttP304)
        DoiMau(mttP401)
        DoiMau(mttP402)
        DoiMau(mttP403)
        DoiMau(mttP404)
    End Sub
    Public Sub DoiMau(Phong As MetroFramework.Controls.MetroTile)
        Try
            TenPhong = Phong.Text
            Dim sql As String = ""
            Dim tt As String = ""
            sql = "select phong.MaTinhTrang from phong where phong.MaPhong=" & Val(vb.Right(TenPhong, 3))
            tt = LayDuLieu(sql).Rows(0).Item(0).ToString

            If tt = "DD" Then
                Phong.Style = MetroFramework.MetroColorStyle.Silver
            ElseIf tt = "TB" Then
                Phong.Style = MetroFramework.MetroColorStyle.Red
            ElseIf tt = "SD" Then
                Phong.Style = MetroFramework.MetroColorStyle.Green
            Else
                Phong.Style = MetroFramework.MetroColorStyle.Default
            End If
        Catch ex As Exception
            Phong.Style = MetroFramework.MetroColorStyle.Default
        End Try

    End Sub
    Public Sub DoiTrangThai(phong As String, TinhTrang As String)
        Dim lenh As New SqlCommand("update phong set MaTinhTrang='" & TinhTrang & "' where MaPhong=" & phong, KetNoi)
        lenh.ExecuteNonQuery()
        MetroFramework.MetroMessageBox.Show(Me, "Đã làm mới lại dữ liệu", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
#End Region
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles mbtThemDV.Click

        'Lấy Mã Khách Hàng
        Dim MaKH As String
        MaKH = LayMa("MaKH", "KHACH_HANG", "CMND='" & mtbCMNDsd.Text & "'")

        'Lấy Mã phiếu đặt
        Dim MaPDat As String
        MaPDat = LayMa("MaPDat", "Phieu_dat", "NgayDat=CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102) and MaKH='" & MaKH & "'")

        'Lấy Mã Phiếu Quản Lý
        MaPhieuQLPL = LayMa("MaPhieuQL", "PHIEU_QL", "MaPDat=" & MaPDat & " and NgayThue=CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102)")

        frmThemSP.Show()


    End Sub
    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles mbtThanhToan.Click
        frmThanhToan.Show()

    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles mbtDatPhong.Click
        If Me.cbbCMND.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Mời bạn nhập thông tin khách hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'lấy mã nhân viên
            Dim MaNV As String = MaNVPL
            Dim MaKH As String = ""

            'Lấy mã khách hàng
            'kiểm tra tồn tại của khách hàng
            Dim lenh As New SqlCommand("Select MaKH from khach_hang where cmnd='" & cbbCMND.Text & "'", KetNoi)
            Dim doc As SqlDataReader = lenh.ExecuteReader

            If doc.HasRows Then
                'có khách
                'Lấy mã Khách Hàng
                doc.Close()
                MaKH = LayMa("MaKH", "KHACH_HANG", "CMND='" & cbbCMND.Text & "'")
            Else
                doc.Close()
                'ko có khách
                'Tạo mã khách hàng
                Dim lenh4 As New SqlCommand("select max(MaKH) from KHACH_HANG", KetNoi)
                Dim doc4 As SqlDataReader = lenh4.ExecuteReader
                Do While doc4.Read
                    MaKH = "KH" & Format(vb.Right(doc4.Item(0).ToString, 3) + 1, "000")
                Loop
                doc4.Close()

                Dim lenh5 As New SqlCommand("Insert into KHACH_HANG(MaKH, TenKH, CMND, NgayCap, NoiCap, NgaySinh, GioiTinh) values('" & MaKH & "',N'" & cbbKhachHang.Text & "','" & cbbCMND.Text & "',CONVERT(DATETIME, '" & mdtNgayCap.Value & "', 102),N'" & wtmNoiCap.Text & "',CONVERT(DATETIME, '" & Now() & "', 102), 'True')", KetNoi)
                If lenh5.ExecuteNonQuery Then
                    MetroFramework.MetroMessageBox.Show(Me, "Khách hàng mới đã được thêm")
                End If
            End If
            doc.Close()

            'lấy mã Phiếu Đặt
            Dim lenh1 As New SqlCommand("select max(convert(int,MaPDat)) from PHIEU_DAT", KetNoi)
            Dim doc1 As SqlDataReader = lenh1.ExecuteReader
            Dim MaPD As String = 0
            Do While doc1.Read
                MaPD = Val(doc1.Item(0).ToString) + 1
            Loop
            doc1.Close()
            NgayDen = mdtNgayDat.Value
            NgayDi = mdtNgayTra.Value
            'thêm vào bảng phiếu đặt

            Dim lenh9 As New SqlCommand("select MaPhong from PHONG where " & wtmPhong.Text & "not in (select MaPhong from phong where MaTinhTrang='DD')", KetNoi)
            Dim doc9 As SqlDataReader = lenh9.ExecuteReader
            If doc9.HasRows Then
                doc9.Close()
                Dim sql2 As String = "insert into PHIEU_DAT(MaPDat, MaNV, MaKH, NgayDat, NgayDi, TienCoc, SoNguoi, NgayLap) values('" & MaPD & "','" & MaNV & "','" & MaKH & "',CONVERT(DATETIME, '" & NgayDen & "', 102),CONVERT(DATETIME, '" & NgayDi & "', 102)," & wtmTienCoc.Text & ",'" & wtmSoKhach.Text & "',CONVERT(DATETIME, '" & mdtLap.Value & "', 102))" ' where MaPhong not in (select MaPhong from Phieu_DAT where NgayDat between convert(datetime, '" & mdtNgayDat.Value & "',102) and convert(datetime, '" & mdtNgayTra.Value & "',102)) "
                Dim lenh2 As New SqlCommand(sql2, KetNoi)
                Try
                    If lenh2.ExecuteNonQuery Then
                        'Thêm Vào Bảng Chi Tiết
                        Dim lenh3 As New SqlCommand("insert into CT_PHIEU_DAT(MaPDat, MaPhong) values('" & MaPD & "','" & wtmPhong.Text & "')", KetNoi)
                        If lenh3.ExecuteNonQuery Then
                            MetroFramework.MetroMessageBox.Show(Me, "Khách hàng đặt phòng thành công")

                            'update Tình Trạng
                            Dim Str As String = "update PHONG set MaTinhTrang = 'DD' where MaPhong=" & MaPhongPL
                            Dim lenh6 As New SqlCommand(Str, KetNoi)
                            lenh6.ExecuteNonQuery()

                            Dim sql As String
                            sql = "SELECT     PHIEU_DAT.MaPDat, KHACH_HANG.TenKH, KHACH_HANG.CMND, KHACH_HANG.NoiCap, KHACH_HANG.NgayCap, PHIEU_DAT.NgayDat, PHIEU_DAT.NgayDi,  PHIEU_DAT.TienCoc, PHIEU_DAT.SoNguoi, NHAN_VIEN.TenNV, LOAI_PHONG.TenLoai, PHONG.MaPhong FROM         CT_PHIEU_DAT INNER JOIN PHIEU_DAT ON CT_PHIEU_DAT.MaPDAT = PHIEU_DAT.MaPDat INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON PHIEU_DAT.MaNV = NHAN_VIEN.MaNV INNER JOIN PHONG ON CT_PHIEU_DAT.MaPhong = PHONG.MaPhong INNER JOIN LOAI_PHONG ON PHONG.MaLoai = LOAI_PHONG.MaLoai  WHERE     PHIEU_DAT.MaPDat not in (select PHIEU_QL.MaPDat from PHIEU_QL )"
                            dtgDSDatPhong.DataSource = LayDuLieu(sql)
                            LoadMau()
                            XoaTT()
                        End If
                    Else

                        MsgBox("Lỗi dữ liệu")
                    End If
                Catch ex As Exception
                    MsgBox("Thiếu dữ liệu")
                End Try




            Else
                doc9.Close()
                MsgBox("Phòng đã được đặt, mời bạn chọn phòng khác")
            End If
            doc9.Close()
        End If

        DinhDangDSDP()


    End Sub

    Private Sub frmTrangChinhCon_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed


    End Sub

    Private Sub frmTrangChinhCon_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTenNV.Text = LayMa("TenNV", "NHAN_VIEN", "MaNV='" & MaNVPL & "'")

        MetroTabControl1.SelectedIndex = 0
        LoadMau()
        Dim sql As String

        sql = "SELECT     PHIEU_DAT.MaPDat, KHACH_HANG.TenKH, KHACH_HANG.CMND, KHACH_HANG.NoiCap, KHACH_HANG.NgayCap, PHIEU_DAT.NgayDat, PHIEU_DAT.NgayDi,  PHIEU_DAT.TienCoc, PHIEU_DAT.SoNguoi, NHAN_VIEN.TenNV, LOAI_PHONG.TenLoai, PHONG.MaPhong FROM         CT_PHIEU_DAT INNER JOIN PHIEU_DAT ON CT_PHIEU_DAT.MaPDAT = PHIEU_DAT.MaPDat INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON PHIEU_DAT.MaNV = NHAN_VIEN.MaNV INNER JOIN PHONG ON CT_PHIEU_DAT.MaPhong = PHONG.MaPhong INNER JOIN LOAI_PHONG ON PHONG.MaLoai = LOAI_PHONG.MaLoai  WHERE     PHIEU_DAT.MaPDat not in (select PHIEU_QL.MaPDat from PHIEU_QL )"
        dtgDSDatPhong.DataSource = LayDuLieu(sql)
        DinhDangDSDP()
        DienDL(cbbCMND, "select cmnd from KHACH_HANG")



        mbtThemDV.Enabled = False
        mbtXoaDV.Enabled = False
        mbtThanhToan.Enabled = False
        cbbGiamDV.SelectedIndex = 0
        cbbGiamPhong.SelectedIndex = 0

        dtgDSDatPhong.MultiSelect = True
        dtgDSDatPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgDSDatPhong.AllowUserToDeleteRows = True
        dtgDSDatPhong.AllowUserToAddRows = True
        dtgDSDatPhong.AllowUserToResizeColumns = True
        dtgDSDatPhong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub mttP101_Click(sender As Object, e As EventArgs) Handles mttP101.Click, mttP102.Click, mttP103.Click, mttP104.Click, mttP105.Click, mttP106.Click, mttP107.Click, mttP108.Click, mttP201.Click, mttP202.Click, mttP203.Click, mttP204.Click, mttP205.Click, mttP206.Click, mttP207.Click, mttP208.Click, mttP301.Click, mttP302.Click, mttP303.Click, mttP304.Click, mttP401.Click, mttP402.Click, mttP403.Click, mttP404.Click
        loadDuLieu(Val(vb.Right(sender.ToString, 3)))
        MaPhongPL = vb.Right(sender.ToString, 3)
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles mtlChuyenDoi.Click
        Dim Str As String = "update PHONG set MaTinhTrang='DC' where Maphong=" & Val(vb.Right(mtlChuyenDoi.Text, 3))

        If vb.Left(mtlChuyenDoi.Text, 10) = "Nhận Phòng" Then
            'Lấy mã thuê
            Dim MaQl
            Dim lenh1 As New SqlCommand("select max(convert(int,MaPhieuQL)) from PHIEU_QL", KetNoi)
            Dim doc1 As SqlDataReader = lenh1.ExecuteReader
            Do While doc1.Read
                MaQl = Val(doc1.Item(0).ToString) + 1
                MaPhieuQLPL = MaQl
            Loop
            doc1.Close()

            'Lấy Mã Khách Hàng
            Dim MaKH As String
            MaKH = LayMa("MaKH", "KHACH_HANG", "CMND='" & mtbCMNDsd.Text & "'")

            'Lấy Mã phiếu đặt
            Dim MaPDat As String
            MaPDat = LayMa("MaPDat", "Phieu_dat", "NgayDat=CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102) and MaKH='" & MaKH & "'")
            Dim sql As String = "Insert into PHIEU_QL(MaPhieuQL, MaPdat, NgayThue) values (" & MaQl & "," & MaPDat & ", convert(datetime, '" & Now() & "', 102))"
            Dim lenh As New SqlCommand(sql, KetNoi)
            lenh.ExecuteNonQuery()
            'thiết lập lại tình trạng
            DoiTrangThai(vb.Right(Me.mtlChuyenDoi.Text, 3), "SD")
            MetroFramework.MetroMessageBox.Show(Me, "Khách Hàng thuê phòng thành công")
            LoadMau()

            mbtThemDV.Enabled = True
            mbtXoaDV.Enabled = True
            mbtThanhToan.Enabled = True


            sql = "SELECT     PHIEU_DAT.MaPDat, KHACH_HANG.TenKH, KHACH_HANG.CMND, KHACH_HANG.NoiCap, KHACH_HANG.NgayCap, PHIEU_DAT.NgayDat, PHIEU_DAT.NgayDi,  PHIEU_DAT.TienCoc, PHIEU_DAT.SoNguoi, NHAN_VIEN.TenNV, LOAI_PHONG.TenLoai, PHONG.MaPhong FROM         CT_PHIEU_DAT INNER JOIN PHIEU_DAT ON CT_PHIEU_DAT.MaPDAT = PHIEU_DAT.MaPDat INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON PHIEU_DAT.MaNV = NHAN_VIEN.MaNV INNER JOIN PHONG ON CT_PHIEU_DAT.MaPhong = PHONG.MaPhong INNER JOIN LOAI_PHONG ON PHONG.MaLoai = LOAI_PHONG.MaLoai  WHERE     PHIEU_DAT.MaPDat not in (select PHIEU_QL.MaPDat from PHIEU_QL )"
            dtgDSDatPhong.DataSource = LayDuLieu(sql)


        ElseIf vb.Left(mtlChuyenDoi.Text, 18) = "Đã Sửa Xong Phòng " Then
                Dim cmd As New SqlCommand(Str, KetNoi)
                If cmd.ExecuteNonQuery > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Cập nhập thành công.")
                    DoiTrangThai(vb.Right(Me.mtlChuyenDoi.Text, 3), "DC")
                    LoadMau()
                    mtlChuyenDoi.Text = "Thuê Phòng " & vb.Right(mtlChuyenDoi.Text, 3)
                End If

                mbtThemDV.Enabled = False
                mbtXoaDV.Enabled = False
                mbtThanhToan.Enabled = False

            ElseIf vb.Left(mtlChuyenDoi.Text, 9) = "Đặt Phòng" Then
                MetroTabControl1.SelectedIndex = 1
                mdtNgayDat.Value = NgayDen
                mdtNgayTra.Value = NgayDi
                wtmPhong.Text = vb.Right(mtlChuyenDoi.Text, 3)

                Dim lenh As New SqlCommand("select TenLoai from LOAI_PHONG inner join PHONG on LOAI_PHONG.MaLoai = PHONG.MaLoai where phong.MaPhong ='" & wtmPhong.Text & "'", KetNoi)
                Dim doc As SqlDataReader = lenh.ExecuteReader
                Do While doc.Read
                    wtmLoaiPhong.Text = doc.Item(0).ToString
                Loop
                doc.Close()

            Else

            End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblHienGio.Text = Now()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles b.Click

        Dim sql, phong As String
        NgayDen = mdtNgayNhan.Value
        NgayDi = mdtNgayTraCT.Value
        sql = "Select CT_PHIEU_DAT.MaPhong FROM         CT_PHIEU_DAT INNER JOIN PHIEU_DAT ON CT_PHIEU_DAT.MaPDAT = PHIEU_DAT.MaPDat  WHERe PHIEU_DAT.NgayDat between CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102) and   CONVERT(DATETIME, '" & mdtNgayTraCT.Value & "', 102) or PHIEU_DAT.NgayDi between CONVERT(DATETIME, '" & mdtNgayNhan.Value & "', 102) and   CONVERT(DATETIME, '" & mdtNgayTraCT.Value & "', 102)"
        dtgDichVu.DataSource = LayDuLieu(sql)

        Try
            For i = 0 To 30
                phong = ("mttP" & LayDuLieu(sql).Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCMND.SelectedIndexChanged

        Dim lenh As New SqlCommand("select TenKH, NgayCap, NoiCap from KHACH_HANG where cmnd='" & cbbCMND.Text & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            cbbKhachHang.Text = doc.Item(0).ToString
            wtmNoiCap.Text = doc.Item(2).ToString
            mdtNgayCap.Value = doc.Item(1).ToString
        Loop
        doc.Close()
    End Sub


    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles mbtCapNhap.Click
        Dim str As String = "update Phieu_dat set"
        Dim lenh As New SqlCommand(str, KetNoi)
        XoaTT()
        DinhDangDSDP()
    End Sub


    Private Sub mbtXoaDV_Click(sender As Object, e As EventArgs) Handles mbtXoaDV.Click
        Dim lenh As New SqlCommand("delete from CT_PHIEU_QL where MaDV= '" & MaDV & "' and MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & vb.Right(mtlChuyenDoi.Text, 3), KetNoi)
        lenh.ExecuteNonQuery()
        MetroFramework.MetroMessageBox.Show(Me, "Xóa Dịch Vụ Thành Công")
        loadDuLieu(MaPhongPL)
    End Sub

    Private Sub dtgDichVu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDichVu.CellClick
        Dim TenDV As String
        TenDV = dtgDichVu.Rows(dtgDichVu.SelectedCells.Item(0).RowIndex).Cells(0).Value.ToString
        MaDV = LayMa("MaDV", "DICH_VU", "TenDV=N'" & TenDV & "'")
        KTSoLuong = Val(dtgDichVu.Rows(dtgDichVu.SelectedCells.Item(2).RowIndex).Cells(0).Value.ToString)

    End Sub

    Private Sub tsmThemSL_Click(sender As Object, e As EventArgs) Handles tsmThemSL.Click
        Try
            Dim lenh As New SqlCommand("update CT_PHIEU_QL set SoLuong = SoLuong + 1 where MaDV= '" & MaDV & "' and MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & vb.Right(mtlChuyenDoi.Text, 3), KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Thêm Số Lượng Thành Công")
            loadDuLieu(MaPhongPL)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Mời bạn thêm dịch vụ trước khi thêm số lượng")
        End Try

    End Sub

    Private Sub tsmGiamSL_Click(sender As Object, e As EventArgs) Handles tsmGiamSL.Click
        If KTSoLuong = 1 Then
            Dim lenh As New SqlCommand("delete from CT_PHIEU_QL where MaDV= '" & MaDV & "' and MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & vb.Right(mtlChuyenDoi.Text, 3), KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Đã Xóa Dịch Vụ")
        Else
            Dim lenh As New SqlCommand("update CT_PHIEU_QL set SoLuong = SoLuong - 1 where MaDV= '" & MaDV & "' and MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & vb.Right(mtlChuyenDoi.Text, 3), KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Giảm Số Lượng Thành Công")
        End If
        loadDuLieu(MaPhongPL)
    End Sub

    Private Sub tsmDoiSL_Click(sender As Object, e As EventArgs) Handles tsmDoiSL.Click
        If InputBox("Nhập Số lượng bạn muốn thêm", "Thêm Số Lương", "", 500, 300) Then
            MetroFramework.MetroMessageBox.Show(Me, "Hãy dùng chức năng cơ bản")
        End If

    End Sub


    Private Sub cbbGiamPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbGiamPhong.SelectedIndexChanged

        TongTienGio -= (cbbGiamPhong.Text * TienThue) / 100
        GiamGio = (cbbGiamPhong.Text * TienThue) / 100
        mtbGiaPhong.Text = Format(Val(GiamGio), "#,##0 VNĐ")



    End Sub

    Private Sub cbbGiamDV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbGiamDV.SelectedIndexChanged
        TongTienDV -= (cbbGiamDV.Text * TienDV) / 100
        GiamDV = (cbbGiamDV.Text * TienDV) / 100
        mtbGiaDichVu.Text = Format(Val(GiamDV), "#,##0 VNĐ")
    End Sub

    Private Sub mttP201_Click(sender As Object, e As EventArgs) Handles mttP201.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles mbtSuaChua.Click
        DoiTrangThai(vb.Right(mtlChuyenDoi.Text, 3), "TB")
        LoadMau()
    End Sub

    Private Sub mbtDoiPhong_Click(sender As Object, e As EventArgs) Handles mbtDoiPhong.Click

    End Sub

    Private Sub mbtXoa_Click(sender As Object, e As EventArgs) Handles mbtXoa.Click
        Try
            Dim lenh As New SqlCommand("delete from CT_PHIEU_DAT where MaPDat = " & MaPDat, KetNoi)
            Dim lenh1 As New SqlCommand("delete from PHIEU_DAT where MaPDat = " & MaPDat, KetNoi)
            If lenh.ExecuteNonQuery() And lenh1.ExecuteNonQuery Then
                MetroFramework.MetroMessageBox.Show(Me, "Xóa Thông Tin Đặt Phòng Thành Công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim Sql As String = "SELECT     PHIEU_DAT.MaPDat, KHACH_HANG.TenKH, KHACH_HANG.CMND, KHACH_HANG.NoiCap, KHACH_HANG.NgayCap, PHIEU_DAT.NgayDat, PHIEU_DAT.NgayDi,  PHIEU_DAT.TienCoc, PHIEU_DAT.SoNguoi, NHAN_VIEN.TenNV, LOAI_PHONG.TenLoai, PHONG.MaPhong FROM         CT_PHIEU_DAT INNER JOIN PHIEU_DAT ON CT_PHIEU_DAT.MaPDAT = PHIEU_DAT.MaPDat INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON PHIEU_DAT.MaNV = NHAN_VIEN.MaNV INNER JOIN PHONG ON CT_PHIEU_DAT.MaPhong = PHONG.MaPhong INNER JOIN LOAI_PHONG ON PHONG.MaLoai = LOAI_PHONG.MaLoai  WHERE     PHIEU_DAT.MaPDat not in (select PHIEU_QL.MaPDat from PHIEU_QL )"
                dtgDSDatPhong.DataSource = LayDuLieu(Sql)
                LoadMau()
            End If
            DoiTrangThai(wtmPhong.Text, "DC")
            LoadMau()
            XoaDl()
            XoaTT()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Chọn phiếu đặt phòng trước khi xóa", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DinhDangDSDP()
    End Sub

    Private Sub dtgDSDatPhong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDSDatPhong.CellClick
        Try
            MaPDat = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(0).Value.ToString()
            mdtLap.Value = Now()
            wtmLoaiPhong.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(10).Value.ToString()
            wtmPhong.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(11).Value.ToString
            mdtNgayDat.Value = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(5).Value.ToString
            mdtNgayTra.Value = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(6).Value.ToString
            txtTenNV.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(9).Value.ToString
            wtmSoKhach.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(8).Value.ToString
            cbbKhachHang.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(1).Value.ToString
            cbbCMND.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(2).Value.ToString
            mdtNgayCap.Value = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(4).Value.ToString
            wtmNoiCap.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(3).Value.ToString
            wtmTienCoc.Text = dtgDSDatPhong.Rows(dtgDSDatPhong.SelectedCells.Item(0).RowIndex).Cells(7).Value.ToString

        Catch ex As Exception
            XoaTT()
        End Try

    End Sub


    Private Sub dtgDichVu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDichVu.CellContentClick

    End Sub
End Class