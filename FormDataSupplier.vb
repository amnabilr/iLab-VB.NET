Imports System.Data.Odbc
Public Class FormDataSupplier
    Sub KondisiAwal()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False

        Button_Input.Enabled = True
        Button_Edit.Enabled = True
        Button_Hapus.Enabled = True

        Button_Input.Text = "Input"
        Button_Edit.Text = "Edit"
        Button_Hapus.Text = "Hapus"
        Button_Tutup.Text = "Tutup"

        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tabel_supplier", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tabel_supplier")
        DataGridView1.DataSource = Ds.Tables("tabel_supplier")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormDataSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Private Sub Button_Input_Click(sender As Object, e As EventArgs) Handles Button_Input.Click
        If Button_Input.Text = "Input" Then
            Button_Input.Text = "Simpan"
            Button_Edit.Enabled = False
            Button_Hapus.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Supplier!")
            Else
                Call Koneksi()
                Dim InputData As String = "insert into tabel_supplier values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If Button_Edit.Text = "Edit" Then
            Button_Edit.Text = "Simpan"
            Button_Input.Enabled = False
            Button_Hapus.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Supplier!")
            Else
                Call Koneksi()
                Dim UpdateData As String = "update tabel_supplier set namasupplier='" & TextBox2.Text & "', alamatsupplier='" & TextBox3.Text & "',teleponsupplier='" & TextBox4.Text & "' where kodesupplier='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tabel_supplier where kodesupplier='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Supplier Tidak Tersedia")
            Else
                TextBox1.Text = Rd.Item("kodesupplier")
                TextBox2.Text = Rd.Item("namapsupplier")
                TextBox3.Text = Rd.Item("alamatsupplier")
                TextBox4.Text = Rd.Item("teleponsupplier")
            End If
        End If
    End Sub

    Private Sub Button_Tutup_Click(sender As Object, e As EventArgs) Handles Button_Tutup.Click
        If Button_Tutup.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        If Button_Hapus.Text = "Hapus" Then
            Button_Hapus.Text = "Delete"
            Button_Input.Enabled = False
            Button_Edit.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Supplier!")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tabel_supplier where kodesupplier='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tabel_supplier where kodesupplier in(select max(kodesupplier)from tabel_supplier)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "SUP" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "SUP" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class