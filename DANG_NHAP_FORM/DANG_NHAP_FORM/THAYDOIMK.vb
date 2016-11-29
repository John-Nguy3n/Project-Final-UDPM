Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Imports System.Drawing.Imaging
Public Class frmDoiMK
    Dim MKCu, MKMoi As String
    Dim DK1, DK2, DK3 As Boolean
    Dim duongdan As String = My.Application.Info.DirectoryPath.ToString
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub


    Private Sub txtMKCu_Leave(sender As Object, e As EventArgs) Handles txtMKCu.Leave
        MKCu = LayDuLieu("select MatKhau from NHAN_VIEN where MaNV='" & MaNVPL & "'").Rows(0).Item(0).ToString

        If txtMKCu.Text = MKCu Then
            DK1 = True
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(duongdan & "\IMG\v.png")
        Else
            DK1 = False
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(duongdan & "\IMG\x.png")
        End If
    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMKMoi_Leave(sender As Object, e As EventArgs) Handles txtMKMoi.Leave
        If txtMKCu.Text = txtMKMoi.Text Then
            MetroFramework.MetroMessageBox.Show(Me, "Mật khẩu mới không được trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DK2 = False
        Else
            PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(duongdan & "\IMG\v.png")
            DK2 = True
        End If
    End Sub

    Private Sub mbtnThemMoi_Click(sender As Object, e As EventArgs) Handles mbtnThemMoi.Click
        If DK1 = True And DK2 = True And DK3 = True Then
            Dim lenh As New SqlCommand("update NHAN_VIEN set MatKhau='" & txtMKMoi.Text & "' where MaNV='" & MaNVPL & "'", KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Đổi Mật Khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Dữ liệu còn thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub

    Private Sub txtDoi_Leave(sender As Object, e As EventArgs) Handles txtDoi.Leave
        If txtDoi.Text = txtMKMoi.Text Then
            PictureBox3.BackgroundImage = System.Drawing.Image.FromFile(duongdan & "\IMG\v.png")
            DK3 = True
        Else
            PictureBox3.BackgroundImage = System.Drawing.Image.FromFile(duongdan & "\IMG\x.png")
            DK3 = False
        End If
    End Sub
End Class