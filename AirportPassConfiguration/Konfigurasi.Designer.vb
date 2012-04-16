<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konfigurasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Konfigurasi))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerBerkas = New System.Windows.Forms.TextBox()
        Me.optSlave = New System.Windows.Forms.RadioButton()
        Me.optMaster = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAutoUpdatePath = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DatabaseSettingsPage1 = New SwdevIUIDatabase.DatabaseSettingsPage()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(489, 319)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(481, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtServerBerkas, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.optSlave, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.optMaster, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAutoUpdatePath, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(29, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(424, 168)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Berkas"
        '
        'txtServerBerkas
        '
        Me.txtServerBerkas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServerBerkas.Location = New System.Drawing.Point(170, 5)
        Me.txtServerBerkas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtServerBerkas.Name = "txtServerBerkas"
        Me.txtServerBerkas.Size = New System.Drawing.Size(250, 28)
        Me.txtServerBerkas.TabIndex = 0
        '
        'optSlave
        '
        Me.optSlave.AutoSize = True
        Me.optSlave.Checked = True
        Me.optSlave.Location = New System.Drawing.Point(169, 105)
        Me.optSlave.Name = "optSlave"
        Me.optSlave.Size = New System.Drawing.Size(153, 25)
        Me.optSlave.TabIndex = 3
        Me.optSlave.TabStop = True
        Me.optSlave.Text = "Slave AutoUpdate"
        Me.optSlave.UseVisualStyleBackColor = True
        '
        'optMaster
        '
        Me.optMaster.AutoSize = True
        Me.optMaster.Location = New System.Drawing.Point(169, 71)
        Me.optMaster.Name = "optMaster"
        Me.optMaster.Size = New System.Drawing.Size(167, 25)
        Me.optMaster.TabIndex = 2
        Me.optMaster.TabStop = True
        Me.optMaster.Text = "Master AutoUpdate"
        Me.optMaster.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AutoUpdate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Path AutoUpdate"
        '
        'txtAutoUpdatePath
        '
        Me.txtAutoUpdatePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAutoUpdatePath.Location = New System.Drawing.Point(169, 37)
        Me.txtAutoUpdatePath.Name = "txtAutoUpdatePath"
        Me.txtAutoUpdatePath.Size = New System.Drawing.Size(252, 28)
        Me.txtAutoUpdatePath.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DatabaseSettingsPage1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(481, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DatabaseSettingsPage1
        '
        Me.DatabaseSettingsPage1.BackColor = System.Drawing.Color.Transparent
        Me.DatabaseSettingsPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatabaseSettingsPage1.Font = New System.Drawing.Font("Calibri", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.DatabaseSettingsPage1.ImageTitle = CType(resources.GetObject("DatabaseSettingsPage1.ImageTitle"), System.Drawing.Image)
        Me.DatabaseSettingsPage1.Location = New System.Drawing.Point(3, 3)
        Me.DatabaseSettingsPage1.lvPageActivities = Nothing
        Me.DatabaseSettingsPage1.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.DatabaseSettingsPage1.Name = "DatabaseSettingsPage1"
        Me.DatabaseSettingsPage1.Size = New System.Drawing.Size(475, 279)
        Me.DatabaseSettingsPage1.TabIndex = 0
        Me.DatabaseSettingsPage1.Title = "Settings"
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Location = New System.Drawing.Point(344, 338)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(157, 36)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "&Simpan"
        '
        'Konfigurasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 381)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Konfigurasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfigurasi"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DatabaseSettingsPage1 As SwdevIUIDatabase.DatabaseSettingsPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServerBerkas As System.Windows.Forms.TextBox
    Friend WithEvents optMaster As System.Windows.Forms.RadioButton
    Friend WithEvents optSlave As System.Windows.Forms.RadioButton
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAutoUpdatePath As System.Windows.Forms.TextBox
End Class
