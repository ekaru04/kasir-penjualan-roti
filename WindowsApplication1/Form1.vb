Public Class Form1
    Public DAA As Odbc.OdbcDataAdapter
    Public DSS As DataSet
    Public DT As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
    Sub isigrid()
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT * FROM tb_barang", konek)
        DT = New DataTable
        DAA.Fill(DT)
        dataroti.DataSource = DT
        dataroti.Enabled = True
        bersih()
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        isigrid()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim save As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        vTgl = DateTimePicker1.Value.Day
        vBln = DateTimePicker1.Value.Month
        vThn = DateTimePicker1.Value.Year
        expired = vThn & "-" & vBln & "-" & vTgl

        save = "UPDATE tb_barang SET nama_barang='" & txtnamaroti.Text & "',kadaluarsa='" & expired & "',stok='" & txtstok.Text & "',harga='" & txtharga.Text & "', harga_beli='" & txthargabeli.Text & "' WHERE kd_barang='" & txtkode.Text & "'"
        kondisi(save)


        isigrid()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim save As String
        Dim expired As String
        Dim vTgl As String
        Dim vBln As String
        Dim vThn As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin ingin menambah barang " + txtnamaroti.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then
            Exit Sub
        End If
        vTgl = DateTimePicker1.Value.Day
        vBln = DateTimePicker1.Value.Month
        vThn = DateTimePicker1.Value.Year
        expired = vThn & "-" & vBln & "-" & vTgl

        save = "INSERT INTO tb_barang(nama_barang,kadaluarsa,stok,harga,harga_beli) values('" & txtnamaroti.Text & "','" & expired & "','" & txtstok.Text & "','" & txtharga.Text & "','" & txthargabeli.Text & "')"
        kondisi(save)


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


    Private Sub dataroti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataroti.CellClick
        Try
            txtnamaroti.Text = dataroti.Rows(e.RowIndex).Cells(1).Value
            txtharga.Text = dataroti.Rows(e.RowIndex).Cells(4).Value
            txtkode.Text = dataroti.Rows(e.RowIndex).Cells(0).Value
            txtstok.Text = dataroti.Rows(e.RowIndex).Cells(3).Value
            txthargabeli.Text = dataroti.Rows(e.RowIndex).Cells(5).Value
            DateTimePicker1.Value = IIf(IsDBNull(dataroti.Rows(e.RowIndex).Cells(2).Value), Date.Now,
                                       dataroti.Rows(e.RowIndex).Cells(2).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT * FROM tb_barang WHERE kd_barang LIKE '%" & txtcari.Text & "%' OR nama_barang LIKE '%" & txtcari.Text & "%'", konek)
        DT = New DataTable
        DAA.Fill(DT)
        dataroti.DataSource = DT
        dataroti.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim save As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data barang " + txtnamaroti.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then
            Exit Sub
        End If



        save = "DELETE FROM tb_barang WHERE kd_barang='" & txtkode.Text & "'"
        kondisi(save)


        isigrid()
    End Sub
    Sub bersih()
        txtnamaroti.Clear()
        txtkode.Clear()
        txtharga.Clear()
        txtstok.Clear()
        DateTimePicker1.Value = Date.Now

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormListRoti.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Yakin ingin keluar aplikasi ?", vbExclamation + vbYesNo, "EXIT") Then
            Exit Sub
        End If
    End Sub
End Class
