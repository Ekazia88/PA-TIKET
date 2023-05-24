Imports MySql.Data.MySqlClient

Public Class LihatPesanan
    Sub DisplayPesan()
        Call Konn()
        Dim Sql As String = "Select * from pesanan join users on users.id_user = pesanan.id_customer join datamobil on datamobil.id_mobil = pesanan.id_mobil where id_customer = " & LoginBARU.id_user & ""
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        LNama.Text = DR("Nama")
        LDari.Text = DR("Dari")
        LKe.Text = DR("Tujuan")
        LNmobil.Text = DR("Nama_Mobil")
        LTglpergi.Text = DR("Tanggal_pergi")
        LHarga.Text = DR("Harga_total")
    End Sub
    Private Sub LihatPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPesan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        MenuUser.Show()
    End Sub
End Class