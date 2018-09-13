Public Class MenuVendor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginVendor.Hide()
        VendorPO.Hide()
        VendorHome.Close()
        VendorHome.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginVendor.Hide()
        VendorHome.Hide()
        VendorPO.Close()
        VendorPO.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginVendor.Show()
        VendorPO.Hide()
        VendorHome.Hide()
    End Sub
End Class
