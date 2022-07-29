Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FormTransaksi
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
            CMD = New Odbc.OdbcCommand("select * from tb_transaksi order by id_transaksi DESC", konek)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                txttransaksi.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_transaksi").ToString, 4)) + 1
                If Len(txttransaksi.Text) = 1 Then
                    txttransaksi.Text = "KT-00" & txttransaksi.Text & ""
                ElseIf Len(txttransaksi.Text) = 2 Then
                    txttransaksi.Text = "KT-0" & txttransaksi.Text & ""
                ElseIf Len(txttransaksi.Text) >= 3 Then
                    txttransaksi.Text = "KT-" & txttransaksi.Text & ""
                End If

            Else
                txttransaksi.Text = "KT-001"
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
                cmbkodekaryawan.Items.Add(DR("id_karyawan"))
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

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txtharga.Text = DR("harga")
            txtstok.Text = DR("stok")
        Else
        End If
        'menampilkan data roti dari combobox ke textbox yang diinginkan

    End Sub
    Private Sub txtjumlahbeli_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahbeli.TextChanged
        txttotalharga.Text = Integer.Parse(txtharga.Text) * Integer.Parse(txtjumlahbeli.Text)
        If CInt(txtjumlahbeli.Text) < 0 Then
            txtjumlahbeli.Text = 0
        End If
        'mengubah text jika membeli barang kurang dari 0

    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim save As String
        'Dim Update As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        Dim pesan As Integer
        Dim update As String
        pesan = MsgBox("Apakah anda yakin ingin menambah barang " + txtnamaroti.Text, vbExclamation + vbYesNo, "perhatian")

        If pesan = vbNo Then
            Exit Sub
        Else
            If Convert.ToInt32(txtjumlahbeli.Text) > Convert.ToInt32(txtstok.Text) Then
                MsgBox("Barang yang anda beli melebihi stok yang ada, mohon coba lagi")
                bersih()
            ElseIf databarang.RowCount > 3 Then
                For i As Integer = 0 To databarang.RowCount - 1
                    If databarang.Item(1, i).Value.Equals(CInt(cmbkoderoti.Text)) Then
                        Console.WriteLine("DATA EXIST!")
                        update = "update tb_dtltransaksi set total_harga=" & CInt(txtharga.Text) & " * (tb_dtltransaksi.jumlah_beli + " & CInt(txtjumlahbeli.Text) & " ), jumlah_beli= tb_dtltransaksi.jumlah_beli + " & CInt(txtjumlahbeli.Text) & "  where kd_barang = " & CInt(cmbkoderoti.Text) & " "
                        kondisi(update)
                        Exit For
                        Return
                    End If
                Next
            Else
                save = "INSERT INTO tb_dtltransaksi(id_transaksi,kd_barang,total_harga,jumlah_beli) values('" & txttransaksi.Text & "','" & cmbkoderoti.Text & "','" & txttotalharga.Text & "','" & txtjumlahbeli.Text & "')"
                kondisi(save)
                'jumlah = Convert.ToInt32(txtstok.Text) - Convert.ToInt32(txtjumlahbeli.Text)
                'Update = "UPDATE tb_barang SET stok='" & jumlah & "' WHERE kd_barang='" & cmbkoderoti.Text & "'"
            End If
            ' Dim jumlah As Integer
            'kondisi(Update)
            End If
            vTgl = DateTimePicker1.Value.Day
            vBln = DateTimePicker1.Value.Month
            vThn = DateTimePicker1.Value.Year
            expired = vThn & "-" & vBln & "-" & vTgl

            bersih()
            isigrid()
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
    Sub isigrid()
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT tb_dtltransaksi.id_transaksi,tb_dtltransaksi.kd_barang,tb_barang.nama_barang,tb_dtltransaksi.jumlah_beli,tb_dtltransaksi.total_harga FROM tb_dtltransaksi,tb_barang WHERE tb_dtltransaksi.id_transaksi = '" & txttransaksi.Text & "' AND tb_barang.kd_barang=tb_dtltransaksi.kd_barang", konek)
        DT = New DataTable
        DAA.Fill(DT)
        databarang.DataSource = DT
        databarang.Enabled = True

    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim save As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        Dim pesan As Integer
        Dim update As String
        Dim jumlah As Integer

        Try
            pesan = MsgBox("Apakah anda yakin ingin menambah transaksi ini ? ", vbExclamation + vbYesNo, "perhatian")
            If pesan = vbNo Then
                Exit Sub
            Else
                Dim intRow As Integer = 0
                For Each rowData In databarang.Rows
                    jumlah = CInt(txtstok.Text) - CInt(txtjumlahbeli.Text)
                    update = "UPDATE tb_barang SET stok= stok -" & CInt(databarang.Item(3, intRow).Value) & " WHERE kd_barang=" & CInt(databarang.Item(1, intRow).Value) & ""
                    kondisi(update)
                    intRow += 1
                Next

            End If

        Catch ex As Exception
            Console.WriteLine("Err, :" & ex.ToString)
        End Try

        vTgl = DateTimePicker1.Value.Day
        vBln = DateTimePicker1.Value.Month
        vThn = DateTimePicker1.Value.Year
        expired = vThn & "-" & vBln & "-" & vTgl

        save = "INSERT INTO tb_transaksi(id_transaksi,tgl_transaksi,id_karyawan) values('" & txttransaksi.Text & "','" & expired & "','" & cmbkodekaryawan.Text & "')"
        kondisi(save)


        bersihall()
        kode_otomatis()
        isigrid()
    End Sub
    Sub bersih()
        cmbkoderoti.SelectedIndex = -1
        txtnamaroti.Clear()
        txtharga.Text = "0"
        txtjumlahbeli.Text = "0"
        txttotalharga.Text = "0"
        txtstok.Text = "0"
        DateTimePicker1.Value = Date.Now

    End Sub
    Sub bersihall()
        cmbkoderoti.SelectedIndex = -1
        txtnamaroti.Clear()
        txtharga.Text = "0"
        txtjumlahbeli.Text = "0"
        txttotalharga.Text = "0"
        txttotalbayar.Text = "0"
        txtuangditerima.Text = "0"
        txtkembalian.Text = "0"
        txttransaksi.Clear()
        cmbkodekaryawan.SelectedIndex = -1
        'databarang.Rows.Clear()

    End Sub
    Private Sub txttotalharga_TextChanged(sender As Object, e As EventArgs) Handles txttotalharga.TextChanged
        Dim CMD As OdbcCommand
        CMD = New Odbc.OdbcCommand("SELECT SUM(`total_harga`) FROM tb_dtltransaksi WHERE id_transaksi = '" & txttransaksi.Text & "'", konek)
        txttotalbayar.Text = CMD.ExecuteScalar().ToString

    End Sub

    Private Sub databarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles databarang.CellClick
        Try
            txtnamaroti.Text = databarang.Rows(e.RowIndex).Cells(2).Value
            txttotalharga.Text = databarang.Rows(e.RowIndex).Cells(4).Value
            cmbkoderoti.Text = databarang.Rows(e.RowIndex).Cells(1).Value
            txtjumlahbeli.Text = databarang.Rows(e.RowIndex).Cells(3).Value
            'txtstok.Text = dataroti.Rows(e.RowIndex).Cells(3).Value
            
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim save As String
        Dim pesan As Integer
        Dim jumlah As Integer
        Dim Update As String
        pesan = MsgBox("Apakah anda yakin akan menghapus Data barang " + txtnamaroti.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then
            Exit Sub
        End If

        jumlah = Convert.ToInt32(txtstok.Text) + Convert.ToInt32(txtjumlahbeli.Text)
        Update = "UPDATE tb_barang SET stok='" & jumlah & "' WHERE kd_barang='" & cmbkoderoti.Text & "'"
        save = "DELETE FROM tb_dtltransaksi WHERE kd_barang='" & CInt(cmbkoderoti.Text) & "' AND id_transaksi ='" & txttransaksi.Text & "'"
        kondisi(save)
        kondisi(Update)

        bersih()
        isigrid()
    End Sub

    Private Sub txtuangditerima_LostFocus(sender As Object, e As EventArgs) Handles txtuangditerima.LostFocus
        If txtuangditerima.Text < txttotalbayar.Text Then
            txtuangditerima.Text = "0"
            txtkembalian.Text = "0"
            MsgBox("Anjay, Duitnya kurang", vbExclamation + vbOKOnly)
        End If
    End Sub

    Private Sub txtuangditerima_TextChanged(sender As Object, e As EventArgs) Handles txtuangditerima.TextChanged
        If txtuangditerima.Text < 0 Then
            txtuangditerima.Text = "0"
            'txtkembalian.Text = "0"
        End If
        txtkembalian.Text = txtuangditerima.Text - txttotalbayar.Text

    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Try
            Dim update As String = "UPDATE tb_dtltransaksi SET kd_barang=" & CInt(cmbkoderoti.SelectedItem) & ", jumlah_beli=" & CInt(txtjumlahbeli.Text) & ", total_harga=" & CInt(txttotalharga.Text) & " WHERE kd_barang=" & CInt(cmbkoderoti.SelectedItem) & ""
            Dim makoto As New OdbcCommand(update, konek)
            'Dim iws As New OdbcCommand(negev, konek)
            makoto.ExecuteNonQuery()
            'iws.ExecuteNonQuery()
            MsgBox("Berhasil edit jumlah", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            Dim negev As String
            negev = "update tb_dtltransaksi set total_harga=" & CInt(txtharga.Text) & " * (tb_dtltransaksi.jumlah_beli + " & CInt(txtjumlahbeli.Text) & " ), jumlah_beli= tb_dtltransaksi.jumlah_beli + " & CInt(txtjumlahbeli.Text) & "  where kd_barang = " & CInt(cmbkoderoti.Text) & " "
            kondisi(negev)

        End Try
        bersih()
        isigrid()
    End Sub

End Class