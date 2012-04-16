<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoUpdate))
        Me.btnStartUpdte = New System.Windows.Forms.Button()
        Me.lblDownloading = New System.Windows.Forms.Label()
        Me.pbDownloadStatus = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.optFromFile = New System.Windows.Forms.RadioButton()
        Me.optFromInternet = New System.Windows.Forms.RadioButton()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.optFromLAN = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartUpdte
        '
        Me.btnStartUpdte.Location = New System.Drawing.Point(351, 252)
        Me.btnStartUpdte.Name = "btnStartUpdte"
        Me.btnStartUpdte.Size = New System.Drawing.Size(95, 40)
        Me.btnStartUpdte.TabIndex = 0
        Me.btnStartUpdte.Text = "Start"
        Me.btnStartUpdte.UseVisualStyleBackColor = True
        '
        'lblDownloading
        '
        Me.lblDownloading.Location = New System.Drawing.Point(75, 47)
        Me.lblDownloading.Name = "lblDownloading"
        Me.lblDownloading.Size = New System.Drawing.Size(371, 35)
        Me.lblDownloading.TabIndex = 1
        '
        'pbDownloadStatus
        '
        Me.pbDownloadStatus.Location = New System.Drawing.Point(78, 21)
        Me.pbDownloadStatus.Name = "pbDownloadStatus"
        Me.pbDownloadStatus.Size = New System.Drawing.Size(368, 23)
        Me.pbDownloadStatus.TabIndex = 2
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(452, 26)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(0, 13)
        Me.lblPercent.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(169, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aplikasi ini akan mengupdate aplikasi Aiport Pass Management System dengan versi " & _
            "terbaru."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutoUpdate.My.Resources.Resources.dephubkecil
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'optFromFile
        '
        Me.optFromFile.AutoSize = True
        Me.optFromFile.Location = New System.Drawing.Point(522, 23)
        Me.optFromFile.Name = "optFromFile"
        Me.optFromFile.Size = New System.Drawing.Size(64, 17)
        Me.optFromFile.TabIndex = 6
        Me.optFromFile.Text = "From file"
        Me.optFromFile.UseVisualStyleBackColor = True
        Me.optFromFile.Visible = False
        '
        'optFromInternet
        '
        Me.optFromInternet.AutoSize = True
        Me.optFromInternet.Checked = True
        Me.optFromInternet.Location = New System.Drawing.Point(522, 147)
        Me.optFromInternet.Name = "optFromInternet"
        Me.optFromInternet.Size = New System.Drawing.Size(86, 17)
        Me.optFromInternet.TabIndex = 7
        Me.optFromInternet.TabStop = True
        Me.optFromInternet.Text = "From internet"
        Me.optFromInternet.UseVisualStyleBackColor = True
        Me.optFromInternet.Visible = False
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(604, 52)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(353, 20)
        Me.txtFileName.TabIndex = 8
        Me.txtFileName.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(538, 50)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(60, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(604, 108)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(353, 20)
        Me.txtIP.TabIndex = 11
        Me.txtIP.Text = "192.168.10.107"
        Me.txtIP.Visible = False
        '
        'optFromLAN
        '
        Me.optFromLAN.AutoSize = True
        Me.optFromLAN.Location = New System.Drawing.Point(522, 79)
        Me.optFromLAN.Name = "optFromLAN"
        Me.optFromLAN.Size = New System.Drawing.Size(120, 17)
        Me.optFromLAN.TabIndex = 10
        Me.optFromLAN.Text = "From Local Network"
        Me.optFromLAN.UseVisualStyleBackColor = True
        Me.optFromLAN.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(538, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "IP Address"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Progress"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(169, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 95)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Jika mengupdate dari internet, maka komputer ini haruslah komputer Master, karena" & _
            " update akan disimpan ke C:\AutoUpdate, yang nanti akan dijadikan master update " & _
            "oleh semua komputer slave"
        '
        'AutoUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.optFromLAN)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.optFromInternet)
        Me.Controls.Add(Me.optFromFile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.pbDownloadStatus)
        Me.Controls.Add(Me.lblDownloading)
        Me.Controls.Add(Me.btnStartUpdte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate Airport Pass Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartUpdte As System.Windows.Forms.Button
    Friend WithEvents lblDownloading As System.Windows.Forms.Label
    Friend WithEvents pbDownloadStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents optFromFile As System.Windows.Forms.RadioButton
    Friend WithEvents optFromInternet As System.Windows.Forms.RadioButton
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents optFromLAN As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
