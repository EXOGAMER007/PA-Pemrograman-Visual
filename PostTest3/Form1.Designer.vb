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
        gambar = New PictureBox()
        Browse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtTelpon = New TextBox()
        txtUmur = New TextBox()
        GroupBox1 = New GroupBox()
        radioPerempuan = New RadioButton()
        radioLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        checkJalan = New CheckBox()
        checkTIdur = New CheckBox()
        checkCerita = New CheckBox()
        checkWC = New CheckBox()
        checkHujan = New CheckBox()
        checkKemping = New CheckBox()
        checkNginap = New CheckBox()
        checkBuku = New CheckBox()
        checkInternet = New CheckBox()
        checkGame = New CheckBox()
        tanggal = New DateTimePicker()
        cetak = New Button()
        BukaFile = New OpenFileDialog()
        CType(gambar, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' gambar
        ' 
        gambar.Location = New Point(532, 12)
        gambar.Name = "gambar"
        gambar.Size = New Size(271, 259)
        gambar.SizeMode = PictureBoxSizeMode.Zoom
        gambar.TabIndex = 0
        gambar.TabStop = False
        ' 
        ' Browse
        ' 
        Browse.Location = New Point(626, 277)
        Browse.Name = "Browse"
        Browse.Size = New Size(94, 29)
        Browse.TabIndex = 1
        Browse.Text = "Browse"
        Browse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 4
        Label3.Text = "No. Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 6
        Label5.Text = "TGL. Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 7
        Label6.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(96, 22)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(244, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(96, 88)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(244, 27)
        txtAlamat.TabIndex = 10
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Location = New Point(96, 55)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(244, 27)
        txtTelpon.TabIndex = 11
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(96, 121)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(244, 27)
        txtUmur.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioPerempuan)
        GroupBox1.Controls.Add(radioLaki)
        GroupBox1.Location = New Point(359, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(155, 164)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(6, 106)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(104, 24)
        radioPerempuan.TabIndex = 16
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' radioLaki
        ' 
        radioLaki.AutoSize = True
        radioLaki.Location = New Point(6, 53)
        radioLaki.Name = "radioLaki"
        radioLaki.Size = New Size(85, 24)
        radioLaki.TabIndex = 15
        radioLaki.TabStop = True
        radioLaki.Text = "Laki-laki"
        radioLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(checkJalan)
        GroupBox2.Controls.Add(checkTIdur)
        GroupBox2.Controls.Add(checkCerita)
        GroupBox2.Controls.Add(checkWC)
        GroupBox2.Controls.Add(checkHujan)
        GroupBox2.Controls.Add(checkKemping)
        GroupBox2.Controls.Add(checkNginap)
        GroupBox2.Controls.Add(checkBuku)
        GroupBox2.Controls.Add(checkInternet)
        GroupBox2.Controls.Add(checkGame)
        GroupBox2.Location = New Point(12, 206)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(328, 200)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' checkJalan
        ' 
        checkJalan.AutoSize = True
        checkJalan.Location = New Point(3, 143)
        checkJalan.Name = "checkJalan"
        checkJalan.Size = New Size(101, 24)
        checkJalan.TabIndex = 9
        checkJalan.Text = "jalan-jalan"
        checkJalan.UseVisualStyleBackColor = True
        ' 
        ' checkTIdur
        ' 
        checkTIdur.AutoSize = True
        checkTIdur.Location = New Point(162, 143)
        checkTIdur.Name = "checkTIdur"
        checkTIdur.Size = New Size(62, 24)
        checkTIdur.TabIndex = 8
        checkTIdur.Text = "tidur"
        checkTIdur.UseVisualStyleBackColor = True
        ' 
        ' checkCerita
        ' 
        checkCerita.AutoSize = True
        checkCerita.Location = New Point(3, 113)
        checkCerita.Name = "checkCerita"
        checkCerita.Size = New Size(123, 24)
        checkCerita.TabIndex = 7
        checkCerita.Text = "menulis cerita"
        checkCerita.UseVisualStyleBackColor = True
        ' 
        ' checkWC
        ' 
        checkWC.AutoSize = True
        checkWC.Location = New Point(162, 113)
        checkWC.Name = "checkWC"
        checkWC.Size = New Size(148, 24)
        checkWC.TabIndex = 6
        checkWC.Text = "di wc berjam-jam"
        checkWC.UseVisualStyleBackColor = True
        ' 
        ' checkHujan
        ' 
        checkHujan.AutoSize = True
        checkHujan.Location = New Point(162, 83)
        checkHujan.Name = "checkHujan"
        checkHujan.Size = New Size(104, 24)
        checkHujan.TabIndex = 5
        checkHujan.Text = "main hujan"
        checkHujan.UseVisualStyleBackColor = True
        ' 
        ' checkKemping
        ' 
        checkKemping.AutoSize = True
        checkKemping.Location = New Point(162, 53)
        checkKemping.Name = "checkKemping"
        checkKemping.Size = New Size(89, 24)
        checkKemping.TabIndex = 4
        checkKemping.Text = "kemping"
        checkKemping.UseVisualStyleBackColor = True
        ' 
        ' checkNginap
        ' 
        checkNginap.AutoSize = True
        checkNginap.Location = New Point(162, 23)
        checkNginap.Name = "checkNginap"
        checkNginap.Size = New Size(163, 24)
        checkNginap.TabIndex = 3
        checkNginap.Text = "nginap dirumah org"
        checkNginap.UseVisualStyleBackColor = True
        ' 
        ' checkBuku
        ' 
        checkBuku.AutoSize = True
        checkBuku.Location = New Point(3, 53)
        checkBuku.Name = "checkBuku"
        checkBuku.Size = New Size(99, 24)
        checkBuku.TabIndex = 2
        checkBuku.Text = "baca buku"
        checkBuku.UseVisualStyleBackColor = True
        ' 
        ' checkInternet
        ' 
        checkInternet.AutoSize = True
        checkInternet.Location = New Point(3, 83)
        checkInternet.Name = "checkInternet"
        checkInternet.Size = New Size(159, 24)
        checkInternet.TabIndex = 1
        checkInternet.Text = "menjelajah internet"
        checkInternet.UseVisualStyleBackColor = True
        ' 
        ' checkGame
        ' 
        checkGame.AutoSize = True
        checkGame.Location = New Point(3, 23)
        checkGame.Name = "checkGame"
        checkGame.Size = New Size(94, 24)
        checkGame.TabIndex = 0
        checkGame.Text = "ngegame"
        checkGame.UseVisualStyleBackColor = True
        ' 
        ' tanggal
        ' 
        tanggal.Location = New Point(90, 159)
        tanggal.Name = "tanggal"
        tanggal.Size = New Size(250, 27)
        tanggal.TabIndex = 15
        ' 
        ' cetak
        ' 
        cetak.Location = New Point(12, 435)
        cetak.Name = "cetak"
        cetak.Size = New Size(791, 29)
        cetak.TabIndex = 10
        cetak.Text = "cetak"
        cetak.UseVisualStyleBackColor = True
        ' 
        ' BukaFile
        ' 
        BukaFile.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(815, 490)
        Controls.Add(cetak)
        Controls.Add(tanggal)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtUmur)
        Controls.Add(txtTelpon)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(gambar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Browse)
        Name = "Form1"
        Text = "Form1"
        CType(gambar, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gambar As PictureBox
    Friend WithEvents Browse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents checkJalan As CheckBox
    Friend WithEvents checkTIdur As CheckBox
    Friend WithEvents checkCerita As CheckBox
    Friend WithEvents checkWC As CheckBox
    Friend WithEvents checkHujan As CheckBox
    Friend WithEvents checkKemping As CheckBox
    Friend WithEvents checkNginap As CheckBox
    Friend WithEvents checkBuku As CheckBox
    Friend WithEvents checkInternet As CheckBox
    Friend WithEvents checkGame As CheckBox
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents cetak As Button
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents BukaFile As OpenFileDialog

End Class
