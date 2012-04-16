Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstansiEntryPage
    Inherits PageEntryTemplate

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
        Me.tableData = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaInstansi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKuotaMaksimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKategori = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBidangUsaha = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSisaKuota = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblNamaFile = New System.Windows.Forms.Label()
        Me.btnStartUpload = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.txtNamaInstansi, 1, 0)
        Me.tableData.Controls.Add(Me.Label2, 0, 1)
        Me.tableData.Controls.Add(Me.txtAlamat, 1, 1)
        Me.tableData.Controls.Add(Me.Label3, 0, 2)
        Me.tableData.Controls.Add(Me.txtKuotaMaksimal, 1, 2)
        Me.tableData.Controls.Add(Me.Label4, 0, 3)
        Me.tableData.Controls.Add(Me.cboKategori, 1, 3)
        Me.tableData.Controls.Add(Me.Label5, 0, 4)
        Me.tableData.Controls.Add(Me.cboBidangUsaha, 1, 4)
        Me.tableData.Controls.Add(Me.Label6, 0, 5)
        Me.tableData.Controls.Add(Me.txtSisaKuota, 1, 5)
        Me.tableData.Location = New System.Drawing.Point(17, 60)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 6
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData.Size = New System.Drawing.Size(484, 243)
        Me.tableData.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nama Instansi"
        '
        'txtNamaInstansi
        '
        Me.txtNamaInstansi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNamaInstansi.Location = New System.Drawing.Point(168, 4)
        Me.txtNamaInstansi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaInstansi.Name = "txtNamaInstansi"
        Me.txtNamaInstansi.Size = New System.Drawing.Size(196, 27)
        Me.txtNamaInstansi.TabIndex = 0
        Me.txtNamaInstansi.Tag = "Nama Instansi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlamat.Location = New System.Drawing.Point(168, 33)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(196, 55)
        Me.txtAlamat.TabIndex = 1
        Me.txtAlamat.Tag = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Kuota Maksimal"
        '
        'txtKuotaMaksimal
        '
        Me.txtKuotaMaksimal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKuotaMaksimal.Location = New System.Drawing.Point(168, 96)
        Me.txtKuotaMaksimal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKuotaMaksimal.Multiline = True
        Me.txtKuotaMaksimal.Name = "txtKuotaMaksimal"
        Me.txtKuotaMaksimal.Size = New System.Drawing.Size(196, 24)
        Me.txtKuotaMaksimal.TabIndex = 2
        Me.txtKuotaMaksimal.Tag = "Kuota Maksimal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Kategori"
        '
        'cboKategori
        '
        Me.cboKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKategori.FormattingEnabled = True
        Me.cboKategori.Items.AddRange(New Object() {"--Pilih kategori instansi--", "Penerbangan", "Pemerintahan", "Umum", "Non Penerbangan"})
        Me.cboKategori.Location = New System.Drawing.Point(168, 128)
        Me.cboKategori.Margin = New System.Windows.Forms.Padding(4)
        Me.cboKategori.Name = "cboKategori"
        Me.cboKategori.Size = New System.Drawing.Size(195, 27)
        Me.cboKategori.TabIndex = 3
        Me.cboKategori.Tag = "kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Bidang Usaha"
        '
        'cboBidangUsaha
        '
        Me.cboBidangUsaha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBidangUsaha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBidangUsaha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboBidangUsaha.FormattingEnabled = True
        Me.cboBidangUsaha.Location = New System.Drawing.Point(168, 170)
        Me.cboBidangUsaha.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBidangUsaha.Name = "cboBidangUsaha"
        Me.cboBidangUsaha.Size = New System.Drawing.Size(196, 27)
        Me.cboBidangUsaha.TabIndex = 4
        Me.cboBidangUsaha.Tag = "idtb_bidangusaha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Sisa Kuota"
        '
        'txtSisaKuota
        '
        Me.txtSisaKuota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSisaKuota.Location = New System.Drawing.Point(168, 209)
        Me.txtSisaKuota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSisaKuota.Name = "txtSisaKuota"
        Me.txtSisaKuota.Size = New System.Drawing.Size(196, 27)
        Me.txtSisaKuota.TabIndex = 5
        Me.txtSisaKuota.Tag = "Sisa Kuota"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(10, 7)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 34)
        Me.btnBrowse.TabIndex = 38
        Me.btnBrowse.Text = "Browse.."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblNamaFile
        '
        Me.lblNamaFile.AutoSize = True
        Me.lblNamaFile.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaFile.Location = New System.Drawing.Point(6, 45)
        Me.lblNamaFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaFile.Name = "lblNamaFile"
        Me.lblNamaFile.Size = New System.Drawing.Size(191, 19)
        Me.lblNamaFile.TabIndex = 37
        Me.lblNamaFile.Text = "Pilih file yang akan diupload"
        '
        'btnStartUpload
        '
        Me.btnStartUpload.Location = New System.Drawing.Point(118, 7)
        Me.btnStartUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartUpload.Name = "btnStartUpload"
        Me.btnStartUpload.Size = New System.Drawing.Size(100, 34)
        Me.btnStartUpload.TabIndex = 39
        Me.btnStartUpload.Text = "Start Upload"
        Me.btnStartUpload.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvList.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.GridColor = System.Drawing.Color.DarkKhaki
        Me.dgvList.Location = New System.Drawing.Point(10, 74)
        Me.dgvList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.ShowEditingIcon = False
        Me.dgvList.Size = New System.Drawing.Size(281, 136)
        Me.dgvList.TabIndex = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Berkas"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Keterangan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnBrowse)
        Me.GroupPanel1.Controls.Add(Me.dgvList)
        Me.GroupPanel1.Controls.Add(Me.btnStartUpload)
        Me.GroupPanel1.Controls.Add(Me.lblNamaFile)
        Me.GroupPanel1.Location = New System.Drawing.Point(511, 61)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(309, 242)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 41
        Me.GroupPanel1.Text = "Attachment"
        '
        'InstansiEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.tableData)
        Me.ImageTitle = Global.MasterModule.My.Resources.Resources.process
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "InstansiEntryPage"
        Me.Size = New System.Drawing.Size(824, 316)
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.Controls.SetChildIndex(Me.GroupPanel1, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNamaInstansi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKuotaMaksimal As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboBidangUsaha As System.Windows.Forms.ComboBox
    Friend WithEvents txtSisaKuota As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblNamaFile As System.Windows.Forms.Label
    Friend WithEvents btnStartUpload As System.Windows.Forms.Button
    Public WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel

End Class
