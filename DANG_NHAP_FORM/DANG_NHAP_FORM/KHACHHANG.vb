Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmKhachHang
    Public Function kiemtraemail(EmailAddress As String) As Boolean
        kiemtraemail = EmailAddress Like "*@[A-Z,a-z,0-9]*.*"
    End Function
    Public Sub dinhdang()
        DataGridView2.MultiSelect = True
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.AllowUserToDeleteRows = True
        DataGridView2.AllowUserToAddRows = True
        DataGridView2.AllowUserToResizeColumns = True
        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        DataGridView2.Columns(0).HeaderText = "Mã khách hàng"
        DataGridView2.Columns(0).Width = 120
        DataGridView2.Columns(1).HeaderText = "Tên khách hàng"
        DataGridView2.Columns(1).Width = 230
        DataGridView2.Columns(2).HeaderText = "Ngày sinh"
        DataGridView2.Columns(3).HeaderText = "Giới tính"
        DataGridView2.Columns(4).HeaderText = "CMND"
        DataGridView2.Columns(5).HeaderText = "Nơi cấp"
        DataGridView2.Columns(5).Width = 150
        DataGridView2.Columns(6).HeaderText = "Ngày cấp"
        DataGridView2.Columns(7).HeaderText = "Email"
        DataGridView2.Columns(7).Width = 215
        DataGridView2.Columns(8).HeaderText = "Ghi chú"

    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView2.DataSource = LayDuLieu("select * from KHACH_HANG")
        dinhdang()

    End Sub
    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        If MetroRadioButton1.Checked = True Then
            DataGridView2.DataSource = LayDuLieu("select * from KHACH_HANG where TenKH like N'" & MetroTextBox1.Text & "%'")
        End If
    End Sub

    Private Sub MetroTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox2.TextChanged
        If MetroRadioButton2.Checked = True Then
            DataGridView2.DataSource = LayDuLieu("select * from KHACH_HANG where CMND like N'" & MetroTextBox2.Text & "%'")
        End If
    End Sub

    Private Sub mbtnXoa_Click(sender As Object, e As EventArgs) Handles mbtnXoa.Click
        frmCapNhatKH.Show()

    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim GioiTinh As Boolean
        Dim ThongBaoLoi As String = ""
        Dim MaKH As String = ""
        Dim lenh1 As New SqlCommand("Select max(MaKH) from KHACH_HANG", KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Do While doc1.Read
            MaKH = "KH" & Format(Val(vb.Right(doc1.Item(0).ToString, 3)) + 1, "000")
        Loop
        doc1.Close()

        If mtbTenKH.Text = "" Then
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
            ThongBaoLoi &= "Sai chuẩn CMND, "
        End If

        If mtbNoiCap.Text = "" Then
            ThongBaoLoi &= "Xin Nhập Tên Khách Hàng, "
        End If

        If ThongBaoLoi = "" Then
            Dim str As String = "insert into KHACH_HANG(MaKH, TenKH, NgaySinh, GioiTinh, CMND, NoiCap, NgayCap, Email, GhiChu) values('" & MaKH & "', N'" & mtbTenKH.Text & "', CONVERT(DATETIME, '" & mdtNgaySinh.Value & "', 102), '" & GioiTinh & "', " & mtbCMND.Text & ", N'" & mtbNoiCap.Text & "', CONVERT(DATETIME, '" & mdtNgayCap.Value & "', 102), '" & mtbEmail.Text & "', N'" & txtGhiChu.Text & "')"
            Dim lenh As New SqlCommand(str, KetNoi)
            lenh.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Thêm Thông Tin Khách Hàng Thành Công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            DataGridView2.DataSource = LayDuLieu("select * from KHACH_HANG")
        Else
            MetroFramework.MetroMessageBox.Show(Me, ThongBaoLoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

    End Sub

    Private Sub mdtNgaySinh_ValueChanged(sender As Object, e As EventArgs) Handles mdtNgaySinh.ValueChanged

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        mtbCMND.Text = ""
        mtbEmail.Text = ""
        mtbNoiCap.Text = ""
        mtbTenKH.Text = ""
        txtGhiChu.Text = ""
    End Sub
End Class