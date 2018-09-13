Imports System.Data.SqlClient

Public Class KeuanganInvoice

    Private Sub KeuanganInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_invoice_kayu, tanggal,jumlah_kayu, deskripsi_invoice_kayu, id_purchase_order FROM t_invoice_kayu", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_good_receipt(tanggal,deskripsi_good_receipt,jumlah_barang_masuk,id_gudang,id_username_staff,id_role_tujuan) values(@tanggal, @deskripsi,@jumlah, @id_gudang, @id_username_staff,@id_role)"
        addGoodReceipt(insertquery)
        deleteInvoice()
        deletePO()
        MessageBox.Show("Berhasil dikirimkan")
        clear()
        KeuanganInvoice_Load(sender, e)
    End Sub

    Private Sub deleteInvoice()
        Dim dequery As String = "delete from t_invoice_kayu where id_invoice_kayu=@id"
        executeQuery(dequery, idInvoice.Text)
    End Sub

    Private Sub deletePO()
        Dim searchquery As String = "Select id_purchase_requisition from t_purchase_order where id_purchase_order=@username"
        Dim cmd As New SqlCommand(searchquery, con)
        cmd.Parameters.AddWithValue("@username", idPO.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        
        Dim dequery As String = "delete from t_purchase_order where id_purchase_order=@id"
        executeQuery(dequery, idPO.Text)
        deletePR(table.Rows(0)(0).ToString)
    End Sub

    Private Sub deletePR(ByVal id As String)
        Dim dequery As String = "delete from t_purchase_requisition where id_purchase_requisition=@id"
        executeQuery(dequery, id)
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
        jumlah.Clear()
        idInvoice.Clear()
    End Sub

    Private Sub addGoodReceipt(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@id_gudang", "BM")
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
        idInvoice.Text = selectedRow.Cells(0).Value.ToString()
        jumlah.Text = selectedRow.Cells(2).Value.ToString()
        idPO.Text = selectedRow.Cells(4).Value.ToString()
    End Sub
End Class