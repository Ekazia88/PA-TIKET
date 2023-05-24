Imports MySql.Data.MySqlClient
Public Class Form_Pemesanan
    Dim Jml_kursi As Integer
    Dim jml_orang As Integer
    Dim hasil As Integer
    Dim idm As Integer
    Dim Tgl As DateTime
    Sub Daerah()
        Cbke.Items.Add("Berau")
        Cbke.Items.Add("Samarinda")
        Cbke.Items.Add("Balikpapan")
        Cbke.Items.Add("Tanah Grogot")
        Cbke.Items.Add("Bontang")

        CbDari.Items.Add("Berau")
        CbDari.Items.Add("Samarinda")
        CbDari.Items.Add("Balikpapan")
        CbDari.Items.Add("Tanah Grogot")
        CbDari.Items.Add("Bontang")
    End Sub
    Sub DataMobil()
        Call Konn()
        Dim Sql As String = "Select * from datamobil where status_mobil= 'Kosong'   "
        CMD = New MySqlCommand(Sql, CONN)
        DA = New MySqlDataAdapter(CMD)
        Dim dt As DataTable = New DataTable()
        DA.Fill(dt)
        CbMobil.DataSource = dt
        CbMobil.DisplayMember = "Nama_Mobil"
        CbMobil.ValueMember = "id_mobil"
    End Sub
    Sub Tambah()
        idm = CbMobil.SelectedValue.ToString()
        Call Konn()
        Dim Sql As String = "Select * from datamobil where id_mobil ='" & idm & "'"
        CMD = New MySqlCommand(Sql, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        Jml_kursi = DR("Jumlah_Kursi")
        Dim Status As String = DR("status_mobil")

        Call Konn()
        Dim Sql3 As String = "Select Dari,Tujuan,Tanggal_pergi,sum(jumlah_kursi) As jml from pesanan where id_mobil ='" & CbMobil.SelectedValue & "'"
        CMD = New MySqlCommand(Sql3, CONN)
        DR = CMD.ExecuteReader()
        DR.Read()
        If DR.IsDBNull(0) Then
            jml_orang = 0
            Call Konn()
            Dim cmdsql As New MySqlCommand("insert into pesanan(id_pesan,id_customer,Dari,Tujuan,Harga_total,Jumlah_kursi,Tanggal_Pergi,id_mobil) values ('',@idcus,@dari,@tujuan,@hargatotal,@jumlah_kursi,@TanggalPergi,@id_mobil)", CONN)
            cmdsql.Parameters.Add("@idcus", MySqlDbType.Int32).Value = LoginBARU.id_user
            cmdsql.Parameters.Add("@dari", MySqlDbType.VarChar).Value = CbDari.Text
            cmdsql.Parameters.Add("@tujuan", MySqlDbType.VarChar).Value = Cbke.Text
            cmdsql.Parameters.Add("@hargatotal", MySqlDbType.Int32).Value = hasil
            cmdsql.Parameters.Add("@jumlah_kursi", MySqlDbType.Int32).Value = TxtJml.Text
            cmdsql.Parameters.Add("@TanggalPergi", MySqlDbType.DateTime).Value = DateTimePicker1.Value
            cmdsql.Parameters.Add("@id_mobil", MySqlDbType.Int32).Value = idm
            cmdsql.ExecuteNonQuery()
            MsgBox("Anda Berhasil Pesan", MsgBoxStyle.Information, "Warning")
        Else
            Tgl = DR("Tanggal_pergi")
            Dim datex As DateTime = Tgl.Date
            jml_orang = DR("jml")
            Dim Dari As String = DR("Dari").ToString()
            Dim Ke As String = DR("Tujuan").ToString()
            Dim SelectedDari As String = CbDari.SelectedItem.ToString()
            Dim SelectedKe As String = Cbke.SelectedItem.ToString()
            If jml_orang >= Jml_kursi And Status = "Kosong" Then
                MsgBox("Mobil Sudah Penuh!", MsgBoxStyle.Information, "Warning")
            ElseIf Dari <> SelectedKe And Ke <> SelectedKe Then

                MsgBox("Mobil Berbeda Arah Tujuan, Silahkan Pilih Mobil Yang Lain", MsgBoxStyle.Information, "Warning")
            ElseIf DateTimePicker1.Value.Date <> datex Then
                MsgBox("Mobil Ini berangkat pada tanggal" & Tgl & "", MsgBoxStyle.Information, "Warning")
            Else
                Call Konn()
                Dim cmdsql As New MySqlCommand("insert into pesanan(id_pesan,id_customer,Dari,Tujuan,Harga_total,Jumlah_kursi,Tanggal_Pergi,id_mobil) values ('',@idcus,@dari,@tujuan,@hargatotal,@jumlah_kursi,@TanggalPergi,@id_mobil)", CONN)
                cmdsql.Parameters.Add("@idcus", MySqlDbType.Int32).Value = LoginBARU.id_user
                cmdsql.Parameters.Add("@dari", MySqlDbType.VarChar).Value = CbDari.Text
                cmdsql.Parameters.Add("@tujuan", MySqlDbType.VarChar).Value = Cbke.Text
                cmdsql.Parameters.Add("@hargatotal", MySqlDbType.Int32).Value = hasil
                cmdsql.Parameters.Add("@jumlah_kursi", MySqlDbType.Int32).Value = TxtJml.Text
                cmdsql.Parameters.Add("@TanggalPergi", MySqlDbType.DateTime).Value = DateTimePicker1.Value
                cmdsql.Parameters.Add("@id_mobil", MySqlDbType.Int32).Value = idm
                cmdsql.ExecuteNonQuery()
                MsgBox("Anda Berhasil Pesan", MsgBoxStyle.Information, "Warning")
            End If
        End If
    End Sub
    Private Sub Form_Pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataMobil()
        Daerah()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim currentDateTime As DateTime = DateTime.Now
        If currentDateTime > DateTimePicker1.Value Then
            MsgBox("Anda Bisa Memesan Tiket Mulai hari ini", MsgBoxStyle.Information, "Warning")
        End If

    End Sub

    Private Sub CbDari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDari.SelectedIndexChanged
        If CbDari.SelectedItem = Cbke.SelectedItem Then
            MsgBox("Daerah Sudah Dipilih", MsgBoxStyle.Information, "Warning")
        End If
    End Sub

    Private Sub Cbke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbke.SelectedIndexChanged
        If Cbke.SelectedItem = CbDari.SelectedItem Then
            MsgBox("Daerah Sudah Dipilih", MsgBoxStyle.Information, "Warning")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtJml.Text = ""
        CbDari.Text = ""
        Cbke.Text = ""
        CbMobil.Text = ""
    End Sub

    Private Sub TxtJml_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJml.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Exit Sub
        End If
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If TxtJml.Text.Length >= 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtJml_TextChanged(sender As Object, e As EventArgs) Handles TxtJml.TextChanged
        If TxtJml.Text = "" Then
            TxtJml.Text = 0
        End If
        hasil = TxtJml.Text * 180000
        LTotal.Text = "Rp. " & hasil.ToString()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        MenuUser.Show()
    End Sub

    Private Sub BtnPesan_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click
        Tambah()
    End Sub



    Private Sub Form_Pemesanan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class