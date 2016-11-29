Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmCapNhatNV
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub

    Private Sub frmCapNhatNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DienDL(mcbMaNV, "Select MaNV from NHAN_VIEN")

    End Sub

    Private Sub mcbMaNV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbMaNV.SelectedIndexChanged
        Dim lenh As New SqlCommand("Select TenNV, NgaySinh, CMND, DiaChi, GioiTinh, SDT, Email, GhiChu, TaiKhoan, MatKhau, Chuccu, NgayBatDau, Luong from NHAN_VIEN where MaNV='" & mcbMaNV.Text & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            mtbTenNV.Text = doc.Item(0).ToString
            mdtNgaySinh.Value = doc.Item(1)
            mtbCMND.Text = doc.Item(2).ToString
            mtbDiaChi.Text = doc.Item(3).ToString
            If IsDBNull(doc.Item(4)) Then
                mcbGioiTinh.Text = "Nam"
            ElseIf doc.Item(4) = True Then
                mcbGioiTinh.Text = "Nam"
            Else
                mcbGioiTinh.Text = "Nữ"
            End If
            mtbSDT.Text = doc.Item(5).ToString
            mtbEmail.Text = doc.Item(6).ToString
            txtGhiChu.Text = doc.Item(7).ToString
            mtbTaiKhoan.Text = doc.Item(8).ToString
            mtbMatKhau.Text = doc.Item(9).ToString
            mcbChucVu.Text = (doc.Item(10).ToString)
            mdtNgayLam.Value = doc.Item(11)
            mtbLuong.Text = doc.Item(12).ToString
        Loop
        doc.close()

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim GioiTinh As Boolean
        Dim ThongBaoLoi As String = ""

        If mtbTenNV.Text = "" Then
            ThongBaoLoi &= "Xin Nhập Tên Nhân Viên, "
        End If

        If mcbGioiTinh.Text = "Nam" Then
            GioiTinh = True
        ElseIf mcbGioiTinh.Text = "Nữ" Then
            GioiTinh = False
        Else
            ThongBaoLoi &= "Xin Chọn Giới Tính, "
        End If

        If vb.Len(mtbCMND.Text) = 9 Then
        Else
            ThongBaoLoi &= "Sai chuẩn CMND, "
        End If




        If ThongBaoLoi = "" Then
            Dim str As String = "update NHAN_VIEN set TenNV=N'" & mtbTenNV.Text & "', NgaySinh=CONVERT(DATETIME, '" & mdtNgaySinh.Value & "', 102), CMND=" & mtbCMND.Text & ", DiaChi=N'" & mtbDiaChi.Text & "', GioiTinh='" & GioiTinh & "', SDT='" & mtbSDT.Text & "', Email='" & mtbEmail.Text & "', ChucCu=N'" & mcbChucVu.Text & "', NgayBatDau=CONVERT(DATETIME, '" & mdtNgayLam.Value & "', 102), Luong=" & mtbLuong.Text & ", GhiChu=N'" & txtGhiChu.Text & "', TaiKhoan='" & mtbTaiKhoan.Text & "', MatKhau='" & mtbMatKhau.Text & "'  where MaNV = '" & mcbMaNV.Text & "'"
            Dim lenh As New SqlCommand(str, KetNoi)
            lenh.ExecuteNonQuery()
            MsgBox("Cập Nhập Thông Tin Nhân Viên Thành Công")
        Else
            MsgBox(ThongBaoLoi)
        End If
    End Sub

    Private Sub mcbChucVu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbChucVu.SelectedIndexChanged
        If mcbChucVu.Text = "Thu Ngân" Then
            mtbMatKhau.Enabled = True
            mtbTaiKhoan.Enabled = True
        Else
            mtbMatKhau.Enabled = False
            mtbTaiKhoan.Enabled = False
        End If
    End Sub
End Class