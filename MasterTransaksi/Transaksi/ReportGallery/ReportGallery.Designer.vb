<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGallery
    Inherits SwdevIUICore.PageTemplate

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
        Me.sidebarProgress = New DevComponents.DotNetBar.SideBar()
        Me.SideBarPanelItem2 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlKlien = New System.Windows.Forms.Panel()
        Me.pnlKlien.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidebarProgress
        '
        Me.sidebarProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.sidebarProgress.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.sidebarProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarProgress.ExpandedPanel = Me.SideBarPanelItem1
        Me.sidebarProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.sidebarProgress.Location = New System.Drawing.Point(0, 0)
        Me.sidebarProgress.Name = "sidebarProgress"
        Me.sidebarProgress.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideBarPanelItem1, Me.SideBarPanelItem2})
        Me.sidebarProgress.Size = New System.Drawing.Size(193, 359)
        Me.sidebarProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.sidebarProgress.TabIndex = 45
        Me.sidebarProgress.Text = "Bundle Permohonan"
        '
        'SideBarPanelItem2
        '
        Me.SideBarPanelItem2.FontBold = True
        Me.SideBarPanelItem2.Name = "SideBarPanelItem2"
        Me.SideBarPanelItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2})
        Me.SideBarPanelItem2.Text = "Akunting"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Rekap PNBP"
        '
        'SideBarPanelItem1
        '
        Me.SideBarPanelItem1.FontBold = True
        Me.SideBarPanelItem1.Name = "SideBarPanelItem1"
        Me.SideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.SideBarPanelItem1.Text = "Umum"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Rekapitulasi Berkas Permohonan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Klik pada jenis laporan yang ingin ditampilkan"
        '
        'pnlKlien
        '
        Me.pnlKlien.Controls.Add(Me.Label1)
        Me.pnlKlien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKlien.Location = New System.Drawing.Point(193, 0)
        Me.pnlKlien.Name = "pnlKlien"
        Me.pnlKlien.Size = New System.Drawing.Size(419, 359)
        Me.pnlKlien.TabIndex = 47
        '
        'ReportGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlKlien)
        Me.Controls.Add(Me.sidebarProgress)
        Me.Name = "ReportGallery"
        Me.Size = New System.Drawing.Size(612, 359)
        Me.Title = "Report Gallery"
        Me.pnlKlien.ResumeLayout(False)
        Me.pnlKlien.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidebarProgress As DevComponents.DotNetBar.SideBar
    Friend WithEvents SideBarPanelItem2 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlKlien As System.Windows.Forms.Panel

End Class
