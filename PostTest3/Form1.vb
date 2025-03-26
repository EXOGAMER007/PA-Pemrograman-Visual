Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
            OrElse keyascii = Keys.Back _
            OrElse keyascii = Keys.Space _
            OrElse keyascii = Keys.Return _
            OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
            OrElse keyascii = Keys.Back _
            OrElse keyascii = Keys.Space _
            OrElse keyascii = Keys.Return _
            OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Function PeriksaKosong() As Boolean
        If txtAlamat.Text = "" Then Return False
        If txtNama.Text = "" Then Return False
        If txtTelpon.Text = "" Then Return False
        If txtUmur.Text = "" Then Return False

        If Not radioLaki.Checked Or Not radioPerempuan.Checked Or Not checkBuku.Checked Or Not checkCerita.Checked Or Not checkGame.Checked Or Not checkHujan.Checked Or Not checkInternet.Checked Or Not checkJalan.Checked Or Not checkKemping.Checked Or Not checkNginap.Checked Or Not checkTIdur.Checked Or Not checkWC.Checked Then
            Return False
        End If

        If gambar.Image Is Nothing Then Return False

        Return True
    End Function

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        BukaFile.Filter = "PNG Image|*.png|JPG Image|*.jpg"
        If BukaFile.ShowDialog() = DialogResult.OK Then
            gambar.ImageLocation = BukaFile.FileName
        End If
    End Sub

    Private Sub cetak_Click(sender As Object, e As EventArgs) Handles cetak.Click
        Dim hasil As Boolean = PeriksaKosong()

        If hasil = False Then
            MessageBox.Show("Inputan tidak boleh kosong ", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Form2.txt2Nama.Text = txtNama.Text
            Form2.txt2Alamat.Text = txtAlamat.Text
            Form2.txt2Telpon.Text = txtTelpon.Text
            Form2.txt2Umur.Text = txtUmur.Text
            Form2.txtTanggal.Text = tanggal.Text

            If radioLaki.Checked Then Form2.txt2Kelamin.Text = radioLaki.Text
            If radioPerempuan.Checked Then Form2.txt2Kelamin.Text = radioPerempuan.Text

            If checkBuku.Checked Then Form2.ListHobby.Items.Add(checkBuku.Text)
            If checkCerita.Checked Then Form2.ListHobby.Items.Add(checkCerita.Text)
            If checkGame.Checked Then Form2.ListHobby.Items.Add(checkGame.Text)
            If checkHujan.Checked Then Form2.ListHobby.Items.Add(checkHujan.Text)
            If checkInternet.Checked Then Form2.ListHobby.Items.Add(checkInternet.Text)
            If checkJalan.Checked Then Form2.ListHobby.Items.Add(checkJalan.Text)
            If checkKemping.Checked Then Form2.ListHobby.Items.Add(checkKemping.Text)
            If checkNginap.Checked Then Form2.ListHobby.Items.Add(checkNginap.Text)
            If checkTIdur.Checked Then Form2.ListHobby.Items.Add(checkTIdur.Text)
            If checkWC.Checked Then Form2.ListHobby.Items.Add(checkWC.Text)

            Form2.PictureBox1.ImageLocation = BukaFile.FileName
            Form2.Show()
        End If
    End Sub
End Class
