<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanTahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelKode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IsiLabelKode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelNama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IsiLabelNama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IsiLabelLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IsiLabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IsiLabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.BarangToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanHarianToolStripMenuItem, Me.PenjualanBulananToolStripMenuItem, Me.PenjualanTahunanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PenjualanHarianToolStripMenuItem
        '
        Me.PenjualanHarianToolStripMenuItem.Name = "PenjualanHarianToolStripMenuItem"
        Me.PenjualanHarianToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PenjualanHarianToolStripMenuItem.Text = "Penjualan Harian"
        '
        'PenjualanBulananToolStripMenuItem
        '
        Me.PenjualanBulananToolStripMenuItem.Name = "PenjualanBulananToolStripMenuItem"
        Me.PenjualanBulananToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PenjualanBulananToolStripMenuItem.Text = "Penjualan Bulanan"
        '
        'PenjualanTahunanToolStripMenuItem
        '
        Me.PenjualanTahunanToolStripMenuItem.Name = "PenjualanTahunanToolStripMenuItem"
        Me.PenjualanTahunanToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PenjualanTahunanToolStripMenuItem.Text = "Penjualan Tahunan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelKode, Me.IsiLabelKode, Me.LabelNama, Me.IsiLabelNama, Me.LabelLevel, Me.IsiLabelLevel, Me.LabelJam, Me.IsiLabelJam, Me.LabelTanggal, Me.IsiLabelTanggal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelKode
        '
        Me.LabelKode.Name = "LabelKode"
        Me.LabelKode.Size = New System.Drawing.Size(40, 17)
        Me.LabelKode.Text = "Kode :"
        '
        'IsiLabelKode
        '
        Me.IsiLabelKode.Name = "IsiLabelKode"
        Me.IsiLabelKode.Size = New System.Drawing.Size(119, 17)
        Me.IsiLabelKode.Text = "ToolStripStatusLabel2"
        '
        'LabelNama
        '
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(48, 17)
        Me.LabelNama.Text = "Nama : "
        '
        'IsiLabelNama
        '
        Me.IsiLabelNama.Name = "IsiLabelNama"
        Me.IsiLabelNama.Size = New System.Drawing.Size(119, 17)
        Me.IsiLabelNama.Text = "ToolStripStatusLabel4"
        '
        'LabelLevel
        '
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(43, 17)
        Me.LabelLevel.Text = "Level : "
        '
        'IsiLabelLevel
        '
        Me.IsiLabelLevel.Name = "IsiLabelLevel"
        Me.IsiLabelLevel.Size = New System.Drawing.Size(119, 17)
        Me.IsiLabelLevel.Text = "ToolStripStatusLabel6"
        '
        'LabelJam
        '
        Me.LabelJam.Name = "LabelJam"
        Me.LabelJam.Size = New System.Drawing.Size(37, 17)
        Me.LabelJam.Text = "Jam : "
        '
        'IsiLabelJam
        '
        Me.IsiLabelJam.Name = "IsiLabelJam"
        Me.IsiLabelJam.Size = New System.Drawing.Size(119, 17)
        Me.IsiLabelJam.Text = "ToolStripStatusLabel8"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(57, 17)
        Me.LabelTanggal.Text = "Tanggal : "
        '
        'IsiLabelTanggal
        '
        Me.IsiLabelTanggal.Name = "IsiLabelTanggal"
        Me.IsiLabelTanggal.Size = New System.Drawing.Size(125, 15)
        Me.IsiLabelTanggal.Text = "ToolStripStatusLabel10"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanHarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanBulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelKode As ToolStripStatusLabel
    Friend WithEvents IsiLabelKode As ToolStripStatusLabel
    Friend WithEvents LabelNama As ToolStripStatusLabel
    Friend WithEvents IsiLabelNama As ToolStripStatusLabel
    Friend WithEvents LabelLevel As ToolStripStatusLabel
    Friend WithEvents IsiLabelLevel As ToolStripStatusLabel
    Friend WithEvents LabelJam As ToolStripStatusLabel
    Friend WithEvents IsiLabelJam As ToolStripStatusLabel
    Friend WithEvents LabelTanggal As ToolStripStatusLabel
    Friend WithEvents IsiLabelTanggal As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PenjualanTahunanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
End Class
