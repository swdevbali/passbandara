<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AntrianTransactionPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AntrianTransactionPage))
        Me.cboAntrian = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNamaAntrian = New System.Windows.Forms.Label()
        Me.lblTotalAntrian = New System.Windows.Forms.Label()
        Me.btnProsesAntrian = New System.Windows.Forms.Button()
        Me.btnBatalkanProsesAntrian = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnPanggilKembali = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAntrian
        '
        Me.cboAntrian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAntrian.FormattingEnabled = True
        Me.cboAntrian.Items.AddRange(New Object() {"Foto", "Pemberkasan", "Pembayaran", "Pendaftaran"})
        Me.cboAntrian.Location = New System.Drawing.Point(97, 186)
        Me.cboAntrian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboAntrian.Name = "cboAntrian"
        Me.cboAntrian.Size = New System.Drawing.Size(260, 29)
        Me.cboAntrian.TabIndex = 0
        Me.cboAntrian.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Antrian"
        Me.Label1.Visible = False
        '
        'lblNamaAntrian
        '
        Me.lblNamaAntrian.AutoSize = True
        Me.lblNamaAntrian.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblNamaAntrian.Location = New System.Drawing.Point(4, 0)
        Me.lblNamaAntrian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAntrian.Name = "lblNamaAntrian"
        Me.lblNamaAntrian.Size = New System.Drawing.Size(141, 29)
        Me.lblNamaAntrian.TabIndex = 2
        Me.lblNamaAntrian.Text = "Total Antrian"
        '
        'lblTotalAntrian
        '
        Me.lblTotalAntrian.AutoSize = True
        Me.lblTotalAntrian.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblTotalAntrian.Location = New System.Drawing.Point(391, 0)
        Me.lblTotalAntrian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAntrian.Name = "lblTotalAntrian"
        Me.lblTotalAntrian.Size = New System.Drawing.Size(27, 29)
        Me.lblTotalAntrian.TabIndex = 3
        Me.lblTotalAntrian.Text = "--"
        '
        'btnProsesAntrian
        '
        Me.btnProsesAntrian.Location = New System.Drawing.Point(31, 63)
        Me.btnProsesAntrian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProsesAntrian.Name = "btnProsesAntrian"
        Me.btnProsesAntrian.Size = New System.Drawing.Size(241, 70)
        Me.btnProsesAntrian.TabIndex = 4
        Me.btnProsesAntrian.Text = "Proses Antrian"
        Me.btnProsesAntrian.UseVisualStyleBackColor = True
        '
        'btnBatalkanProsesAntrian
        '
        Me.btnBatalkanProsesAntrian.Location = New System.Drawing.Point(31, 143)
        Me.btnBatalkanProsesAntrian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBatalkanProsesAntrian.Name = "btnBatalkanProsesAntrian"
        Me.btnBatalkanProsesAntrian.Size = New System.Drawing.Size(241, 37)
        Me.btnBatalkanProsesAntrian.TabIndex = 5
        Me.btnBatalkanProsesAntrian.Text = "Batalkan"
        Me.btnBatalkanProsesAntrian.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'btnInitialize
        '
        Me.btnInitialize.Location = New System.Drawing.Point(280, 143)
        Me.btnInitialize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(241, 37)
        Me.btnInitialize.TabIndex = 6
        Me.btnInitialize.Text = "Reset Antrian"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(365, 186)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(143, 66)
        Me.AxWindowsMediaPlayer1.TabIndex = 7
        '
        'btnPanggilKembali
        '
        Me.btnPanggilKembali.Location = New System.Drawing.Point(280, 63)
        Me.btnPanggilKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPanggilKembali.Name = "btnPanggilKembali"
        Me.btnPanggilKembali.Size = New System.Drawing.Size(241, 70)
        Me.btnPanggilKembali.TabIndex = 8
        Me.btnPanggilKembali.Text = "Pemanggilan Ulang"
        Me.btnPanggilKembali.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.18367!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.81633!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblNamaAntrian, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotalAntrian, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(490, 34)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'AntrianTransactionPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnPanggilKembali)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnInitialize)
        Me.Controls.Add(Me.btnBatalkanProsesAntrian)
        Me.Controls.Add(Me.btnProsesAntrian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAntrian)
        Me.ImageTitle = Global.TransaksiModule.My.Resources.Resources.note_accept
        Me.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.Name = "AntrianTransactionPage"
        Me.Size = New System.Drawing.Size(546, 232)
        Me.Title = "Antrian Kasir"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAntrian As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNamaAntrian As System.Windows.Forms.Label
    Friend WithEvents lblTotalAntrian As System.Windows.Forms.Label
    Friend WithEvents btnProsesAntrian As System.Windows.Forms.Button
    Friend WithEvents btnBatalkanProsesAntrian As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnInitialize As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnPanggilKembali As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
