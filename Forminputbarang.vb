
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports kasir_cafe.CAFEDataSetTableAdapters

Public Class FormInputBarang

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Periksa apakah TextBox1 kosong atau ComboBox1 tidak memiliki pilihan yang dipilih
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse ComboBox1.SelectedIndex = -1 OrElse ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Isi semua komponen sebelum melanjutkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim FormRincianBarang As New formRincianBarang()
            Namabarang = TextBox1.Text
            kategori = ComboBox1.Text
            subkategori = ComboBox2.Text
            harga = TextBox2.Text

            ITEM_MENUTableAdapter.Insert(TextBox3.Text, ComboBox2.SelectedValue, TextBox1.Text, TextBox2.Text)
            FormRincianBarang.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Loop through all controls on the form
        For Each control As Control In Me.Controls
            ' Check if the control is a TextBox
            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Then
                ' Set the Text property of the control to an empty string
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dashboardadmin As New dashboardadmin()
        dashboardadmin.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Bersihkan item yang ada di ComboBox2
        ' ComboBox2.Items.Clear()

        ' Tambahkan item berdasarkan pilihan ComboBox1
        'If ComboBox1.Text = "Makanan" Then
        ' Pilihan kategori Makanan, tambahkan subkategori Roti
        'ComboBox2.Items.Add("Roti")
        ' ElseIf ComboBox1.Text = "Minuman" Then
        ' Pilihan kategori Minuman, tambahkan subkategori Teh dan Kopi
        'ComboBox2.Items.Add("Teh")
        'ComboBox2.Items.Add("Kopi")
        ' End If
    End Sub

    Private Sub FormInputBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.SUBKATEGORI_MENU' table. You can move, or remove it, as needed.
        Me.SUBKATEGORI_MENUTableAdapter.Fill(Me.CAFEDataSet.SUBKATEGORI_MENU)
        'TODO: This line of code loads data into the 'CAFEDataSet.KATEGORI_MENU' table. You can move, or remove it, as needed.
        Me.KATEGORI_MENUTableAdapter.Fill(Me.CAFEDataSet.KATEGORI_MENU)
        'TODO: This line of code loads data into the 'CAFEDataSet.ITEM_MENU' table. You can move, or remove it, as needed.
        Me.ITEM_MENUTableAdapter.Fill(Me.CAFEDataSet.ITEM_MENU)

    End Sub
End Class