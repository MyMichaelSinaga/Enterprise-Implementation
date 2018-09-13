Imports System.Data.SqlClient

Public Class StaffGudang

    Private Sub StaffGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_sales_order", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
    End Sub

    Private Sub execQuery(ByVal query As String)
        Dim searchquery As String = "Select * from t_gudang where id_gudang=@id_gudang"
        Dim cmd1 As New SqlCommand(searchquery, con)
        cmd1.Parameters.AddWithValue("@id_gudang", "BJ")

        Dim da As New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        da.Fill(table)
        Dim cmd As New SqlCommand(query, con)
        Dim barangSekarang = Convert.ToInt32(table.Rows(0)(2).ToString) - Convert.ToInt32(jumlahBarang.Text)
        cmd.Parameters.AddWithValue("@id", table.Rows(0)(0).ToString)
        cmd.Parameters.AddWithValue("@deskripsi", table.Rows(0)(1).ToString)
        cmd.Parameters.AddWithValue("@total", Convert.ToString(barangSekarang))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minusGudang As String = "update t_gudang set deskripsi_gudang=@deskripsi,total_barang=@total WHERE id_gudang=@id"
        execQuery(minusGudang)
        Dim insertquery As String = "insert into t_good_issue(tanggal,deskripsi_good_issue,jumlah_barang_keluar,id_gudang,id_username_staff,id_sales_order,id_role_tujuan) values(@tanggal, @deskripsi,@jumlah, @id_gudang, @id_username_staff, @id_sales_order,@id_role)"
        addGoodIssue(insertquery)
        MessageBox.Show("Good Issue berhasil dibuat")
        clear()
    End Sub

    Private Sub clear()
        id_sales_order.Clear()
        deskripsi.Clear()
        jumlahBarang.Clear()
    End Sub

    Private Sub addGoodIssue(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlahBarang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", "BJ")
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        cmd.Parameters.AddWithValue("@id_sales_order", id_sales_order.Text)
        cmd.Parameters.AddWithValue("@id_role", "SK")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        id_sales_order.Text = selectedRow.Cells(0).Value.ToString()
        jumlahBarang.Text = selectedRow.Cells(5).Value.ToString()
    End Sub
End Class