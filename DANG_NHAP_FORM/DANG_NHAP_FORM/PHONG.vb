Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime

Public Class frmPhong
#Region "biến" 'Khai báo biến lấy dữ liệu 
    Dim str As String = "SELECT        PHONG.MaLoai, LOAI_PHONG.TenLoai, PHONG.MaPhong, TINH_TRANG.TenTinhTrang, PHIEU_DAT.NgayLap, PHIEU_DAT.NgayDat, PHIEU_DAT.NgayDi, CT_PHIEU_DAT.MaPDAT, NHAN_VIEN.TenNV,  KHACH_HANG.TenKH, PHIEU_DAT.SoNguoi FROM            PHIEU_DAT INNER JOIN CT_PHIEU_DAT ON PHIEU_DAT.MaPDat = CT_PHIEU_DAT.MaPDAT INNER JOIN KHACH_HANG ON PHIEU_DAT.MaKH = KHACH_HANG.MaKH INNER JOIN NHAN_VIEN ON PHIEU_DAT.MaNV = NHAN_VIEN.MaNV RIGHT OUTER JOIN LOAI_PHONG INNER JOIN PHONG ON LOAI_PHONG.MaLoai = PHONG.MaLoai INNER JOIN TINH_TRANG ON PHONG.MaTinhTrang = TINH_TRANG.MaTinhTrang ON CT_PHIEU_DAT.MaPhong = PHONG.MaPhong"
