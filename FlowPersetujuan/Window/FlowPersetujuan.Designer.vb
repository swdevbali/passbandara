<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowPersetujuan
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlowPersetujuan))
        Me.lblCurrentPembayaran = New System.Windows.Forms.Label()
        Me.btnPembayaran = New System.Windows.Forms.Button()
        Me.lblCurrentFoto = New System.Windows.Forms.Label()
        Me.lblTime = New gLabel.gLabel()
        Me.lblCurrentPemberkasan = New System.Windows.Forms.Label()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.btnPemberkasan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCurrentPendaftaran = New System.Windows.Forms.Label()
        Me.btnPendaftaran = New System.Windows.Forms.Button()
        Me.PersetujuanFlowDisplayPage1 = New TransaksiModule.PersetujuanFlowDisplayPage()
        Me.SuspendLayout()
        '
        'lblCurrentPembayaran
        '
        Me.lblCurrentPembayaran.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPembayaran.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCurrentPembayaran.Location = New System.Drawing.Point(1122, 557)
        Me.lblCurrentPembayaran.Name = "lblCurrentPembayaran"
        Me.lblCurrentPembayaran.Size = New System.Drawing.Size(132, 206)
        Me.lblCurrentPembayaran.TabIndex = 6
        Me.lblCurrentPembayaran.Text = "1"
        Me.lblCurrentPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackgroundImage = Global.FlowPersetujuan.My.Resources.Resources.bt
        Me.btnPembayaran.Font = New System.Drawing.Font("Impact", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembayaran.Location = New System.Drawing.Point(1024, 856)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(348, 72)
        Me.btnPembayaran.TabIndex = 5
        Me.btnPembayaran.Text = "Ambil Antrian"
        Me.btnPembayaran.UseVisualStyleBackColor = True
        '
        'lblCurrentFoto
        '
        Me.lblCurrentFoto.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFoto.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCurrentFoto.Location = New System.Drawing.Point(1641, 569)
        Me.lblCurrentFoto.Name = "lblCurrentFoto"
        Me.lblCurrentFoto.Size = New System.Drawing.Size(132, 206)
        Me.lblCurrentFoto.TabIndex = 1
        Me.lblCurrentFoto.Text = "1"
        Me.lblCurrentFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.BorderWidth = 1.0!
        Me.lblTime.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblTime.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblTime.Font = New System.Drawing.Font("Impact", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DodgerBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblTime.ForeColorBlend = CBlendItems1
        Me.lblTime.Glow = 12
        Me.lblTime.GlowColor = System.Drawing.Color.Crimson
        Me.lblTime.GlowState = False
        Me.lblTime.Location = New System.Drawing.Point(659, 286)
        Me.lblTime.MouseOver = False
        Me.lblTime.MouseOverColor = System.Drawing.Color.Gray
        Me.lblTime.Name = "lblTime"
        Me.lblTime.PulseSpeed = 100
        Me.lblTime.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblTime.Size = New System.Drawing.Size(8, 57)
        Me.lblTime.TabIndex = 14
        Me.lblTime.TabStop = True
        Me.lblTime.Text = "Date : Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentPemberkasan
        '
        Me.lblCurrentPemberkasan.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPemberkasan.Font = New System.Drawing.Font("Microsoft Sans Serif", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPemberkasan.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCurrentPemberkasan.Location = New System.Drawing.Point(654, 538)
        Me.lblCurrentPemberkasan.Name = "lblCurrentPemberkasan"
        Me.lblCurrentPemberkasan.Size = New System.Drawing.Size(132, 206)
        Me.lblCurrentPemberkasan.TabIndex = 2
        Me.lblCurrentPemberkasan.Text = "1"
        Me.lblCurrentPemberkasan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFoto
        '
        Me.btnFoto.AllowDrop = True
        Me.btnFoto.BackgroundImage = Global.FlowPersetujuan.My.Resources.Resources.bt
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.Font = New System.Drawing.Font("Impact", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.Location = New System.Drawing.Point(1507, 856)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(348, 72)
        Me.btnFoto.TabIndex = 3
        Me.btnFoto.Text = "Ambil Antrian"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'btnPemberkasan
        '
        Me.btnPemberkasan.BackgroundImage = Global.FlowPersetujuan.My.Resources.Resources.bt
        Me.btnPemberkasan.Font = New System.Drawing.Font("Impact", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPemberkasan.Location = New System.Drawing.Point(554, 856)
        Me.btnPemberkasan.Name = "btnPemberkasan"
        Me.btnPemberkasan.Size = New System.Drawing.Size(348, 72)
        Me.btnPemberkasan.TabIndex = 4
        Me.btnPemberkasan.Text = "Ambil Antrian"
        Me.btnPemberkasan.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'lblCurrentPendaftaran
        '
        Me.lblCurrentPendaftaran.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPendaftaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPendaftaran.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCurrentPendaftaran.Location = New System.Drawing.Point(170, 538)
        Me.lblCurrentPendaftaran.Name = "lblCurrentPendaftaran"
        Me.lblCurrentPendaftaran.Size = New System.Drawing.Size(132, 206)
        Me.lblCurrentPendaftaran.TabIndex = 15
        Me.lblCurrentPendaftaran.Text = "1"
        Me.lblCurrentPendaftaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPendaftaran
        '
        Me.btnPendaftaran.BackgroundImage = Global.FlowPersetujuan.My.Resources.Resources.bt
        Me.btnPendaftaran.Font = New System.Drawing.Font("Impact", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendaftaran.Location = New System.Drawing.Point(49, 856)
        Me.btnPendaftaran.Name = "btnPendaftaran"
        Me.btnPendaftaran.Size = New System.Drawing.Size(348, 72)
        Me.btnPendaftaran.TabIndex = 16
        Me.btnPendaftaran.Text = "Ambil Antrian"
        Me.btnPendaftaran.UseVisualStyleBackColor = True
        '
        'PersetujuanFlowDisplayPage1
        '
        Me.PersetujuanFlowDisplayPage1.BackColor = System.Drawing.Color.Transparent
        Me.PersetujuanFlowDisplayPage1.BackgroundImage = CType(resources.GetObject("PersetujuanFlowDisplayPage1.BackgroundImage"), System.Drawing.Image)
        Me.PersetujuanFlowDisplayPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PersetujuanFlowDisplayPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersetujuanFlowDisplayPage1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersetujuanFlowDisplayPage1.ImageTitle = Nothing
        Me.PersetujuanFlowDisplayPage1.Location = New System.Drawing.Point(0, 0)
        Me.PersetujuanFlowDisplayPage1.lvPageActivities = Nothing
        Me.PersetujuanFlowDisplayPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.PersetujuanFlowDisplayPage1.Name = "PersetujuanFlowDisplayPage1"
        Me.PersetujuanFlowDisplayPage1.Size = New System.Drawing.Size(1300, 820)
        Me.PersetujuanFlowDisplayPage1.TabIndex = 17
        Me.PersetujuanFlowDisplayPage1.Title = "Aliran Permohonan"
        '
        'FlowPersetujuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 820)
        Me.Controls.Add(Me.PersetujuanFlowDisplayPage1)
        Me.Controls.Add(Me.btnPendaftaran)
        Me.Controls.Add(Me.lblCurrentPendaftaran)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.lblCurrentPembayaran)
        Me.Controls.Add(Me.btnPemberkasan)
        Me.Controls.Add(Me.lblCurrentFoto)
        Me.Controls.Add(Me.lblCurrentPemberkasan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FlowPersetujuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AntrianForUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPembayaran As System.Windows.Forms.Button
    Friend WithEvents btnPemberkasan As System.Windows.Forms.Button
    Friend WithEvents btnFoto As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As gLabel.gLabel
    Friend WithEvents lblCurrentFoto As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPemberkasan As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblCurrentPembayaran As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPendaftaran As System.Windows.Forms.Label
    Friend WithEvents btnPendaftaran As System.Windows.Forms.Button
    Friend WithEvents PersetujuanFlowDisplayPage1 As TransaksiModule.PersetujuanFlowDisplayPage
End Class
