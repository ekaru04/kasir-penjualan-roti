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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnamaroti = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.dataroti = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txthargabeli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dataroti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "kode roti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nama roti"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(67, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "kadaluarsa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "stok"
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.ForeColor = System.Drawing.Color.Black
        Me.txtkode.Location = New System.Drawing.Point(176, 100)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(141, 22)
        Me.txtkode.TabIndex = 5
        '
        'txtnamaroti
        '
        Me.txtnamaroti.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.txtnamaroti.Location = New System.Drawing.Point(176, 140)
        Me.txtnamaroti.Name = "txtnamaroti"
        Me.txtnamaroti.Size = New System.Drawing.Size(141, 22)
        Me.txtnamaroti.TabIndex = 6
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.txtharga.Location = New System.Drawing.Point(176, 182)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(141, 22)
        Me.txtharga.TabIndex = 7
        '
        'txtstok
        '
        Me.txtstok.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.txtstok.Location = New System.Drawing.Point(464, 140)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(141, 22)
        Me.txtstok.TabIndex = 9
        '
        'btnbaru
        '
        Me.btnbaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbaru.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbaru.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaru.Location = New System.Drawing.Point(154, 236)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(102, 36)
        Me.btnbaru.TabIndex = 10
        Me.btnbaru.Text = "Baru"
        Me.btnbaru.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(478, 236)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(102, 36)
        Me.btnedit.TabIndex = 11
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(370, 236)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(102, 36)
        Me.btnsimpan.TabIndex = 12
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(262, 236)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(102, 36)
        Me.btnhapus.TabIndex = 13
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'dataroti
        '
        Me.dataroti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataroti.Location = New System.Drawing.Point(59, 365)
        Me.dataroti.Name = "dataroti"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataroti.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataroti.Size = New System.Drawing.Size(535, 150)
        Me.dataroti.TabIndex = 14
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(101, 339)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(141, 20)
        Me.txtcari.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "cari"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gray
        Me.DateTimePicker1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(464, 99)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Daftar Roti"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txthargabeli
        '
        Me.txthargabeli.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.txthargabeli.Location = New System.Drawing.Point(464, 181)
        Me.txthargabeli.Name = "txthargabeli"
        Me.txthargabeli.Size = New System.Drawing.Size(141, 22)
        Me.txthargabeli.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(337, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "harga beli"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(623, 548)
        Me.Controls.Add(Me.txthargabeli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dataroti)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnamaroti)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ManaKuTau"
        CType(Me.dataroti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtnamaroti As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents btnbaru As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents dataroti As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txthargabeli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
