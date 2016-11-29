Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmCapNhatDV
    Dim GiaCu As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label8.Text = Now
    End Sub

    Private Sub frmCapNhatDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DienDL(mcbTenDV, "select MaDV from DICH_VU")
        mcbTenDV.Text = MaDVPL
        Dim lenh As New SqlCommand("SELECT        DICH_VU.TenDV, t1.GiaDV, DICH_VU.DVT
FROM            GIA_DV AS t1 INNER JOIN
                             (SELECT        MaDV, MAX(Ngay) AS NgayBan
                               FROM            GIA_DV
                               GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN
                         DICH_VU ON t1.MaDV = DICH_VU.MaDV
where DICH_VU.MaDV ='" & mcbTenDV.Text & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            txtTenDV.Text = doc.Item(0)
            txtGiaDV.Text = doc.Item(1)
            GiaCu = doc.Item(1)
            txtDonVi.Text = doc.Item(2)
        Loop
        doc.Close()
    End Sub

    Private Sub btnThemMoi_Click(sender As Object, e As EventArgs) Handles btnThemMoi.Click
        Dim lenh As New SqlCommand("update DICH_VU set TenDV=N'" & txtTenDV.Text & "', DVT ='" & txtDonVi.Text & "' where MaDV ='" & mcbTenDV.Text & "'", KetNoi)

        If txtGiaDV.Text = GiaCu Then
            MsgBox("Ko đổi giá")
            If lenh.ExecuteNonQuery Then
                MetroFramework.MetroMessageBox.Show(Me, "Bạn đã cập nhập dịch vụ thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtGiaDV.Text = ""
                txtDonVi.Text = ""
                mcbTenDV.Text = ""
                txtTenDV.Text = ""
            End If
        Else
                Dim lenh1 As New SqlCommand("insert into Gia_DV (MaDV, Ngay, GiaDV) values ('" & mcbTenDV.Text & "', convert(datetime, '" & Label8.Text & "', 102), " & Val(txtGiaDV.Text) & ")", KetNoi)
            lenh.ExecuteNonQuery()
            Try
                lenh1.ExecuteNonQuery()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Hôm nay bạn đã đổi giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            MetroFramework.MetroMessageBox.Show(Me, "Bạn đã cập nhập dịch vụ thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtGiaDV.Text = ""
                    txtDonVi.Text = ""
                    mcbTenDV.Text = ""
            txtTenDV.Text = ""
        End If


    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub mcbTenDV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbTenDV.SelectedIndexChanged
        Dim lenh As New SqlCommand("SELECT        DICH_VU.TenDV, t1.GiaDV, DICH_VU.DVT
FROM            GIA_DV AS t1 INNER JOIN
                             (SELECT        MaDV, MAX(Ngay) AS NgayBan
                               FROM            GIA_DV
                               GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN
                         DICH_VU ON t1.MaDV = DICH_VU.MaDV
where DICH_VU.MaDV ='" & mcbTenDV.Text & "'", KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            txtTenDV.Text = doc.Item(0)
            txtGiaDV.Text = doc.Item(1)
            GiaCu = doc.Item(1)
            txtDonVi.Text = doc.Item(2)
        Loop
        doc.Close()
    End Sub


End Class