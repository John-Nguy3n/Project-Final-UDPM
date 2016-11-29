Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmThanhToan
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub

    Private Sub frmThanhToan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TienCoc As Double
        TienCoc = Val(LayMa("TienCoc", "PHIEU_DAT", "MaPDat = (select MaPDat from PHIEU_QL where MaPhieuQL = " & MaPhieuQLPL & ")"))
        lblTienCoc.Text = Format(TienCoc, "#,##0 VNĐ")

        mttP.Text = "Phòng " & vb.Format(DANG_NHAP_FORM.frmTrangChinhCon.mtlChuyenDoi.Text, 3)
        lblTienP.Text = Format(Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienGio), "#,##0 VNĐ")
        lblTienDV.Text = Format(Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienDV), "#,##0 VNĐ")
        lblTongTien.Text = Format(Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienGio) + Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienDV - TienCoc), "#,##0 VNĐ")
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim str As String
        Dim MaHD, MaKH As String
        str = "select max(convert(int,MaHD)) from HOA_DON"
        Dim lenh As New SqlCommand(str, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            MaHD = Val(doc.Item(0).ToString) + 1
        Loop
        doc.Close()


        MaKH = LayMa("MaKH", "KHACH_HANG", "TenKH=N'" & frmTrangChinhCon.mtbTenKHsd.Text & "'")
        '
        str = "insert into Hoa_Don (MaHD, MaKH, MaNV, NgayLap, MaPhieuQL, TongTien, GhiChu, GiamGia) values('" & MaHD & "', '" & MaKH & "', '" & MaNVPL & "',  CONVERT(DATETIME, '" & Now() & "', 102), " & MaPhieuQLPL & ", " & Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienGio) + Val(DANG_NHAP_FORM.frmTrangChinhCon.TongTienDV) & ", '', " & Val(DANG_NHAP_FORM.frmTrangChinhCon.GiamGio) + Val(DANG_NHAP_FORM.frmTrangChinhCon.GiamDV) & ")"
        Dim lenh1 As New SqlCommand(str, KetNoi)
        lenh1.ExecuteNonQuery()


        str = "update PHONG set MaTinhTrang = 'DC' where MaPhong=" & MaPhongPL
        Dim lenh2 As New SqlCommand(str, KetNoi)
        lenh2.ExecuteNonQuery()
        MetroFramework.MetroMessageBox.Show(Me, "Đã thanh toán thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        frmTrangChinhCon.LoadMau()
        Me.Close()
    End Sub
End Class