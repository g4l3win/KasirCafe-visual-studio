Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Periksa apakah TextBox1 kosong atau ComboBox1 tidak memiliki pilihan yang dipilih
        'If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse String.IsNullOrEmpty(TextBox5.Text) Then
        'MessageBox.Show("Masukkan semua data sebelum melanjutkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        ' Lanjutkan ke form berikutnya karena validasi berhasil
        'Dim FormRincianpelanggan As New formRincianPelanggan()

        'idpelanggan = TextBox6.Text
        'namapelanggan = TextBox1.Text
        'telppelanggan = TextBox2.Text
        'alamatpelanggan = TextBox3.Text
        'emailpelanggan = TextBox4.Text

        PELANGGAN_CAFETableAdapter.Update(CAFEDataSet.PELANGGAN_CAFE)
        'FormRincianpelanggan.Show()
        'Me.Hide()
        'End If

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '  TextBox1.Clear()
    '  TextBox2.Clear()
    '  TextBox3.Clear()
    '  TextBox4.Clear()
    ' TextBox5.Clear()
    ' End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.PELANGGAN_CAFE' table. You can move, or remove it, as needed.
        Me.PELANGGAN_CAFETableAdapter.Fill(Me.CAFEDataSet.PELANGGAN_CAFE)
        PELANGGAN_CAFETableAdapter.Update(CAFEDataSet.PELANGGAN_CAFE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dashboardpelanggan As New dashboardpelanggan()
        dashboardpelanggan.Show()
        Me.Hide() ' Menyembunyikan form saat ini (dashboard)
    End Sub
End Class