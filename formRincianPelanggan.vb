Public Class formRincianPelanggan
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide() ' Menyembunyikan form saat ini (dashboard)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dashboardpelanggan As New dashboardpelanggan()
        dashboardpelanggan.Show()
        Me.Hide() ' Menyembunyikan form saat ini (dashboard)
    End Sub

    Private Sub formRincianPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = namapelanggan
        Label7.Text = telppelanggan
        Label8.Text = alamatpelanggan
        Label9.Text = emailpelanggan

    End Sub
End Class