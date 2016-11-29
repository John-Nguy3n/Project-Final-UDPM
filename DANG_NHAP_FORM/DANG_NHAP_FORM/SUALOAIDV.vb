Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmSuaLoaiDV
    Private Sub frmSuaLoaiDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaLoaiDV.Text = MaLoaiDVPL
        txtTenLoaiDV.Text = LayDuLieu("select TenLoaiDV from Loai_DV where MaLoaiDV='" & txtMaLoaiDV.Text & "'").Rows(0).Item(0).ToString
    End Sub

    Private Sub mbtXoaDV_Click(sender As Object, e As EventArgs) Handles mbtXoaDV.Click
        Me.Close()
    End Sub

    Private Sub mbtThemDV_Click(sender As Object, e As EventArgs) Handles mbtThemDV.Click
        If txtTenLoaiDV.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Tên Loại dịch vụ không được để rỗng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenh As New SqlCommand("update Loai_DV set TenLoaiDv=N'" & txtTenLoaiDV.Text & "' where MaLoaiDV ='" & txtMaLoaiDV.Text & "'")
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Đổi tên dịch vụ thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class