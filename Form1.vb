Public Class Form1
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Deklarasi konstanta 

    Const pajak As Decimal = 0.1D 'persen pajak 10%
    Const roti_putih As Decimal = 12000D 'Biaya roti tawar putih
    Const roti_gandum As Decimal = 15000D 'Biaya roti gandum
    Const roti_pandan As Decimal = 15000D 'Biaya roti pandan
    Const roti_charcoal As Decimal = 20000D 'Biaya roti chorcoal
    Const top_cokelat As Decimal = 7000D 'Biaya topping cokelat
    Const top_keju As Decimal = 9000D 'Biaya topping keju
    Const top_strawberry As Decimal = 5000D 'Biaya topping strawberry
    Const top_blueberry As Decimal = 5000D 'Biaya topping blueberry
    Const top_greentea As Decimal = 9000D 'Biaya topping greentea
    Const top_icecreamvanilla As Decimal = 10000D 'Biaya topping ice cream vanilla
    Const kopisusu As Decimal = 12000D 'Biaya minuman kopi susu
    Const kopihitam As Decimal = 9000D 'Biaya minuman kopi hitam
    Const tehtarik As Decimal = 10000D 'Biaya minuman teh tarik
    Const milkshake As Decimal = 18000D 'Biaya minuman milkshake

    Function HitungBiayaRoti() As Decimal
        'Function untuk menghitung harga roti
        Dim hit_roti As Decimal
        If radPutih.Checked = True Then
            hit_roti = roti_putih
        ElseIf radGandum.Checked = True Then
            hit_roti = roti_gandum
        ElseIf radPandan.Checked = True Then
            hit_roti = roti_pandan
        ElseIf radCharcoal.Checked = True Then
            hit_roti = roti_charcoal
        End If
        Return hit_roti
    End Function

    Function HitungBiayaTopping() As Decimal
        'Fungsi ini menghasilkan biaya dari topping
        Dim hit_topping As Decimal = 0D
        If chkCokelat.Checked = True Then
            hit_topping += top_cokelat
        End If
        If chkKeju.Checked = True Then
            hit_topping += top_keju
        End If
        If chkStrawberry.Checked = True Then
            hit_topping += top_strawberry
        End If
        If chkBlueberry.Checked = True Then
            hit_topping += top_blueberry
        End If
        If chkGreentea.Checked = True Then
            hit_topping += top_greentea
        End If
        If chkIcecream.Checked = True Then
            hit_topping += top_icecreamvanilla
        End If
        Return hit_topping
    End Function

    Function HitungBiayaMinum() As Decimal
        'Funsi untuk menghasilkan biaya minum
        Dim hit_minum As Decimal
        If radKopSus.Checked = True Then
            hit_minum = kopisusu
        ElseIf radKopHit.Checked = True Then
            hit_minum = kopihitam
        ElseIf radTehTar.Checked = True Then
            hit_minum = tehtarik
        ElseIf radMilkshake.Checked = True Then
            hit_minum = milkshake
        End If
        Return hit_minum
    End Function
    Sub ResetRoti()
        'Prosedur ini mengatur ulang setiap radio button jenis roti menjadi nilai awal
        radPutih.Checked = True
    End Sub

    Sub ResetTopping()
        'Prosedur ini membatalkan centang semua checkbox 
        chkCokelat.Checked = False
        chkKeju.Checked = False
        chkStrawberry.Checked = False
        chkBlueberry.Checked = False
        chkGreentea.Checked = False
        chkIcecream.Checked = False
    End Sub

    Sub ResetMinum()
        'Prosedur ini mengatur ulang setiap radio button topping menjadi nilai awal
        radKopSus.Checked = False
        radKopHit.Checked = False
        radTehTar.Checked = False
        radMilkshake.Checked = False
    End Sub

    Sub ResetHarga()
        'Prosedur ini mengatur ulanga harga harga
        lblSubtotal.Text = String.Empty
        lblPajak.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        'Prosedur untuk menghitung biaya total dari pesanan
        Dim hit_subtotal As Decimal 'Menampung biaya subtotal
        Dim hit_pajak As Decimal 'Menampung biaya pajak
        Dim hit_total As Decimal 'Menampung biaya total pemesanan

        hit_subtotal = HitungBiayaRoti() + HitungBiayaTopping() + HitungBiayaMinum()
        hit_pajak = HitungPajak(hit_subtotal)
        hit_total = hit_subtotal + hit_pajak

        lblSubtotal.Text = "Rp. " & hit_subtotal.ToString()
        lblPajak.Text = "Rp. " & hit_pajak.ToString()
        lblTotal.Text = "Rp. " & hit_total.ToString()

    End Sub
    Function HitungPajak(ByVal subtotal As Single) As Decimal
        Return pajak * subtotal
    End Function
    Private Sub tombolReset_Click(sender As Object, e As EventArgs) Handles tombolReset.Click
        'Prosedur untuk mengatur-ulang setiap nilai pada kontrol menjadi default
        Call ResetRoti()
        Call ResetTopping()
        Call ResetMinum()
        Call ResetHarga()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
