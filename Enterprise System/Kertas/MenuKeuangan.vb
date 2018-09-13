Public Class MenuKeuangan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hideAll()
        StaffKeuangan.Close()
        StaffKeuangan.Show()
    End Sub

    Sub hideAll()
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hideAll()
        LoginForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideAll()
        KeuanganInvoice.Close()
        KeuanganInvoice.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hideAll()
        KeuanganDaftarVendor.Hide()
        KeuanganDaftarVendor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hideAll()
        KeuanganRequisition.Hide()
        KeuanganRequisition.Show()
    End Sub
End Class
