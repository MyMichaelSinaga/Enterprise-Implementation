Imports System.Data.SqlClient

Public Class ProduksiGoodIssue

    Private Sub ProduksiGoodIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal, deskripsi_good_issue, jumlah_barang_keluar, id_produksi FROM t_good_issue where id_role_tujuan='SP'", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_good_receipt(tanggal,deskripsi_good_receipt,jumlah_barang_masuk,id_gudang,id_username_staff,id_role_tujuan) values(@tanggal, @deskripsi,@jumlah, @id_gudang, @id_username_staff,@id_role)"
        addGoodReceipt(insertquery)
        
        Dim dequery As String = "delete from t_good_issue where id_good_issue=@id"
        executeQuery(dequery, idGoodIssue.Text)
        Dim dequery1 As String = "delete from t_produksi where id_produksi=@id"
        executeQuery(dequery1, idProduksi.Text)

        MessageBox.Show("Good Receipt berhasil dibuat")
        clear()

    End Sub

    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", id)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub clear()
        deskripsi.Clear()
        idGoodIssue.Clear()
    End Sub

    Private Sub addGoodReceipt(ByVal query As String)
        Dim searchquery As String = "Select * from t_produksi where id_produksi=@id_produksi"
        Dim cmd1 As New SqlCommand(searchquery, con)
        cmd1.Parameters.AddWithValue("@id_produksi", idProduksi.Text)

        Dim da As New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        da.Fill(table)

        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@jumlah", table.Rows(0)(2).ToString)
        cmd.Parameters.AddWithValue("@id_gudang", "BJ")
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_role", "SG")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        idProduksi.Text = selectedRow.Cells(4).Value.ToString()
        idGoodIssue.Text = selectedRow.Cells(0).Value.ToString()
    End Sub
End Class