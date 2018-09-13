Imports System.Data.SqlClient
Public Class StaffKeuangan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_invoice_kertas(tanggal,deskripsi_invoice_kertas,jumlah_kertas,id_good_issue,id_username_staff,id_role_tujuan) values(@tanggal, @deskripsi,@jumlah, @id_good_issue, @id_username_staff,@id_role)"
        addInvoice(insertquery)
        MessageBox.Show("Invoice berhasil dibuat")
        clear()
    End Sub
    Private Sub clear()
        idGood.Clear()
        deskripsi.Clear()
        jumlahKertas.Clear()
    End Sub

    Private Sub addInvoice(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlahKertas.Text)
        cmd.Parameters.AddWithValue("@id_good_issue", idGood.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_role", "SKF")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub StaffKeuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal, deskripsi_good_issue, jumlah_barang_keluar FROM t_good_issue where id_role_tujuan='SK'", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        idGood.Text = selectedRow.Cells(0).Value.ToString()
        jumlahKertas.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

End Class