Imports MySql.Data.MySqlClient
Public Class Profil
    Sub DisplayProfil()
        Call Konn()
        Dim Sql As String = "Select * From users Where id_user =" & LoginBARU.id_user & ""
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        LNama.Text = DR("Nama")
        Lusername.Text = DR("username")
        LAlamat.Text = DR("Alamat")
        Dim filename As String = DR("Gambar")
        Dim location As String = "D:\clonee\Gambar\" & filename & ""
        PictureBox2.Image = Image.FromFile(location)
    End Sub
    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProfil()
    End Sub

    Private Sub Profil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuUser.Show()
    End Sub
End Class