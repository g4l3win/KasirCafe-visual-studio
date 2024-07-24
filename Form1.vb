

Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports kasir_cafe.CAFEDataSetTableAdapters

Public Class Form1
    Dim TotalBayar As Integer = 0
    Dim connectionString As String = "Data Source=LAPTOP-FTNPN94M;Initial Catalog=cafe;Integrated Security=True"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            Try
                ' Hapus isi TextBox1 sebelum menampilkan harga baru
                TextBox1.Clear()
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim sqlQuery As String = "SELECT HARGA FROM ITEM_MENU WHERE NAMA = @menuName"

                    Using command As New SqlCommand(sqlQuery, connection)
                        command.Parameters.AddWithValue("@menuName", ComboBox1.Text)

                        Dim harga As Object = command.ExecuteScalar()

                        If harga IsNot Nothing AndAlso Not IsDBNull(harga) Then
                            TextBox1.Text = harga.ToString()
                        Else
                            TextBox1.Text = "0"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If

    End Sub


    'textbox jumlah minuman dan makanan
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim Nilai As Integer

        If Val(TextBox3.Text) <> 0 Then
            Nilai = Int(TextBox1.Text)
            TextBox1.Text = Nilai
            Button5.Enabled = True
            Button1.Enabled = True
        Else Button5.Enabled = False
            Button1.Enabled = False
        End If

    End Sub

    'button hitung
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = Val(TextBox3.Text) * Val(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.ResetText()

        TextBox1.ResetText()
        TextBox8.ResetText()
        TextBox3.ResetText()
        TextBox7.ResetText()

    End Sub
    'Insert ke tabel pesanan
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PESANAN_PELANGGANTableAdapter.Insert(TextBox9.Text, TextBox8.Text, TextBox4.Text, DateTimePicker1.Value)
        Me.PESANAN_PELANGGANTableAdapter.Fill(Me.CAFEDataSet.PESANAN_PELANGGAN)
    End Sub

    'buat tombol submit mininuman kirim ke rincian pesanan
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim data(4) As String
        data(0) = ComboBox1.SelectedValue.ToString()
        'data(0) = ComboBox1.SelectedValue.ToString()
        data(1) = TextBox1.Text
        data(2) = TextBox3.Text
        data(3) = TextBox7.Text
        Dim itemList As New ListViewItem(data)
        ListView1.Items.Add(itemList)
        TotalBayar += Convert.ToInt32(TextBox7.Text)
        TextBox5.Text = TotalBayar.ToString()


        DETAIL_PESANANTableAdapter.Insert(ComboBox1.SelectedValue, TextBox9.Text, TextBox3.Text, TextBox7.Text)
        Me.DataTable1TableAdapter.Fill(Me.CAFEDataSet.DataTable1)
    End Sub
    'button submit makanan

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim item As ListViewItem
        For Each item In ListView1.SelectedItems
            ComboBox1.Text = item.SubItems(0).Text
            TextBox1.Text = item.SubItems(1).Text
            TextBox3.Text = item.SubItems(2).Text
            TextBox7.Text = item.SubItems(3).Text
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        hargatotal = TextBox5.Text
        nopesan = TextBox9.Text

        Dim dataToPass As New List(Of List(Of String))()
        For Each item As ListViewItem In ListView1.Items
            Dim data As New List(Of String)()
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                data.Add(subItem.Text)
            Next
            dataToPass.Add(data)
        Next
        Dim formTarget As New FormRincianPesanan(dataToPass)
        formTarget.Show()
        Me.Hide()
    End Sub
    'sembunyiin tombol yang g bisa diklik
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.CAFEDataSet.DataTable1)
        'TODO: This line of code loads data into the 'CAFEDataSet.PELANGGAN_CAFE' table. You can move, or remove it, as needed.
        Me.PELANGGAN_CAFETableAdapter.Fill(Me.CAFEDataSet.PELANGGAN_CAFE)
        'TODO: This line of code loads data into the 'CAFEDataSet.PESANAN_PELANGGAN' table. You can move, or remove it, as needed.
        Me.PESANAN_PELANGGANTableAdapter.Fill(Me.CAFEDataSet.PESANAN_PELANGGAN)
        'TODO: This line of code loads data into the 'CAFEDataSet.DETAIL_PESANAN' table. You can move, or remove it, as needed.
        Me.DETAIL_PESANANTableAdapter.Fill(Me.CAFEDataSet.DETAIL_PESANAN)
        'TODO: This line of code loads data into the 'CAFEDataSet.ITEM_MENU' table. You can move, or remove it, as needed.
        Me.ITEM_MENUTableAdapter.Fill(Me.CAFEDataSet.ITEM_MENU)

        TextBox3.Enabled = False
        Button5.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If PELANGGAN_CAFETableAdapter.GetData().Rows.Count > 0 Then
            TextBox8.Text = PELANGGAN_CAFETableAdapter.GetData().Rows(0)("NOPELANGGAN").ToString()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Membuat instance dari Form kedua
        Dim dashboardpelanggan As New dashboardpelanggan()

        ' Menampilkan Form kedua
        dashboardpelanggan.Show()
        Me.Close()
    End Sub


End Class


