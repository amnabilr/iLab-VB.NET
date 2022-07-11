Imports System.Data.Odbc
Public Class FormTransaksiPembelian
    Dim TglMySQL As String
    Sub KondisiAwal()
        LabelNamaSupplier.Text = ""
        LabelAlamat.Text = ""
        LabelTelepon.Text = ""
        LabelTanggal.Text = Today
        LabelAdmin.Text = FormMenuUtama.IsiLabelNama.Text
        LabelKembali.Text = ""
        LBLHargaBarang.Text = ""
        LBLNamaBarang.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        Call MunculKodeSupplier()
        Call NomorOtomatis()
        Call BuatKolom()
        Label8.Text = "0"
        TextBox1.Text = ""
    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tabel_beli where nomorbeli in(select max(nomorbeli) from tabel_beli)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "TR" + Format(Now, "ddMMyy") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "TR" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LabelNoBeli.Text = UrutanKode
    End Sub

    Sub MunculKodeSupplier()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tabel_supplier", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop

    End Sub

    Private Sub FormTransaksiPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelJam.Text = TimeOfDay
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tabel_supplier where kodesupplier = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LabelNamaSupplier.Text = Rd!NamaSupplier
            LabelAlamat.Text = Rd!AlamatSupplier
            LabelTelepon.Text = Rd!TeleponSupplier
        End If
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tabel_barang where kodebarang='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Barang Tidak Tersedia")
            Else
                TextBox2.Text = Rd.Item("kodebarang")
                LBLNamaBarang.Text = Rd.Item("namabarang")
                LBLHargaBarang.Text = Rd.Item("hargabarang")
                TextBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LBLNamaBarang.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan Masukkan Kode Barang dan Tekan ENTER!")
        Else
            DataGridView1.Rows.Add(New String() {TextBox2.Text, LBLNamaBarang.Text, LBLHargaBarang.Text, TextBox3.Text, Val(LBLHargaBarang.Text) * Val(TextBox3.Text)})
            Call RumusSubtotal()
            LBLHargaBarang.Text = ""
            LBLNamaBarang.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Enabled = False
            Call RumusCariItem()
        End If
    End Sub

    Sub RumusSubtotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(4).Value
            Label8.Text = Hitung
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label8.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox1.Text) = Val(Label8.Text) Then
                LabelKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label8.Text) Then
                LabelKembali.Text = Val(TextBox1.Text) - Val(Label8.Text)
                Btn_Simpan.Focus()
            End If
        End If
    End Sub

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LabelItem.Text = HitungItem

        Next
    End Sub

    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If LabelKembali.Text = "" Or LabelNamaSupplier.Text = "" Or Label8.Text = "" Then
            MsgBox("Transaksi Tidak Ada! Silahkan Lakukan Transaksi Terlebih Dahulu.")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanDataPembelian As String = "Insert into tabel_beli values('" & LabelNoBeli.Text & "','" & TglMySQL & "', '" & LabelJam.Text & "', '" & LabelItem.Text & "', '" & Label8.Text & "', '" & TextBox1.Text & "', '" & LabelKembali.Text & "', '" & ComboBox1.Text & "', '" & FormMenuUtama.IsiLabelKode.Text & "')"
            Cmd = New OdbcCommand(SimpanDataPembelian, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetailPembelian As String = "Insert into tabel_detailpembelian values('" & LabelNoBeli.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetailPembelian, Conn)
                Cmd.ExecuteNonQuery()

                Cmd = New OdbcCommand("Select * From tabel_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim KurangiStok As String = "Update tabel_barang set JumlahBarang = '" & Rd.Item("JumlahBarang") - DataGridView1.Rows(Baris).Cells(3).Value & "' where kodebarang = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Berhasil Disimpan")
        End If
    End Sub

    Private Sub Btn_Batal_Click(sender As Object, e As EventArgs) Handles Btn_Batal.Click
        Call KondisiAwal()
    End Sub

    Private Sub Btn_Tutup_Click(sender As Object, e As EventArgs) Handles Btn_Tutup.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class