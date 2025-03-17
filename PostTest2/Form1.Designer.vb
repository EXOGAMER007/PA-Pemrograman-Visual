<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        textJudul1 = New TextBox()
        kontainerTambah = New GroupBox()
        tambah = New Button()
        textGenre = New TextBox()
        tambahGenre = New Label()
        tambahJudul = New Label()
        kontainerHapus = New GroupBox()
        hapus = New Button()
        hapusJudul = New Label()
        textJudul2 = New TextBox()
        ListBox1 = New ListBox()
        kontainerTambah.SuspendLayout()
        kontainerHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' textJudul1
        ' 
        textJudul1.Location = New Point(119, 26)
        textJudul1.Name = "textJudul1"
        textJudul1.Size = New Size(125, 27)
        textJudul1.TabIndex = 0
        ' 
        ' kontainerTambah
        ' 
        kontainerTambah.Controls.Add(tambah)
        kontainerTambah.Controls.Add(textGenre)
        kontainerTambah.Controls.Add(tambahGenre)
        kontainerTambah.Controls.Add(tambahJudul)
        kontainerTambah.Controls.Add(textJudul1)
        kontainerTambah.Location = New Point(40, 26)
        kontainerTambah.Name = "kontainerTambah"
        kontainerTambah.Size = New Size(250, 133)
        kontainerTambah.TabIndex = 1
        kontainerTambah.TabStop = False
        kontainerTambah.Text = "Tambah buku"
        ' 
        ' tambah
        ' 
        tambah.Location = New Point(150, 92)
        tambah.Name = "tambah"
        tambah.Size = New Size(94, 29)
        tambah.TabIndex = 4
        tambah.Text = "Tambah"
        tambah.UseVisualStyleBackColor = True
        ' 
        ' textGenre
        ' 
        textGenre.Location = New Point(119, 59)
        textGenre.Name = "textGenre"
        textGenre.Size = New Size(125, 27)
        textGenre.TabIndex = 3
        ' 
        ' tambahGenre
        ' 
        tambahGenre.AutoSize = True
        tambahGenre.Location = New Point(6, 66)
        tambahGenre.Name = "tambahGenre"
        tambahGenre.Size = New Size(48, 20)
        tambahGenre.TabIndex = 2
        tambahGenre.Text = "Genre"
        ' 
        ' tambahJudul
        ' 
        tambahJudul.AutoSize = True
        tambahJudul.Location = New Point(6, 29)
        tambahJudul.Name = "tambahJudul"
        tambahJudul.Size = New Size(79, 20)
        tambahJudul.TabIndex = 1
        tambahJudul.Text = "Judul buku"
        ' 
        ' kontainerHapus
        ' 
        kontainerHapus.Controls.Add(hapus)
        kontainerHapus.Controls.Add(hapusJudul)
        kontainerHapus.Controls.Add(textJudul2)
        kontainerHapus.Location = New Point(296, 26)
        kontainerHapus.Name = "kontainerHapus"
        kontainerHapus.Size = New Size(273, 133)
        kontainerHapus.TabIndex = 3
        kontainerHapus.TabStop = False
        kontainerHapus.Text = "Hapus Buku"
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(173, 92)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 5
        hapus.Text = "Hapus"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' hapusJudul
        ' 
        hapusJudul.AutoSize = True
        hapusJudul.Location = New Point(6, 29)
        hapusJudul.Name = "hapusJudul"
        hapusJudul.Size = New Size(79, 20)
        hapusJudul.TabIndex = 1
        hapusJudul.Text = "Judul buku"
        ' 
        ' textJudul2
        ' 
        textJudul2.Location = New Point(142, 26)
        textJudul2.Name = "textJudul2"
        textJudul2.Size = New Size(125, 27)
        textJudul2.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(46, 200)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(704, 224)
        ListBox1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(kontainerHapus)
        Controls.Add(kontainerTambah)
        Name = "Form1"
        Text = "Form1"
        kontainerTambah.ResumeLayout(False)
        kontainerTambah.PerformLayout()
        kontainerHapus.ResumeLayout(False)
        kontainerHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents textJudul1 As TextBox
    Friend WithEvents kontainerTambah As GroupBox
    Friend WithEvents tambahGenre As Label
    Friend WithEvents tambahJudul As Label
    Friend WithEvents kontainerHapus As GroupBox
    Friend WithEvents hapusJudul As Label
    Friend WithEvents textJudul2 As TextBox
    Friend WithEvents textGenre As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents hapus As Button
    Friend WithEvents ListBox1 As ListBox

End Class
