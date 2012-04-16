<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaWilayahPermohonan
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnKirim = New DevComponents.DotNetBar.ButtonX()
        Me.pnlBerkasViewer = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.cboPemohon = New System.Windows.Forms.ComboBox()
        Me.cboPilihBundle = New System.Windows.Forms.ComboBox()
        Me.pnlPemberkasan = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkT3 = New System.Windows.Forms.CheckBox()
        Me.txtNomorPass = New System.Windows.Forms.TextBox()
        Me.chkT2 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkT1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboWilayahKerjaQ = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaX = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaM = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaY = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaG = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaZ = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaS = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaV = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaP = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaA = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaC = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaGMF = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaB = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaR = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaT = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.sidebarProgress = New DevComponents.DotNetBar.SideBar()
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlPemberkasan.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pemohon"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 614.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnKirim, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlBerkasViewer, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPemohon, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(828, 153)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'btnKirim
        '
        Me.btnKirim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKirim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnKirim, 2)
        Me.btnKirim.Enabled = False
        Me.btnKirim.Location = New System.Drawing.Point(3, 3)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(423, 65)
        Me.btnKirim.TabIndex = 62
        Me.btnKirim.Text = "Kirim ke Verifikasi Kasubag Perencanaan dan Keuangan"
        '
        'pnlBerkasViewer
        '
        Me.pnlBerkasViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBerkasViewer.Location = New System.Drawing.Point(532, 3)
        Me.pnlBerkasViewer.Name = "pnlBerkasViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.pnlBerkasViewer, 4)
        Me.pnlBerkasViewer.Size = New System.Drawing.Size(608, 147)
        Me.pnlBerkasViewer.TabIndex = 9
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(194, 111)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(181, 31)
        Me.ButtonX1.TabIndex = 62
        Me.ButtonX1.Text = "Simpan Perubahan "
        '
        'cboPemohon
        '
        Me.cboPemohon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPemohon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPemohon.FormattingEnabled = True
        Me.cboPemohon.Location = New System.Drawing.Point(194, 76)
        Me.cboPemohon.Name = "cboPemohon"
        Me.cboPemohon.Size = New System.Drawing.Size(253, 29)
        Me.cboPemohon.TabIndex = 8
        Me.cboPemohon.Text = "DADANG HERMAWAN"
        '
        'cboPilihBundle
        '
        Me.cboPilihBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPilihBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPilihBundle.FormattingEnabled = True
        Me.cboPilihBundle.Location = New System.Drawing.Point(586, 71)
        Me.cboPilihBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPilihBundle.Name = "cboPilihBundle"
        Me.cboPilihBundle.Size = New System.Drawing.Size(134, 29)
        Me.cboPilihBundle.TabIndex = 61
        Me.cboPilihBundle.Tag = ""
        Me.cboPilihBundle.Text = "G.20120217/2.TN"
        Me.cboPilihBundle.Visible = False
        '
        'pnlPemberkasan
        '
        Me.pnlPemberkasan.Controls.Add(Me.Label8)
        Me.pnlPemberkasan.Controls.Add(Me.chkT3)
        Me.pnlPemberkasan.Controls.Add(Me.txtNomorPass)
        Me.pnlPemberkasan.Controls.Add(Me.cboPilihBundle)
        Me.pnlPemberkasan.Controls.Add(Me.chkT2)
        Me.pnlPemberkasan.Controls.Add(Me.Label14)
        Me.pnlPemberkasan.Controls.Add(Me.chkT1)
        Me.pnlPemberkasan.Controls.Add(Me.Label13)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaQ)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaX)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaM)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaY)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaG)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaZ)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaS)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaV)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaP)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaA)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaC)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaGMF)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaB)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaR)
        Me.pnlPemberkasan.Controls.Add(Me.cboWilayahKerjaT)
        Me.pnlPemberkasan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPemberkasan.Location = New System.Drawing.Point(3, 162)
        Me.pnlPemberkasan.Name = "pnlPemberkasan"
        Me.pnlPemberkasan.Size = New System.Drawing.Size(828, 610)
        Me.pnlPemberkasan.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 21)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Nomor Pass"
        '
        'chkT3
        '
        Me.chkT3.AutoSize = True
        Me.chkT3.Location = New System.Drawing.Point(194, 219)
        Me.chkT3.Name = "chkT3"
        Me.chkT3.Size = New System.Drawing.Size(55, 25)
        Me.chkT3.TabIndex = 46
        Me.chkT3.Text = "T. III"
        Me.chkT3.UseVisualStyleBackColor = True
        '
        'txtNomorPass
        '
        Me.txtNomorPass.Location = New System.Drawing.Point(194, 15)
        Me.txtNomorPass.Name = "txtNomorPass"
        Me.txtNomorPass.Size = New System.Drawing.Size(240, 28)
        Me.txtNomorPass.TabIndex = 28
        Me.txtNomorPass.Tag = "Nomor Pass"
        '
        'chkT2
        '
        Me.chkT2.AutoSize = True
        Me.chkT2.Location = New System.Drawing.Point(194, 190)
        Me.chkT2.Name = "chkT2"
        Me.chkT2.Size = New System.Drawing.Size(51, 25)
        Me.chkT2.TabIndex = 45
        Me.chkT2.Text = "T. II"
        Me.chkT2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 21)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Terminal"
        '
        'chkT1
        '
        Me.chkT1.AutoSize = True
        Me.chkT1.Location = New System.Drawing.Point(194, 162)
        Me.chkT1.Name = "chkT1"
        Me.chkT1.Size = New System.Drawing.Size(47, 25)
        Me.chkT1.TabIndex = 44
        Me.chkT1.Text = "T. I"
        Me.chkT1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Wilayah Kerja"
        '
        'cboWilayahKerjaQ
        '
        Me.cboWilayahKerjaQ.AutoSize = True
        Me.cboWilayahKerjaQ.Location = New System.Drawing.Point(410, 120)
        Me.cboWilayahKerjaQ.Name = "cboWilayahKerjaQ"
        Me.cboWilayahKerjaQ.Size = New System.Drawing.Size(40, 25)
        Me.cboWilayahKerjaQ.TabIndex = 43
        Me.cboWilayahKerjaQ.Text = "Q"
        Me.cboWilayahKerjaQ.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaX
        '
        Me.cboWilayahKerjaX.AutoSize = True
        Me.cboWilayahKerjaX.Location = New System.Drawing.Point(194, 53)
        Me.cboWilayahKerjaX.Name = "cboWilayahKerjaX"
        Me.cboWilayahKerjaX.Size = New System.Drawing.Size(38, 25)
        Me.cboWilayahKerjaX.TabIndex = 29
        Me.cboWilayahKerjaX.Text = "X"
        Me.cboWilayahKerjaX.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaM
        '
        Me.cboWilayahKerjaM.AutoSize = True
        Me.cboWilayahKerjaM.Location = New System.Drawing.Point(362, 120)
        Me.cboWilayahKerjaM.Name = "cboWilayahKerjaM"
        Me.cboWilayahKerjaM.Size = New System.Drawing.Size(44, 25)
        Me.cboWilayahKerjaM.TabIndex = 42
        Me.cboWilayahKerjaM.Text = "M"
        Me.cboWilayahKerjaM.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaY
        '
        Me.cboWilayahKerjaY.AutoSize = True
        Me.cboWilayahKerjaY.Location = New System.Drawing.Point(260, 53)
        Me.cboWilayahKerjaY.Name = "cboWilayahKerjaY"
        Me.cboWilayahKerjaY.Size = New System.Drawing.Size(37, 25)
        Me.cboWilayahKerjaY.TabIndex = 30
        Me.cboWilayahKerjaY.Text = "Y"
        Me.cboWilayahKerjaY.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaG
        '
        Me.cboWilayahKerjaG.AutoSize = True
        Me.cboWilayahKerjaG.Location = New System.Drawing.Point(315, 120)
        Me.cboWilayahKerjaG.Name = "cboWilayahKerjaG"
        Me.cboWilayahKerjaG.Size = New System.Drawing.Size(40, 25)
        Me.cboWilayahKerjaG.TabIndex = 41
        Me.cboWilayahKerjaG.Text = "G"
        Me.cboWilayahKerjaG.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaZ
        '
        Me.cboWilayahKerjaZ.AutoSize = True
        Me.cboWilayahKerjaZ.Location = New System.Drawing.Point(315, 53)
        Me.cboWilayahKerjaZ.Name = "cboWilayahKerjaZ"
        Me.cboWilayahKerjaZ.Size = New System.Drawing.Size(37, 25)
        Me.cboWilayahKerjaZ.TabIndex = 31
        Me.cboWilayahKerjaZ.Text = "Z"
        Me.cboWilayahKerjaZ.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaS
        '
        Me.cboWilayahKerjaS.AutoSize = True
        Me.cboWilayahKerjaS.Location = New System.Drawing.Point(260, 120)
        Me.cboWilayahKerjaS.Name = "cboWilayahKerjaS"
        Me.cboWilayahKerjaS.Size = New System.Drawing.Size(37, 25)
        Me.cboWilayahKerjaS.TabIndex = 40
        Me.cboWilayahKerjaS.Text = "S"
        Me.cboWilayahKerjaS.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaV
        '
        Me.cboWilayahKerjaV.AutoSize = True
        Me.cboWilayahKerjaV.Location = New System.Drawing.Point(362, 53)
        Me.cboWilayahKerjaV.Name = "cboWilayahKerjaV"
        Me.cboWilayahKerjaV.Size = New System.Drawing.Size(39, 25)
        Me.cboWilayahKerjaV.TabIndex = 32
        Me.cboWilayahKerjaV.Text = "V"
        Me.cboWilayahKerjaV.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaP
        '
        Me.cboWilayahKerjaP.AutoSize = True
        Me.cboWilayahKerjaP.Location = New System.Drawing.Point(194, 120)
        Me.cboWilayahKerjaP.Name = "cboWilayahKerjaP"
        Me.cboWilayahKerjaP.Size = New System.Drawing.Size(38, 25)
        Me.cboWilayahKerjaP.TabIndex = 39
        Me.cboWilayahKerjaP.Text = "P"
        Me.cboWilayahKerjaP.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaA
        '
        Me.cboWilayahKerjaA.AutoSize = True
        Me.cboWilayahKerjaA.Location = New System.Drawing.Point(410, 53)
        Me.cboWilayahKerjaA.Name = "cboWilayahKerjaA"
        Me.cboWilayahKerjaA.Size = New System.Drawing.Size(39, 25)
        Me.cboWilayahKerjaA.TabIndex = 33
        Me.cboWilayahKerjaA.Text = "A"
        Me.cboWilayahKerjaA.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaC
        '
        Me.cboWilayahKerjaC.AutoSize = True
        Me.cboWilayahKerjaC.Location = New System.Drawing.Point(410, 85)
        Me.cboWilayahKerjaC.Name = "cboWilayahKerjaC"
        Me.cboWilayahKerjaC.Size = New System.Drawing.Size(38, 25)
        Me.cboWilayahKerjaC.TabIndex = 38
        Me.cboWilayahKerjaC.Text = "C"
        Me.cboWilayahKerjaC.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaGMF
        '
        Me.cboWilayahKerjaGMF.AutoSize = True
        Me.cboWilayahKerjaGMF.Location = New System.Drawing.Point(194, 85)
        Me.cboWilayahKerjaGMF.Name = "cboWilayahKerjaGMF"
        Me.cboWilayahKerjaGMF.Size = New System.Drawing.Size(63, 25)
        Me.cboWilayahKerjaGMF.TabIndex = 34
        Me.cboWilayahKerjaGMF.Text = "GMF"
        Me.cboWilayahKerjaGMF.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaB
        '
        Me.cboWilayahKerjaB.AutoSize = True
        Me.cboWilayahKerjaB.Location = New System.Drawing.Point(362, 85)
        Me.cboWilayahKerjaB.Name = "cboWilayahKerjaB"
        Me.cboWilayahKerjaB.Size = New System.Drawing.Size(38, 25)
        Me.cboWilayahKerjaB.TabIndex = 37
        Me.cboWilayahKerjaB.Text = "B"
        Me.cboWilayahKerjaB.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaR
        '
        Me.cboWilayahKerjaR.AutoSize = True
        Me.cboWilayahKerjaR.Location = New System.Drawing.Point(260, 85)
        Me.cboWilayahKerjaR.Name = "cboWilayahKerjaR"
        Me.cboWilayahKerjaR.Size = New System.Drawing.Size(38, 25)
        Me.cboWilayahKerjaR.TabIndex = 35
        Me.cboWilayahKerjaR.Text = "R"
        Me.cboWilayahKerjaR.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaT
        '
        Me.cboWilayahKerjaT.AutoSize = True
        Me.cboWilayahKerjaT.Location = New System.Drawing.Point(315, 85)
        Me.cboWilayahKerjaT.Name = "cboWilayahKerjaT"
        Me.cboWilayahKerjaT.Size = New System.Drawing.Size(37, 25)
        Me.cboWilayahKerjaT.TabIndex = 36
        Me.cboWilayahKerjaT.Text = "T"
        Me.cboWilayahKerjaT.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(834, 775)
        Me.TableLayoutPanel2.TabIndex = 9
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
        Me.sidebarProgress.Size = New System.Drawing.Size(278, 775)
        Me.sidebarProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.sidebarProgress.TabIndex = 47
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
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(3, 775)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 48
        Me.ExpandableSplitter1.TabStop = False
        '
        'AreaWilayahPermohonan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.sidebarProgress)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "AreaWilayahPermohonan"
        Me.Size = New System.Drawing.Size(1115, 775)
        Me.Title = "Area dan Terminal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlPemberkasan.ResumeLayout(False)
        Me.pnlPemberkasan.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboPemohon As System.Windows.Forms.ComboBox
    Friend WithEvents pnlBerkasViewer As System.Windows.Forms.Panel
    Friend WithEvents pnlPemberkasan As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkT3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNomorPass As System.Windows.Forms.TextBox
    Friend WithEvents chkT2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkT1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboWilayahKerjaQ As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaX As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaM As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaY As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaG As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaZ As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaS As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaV As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaP As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaA As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaC As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaGMF As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaB As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaR As System.Windows.Forms.CheckBox
    Friend WithEvents cboWilayahKerjaT As System.Windows.Forms.CheckBox
    Friend WithEvents sidebarProgress As DevComponents.DotNetBar.SideBar
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents cboPilihBundle As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnKirim As DevComponents.DotNetBar.ButtonX

End Class
