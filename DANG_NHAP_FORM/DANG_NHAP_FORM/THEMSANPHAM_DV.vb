Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class frmThemSP

#Region "Biến"

    Dim TenDV As String
    Public Sub DinhDang()
        dtgDichVu.MultiSelect = True
        dtgDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgDichVu.AllowUserToDeleteRows = True
        dtgDichVu.AllowUserToAddRows = True
        dtgDichVu.AllowUserToResizeColumns = True
        dtgDichVu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dtgDichVu.Columns(0).HeaderText = "Tên Dịch Vụ"
        dtgDichVu.Columns(0).Width = "220"
        dtgDichVu.Columns(1).HeaderText = "Loại Dịch Vụ"
        dtgDichVu.Columns(1).Width = "130"
        dtgDichVu.Columns(2).HeaderText = "Đơn Vị Tính"
        dtgDichVu.Columns(2).Width = "110"
        dtgDichVu.Columns(3).HeaderText = "Đơn Giá"
        dtgDichVu.Columns(3).Width = "80"
    End Sub
    Sub GhiMon(ByVal dtg As DataGridView, ByVal dk As String)
        Dim lenh As New SqlCommand(dk, KetNoi)
        If lenh.ExecuteNonQuery > 0 Then
            'MsgBox("Thêm dịch vụ thành công.")
        End If
    End Sub

    Function LayMa(ByVal Ma As String, ByVal bang As String, ByVal DK As String) As String
        Dim lenh As New SqlCommand("select " & Ma & " from " & bang & " where " & DK, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Dim kq As String = ""
        Do While doc.Read
            kq = doc.Item(0).ToString
        Loop
        doc.Close()
        Return kq


    End Function

#End Region


    Private Sub DataGridView1_AutoSizeChanged(sender As Object, e As EventArgs) Handles dtgDichVu.AutoSizeChanged

    End Sub

    Private Sub frmThemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "SELECT      DICH_VU.TenDV, LOAI_DV.TenLoaiDV, DICH_VU.DVT , t1.GiaDV  FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN LOAI_DV on LOAI_DV.MaLoaiDV=DICH_VU.MaLoaiDV "
        dtgDichVu.DataSource = LayDuLieu(str)
        DinhDang()

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub

    Private Sub WaterMark_LOGIN1_TextChanged(sender As Object, e As EventArgs) Handles wmlTK.TextChanged
        Dim str As String

        If Me.mrbLoaiDV.Checked = True Then 'Khi tìm kiếm theo loại dịch vụ
            str = "SELECT      DICH_VU.TenDV, LOAI_DV.TenLoaiDV, DICH_VU.DVT , t1.GiaDV  FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN LOAI_DV on LOAI_DV.MaLoaiDV=DICH_VU.MaLoaiDV where LOAI_DV.TenLoaiDV like N'" & Me.wmlTK.Text & "%'"
            dtgDichVu.DataSource = LayDuLieu(str)
            DinhDang()


        Else 'Khi tìm kiếm theo Tên dịch vụ
            str = "SELECT      DICH_VU.TenDV, LOAI_DV.TenLoaiDV, DICH_VU.DVT , t1.GiaDV  FROM         GIA_DV AS t1 INNER JOIN (SELECT     MaDV, MAX(Ngay) AS NgayBan FROM          GIA_DV GROUP BY MaDV) AS t2 ON t1.MaDV = t2.MaDV AND t1.Ngay = t2.NgayBan INNER JOIN DICH_VU ON t1.MaDV = DICH_VU.MaDV INNER JOIN LOAI_DV on LOAI_DV.MaLoaiDV=DICH_VU.MaLoaiDV where DICH_VU.TenDV like N'" & Me.wmlTK.Text & "%'"
            dtgDichVu.DataSource = LayDuLieu(str)
            DinhDang()


        End If
    End Sub

    Private Sub dtgDichVu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDichVu.CellClick
        TenDV = dtgDichVu.Rows(dtgDichVu.SelectedCells.Item(0).RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim MaDV As String
        MaDV = LayMa("MaDV", "DICH_VU", "TenDV=N'" & TenDV & "'")
        Dim MaCT As String
        Dim lenh1 As New SqlCommand("select max(convert(int,MaCT)) from CT_PHIEU_QL", KetNoi)
        Dim doc1 As SqlDataReader = lenh1.ExecuteReader
        Do While doc1.Read
            MaCT = Val(doc1.Item(0).ToString) + 1
        Loop
        doc1.Close()

        KetNoi.Close()
        KetNoi.Open()

        Dim str As String
        str = "select * from DICH_VU where '" & MaDV & "' not in (select MaDV from CT_PHIEU_QL where MaPhieuQL=" & MaPhieuQLPL & " and MaPhong=" & MaPhongPL & ")"
        Dim lenh2 As New SqlCommand(str, KetNoi)
        Dim doc2 As SqlDataReader = lenh2.ExecuteReader
        If doc2.HasRows Then
            doc2.Close()
            'Khi không có Dịch vụ
            str = "insert into CT_PHIEU_QL (MaCT, MaPhieuQL, MaPhong, MaDV, SoLuong) values(" & MaCT & ", " & MaPhieuQLPL & ", " & MaPhongPL & ", '" & MaDV & "', 1)"
            Dim lenh As New SqlCommand(str, KetNoi)
            lenh.ExecuteNonQuery()

        Else
            'Khi có dịch vụ
            doc2.Close()
            If MetroFramework.MetroMessageBox.Show(Me, "Dịch vụ đã có, Bạn có muốn tăng số lương?", vbOKCancel) = DialogResult.OK Then
                Dim lenh As New SqlCommand("update CT_PHIEU_QL set SoLuong = SoLuong + 1 where MaDV= '" & MaDV & "' and MaPhieuQL =" & MaPhieuQLPL & " and MaPhong =" & MaPhongPL, KetNoi)
                lenh.ExecuteNonQuery()
            Else
            End If

        End If
        doc2.Close()




        DANG_NHAP_FORM.frmTrangChinhCon.loadDuLieu(MaPhongPL)
    End Sub


    Private Sub dtgDichVu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDichVu.CellContentClick

    End Sub
End Class