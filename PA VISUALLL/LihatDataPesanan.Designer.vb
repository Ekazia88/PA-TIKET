<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatDataPesanan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LihatDataPesanan))
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Datapesanan = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Datapesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.BurlyWood
        Me.Btnback.Font = New System.Drawing.Font("Footlight MT Light", 14.0!)
        Me.Btnback.Location = New System.Drawing.Point(593, 331)
        Me.Btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(106, 46)
        Me.Btnback.TabIndex = 49
        Me.Btnback.Text = "Kembali"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Lihat Data Pesanan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Rockwell", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(161, 78)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 21)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Cari"
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Rockwell", 13.875!)
        Me.TxtCari.Location = New System.Drawing.Point(257, 75)
        Me.TxtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(276, 29)
        Me.TxtCari.TabIndex = 52
        '
        'Datapesanan
        '
        Me.Datapesanan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Datapesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datapesanan.Location = New System.Drawing.Point(81, 122)
        Me.Datapesanan.Name = "Datapesanan"
        Me.Datapesanan.Size = New System.Drawing.Size(618, 191)
        Me.Datapesanan.TabIndex = 53
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusDataToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'HapusDataToolStripMenuItem
        '
        Me.HapusDataToolStripMenuItem.Name = "HapusDataToolStripMenuItem"
        Me.HapusDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HapusDataToolStripMenuItem.Text = "Hapus Data"
        '
        'LihatDataPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 406)
        Me.Controls.Add(Me.Datapesanan)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LihatDataPesanan"
        Me.Text = "LIHAT DATA PESANAN"
        CType(Me.Datapesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnback As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Datapesanan As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HapusDataToolStripMenuItem As ToolStripMenuItem
End Class
