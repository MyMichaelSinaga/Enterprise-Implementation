Imports System.Data.SqlClient

Public Class GudangGoodReceipt

    Private Sub GudangGoodReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_receipt, tanggal, deskripsi_good_receipt, jumlah_barang_masuk,id_gudang FROM t_good_receipt where id_role_tujuan='SG'", con)
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
        idGudang.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchquery As String = "Select * from t_gudang where id_gudang=@id"
        Dim cmd As New SqlCommand(searchquery, con)

        If (idGudang.Text = "BJ") Then
            cmd.Parameters.AddWithValue("@id", "BJ")
        ElseIf (idGudang.Text = "BM") Then
            cmd.Parameters.AddWithValue("@id", "BM")
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)

        Dim updatequery As String = "update t_gudang set deskripsi_gudang=@deskripsi,total_barang=@total where id_gudang=@id"
        updateGudang(updatequery, table)

        Dim dequery As String = "delete from t_good_receipt where id_good_receipt=@id"
        executeQuery(dequery)
        GudangGoodReceipt_Load(sender, e)
        MessageBox.Show("Kertas dimasukkan")
    End Sub

    Private Sub executeQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", id.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub updateGudang(ByVal query As String, ByVal table As DataTable)
        Dim cmd As New SqlCommand(query, con)
        If (idGudang.Text = "BJ") Then
            cmd.Parameters.AddWithValue("@id", "BJ")
        ElseIf (idGudang.Text = "BM") Then
            cmd.Parameters.AddWithValue("@id", "BM")
        End If
        cmd.Parameters.AddWithValue("@deskripsi", table.Rows(0)(1).ToString)
        cmd.Parameters.AddWithValue("@total", Convert.ToInt32(table.Rows(0)(2).ToString) + Convert.ToInt32(jumlah.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class