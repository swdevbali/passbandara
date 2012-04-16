Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressEntryPage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaProgress = New System.Windows.Forms.TextBox()
        Me.cboJabatan = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91045!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08955!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tableData.Controls.Add(Me.Label3, 0, 1)
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.txtNamaProgress, 1, 0)
        Me.tableData.Controls.Add(Me.cboJabatan, 1, 1)
        Me.tableData.Location = New System.Drawing.Point(34, 66)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 2
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.Size = New System.Drawing.Size(568, 86)
        Me.tableData.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Jabatan berwenang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Progress"
        '
        'txtNamaProgress
        '
        Me.txtNamaProgress.Location = New System.Drawing.Point(172, 4)
        Me.txtNamaProgress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaProgress.Name = "txtNamaProgress"
        Me.txtNamaProgress.Size = New System.Drawing.Size(267, 27)
        Me.txtNamaProgress.TabIndex = 1
        Me.txtNamaProgress.Tag = "Tahap Persetujuan"
        '
        'cboJabatan
        '
        Me.cboJabatan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboJabatan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboJabatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboJabatan.FormattingEnabled = True
        Me.cboJabatan.Location = New System.Drawing.Point(172, 39)
        Me.cboJabatan.Margin = New System.Windows.Forms.Padding(4)
        Me.cboJabatan.Name = "cboJabatan"
        Me.cboJabatan.Size = New System.Drawing.Size(267, 27)
        Me.cboJabatan.TabIndex = 39
        Me.cboJabatan.Tag = "koderole"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(30, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 86)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "TIPS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Progress menentukan tahap yang sedang dilalui oleh berkas permohonan, yang" & _
            " hanya berhak diakses oleh pejabat tertentu"
        '
        'ProgressEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tableData)
        Me.ImageTitle = Global.MasterModule.My.Resources.Resources.process
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "ProgressEntryPage"
        Me.Size = New System.Drawing.Size(705, 230)
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNamaProgress As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboJabatan As System.Windows.Forms.ComboBox

End Class
