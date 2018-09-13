Imports System.Data.SqlClient

Public Class GudangGoodIssue

    Private Sub GudangGoodIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal, deskripsi_good_issue, jumlah_barang_keluar FROM t_good_issue where id_role_tujuan='SG'", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        id.Text = selectedRow.Cells(0).Value.ToString()
        tanggal.Text = selectedRow.Cells(1).Value.ToString()
        deskripsi.Text = selectedRow.Cells(2).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchquery As String = "Select * from t_good_issue where id_good_issue=@id"
        Dim cmd As New SqlCommand(searchquery, con)
        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        Dim insertquery As String = "update t_good_issue set tanggal=@tanggal,deskripsi_good_issue=@deskripsi,jumlah_barang_keluar=@jumlah,id_gudang=@id_gudang,id_username_staff=@id_username_staff,id_produksi=@id_produksi,id_role_tujuan=@id_role where id_good_issue=@id"
        addGoodIssue(insertquery, table)

        Dim searchquery1 As String = "Select * from t_gudang where id_gudang=@id"
        Dim cmd1 As New SqlCommand(searchquery1, con)
        cmd1.Parameters.AddWithValue("id", "BM")
        Dim da1 As New SqlDataAdapter(cmd1)
        Dim table1 As New DataTable
        da1.Fill(table1)
        Dim updateQuery As String = "update t_gudang set deskripsi_gudang=@deskripsi, total_barang=@total where id_gudang=@id"
        updateGudang(updateQuery, table1)

        MessageBox.Show("Berhasil dikirimkan")
        clear()
        GudangGoodIssue_Load(sender, e)
    End Sub

    Private Sub addGoodIssue(ByVal query As String, ByVal table As DataTable)
        Dim datee As Date = Date.Today
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", id.Text)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", table.Rows(0)(2).ToString)
        cmd.Parameters.AddWithValue("@jumlah", table.Rows(0)(3).ToString)
        cmd.Parameters.AddWithValue("@id_gudang", table.Rows(0)(4).ToString)
        cmd.Parameters.AddWithValue("@id_username_staff", table.Rows(0)(5).ToString)
        cmd.Parameters.AddWithValue("@id_produksi", Convert.ToInt32(table.Rows(0)(7).ToString))
        cmd.Parameters.AddWithValue("@id_role", "SP")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub updateGudang(ByVal query As String, ByVal table As DataTable)
        Dim datee As Date = Date.Today
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", "BM")
        cmd.Parameters.AddWithValue("@deskripsi", table.Rows(0)(1).ToString())
        cmd.Parameters.AddWithValue("@total", Convert.ToInt32(table.Rows(0)(2).ToString()) - Convert.ToInt32(jumlah.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub clear()
        id.Clear()
        tanggal.Clear()
        deskripsi.Clear()
        jumlah.Clear()
    End Sub

End Class