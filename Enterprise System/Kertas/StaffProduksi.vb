Imports System.Data.SqlClient

Public Class StaffProduksi
    Private Sub executeQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlahBarang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", "BM")
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_produksi", id_produksi.Text)
        cmd.Parameters.AddWithValue("@id_role", "SG")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub clear()
        id_produksi.Clear()
        deskripsi.Clear()
        jumlahBarang.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_good_issue(tanggal,deskripsi_good_issue,jumlah_barang_keluar,id_gudang,id_username_staff,id_produksi,id_role_tujuan) values(@tanggal, @deskripsi,@jumlah, @id_gudang, @id_username_staff, @id_produksi,@id_role)"
        executeQuery(insertquery)
        MessageBox.Show("Berhasil direquest")
        clear()
    End Sub

    Private Sub StaffProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_produksi, tanggal, jumlah_kertas FROM t_produksi", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        id_produksi.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

End Class