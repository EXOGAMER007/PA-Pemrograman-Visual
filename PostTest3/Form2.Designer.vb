<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        txt2Umur = New TextBox()
        txt2Nama = New TextBox()
        txt2Telpon = New TextBox()
        txt2Alamat = New TextBox()
        txt2Hobby = New TextBox()
        txtTanggal = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txt2Kelamin = New TextBox()
        ListHobby = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(61, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txt2Umur
        ' 
        txt2Umur.Font = New Font("Segoe UI", 12F)
        txt2Umur.Location = New Point(453, 113)
        txt2Umur.Name = "txt2Umur"
        txt2Umur.Size = New Size(327, 34)
        txt2Umur.TabIndex = 1
        ' 
        ' txt2Nama
        ' 
        txt2Nama.Font = New Font("Segoe UI", 12F)
        txt2Nama.Location = New Point(453, 73)
        txt2Nama.Name = "txt2Nama"
        txt2Nama.Size = New Size(327, 34)
        txt2Nama.TabIndex = 2
        ' 
        ' txt2Telpon
        ' 
        txt2Telpon.Font = New Font("Segoe UI", 12F)
        txt2Telpon.Location = New Point(453, 153)
        txt2Telpon.Name = "txt2Telpon"
        txt2Telpon.Size = New Size(327, 34)
        txt2Telpon.TabIndex = 3
        ' 
        ' txt2Alamat
        ' 
        txt2Alamat.Font = New Font("Segoe UI", 12F)
        txt2Alamat.Location = New Point(453, 313)
        txt2Alamat.Name = "txt2Alamat"
        txt2Alamat.Size = New Size(325, 34)
        txt2Alamat.TabIndex = 4
        ' 
        ' txt2Hobby
        ' 
        txt2Hobby.Font = New Font("Segoe UI", 12F)
        txt2Hobby.Location = New Point(451, 233)
        txt2Hobby.Name = "txt2Hobby"
        txt2Hobby.Size = New Size(327, 34)
        txt2Hobby.TabIndex = 6
        ' 
        ' txtTanggal
        ' 
        txtTanggal.Font = New Font("Segoe UI", 12F)
        txtTanggal.Location = New Point(453, 273)
        txtTanggal.Name = "txtTanggal"
        txtTanggal.Size = New Size(327, 34)
        txtTanggal.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(351, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 9
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(351, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 28)
        Label2.TabIndex = 10
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(61, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 28)
        Label3.TabIndex = 11
        Label3.Text = "Hobby"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(351, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 28)
        Label4.TabIndex = 12
        Label4.Text = "Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(351, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 28)
        Label5.TabIndex = 13
        Label5.Text = "Kelamin"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(353, 279)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 28)
        Label6.TabIndex = 14
        Label6.Text = "Tanggal"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(351, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 28)
        Label7.TabIndex = 15
        Label7.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(102, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(61, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(261, 50)
        Label9.TabIndex = 17
        Label9.Text = "Kartu Identitas"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(351, 372)
        Label10.Name = "Label10"
        Label10.Size = New Size(423, 50)
        Label10.TabIndex = 18
        Label10.Text = "Universitas Mulawarman"
        ' 
        ' txt2Kelamin
        ' 
        txt2Kelamin.Font = New Font("Segoe UI", 12F)
        txt2Kelamin.Location = New Point(453, 193)
        txt2Kelamin.Name = "txt2Kelamin"
        txt2Kelamin.Size = New Size(327, 34)
        txt2Kelamin.TabIndex = 19
        ' 
        ' ListHobby
        ' 
        ListHobby.FormattingEnabled = True
        ListHobby.Location = New Point(61, 319)
        ListHobby.Name = "ListHobby"
        ListHobby.Size = New Size(261, 104)
        ListHobby.TabIndex = 20
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListHobby)
        Controls.Add(txt2Kelamin)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTanggal)
        Controls.Add(txt2Hobby)
        Controls.Add(txt2Alamat)
        Controls.Add(txt2Telpon)
        Controls.Add(txt2Nama)
        Controls.Add(txt2Umur)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt2Umur As TextBox
    Friend WithEvents txt2Nama As TextBox
    Friend WithEvents txt2Telpon As TextBox
    Friend WithEvents txt2Alamat As TextBox
    Friend WithEvents txt2Hobby As TextBox
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt2Kelamin As TextBox
    Friend WithEvents ListHobby As ListBox
End Class
