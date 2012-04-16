<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AntrianForDisplay
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
        Dim CBlendItems2 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems3 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems4 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems5 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AntrianForDisplay))
        Me.lblAntrianPembayaran = New gLabel.gLabel()
        Me.lblTime = New gLabel.gLabel()
        Me.lblAntrianPemberkasan = New gLabel.gLabel()
        Me.lblAntrianPendaftaran = New gLabel.gLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAntrianFoto = New gLabel.gLabel()
        Me.SuspendLayout()
        '
        'lblAntrianPembayaran
        '
        Me.lblAntrianPembayaran.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrianPembayaran.BorderWidth = 1.0!
        Me.lblAntrianPembayaran.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblAntrianPembayaran.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblAntrianPembayaran.Font = New System.Drawing.Font("Impact", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntrianPembayaran.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblAntrianPembayaran.ForeColorBlend = CBlendItems1
        Me.lblAntrianPembayaran.Glow = 12
        Me.lblAntrianPembayaran.GlowColor = System.Drawing.Color.Crimson
        Me.lblAntrianPembayaran.Location = New System.Drawing.Point(1029, 502)
        Me.lblAntrianPembayaran.MouseOver = False
        Me.lblAntrianPembayaran.MouseOverColor = System.Drawing.Color.Gray
        Me.lblAntrianPembayaran.Name = "lblAntrianPembayaran"
        Me.lblAntrianPembayaran.PulseSpeed = 100
        Me.lblAntrianPembayaran.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblAntrianPembayaran.Size = New System.Drawing.Size(347, 364)
        Me.lblAntrianPembayaran.TabIndex = 15
        Me.lblAntrianPembayaran.TabStop = True
        Me.lblAntrianPembayaran.Text = "0"
        Me.lblAntrianPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.BorderWidth = 1.0!
        Me.lblTime.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblTime.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblTime.Font = New System.Drawing.Font("Impact", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DodgerBlue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblTime.ForeColorBlend = CBlendItems2
        Me.lblTime.Glow = 12
        Me.lblTime.GlowColor = System.Drawing.Color.Crimson
        Me.lblTime.GlowState = False
        Me.lblTime.Location = New System.Drawing.Point(641, 41)
        Me.lblTime.MouseOver = False
        Me.lblTime.MouseOverColor = System.Drawing.Color.Gray
        Me.lblTime.Name = "lblTime"
        Me.lblTime.PulseSpeed = 100
        Me.lblTime.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblTime.Size = New System.Drawing.Size(618, 50)
        Me.lblTime.TabIndex = 13
        Me.lblTime.TabStop = True
        Me.lblTime.Text = "Date : Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAntrianPemberkasan
        '
        Me.lblAntrianPemberkasan.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrianPemberkasan.BorderWidth = 1.0!
        Me.lblAntrianPemberkasan.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblAntrianPemberkasan.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblAntrianPemberkasan.Font = New System.Drawing.Font("Impact", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntrianPemberkasan.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems3.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblAntrianPemberkasan.ForeColorBlend = CBlendItems3
        Me.lblAntrianPemberkasan.Glow = 12
        Me.lblAntrianPemberkasan.GlowColor = System.Drawing.Color.Crimson
        Me.lblAntrianPemberkasan.Location = New System.Drawing.Point(553, 502)
        Me.lblAntrianPemberkasan.MouseOver = False
        Me.lblAntrianPemberkasan.MouseOverColor = System.Drawing.Color.Gray
        Me.lblAntrianPemberkasan.Name = "lblAntrianPemberkasan"
        Me.lblAntrianPemberkasan.PulseSpeed = 100
        Me.lblAntrianPemberkasan.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblAntrianPemberkasan.Size = New System.Drawing.Size(347, 364)
        Me.lblAntrianPemberkasan.TabIndex = 15
        Me.lblAntrianPemberkasan.TabStop = True
        Me.lblAntrianPemberkasan.Text = "0"
        Me.lblAntrianPemberkasan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAntrianPendaftaran
        '
        Me.lblAntrianPendaftaran.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrianPendaftaran.BorderWidth = 1.0!
        Me.lblAntrianPendaftaran.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblAntrianPendaftaran.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblAntrianPendaftaran.Font = New System.Drawing.Font("Impact", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntrianPendaftaran.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems4.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblAntrianPendaftaran.ForeColorBlend = CBlendItems4
        Me.lblAntrianPendaftaran.Glow = 12
        Me.lblAntrianPendaftaran.GlowColor = System.Drawing.Color.Crimson
        Me.lblAntrianPendaftaran.Location = New System.Drawing.Point(71, 502)
        Me.lblAntrianPendaftaran.MouseOver = False
        Me.lblAntrianPendaftaran.MouseOverColor = System.Drawing.Color.Gray
        Me.lblAntrianPendaftaran.Name = "lblAntrianPendaftaran"
        Me.lblAntrianPendaftaran.PulseSpeed = 100
        Me.lblAntrianPendaftaran.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblAntrianPendaftaran.Size = New System.Drawing.Size(347, 364)
        Me.lblAntrianPendaftaran.TabIndex = 14
        Me.lblAntrianPendaftaran.TabStop = True
        Me.lblAntrianPendaftaran.Text = "0"
        Me.lblAntrianPendaftaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'lblAntrianFoto
        '
        Me.lblAntrianFoto.BackColor = System.Drawing.Color.Transparent
        Me.lblAntrianFoto.BorderWidth = 1.0!
        Me.lblAntrianFoto.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblAntrianFoto.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblAntrianFoto.Font = New System.Drawing.Font("Impact", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntrianFoto.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems5.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblAntrianFoto.ForeColorBlend = CBlendItems5
        Me.lblAntrianFoto.Glow = 12
        Me.lblAntrianFoto.GlowColor = System.Drawing.Color.Crimson
        Me.lblAntrianFoto.Location = New System.Drawing.Point(1503, 502)
        Me.lblAntrianFoto.MouseOver = False
        Me.lblAntrianFoto.MouseOverColor = System.Drawing.Color.Gray
        Me.lblAntrianFoto.Name = "lblAntrianFoto"
        Me.lblAntrianFoto.PulseSpeed = 100
        Me.lblAntrianFoto.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblAntrianFoto.Size = New System.Drawing.Size(347, 364)
        Me.lblAntrianFoto.TabIndex = 16
        Me.lblAntrianFoto.TabStop = True
        Me.lblAntrianFoto.Text = "0"
        Me.lblAntrianFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AntrianForDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.AntrianForDisplay_1980x1080.My.Resources.Resources.bg_form_signage2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 820)
        Me.Controls.Add(Me.lblAntrianFoto)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblAntrianPembayaran)
        Me.Controls.Add(Me.lblAntrianPemberkasan)
        Me.Controls.Add(Me.lblAntrianPendaftaran)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AntrianForDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As gLabel.gLabel
    Friend WithEvents lblAntrianPemberkasan As gLabel.gLabel
    Friend WithEvents lblAntrianPendaftaran As gLabel.gLabel
    Friend WithEvents lblAntrianPembayaran As gLabel.gLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblAntrianFoto As gLabel.gLabel
End Class
