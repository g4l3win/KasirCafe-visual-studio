Imports System.Data.SqlClient

Public Class formInputKategori
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Periksa apakah TextBox1 kosong atau ComboBox1 tidak memiliki pilihan yang dipilih
        If String.IsNullOrEmpty(TextBox1.Text) OrElse ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Kategori dan isi subkategori sebelum melanjutkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Lanjutkan ke form berikutnya karena validasi berhasil
            Dim FormRincianKategori As New FormRincianKategori()

            kategori = ComboBox1.Text
            subkategori = TextBox1.Text

            SUBKATEGORI_MENUTableAdapter.Insert(TextBox2.Text, ComboBox1.SelectedValue, TextBox1.Text)
            FormRincianKategori.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.ResetText()
        TextBox1.Clear()
    End Sub

    Private Sub formInputKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.SUBKATEGORI_MENU' table. You can move, or remove it, as needed.
        Me.SUBKATEGORI_MENUTableAdapter.Fill(Me.CAFEDataSet.SUBKATEGORI_MENU)
        Me.KATEGORI_MENUTableAdapter.Fill(Me.CAFEDataSet.KATEGORI_MENU)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dashboardadmin As New dashboardadmin()
        dashboardadmin.Show()
        Me.Close()
    End Sub


End Class