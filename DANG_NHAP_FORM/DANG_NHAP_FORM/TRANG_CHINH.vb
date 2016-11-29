Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmTrangChinh
    Private Sub frmTrangChinh_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        KetNoi.Close()
        DANG_NHAP_FORM.frmDangNhap.Close()

    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs)
        frmThanhToan.Show()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmGioiThieu.Show()
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs)
        frmThemSP.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim dk 'Khai báo biến điều kiện để sử lý sự kiện của messeagebox
        dk = MetroFramework.MetroMessageBox.Show(Me, "Bạn có chắc chắc muốn đóng phần mềm", "Xác nhận đóng phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dk = DialogResult.Yes Then 'Nếu button click là yes thì sẽ đóng form
            Me.Close()
        End If
    End Sub

    Private Sub QuảnLýPhòngToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmTrangChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KetNoi.Open()
        Label1.Text = LayMa("TenNV", "NHAN_VIEN", "MaNV='" & MaNVPL & "'")
        Me.Show()
        With frmTrangChinhCon
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With

    End Sub

    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs)
        frmThemSP.Show()
    End Sub

    Private Sub MetroButton6_Click_1(sender As Object, e As EventArgs)
        frmThanhToan.Show()

    End Sub

    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HệThốngToolStripMenuItem.Click
        With frmTrangChinhCon
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub ThoátToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BáoCáoDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoDoanhThuToolStripMenuItem.Click
        With DOANHTHU
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub PhòngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhòngToolStripMenuItem.Click
        With frmPhong
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        With frmKhachHang
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub DịchVụToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DịchVụToolStripMenuItem.Click
        With frmQLDichVu
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        With frmQLNhanVien
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub ThayĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiMậtKhẩuToolStripMenuItem.Click
        frmDoiMK.Show()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        frmGioiThieu.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class