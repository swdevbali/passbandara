Imports SwdevIUIcore

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits PageTemplate

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
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.GLabel16 = New gLabel.gLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.linkSettings = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GLabel16
        '
        Me.GLabel16.BorderWidth = 1.0!
        Me.GLabel16.FillType = gLabel.gLabel.eFillType.Solid
        Me.GLabel16.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GLabel16.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel16.ForeColor = System.Drawing.Color.DodgerBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.GLabel16.ForeColorBlend = CBlendItems1
        Me.GLabel16.Glow = 12
        Me.GLabel16.GlowColor = System.Drawing.Color.Crimson
        Me.GLabel16.GlowState = False
        Me.GLabel16.Location = New System.Drawing.Point(327, 15)
        Me.GLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GLabel16.MouseOver = False
        Me.GLabel16.MouseOverColor = System.Drawing.Color.Gray
        Me.GLabel16.Name = "GLabel16"
        Me.GLabel16.PulseSpeed = 100
        Me.GLabel16.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.GLabel16.Size = New System.Drawing.Size(294, 36)
        Me.GLabel16.TabIndex = 11
        Me.GLabel16.TabStop = True
        Me.GLabel16.Text = "Selamat Datang!"
        Me.GLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(953, 148)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Location = New System.Drawing.Point(329, 612)
        Me.linkLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(216, 21)
        Me.linkLogin.TabIndex = 14
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Silahkan login terlebih dahulu"
        Me.linkLogin.Visible = False
        '
        'linkSettings
        '
        Me.linkSettings.ActiveLinkColor = System.Drawing.Color.SeaShell
        Me.linkSettings.AutoSize = True
        Me.linkSettings.Location = New System.Drawing.Point(329, 646)
        Me.linkSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkSettings.Name = "linkSettings"
        Me.linkSettings.Size = New System.Drawing.Size(316, 21)
        Me.linkSettings.TabIndex = 19
        Me.linkSettings.TabStop = True
        Me.linkSettings.Text = "Silahkan atur konfigurasinya terlebih dahulu"
        Me.linkSettings.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PassBandara.My.Resources.Resources.img_samping4
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 771)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.PassBandara.My.Resources.Resources.bt_user_login_64
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(333, 256)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 103)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "LOGIN"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.PassBandara.My.Resources.Resources.bt_dbconfig_64
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(473, 256)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 103)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "KONFIGURASI"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.linkSettings)
        Me.Controls.Add(Me.linkLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GLabel16)
        Me.ImageTitle = Global.PassBandara.My.Resources.Resources.home_24
        Me.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.Name = "HomePage"
        Me.Size = New System.Drawing.Size(1779, 1391)
        Me.Title = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GLabel16 As gLabel.gLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents linkLogin As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSettings As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
