<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.txttransaksi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txttotalbayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtuangditerima = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbkodekaryawan = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnamaroti = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlahbeli = New System.Windows.Forms.TextBox()
        Me.txttotalharga = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.databarang = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbkoderoti = New System.Windows.Forms.ComboBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.editbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'txttransaksi
        '
        Me.txttransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransaksi.Location = New System.Drawing.Point(187, 22)
        Me.txttransaksi.Name = "txttransaksi"
        Me.txttransaksi.ReadOnly = True
        Me.txttransaksi.Size = New System.Drawing.Size(129, 22)
        Me.txttransaksi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE KARYAWAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Blue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(804, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txttotalbayar
        '
        Me.txttotalbayar.Location = New System.Drawing.Point(600, 325)
        Me.txttotalbayar.Name = "txttotalbayar"
        Me.txttotalbayar.Size = New System.Drawing.Size(129, 20)
        Me.txttotalbayar.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(425, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Uang diterima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(425, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kembalian"
        '
        'txtuangditerima
        '
        Me.txtuangditerima.Location = New System.Drawing.Point(600, 355)
        Me.txtuangditerima.Name = "txtuangditerima"
        Me.txtuangditerima.Size = New System.Drawing.Size(129, 20)
        Me.txtuangditerima.TabIndex = 14
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(600, 382)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(129, 20)
        Me.txtkembalian.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Aqua
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(414, 312)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(391, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'cmbkodekaryawan
        '
        Me.cmbkodekaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkodekaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbkodekaryawan.FormattingEnabled = True
        Me.cmbkodekaryawan.Location = New System.Drawing.Point(187, 47)
        Me.cmbkodekaryawan.Name = "cmbkodekaryawan"
        Me.cmbkodekaryawan.Size = New System.Drawing.Size(129, 24)
        Me.cmbkodekaryawan.TabIndex = 17
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(1, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(804, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kode Roti"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Nama Roti"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Harga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(439, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Jumlah Beli"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(554, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Total Harga"
        '
        'txtnamaroti
        '
        Me.txtnamaroti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaroti.Location = New System.Drawing.Point(100, 112)
        Me.txtnamaroti.Name = "txtnamaroti"
        Me.txtnamaroti.ReadOnly = True
        Me.txtnamaroti.Size = New System.Drawing.Size(139, 22)
        Me.txtnamaroti.TabIndex = 25
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(245, 112)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(111, 22)
        Me.txtharga.TabIndex = 26
        '
        'txtjumlahbeli
        '
        Me.txtjumlahbeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahbeli.Location = New System.Drawing.Point(426, 112)
        Me.txtjumlahbeli.Name = "txtjumlahbeli"
        Me.txtjumlahbeli.Size = New System.Drawing.Size(111, 22)
        Me.txtjumlahbeli.TabIndex = 27
        '
        'txttotalharga
        '
        Me.txttotalharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalharga.Location = New System.Drawing.Point(543, 112)
        Me.txttotalharga.Name = "txttotalharga"
        Me.txttotalharga.ReadOnly = True
        Me.txttotalharga.Size = New System.Drawing.Size(111, 22)
        Me.txttotalharga.TabIndex = 28
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(660, 108)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(58, 28)
        Me.btnOK.TabIndex = 29
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Enabled = False
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(724, 109)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(69, 28)
        Me.btnhapus.TabIndex = 30
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'databarang
        '
        Me.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databarang.Location = New System.Drawing.Point(1, 151)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(804, 150)
        Me.databarang.TabIndex = 31
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(579, 427)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 32
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(667, 427)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbkoderoti
        '
        Me.cmbkoderoti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkoderoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbkoderoti.FormattingEnabled = True
        Me.cmbkoderoti.Location = New System.Drawing.Point(16, 112)
        Me.cmbkoderoti.Name = "cmbkoderoti"
        Me.cmbkoderoti.Size = New System.Drawing.Size(80, 24)
        Me.cmbkoderoti.TabIndex = 34
        '
        'txtstok
        '
        Me.txtstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstok.Location = New System.Drawing.Point(362, 112)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.ReadOnly = True
        Me.txtstok.Size = New System.Drawing.Size(58, 22)
        Me.txtstok.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(373, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 15)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Stok"
        '
        'editbtn
        '
        Me.editbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editbtn.Location = New System.Drawing.Point(724, 109)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(58, 28)
        Me.editbtn.TabIndex = 37
        Me.editbtn.Text = "EDIT"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 457)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.cmbkoderoti)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.databarang)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txttotalharga)
        Me.Controls.Add(Me.txtjumlahbeli)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnamaroti)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.cmbkodekaryawan)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtuangditerima)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttotalbayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnhapus)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txttotalbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtuangditerima As System.Windows.Forms.TextBox
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbkodekaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnamaroti As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlahbeli As System.Windows.Forms.TextBox
    Friend WithEvents txttotalharga As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents databarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbkoderoti As System.Windows.Forms.ComboBox
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents editbtn As System.Windows.Forms.Button
End Class
