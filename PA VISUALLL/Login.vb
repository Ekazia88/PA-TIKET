Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konn()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Sql As String = "Select * From users where username = '" & txtuser.Text & "'and password ='" & txtpass.Text & "'"
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        If DR.HasRows Then
            If DR("level") = "admin" Then
                Me.Hide()
                FormMenuAdmin.Show()
            End If
        Else
            MessageBox.Show("Invalid Username Or Password")
        End If
    End Sub
End Class