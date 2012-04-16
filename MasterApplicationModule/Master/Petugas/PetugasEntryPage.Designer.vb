Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetugasEntryPage
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHandphone = New System.Windows.Forms.TextBox()
        Me.cboKodeRole = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tableData.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableData
        '
        Me.tableData.ColumnCount = 3
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.tableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tableData.Controls.Add(Me.Label1, 0, 1)
        Me.tableData.Controls.Add(Me.txtUsername, 1, 1)
        Me.tableData.Controls.Add(Me.Label2, 0, 2)
        Me.tableData.Controls.Add(Me.txtPassword, 1, 2)
        Me.tableData.Controls.Add(Me.Label3, 0, 3)
        Me.tableData.Controls.Add(Me.txtNamaLengkap, 1, 3)
        Me.tableData.Controls.Add(Me.Label4, 0, 4)
        Me.tableData.Controls.Add(Me.Label5, 0, 5)
        Me.tableData.Controls.Add(Me.txtAlamat, 1, 5)
        Me.tableData.Controls.Add(Me.Label6, 0, 6)
        Me.tableData.Controls.Add(Me.txtHandphone, 1, 6)
        Me.tableData.Controls.Add(Me.cboKodeRole, 1, 4)
        Me.tableData.Location = New System.Drawing.Point(31, 60)
        Me.tableData.Margin = New System.Windows.Forms.Padding(4)
        Me.tableData.Name = "tableData"
        Me.tableData.RowCount = 7
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableData.Size = New System.Drawing.Size(459, 215)
        Me.tableData.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUsername.Location = New System.Drawing.Point(204, 4)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(197, 27)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Tag = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPassword.Location = New System.Drawing.Point(204, 39)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(197, 27)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Lengkap"
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNamaLengkap.Location = New System.Drawing.Point(204, 74)
        Me.txtNamaLengkap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.Size = New System.Drawing.Size(197, 27)
        Me.txtNamaLengkap.TabIndex = 5
        Me.txtNamaLengkap.Tag = "namalengkap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlamat.Location = New System.Drawing.Point(204, 144)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(197, 27)
        Me.txtAlamat.TabIndex = 8
        Me.txtAlamat.Tag = "alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Handphone"
        '
        'txtHandphone
        '
        Me.txtHandphone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHandphone.Location = New System.Drawing.Point(204, 179)
        Me.txtHandphone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHandphone.Name = "txtHandphone"
        Me.txtHandphone.Size = New System.Drawing.Size(197, 27)
        Me.txtHandphone.TabIndex = 10
        Me.txtHandphone.Tag = "nomorhp"
        '
        'cboKodeRole
        '
        Me.cboKodeRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKodeRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKodeRole.FormattingEnabled = True
        Me.cboKodeRole.Location = New System.Drawing.Point(204, 109)
        Me.cboKodeRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cboKodeRole.Name = "cboKodeRole"
        Me.cboKodeRole.Size = New System.Drawing.Size(196, 27)
        Me.cboKodeRole.TabIndex = 11
        Me.cboKodeRole.Tag = "koderole"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(498, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(463, 99)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "TIPS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jika field password dikosongkan, petugas akan menggunakan password yang l" & _
            "ama. Isikan password yang baru untuk mengubah password yang lama."
        '
        'PetugasEntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tableData)
        Me.ImageTitle = Global.MasterModule.My.Resources.Resources.users1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "PetugasEntryPage"
        Me.Size = New System.Drawing.Size(755, 297)
        Me.Title = "Petugas"
        Me.Controls.SetChildIndex(Me.tableData, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.tableData.ResumeLayout(False)
        Me.tableData.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLengkap As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHandphone As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboKodeRole As System.Windows.Forms.ComboBox

End Class
