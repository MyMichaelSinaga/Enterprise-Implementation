Imports System.Data.SqlClient

Public Class VendorPO

    Private Sub VendorPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_purchase_order, tanggal, jumlah_kayu, total_harga FROM t_purchase_order", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        idPO.Text = selectedRow.Cells(0).Value.ToString()
        jumlah.Text = selectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_invoice_kayu(tanggal,deskripsi_invoice_kayu,jumlah_kayu,id_purchase_order,id_username_vendor,id_role_tujuan) values(@tanggal,@dekripsi,@jumlah, @id_po,@id_username_vendor,@id_role_tujuan)"
        addInvoiceKayu(insertquery)
        Dim updatequery As String = "update t_barang set nama_barang=@nama,harga_per_unit=@harga,stock_barang=@stock where id_username_vendor=@id"
        updateBarang(updatequery)
        MessageBox.Show("Berhasil dikirimkan")
        clear()
    End Sub

    Private Sub clear()
        jumlah.Clear()
        deskripsi.Clear()
        idPO.Clear()
    End Sub

    Private Sub addInvoiceKayu(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@dekripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@id_po", idPO.Text)
        cmd.Parameters.AddWithValue("@id_username_vendor", LoginVendor.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_role_tujuan", "SK")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub updateBarang(ByVal query As String)
        Dim searchQuery As String = "Select * from t_barang where id_username_vendor=@username"
        Dim cmd1 As New SqlCommand(searchQuery, con)
        cmd1.Parameters.AddWithValue("@username", LoginVendor.usernameText.Text)
        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable()
        adapter.Fill(table)


        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@nama", table.Rows(0)(2).ToString)
        cmd.Parameters.AddWithValue("@harga", table.Rows(0)(3).ToString)
        cmd.Parameters.AddWithValue("@id", LoginVendor.usernameText.Text)
        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(table.Rows(0)(3).ToString) - Convert.ToInt32(jumlah.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class