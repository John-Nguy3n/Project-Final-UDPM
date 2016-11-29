Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Module Module1
    ' Khai báo biến để kết nối với Database
    Public _ConnectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
    ' Khởi tạo biến kết nối
    Public KetNoi As New SqlConnection(_ConnectionString)

    Public DuLieu As SqlDataAdapter
    ' Định nghĩa hàm đổ dữ liệu vào bảng

    Public MaPhieuQLPL, MaPhongPL As String 'Xác định các vị trí của phiếu khi thêm dịch vụ
    Public MaDVPL, MaNVPL, MaLoaiDVPL As String
    Public Function LayMa(ByVal Ma As String, ByVal bang As String, ByVal DK As String) As String
        Dim lenh As New SqlCommand("select " & Ma & " from " & bang & " where " & DK, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Dim kq As String = ""
        Do While doc.Read
            kq = doc.Item(0).ToString
        Loop
        doc.Close()
        Return kq


    End Function

    Public Function LayDuLieu(sqlQuery As String) As DataTable
        Dim DuLieuBang As New DataTable
        Dim ketnoi As New SqlConnection(_ConnectionString)
        ' Khởi tạo biến dữ liệu
        DuLieu = New SqlDataAdapter(sqlQuery, KetNoi)
        Try
            ' Mở chuỗi kết nối
            'ketnoi.Open()
            ' Đổ dữ liệu vào bảng
            DuLieu.Fill(DuLieuBang)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") 'Thông báo lỗi 
        Finally
            'KetNoi.Close() ' Đóng chuỗi kết nối
        End Try
        Return DuLieuBang
    End Function

    Public Sub DienDL(ByRef cmb As ComboBox, ByVal chuoi As String)


        Dim lenh As New SqlCommand(chuoi, KetNoi)
        Dim doc As SqlDataReader = lenh.ExecuteReader
        Do While doc.Read
            cmb.Items.Add(doc.Item(0))
        Loop
        doc.Close()

    End Sub

End Module
