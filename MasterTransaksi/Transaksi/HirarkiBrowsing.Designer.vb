<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HirarkiBrowsing
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
        Me.tree = New DevComponents.AdvTree.AdvTree()
        Me.columnHeader4 = New DevComponents.AdvTree.ColumnHeader()
        Me.columnHeader5 = New DevComponents.AdvTree.ColumnHeader()
        Me.columnHeader6 = New DevComponents.AdvTree.ColumnHeader()
        Me.nodeBundlePermohonan = New DevComponents.AdvTree.Node()
        Me.Node2 = New DevComponents.AdvTree.Node()
        Me.Node4 = New DevComponents.AdvTree.Node()
        Me.Cell18 = New DevComponents.AdvTree.Cell()
        Me.Node5 = New DevComponents.AdvTree.Node()
        Me.Node8 = New DevComponents.AdvTree.Node()
        Me.Cell17 = New DevComponents.AdvTree.Cell()
        Me.Cell19 = New DevComponents.AdvTree.Cell()
        Me.Node9 = New DevComponents.AdvTree.Node()
        Me.Cell20 = New DevComponents.AdvTree.Cell()
        Me.Cell21 = New DevComponents.AdvTree.Cell()
        Me.Node6 = New DevComponents.AdvTree.Node()
        Me.Node10 = New DevComponents.AdvTree.Node()
        Me.Node7 = New DevComponents.AdvTree.Node()
        Me.Node11 = New DevComponents.AdvTree.Node()
        Me.Node3 = New DevComponents.AdvTree.Node()
        Me.Node12 = New DevComponents.AdvTree.Node()
        Me.Node13 = New DevComponents.AdvTree.Node()
        Me.nodePemerintahan = New DevComponents.AdvTree.Node()
        Me.Node18 = New DevComponents.AdvTree.Node()
        Me.nodePenerbangan = New DevComponents.AdvTree.Node()
        Me.Node19 = New DevComponents.AdvTree.Node()
        Me.nodeNonPenerbangan = New DevComponents.AdvTree.Node()
        Me.Node20 = New DevComponents.AdvTree.Node()
        Me.nodeUmum = New DevComponents.AdvTree.Node()
        Me.Node21 = New DevComponents.AdvTree.Node()
        Me.elementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.unreadEmailStyle = New DevComponents.DotNetBar.ElementStyle()
        Me.cell9 = New DevComponents.AdvTree.Cell()
        Me.cell10 = New DevComponents.AdvTree.Cell()
        Me.cell7 = New DevComponents.AdvTree.Cell()
        Me.cell8 = New DevComponents.AdvTree.Cell()
        Me.cell15 = New DevComponents.AdvTree.Cell()
        Me.cell16 = New DevComponents.AdvTree.Cell()
        Me.cell13 = New DevComponents.AdvTree.Cell()
        Me.cell14 = New DevComponents.AdvTree.Cell()
        Me.cell1 = New DevComponents.AdvTree.Cell()
        Me.cell2 = New DevComponents.AdvTree.Cell()
        Me.cell3 = New DevComponents.AdvTree.Cell()
        Me.cell4 = New DevComponents.AdvTree.Cell()
        Me.cell5 = New DevComponents.AdvTree.Cell()
        Me.cell6 = New DevComponents.AdvTree.Cell()
        Me.cell11 = New DevComponents.AdvTree.Cell()
        Me.cell12 = New DevComponents.AdvTree.Cell()
        Me.btnPopupDialog = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlViewer = New DevComponents.DotNetBar.PanelEx()
        CType(Me.tree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tree
        '
        Me.tree.AllowDrop = True
        Me.tree.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.tree.BackgroundStyle.Class = "TreeBorderKey"
        Me.tree.Columns.Add(Me.columnHeader4)
        Me.tree.Columns.Add(Me.columnHeader5)
        Me.tree.Columns.Add(Me.columnHeader6)
        Me.tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tree.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
        Me.tree.ExpandWidth = 14
        Me.tree.Location = New System.Drawing.Point(3, 39)
        Me.tree.Name = "tree"
        Me.tree.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.nodeBundlePermohonan, Me.Node13})
        Me.tree.NodeStyle = Me.elementStyle2
        Me.tree.PathSeparator = ";"
        Me.tree.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
        Me.tree.Size = New System.Drawing.Size(711, 249)
        Me.tree.Styles.Add(Me.elementStyle2)
        Me.tree.Styles.Add(Me.unreadEmailStyle)
        Me.tree.SuspendPaint = False
        Me.tree.TabIndex = 1
        Me.tree.Text = "advTree2"
        '
        'columnHeader4
        '
        Me.columnHeader4.Name = "columnHeader4"
        Me.columnHeader4.Text = "Tipe"
        Me.columnHeader4.Width.Absolute = 300
        '
        'columnHeader5
        '
        Me.columnHeader5.Name = "columnHeader5"
        Me.columnHeader5.Text = "Data"
        Me.columnHeader5.Width.Absolute = 400
        '
        'columnHeader6
        '
        Me.columnHeader6.Name = "columnHeader6"
        Me.columnHeader6.Text = "Keterangan"
        Me.columnHeader6.Width.Absolute = 300
        '
        'nodeBundlePermohonan
        '
        Me.nodeBundlePermohonan.Name = "nodeBundlePermohonan"
        Me.nodeBundlePermohonan.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node2, Me.Node3})
        Me.nodeBundlePermohonan.Text = "Bundle Permohonan(23)"
        Me.nodeBundlePermohonan.Visible = False
        '
        'Node2
        '
        Me.Node2.Expanded = True
        Me.Node2.Name = "Node2"
        Me.Node2.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node4})
        Me.Node2.Text = "Sedang diproses(1)"
        '
        'Node4
        '
        Me.Node4.Cells.Add(Me.Cell18)
        Me.Node4.Expanded = True
        Me.Node4.Name = "Node4"
        Me.Node4.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node5, Me.Node6, Me.Node7})
        Me.Node4.Text = "T.2012-02-17/236.GA (17)"
        '
        'Cell18
        '
        Me.Cell18.Name = "Cell18"
        Me.Cell18.StyleMouseOver = Nothing
        Me.Cell18.Text = "PAREWA AERO CATERING"
        '
        'Node5
        '
        Me.Node5.Expanded = True
        Me.Node5.Name = "Node5"
        Me.Node5.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node8, Me.Node9})
        Me.Node5.Text = "Diproses(2)"
        '
        'Node8
        '
        Me.Node8.Cells.Add(Me.Cell17)
        Me.Node8.Cells.Add(Me.Cell19)
        Me.Node8.Expanded = True
        Me.Node8.Name = "Node8"
        Me.Node8.Text = "T.2012-02-17/1.GA"
        '
        'Cell17
        '
        Me.Cell17.Name = "Cell17"
        Me.Cell17.StyleMouseOver = Nothing
        Me.Cell17.Text = "DADANG HERMAWAN"
        '
        'Cell19
        '
        Me.Cell19.Name = "Cell19"
        Me.Cell19.StyleMouseOver = Nothing
        Me.Cell19.Text = "Persetujuan Kepala Kantor"
        '
        'Node9
        '
        Me.Node9.Cells.Add(Me.Cell20)
        Me.Node9.Cells.Add(Me.Cell21)
        Me.Node9.Expanded = True
        Me.Node9.Name = "Node9"
        Me.Node9.Text = "T.2012-02-17/2.GA"
        '
        'Cell20
        '
        Me.Cell20.Name = "Cell20"
        Me.Cell20.StyleMouseOver = Nothing
        Me.Cell20.Text = "HARRI WIDIYANTO"
        '
        'Cell21
        '
        Me.Cell21.Name = "Cell21"
        Me.Cell21.StyleMouseOver = Nothing
        Me.Cell21.Text = "Persetujuan Kepala Kantor"
        '
        'Node6
        '
        Me.Node6.Name = "Node6"
        Me.Node6.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node10})
        Me.Node6.Text = "Diterima(13)"
        '
        'Node10
        '
        Me.Node10.Expanded = True
        Me.Node10.Name = "Node10"
        Me.Node10.Text = "Node10"
        '
        'Node7
        '
        Me.Node7.Name = "Node7"
        Me.Node7.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node11})
        Me.Node7.Text = "Ditolak(2)"
        '
        'Node11
        '
        Me.Node11.Expanded = True
        Me.Node11.Name = "Node11"
        Me.Node11.Text = "Node11"
        '
        'Node3
        '
        Me.Node3.Name = "Node3"
        Me.Node3.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node12})
        Me.Node3.Text = "Selesai Diproses(22)"
        '
        'Node12
        '
        Me.Node12.Expanded = True
        Me.Node12.Name = "Node12"
        Me.Node12.Text = "Node12"
        '
        'Node13
        '
        Me.Node13.Expanded = True
        Me.Node13.Name = "Node13"
        Me.Node13.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.nodePemerintahan, Me.nodePenerbangan, Me.nodeNonPenerbangan, Me.nodeUmum})
        Me.Node13.Text = "Instansi"
        '
        'nodePemerintahan
        '
        Me.nodePemerintahan.Name = "nodePemerintahan"
        Me.nodePemerintahan.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node18})
        Me.nodePemerintahan.Text = "Pemerintahan"
        '
        'Node18
        '
        Me.Node18.Expanded = True
        Me.Node18.Name = "Node18"
        Me.Node18.Text = "Dummy"
        '
        'nodePenerbangan
        '
        Me.nodePenerbangan.Name = "nodePenerbangan"
        Me.nodePenerbangan.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node19})
        Me.nodePenerbangan.Text = "Penerbangan"
        '
        'Node19
        '
        Me.Node19.Expanded = True
        Me.Node19.Name = "Node19"
        Me.Node19.Text = "Dummy"
        '
        'nodeNonPenerbangan
        '
        Me.nodeNonPenerbangan.Name = "nodeNonPenerbangan"
        Me.nodeNonPenerbangan.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node20})
        Me.nodeNonPenerbangan.Text = "Non Penerbangan"
        '
        'Node20
        '
        Me.Node20.Expanded = True
        Me.Node20.Name = "Node20"
        Me.Node20.Text = "Dummy"
        '
        'nodeUmum
        '
        Me.nodeUmum.Name = "nodeUmum"
        Me.nodeUmum.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node21})
        Me.nodeUmum.Text = "Umum"
        '
        'Node21
        '
        Me.Node21.Expanded = True
        Me.Node21.Name = "Node21"
        Me.Node21.Text = "Dummy"
        '
        'elementStyle2
        '
        Me.elementStyle2.Name = "elementStyle2"
        Me.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText
        '
        'unreadEmailStyle
        '
        Me.unreadEmailStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unreadEmailStyle.Name = "unreadEmailStyle"
        '
        'cell9
        '
        Me.cell9.Name = "cell9"
        Me.cell9.StyleMouseOver = Nothing
        Me.cell9.Text = "ZipZoomfly Your Luck is Here"
        '
        'cell10
        '
        Me.cell10.Name = "cell10"
        Me.cell10.StyleMouseOver = Nothing
        Me.cell10.Text = "Tue 3/4/2008 1:38 PM"
        '
        'cell7
        '
        Me.cell7.Name = "cell7"
        Me.cell7.StyleMouseOver = Nothing
        Me.cell7.Text = "Free Shipping on Acer Notebook $549.99, and Dont Miss Our Canon SD1100 Sweepstake" & _
            "s!"
        '
        'cell8
        '
        Me.cell8.Name = "cell8"
        Me.cell8.StyleMouseOver = Nothing
        Me.cell8.Text = "Thu 4/10/2008 6:38 AM"
        '
        'cell15
        '
        Me.cell15.Name = "cell15"
        Me.cell15.StyleMouseOver = Nothing
        Me.cell15.Text = "DotNetBar for Windows Forms 7.3 Released"
        '
        'cell16
        '
        Me.cell16.Name = "cell16"
        Me.cell16.StyleMouseOver = Nothing
        Me.cell16.Text = "Wed 4/30/2008 8:00 PM"
        '
        'cell13
        '
        Me.cell13.Name = "cell13"
        Me.cell13.StyleMouseOver = Nothing
        Me.cell13.Text = "Certified GoDaddy.com Renewal Notice"
        '
        'cell14
        '
        Me.cell14.Name = "cell14"
        Me.cell14.StyleMouseOver = Nothing
        Me.cell14.Text = "Wed 4/2/2008 7:09 AM"
        '
        'cell1
        '
        Me.cell1.Name = "cell1"
        Me.cell1.StyleMouseOver = Nothing
        Me.cell1.Text = "DotNetBar now includes advanced Tree control"
        '
        'cell2
        '
        Me.cell2.Name = "cell2"
        Me.cell2.StyleMouseOver = Nothing
        Me.cell2.Text = "Fri 4/11/2008 11:45 AM"
        '
        'cell3
        '
        Me.cell3.Name = "cell3"
        Me.cell3.StyleMouseOver = Nothing
        Me.cell3.Text = "VW brings back Golf GTI Pirelli in the UK"
        '
        'cell4
        '
        Me.cell4.Name = "cell4"
        Me.cell4.StyleMouseOver = Nothing
        Me.cell4.Text = "Fri 4/10/2008 9:01 AM"
        '
        'cell5
        '
        Me.cell5.Name = "cell5"
        Me.cell5.StyleMouseOver = Nothing
        Me.cell5.Text = "Canon's Rebel XSi turns up in retail spy shot"
        '
        'cell6
        '
        Me.cell6.Name = "cell6"
        Me.cell6.StyleMouseOver = Nothing
        Me.cell6.Text = "Fri 4/10/2008 9:01 AM"
        '
        'cell11
        '
        Me.cell11.Name = "cell11"
        Me.cell11.StyleMouseOver = Nothing
        Me.cell11.Text = "Amazon.de empfiehlt ""Asterix bei den Briten"" und mehr"
        '
        'cell12
        '
        Me.cell12.Name = "cell12"
        Me.cell12.StyleMouseOver = Nothing
        Me.cell12.Text = "Tue 1/15/2008 1:13 AM"
        '
        'btnPopupDialog
        '
        Me.btnPopupDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPopupDialog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPopupDialog.Location = New System.Drawing.Point(3, 3)
        Me.btnPopupDialog.Name = "btnPopupDialog"
        Me.btnPopupDialog.Size = New System.Drawing.Size(75, 23)
        Me.btnPopupDialog.TabIndex = 2
        Me.btnPopupDialog.Text = "Preview.."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tree, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlViewer, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(717, 379)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPopupDialog)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 30)
        Me.Panel1.TabIndex = 2
        '
        'pnlViewer
        '
        Me.pnlViewer.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewer.Location = New System.Drawing.Point(3, 294)
        Me.pnlViewer.Name = "pnlViewer"
        Me.pnlViewer.Size = New System.Drawing.Size(711, 82)
        Me.pnlViewer.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlViewer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlViewer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlViewer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlViewer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlViewer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlViewer.Style.GradientAngle = 90
        Me.pnlViewer.TabIndex = 3
        Me.pnlViewer.Text = "PanelEx1"
        '
        'HirarkiBrowsing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "HirarkiBrowsing"
        Me.Size = New System.Drawing.Size(717, 379)
        Me.Title = "Penjelajahan Data"
        CType(Me.tree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tree As DevComponents.AdvTree.AdvTree
    Private WithEvents columnHeader4 As DevComponents.AdvTree.ColumnHeader
    Private WithEvents columnHeader5 As DevComponents.AdvTree.ColumnHeader
    Private WithEvents columnHeader6 As DevComponents.AdvTree.ColumnHeader
    Private WithEvents nodeBundlePermohonan As DevComponents.AdvTree.Node
    Private WithEvents cell11 As DevComponents.AdvTree.Cell
    Private WithEvents cell12 As DevComponents.AdvTree.Cell
    Private WithEvents cell7 As DevComponents.AdvTree.Cell
    Private WithEvents cell8 As DevComponents.AdvTree.Cell
    Private WithEvents unreadEmailStyle As DevComponents.DotNetBar.ElementStyle
    Private WithEvents cell15 As DevComponents.AdvTree.Cell
    Private WithEvents cell16 As DevComponents.AdvTree.Cell
    Private WithEvents cell13 As DevComponents.AdvTree.Cell
    Private WithEvents cell14 As DevComponents.AdvTree.Cell
    Private WithEvents cell1 As DevComponents.AdvTree.Cell
    Private WithEvents cell2 As DevComponents.AdvTree.Cell
    Private WithEvents cell3 As DevComponents.AdvTree.Cell
    Private WithEvents cell4 As DevComponents.AdvTree.Cell
    Private WithEvents cell5 As DevComponents.AdvTree.Cell
    Private WithEvents cell6 As DevComponents.AdvTree.Cell
    Private WithEvents cell9 As DevComponents.AdvTree.Cell
    Private WithEvents cell10 As DevComponents.AdvTree.Cell
    Private WithEvents elementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Node2 As DevComponents.AdvTree.Node
    Friend WithEvents Node4 As DevComponents.AdvTree.Node
    Friend WithEvents Node5 As DevComponents.AdvTree.Node
    Friend WithEvents Node3 As DevComponents.AdvTree.Node
    Friend WithEvents Node8 As DevComponents.AdvTree.Node
    Friend WithEvents Node6 As DevComponents.AdvTree.Node
    Friend WithEvents Node7 As DevComponents.AdvTree.Node
    Friend WithEvents Cell18 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell17 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell19 As DevComponents.AdvTree.Cell
    Friend WithEvents Node9 As DevComponents.AdvTree.Node
    Friend WithEvents Cell20 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell21 As DevComponents.AdvTree.Cell
    Friend WithEvents Node10 As DevComponents.AdvTree.Node
    Friend WithEvents Node11 As DevComponents.AdvTree.Node
    Friend WithEvents Node12 As DevComponents.AdvTree.Node
    Friend WithEvents Node13 As DevComponents.AdvTree.Node
    Friend WithEvents nodePemerintahan As DevComponents.AdvTree.Node
    Friend WithEvents Node18 As DevComponents.AdvTree.Node
    Friend WithEvents nodePenerbangan As DevComponents.AdvTree.Node
    Friend WithEvents Node19 As DevComponents.AdvTree.Node
    Friend WithEvents nodeNonPenerbangan As DevComponents.AdvTree.Node
    Friend WithEvents Node20 As DevComponents.AdvTree.Node
    Friend WithEvents nodeUmum As DevComponents.AdvTree.Node
    Friend WithEvents Node21 As DevComponents.AdvTree.Node
    Friend WithEvents btnPopupDialog As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlViewer As DevComponents.DotNetBar.PanelEx

End Class
