Public Class MenuGudang

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hideAll()
        StaffGudang.Close()
        StaffGudang.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hideAll()
        LoginForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hideAll()
        Gudang.Close()
        Gudang.Show()
    End Sub

    Sub hideAll()
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hideAll()
        GudangGoodIssue.Close()
        GudangGoodIssue.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideAll()
        GudangGoodReceipt.Close()
        GudangGoodReceipt.Show()
    End Sub
End Class
