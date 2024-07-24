Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formRincianBarang
    Private Sub formRincianBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Namabarang
        Label7.Text = kategori
        Label8.Text = subkategori
        Label9.Text = harga

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dashboardadmin1 As New dashboardadmin()
        dashboardadmin1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formInputBarang As New FormInputBarang

        formInputBarang.Show()
        Me.Close()
    End Sub

End Class