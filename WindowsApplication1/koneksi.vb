Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Module koneksi
    Public konek As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public DT As DataTable

    Sub bukaDB()

        Try
            konek = New OdbcConnection("DSN=dsn_roti;MultipleActiveResultSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Database Bermasalah, silahkan coba lagi")
        End Try

    End Sub
End Module
