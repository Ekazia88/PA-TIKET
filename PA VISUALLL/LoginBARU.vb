Imports MySql.Data.MySqlClient

Public Class LoginBARU
    Public id_user As Integer
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpass.Text = ""
        txtuser.Text = ""
        txtpass.PasswordChar = "*"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" And txtpass.Text = "" Then
            MsgBox("Field Harus diisi!", MsgBoxStyle.Information, "Warning")
        Else
            Call Konn()
            Dim Sql As String = "Select * From users where username = '" & txtuser.Text & "'and password ='" & txtpass.Text & "'"
            CMD = New MySqlCommand(Sql, CONN)
            DR = CMD.ExecuteReader()
            DR.Read()
            If DR.HasRows Then
                If DR("level") = "admin" Then
                    Me.Hide()
                    FormMenuAdmin.Show()
                ElseIf DR("level") = "customer" Then
                    id_user = DR("id_user")
                    Me.Hide()
                    MenuUser.Show()
                End If
            Else
                MessageBox.Show("Invalid Username Or Password")
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        FormRegistrasi.Show()
    End Sub

    Private Sub bntexit_Click(sender As Object, e As EventArgs) Handles bntexit.Click
        Application.Exit()
    End Sub


End Class