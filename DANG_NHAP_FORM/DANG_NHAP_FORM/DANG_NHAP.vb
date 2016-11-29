
Imports System.Configuration
Imports System.Data.SqlClient
    Public Class frmDangNhap
        ' Khai báo biến để kết nối với Database
        Private _ConnectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
        Private KetNoi As SqlConnection
        Private DuLieu As SqlDataAdapter
        ' Định nghĩa hàm đổ dữ liệu vào bảng
        Private Function LayDuLieu(sqlQuery As String) As DataTable
            Dim DuLieuBang As New DataTable
            ' Khởi tạo biến kết nối
            KetNoi = New SqlConnection(_ConnectionString)
            ' Khởi tạo biến dữ liệu
            DuLieu = New SqlDataAdapter(sqlQuery, KetNoi)
            Try
                ' Mở chuỗi kết nối
                KetNoi.Open()
                ' Đổ dữ liệu vào bảng
                DuLieu.Fill(DuLieuBang)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error") 'Thông báo lỗi 
            Finally
                KetNoi.Close() ' Đóng chuỗi kết nối
            End Try
            Return DuLieuBang
        End Function
        ' Hàm kiểm tra tài khoản, mật khẩu nhập vào
        Private Function KiemTra(TaiKhoan As String, MatKhau As String)
        Dim sqlQuery As String = String.Format("select * from [dbo].[NHAN_VIEN] where TaiKhoan = '{0}' and MatKhau ='{1}'", TaiKhoan, MatKhau)
        Dim DuLieuBang As DataTable = LayDuLieu(sqlQuery)
            Return DuLieuBang.Rows.Count > 0
        End Function
        ' Hàm kiểm tra dữ liệu nhập vào có trống hay không
        Private Function DuLieuTrong() As Boolean
            Return String.IsNullOrEmpty(Me.txtTaiKhoan.Text) OrElse String.IsNullOrEmpty(Me.txtMatKhau.Text)
        End Function
    Private Sub lblDangNhap_Click_1(sender As Object, e As EventArgs) Handles lblDangNhap.Click
        If DuLieuTrong() Then
            MetroFramework.MetroMessageBox.Show(Me, "Mời bạn nhập tài khoản và mật khẩu truy cập", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If KiemTra(Me.txtTaiKhoan.Text.ToLower, Me.txtMatKhau.Text.ToLower) Then
                MetroFramework.MetroMessageBox.Show(Me, "Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim sqlQuery As String = String.Format("select * from [dbo].[NHAN_VIEN] where TaiKhoan = '{0}' and MatKhau ='{1}'", Me.txtTaiKhoan.Text.ToLower, Me.txtMatKhau.Text.ToLower)
                MaNVPL = LayDuLieu(sqlQuery).Rows(0).Item(0).ToString
                frmTrangChinh.Show()
                Me.Hide()

            Else ' Trường hợp sai tài khoản mật khẩu
                MetroFramework.MetroMessageBox.Show(Me, "Tài khoản hoặc mật khẩu không đúng, mời bạn kiểm tra lại", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles lblDangNhap.MouseHover
        lblDangNhap.ForeColor = Color.Black
        lblDangNhap.BackColor = Color.White
    End Sub

    Private Sub lblDangNhap_MouseLeave(sender As Object, e As EventArgs) Handles lblDangNhap.MouseLeave
            lblDangNhap.ForeColor = Color.Gray
            lblDangNhap.BackColor = Color.White
        End Sub

        Private Sub lblThoat_MouseHover(sender As Object, e As EventArgs) Handles lblThoat.MouseHover
            lblThoat.ForeColor = Color.Black
            lblThoat.BackColor = Color.White
        End Sub
        Private Sub lblThoat_MouseLeave(sender As Object, e As EventArgs) Handles lblThoat.MouseLeave
            lblThoat.ForeColor = Color.Gray
            lblThoat.BackColor = Color.White

        End Sub

    Private Sub lblThoat_Click(sender As Object, e As EventArgs) Handles lblThoat.Click
        Me.Close()
    End Sub
    Private Sub txtMatKhau_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatKhau.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.lblDangNhap_Click_1(sender, e)

        End If
    End Sub
End Class
