Imports System.Data.SqlClient

Public Class KeuanganRequisition

    Private Sub SalesRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_purchase_requisition, tanggal, jumlah_kayu FROM t_purchase_requisition", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        idpr.Text = selectedRow.Cells(0).Value.ToString()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_purchase_order(tanggal,jumlah_kayu,total_harga,id_purchase_requisition,id_username_staff,id_vendor) values(@tanggal,@jumlah, @total, @id_pr,@id_username_staff,@id_vendor)"
        addPO(insertquery)
        MessageBox.Show("Berhasil dikirim")
    End Sub

    Private Sub addPO(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@total", total.Text)
        cmd.Parameters.AddWithValue("@id_pr", idpr.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_vendor", idvendor.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class