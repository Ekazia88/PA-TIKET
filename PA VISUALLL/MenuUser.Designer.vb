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
        Me.BtnLihatPesan = New System.Windows.Forms.Button()
        Me.BtnPesan = New System.Windows.Forms.Button()
        Me.Pesan = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLihatPesan
        '
        Me.BtnLihatPesan.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnLihatPesan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLihatPesan.Location = New System.Drawing.Point(78, 111)
        Me.BtnLihatPesan.Name = "BtnLihatPesan"
        Me.BtnLihatPesan.Size = New System.Drawing.Size(217, 53)
        Me.BtnLihatPesan.TabIndex = 0
        Me.BtnLihatPesan.Text = "Lihat Pesanan"
        Me.BtnLihatPesan.UseVisualStyleBackColor = False
        '
        'BtnPesan
        '
        Me.BtnPesan.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnPesan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnPesan.Location = New System.Drawing.Point(78, 222)
        Me.BtnPesan.Name = "BtnPesan"
        Me.BtnPesan.Size = New System.Drawing.Size(217, 53)
        Me.BtnPesan.TabIndex = 1
        Me.BtnPesan.Text = "Pesan"
        Me.BtnPesan.UseVisualStyleBackColor = False
        '
        'Pesan
        '
        Me.Pesan.AutoSize = True
        Me.Pesan.Font = New System.Drawing.Font("Goudy Stout", 24.0!)
        Me.Pesan.Location = New System.Drawing.Point(70, 26)
        Me.Pesan.Name = "Pesan"
        Me.Pesan.Size = New System.Drawing.Size(315, 44)
        Me.Pesan.TabIndex = 2
        Me.Pesan.Text = "Welcome"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Goudy Stout", 24.0!)
        Me.Username.Location = New System.Drawing.Point(442, 26)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(239, 44)
        Me.Username.TabIndex = 4
        Me.Username.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(524, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Lihat Profil"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA_VISUALLL.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(524, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Location = New System.Drawing.Point(78, 313)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(217, 53)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Keluar"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'MenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pesan)
        Me.Controls.Add(Me.BtnPesan)
        Me.Controls.Add(Me.BtnLihatPesan)
        Me.Name = "MenuUser"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLihatPesan As Button
    Friend WithEvents BtnPesan As Button
    Friend WithEvents Pesan As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnExit As Button
End Class
