<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.radPutih = New System.Windows.Forms.RadioButton()
        Me.radGandum = New System.Windows.Forms.RadioButton()
        Me.radPandan = New System.Windows.Forms.RadioButton()
        Me.radCharcoal = New System.Windows.Forms.RadioButton()
        Me.chkCokelat = New System.Windows.Forms.CheckBox()
        Me.chkKeju = New System.Windows.Forms.CheckBox()
        Me.chkStrawberry = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkGreentea = New System.Windows.Forms.CheckBox()
        Me.chkIcecream = New System.Windows.Forms.CheckBox()
        Me.radKopSus = New System.Windows.Forms.RadioButton()
        Me.radKopHit = New System.Windows.Forms.RadioButton()
        Me.radTehTar = New System.Windows.Forms.RadioButton()
        Me.radMilkshake = New System.Windows.Forms.RadioButton()
        Me.tombolHitung = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPajak = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roti Bakar XYZ"
        '
        'ToolTip1
        '
        '
        'radPutih
        '
        Me.radPutih.AutoSize = True
        Me.radPutih.Checked = True
        Me.radPutih.Location = New System.Drawing.Point(16, 15)
        Me.radPutih.Name = "radPutih"
        Me.radPutih.Size = New System.Drawing.Size(163, 17)
        Me.radPutih.TabIndex = 1
        Me.radPutih.TabStop = True
        Me.radPutih.Text = "Roti Tawar Putih (Rp. 12000)"
        Me.ToolTip1.SetToolTip(Me.radPutih, "Klik disini untuk memilih Roti Tawar Putih")
        Me.radPutih.UseVisualStyleBackColor = True
        '
        'radGandum
        '
        Me.radGandum.AutoSize = True
        Me.radGandum.Location = New System.Drawing.Point(16, 38)
        Me.radGandum.Name = "radGandum"
        Me.radGandum.Size = New System.Drawing.Size(146, 17)
        Me.radGandum.TabIndex = 2
        Me.radGandum.Text = "Roti Gandum (Rp. 15000)"
        Me.ToolTip1.SetToolTip(Me.radGandum, "Klik disini untuk memilih Roti Gandum")
        Me.radGandum.UseVisualStyleBackColor = True
        '
        'radPandan
        '
        Me.radPandan.AutoSize = True
        Me.radPandan.Location = New System.Drawing.Point(16, 61)
        Me.radPandan.Name = "radPandan"
        Me.radPandan.Size = New System.Drawing.Size(176, 17)
        Me.radPandan.TabIndex = 3
        Me.radPandan.Text = "Roti Tawar Pandan (Rp. 15000)"
        Me.ToolTip1.SetToolTip(Me.radPandan, "Klik disini untuk memilih Roti Tawar Pandan")
        Me.radPandan.UseVisualStyleBackColor = True
        '
        'radCharcoal
        '
        Me.radCharcoal.AutoSize = True
        Me.radCharcoal.Location = New System.Drawing.Point(16, 84)
        Me.radCharcoal.Name = "radCharcoal"
        Me.radCharcoal.Size = New System.Drawing.Size(181, 17)
        Me.radCharcoal.TabIndex = 4
        Me.radCharcoal.Text = "Roti Tawar Charcoal (Rp. 20000)"
        Me.ToolTip1.SetToolTip(Me.radCharcoal, "Klik disini untuk memilih Roti Tawar Charcoal")
        Me.radCharcoal.UseVisualStyleBackColor = True
        '
        'chkCokelat
        '
        Me.chkCokelat.AutoSize = True
        Me.chkCokelat.Location = New System.Drawing.Point(15, 13)
        Me.chkCokelat.Name = "chkCokelat"
        Me.chkCokelat.Size = New System.Drawing.Size(115, 17)
        Me.chkCokelat.TabIndex = 6
        Me.chkCokelat.Text = "Cokelat (Rp. 7000)"
        Me.ToolTip1.SetToolTip(Me.chkCokelat, "Klik disini untuk memilih Topping Cokelat")
        Me.chkCokelat.UseVisualStyleBackColor = True
        '
        'chkKeju
        '
        Me.chkKeju.AutoSize = True
        Me.chkKeju.Location = New System.Drawing.Point(15, 37)
        Me.chkKeju.Name = "chkKeju"
        Me.chkKeju.Size = New System.Drawing.Size(100, 17)
        Me.chkKeju.TabIndex = 7
        Me.chkKeju.Text = "Keju (Rp. 9000)"
        Me.ToolTip1.SetToolTip(Me.chkKeju, "Klik disini untuk memilih Topping Keju")
        Me.chkKeju.UseVisualStyleBackColor = True
        '
        'chkStrawberry
        '
        Me.chkStrawberry.AutoSize = True
        Me.chkStrawberry.Location = New System.Drawing.Point(15, 61)
        Me.chkStrawberry.Name = "chkStrawberry"
        Me.chkStrawberry.Size = New System.Drawing.Size(129, 17)
        Me.chkStrawberry.TabIndex = 8
        Me.chkStrawberry.Text = "Strawberry (Rp. 5000)"
        Me.ToolTip1.SetToolTip(Me.chkStrawberry, "Klik disini untuk memilih Topping Strawberry")
        Me.chkStrawberry.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(15, 85)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(123, 17)
        Me.chkBlueberry.TabIndex = 9
        Me.chkBlueberry.Text = "Blueberry (Rp. 5000)"
        Me.ToolTip1.SetToolTip(Me.chkBlueberry, "Klik disini untuk memilih Topping Blueberry")
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkGreentea
        '
        Me.chkGreentea.AutoSize = True
        Me.chkGreentea.Location = New System.Drawing.Point(15, 109)
        Me.chkGreentea.Name = "chkGreentea"
        Me.chkGreentea.Size = New System.Drawing.Size(123, 17)
        Me.chkGreentea.TabIndex = 10
        Me.chkGreentea.Text = "Greentea (Rp. 9000)"
        Me.ToolTip1.SetToolTip(Me.chkGreentea, "Klik disini untuk memilih Topping Greentea")
        Me.chkGreentea.UseVisualStyleBackColor = True
        '
        'chkIcecream
        '
        Me.chkIcecream.AutoSize = True
        Me.chkIcecream.Location = New System.Drawing.Point(15, 133)
        Me.chkIcecream.Name = "chkIcecream"
        Me.chkIcecream.Size = New System.Drawing.Size(167, 17)
        Me.chkIcecream.TabIndex = 11
        Me.chkIcecream.Text = "Ice Cream Vanilla (Rp. 10000)"
        Me.ToolTip1.SetToolTip(Me.chkIcecream, "Klik disini untuk memilih Topping Ice Cream Vanilla")
        Me.chkIcecream.UseVisualStyleBackColor = True
        '
        'radKopSus
        '
        Me.radKopSus.AutoSize = True
        Me.radKopSus.Location = New System.Drawing.Point(19, 12)
        Me.radKopSus.Name = "radKopSus"
        Me.radKopSus.Size = New System.Drawing.Size(132, 17)
        Me.radKopSus.TabIndex = 13
        Me.radKopSus.TabStop = True
        Me.radKopSus.Text = "Kopi Susu (Rp. 12000)"
        Me.ToolTip1.SetToolTip(Me.radKopSus, "Klik disini untuk memilih Kopi Susu")
        Me.radKopSus.UseVisualStyleBackColor = True
        '
        'radKopHit
        '
        Me.radKopHit.AutoSize = True
        Me.radKopHit.Location = New System.Drawing.Point(19, 35)
        Me.radKopHit.Name = "radKopHit"
        Me.radKopHit.Size = New System.Drawing.Size(129, 17)
        Me.radKopHit.TabIndex = 14
        Me.radKopHit.TabStop = True
        Me.radKopHit.Text = "Kopi Hitam (Rp. 9000)"
        Me.ToolTip1.SetToolTip(Me.radKopHit, "Klik disini untuk memilih Kopi Hitam")
        Me.radKopHit.UseVisualStyleBackColor = True
        '
        'radTehTar
        '
        Me.radTehTar.AutoSize = True
        Me.radTehTar.Location = New System.Drawing.Point(19, 58)
        Me.radTehTar.Name = "radTehTar"
        Me.radTehTar.Size = New System.Drawing.Size(130, 17)
        Me.radTehTar.TabIndex = 15
        Me.radTehTar.TabStop = True
        Me.radTehTar.Text = "Teh Tarik (Rp. 10000)"
        Me.ToolTip1.SetToolTip(Me.radTehTar, "Klik disini untuk memilih Teh Tarik")
        Me.radTehTar.UseVisualStyleBackColor = True
        '
        'radMilkshake
        '
        Me.radMilkshake.AutoSize = True
        Me.radMilkshake.Location = New System.Drawing.Point(19, 82)
        Me.radMilkshake.Name = "radMilkshake"
        Me.radMilkshake.Size = New System.Drawing.Size(132, 17)
        Me.radMilkshake.TabIndex = 16
        Me.radMilkshake.TabStop = True
        Me.radMilkshake.Text = "Milkshake (Rp. 18000)"
        Me.ToolTip1.SetToolTip(Me.radMilkshake, "Klik disini untuk memilih Milkshake")
        Me.radMilkshake.UseVisualStyleBackColor = True
        '
        'tombolHitung
        '
        Me.tombolHitung.Location = New System.Drawing.Point(176, 442)
        Me.tombolHitung.Name = "tombolHitung"
        Me.tombolHitung.Size = New System.Drawing.Size(75, 23)
        Me.tombolHitung.TabIndex = 25
        Me.tombolHitung.Text = "&Hitung Total"
        Me.ToolTip1.SetToolTip(Me.tombolHitung, "Klik disini untuk menghitung biaya total pesanan")
        Me.tombolHitung.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(293, 442)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(75, 23)
        Me.tombolReset.TabIndex = 26
        Me.tombolReset.Text = "&Reset Form"
        Me.ToolTip1.SetToolTip(Me.tombolReset, "Klik di sini untuk membersihkan form mulai dari awal")
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(411, 442)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(75, 23)
        Me.tombolKeluar.TabIndex = 27
        Me.tombolKeluar.Text = "&Keluar"
        Me.ToolTip1.SetToolTip(Me.tombolKeluar, "Klik di sini untuk keluar aplikasi")
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCharcoal)
        Me.GroupBox1.Controls.Add(Me.radPandan)
        Me.GroupBox1.Controls.Add(Me.radGandum)
        Me.GroupBox1.Controls.Add(Me.radPutih)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 132)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Roti"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkIcecream)
        Me.GroupBox2.Controls.Add(Me.chkGreentea)
        Me.GroupBox2.Controls.Add(Me.chkBlueberry)
        Me.GroupBox2.Controls.Add(Me.chkStrawberry)
        Me.GroupBox2.Controls.Add(Me.chkKeju)
        Me.GroupBox2.Controls.Add(Me.chkCokelat)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 169)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Topping"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radMilkshake)
        Me.GroupBox3.Controls.Add(Me.radTehTar)
        Me.GroupBox3.Controls.Add(Me.radKopHit)
        Me.GroupBox3.Controls.Add(Me.radKopSus)
        Me.GroupBox3.Location = New System.Drawing.Point(391, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 128)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Minuman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(85, 13)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pajak"
        '
        'lblPajak
        '
        Me.lblPajak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPajak.Location = New System.Drawing.Point(85, 47)
        Me.lblPajak.Name = "lblPajak"
        Me.lblPajak.Size = New System.Drawing.Size(100, 23)
        Me.lblPajak.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(85, 85)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lblPajak)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(391, 223)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 133)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Harga"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolHitung)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roti Bakar XYZ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents radPutih As RadioButton
    Friend WithEvents radGandum As RadioButton
    Friend WithEvents radPandan As RadioButton
    Friend WithEvents radCharcoal As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCokelat As CheckBox
    Friend WithEvents chkKeju As CheckBox
    Friend WithEvents chkStrawberry As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkGreentea As CheckBox
    Friend WithEvents chkIcecream As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radKopSus As RadioButton
    Friend WithEvents radKopHit As RadioButton
    Friend WithEvents radTehTar As RadioButton
    Friend WithEvents radMilkshake As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPajak As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tombolHitung As Button
    Friend WithEvents tombolReset As Button
    Friend WithEvents tombolKeluar As Button
End Class
