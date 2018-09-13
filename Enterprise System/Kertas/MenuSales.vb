Public Class MenuSales

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StaffSales.Show()
        SalesOrderCreate.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SalesOrderCreate.Show()
        StaffSales.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        StaffSales.Close()
        SalesOrderCreate.Close()
    End Sub
End Class
