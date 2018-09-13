Imports System.Data.SqlClient

Public Class Gudang

    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_gudang", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_produksi(tanggal,jumlah_kertas,id_username_staff) values(@tanggal, @jumlah_kertas,@id_username_staff)"
        execQuery(insertquery)
        MessageBox.Show("Permintaan Produksi Kertas berhasil dilakukan")
    End Sub

    Private Sub execQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah_kertas", Convert.ToInt32(jumlahKertas.Text))
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim insertquery As String = "insert into t_purchase_requisition(tanggal,jumlah_kayu,id_username_staff) values(@tanggal, @jumlah_kayu,@id_username_staff)"
        executeQuery(insertquery)
        MessageBox.Show("Permintaan Kayu berhasil dilakukan")
    End Sub

    Private Sub executeQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal1.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah_kayu", Convert.ToInt32(jumlahKayu.Text))
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class