Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormRincianKategori
    Private Sub FormRincianKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = kategori
        Label7.Text = subkategori
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormRincianKategori As New FormRincianKategori()
        kategori = Label6.Text
        subkategori = Label7.Text

        ' Menampilkan pesan konfirmasi
        Dim result As DialogResult
        result = MessageBox.Show("Data telah tersimpan! Apakah ingin menambahkan kategori lagi?", "Konfirmasi", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Jika pengguna memilih Yes, kembali ke form input
            Dim formInputKategori As New formInputKategori
            formInputKategori.Show()
            Me.Close()
        ElseIf result = DialogResult.No Then
            ' Jika pengguna memilih No, kembali ke dashboard
            Dim dashboardadmin As New dashboardadmin()
            dashboardadmin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formInputKategori As New formInputKategori
        formInputKategori.Show()
        Me.Close()
    End Sub
End Class