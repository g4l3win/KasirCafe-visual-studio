Public Class formlaporanpenghasilan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dashboardadmin As New dashboardadmin()
        dashboardadmin.Show()
        Me.Close()
    End Sub

    Private Sub formlaporanpenghasilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CAFEDataSet.TABELPENGHASILAN' table. You can move, or remove it, as needed.
        Me.TABELPENGHASILANTableAdapter.Fill(Me.CAFEDataSet.TABELPENGHASILAN)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = TABELPENGHASILANTableAdapter.hitungPenghasilan()
    End Sub
End Class