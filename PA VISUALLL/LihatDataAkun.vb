Imports MySql.Data.MySqlClient
Public Class LihatDataAkun
    Sub Display_Data()
        DA = New MySqlDataAdapter("Select * from users", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "users")
        DataAkun.DataSource = DS.Tables("users")
        DataAkun.Refresh()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim QuerySearch As String = "Select * From users where Nama like '" & TxtCari.Text & "%' or username like '" & TxtCari.Text & "%'"
        DA = New MySqlDataAdapter(QuerySearch, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "users")
        DataAkun.DataSource = DS.Tables("users")
        DataAkun.Refresh()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        FormMenuAdmin.Show()
    End Sub

    Private Sub LihatDataAkun_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LihatDataAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konn()
        Display_Data()
    End Sub
End Class