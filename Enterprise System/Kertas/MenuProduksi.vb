Public Class MenuProduksi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hideAll()
        StaffProduksi.Close()
        StaffProduksi.Show()
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

    Private Sub GoodIssue_Click(sender As Object, e As EventArgs) Handles GoodIssue.Click
        hideAll()
        ProduksiGoodIssue.Close()
        ProduksiGoodIssue.Show()
    End Sub
End Class
