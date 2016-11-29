Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime

Public Class frmQLNhanVien
    Public Function kiemtraemail(EmailAddress As String) As Boolean
        kiemtraemail = EmailAddress Like "*@[A-Z,a-z,0-9]*.*"
    End Function
    Public Sub Dinhdang()

        dtgNhanVien.MultiSelect = True 'Cho phép việc chọn nhiều dòng
        dtgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Cho phép trõ chuột bất kì thì sẽ chọn hết 1 dòng
        dtgNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) 'Việc tự chỉnh sửa độ dài của từng dòng
        'Gán tiêu đề cột cho mỗi cột dữ liệu
        dtgNhanVien.Columns(0).HeaderText = "Mã nhân viên"
        dtgNhanVien.Columns(1).HeaderText = "Tên nhân viên"
        dtgNhanVien.Columns(2).HeaderText = "Ngày sinh"
        dtgNhanVien.Columns(3).HeaderText = "CMND"
        dtgNhanVien.Columns(4).HeaderText = "Địa chỉ"
        dtgNhanVien.Columns(5).HeaderText = "Giới tính"
        dtgNhanVien.Columns(6).HeaderText = "Số ĐT"
        dtgNhanVien.Columns(7).HeaderText = "Email"
        dtgNhanVien.Columns(8).HeaderText = "Chức vụ"
        dtgNhanVien.Columns(9).HeaderText = "Ngày bắt đầu"
        dtgNhanVien.Columns(10).HeaderText = "Lương"
        dtgNhanVien.Columns(11).HeaderText = "Ghi chú"
        dtgNhanVien.Columns(12).HeaderText = "Tài khoản"
        dtgNhanVien.Columns(13).HeaderText = "Mật khẩu"



    End Sub
    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbTimkiem.TextChanged
        Dim Timkiem As String
        Dim i As Integer
        Dim kt As String
        If Me.rdoNhanVien.Checked = True Then 'Khi tìm kiếm theo loại dịch vụ
            Timkiem = "select * from NHAN_VIEN where TenNV like N'" & txbTimkiem.Text & "%'"
            dtgNhanVien.DataSource = LayDuLieu(Timkiem)
        Else 'Khi tìm kiếm theo Tên dịch vụ
            Me.rdoCMND.Checked = True  'Khi tìm kiếm theo loại dịch vụ
            Timkiem = "select * from NHAN_VIEN where CMND like N'" & txbTimkiem.Text & "%'"
            dtgNhanVien.DataSource = LayDuLieu(Timkiem)
        End If
    End Sub

    Private Sub mbtnXoa_Click(sender As Object, e As EventArgs) Handles mbtnXoa.Click
        Me.Close()

    End Sub

    Private Sub frmQLNhanVien_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtgNhanVien.DataSource = LayDuLieu("select * from NHAN_VIEN")
        Dinhdang()
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim GioiTinh As Boolean
        Dim ThongBaoLoi As String = ""
        Dim MaNV As String = ""
        Dim lenh1 As New SqlCommand("Select max(MaNV) from NHAN_VIEN", KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Do While doc1.Read
            MaNV = "NV" & Format(Val(vb.Right(doc1.Item(0).ToString, 3)) + 1, "000")

        Loop
        doc1.Close()
        If mtbTenNV.Text = "" Then
            ThongBaoLoi &= "Xin Nhập Tên Khách Hàng, "
        End If

        If mcbGioiTinh.Text = "Nam" Then
            GioiTinh = True
        ElseIf mcbGioiTinh.Text = "Nữ" Then
            GioiTinh = False
        Else
            ThongBaoLoi &= "Xin Chọn Giới Tính, "
        End If
        If (kiemtraemail(mtbEmail.Text) = False) Then ' Nếu địa chỉ email không đúng
            Beep() ' Kêu 1 tiếng bíp cho người dùng sợ
            ThongBaoLoi &= "Email không hợp lệ, "
        End If

        If vb.Len(mtbCMND.Text) = 9 Then
            Else
            ThongBaoLoi &= "Sai chuẩn CMND "
        End If

            If ThongBaoLoi = "" Then
            Dim str As String = "insert into NHAN_VIEN(MaNV, TenNV, NgaySinh, CMND, DiaChi, GioiTinh, SDT, Email, ChucCu, NgayBatDau, Luong, GhiChu, TaiKhoan, MatKhau) values('" & MaNV & "', N'" & mtbTenNV.Text & "', CONVERT(DATETIME, '" & mdtNgaySinh.Value & "', 102), " & mtbCMND.Text & ", N'" & mtbDiaChi.Text & "', '" & GioiTinh & "', " & mtbSDT.Text & ", '" & mtbEmail.Text & "', N'" & mcbChucVu.Text & "', CONVERT(DATETIME, '" & mdtNgayLam.Value & "', 102), " & mtbLuong.Text & ", N'" & txtGhiChu.Text & "', '" & MetroTextBox1.Text & "', '" & MetroTextBox2.Text & "' )"
            Dim lenh As New SqlCommand(str, KetNoi)
                lenh.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Thêm mới nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                dtgNhanVien.DataSource = LayDuLieu("select * from NHAN_VIEN")
            Else
            MetroFramework.MetroMessageBox.Show(Me, (ThongBaoLoi), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtbCMND.Text = ""
            mtbDiaChi.Text = ""
            mtbEmail.Text = ""
            mtbLuong.Text = ""
            mtbMatKhau.Text = ""
            mtbTenNV.Text = ""
            mtbSDT.Text = ""
            mdtNgaySinh.MaxDate = Now
            txtGhiChu.Text = ""

        End If



    End Sub

    Private Sub mcbChucVu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbChucVu.SelectedIndexChanged
        If mcbChucVu.Text = "Thu Ngân" Then
            MetroTextBox2.Enabled = True
            MetroTextBox1.Enabled = True
        Else
            MetroTextBox2.Enabled = False
            MetroTextBox1.Enabled = False
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        frmCapNhatNV.Show()
    End Sub
End Class