Imports System.Data.SqlClient

Public Class VendorHome

    Private Sub VendorHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchQuery As String = "Select * from t_barang where id_username_vendor=@username"
        Dim cmd As New SqlCommand(searchQuery, con)
        cmd.Parameters.AddWithValue("@username", LoginVendor.usernameText.Text)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        namaBarang.Text = selectedRow.Cells(1).Value.ToString()
        hargaBarang.Text = selectedRow.Cells(2).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updatequery As String = "update t_barang set nama_barang=@nama,harga_per_unit=@harga,stock_barang=@stock where id_username_vendor=@id"
        updateBarang(updatequery)
        MessageBox.Show("Berhasil diupdate")
        VendorHome_Load(sender, e)
    End Sub

    Private Sub updateBarang(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@nama", namaBarang.Text)
        cmd.Parameters.AddWithValue("@harga", hargaBarang.Text)
        cmd.Parameters.AddWithValue("@id", LoginVendor.usernameText.Text)
        cmd.Parameters.AddWithValue("@stock", jumlah.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class