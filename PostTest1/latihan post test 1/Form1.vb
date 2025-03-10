Public Class Form1
    Dim IP, IPK, Jumlah As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IP += TextBox1.Text
        Jumlah += 1
        IPK = IP / Jumlah
        TextBox2.Text = IPK
        TextBox1.Text = ""
        If IPK >= 3.1 Then
            Label3.Text = "Sangat Memuaskan"
        ElseIf IPK >= 2.76 And IPK <= 3.0 Then
            Label3.Text = "Memuaskan"
        ElseIf IPK >= 2.0 And IPK <= 2.75 Then
            Label3.Text = "Cukup"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IP = 0
        IPK = 0
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub
End Class
