Imports System.IO
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.DateTime
Public Class frmThemLoaiDV
    Public Sub lammoi()
        
        frmQLDichVu.TwDichVu.Nodes.Clear()
        frmQLDichVu.TwDichVu.Nodes.Add("Tất cả")
        Dim str As String
        str = "select TenLoaiDV from LOAI_DV"
        Dim lenh1 As New SqlCommand(str, KetNoi)
        Dim doc As SqlDataReader = lenh1.ExecuteReader
        Do While doc.Read
            frmQLDichVu.TwDichVu.Nodes.Add(doc.Item(0).ToString)
        Loop
        doc.Close()

    End Sub

    Private Sub mbtThemDV_Click(sender As Object, e As EventArgs) Handles mbtThemDV.Click
        Try
            If txtMaLoaiDV.Text = "" Or txtTenLoaiDV.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Mời bạn nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim str As String = "insert into LOAI_DV(MaLoaiDV, TenLoaiDV) values('" & txtMaLoaiDV.Text & "', N'" & txtTenLoaiDV.Text & "')"
                Dim lenh As New SqlCommand(str, KetNoi)
                lenh.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Thêm loại dịch vụ thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Trùng mã loại dịch vụ ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        lammoi()
    End Sub

    Private Sub mbtXoaDV_Click(sender As Object, e As EventArgs) Handles mbtXoaDV.Click
        Me.Close()
    End Sub
End Class