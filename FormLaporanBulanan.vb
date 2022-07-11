Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanBulanan
    Private Sub FormLaporanBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Cmd = New OdbcCommand("select distinct month(tanggaljual) as bulan from tabel_jual", Conn)
        Rd = Cmd.ExecuteReader
        CBBulan.Items.Add("Pilih")
        CBBulan.SelectedIndex = 0
        While Rd.Read()
            CBBulan.Items.Add(Rd.Item("bulan"))
        End While

    End Sub

    Private Sub CBBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBulan.SelectedIndexChanged
        If CBBulan.SelectedIndex = 0 Then
            CrystalReportViewer1.ReportSource = Nothing
            Exit Sub
        Else
            Dim LaporanH As New ReportDocument
            LaporanH.Load("F:\Documents\AplikasiPenjualan\AplikasiPenjualan\LaporanBulanan.rpt")
            LaporanH.SetParameterValue("Bulannya", CBBulan.Text)
            CrystalReportViewer1.ReportSource = LaporanH
            CrystalReportViewer1.Refresh()
        End If
    End Sub
End Class