Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporanTahunan
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormLaporanTahunan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Cmd = New OdbcCommand("Select distinct year(tanggaljual) As tahun From tabel_jual", Conn)
        Rd = Cmd.ExecuteReader
        CBTahun.Items.Add("Pilih")
        CBTahun.SelectedIndex = 0
        While Rd.Read()
            CBTahun.Items.Add(Rd.Item("tahun"))
        End While
    End Sub

    Private Sub CBTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTahun.SelectedIndexChanged
        If CBTahun.SelectedIndex = 0 Then
            CrystalReportViewer1.ReportSource = Nothing
            Exit Sub
        Else
            Dim LaporanTahunan As New ReportDocument
            LaporanTahunan.Load("F:\Documents\AplikasiPenjualan\AplikasiPenjualan\LaporanTahunan.rpt")
            LaporanTahunan.SetParameterValue("Tahunnya", CBTahun.Text)
            CrystalReportViewer1.ReportSource = LaporanTahunan
            CrystalReportViewer1.Refresh()
        End If
    End Sub
End Class