Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FormBeli
    Public DAA As Odbc.OdbcDataAdapter
    Public DSS As DataSet
    Dim CMD As OdbcCommand
    Dim DR As OdbcDataReader
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim DT As DataTable
    Private Sub kode_otomatis()
        Try
            Call bukaDB()
            CMD = New Odbc.OdbcCommand("select * from tb_beli order by id_beli DESC", konek)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                txttransaksi.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_beli").ToString, 4)) + 1
                If Len(txttransaksi.Text) = 1 Then
                    txttransaksi.Text = "KB-00" & txttransaksi.Text & ""
                ElseIf Len(txttransaksi.Text) = 2 Then
                    txttransaksi.Text = "KB-0" & txttransaksi.Text & ""
                ElseIf Len(txttransaksi.Text) >= 3 Then
                    txttransaksi.Text = "KB-" & txttransaksi.Text & ""
                End If

            Else
                txttransaksi.Text = "KB-001"
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub tampilDataComboBox()
        Call bukaDB()
        Dim str As String
        str = "select id_karyawan from tb_karyawan"
        CMD = New OdbcCommand(str, konek)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            Do While DR.Read
                cmbkaryawan.Items.Add(DR("id_karyawan"))
            Loop
        Else
        End If
    End Sub
    Sub tampilDataComboBoxRoti()
        Call bukaDB()
        Dim str As String
        str = "select kd_barang from tb_barang"
        CMD = New OdbcCommand(str, konek)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            Do While DR.Read
                cmbkoderoti.Items.Add(DR("kd_barang"))
            Loop
        Else
        End If
    End Sub
    Private Sub kondisi(ByVal sql As String)
        Dim obj As New System.Data.Odbc.OdbcCommand
        Call bukaDB()
        Try
            obj.Connection = konek
            obj.CommandType = CommandType.Text
            obj.CommandText = sql
            obj.ExecuteNonQuery()
            obj.Dispose()
            MsgBox("Berhasil", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal, Silahkan coba lagi!!!" & ex.Message)
        End Try
    End Sub

    Private Sub FormBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kode_otomatis()
        tampilDataComboBox()
        tampilDataComboBoxRoti()

    End Sub
    Private Sub cmbkoderoti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkoderoti.SelectedIndexChanged
        Call bukaDB()
        Dim str As String
        str = "select * from tb_barang WHERE kd_barang = '" & cmbkoderoti.Text & "'"
        CMD = New OdbcCommand(str, konek)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            DR.Read()
            txtnamaroti.Text = DR("nama_barang")
            txthargabeli.Text = DR("harga_beli")
            'txtstok.Text = DR("stok")
        Else
        End If
    End Sub


    Private Sub txtjumlahbeli_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahbeli.TextChanged
        txttotal.Text = Integer.Parse(txthargabeli.Text) * Integer.Parse(txtjumlahbeli.Text)
        
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Dim save As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        Dim pesan As Integer
        Dim jumlah As String
        Dim update As String
        pesan = MsgBox("Apakah anda yakin ingin menambah barang " + txtnamaroti.Text, vbExclamation + vbYesNo, "perhatian")
        'MsgBox("txtjumlahbeli " + txtjumlahbeli.Text)
        If pesan = vbNo Then
            Exit Sub
        Else
            save = "INSERT INTO tb_dtlbeli(id_beli,kd_barang,total_harga,jumlah_beli) values('" & txttransaksi.Text & "','" & cmbkoderoti.Text & "','" & txttotal.Text & "','" & txtjumlahbeli.Text & "')"
            'jumlah = Convert.ToInt32(txtjumlahbeli.Text) * Convert.ToInt32(txthargabeli.Text)
            'update = "UPDATE tb_dtlbeli SET total_harga=total_harga * (jumlah_beli + " & CInt(txtjumlahbeli.Text) & " ), jumlah_beli= jumlah_beli + " & CInt(txtjumlahbeli.Text) & "  where kd_barang = " & CInt(cmbkoderoti.SelectedItem) & " AND id_beli = '" & txttransaksi.Text & "'"
            kondisi(save)
            'kondisi(update)
        End If
        'kondisi(save)
        vTgl = DateTimePicker1.Value.Day
        vBln = DateTimePicker1.Value.Month
        vThn = DateTimePicker1.Value.Year
        expired = vThn & "-" & vBln & "-" & vTgl

        bersih()
        isigrid()
    End Sub
    Sub isigrid()
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT tb_dtlbeli.id_beli,tb_dtlbeli.kd_barang,tb_barang.nama_barang,tb_dtlbeli.jumlah_beli,tb_dtlbeli.total_harga FROM tb_dtlbeli,tb_barang WHERE tb_dtlbeli.id_beli = '" & txttransaksi.Text & "' AND tb_barang.kd_barang=tb_dtlbeli.kd_barang", konek)
        DT = New DataTable
        DAA.Fill(DT)
        databarang.DataSource = DT
        databarang.Enabled = True
    End Sub

    Private Sub simpanbtn_Click(sender As Object, e As EventArgs) Handles simpanbtn.Click
        Dim save As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        Dim pesan As Integer
        Dim update As String
        'Dim jumlah As Integer
            pesan = MsgBox("Apakah anda yakin ingin menambah transaksi ini ? ", vbExclamation + vbYesNo, "perhatian")
            If pesan = vbNo Then
            Exit Sub
        Else
            update = "UPDATE tb_barang SET stok=tb_barang.stok+" & CInt(txtjumlahbeli.Text) & " WHERE kd_barang=" & CInt(cmbkoderoti.SelectedItem) & ""
            kondisi(update)
        End If
        vTgl = DateTimePicker1.Value.Day
        vBln = DateTimePicker1.Value.Month
        vThn = DateTimePicker1.Value.Year
        expired = vThn & "-" & vBln & "-" & vTgl

        save = "INSERT INTO tb_beli(id_beli,tgl_beli,id_karyawan) values('" & txttransaksi.Text & "','" & expired & "','" & cmbkaryawan.Text & "')"
        kondisi(save)

        bersihall()
        kode_otomatis()
        isigrid()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Dim CMD As OdbcCommand
        CMD = New Odbc.OdbcCommand("SELECT SUM(`total_harga`) FROM tb_dtlbeli WHERE id_beli ='" & txttransaksi.Text & "'", konek)
        txtpengeluaran.Text = CMD.ExecuteScalar().ToString
    End Sub
    Sub bersih()
        cmbkoderoti.SelectedIndex = -1
        txtnamaroti.Clear()
        txthargabeli.Text = "0"
        txtjumlahbeli.Text = "0"
        txttotal.Text = "0"
        'txtstok.Text = "0"
        DateTimePicker1.Value = Date.Now
    End Sub
    Sub bersihall()
        cmbkoderoti.SelectedIndex = -1
        txtnamaroti.Clear()
        txthargabeli.Text = "0"
        txtjumlahbeli.Text = "0"
        txttotal.Text = "0"
        txtpengeluaran.Text = "0"
        DateTimePicker1.Value = Date.Now
    End Sub
End Class