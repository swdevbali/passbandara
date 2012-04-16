Imports SwdevIUIcore


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        'Dim FlatMenuItemList1 As MenuControls.FlatMenuItemList = New MenuControls.FlatMenuItemList()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.lblDatabaseStatus = New System.Windows.Forms.LinkLabel()
        Me.pnlUtama = New System.Windows.Forms.Panel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.picDatabaseStatus = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabHeader = New SwdevIUICore.TabHeader()
        'Me.flatMenu = New MenuControls.FlatMenuBar()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.linkMax = New System.Windows.Forms.LinkLabel()
        Me.linkClose = New System.Windows.Forms.LinkLabel()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.picDatabaseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatabaseStatus
        '
        Me.lblDatabaseStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDatabaseStatus.AutoSize = True
        Me.lblDatabaseStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabaseStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblDatabaseStatus.Location = New System.Drawing.Point(35, 607)
        Me.lblDatabaseStatus.Name = "lblDatabaseStatus"
        Me.lblDatabaseStatus.Size = New System.Drawing.Size(59, 13)
        Me.lblDatabaseStatus.TabIndex = 28
        Me.lblDatabaseStatus.TabStop = True
        Me.lblDatabaseStatus.Text = "LinkLabel1"
        '
        'pnlUtama
        '
        Me.pnlUtama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUtama.BackColor = System.Drawing.Color.Transparent
        Me.pnlUtama.Location = New System.Drawing.Point(13, 212)
        Me.pnlUtama.Name = "pnlUtama"
        Me.pnlUtama.Size = New System.Drawing.Size(1262, 373)
        Me.pnlUtama.TabIndex = 29
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(0, 173)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(20, 19)
        Me.closeButton.TabIndex = 30
        Me.closeButton.Text = "X"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'picDatabaseStatus
        '
        Me.picDatabaseStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picDatabaseStatus.Image = Global.PassBandara.My.Resources.Resources.database_down
        Me.picDatabaseStatus.Location = New System.Drawing.Point(13, 608)
        Me.picDatabaseStatus.Name = "picDatabaseStatus"
        Me.picDatabaseStatus.Size = New System.Drawing.Size(16, 16)
        Me.picDatabaseStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDatabaseStatus.TabIndex = 27
        Me.picDatabaseStatus.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.PassBandara.My.Resources.Resources.bg_header5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.tabHeader)
        ' Me.Panel1.Controls.Add(Me.flatMenu)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.linkMax)
        Me.Panel1.Controls.Add(Me.linkClose)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 172)
        Me.Panel1.TabIndex = 22
        '
        'tabHeader
        '
        Me.tabHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHeader.BackColor = System.Drawing.Color.Transparent
        Me.tabHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabHeader.Location = New System.Drawing.Point(10, 137)
        Me.tabHeader.Margin = New System.Windows.Forms.Padding(6)
        Me.tabHeader.Name = "tabHeader"
        Me.tabHeader.Size = New System.Drawing.Size(1264, 35)
        Me.tabHeader.TabIndex = 33
        '
        'flatMenu
        '
        'Me.flatMenu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        'Me.flatMenu.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(165, Byte), Integer))
        'Me.flatMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.flatMenu.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.flatMenu.HoverFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.flatMenu.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.flatMenu.Location = New System.Drawing.Point(366, 17)
        'Me.flatMenu.MenuItems = FlatMenuItemList1
        'Me.flatMenu.Name = "flatMenu"
        'Me.flatMenu.ParentMenu = Nothing
        'Me.flatMenu.ParentMenuItem = Nothing
        'Me.flatMenu.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.flatMenu.Size = New System.Drawing.Size(75, 23)
        'Me.flatMenu.TabIndex = 32
        'Me.flatMenu.TabStop = False
        'Me.flatMenu.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.flatMenu.Visible = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(1078, 11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(57, 32)
        Me.btnMinimize.TabIndex = 31
        Me.btnMinimize.Text = "Min"
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1217, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 32)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Location = New System.Drawing.Point(1141, 11)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(70, 32)
        Me.btnMaximize.TabIndex = 29
        Me.btnMaximize.Text = "Restore"
        Me.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'linkMax
        '
        Me.linkMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkMax.AutoSize = True
        Me.linkMax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMax.LinkColor = System.Drawing.Color.White
        Me.linkMax.Location = New System.Drawing.Point(1238, 17)
        Me.linkMax.Name = "linkMax"
        Me.linkMax.Size = New System.Drawing.Size(16, 13)
        Me.linkMax.TabIndex = 27
        Me.linkMax.TabStop = True
        Me.linkMax.Text = "[ ]"
        '
        'linkClose
        '
        Me.linkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkClose.AutoSize = True
        Me.linkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkClose.LinkColor = System.Drawing.Color.White
        Me.linkClose.Location = New System.Drawing.Point(1260, 17)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(12, 13)
        Me.linkClose.TabIndex = 26
        Me.linkClose.TabStop = True
        Me.linkClose.Text = "x"
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Image = Global.PassBandara.My.Resources.Resources.left_arrow
        Me.btnPrev.Location = New System.Drawing.Point(246, 12)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(35, 36)
        Me.btnPrev.TabIndex = 24
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrev.UseVisualStyleBackColor = False
        Me.btnPrev.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = Global.PassBandara.My.Resources.Resources.right_arrow
        Me.btnNext.Location = New System.Drawing.Point(284, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 36)
        Me.btnNext.TabIndex = 23
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.PassBandara.My.Resources.Resources.home
        Me.btnHome.Location = New System.Drawing.Point(325, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(35, 36)
        Me.btnHome.TabIndex = 22
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHome.UseVisualStyleBackColor = False
        Me.btnHome.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Teal
        Me.lblUsername.Location = New System.Drawing.Point(563, 175)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(712, 34)
        Me.lblUsername.TabIndex = 31
        Me.lblUsername.Text = "Label1"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PassBandara.My.Resources.Resources.bg5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1284, 629)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.pnlUtama)
        Me.Controls.Add(Me.lblDatabaseStatus)
        Me.Controls.Add(Me.picDatabaseStatus)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<< TITLE >>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picDatabaseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents linkMax As System.Windows.Forms.LinkLabel
    Friend WithEvents linkClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    'Friend WithEvents flatMenu As MenuControls.FlatMenuBar
    Friend WithEvents picDatabaseStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblDatabaseStatus As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel
    Friend WithEvents tabHeader As SwdevIUICore.TabHeader
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
End Class
