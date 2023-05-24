<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
        Me.Pesan = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLihatPesan = New System.Windows.Forms.Button()
        Me.BtnProfil = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnPesan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pesan
        '
        Me.Pesan.AutoSize = True
        Me.Pesan.BackColor = System.Drawing.Color.Transparent
        Me.Pesan.Font = New System.Drawing.Font("Goudy Stout", 24.0!)
        Me.Pesan.Location = New System.Drawing.Point(205, 28)
        Me.Pesan.Name = "Pesan"
        Me.Pesan.Size = New System.Drawing.Size(315, 44)
        Me.Pesan.TabIndex = 2
        Me.Pesan.Text = "Welcome"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.LightBlue
        Me.Username.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(570, 112)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(103, 39)
        Me.Username.TabIndex = 4
        Me.Username.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(548, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BtnLihatPesan
        '
        Me.BtnLihatPesan.BackColor = System.Drawing.Color.LightBlue
        Me.BtnLihatPesan.Font = New System.Drawing.Font("Footlight MT Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLihatPesan.Location = New System.Drawing.Point(78, 106)
        Me.BtnLihatPesan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLihatPesan.Name = "BtnLihatPesan"
        Me.BtnLihatPesan.Size = New System.Drawing.Size(218, 53)
        Me.BtnLihatPesan.TabIndex = 11
        Me.BtnLihatPesan.Text = "Lihat Pesanan"
        Me.BtnLihatPesan.UseVisualStyleBackColor = False
        '
        'BtnProfil
        '
        Me.BtnProfil.BackColor = System.Drawing.Color.LightBlue
        Me.BtnProfil.Font = New System.Drawing.Font("Footlight MT Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfil.Location = New System.Drawing.Point(510, 334)
        Me.BtnProfil.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnProfil.Name = "BtnProfil"
        Me.BtnProfil.Size = New System.Drawing.Size(218, 53)
        Me.BtnProfil.TabIndex = 13
        Me.BtnProfil.Text = "Lihat Profil"
        Me.BtnProfil.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnKeluar.Font = New System.Drawing.Font("Footlight MT Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(78, 304)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(218, 53)
        Me.BtnKeluar.TabIndex = 14
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'BtnPesan
        '
        Me.BtnPesan.BackColor = System.Drawing.Color.LightBlue
        Me.BtnPesan.Font = New System.Drawing.Font("Footlight MT Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesan.Location = New System.Drawing.Point(78, 211)
        Me.BtnPesan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPesan.Name = "BtnPesan"
        Me.BtnPesan.Size = New System.Drawing.Size(218, 53)
        Me.BtnPesan.TabIndex = 15
        Me.BtnPesan.Text = "Pesan"
        Me.BtnPesan.UseVisualStyleBackColor = False
        '
        'MenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.PA_VISUALLL.My.Resources.Resources.Travel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPesan)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnProfil)
        Me.Controls.Add(Me.BtnLihatPesan)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pesan)
        Me.DoubleBuffered = True
        Me.Name = "MenuUser"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Menu User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pesan As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As Label
    Friend WithEvents BtnLihatPesan As Button
    Friend WithEvents BtnProfil As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnPesan As Button
End Class
