<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengaturanAwal
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tableData2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNomorBundle = New System.Windows.Forms.TextBox()
        Me.lblSudahDikirim = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPengurusBundle = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtTanggalMasukBundle = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboInstansiBundle = New System.Windows.Forms.ComboBox()
        Me.txtNomorSurat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboStatusBundle = New System.Windows.Forms.ComboBox()
        Me.numJumlahPermohonan = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSisaKuota = New System.Windows.Forms.Label()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.idtb_permohonan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Pemohon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis_Kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idtb_pemohon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusPermohonanIniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadAutocompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdatePermohonan = New DevComponents.DotNetBar.ButtonX()
        Me.btnKirim = New DevComponents.DotNetBar.ButtonX()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.pnlFormEntry = New System.Windows.Forms.Panel()
        Me.btnHapusBendel = New DevComponents.DotNetBar.ButtonX()
        Me.btnUpdateBendel = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.tableData2.SuspendLayout()
        CType(Me.numJumlahPermohonan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlFormEntry.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableData2
        '
        Me.tableData2.ColumnCount = 3
        Me.tableData2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tableData2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256.0!))
        Me.tableData2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.tableData2.Controls.Add(Me.Label1, 0, 1)
        Me.tableData2.Controls.Add(Me.Label9, 0, 0)
        Me.tableData2.Controls.Add(Me.txtNomorBundle, 1, 0)
        Me.tableData2.Controls.Add(Me.lblSudahDikirim, 0, 5)
        Me.tableData2.Controls.Add(Me.Label12, 0, 4)
        Me.tableData2.Controls.Add(Me.txtPengurusBundle, 1, 4)
        Me.tableData2.Controls.Add(Me.Label11, 0, 3)
        Me.tableData2.Controls.Add(Me.dtTanggalMasukBundle, 1, 3)
        Me.tableData2.Controls.Add(Me.Label10, 0, 2)
        Me.tableData2.Controls.Add(Me.cboInstansiBundle, 1, 2)
        Me.tableData2.Controls.Add(Me.txtNomorSurat, 1, 1)
        Me.tableData2.Location = New System.Drawing.Point(14, 10)
        Me.tableData2.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData2.Name = "tableData2"
        Me.tableData2.RowCount = 6
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tableData2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tableData2.Size = New System.Drawing.Size(701, 240)
        Me.tableData2.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Nomor Surat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 21)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Nomor Bundle"
        '
        'txtNomorBundle
        '
        Me.txtNomorBundle.Location = New System.Drawing.Point(194, 4)
        Me.txtNomorBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomorBundle.Name = "txtNomorBundle"
        Me.txtNomorBundle.Size = New System.Drawing.Size(246, 28)
        Me.txtNomorBundle.TabIndex = 0
        '
        'lblSudahDikirim
        '
        Me.lblSudahDikirim.AutoSize = True
        Me.tableData2.SetColumnSpan(Me.lblSudahDikirim, 3)
        Me.lblSudahDikirim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSudahDikirim.Location = New System.Drawing.Point(3, 218)
        Me.lblSudahDikirim.Name = "lblSudahDikirim"
        Me.lblSudahDikirim.Size = New System.Drawing.Size(695, 37)
        Me.lblSudahDikirim.TabIndex = 54
        Me.lblSudahDikirim.Text = "* status sudah dikirim belum *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 178)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 21)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Pengurus"
        '
        'txtPengurusBundle
        '
        Me.txtPengurusBundle.Location = New System.Drawing.Point(194, 182)
        Me.txtPengurusBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPengurusBundle.Name = "txtPengurusBundle"
        Me.txtPengurusBundle.Size = New System.Drawing.Size(246, 28)
        Me.txtPengurusBundle.TabIndex = 4
        Me.txtPengurusBundle.Tag = "pengurus"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 136)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 21)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Tanggal Masuk Proses"
        '
        'dtTanggalMasukBundle
        '
        Me.dtTanggalMasukBundle.CustomFormat = " "
        Me.dtTanggalMasukBundle.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalMasukBundle.Location = New System.Drawing.Point(194, 140)
        Me.dtTanggalMasukBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.dtTanggalMasukBundle.Name = "dtTanggalMasukBundle"
        Me.dtTanggalMasukBundle.Size = New System.Drawing.Size(246, 28)
        Me.dtTanggalMasukBundle.TabIndex = 3
        Me.dtTanggalMasukBundle.Tag = "Tgl Masuk"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Instansi"
        '
        'cboInstansiBundle
        '
        Me.cboInstansiBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstansiBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstansiBundle.FormattingEnabled = True
        Me.cboInstansiBundle.Location = New System.Drawing.Point(194, 95)
        Me.cboInstansiBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInstansiBundle.Name = "cboInstansiBundle"
        Me.cboInstansiBundle.Size = New System.Drawing.Size(246, 29)
        Me.cboInstansiBundle.TabIndex = 2
        Me.cboInstansiBundle.Tag = "idtb_pemohon"
        '
        'txtNomorSurat
        '
        Me.txtNomorSurat.Location = New System.Drawing.Point(194, 46)
        Me.txtNomorSurat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomorSurat.Name = "txtNomorSurat"
        Me.txtNomorSurat.Size = New System.Drawing.Size(246, 28)
        Me.txtNomorSurat.TabIndex = 1
        Me.txtNomorSurat.Tag = "nomor_surat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(723, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Status"
        Me.Label7.Visible = False
        '
        'cboStatusBundle
        '
        Me.cboStatusBundle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatusBundle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatusBundle.FormattingEnabled = True
        Me.cboStatusBundle.Items.AddRange(New Object() {"--Pilih status bundel ini--", "Sedang diproses", "Selesai diproses"})
        Me.cboStatusBundle.Location = New System.Drawing.Point(727, 44)
        Me.cboStatusBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStatusBundle.Name = "cboStatusBundle"
        Me.cboStatusBundle.Size = New System.Drawing.Size(246, 29)
        Me.cboStatusBundle.TabIndex = 53
        Me.cboStatusBundle.Tag = "status"
        Me.cboStatusBundle.Visible = False
        '
        'numJumlahPermohonan
        '
        Me.numJumlahPermohonan.Location = New System.Drawing.Point(167, 11)
        Me.numJumlahPermohonan.Name = "numJumlahPermohonan"
        Me.numJumlahPermohonan.Size = New System.Drawing.Size(135, 28)
        Me.numJumlahPermohonan.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 21)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Jumlah Permohonan"
        '
        'lblSisaKuota
        '
        Me.lblSisaKuota.AutoSize = True
        Me.lblSisaKuota.Location = New System.Drawing.Point(8, 42)
        Me.lblSisaKuota.Name = "lblSisaKuota"
        Me.lblSisaKuota.Size = New System.Drawing.Size(157, 21)
        Me.lblSisaKuota.TabIndex = 66
        Me.lblSisaKuota.Text = "Sisa Kuota : 10 orang"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvList.BackgroundColor = System.Drawing.Color.White
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idtb_permohonan, Me.NIP, Me.Nama_Pemohon, Me.Jenis_Kelamin, Me.Posisi, Me.idtb_pemohon})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.GridColor = System.Drawing.Color.DarkKhaki
        Me.dgvList.Location = New System.Drawing.Point(14, 116)
        Me.dgvList.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(973, 275)
        Me.dgvList.TabIndex = 67
        '
        'idtb_permohonan
        '
        Me.idtb_permohonan.HeaderText = "idtb_permohonan"
        Me.idtb_permohonan.Name = "idtb_permohonan"
        Me.idtb_permohonan.Visible = False
        Me.idtb_permohonan.Width = 141
        '
        'NIP
        '
        Me.NIP.HeaderText = "NIP"
        Me.NIP.Name = "NIP"
        Me.NIP.Width = 58
        '
        'Nama_Pemohon
        '
        Me.Nama_Pemohon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nama_Pemohon.HeaderText = "Nama Pemohon"
        Me.Nama_Pemohon.MinimumWidth = 250
        Me.Nama_Pemohon.Name = "Nama_Pemohon"
        Me.Nama_Pemohon.Width = 250
        '
        'Jenis_Kelamin
        '
        Me.Jenis_Kelamin.HeaderText = "Jenis Kelamin"
        Me.Jenis_Kelamin.Name = "Jenis_Kelamin"
        Me.Jenis_Kelamin.Width = 127
        '
        'Posisi
        '
        Me.Posisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Posisi.HeaderText = "Posisi"
        Me.Posisi.MinimumWidth = 200
        Me.Posisi.Name = "Posisi"
        '
        'idtb_pemohon
        '
        Me.idtb_pemohon.HeaderText = "idtb_pemohon"
        Me.idtb_pemohon.Name = "idtb_pemohon"
        Me.idtb_pemohon.Visible = False
        Me.idtb_pemohon.Width = 137
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.HapusPermohonanIniToolStripMenuItem, Me.ReloadAutocompleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 70)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UndoToolStripMenuItem.Text = "Undo.."
        '
        'HapusPermohonanIniToolStripMenuItem
        '
        Me.HapusPermohonanIniToolStripMenuItem.Name = "HapusPermohonanIniToolStripMenuItem"
        Me.HapusPermohonanIniToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HapusPermohonanIniToolStripMenuItem.Text = "Hapus permohonan ini.."
        '
        'ReloadAutocompleteToolStripMenuItem
        '
        Me.ReloadAutocompleteToolStripMenuItem.Name = "ReloadAutocompleteToolStripMenuItem"
        Me.ReloadAutocompleteToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReloadAutocompleteToolStripMenuItem.Text = "Reload autocomplete..."
        '
        'btnUpdatePermohonan
        '
        Me.btnUpdatePermohonan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdatePermohonan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUpdatePermohonan.Location = New System.Drawing.Point(14, 75)
        Me.btnUpdatePermohonan.Name = "btnUpdatePermohonan"
        Me.btnUpdatePermohonan.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F11)
        Me.btnUpdatePermohonan.Size = New System.Drawing.Size(116, 23)
        Me.btnUpdatePermohonan.TabIndex = 68
        Me.btnUpdatePermohonan.Text = "&Simpan"
        '
        'btnKirim
        '
        Me.btnKirim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKirim.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKirim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnKirim.Location = New System.Drawing.Point(653, 75)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.btnKirim.Size = New System.Drawing.Size(334, 23)
        Me.btnKirim.TabIndex = 69
        Me.btnKirim.Text = "&Kirim ke Kasubag Perencanaan dan Keuangan >"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandableSplitter1.ExpandableControl = Me.pnlFormEntry
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
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(0, 305)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(1002, 10)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 70
        Me.ExpandableSplitter1.TabStop = False
        '
        'pnlFormEntry
        '
        Me.pnlFormEntry.Controls.Add(Me.btnHapusBendel)
        Me.pnlFormEntry.Controls.Add(Me.btnUpdateBendel)
        Me.pnlFormEntry.Controls.Add(Me.tableData2)
        Me.pnlFormEntry.Controls.Add(Me.Label7)
        Me.pnlFormEntry.Controls.Add(Me.cboStatusBundle)
        Me.pnlFormEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormEntry.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormEntry.Name = "pnlFormEntry"
        Me.pnlFormEntry.Size = New System.Drawing.Size(1002, 305)
        Me.pnlFormEntry.TabIndex = 71
        '
        'btnHapusBendel
        '
        Me.btnHapusBendel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnHapusBendel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnHapusBendel.Location = New System.Drawing.Point(197, 273)
        Me.btnHapusBendel.Name = "btnHapusBendel"
        Me.btnHapusBendel.Size = New System.Drawing.Size(162, 23)
        Me.btnHapusBendel.TabIndex = 1
        Me.btnHapusBendel.Text = "&Hapus Bendel Berkas"
        '
        'btnUpdateBendel
        '
        Me.btnUpdateBendel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdateBendel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUpdateBendel.Location = New System.Drawing.Point(14, 273)
        Me.btnUpdateBendel.Name = "btnUpdateBendel"
        Me.btnUpdateBendel.Size = New System.Drawing.Size(177, 23)
        Me.btnUpdateBendel.TabIndex = 0
        Me.btnUpdateBendel.Text = "&Update Bendel Berkas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.numJumlahPermohonan)
        Me.Panel1.Controls.Add(Me.lblSisaKuota)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgvList)
        Me.Panel1.Controls.Add(Me.btnUpdatePermohonan)
        Me.Panel1.Controls.Add(Me.btnKirim)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 403)
        Me.Panel1.TabIndex = 72
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(136, 75)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F11)
        Me.ButtonX1.Size = New System.Drawing.Size(179, 23)
        Me.ButtonX1.TabIndex = 70
        Me.ButtonX1.Text = "&Hapus baris pemohon.."
        '
        'PengaturanAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.pnlFormEntry)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "PengaturanAwal"
        Me.Size = New System.Drawing.Size(1002, 718)
        Me.tableData2.ResumeLayout(False)
        Me.tableData2.PerformLayout()
        CType(Me.numJumlahPermohonan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlFormEntry.ResumeLayout(False)
        Me.pnlFormEntry.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPengurusBundle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNomorBundle As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboInstansiBundle As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtTanggalMasukBundle As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboStatusBundle As System.Windows.Forms.ComboBox
    Friend WithEvents lblSisaKuota As System.Windows.Forms.Label
    Friend WithEvents numJumlahPermohonan As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusPermohonanIniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadAutocompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdatePermohonan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnKirim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents pnlFormEntry As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSudahDikirim As System.Windows.Forms.Label
    Friend WithEvents btnUpdateBendel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHapusBendel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomorSurat As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents idtb_permohonan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Pemohon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jenis_Kelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idtb_pemohon As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
