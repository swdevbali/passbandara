<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MigrasiData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MigrasiData))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMulaiMigrasi = New System.Windows.Forms.Button()
        Me.listMigrasi = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Seting Koneksi..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMulaiMigrasi
        '
        Me.btnMulaiMigrasi.Location = New System.Drawing.Point(13, 42)
        Me.btnMulaiMigrasi.Name = "btnMulaiMigrasi"
        Me.btnMulaiMigrasi.Size = New System.Drawing.Size(133, 23)
        Me.btnMulaiMigrasi.TabIndex = 1
        Me.btnMulaiMigrasi.Text = "Mulai proses migrasi"
        Me.btnMulaiMigrasi.UseVisualStyleBackColor = True
        '
        'listMigrasi
        '
        Me.listMigrasi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listMigrasi.FormattingEnabled = True
        Me.listMigrasi.Location = New System.Drawing.Point(13, 85)
        Me.listMigrasi.Name = "listMigrasi"
        Me.listMigrasi.ScrollAlwaysVisible = True
        Me.listMigrasi.Size = New System.Drawing.Size(695, 264)
        Me.listMigrasi.TabIndex = 2
        '
        'MigrasiData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 364)
        Me.Controls.Add(Me.listMigrasi)
        Me.Controls.Add(Me.btnMulaiMigrasi)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MigrasiData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Migrasi Data"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnMulaiMigrasi As System.Windows.Forms.Button
    Friend WithEvents listMigrasi As System.Windows.Forms.ListBox
End Class
