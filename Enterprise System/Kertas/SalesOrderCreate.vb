Imports System.Data.SqlClient

Public Class SalesOrderCreate

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_sales_order(tanggal,nama_pelanggan,alamat_pelanggan,telepon_pelanggan,jumlah_barang,total_harga,status_bayar,id_username_staff) values(@tanggal, @nama_pelanggan,@alamat_pelanggan, @telepon_pelanggan, @jumlah_barang, @total_harga,@status_bayar, @id_username_staff)"
        addSalesOder(insertquery)
        MessageBox.Show("Order Ditambahkan")
        clearAll()
    End Sub

    Private Sub addSalesOder(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@nama_pelanggan", namaPelanggan.Text)
        cmd.Parameters.AddWithValue("@alamat_pelanggan", alamatPelanggan.Text)
        cmd.Parameters.AddWithValue("@telepon_pelanggan", teleponPelanggan.Text)
        cmd.Parameters.AddWithValue("@jumlah_barang", jumlahBarang.Text)
        cmd.Parameters.AddWithValue("@total_harga", totalHarga.Text)
        cmd.Parameters.AddWithValue("@status_bayar", "Belum Lunas")
        cmd.Parameters.AddWithValue("@id_username_staff", LoginForm.usernameText.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub clearAll()
        namaPelanggan.Clear()
        alamatPelanggan.Clear()
        teleponPelanggan.Clear()
        jumlahBarang.Clear()
        totalHarga.Clear()
    End Sub

    Private Sub jumlahBarang_TextChanged_1(sender As Object, e As EventArgs) Handles jumlahBarang.TextChanged
        Try
            Dim total As Integer = Convert.ToInt32(jumlahBarang.Text)
            totalHarga.Text = Convert.ToString(total * 2000)
        Catch ex As Exception
            totalHarga.Clear()
        End Try

    End Sub
End Class