Imports System.Data.Odbc
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub lgn()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tabel_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.IsiLabelKode.Text = Rd!KodeAdmin
                FormMenuUtama.IsiLabelNama.Text = Rd!NamaAdmin
                FormMenuUtama.IsiLabelLevel.Text = Rd!LevelAdmin
            Else
                MsgBox("Kode Admin atau Password Salah!")
            End If
        End If
    End Sub
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Call lgn()
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call lgn()
        End If
    End Sub
End Class