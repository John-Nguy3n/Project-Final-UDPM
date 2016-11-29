Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime

Public Class frmCapNhatKH


    Private Sub frmCapNhatKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DienDL(cbbMaKH, "Select MaKH from KHACH_HANG")
    End Sub

    Private Sub cbbMaKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaKH.SelectedIndexChanged
        Dim lenh As New SqlCommand("Select TenKH, CMND, GioiTinh, Email, NoiCap, NgayCap, NgaySinh, GhiChu from KHACH_HANG where MaKH='" & cbbMaKH.Text & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            mtbTenKH.Text = doc.Item(0).ToString
            mtbCMND.Text = doc.Item(1).ToString
            If IsDBNull(doc.Item(2)) Then
                cbbGioiTinh.Text = "Nam"
            ElseIf doc.Item(2) = True Then
                cbbGioiTinh.Text = "Nam"
            Else
                cbbGioiTinh.Text = "Nữ"
            End If
            mtbEmail.Text = doc.Item(3).ToString
            mtbNoiCap.Text = doc.Item(4).ToString
            mdtNgayCap.Value = doc.Item(5)
            Try
                mdtNgaySinh.Value = doc.Item(6)
            Catch ex As Exception
                mdtNgaySinh.Value = Now()
            End Try

            txtGhiChu.Text = doc.Item(7).ToString
        Loop
        doc.Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim GioiTinh As Boolean
        Dim ThongBaoLoi As String = ""

        If mtbTenKH.Text = "" Then
            ThongBaoLoi &= "Xin Nhập Tên Khách Hàng, "
        End If

        If cbbGioiTinh.Text = "Nam" Then
            GioiTinh = True
        ElseIf cbbGioiTinh.Text = "Nữ" Then
            GioiTinh = False
        Else
            ThongBaoLoi &= "Xin Chọn Giới Tính, "
        End If

        If vb.Len(mtbCMND.Text) = 9 Then
        Else
            ThongBaoLoi &= "Sai chuẩn CMND, "
        End If

        If mtbNoiCap.Text = "" Then
            ThongBaoLoi &= "Xin Nhập Tên Khách Hàng, "
        End If



        If ThongBaoLoi = "" Then
            Dim str As String = "update KHACH_HANG set TenKH=N'" & mtbTenKH.Text & "', CMND=" & mtbCMND.Text & ",GioiTinh='" & GioiTinh & "', Email='" & mtbEmail.Text & "', NoiCap=N'" & mtbNoiCap.Text & "', NgayCap=CONVERT(DATETIME, '" & mdtNgayCap.Value & "', 102), NgaySinh=CONVERT(DATETIME, '" & mdtNgaySinh.Value & "', 102), GhiChu=N'" & txtGhiChu.Text & "' where MaKH = '" & cbbMaKH.Text & "'"
            Dim lenh As New SqlCommand(str, KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Cập nhật thông tin khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MetroFramework.MetroMessageBox.Show(Me, ThongBaoLoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub
End Class