#End Region


    'Định dạng kích thước, và gán text header cho các cột dữ liệu thuộc bảng thông tin các phòng
    Public Sub Dinhdang()
        dtgrvThongTinP.MultiSelect = True 'Cho phép việc chọn nhiều dòng
        dtgrvThongTinP.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Cho phép trõ chuột bất kì thì sẽ chọn hết 1 dòng
        dtgrvThongTinP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) 'Việc tự chỉnh sửa độ dài của từng dòng
        'Tùy chỉnh độ dài của mỗi cột
        dtgrvThongTinP.Columns(0).Width = "80"
        dtgrvThongTinP.Columns(1).Width = "130"
        dtgrvThongTinP.Columns(2).Width = "60"
        dtgrvThongTinP.Columns(3).Width = "100"
        dtgrvThongTinP.Columns(4).Width = "130"
        dtgrvThongTinP.Columns(5).Width = "130"
        dtgrvThongTinP.Columns(6).Width = "130"
        dtgrvThongTinP.Columns(7).Width = "80"
        dtgrvThongTinP.Columns(8).Width = "130"
        dtgrvThongTinP.Columns(9).Width = "145"
        dtgrvThongTinP.Columns(10).Width = "50"
        'Gán tiêu đề cột cho mỗi cột dữ liệu
        dtgrvThongTinP.Columns(0).HeaderText = "Mã loại phòng"
        dtgrvThongTinP.Columns(1).HeaderText = "Tên loại phòng"
        dtgrvThongTinP.Columns(2).HeaderText = "Số phòng"
        dtgrvThongTinP.Columns(3).HeaderText = "Tình trạng"
        dtgrvThongTinP.Columns(4).HeaderText = "Ngày lập "
        dtgrvThongTinP.Columns(5).HeaderText = "Ngày đặt"
        dtgrvThongTinP.Columns(6).HeaderText = "Ngày đi"
        dtgrvThongTinP.Columns(7).HeaderText = "Mã phiếu đặt"
        dtgrvThongTinP.Columns(8).HeaderText = "Nhân viên"
        dtgrvThongTinP.Columns(9).HeaderText = "Khách hàng"
        dtgrvThongTinP.Columns(10).HeaderText = "Số khách"
    End Sub
    'Định dạng kích thước, và gán text header cho các cột dữ liệu thuộc bảng giá phòng
    Public Sub Dinhdang1()

        dtgLoaiPhong.MultiSelect = True 'Cho phép việc chọn nhiều dòng
        dtgLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Cho phép trõ chuột bất kì thì sẽ chọn hết 1 dòng
        dtgLoaiPhong.AllowUserToAddRows = True
        dtgLoaiPhong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) 'Việc tự chỉnh sửa độ dài của từng dòng
        dtgLoaiPhong.Columns(0).Width = "180"
        dtgLoaiPhong.Columns(1).Width = "375"
        dtgLoaiPhong.Columns(2).Width = "140"
    End Sub
    Public Sub Dinhdang2()
        DataGridView1.MultiSelect = True 'Cho phép việc chọn nhiều dòng
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Cho phép trõ chuột bất kì thì sẽ chọn hết 1 dòng
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) 'Việc tự chỉnh sửa độ dài của từng dòng
        'Tùy chỉnh độ dài của mỗi cột
        DataGridView1.Columns(0).Width = "205"
        DataGridView1.Columns(1).Width = "130"
        DataGridView1.Columns(2).Width = "155"
        DataGridView1.Columns(3).Width = "155"
        'Gán tiêu đề cột cho mỗi cột dữ liệu
        DataGridView1.Columns(0).HeaderText = "Tên loại phòng"
        DataGridView1.Columns(1).HeaderText = "Thời gian"
        DataGridView1.Columns(2).HeaderText = "Giá theo giờ"
        DataGridView1.Columns(3).HeaderText = "Giá theo ngày"

    End Sub
    Private Sub mbtnDoiLoaiPhong_Click_1(sender As Object, e As EventArgs) Handles mbtnDoiLoaiPhong.Click
        frmDoiLoaiPhong.Show()
    End Sub

    Private Sub frmPhong_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtgrvThongTinP.DataSource = LayDuLieu(str) 'Gọi dữ liệu load lên trên bảng trong sự kiện load form
        Dinhdang() 'Gọi lại các thuộc tính đã khai báo ở trên
        dtgLoaiPhong.DataSource = LayDuLieu("select MaLoai as 'Mã Loai', TenLoai as 'Tên Loại',SoGiuong as 'Số giường' from LOAI_PHONG") 'Đưa các dữ liệu cần thiết từ bảng LOAI_PHONG lên bảng hiển thị
        Dinhdang1()
        DienDL(cbbLoaiPhong, "select TenLoai from LOAI_PHONG")
        DienDL(cbbTinhTrangP, "select TenTinhTrang from TINH_TRANG")
        DataGridView1.DataSource = LayDuLieu("SELECT LOAI_PHONG.TenLoai, GIA_PHONG.Ngay, GIA_PHONG.GiaGio, GIA_PHONG.GiaNgay FROM  GIA_PHONG INNER JOIN LOAI_PHONG ON GIA_PHONG.MaLoai = LOAI_PHONG.MaLoai") 'Load lại dữ liệu lên bảng với các điều kiện chọn
        DienDL(MetroComboBox3, "select TenLoai from LOAI_PHONG")
        KetNoi.Close()
        KetNoi.Open()
        Dinhdang2()
    End Sub


    'Cậu lệnh kiểm tra nếu được chọn thì sẽ kiểm tra các kí tự có trong textbox mà người dùng nhập vào
    Private Sub cbbLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiPhong.SelectedIndexChanged
        If rdoLoaiPhong.Checked = True Then
            dtgrvThongTinP.DataSource = LayDuLieu(str & " where TenLoai=N'" & cbbLoaiPhong.Text & "'")
        Else
        End If
    End Sub
    'Cậu lệnh kiểm tra nếu được chọn thì sẽ kiểm tra các kí tự có trong textbox mà người dùng nhập vào
    Private Sub cbbTinhTrangP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTinhTrangP.SelectedIndexChanged
        If rdoTinhTrangP.Checked = True Then
            dtgrvThongTinP.DataSource = LayDuLieu(str & " where TenTinhTrang=N'" & cbbTinhTrangP.Text & "'")
        Else
        End If
    End Sub
    'Cậu lệnh kiểm tra nếu được chọn thì sẽ kiểm tra thời gian dặt từ phòng trong khoản thời gian xác định
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim str As String = "select t1.MaLoai, t1.GiaNgay, t1.GiaGio, t1.Ngay from GIA_PHONG as t1 inner join (select MaLoai, Max(Ngay) as NgayThue from GIA_PHONG group by MaLoai ) as t2 on t1.MaLoai=t2.MaLoai and t1.ngay=t2.NgayThue"
        Try
            If txtGiaGio.Text = "" And txtGiaNgay.Text = "" Then
                MsgBox("Mời Bạn nhập giá ít nhất 1 loại")
            ElseIf txtGiaNgay.Text = "" Then
                'Nhập giá giờ
                Dim GiaNgay As Double
                GiaNgay = Val(LayDuLieu(str & " where t1.MaLoai='" & MetroTextBox1.Text & "'").Rows(0).Item(1).ToString)

                Dim lenh As New SqlCommand("insert into GIA_PHONG(MaLoai, Ngay, GiaGio, GiaNgay) values ('" & MetroTextBox1.Text & "', CONVERT(DATETIME, '" & MetroDateTime4.Value & "', 102), " & Val(txtGiaGio.Text) & ", " & GiaNgay & " )", KetNoi)
                lenh.ExecuteNonQuery()
                MsgBox("Thêm Thành công")

            ElseIf txtGiaGio.Text = "" Then
                'Nhập giá Ngày
                Dim GiaGio As Double
                GiaGio = Val(LayDuLieu(str & " where t1.MaLoai='" & MetroTextBox1.Text & "'").Rows(0).Item(2).ToString)

                Dim lenh As New SqlCommand("insert into GIA_PHONG(MaLoai, Ngay, GiaNgay, GiaGio) values ('" & MetroTextBox1.Text & "', CONVERT(DATETIME, '" & MetroDateTime4.Value & "', 102), " & Val(txtGiaNgay.Text) & ", " & GiaGio & " )", KetNoi)
                lenh.ExecuteNonQuery()
                MsgBox("Thêm Thành công")
            Else
                Dim lenh As New SqlCommand("insert into GIA_PHONG(MaLoai, Ngay, GiaNgay, GiaGio) values ('" & MetroTextBox1.Text & "', CONVERT(DATETIME, '" & MetroDateTime4.Value & "', 102), " & Val(txtGiaNgay.Text) & ", " & Val(txtGiaGio.Text) & " )", KetNoi)
                lenh.ExecuteNonQuery()
                MsgBox("Thêm Thành công")
            End If
        Catch ex As Exception
            MsgBox("Xin chọn 1 ngày khác")
        End Try


        DataGridView1.DataSource = LayDuLieu("SELECT        LOAI_PHONG.TenLoai, GIA_PHONG.Ngay, GIA_PHONG.GiaGio, GIA_PHONG.GiaNgay FROM            GIA_PHONG INNER JOIN LOAI_PHONG ON GIA_PHONG.MaLoai = LOAI_PHONG.MaLoai")



    End Sub

    Private Sub MetroComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox3.SelectedIndexChanged
        MetroTextBox1.Text = LayMa("MaLoai", "LOAI_PHONG", "TenLoai =N'" & MetroComboBox3.Text & "'")
    End Sub

    Private Sub mbtnLuu_Click(sender As Object, e As EventArgs) Handles mbtnLuu.Click
        Try
            If MetroTextBox4.Text = "" Or MetroTextBox5.Text = "" Or MetroTextBox7.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Mời bạn nhập đủ dữ liêu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim lenh As New SqlCommand("Insert into LOAI_PHONG(MaLoai, TenLoai, SoGiuong) values('" & MetroTextBox4.Text & "', N'" & MetroTextBox5.Text & "', " & Val(MetroTextBox7.Text) & ")", KetNoi)
                lenh.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Đã thêm mới dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                dtgLoaiPhong.DataSource = LayDuLieu("select MaLoai as 'Mã Loai', TenLoai as 'Tên Loại',SoGiuong as 'Số giường' from LOAI_PHONG")
            End If
        Catch ex As Exception
            MsgBox("Lỗi Dữ Liệu")
        End Try


    End Sub

    Private Sub dtgrvThongTinP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtKH_TextChanged(sender As Object, e As EventArgs) Handles txtKH.TextChanged
        If rdoKH.Checked = True Then
            dtgrvThongTinP.DataSource = LayDuLieu(str & " where TenKH like N'" & txtKH.Text & "%'")
        Else
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        dtgrvThongTinP.DataSource = LayDuLieu(str)
    End Sub


    Private Sub dtNgayODen_TextChanged(sender As Object, e As EventArgs) Handles dtNgayODen.TextChanged
        If rdoNgatDat.Checked = True Then
            dtgrvThongTinP.DataSource = LayDuLieu(str & " where NgayDat between CONVERT(DATETIME, '" & dtNgayOTu.Value & "', 102) and CONVERT(DATETIME, '" & dtNgayODen.Value & "', 102) ")
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        txtGiaGio.Text = ""
        txtGiaNgay.Text = ""
        MetroComboBox3.Text = ""
        MetroTextBox1.Text = ""
    End Sub
End Class