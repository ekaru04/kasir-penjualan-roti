Public Class master

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPegawai.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        'Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormTransaksi.Show()
        'Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'laporanform.Show()
    End Sub
End Class