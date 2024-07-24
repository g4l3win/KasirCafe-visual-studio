Imports System.Data.SqlClient
Imports kasir_cafe.CAFEDataSetTableAdapters

Public Class FormLoginUser
    Private connectionString As String = "Data Source=LAPTOP-FTNPN94M;Initial Catalog=cafe;Integrated Security=True"
    'Data Source = laptop - ftnpn94m;Initial Catalog=cafe;User ID=rootLAPTOP-FTNPN94M\Acer;Password=Untar2022;
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim SqlLogin = "select [role] from [dbo].[login] where [username] =@user and [password] = @password;"
        Dim role As String = ""
        Using connectionLogin As New SqlConnection(connectionString),
        cmd As New SqlCommand(SqlLogin, connectionLogin)
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text
            connectionLogin.Open()
            role = CStr(cmd.ExecuteScalar)
        End Using 'closed the Connection and disposes the Connection and Command

        If String.IsNullOrEmpty(role) Then
            MessageBox.Show("Password atau Username salah. Coba Lagi", "Login Gagal", MessageBoxButtons.OK)
        Else
            If role = "admin" Then
                MessageBox.Show("Login Berhasil Selamat datang Admin", "Login Berhasil", MessageBoxButtons.OK)
                Dim dashboardadmin As New dashboardadmin()
                dashboardadmin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Berhasil Selamat datang Pelanggan", "Login Berhasil", MessageBoxButtons.OK)
                Dim dashboardpelanggan As New dashboardpelanggan()
                dashboardpelanggan.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()

    End Sub

End Class