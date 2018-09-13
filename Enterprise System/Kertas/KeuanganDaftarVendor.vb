Imports System.Data.SqlClient

Public Class KeuanganDaftarVendor

    Private Sub SalesDaftarVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select nama_barang, harga_per_unit, stock_barang, id_username_vendor FROM t_barang", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class