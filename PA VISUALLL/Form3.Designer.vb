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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNama = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.btnUsername = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.BtnPassword = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.Label()
        Me.BtnAlamat = New System.Windows.Forms.TextBox()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'BtnNama
        '
        Me.BtnNama.Location = New System.Drawing.Point(118, 113)
        Me.BtnNama.Name = "BtnNama"
        Me.BtnNama.Size = New System.Drawing.Size(100, 20)
        Me.BtnNama.TabIndex = 1
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(63, 164)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Username"
        '
        'btnUsername
        '
        Me.btnUsername.Location = New System.Drawing.Point(124, 164)
        Me.btnUsername.Name = "btnUsername"
        Me.btnUsername.Size = New System.Drawing.Size(100, 20)
        Me.btnUsername.TabIndex = 3
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.Location = New System.Drawing.Point(63, 205)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(53, 13)
        Me.Pass.TabIndex = 4
        Me.Pass.Text = "Password"
        '
        'BtnPassword
        '
        Me.BtnPassword.Location = New System.Drawing.Point(124, 205)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(100, 20)
        Me.BtnPassword.TabIndex = 5
        '
        'Alamat
        '
        Me.Alamat.AutoSize = True
        Me.Alamat.Location = New System.Drawing.Point(63, 246)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(39, 13)
        Me.Alamat.TabIndex = 6
        Me.Alamat.Text = "Alamat"
        '
        'BtnAlamat
        '
        Me.BtnAlamat.Location = New System.Drawing.Point(124, 243)
        Me.BtnAlamat.Multiline = True
        Me.BtnAlamat.Name = "BtnAlamat"
        Me.BtnAlamat.Size = New System.Drawing.Size(164, 47)
        Me.BtnAlamat.TabIndex = 7
        '
        'BtnDaftar
        '
        Me.BtnDaftar.Location = New System.Drawing.Point(286, 329)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(194, 69)
        Me.BtnDaftar.TabIndex = 8
        Me.BtnDaftar.Text = "Daftar"
        Me.BtnDaftar.UseVisualStyleBackColor = True
        '
        'FormRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.BtnAlamat)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.BtnPassword)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.btnUsername)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.BtnNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRegistrasi"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNama As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents btnUsername As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents BtnPassword As TextBox
    Friend WithEvents Alamat As Label
    Friend WithEvents BtnAlamat As TextBox
    Friend WithEvents BtnDaftar As Button
End Class
