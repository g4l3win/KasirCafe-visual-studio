Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports kasir_cafe.CAFEDataSetTableAdapters

Public Class FormRincianPesanan
    Public Property Items As List(Of List(Of String))

    Public Sub New(data As List(Of List(Of String)))
        InitializeComponent()
        Items = data
        PopulateListView()
    End Sub

    Private Sub PopulateListView()
        For Each itemData As List(Of String) In Items
            Dim listViewItem As New ListViewItem(itemData(0))
            For i As Integer = 1 To itemData.Count - 1
                listViewItem.SubItems.Add(itemData(i))
            Next
            ListView1.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub FormRincianPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.CAFEDataSet.DataTable1)
        'TODO: This line of code loads data into the 'CAFEDataSet.PEMBAYARAN_PESANAN' table. You can move, or remove it, as needed.
        Me.PEMBAYARAN_PESANANTableAdapter.Fill(Me.CAFEDataSet.PEMBAYARAN_PESANAN)

        Label12.Text = hargatotal
        Label2.Text = nopesan
    End Sub
    'button untuk ke dashboard
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Nilai As Integer

        If Val(Label12.Text) <> 0 Then
            Nilai = Int(Label12.Text)
        End If
        PEMBAYARAN_PESANANTableAdapter.Insert(TextBox1.Text, Label2.Text, DateTimePicker1.Value, Nilai)
        Dim dashboardpelanggan As New dashboardpelanggan()
        dashboardpelanggan.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nilai As Integer

        If Val(Label12.Text) <> 0 Then
            Nilai = Int(Label12.Text)
        End If
        PEMBAYARAN_PESANANTableAdapter.Insert(TextBox1.Text, Label2.Text, DateTimePicker1.Value, Nilai)
        Dim form1 As New Form1()
            form1.Show()
        Me.Close()
    End Sub


End Class