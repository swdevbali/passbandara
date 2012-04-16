Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisBerkasEntryPage
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tableData = New System.Windows.Forms.TableLayoutPanel()
        Me.txtJenisBerkas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboWajib = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableData.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42105!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tableData.Controls.Add(Me.txtJenisBerkas, 1, 0)
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.cboWajib, 1, 1)
        Me.tableData.Location = New System.Drawing.Point(61, 96)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 2
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tableData.Size = New System.Drawing.Size(393, 107)
        Me.tableData.TabIndex = 36
        '
        'txtJenisBerkas
        '
        Me.txtJenisBerkas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJenisBerkas.Location = New System.Drawing.Point(112, 4)
        Me.txtJenisBerkas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJenisBerkas.Name = "txtJenisBerkas"
        Me.txtJenisBerkas.Size = New System.Drawing.Size(228, 27)
        Me.txtJenisBerkas.TabIndex = 0
        Me.txtJenisBerkas.Tag = "jenis_berkas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Berkas"
        '
        'cboWajib
        '
        Me.cboWajib.AutoSize = True
        Me.cboWajib.Location = New System.Drawing.Point(112, 46)
        Me.cboWajib.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboWajib.Name = "cboWajib"
        Me.cboWajib.Size = New System.Drawing.Size(107, 23)
        Me.cboWajib.TabIndex = 3
        Me.cboWajib.Tag = "wajib"
        Me.cboWajib.Text = "Syarat wajib"
        Me.cboWajib.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(57, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(396, 82)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "TIP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jika jenis berkas ini merupakan syarat wajib yang harus dipenuhi pemohon, ce" & _
            "ntang checkbox Syarat Wajib"
        '
        'JenisBerkasEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tableData)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "JenisBerkasEntryPage"
        Me.Size = New System.Drawing.Size(727, 310)
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtJenisBerkas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboWajib As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
