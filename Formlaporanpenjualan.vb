Public Class Formlaporanpenjualan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dashboardadmin As New dashboardadmin()
        dashboardadmin.Show()
        Me.Close()
    End Sub

    Private Sub Formlaporanpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.TABELPENJUALAN' table. You can move, or remove it, as needed.
        Me.TABELPENJUALANTableAdapter.Fill(Me.CAFEDataSet.TABELPENJUALAN)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label64.Text = TABELPENJUALANTableAdapter.hitungPenjualan()
    End Sub
End Class