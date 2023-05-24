Imports MySql.Data.MySqlClient
Public Class LihatDataPesanan
    Dim id As Integer
    Sub Display_Data()
        DA = New MySqlDataAdapter("Select * from pesanan join users on users.id_user = pesanan.id_customer join datamobil on datamobil.id_mobil = pesanan.id_mobil", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pesanan")
        Datapesanan.DataSource = DS.Tables("pesanan")
        Datapesanan.Refresh()
    End Sub
    Private Sub LihatDataPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konn()
        Display_Data()
    End Sub



    Private Sub LihatDataPesanan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim QuerySearch As String = "Select * From Pesanan join users on users.id_user = pesanan.id_customer join datamobil on datamobil.id_mobil = pesanan.id_mobil where Nama_mobil like'" & TxtCari.Text & "%'or Nama like '" & TxtCari.Text & "%' or Dari like '" & TxtCari.Text & "%' or Tujuan like '" & TxtCari.Text & "%'"
        DA = New MySqlDataAdapter(QuerySearch, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pesanan")
        Datapesanan.DataSource = DS.Tables("pesanan")
        Datapesanan.Refresh()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        FormMenuAdmin.Show()
    End Sub

    Private Sub Datapesanan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Datapesanan.CellMouseClick
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = Datapesanan.Rows(e.RowIndex)
            id = selectedRow.Cells(0).Value
            Datapesanan.ClearSelection()
            Datapesanan.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub HapusDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim Sql As String = "Delete FROM pesanan where id_pesan =" & id & ""
            CMD = New MySqlCommand(Sql, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil!", MsgBoxStyle.Information, "Success")
            Display_Data()
        ElseIf result = DialogResult.No Then
            Return
        End If
    End Sub
End Class