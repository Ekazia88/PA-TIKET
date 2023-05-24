Imports MySql.Data.MySqlClient

Public Class MenuUser

    Sub DisplayUser()
        Call Konn()
        Dim Sql As String = "Select * From users where id_user = " & LoginBARU.id_user & ""
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        Dim filename As String = DR("Gambar")
        Dim location As String = "D:\clonee\Gambar\" & filename & ""
        PictureBox1.Image = Image.FromFile(location)
        Username.Text = DR("username")
    End Sub
    Private Sub BtnPesan_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click
        Call Konn()
        Dim Sql As String = "Select * From Pesanan Where id_customer = " & LoginBARU.id_user & ""
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        If DR.HasRows Then
            MsgBox("Anda Sudah Memesan", MsgBoxStyle.Information, "Warning")
        Else
            Me.Hide()
            Form_Pemesanan.Show()
        End If
    End Sub

    Private Sub BtnLihatPesan_Click(sender As Object, e As EventArgs) Handles BtnLihatPesan.Click
        Call Konn()
        Dim Sql As String = "Select * From Pesanan Where id_customer = " & LoginBARU.id_user & ""
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        If DR.HasRows Then
            Me.Hide()
            LihatPesanan.Show()
        Else
            MsgBox("Anda Belum Memesan Apapun", MsgBoxStyle.Information, "Warning")
        End If

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        LoginBARU.Show()
    End Sub

    Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUser()
    End Sub

    Private Sub MenuUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnProfil_Click(sender As Object, e As EventArgs) Handles BtnProfil.Click
        Me.Hide()
        Profil.Show()
    End Sub
End Class