Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class frmThemMoiDV
    Private Sub frmThemMoiDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DienDL(mcbLoaiDV, "Select TenLoaiDV from LOAI_DV")
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label8.Text = Now()
    End Sub

    Private Sub btnThemMoi_Click(sender As Object, e As EventArgs) Handles btnThemMoi.Click
        Dim MaLoaiDV As String = LayMa("MaLoaiDV", "Loai_DV", "TenLoaiDV=N'" & mcbLoaiDV.Text & "'")

        Dim lenh As New SqlCommand("insert into DICH_VU(MaDV, TenDV, DVT, MaloaiDV) values('" & txtMaDV.Text & "', N'" & txtTenDV.Text & "', N'" & txtDonVi.Text & "', '" & MaLoaiDV & "' )", KetNoi)

        Dim lenh1 As New SqlCommand("insert into Gia_DV (MaDV, Ngay, GiaDV) values ('" & txtMaDV.Text & "', convert(datetime, '" & Label8.Text & "', 102), " & Val(txtGiaDV.Text) & ")", KetNoi)
        If lenh.ExecuteNonQuery() And lenh1.ExecuteNonQuery() Then
            MetroFramework.MetroMessageBox.Show(Me, "Bạn đã thêm dịch vụ thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGiaDV.Text = ""
            txtDonVi.Text = ""
            txtMaDV.Text = ""
            txtTenDV.Text = ""
            mcbLoaiDV.Text = ""
        End If


    End Sub

    Private Sub mcbLoaiCu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbLoaiDV.SelectedIndexChanged


        Dim MaLoaiDV As String = LayMa("MaLoaiDV", "Loai_DV", "TenLoaiDV=N'" & mcbLoaiDV.Text & "'")
        Dim lenh As New SqlCommand("select Max(MaDV) from DICH_VU where MaLoaiDV ='" & MaLoaiDV & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Dim MaDV As String
        Do While doc.Read
            MaDV = MaLoaiDV & Format(Val(vb.Right(doc.Item(0).ToString, 3) + 1), "000")
        Loop
        doc.Close()
        txtMaDV.Text = MaDV
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class