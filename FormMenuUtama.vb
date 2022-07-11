Public Class FormMenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        IsiLabelTanggal.Text = Today
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        FormDataAdmin.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FormDataPelanggan.Show()
    End Sub
    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormDataBarang.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IsiLabelJam.Text = TimeOfDay
    End Sub
    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormTransaksiPenjualan.Show()
    End Sub

    Private Sub PenjualanHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanHarianToolStripMenuItem.Click
        FormLaporanHarian.Show()
    End Sub

    Private Sub PenjualanBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanBulananToolStripMenuItem.Click
        FormLaporanBulanan.Show()
    End Sub

    Private Sub PenjualanTahunanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanTahunanToolStripMenuItem.Click
        FormLaporanTahunan.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        FormDataSupplier.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FormTransaksiPembelian.Show()
    End Sub
End Class
