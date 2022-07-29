Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text




Public Class login


    Shared Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click


        Dim user As String = txtuser.Text
        Dim pass As String = GetHash(txtpass.Text)
        Dim query As String = "select user, pass from login WHERE user='" & user & "' AND pass='" & pass & "'"

        Try
            Call bukaDB()
            CMD = New OdbcCommand(query, konek)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                master.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah")
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class