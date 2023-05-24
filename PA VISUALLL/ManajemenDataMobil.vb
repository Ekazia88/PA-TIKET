Imports MySql.Data.MySqlClient
Public Class ManajemenDataMobil
    Dim idxRow As Integer
    Dim id As Integer
    Sub Status()
        CbStatus.Items.Add("Berangkat")
        CbStatus.Items.Add("Kosong")
        CbStatus.Items.Add("Dalam Perbaikan")
    End Sub
    Private Sub ManajemenDataMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konn()
        Status()
        Display_Data()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtMerk.Text = "" And TxtMuatan.Text = "" And Txtplat.Text = "" And CbStatus.Text = "" Then
            MsgBox("Data Harus Diisi!", MsgBoxStyle.Information, "Warning")
        Else
            Dim Sql As String = "Insert Into datamobil(id_mobil,Nama_mobil,Plat_Mobil,Jumlah_Kursi,status_mobil) values('','" & TxtMerk.Text & "','" & Txtplat.Text & "','" & TxtMuatan.Text & "','" & CbStatus.Text & "')"
            CMD = New MySqlCommand(Sql, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information, "Success")
            Display_Data()
        End If
    End Sub

    Sub Display_Data()
        DA = New MySqlDataAdapter("Select * from datamobil", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "datamobil")
        DataMobil.DataSource = DS.Tables("datamobil")
        DataMobil.Refresh()
    End Sub

    Private Sub DataMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataMobil.CellClick
        Dim selectedRow As DataGridViewRow
        selectedRow = DataMobil.Rows(e.RowIndex)
        idxRow = e.RowIndex
        id = selectedRow.Cells(0).Value
        TxtMerk.Text = selectedRow.Cells(1).Value
        Txtplat.Text = selectedRow.Cells(2).Value
        TxtMuatan.Text = selectedRow.Cells(3).Value
        CbStatus.Text = selectedRow.Cells(4).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtMerk.Text = "" And TxtMuatan.Text = "" And Txtplat.Text = "" And CbStatus.Text = "" Then
            MsgBox("Data Harus Diisi!", MsgBoxStyle.Information, "Warning")
        Else
            Dim Sql As String = "Update datamobil set Nama_mobil = '" & TxtMerk.Text & "',Plat_Mobil= '" & Txtplat.Text & "',Jumlah_Kursi ='" & TxtMuatan.Text & "',status_mobil ='" & CbStatus.Text & "' where id_mobil =" & id & ""
            CMD = New MySqlCommand(Sql, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Update Data Berhasil!", MsgBoxStyle.Information, "Success")
            Display_Data()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtMerk.Text = "" And TxtMuatan.Text = "" And Txtplat.Text = "" And CbStatus.Text = "" Then
            MsgBox("Data Harus Diisi!", MsgBoxStyle.Information, "Warning")
        Else
            Dim Sql As String = "Delete FROM datamobil where id_mobil =" & id & ""
            CMD = New MySqlCommand(Sql, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil!", MsgBoxStyle.Information, "Success")
            Display_Data()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtMerk.Text = ""
        TxtMuatan.Text = ""
        Txtplat.Text = ""
        CbStatus.Text = ""
    End Sub

    Private Sub ManajemenDataMobil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormMenuAdmin.Show()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim QuerySearch As String = "Select * From datamobil where Nama_mobil like'" & TxtCari.Text & "%' or Plat_Mobil like'" & TxtCari.Text & "%' or Jumlah_Kursi like '" & TxtCari.Text & "%' or status_mobil like '" & TxtCari.Text & "%'"
        DA = New MySqlDataAdapter(QuerySearch, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "datamobil")
        DataMobil.DataSource = DS.Tables("datamobil")
        DataMobil.Refresh()
    End Sub

    Private Sub TxtMuatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMuatan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStatus.SelectedIndexChanged

    End Sub
End Class