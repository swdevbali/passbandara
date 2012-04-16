<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontlinerPermohonanPage
    Inherits SwdevIUICore.PageTemplate

    'UserControl overrides dispose to clean up the component list.
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
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkTambahBundle = New System.Windows.Forms.LinkLabel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboPilihBundle = New System.Windows.Forms.ComboBox()
        Me.pnlKlien = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Pemberkasan"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.ImagePaddingHorizontal = 8
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Area dan Wilayah"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.ImagePaddingHorizontal = 8
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Foto && Cetak"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "New Button"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.ImagePaddingHorizontal = 8
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Statistik"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.ImagePaddingHorizontal = 8
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "ButtonItem8"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.linkTambahBundle)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.cboPilihBundle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 47)
        Me.Panel1.TabIndex = 65
        '
        'linkTambahBundle
        '
        Me.linkTambahBundle.AutoSize = True
        Me.linkTambahBundle.Location = New System.Drawing.Point(471, 12)
        Me.linkTambahBundle.Name = "linkTambahBundle"
        Me.linkTambahBundle.Size = New System.Drawing.Size(125, 21)
        Me.linkTambahBundle.TabIndex = 67
        Me.linkTambahBundle.TabStop = True
        Me.linkTambahBundle.Text = "Tambah bundle.."
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(182, 23)
        Me.LabelX1.TabIndex = 66
        Me.LabelX1.Text = "Pilih Bundle Permohonan"
        '
        'cboPilihBundle
        '
        Me.cboPilihBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPilihBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPilihBundle.FormattingEnabled = True
        Me.cboPilihBundle.Location = New System.Drawing.Point(218, 8)
        Me.cboPilihBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPilihBundle.Name = "cboPilihBundle"
        Me.cboPilihBundle.Size = New System.Drawing.Size(246, 29)
        Me.cboPilihBundle.TabIndex = 65
        Me.cboPilihBundle.Tag = ""
        '
        'pnlKlien
        '
        Me.pnlKlien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKlien.Location = New System.Drawing.Point(0, 47)
        Me.pnlKlien.Name = "pnlKlien"
        Me.pnlKlien.Size = New System.Drawing.Size(909, 333)
        Me.pnlKlien.TabIndex = 66
        '
        'FrontlinerPermohonanPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlKlien)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "FrontlinerPermohonanPage"
        Me.Size = New System.Drawing.Size(909, 380)
        Me.Title = "Permohonan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlKlien As System.Windows.Forms.Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboPilihBundle As System.Windows.Forms.ComboBox
    Friend WithEvents linkTambahBundle As System.Windows.Forms.LinkLabel

End Class
