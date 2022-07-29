Public Class FormListRoti
    Public DAA As Odbc.OdbcDataAdapter
    Public DSS As DataSet
    Public DT As DataTable

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcariroti_TextChanged(sender As Object, e As EventArgs) Handles txtcariroti.TextChanged
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT * FROM tb_barang WHERE kd_barang LIKE '%" & txtcariroti.Text & "%' OR nama_barang LIKE '%" & txtcariroti.Text & "%'", konek)
        DT = New DataTable
        DAA.Fill(DT)
        dataroti.DataSource = DT
        dataroti.Enabled = True
    End Sub

    Private Sub FormListRoti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
    End Sub
    Sub isigrid()
        bukaDB()
        DAA = New Odbc.OdbcDataAdapter("SELECT * FROM tb_barang", konek)
        DT = New DataTable
        DAA.Fill(DT)
        dataroti.DataSource = DT
        dataroti.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        pesan = MsgBox("anjay", vbExclamation + vbOKCancel)
        If pesan = vbOK Then
            Me.Close()
        End If
    End Sub
End Class