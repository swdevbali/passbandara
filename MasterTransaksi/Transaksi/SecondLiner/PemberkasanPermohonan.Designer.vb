<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PemberkasanPermohonan
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBerkasViewer = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPemohon = New System.Windows.Forms.ComboBox()
        Me.cboPilihBundle = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPemberkasan = New System.Windows.Forms.Panel()
        Me.sidebarProgress = New DevComponents.DotNetBar.SideBar()
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.btnKirim = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 437.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlBerkasViewer, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPilihBundle, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnKirim, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPemohon, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(705, 157)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'pnlBerkasViewer
        '
        Me.pnlBerkasViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBerkasViewer.Location = New System.Drawing.Point(631, 3)
        Me.pnlBerkasViewer.Name = "pnlBerkasViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.pnlBerkasViewer, 2)
        Me.pnlBerkasViewer.Size = New System.Drawing.Size(136, 109)
        Me.pnlBerkasViewer.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pemohon"
        '
        'cboPemohon
        '
        Me.cboPemohon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPemohon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPemohon.Enabled = False
        Me.cboPemohon.FormattingEnabled = True
        Me.cboPemohon.Location = New System.Drawing.Point(194, 79)
        Me.cboPemohon.Name = "cboPemohon"
        Me.cboPemohon.Size = New System.Drawing.Size(270, 29)
        Me.cboPemohon.TabIndex = 8
        Me.cboPemohon.Text = "DADANG HERMAWAN"
        '
        'cboPilihBundle
        '
        Me.cboPilihBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPilihBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPilihBundle.FormattingEnabled = True
        Me.cboPilihBundle.Location = New System.Drawing.Point(632, 119)
        Me.cboPilihBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPilihBundle.Name = "cboPilihBundle"
        Me.cboPilihBundle.Size = New System.Drawing.Size(134, 29)
        Me.cboPilihBundle.TabIndex = 60
        Me.cboPilihBundle.Tag = ""
        Me.cboPilihBundle.Text = "G.20120217/2.TN"
        Me.cboPilihBundle.Visible = False
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(711, 643)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'pnlPemberkasan
        '
        Me.pnlPemberkasan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPemberkasan.Location = New System.Drawing.Point(3, 166)
        Me.pnlPemberkasan.Name = "pnlPemberkasan"
        Me.pnlPemberkasan.Size = New System.Drawing.Size(705, 474)
        Me.pnlPemberkasan.TabIndex = 8
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
        Me.sidebarProgress.Size = New System.Drawing.Size(278, 643)
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
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(3, 643)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 47
        Me.ExpandableSplitter1.TabStop = False
        '
        'btnKirim
        '
        Me.btnKirim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKirim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnKirim, 2)
        Me.btnKirim.Enabled = False
        Me.btnKirim.Image = Global.TransaksiModule.My.Resources.Resources.bt_disetujui_64
        Me.btnKirim.Location = New System.Drawing.Point(3, 3)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(461, 65)
        Me.btnKirim.TabIndex = 61
        Me.btnKirim.Text = "Kirim ke Proses Screening/Verifikasi Administrasi Kasubag Perencanaan dan Keuanga" & _
            "n"
        '
        'PemberkasanPermohonan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.sidebarProgress)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "PemberkasanPermohonan"
        Me.Size = New System.Drawing.Size(992, 643)
        Me.Title = "Pemberkasan Permohonan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlPemberkasan As System.Windows.Forms.Panel
    Friend WithEvents cboPemohon As System.Windows.Forms.ComboBox
    Friend WithEvents pnlBerkasViewer As System.Windows.Forms.Panel
    Friend WithEvents sidebarProgress As DevComponents.DotNetBar.SideBar
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents cboPilihBundle As System.Windows.Forms.ComboBox
    Friend WithEvents btnKirim As DevComponents.DotNetBar.ButtonX

End Class
