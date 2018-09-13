Imports System.Data.SqlClient

Public Class LoginVendor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchquery As String = "Select * from t_vendor where id_username_vendor=@username"
        Dim cmd As New SqlCommand(searchquery, con)
        cmd.Parameters.AddWithValue("@username", usernameText.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count > 0 Then
            If passwordText.Text = table.Rows(0)(1).ToString Then
                VendorHome.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login Unsuccessfull")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Start.Show()
    End Sub
End Class