Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanHarian
    Private Sub FormLaporanHarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Cmd = New OdbcCommand("select distinct tanggaljual as tanggal from tabel_jual", Conn)
        Rd = Cmd.ExecuteReader
        CBHari.Items.Add("Pilih")
        CBHari.SelectedIndex = 0
        While Rd.Read()
            CBHari.Items.Add(Rd.Item("tanggal"))
        End While
    End Sub

    Private Sub CBHari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBHari.SelectedIndexChanged
        If CBHari.SelectedIndex = 0 Then
            CrystalReportViewer1.ReportSource = Nothing
            Exit Sub
        Else
            Dim LaporanPenjualan As New ReportDocument
            LaporanPenjualan.Load("F:\Documents\AplikasiPenjualan\AplikasiPenjualan\LaporanHarian.rpt")
            LaporanPenjualan.SetParameterValue("Harinya", CBHari.Text)
            CrystalReportViewer1.ReportSource = LaporanPenjualan
            CrystalReportViewer1.Refresh()
        End If
    End Sub
End Class