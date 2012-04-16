Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JabatanEntryPage
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
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.85714!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.14286!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.tableData.Controls.Add(Me.Label1, 0, 0)
        Me.tableData.Controls.Add(Me.txtRole, 1, 0)
        Me.tableData.Location = New System.Drawing.Point(73, 95)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 1
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableData.Size = New System.Drawing.Size(433, 60)
        Me.tableData.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Jabatan"
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(126, 4)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(221, 27)
        Me.txtRole.TabIndex = 1
        Me.txtRole.Tag = "role"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(73, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 82)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "TIPS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jabatan akan menentukan hak akses modul aplikasi. Selain itu, jabatan tert" & _
            "entu berwenang untuk menyetujui pengajuan permhonan Pass Bandara"
        '
        'JabatanEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tableData)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "JabatanEntryPage"
        Me.Size = New System.Drawing.Size(687, 317)
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRole As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
