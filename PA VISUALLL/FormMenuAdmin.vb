Public Class FormMenuAdmin
    Private Sub FormMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Hide()
        LoginBARU.Show()
    End Sub

    Private Sub LihatDataPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataPesananToolStripMenuItem.Click
        Me.Hide()
        LihatDataPesanan.Show()
    End Sub

    Private Sub ManajemenDataMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenDataMobilToolStripMenuItem.Click
        Me.Hide()
        ManajemenDataMobil.Show()
    End Sub

    Private Sub AkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkunToolStripMenuItem.Click
        Me.Hide()
        LihatDataAkun.Show()
    End Sub

    Private Sub FormMenuAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
