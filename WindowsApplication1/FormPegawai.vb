Public Class FormPegawai
    Public DAA As Odbc.OdbcDataAdapter
    Public DSS As DataSet
    Public DT As DataTable

    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kode_otomatis()
        isigrid()

    End Sub
    Sub isigrid()
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT * FROM tb_karyawan", konek)
        DT = New DataTable
        DAA.Fill(DT)
        datapegawai.DataSource = DT
        datapegawai.Enabled = True
        bersih()
    End Sub
    Private Sub kode_otomatis()
        Try
            Call bukaDB()
            CMD = New Odbc.OdbcCommand("select * from tb_karyawan order by id_karyawan DESC", konek)
            DR = CMD.ExecuteReader
            DR.Read()

            If Not DR.HasRows Then
                txtkodepegawai.Text = "KAR" + "0001"
            Else

                txtkodepegawai.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_karyawan").ToString, 6, 3)) + 1
                If Len(txtkodepegawai.Text) = 1 Then
                    txtkodepegawai.Text = "KAR000" & txtkodepegawai.Text & ""
                ElseIf Len(txtkodepegawai.Text) = 2 Then
                    txtkodepegawai.Text = "KAR00" & txtkodepegawai.Text & ""
                ElseIf Len(txtkodepegawai.Text) = 3 Then
                    txtkodepegawai.Text = "KAR0" & txtkodepegawai.Text & ""
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub bersih()
        txtnamapegawai.Clear()
        txtalamat.Clear()
    End Sub
    Sub bersihall()
        txtkodepegawai.Clear()
        txtnamapegawai.Clear()
        txtalamat.Clear()
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

    Private Sub barubtn_Click(sender As Object, e As EventArgs) Handles barubtn.Click
        isigrid()
    End Sub

    Private Sub simpanbtn_Click(sender As Object, e As EventArgs) Handles simpanbtn.Click
        Dim save As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin ingin menambah pegawai " + txtnamapegawai.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then
            Exit Sub
        End If

        save = "INSERT INTO tb_karyawan(id_karyawan,nama_karyawan,alamat) values('" & txtkodepegawai.Text & "','" & txtnamapegawai.Text & "','" & txtalamat.Text & "')"
        kondisi(save)

        bersihall()
        kode_otomatis()
        isigrid()
    End Sub

    Private Sub hapusbtn_Click(sender As Object, e As EventArgs) Handles hapusbtn.Click
        Dim save As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus " + txtnamapegawai.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then
            Exit Sub
        End If



        save = "DELETE FROM tb_karyawan WHERE id_karyawan='" & txtkodepegawai.Text & "'"
        kondisi(save)


        isigrid()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Dim save As String

        save = "UPDATE tb_karyawan SET nama_karyawan='" & txtnamapegawai.Text & "',alamat='" & txtalamat.Text & "' WHERE id_karyawan='" & txtkodepegawai.Text & "'"
        kondisi(save)


        isigrid()
    End Sub

    Private Sub datapegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datapegawai.CellClick
        Try
            txtnamapegawai.Text = datapegawai.Rows(e.RowIndex).Cells(1).Value
            txtalamat.Text = datapegawai.Rows(e.RowIndex).Cells(2).Value
            txtkodepegawai.Text = datapegawai.Rows(e.RowIndex).Cells(0).Value
            
        Catch ex As Exception

        End Try
    End Sub
End Class