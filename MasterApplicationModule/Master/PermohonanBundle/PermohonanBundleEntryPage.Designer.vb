<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermohonanBundleEntryPage
    Inherits SwdevIUIDatabase.PageEntryTemplate

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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtProses = New System.Windows.Forms.DateTimePicker()
        Me.cboInstansi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomorBundle = New System.Windows.Forms.TextBox()
        Me.txtPengurus = New System.Windows.Forms.TextBox()
        Me.linkInstansi = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomorSurat = New System.Windows.Forms.TextBox()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.tableData.Controls.Add(Me.Label5, 0, 3)
        Me.tableData.Controls.Add(Me.dtProses, 1, 1)
        Me.tableData.Controls.Add(Me.cboInstansi, 1, 0)
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.Label2, 0, 1)
        Me.tableData.Controls.Add(Me.Label3, 0, 2)
        Me.tableData.Controls.Add(Me.txtNomorBundle, 1, 2)
        Me.tableData.Controls.Add(Me.linkInstansi, 2, 0)
        Me.tableData.Controls.Add(Me.Label4, 0, 4)
        Me.tableData.Controls.Add(Me.txtPengurus, 1, 4)
        Me.tableData.Controls.Add(Me.txtNomorSurat, 1, 3)
        Me.tableData.Location = New System.Drawing.Point(27, 92)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 5
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableData.Size = New System.Drawing.Size(683, 223)
        Me.tableData.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Pengurus"
        '
        'dtProses
        '
        Me.dtProses.CustomFormat = "yyyy/M/dd"
        Me.dtProses.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtProses.Location = New System.Drawing.Point(280, 49)
        Me.dtProses.Margin = New System.Windows.Forms.Padding(4)
        Me.dtProses.Name = "dtProses"
        Me.dtProses.Size = New System.Drawing.Size(219, 27)
        Me.dtProses.TabIndex = 2
        Me.dtProses.Tag = "Tgl Masuk"
        '
        'cboInstansi
        '
        Me.cboInstansi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstansi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstansi.FormattingEnabled = True
        Me.cboInstansi.Location = New System.Drawing.Point(280, 4)
        Me.cboInstansi.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInstansi.Name = "cboInstansi"
        Me.cboInstansi.Size = New System.Drawing.Size(265, 27)
        Me.cboInstansi.TabIndex = 0
        Me.cboInstansi.Tag = "idtb_instansi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Instansi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Masuk Proses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nomor Bundle"
        '
        'txtNomorBundle
        '
        Me.txtNomorBundle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomorBundle.Location = New System.Drawing.Point(280, 91)
        Me.txtNomorBundle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomorBundle.Name = "txtNomorBundle"
        Me.txtNomorBundle.Size = New System.Drawing.Size(268, 27)
        Me.txtNomorBundle.TabIndex = 3
        '
        'txtPengurus
        '
        Me.txtPengurus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPengurus.Location = New System.Drawing.Point(280, 177)
        Me.txtPengurus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPengurus.Name = "txtPengurus"
        Me.txtPengurus.Size = New System.Drawing.Size(268, 27)
        Me.txtPengurus.TabIndex = 4
        '
        'linkInstansi
        '
        Me.linkInstansi.AutoSize = True
        Me.linkInstansi.Location = New System.Drawing.Point(555, 0)
        Me.linkInstansi.Name = "linkInstansi"
        Me.linkInstansi.Size = New System.Drawing.Size(115, 19)
        Me.linkInstansi.TabIndex = 1
        Me.linkInstansi.TabStop = True
        Me.linkInstansi.Text = "Tambah instansi"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nomor Surat"
        '
        'txtNomorSurat
        '
        Me.txtNomorSurat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomorSurat.Location = New System.Drawing.Point(279, 131)
        Me.txtNomorSurat.Name = "txtNomorSurat"
        Me.txtNomorSurat.Size = New System.Drawing.Size(270, 27)
        Me.txtNomorSurat.TabIndex = 53
        Me.txtNomorSurat.Tag = "nomor_surat"
        '
        'PermohonanBundleEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tableData)
        Me.ImageTitle = Global.MasterModule.My.Resources.Resources.users1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "PermohonanBundleEntryPage"
        Me.Size = New System.Drawing.Size(717, 304)
        Me.Title = "Bundle Permohonan"
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomorBundle As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboInstansi As System.Windows.Forms.ComboBox
    Friend WithEvents dtProses As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPengurus As System.Windows.Forms.TextBox
    Friend WithEvents linkInstansi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomorSurat As System.Windows.Forms.TextBox

End Class
