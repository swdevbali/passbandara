Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PemohonEntryPage
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
        Me.tableData = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoIdentitas = New System.Windows.Forms.TextBox()
        Me.cboJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.cboInstansi = New System.Windows.Forms.ComboBox()
        Me.cboStatusPemohon = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboWilayahKerjaT = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaR = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaB = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaGMF = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaC = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaA = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaP = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaV = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaS = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaZ = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaG = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaY = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaM = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaX = New System.Windows.Forms.CheckBox()
        Me.cboWilayahKerjaQ = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.Label2, 0, 1)
        Me.tableData.Controls.Add(Me.Label3, 0, 2)
        Me.tableData.Controls.Add(Me.Label4, 0, 3)
        Me.tableData.Controls.Add(Me.Label5, 0, 4)
        Me.tableData.Controls.Add(Me.Label6, 0, 5)
        Me.tableData.Controls.Add(Me.txtNama, 1, 0)
        Me.tableData.Controls.Add(Me.txtAlamat, 1, 1)
        Me.tableData.Controls.Add(Me.txtNoIdentitas, 1, 2)
        Me.tableData.Controls.Add(Me.cboJenisKelamin, 1, 3)
        Me.tableData.Controls.Add(Me.cboInstansi, 1, 4)
        Me.tableData.Controls.Add(Me.cboStatusPemohon, 1, 5)
        Me.tableData.Controls.Add(Me.Label9, 0, 6)
        Me.tableData.Controls.Add(Me.txtJabatan, 1, 6)
        Me.tableData.Location = New System.Drawing.Point(31, 7)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 7
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableData.Size = New System.Drawing.Size(507, 321)
        Me.tableData.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Identitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Instansi Terkini"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status Pemohon"
        '
        'txtNama
        '
        Me.txtNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNama.Location = New System.Drawing.Point(155, 4)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(307, 27)
        Me.txtNama.TabIndex = 7
        Me.txtNama.Tag = "nama"
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlamat.Location = New System.Drawing.Point(155, 45)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(307, 80)
        Me.txtAlamat.TabIndex = 8
        Me.txtAlamat.Tag = "alamat"
        '
        'txtNoIdentitas
        '
        Me.txtNoIdentitas.Location = New System.Drawing.Point(155, 133)
        Me.txtNoIdentitas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoIdentitas.Name = "txtNoIdentitas"
        Me.txtNoIdentitas.Size = New System.Drawing.Size(175, 27)
        Me.txtNoIdentitas.TabIndex = 9
        Me.txtNoIdentitas.Tag = "no_identitas"
        '
        'cboJenisKelamin
        '
        Me.cboJenisKelamin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboJenisKelamin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboJenisKelamin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboJenisKelamin.FormattingEnabled = True
        Me.cboJenisKelamin.Items.AddRange(New Object() {"--Pilih Jenis Kelamin--", "Pria", "Wanita"})
        Me.cboJenisKelamin.Location = New System.Drawing.Point(155, 170)
        Me.cboJenisKelamin.Margin = New System.Windows.Forms.Padding(4)
        Me.cboJenisKelamin.Name = "cboJenisKelamin"
        Me.cboJenisKelamin.Size = New System.Drawing.Size(307, 27)
        Me.cboJenisKelamin.TabIndex = 14
        Me.cboJenisKelamin.Tag = "jenis_kelamin"
        '
        'cboInstansi
        '
        Me.cboInstansi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstansi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstansi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboInstansi.FormattingEnabled = True
        Me.cboInstansi.Items.AddRange(New Object() {"--Pilih Jenis Kelamin--", "Pria", "Wanita"})
        Me.cboInstansi.Location = New System.Drawing.Point(155, 208)
        Me.cboInstansi.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInstansi.Name = "cboInstansi"
        Me.cboInstansi.Size = New System.Drawing.Size(307, 27)
        Me.cboInstansi.TabIndex = 15
        Me.cboInstansi.Tag = "idtb_instansi"
        '
        'cboStatusPemohon
        '
        Me.cboStatusPemohon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatusPemohon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatusPemohon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboStatusPemohon.FormattingEnabled = True
        Me.cboStatusPemohon.Items.AddRange(New Object() {"--Pilih Status Pemohon Saat Ini--", "Baru", "Lama"})
        Me.cboStatusPemohon.Location = New System.Drawing.Point(155, 249)
        Me.cboStatusPemohon.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStatusPemohon.Name = "cboStatusPemohon"
        Me.cboStatusPemohon.Size = New System.Drawing.Size(307, 27)
        Me.cboStatusPemohon.TabIndex = 16
        Me.cboStatusPemohon.Tag = "status_pemohon"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(572, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 156)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "TIPS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instansi terkini bisa dikosongkan, yang berarti data pemohon ini masih dat" & _
            "a sementara. Jika merupakan data pemohon lama, maka instansi bisa diisikan untuk" & _
            " mencatat data instansi terkini"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(550, 375)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tableData)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(542, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informasi Pemohon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaT
        '
        Me.cboWilayahKerjaT.AutoSize = True
        Me.cboWilayahKerjaT.Location = New System.Drawing.Point(238, 44)
        Me.cboWilayahKerjaT.Name = "cboWilayahKerjaT"
        Me.cboWilayahKerjaT.Size = New System.Drawing.Size(36, 23)
        Me.cboWilayahKerjaT.TabIndex = 30
        Me.cboWilayahKerjaT.Text = "T"
        Me.cboWilayahKerjaT.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaR
        '
        Me.cboWilayahKerjaR.AutoSize = True
        Me.cboWilayahKerjaR.Location = New System.Drawing.Point(189, 44)
        Me.cboWilayahKerjaR.Name = "cboWilayahKerjaR"
        Me.cboWilayahKerjaR.Size = New System.Drawing.Size(37, 23)
        Me.cboWilayahKerjaR.TabIndex = 29
        Me.cboWilayahKerjaR.Text = "R"
        Me.cboWilayahKerjaR.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaB
        '
        Me.cboWilayahKerjaB.AutoSize = True
        Me.cboWilayahKerjaB.Location = New System.Drawing.Point(280, 44)
        Me.cboWilayahKerjaB.Name = "cboWilayahKerjaB"
        Me.cboWilayahKerjaB.Size = New System.Drawing.Size(37, 23)
        Me.cboWilayahKerjaB.TabIndex = 31
        Me.cboWilayahKerjaB.Text = "B"
        Me.cboWilayahKerjaB.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaGMF
        '
        Me.cboWilayahKerjaGMF.AutoSize = True
        Me.cboWilayahKerjaGMF.Location = New System.Drawing.Point(130, 44)
        Me.cboWilayahKerjaGMF.Name = "cboWilayahKerjaGMF"
        Me.cboWilayahKerjaGMF.Size = New System.Drawing.Size(58, 23)
        Me.cboWilayahKerjaGMF.TabIndex = 28
        Me.cboWilayahKerjaGMF.Text = "GMF"
        Me.cboWilayahKerjaGMF.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaC
        '
        Me.cboWilayahKerjaC.AutoSize = True
        Me.cboWilayahKerjaC.Location = New System.Drawing.Point(322, 44)
        Me.cboWilayahKerjaC.Name = "cboWilayahKerjaC"
        Me.cboWilayahKerjaC.Size = New System.Drawing.Size(37, 23)
        Me.cboWilayahKerjaC.TabIndex = 32
        Me.cboWilayahKerjaC.Text = "C"
        Me.cboWilayahKerjaC.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaA
        '
        Me.cboWilayahKerjaA.AutoSize = True
        Me.cboWilayahKerjaA.Location = New System.Drawing.Point(322, 15)
        Me.cboWilayahKerjaA.Name = "cboWilayahKerjaA"
        Me.cboWilayahKerjaA.Size = New System.Drawing.Size(37, 23)
        Me.cboWilayahKerjaA.TabIndex = 27
        Me.cboWilayahKerjaA.Text = "A"
        Me.cboWilayahKerjaA.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaP
        '
        Me.cboWilayahKerjaP.AutoSize = True
        Me.cboWilayahKerjaP.Location = New System.Drawing.Point(130, 76)
        Me.cboWilayahKerjaP.Name = "cboWilayahKerjaP"
        Me.cboWilayahKerjaP.Size = New System.Drawing.Size(36, 23)
        Me.cboWilayahKerjaP.TabIndex = 33
        Me.cboWilayahKerjaP.Text = "P"
        Me.cboWilayahKerjaP.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaV
        '
        Me.cboWilayahKerjaV.AutoSize = True
        Me.cboWilayahKerjaV.Location = New System.Drawing.Point(280, 15)
        Me.cboWilayahKerjaV.Name = "cboWilayahKerjaV"
        Me.cboWilayahKerjaV.Size = New System.Drawing.Size(37, 23)
        Me.cboWilayahKerjaV.TabIndex = 26
        Me.cboWilayahKerjaV.Text = "V"
        Me.cboWilayahKerjaV.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaS
        '
        Me.cboWilayahKerjaS.AutoSize = True
        Me.cboWilayahKerjaS.Location = New System.Drawing.Point(189, 76)
        Me.cboWilayahKerjaS.Name = "cboWilayahKerjaS"
        Me.cboWilayahKerjaS.Size = New System.Drawing.Size(35, 23)
        Me.cboWilayahKerjaS.TabIndex = 34
        Me.cboWilayahKerjaS.Text = "S"
        Me.cboWilayahKerjaS.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaZ
        '
        Me.cboWilayahKerjaZ.AutoSize = True
        Me.cboWilayahKerjaZ.Location = New System.Drawing.Point(238, 15)
        Me.cboWilayahKerjaZ.Name = "cboWilayahKerjaZ"
        Me.cboWilayahKerjaZ.Size = New System.Drawing.Size(36, 23)
        Me.cboWilayahKerjaZ.TabIndex = 25
        Me.cboWilayahKerjaZ.Text = "Z"
        Me.cboWilayahKerjaZ.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaG
        '
        Me.cboWilayahKerjaG.AutoSize = True
        Me.cboWilayahKerjaG.Location = New System.Drawing.Point(238, 76)
        Me.cboWilayahKerjaG.Name = "cboWilayahKerjaG"
        Me.cboWilayahKerjaG.Size = New System.Drawing.Size(38, 23)
        Me.cboWilayahKerjaG.TabIndex = 35
        Me.cboWilayahKerjaG.Text = "G"
        Me.cboWilayahKerjaG.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaY
        '
        Me.cboWilayahKerjaY.AutoSize = True
        Me.cboWilayahKerjaY.Location = New System.Drawing.Point(189, 15)
        Me.cboWilayahKerjaY.Name = "cboWilayahKerjaY"
        Me.cboWilayahKerjaY.Size = New System.Drawing.Size(36, 23)
        Me.cboWilayahKerjaY.TabIndex = 24
        Me.cboWilayahKerjaY.Text = "Y"
        Me.cboWilayahKerjaY.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaM
        '
        Me.cboWilayahKerjaM.AutoSize = True
        Me.cboWilayahKerjaM.Location = New System.Drawing.Point(280, 76)
        Me.cboWilayahKerjaM.Name = "cboWilayahKerjaM"
        Me.cboWilayahKerjaM.Size = New System.Drawing.Size(41, 23)
        Me.cboWilayahKerjaM.TabIndex = 36
        Me.cboWilayahKerjaM.Text = "M"
        Me.cboWilayahKerjaM.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaX
        '
        Me.cboWilayahKerjaX.AutoSize = True
        Me.cboWilayahKerjaX.Location = New System.Drawing.Point(130, 15)
        Me.cboWilayahKerjaX.Name = "cboWilayahKerjaX"
        Me.cboWilayahKerjaX.Size = New System.Drawing.Size(36, 23)
        Me.cboWilayahKerjaX.TabIndex = 23
        Me.cboWilayahKerjaX.Text = "X"
        Me.cboWilayahKerjaX.UseVisualStyleBackColor = True
        '
        'cboWilayahKerjaQ
        '
        Me.cboWilayahKerjaQ.AutoSize = True
        Me.cboWilayahKerjaQ.Location = New System.Drawing.Point(322, 76)
        Me.cboWilayahKerjaQ.Name = "cboWilayahKerjaQ"
        Me.cboWilayahKerjaQ.Size = New System.Drawing.Size(39, 23)
        Me.cboWilayahKerjaQ.TabIndex = 37
        Me.cboWilayahKerjaQ.Text = "Q"
        Me.cboWilayahKerjaQ.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Wilayah Kerja"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(126, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 156)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "TIPS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wilayah kerja terkini akan diupdate berdasarkan permohonan terkini yang ma" & _
            "suk. Jika saat ini pemohon telah memiliki data wilayah kerja, silahkan inputkan " & _
            "disini "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaQ)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaX)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaM)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaY)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaG)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaZ)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaS)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaV)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaP)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaA)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaC)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaGMF)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaB)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaR)
        Me.TabPage2.Controls.Add(Me.cboWilayahKerjaT)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(542, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Wilayah Kerja Terkini"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Jabatan"
        '
        'txtJabatan
        '
        Me.txtJabatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJabatan.Location = New System.Drawing.Point(154, 287)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(309, 27)
        Me.txtJabatan.TabIndex = 18
        Me.txtJabatan.Tag = "jabatan"
        '
        'PemohonEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label8)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "PemohonEntryPage"
        Me.Size = New System.Drawing.Size(841, 455)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoIdentitas As System.Windows.Forms.TextBox
    Friend WithEvents cboJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatusPemohon As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboInstansi As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox

End Class
