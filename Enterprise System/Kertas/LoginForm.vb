Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchquery As String = "Select * from t_staff where id_username_staff=@username"
        Dim cmd As New SqlCommand(searchquery, con)
        cmd.Parameters.AddWithValue("@username", usernameText.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count > 0 Then
            If passwordText.Text = table.Rows(0)(1).ToString Then
                Dim role As String = table.Rows(0)(4)
                checkRole(role)
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login Unsuccessfull")
        End If
    End Sub

    Private Sub checkRole(role As String)
        If (role = "SKF") Then
            StaffSales.Show()
        ElseIf (role = "SG") Then
            StaffGudang.Show()
        ElseIf (role = "SK") Then
            StaffKeuangan.Show()
        ElseIf (role = "SP") Then
            StaffProduksi.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Start.Show()
    End Sub
End Class