Module Module1
    Public judul(9) As String
    Public genre(9) As String
    Public index As Integer = 0
End Module

Public Class Form1
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        JudulBaru(textJudul1.Text, textGenre.Text)
        view()
    End Sub
    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        If textJudul2.Text <> "" Then
            JudulHapus(textJudul2.Text)
            view()
        Else
            MessageBox.Show("Judul tidak boleh kosong")
        End If
    End Sub

    Public Function PeriksaJudulKosong() As Integer
        Dim i As Integer
        For i = 0 To judul.Length - 1
            If judul(i) = "" Then
                Return i
            End If
            index += 1
        Next
        Return -1
    End Function

    Public Sub JudulHapus(ByVal judulHapus As String)
        For i As Integer = 0 To judul.Length - 1
            If judul(i) = judulHapus Then
                judul(i) = ""
                genre(i) = ""
                Exit For
            End If
        Next
    End Sub

    Public Sub JudulBaru(ByVal judulBaru As String, genreBaru As String)
        Dim index2 As Integer = PeriksaJudulKosong()
        If index <> -1 Then
            judul(index2) = judulBaru
            genre(index2) = genreBaru
            index += 1
        Else
            MessageBox.Show("Data sudah penuh")
        End If
    End Sub

    Public Sub view()
        ListBox1.Items.Clear()
        Dim Perulangan As Integer = 1
        For i As Integer = 0 To judul.Length - 1
            If judul(i) <> "" Then
                ListBox1.Items.Add("Buku ke-" & (Perulangan))
                ListBox1.Items.Add("Judul : " & judul(i))
                ListBox1.Items.Add("Genre : " & genre(i))
                Perulangan += 1
            End If
        Next
    End Sub
End Class
