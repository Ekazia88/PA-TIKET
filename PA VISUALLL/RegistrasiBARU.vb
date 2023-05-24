Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormRegistrasi
    Dim location As String
    Dim filename As String
    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPassword.PasswordChar = "*"
    End Sub
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Call Konn()
        Dim Sql As String = "Select * From users where username = '" & TxtUsername.Text & "'"
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        If DR.HasRows Then
            MsgBox("Username Sudah Ada!")
        Else
            Call Konn()
            Dim Sql2 As String = "Insert Into users(id_user,username,password,Nama,Alamat,Gambar,level) values('','" & TxtUsername.Text & "','" & TxtPassword.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & filename & "','customer')"
            PictureBox1.Image.Save("D:\clonee\Gambar\" & filename & "")
            CMD = New MySqlCommand(Sql2, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Registrasi Berhasil", MsgBoxStyle.Information, "Warning")
            Me.Hide()
            LoginBARU.Show()
        End If

    End Sub

    Private Sub BtnPhoto_Click(sender As Object, e As EventArgs) Handles BtnPhoto.Click
        OpenFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            filename = Path.GetFileName(OpenFileDialog1.FileName)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub FormRegistrasi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class