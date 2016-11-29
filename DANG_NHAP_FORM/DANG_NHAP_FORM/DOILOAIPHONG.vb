Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmDoiLoaiPhong

    Private Sub frmDoiLoaiPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DienDL(mcbTenPhong, "Select MaPhong from PHONG")
        DienDL(mcbLoaiCu, "select TenLoai From LOAI_PHONG")
        DienDL(mcbLoaiMoi, "select TenLoai From LOAI_PHONG")
    End Sub

    Private Sub mcbTenPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbTenPhong.SelectedIndexChanged
        Dim lenh As New SqlCommand("Select TenLoai  from loai_phong inner join PHONG on PHONG.Maloai = LOAI_PHONG.MaLoai where PHONG.MaPhong= " & mcbTenPhong.Text, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            mcbLoaiCu.Text = doc.Item(0).ToString
        Loop
        doc.Close()
    End Sub

    Private Sub mbtnDoiLoaiPhong_Click(sender As Object, e As EventArgs) Handles mbtnDoiLoaiPhong.Click
        Dim MaLoai As String
        MaLoai = LayMa("MaLoai", "Loai_phong", "TenLoai=N'" & mcbLoaiMoi.Text & "'")
        Dim lenh As New SqlCommand("update Phong set MaLoai='" & MaLoai & "' where MaPhong=" & mcbTenPhong.Text, KetNoi)
        lenh.ExecuteNonQuery()
        MsgBox("Đổi Loại Phòng Thành Công")

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class