Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Pesanan sedang kami proses", "Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim konfirmasi As String
        konfirmasi = MessageBox.Show("Batalkan pesanan anda?", "Pesanan dibatalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class