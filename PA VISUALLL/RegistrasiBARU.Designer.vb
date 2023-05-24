<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrasi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPhoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.Label1.Location = New System.Drawing.Point(24, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Label1.Size = New System.Drawing.Size(64, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.Color.White
        Me.TxtNama.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtNama.Location = New System.Drawing.Point(148, 85)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(154, 29)
        Me.TxtNama.TabIndex = 1
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.MintCream
        Me.Username.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.Username.Location = New System.Drawing.Point(24, 136)
        Me.Username.Name = "Username"
        Me.Username.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Username.Size = New System.Drawing.Size(103, 27)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.White
        Me.TxtUsername.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtUsername.Location = New System.Drawing.Point(148, 136)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(154, 29)
        Me.TxtUsername.TabIndex = 3
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.MintCream
        Me.Pass.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.Pass.Location = New System.Drawing.Point(24, 178)
        Me.Pass.Name = "Pass"
        Me.Pass.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pass.Size = New System.Drawing.Size(99, 27)
        Me.Pass.TabIndex = 4
        Me.Pass.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.White
        Me.TxtPassword.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtPassword.Location = New System.Drawing.Point(148, 181)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(154, 29)
        Me.TxtPassword.TabIndex = 5
        '
        'Alamat
        '
        Me.Alamat.AutoSize = True
        Me.Alamat.BackColor = System.Drawing.Color.MintCream
        Me.Alamat.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.Alamat.Location = New System.Drawing.Point(24, 219)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Alamat.Size = New System.Drawing.Size(75, 27)
        Me.Alamat.TabIndex = 6
        Me.Alamat.Text = "Alamat"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.Color.White
        Me.TxtAlamat.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtAlamat.Location = New System.Drawing.Point(148, 226)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(220, 90)
        Me.TxtAlamat.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 32)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "REGISTRASI"
        '
        'BtnDaftar
        '
        Me.BtnDaftar.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BtnDaftar.Font = New System.Drawing.Font("Footlight MT Light", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDaftar.Location = New System.Drawing.Point(380, 289)
        Me.BtnDaftar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(104, 43)
        Me.BtnDaftar.TabIndex = 46
        Me.BtnDaftar.Text = "Daftar"
        Me.BtnDaftar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button1.Font = New System.Drawing.Font("Footlight MT Light", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(536, 289)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 43)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(442, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'BtnPhoto
        '
        Me.BtnPhoto.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnPhoto.Font = New System.Drawing.Font("Footlight MT Light", 12.875!)
        Me.BtnPhoto.Location = New System.Drawing.Point(456, 226)
        Me.BtnPhoto.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPhoto.Name = "BtnPhoto"
        Me.BtnPhoto.Size = New System.Drawing.Size(104, 27)
        Me.BtnPhoto.TabIndex = 49
        Me.BtnPhoto.Text = "Pilih Foto"
        Me.BtnPhoto.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 374)
        Me.Controls.Add(Me.BtnPhoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormRegistrasi"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Alamat As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnPhoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
