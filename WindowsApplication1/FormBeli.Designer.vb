<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeli
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttransaksi = New System.Windows.Forms.TextBox()
        Me.cmbkaryawan = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbkoderoti = New System.Windows.Forms.ComboBox()
        Me.txtnamaroti = New System.Windows.Forms.TextBox()
        Me.txthargabeli = New System.Windows.Forms.TextBox()
        Me.txtjumlahbeli = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.databarang = New System.Windows.Forms.DataGridView()
        Me.txtpengeluaran = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.simpanbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Blue
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(804, 80)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KODE TRANSAKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KODE KARYAWAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TANGGAL"
        '
        'txttransaksi
        '
        Me.txttransaksi.Location = New System.Drawing.Point(187, 22)
        Me.txttransaksi.Name = "txttransaksi"
        Me.txttransaksi.Size = New System.Drawing.Size(129, 20)
        Me.txttransaksi.TabIndex = 4
        '
        'cmbkaryawan
        '
        Me.cmbkaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkaryawan.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cmbkaryawan.FormattingEnabled = True
        Me.cmbkaryawan.Location = New System.Drawing.Point(185, 48)
        Me.cmbkaryawan.Name = "cmbkaryawan"
        Me.cmbkaryawan.Size = New System.Drawing.Size(131, 21)
        Me.cmbkaryawan.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(1, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(804, 60)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'cmbkoderoti
        '
        Me.cmbkoderoti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkoderoti.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cmbkoderoti.FormattingEnabled = True
        Me.cmbkoderoti.Location = New System.Drawing.Point(16, 112)
        Me.cmbkoderoti.Name = "cmbkoderoti"
        Me.cmbkoderoti.Size = New System.Drawing.Size(80, 21)
        Me.cmbkoderoti.TabIndex = 8
        '
        'txtnamaroti
        '
        Me.txtnamaroti.Location = New System.Drawing.Point(100, 112)
        Me.txtnamaroti.Name = "txtnamaroti"
        Me.txtnamaroti.ReadOnly = True
        Me.txtnamaroti.Size = New System.Drawing.Size(150, 20)
        Me.txtnamaroti.TabIndex = 9
        '
        'txthargabeli
        '
        Me.txthargabeli.Location = New System.Drawing.Point(385, 112)
        Me.txthargabeli.Name = "txthargabeli"
        Me.txthargabeli.ReadOnly = True
        Me.txthargabeli.Size = New System.Drawing.Size(152, 20)
        Me.txthargabeli.TabIndex = 10
        '
        'txtjumlahbeli
        '
        Me.txtjumlahbeli.Location = New System.Drawing.Point(256, 112)
        Me.txtjumlahbeli.Name = "txtjumlahbeli"
        Me.txtjumlahbeli.Size = New System.Drawing.Size(123, 20)
        Me.txtjumlahbeli.TabIndex = 12
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(543, 112)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(111, 20)
        Me.txttotal.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "kode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "nama barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "jumlah beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "harga beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(585, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "total"
        '
        'databarang
        '
        Me.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databarang.Location = New System.Drawing.Point(1, 153)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(804, 150)
        Me.databarang.TabIndex = 19
        '
        'txtpengeluaran
        '
        Me.txtpengeluaran.Location = New System.Drawing.Point(588, 341)
        Me.txtpengeluaran.Multiline = True
        Me.txtpengeluaran.Name = "txtpengeluaran"
        Me.txtpengeluaran.Size = New System.Drawing.Size(173, 84)
        Me.txtpengeluaran.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(611, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "TOTAL PENGELUARAN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(480, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'okbtn
        '
        Me.okbtn.Location = New System.Drawing.Point(661, 112)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(75, 23)
        Me.okbtn.TabIndex = 23
        Me.okbtn.Text = "OK"
        Me.okbtn.UseVisualStyleBackColor = True
        '
        'simpanbtn
        '
        Me.simpanbtn.Location = New System.Drawing.Point(638, 431)
        Me.simpanbtn.Name = "simpanbtn"
        Me.simpanbtn.Size = New System.Drawing.Size(75, 23)
        Me.simpanbtn.TabIndex = 24
        Me.simpanbtn.Text = "SIMPAN"
        Me.simpanbtn.UseVisualStyleBackColor = True
        '
        'FormBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 457)
        Me.Controls.Add(Me.simpanbtn)
        Me.Controls.Add(Me.okbtn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpengeluaran)
        Me.Controls.Add(Me.databarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjumlahbeli)
        Me.Controls.Add(Me.txthargabeli)
        Me.Controls.Add(Me.txtnamaroti)
        Me.Controls.Add(Me.cmbkoderoti)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmbkaryawan)
        Me.Controls.Add(Me.txttransaksi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormBeli"
        Me.Text = "FormBeli"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttransaksi As System.Windows.Forms.TextBox
    Friend WithEvents cmbkaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbkoderoti As System.Windows.Forms.ComboBox
    Friend WithEvents txtnamaroti As System.Windows.Forms.TextBox
    Friend WithEvents txthargabeli As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlahbeli As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents databarang As System.Windows.Forms.DataGridView
    Friend WithEvents txtpengeluaran As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents okbtn As System.Windows.Forms.Button
    Friend WithEvents simpanbtn As System.Windows.Forms.Button
End Class
