<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_Input = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Tutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM DATA ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Level Admin"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(209, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(253, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(209, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(253, 20)
        Me.TextBox3.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(209, 178)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(253, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Button_Input
        '
        Me.Button_Input.Location = New System.Drawing.Point(183, 253)
        Me.Button_Input.Name = "Button_Input"
        Me.Button_Input.Size = New System.Drawing.Size(91, 36)
        Me.Button_Input.TabIndex = 9
        Me.Button_Input.Text = "Input"
        Me.Button_Input.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(314, 253)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(91, 36)
        Me.Button_Edit.TabIndex = 10
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(451, 253)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(91, 36)
        Me.Button_Hapus.TabIndex = 11
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Tutup
        '
        Me.Button_Tutup.Location = New System.Drawing.Point(593, 253)
        Me.Button_Tutup.Name = "Button_Tutup"
        Me.Button_Tutup.Size = New System.Drawing.Size(91, 36)
        Me.Button_Tutup.TabIndex = 12
        Me.Button_Tutup.Text = "Tutup"
        Me.Button_Tutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(183, 338)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(484, 170)
        Me.DataGridView1.TabIndex = 13
        '
        'FormDataAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Tutup)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Input)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataAdmin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_Input As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Tutup As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
