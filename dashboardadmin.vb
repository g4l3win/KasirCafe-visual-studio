Public Class dashboardadmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormLoginUser As New FormLoginUser()

        ' Menampilkan Form kedua
        FormLoginUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button2.MouseHover
        Dim buttonHover = DirectCast(sender, Button)
        buttonHover.BackColor = Color.White
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave
        Dim buttonLeave = DirectCast(sender, Button)
        buttonLeave.BackColor = Color.Maroon
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim FormInputBarang As New FormInputBarang()

        ' Menampilkan Form kedua
        FormInputBarang.Show()
        Me.Hide()
    End Sub


    Private Sub pictureHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover, PictureBox3.MouseHover, PictureBox5.MouseHover, PictureBox6.MouseHover
        Dim pictureHover = DirectCast(sender, PictureBox)
        pictureHover.BackColor = Color.White
    End Sub

    Private Sub pictureLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, PictureBox3.MouseLeave, PictureBox5.MouseLeave, PictureBox6.MouseLeave
        Dim pictureLeave = DirectCast(sender, PictureBox)
        pictureLeave.BackColor = Color.Brown
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim FormInputKategori As New formInputKategori()

        ' Menampilkan Form kedua
        FormInputKategori.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim formlaporanpenjualan As New Formlaporanpenjualan()
        formlaporanpenjualan.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim formlaporanpenghasilan As New formlaporanpenghasilan()
        formlaporanpenghasilan.Show()
        Me.Close()
    End Sub
End Class