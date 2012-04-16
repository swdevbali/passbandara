<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FotoDanPencetakanPermohonan
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
        Me.pnlPemberkasan = New System.Windows.Forms.Panel()
        Me.cboPilihBundle = New System.Windows.Forms.ComboBox()
        Me.picCrop = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCetakPassBulanan = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNomorBundle = New System.Windows.Forms.Label()
        Me.pnlBerkasViewer = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPemohon = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStatusPermohonan = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblJenisKartu = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMasaBerlaku = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.sidebarProgress = New DevComponents.DotNetBar.SideBar()
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.pnlPemberkasan.SuspendLayout()
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPemberkasan
        '
        Me.pnlPemberkasan.Controls.Add(Me.cboPilihBundle)
        Me.pnlPemberkasan.Controls.Add(Me.picCrop)
        Me.pnlPemberkasan.Controls.Add(Me.Button1)
        Me.pnlPemberkasan.Controls.Add(Me.btnCetakPassBulanan)
        Me.pnlPemberkasan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPemberkasan.Location = New System.Drawing.Point(3, 214)
        Me.pnlPemberkasan.Name = "pnlPemberkasan"
        Me.pnlPemberkasan.Size = New System.Drawing.Size(653, 367)
        Me.pnlPemberkasan.TabIndex = 8
        '
        'cboPilihBundle
        '
        Me.cboPilihBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPilihBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPilihBundle.FormattingEnabled = True
        Me.cboPilihBundle.Location = New System.Drawing.Point(272, 15)
        Me.cboPilihBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPilihBundle.Name = "cboPilihBundle"
        Me.cboPilihBundle.Size = New System.Drawing.Size(246, 29)
        Me.cboPilihBundle.TabIndex = 60
        Me.cboPilihBundle.Tag = ""
        Me.cboPilihBundle.Text = "G.20120217/2.TN"
        Me.cboPilihBundle.Visible = False
        '
        'picCrop
        '
        Me.picCrop.Location = New System.Drawing.Point(8, 66)
        Me.picCrop.Name = "picCrop"
        Me.picCrop.Size = New System.Drawing.Size(284, 232)
        Me.picCrop.TabIndex = 18
        Me.picCrop.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ambil Foto.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCetakPassBulanan
        '
        Me.btnCetakPassBulanan.Location = New System.Drawing.Point(8, 10)
        Me.btnCetakPassBulanan.Name = "btnCetakPassBulanan"
        Me.btnCetakPassBulanan.Size = New System.Drawing.Size(123, 36)
        Me.btnCetakPassBulanan.TabIndex = 16
        Me.btnCetakPassBulanan.Text = "Cetak Pass.."
        Me.btnCetakPassBulanan.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 614.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNomorBundle, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlBerkasViewer, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPemohon, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatusPermohonan, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblJenisKartu, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMasaBerlaku, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(653, 205)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nomor Bundle"
        '
        'lblNomorBundle
        '
        Me.lblNomorBundle.AutoSize = True
        Me.lblNomorBundle.Location = New System.Drawing.Point(194, 0)
        Me.lblNomorBundle.Name = "lblNomorBundle"
        Me.lblNomorBundle.Size = New System.Drawing.Size(135, 21)
        Me.lblNomorBundle.TabIndex = 7
        Me.lblNomorBundle.Text = "G.20120217/2.TN"
        '
        'pnlBerkasViewer
        '
        Me.pnlBerkasViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBerkasViewer.Location = New System.Drawing.Point(532, 3)
        Me.pnlBerkasViewer.Name = "pnlBerkasViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.pnlBerkasViewer, 6)
        Me.pnlBerkasViewer.Size = New System.Drawing.Size(608, 211)
        Me.pnlBerkasViewer.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pemohon"
        '
        'cboPemohon
        '
        Me.cboPemohon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPemohon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPemohon.FormattingEnabled = True
        Me.cboPemohon.Location = New System.Drawing.Point(194, 38)
        Me.cboPemohon.Name = "cboPemohon"
        Me.cboPemohon.Size = New System.Drawing.Size(253, 29)
        Me.cboPemohon.TabIndex = 8
        Me.cboPemohon.Text = "DADANG HERMAWAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Status Permohonan"
        '
        'lblStatusPermohonan
        '
        Me.lblStatusPermohonan.AutoSize = True
        Me.lblStatusPermohonan.Location = New System.Drawing.Point(194, 71)
        Me.lblStatusPermohonan.Name = "lblStatusPermohonan"
        Me.lblStatusPermohonan.Size = New System.Drawing.Size(42, 21)
        Me.lblStatusPermohonan.TabIndex = 11
        Me.lblStatusPermohonan.Text = "Baru"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Jenis Kartu"
        '
        'lblJenisKartu
        '
        Me.lblJenisKartu.AutoSize = True
        Me.lblJenisKartu.Location = New System.Drawing.Point(194, 110)
        Me.lblJenisKartu.Name = "lblJenisKartu"
        Me.lblJenisKartu.Size = New System.Drawing.Size(66, 21)
        Me.lblJenisKartu.TabIndex = 14
        Me.lblJenisKartu.Text = "Bulanan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Masa Berlaku"
        '
        'lblMasaBerlaku
        '
        Me.lblMasaBerlaku.AutoSize = True
        Me.lblMasaBerlaku.Location = New System.Drawing.Point(194, 151)
        Me.lblMasaBerlaku.Name = "lblMasaBerlaku"
        Me.lblMasaBerlaku.Size = New System.Drawing.Size(93, 21)
        Me.lblMasaBerlaku.TabIndex = 15
        Me.lblMasaBerlaku.Text = "Maret 2012"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlPemberkasan, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(281, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(659, 584)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'sidebarProgress
        '
        Me.sidebarProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.sidebarProgress.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.sidebarProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarProgress.ExpandedPanel = Me.SideBarPanelItem1
        Me.sidebarProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.sidebarProgress.Location = New System.Drawing.Point(0, 0)
        Me.sidebarProgress.Name = "sidebarProgress"
        Me.sidebarProgress.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideBarPanelItem1})
        Me.sidebarProgress.Size = New System.Drawing.Size(278, 584)
        Me.sidebarProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.sidebarProgress.TabIndex = 46
        Me.sidebarProgress.Text = "Bundle Permohonan"
        '
        'SideBarPanelItem1
        '
        Me.SideBarPanelItem1.FontBold = True
        Me.SideBarPanelItem1.Name = "SideBarPanelItem1"
        Me.SideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.SideBarPanelItem1.Text = "SideBarPanelItem1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "New Button"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandableControl = Me.sidebarProgress
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(278, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(3, 584)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 47
        Me.ExpandableSplitter1.TabStop = False
        '
        'FotoDanPencetakanPermohonan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.sidebarProgress)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "FotoDanPencetakanPermohonan"
        Me.Size = New System.Drawing.Size(940, 584)
        Me.Title = "Foto dan Pencetakan Kartu Pass"
        Me.pnlPemberkasan.ResumeLayout(False)
        CType(Me.picCrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPemberkasan As System.Windows.Forms.Panel
    Friend WithEvents picCrop As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCetakPassBulanan As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlBerkasViewer As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPemohon As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblStatusPermohonan As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblJenisKartu As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMasaBerlaku As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sidebarProgress As DevComponents.DotNetBar.SideBar
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents cboPilihBundle As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNomorBundle As System.Windows.Forms.Label

End Class
