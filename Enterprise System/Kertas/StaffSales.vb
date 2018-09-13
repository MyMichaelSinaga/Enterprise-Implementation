Imports System.Data.SqlClient

Public Class StaffSales

    Private Sub StaffSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_invoice_kertas where id_role_tujuan='SKF'", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        idInvoice.Text = selectedRow.Cells(0).Value.ToString()
        tanggal.Text = selectedRow.Cells(1).Value.ToString()
        deskripsi.Text = selectedRow.Cells(2).Value.ToString()
        jumlahKertas.Text = selectedRow.Cells(3).Value.ToString()
        idGoodIssue.Text = selectedRow.Cells(4).Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dequery As String = "delete from t_invoice_kertas where id_invoice_kertas=@id"
        executeQuery(dequery)
        MessageBox.Show("berhasil dikonfirmasi")
        clear()
        StaffSales_Load(sender, e)
    End Sub

    Private Sub executeQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", idInvoice.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub clear()
        idGoodIssue.Clear()
        idInvoice.Clear()
        tanggal.Clear()
        deskripsi.Clear()
        jumlahKertas.Clear()
    End Sub
End Class