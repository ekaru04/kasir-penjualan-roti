<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
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
        Me.txtkodepegawai = New System.Windows.Forms.TextBox()
        Me.txtnamapegawai = New System.Windows.Forms.TextBox()
        Me.barubtn = New System.Windows.Forms.Button()
        Me.hapusbtn = New System.Windows.Forms.Button()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.simpanbtn = New System.Windows.Forms.Button()
        Me.datapegawai = New System.Windows.Forms.DataGridView()
        CType(Me.datapegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE PEGAWAI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA PEGAWAI"
        '
        'txtkodepegawai
        '
        Me.txtkodepegawai.Location = New System.Drawing.Point(166, 76)
        Me.txtkodepegawai.Name = "txtkodepegawai"
        Me.txtkodepegawai.ReadOnly = True
        Me.txtkodepegawai.Size = New System.Drawing.Size(138, 20)
        Me.txtkodepegawai.TabIndex = 3
        '
        'txtnamapegawai
        '
        Me.txtnamapegawai.Location = New System.Drawing.Point(166, 102)
        Me.txtnamapegawai.Name = "txtnamapegawai"
        Me.txtnamapegawai.Size = New System.Drawing.Size(138, 20)
        Me.txtnamapegawai.TabIndex = 4
        '
        'barubtn
        '
        Me.barubtn.Location = New System.Drawing.Point(310, 76)
        Me.barubtn.Name = "barubtn"
        Me.barubtn.Size = New System.Drawing.Size(75, 23)
        Me.barubtn.TabIndex = 5
        Me.barubtn.Text = "BARU"
        Me.barubtn.UseVisualStyleBackColor = True
        '
        'hapusbtn
        '
        Me.hapusbtn.Location = New System.Drawing.Point(391, 76)
        Me.hapusbtn.Name = "hapusbtn"
        Me.hapusbtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusbtn.TabIndex = 6
        Me.hapusbtn.Text = "HAPUS"
        Me.hapusbtn.UseVisualStyleBackColor = True
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(166, 128)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(138, 20)
        Me.txtalamat.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ALAMAT"
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(391, 128)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(75, 23)
        Me.editbtn.TabIndex = 9
        Me.editbtn.Text = "EDIT"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'simpanbtn
        '
        Me.simpanbtn.Location = New System.Drawing.Point(310, 128)
        Me.simpanbtn.Name = "simpanbtn"
        Me.simpanbtn.Size = New System.Drawing.Size(75, 23)
        Me.simpanbtn.TabIndex = 10
        Me.simpanbtn.Text = "SIMPAN"
        Me.simpanbtn.UseVisualStyleBackColor = True
        '
        'datapegawai
        '
        Me.datapegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datapegawai.Location = New System.Drawing.Point(43, 161)
        Me.datapegawai.Name = "datapegawai"
        Me.datapegawai.Size = New System.Drawing.Size(423, 150)
        Me.datapegawai.TabIndex = 11
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 363)
        Me.Controls.Add(Me.datapegawai)
        Me.Controls.Add(Me.simpanbtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hapusbtn)
        Me.Controls.Add(Me.barubtn)
        Me.Controls.Add(Me.txtnamapegawai)
        Me.Controls.Add(Me.txtkodepegawai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPegawai"
        Me.Text = "FormPegawai"
        CType(Me.datapegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtkodepegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapegawai As System.Windows.Forms.TextBox
    Friend WithEvents barubtn As System.Windows.Forms.Button
    Friend WithEvents hapusbtn As System.Windows.Forms.Button
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents editbtn As System.Windows.Forms.Button
    Friend WithEvents simpanbtn As System.Windows.Forms.Button
    Friend WithEvents datapegawai As System.Windows.Forms.DataGridView
End Class
