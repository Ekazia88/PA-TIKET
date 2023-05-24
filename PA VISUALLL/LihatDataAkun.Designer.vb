<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatDataAkun
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
        Me.DataAkun = New System.Windows.Forms.DataGridView()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataAkun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataAkun
        '
        Me.DataAkun.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataAkun.Location = New System.Drawing.Point(91, 150)
        Me.DataAkun.Name = "DataAkun"
        Me.DataAkun.Size = New System.Drawing.Size(618, 191)
        Me.DataAkun.TabIndex = 58
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtCari.Location = New System.Drawing.Point(267, 103)
        Me.TxtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(276, 29)
        Me.TxtCari.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Rockwell", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(171, 106)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 21)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Cari"
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.BurlyWood
        Me.Btnback.Font = New System.Drawing.Font("Footlight MT Light", 14.0!)
        Me.Btnback.Location = New System.Drawing.Point(603, 359)
        Me.Btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(106, 46)
        Me.Btnback.TabIndex = 55
        Me.Btnback.Text = "Kembali"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 32)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Lihat Data Akun"
        '
        'LihatDataAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_VISUALLL.My.Resources.Resources.Travel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataAkun)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LihatDataAkun"
        Me.Text = "Data Akun"
        CType(Me.DataAkun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataAkun As DataGridView
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Btnback As Button
    Friend WithEvents Label1 As Label
End Class
