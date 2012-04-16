Imports SwdevIUIcore


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdministratorPage
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeAdministratorPage))
        Me.GLabel16 = New gLabel.gLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.linkLogout = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvAdministratorActivities = New System.Windows.Forms.ListView()
        Me.imglstLarge1 = New System.Windows.Forms.ImageList(Me.components)
        Me.imglstSmall1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cboLvStyle = New System.Windows.Forms.ComboBox()
        Me.linkAntrianForDisplay = New System.Windows.Forms.LinkLabel()
        Me.linkAntrianUser = New System.Windows.Forms.LinkLabel()
        Me.linkAntrianPopup = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.GLabel16.Location = New System.Drawing.Point(233, 17)
        Me.GLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GLabel16.MouseOver = False
        Me.GLabel16.MouseOverColor = System.Drawing.Color.Gray
        Me.GLabel16.Name = "GLabel16"
        Me.GLabel16.PulseSpeed = 100
        Me.GLabel16.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.GLabel16.Size = New System.Drawing.Size(327, 33)
        Me.GLabel16.TabIndex = 12
        Me.GLabel16.TabStop = True
        Me.GLabel16.Text = "Pengelola Aplikasi"
        Me.GLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PassBandara.My.Resources.Resources.img_sampingkecil1
        Me.PictureBox1.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 377)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Things"
        Me.ColumnHeader3.Width = 259
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Things"
        Me.ColumnHeader1.Width = 259
        '
        'linkLogout
        '
        Me.linkLogout.AutoSize = True
        Me.linkLogout.Location = New System.Drawing.Point(1008, 46)
        Me.linkLogout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(58, 21)
        Me.linkLogout.TabIndex = 45
        Me.linkLogout.TabStop = True
        Me.linkLogout.Text = "Logout"
        Me.linkLogout.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "All Activities"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Task"
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 260
        '
        'lvAdministratorActivities
        '
        Me.lvAdministratorActivities.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvAdministratorActivities.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAdministratorActivities.BackgroundImage = Global.PassBandara.My.Resources.Resources.bg_dalem3
        Me.lvAdministratorActivities.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAdministratorActivities.HotTracking = True
        Me.lvAdministratorActivities.HoverSelection = True
        Me.lvAdministratorActivities.LargeImageList = Me.imglstLarge1
        Me.lvAdministratorActivities.Location = New System.Drawing.Point(239, 71)
        Me.lvAdministratorActivities.Margin = New System.Windows.Forms.Padding(4)
        Me.lvAdministratorActivities.Name = "lvAdministratorActivities"
        Me.lvAdministratorActivities.Size = New System.Drawing.Size(1543, 1214)
        Me.lvAdministratorActivities.SmallImageList = Me.imglstSmall1
        Me.lvAdministratorActivities.TabIndex = 46
        Me.lvAdministratorActivities.UseCompatibleStateImageBehavior = False
        Me.lvAdministratorActivities.View = System.Windows.Forms.View.Details
        '
        'imglstLarge1
        '
        Me.imglstLarge1.ImageStream = CType(resources.GetObject("imglstLarge1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstLarge1.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstLarge1.Images.SetKeyName(0, "Clock.png")
        Me.imglstLarge1.Images.SetKeyName(1, "Favorite.png")
        Me.imglstLarge1.Images.SetKeyName(2, "Floppy.png")
        Me.imglstLarge1.Images.SetKeyName(3, "Gear.png")
        Me.imglstLarge1.Images.SetKeyName(4, "Globe.png")
        Me.imglstLarge1.Images.SetKeyName(5, "IPOD.png")
        Me.imglstLarge1.Images.SetKeyName(6, "Reel.png")
        Me.imglstLarge1.Images.SetKeyName(7, "icon_master_ID2_48.png")
        Me.imglstLarge1.Images.SetKeyName(8, "icon_pemberkasan_48.png")
        Me.imglstLarge1.Images.SetKeyName(9, "icon_persetujuan_48.png")
        Me.imglstLarge1.Images.SetKeyName(10, "48_electronic_billing_machine.png")
        Me.imglstLarge1.Images.SetKeyName(11, "m_area_128.png")
        Me.imglstLarge1.Images.SetKeyName(12, "m_berkas_128.png")
        Me.imglstLarge1.Images.SetKeyName(13, "m_dll_128.png")
        Me.imglstLarge1.Images.SetKeyName(14, "m_instansi_128.png")
        Me.imglstLarge1.Images.SetKeyName(15, "m_jabatan_128.png")
        Me.imglstLarge1.Images.SetKeyName(16, "m_jenisberkas_128.png")
        Me.imglstLarge1.Images.SetKeyName(17, "m_log_128.png")
        Me.imglstLarge1.Images.SetKeyName(18, "m_pemohon_128.png")
        Me.imglstLarge1.Images.SetKeyName(19, "m_permohonan_128.png")
        Me.imglstLarge1.Images.SetKeyName(20, "m_permohonanbundle_128.png")
        Me.imglstLarge1.Images.SetKeyName(21, "m_petugas_128.png")
        Me.imglstLarge1.Images.SetKeyName(22, "m_privilege_128.png")
        Me.imglstLarge1.Images.SetKeyName(23, "m_progress_128.png")
        Me.imglstLarge1.Images.SetKeyName(24, "t_pembayaran_128.png")
        Me.imglstLarge1.Images.SetKeyName(25, "t_pemberkasan_128.png")
        Me.imglstLarge1.Images.SetKeyName(26, "t_pencetakan_128.png")
        Me.imglstLarge1.Images.SetKeyName(27, "t_permohonan_128.png")
        Me.imglstLarge1.Images.SetKeyName(28, "t_persetujuan_128.png")
        Me.imglstLarge1.Images.SetKeyName(29, "t_transaksi_128.png")
        Me.imglstLarge1.Images.SetKeyName(30, "t_flowchart_128.png")
        Me.imglstLarge1.Images.SetKeyName(31, "m_berkaspemohon_128.png")
        '
        'imglstSmall1
        '
        Me.imglstSmall1.ImageStream = CType(resources.GetObject("imglstSmall1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstSmall1.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstSmall1.Images.SetKeyName(0, "Clock.png")
        Me.imglstSmall1.Images.SetKeyName(1, "Favorite.png")
        Me.imglstSmall1.Images.SetKeyName(2, "Floppy.png")
        Me.imglstSmall1.Images.SetKeyName(3, "Gear.png")
        Me.imglstSmall1.Images.SetKeyName(4, "Globe.png")
        Me.imglstSmall1.Images.SetKeyName(5, "IPOD.png")
        Me.imglstSmall1.Images.SetKeyName(6, "Reel.png")
        Me.imglstSmall1.Images.SetKeyName(7, "icon_master_ID2_32.png")
        Me.imglstSmall1.Images.SetKeyName(8, "icon_pemberkasan_32.png")
        Me.imglstSmall1.Images.SetKeyName(9, "icon_persetujuan_32.png")
        Me.imglstSmall1.Images.SetKeyName(10, "32_electronic_billing_machine.png")
        Me.imglstSmall1.Images.SetKeyName(11, "m_area_64.png")
        Me.imglstSmall1.Images.SetKeyName(12, "m_berkas_64.png")
        Me.imglstSmall1.Images.SetKeyName(13, "m_dll_64.png")
        Me.imglstSmall1.Images.SetKeyName(14, "m_instansi_64.png")
        Me.imglstSmall1.Images.SetKeyName(15, "m_jabatan_64.png")
        Me.imglstSmall1.Images.SetKeyName(16, "m_jenisberkas_64.png")
        Me.imglstSmall1.Images.SetKeyName(17, "m_log_64.png")
        Me.imglstSmall1.Images.SetKeyName(18, "m_pemohon_64.png")
        Me.imglstSmall1.Images.SetKeyName(19, "m_permohonan_64.png")
        Me.imglstSmall1.Images.SetKeyName(20, "m_permohonanbundle_64.png")
        Me.imglstSmall1.Images.SetKeyName(21, "m_petugas_64.png")
        Me.imglstSmall1.Images.SetKeyName(22, "m_privilege_64.png")
        Me.imglstSmall1.Images.SetKeyName(23, "m_progress_64.png")
        Me.imglstSmall1.Images.SetKeyName(24, "t_pembayaran_64.png")
        Me.imglstSmall1.Images.SetKeyName(25, "t_pemberkasan_64.png")
        Me.imglstSmall1.Images.SetKeyName(26, "t_pencetakan_64.png")
        Me.imglstSmall1.Images.SetKeyName(27, "t_permohonan_64.png")
        Me.imglstSmall1.Images.SetKeyName(28, "t_persetujuan_64.png")
        Me.imglstSmall1.Images.SetKeyName(29, "t_transaksi_64.png")
        Me.imglstSmall1.Images.SetKeyName(30, "t_flowchart_64.png")
        Me.imglstSmall1.Images.SetKeyName(31, "m_berkaspemohon_64.png")
        '
        'cboLvStyle
        '
        Me.cboLvStyle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboLvStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLvStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboLvStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLvStyle.FormattingEnabled = True
        Me.cboLvStyle.Items.AddRange(New Object() {"Small Icons", "Large Icons", "Detail", "Tile"})
        Me.cboLvStyle.Location = New System.Drawing.Point(557, 21)
        Me.cboLvStyle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLvStyle.Name = "cboLvStyle"
        Me.cboLvStyle.Size = New System.Drawing.Size(415, 27)
        Me.cboLvStyle.TabIndex = 48
        '
        'linkAntrianForDisplay
        '
        Me.linkAntrianForDisplay.AutoSize = True
        Me.linkAntrianForDisplay.Location = New System.Drawing.Point(976, 0)
        Me.linkAntrianForDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkAntrianForDisplay.Name = "linkAntrianForDisplay"
        Me.linkAntrianForDisplay.Size = New System.Drawing.Size(116, 21)
        Me.linkAntrianForDisplay.TabIndex = 49
        Me.linkAntrianForDisplay.TabStop = True
        Me.linkAntrianForDisplay.Text = "Antrian Display"
        Me.linkAntrianForDisplay.Visible = False
        '
        'linkAntrianUser
        '
        Me.linkAntrianUser.AutoSize = True
        Me.linkAntrianUser.Location = New System.Drawing.Point(1266, 0)
        Me.linkAntrianUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkAntrianUser.Name = "linkAntrianUser"
        Me.linkAntrianUser.Size = New System.Drawing.Size(98, 21)
        Me.linkAntrianUser.TabIndex = 50
        Me.linkAntrianUser.TabStop = True
        Me.linkAntrianUser.Text = "Antrian User"
        Me.linkAntrianUser.Visible = False
        '
        'linkAntrianPopup
        '
        Me.linkAntrianPopup.AutoSize = True
        Me.linkAntrianPopup.Location = New System.Drawing.Point(1124, 0)
        Me.linkAntrianPopup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkAntrianPopup.Name = "linkAntrianPopup"
        Me.linkAntrianPopup.Size = New System.Drawing.Size(111, 21)
        Me.linkAntrianPopup.TabIndex = 51
        Me.linkAntrianPopup.TabStop = True
        Me.linkAntrianPopup.Text = "Popup Antrian"
        Me.linkAntrianPopup.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.PassBandara.My.Resources.Resources.bt_user_logout_64
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(19, 701)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 94)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "LOG OUT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.PassBandara.My.Resources.Resources.ticket_display_64
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(19, 599)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 97)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "ANTRIAN DISPLAY"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.PassBandara.My.Resources.Resources.ticket_call_64
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(19, 498)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 96)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "ANTRIAN CALL"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.PassBandara.My.Resources.Resources.ticket_foruser_64
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(19, 397)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 96)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "ANTRIAN USER"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'HomeAdministratorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.linkAntrianPopup)
        Me.Controls.Add(Me.linkAntrianUser)
        Me.Controls.Add(Me.linkAntrianForDisplay)
        Me.Controls.Add(Me.linkLogout)
        Me.Controls.Add(Me.cboLvStyle)
        Me.Controls.Add(Me.lvAdministratorActivities)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GLabel16)
        Me.ImageTitle = Global.PassBandara.My.Resources.Resources.tool
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "HomeAdministratorPage"
        Me.Size = New System.Drawing.Size(1893, 1407)
        Me.Title = "Administrator Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GLabel16 As gLabel.gLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

    Friend WithEvents Label2 As System.Windows.Forms.Label

    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvAdministratorActivities As System.Windows.Forms.ListView
    Friend WithEvents cboLvStyle As System.Windows.Forms.ComboBox
    Friend WithEvents linkLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAntrianForDisplay As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAntrianUser As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAntrianPopup As System.Windows.Forms.LinkLabel
    Friend WithEvents imglstLarge1 As System.Windows.Forms.ImageList
    Friend WithEvents imglstSmall1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
