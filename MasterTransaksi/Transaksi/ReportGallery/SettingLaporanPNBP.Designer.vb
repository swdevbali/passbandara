<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingLaporanPNBP
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
        Me.chkBulan = New System.Windows.Forms.CheckBox()
        Me.dtEnd = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtStart = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'chkBulan
        '
        Me.chkBulan.AutoSize = True
        Me.chkBulan.Location = New System.Drawing.Point(120, 227)
        Me.chkBulan.Name = "chkBulan"
        Me.chkBulan.Size = New System.Drawing.Size(120, 25)
        Me.chkBulan.TabIndex = 11
        Me.chkBulan.Text = "Bulan ini saja"
        Me.chkBulan.UseVisualStyleBackColor = True
        '
        'dtEnd
        '
        Me.dtEnd.Location = New System.Drawing.Point(605, 53)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "sampai dengan"
        '
        'dtStart
        '
        Me.dtStart.Location = New System.Drawing.Point(120, 53)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Periode"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(120, 258)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(120, 42)
        Me.ButtonX1.TabIndex = 12
        Me.ButtonX1.Text = "Tampilkan"
        '
        'SettingLaporanPNBP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.chkBulan)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.Label2)
        Me.Name = "SettingLaporanPNBP"
        Me.Size = New System.Drawing.Size(1057, 533)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkBulan As System.Windows.Forms.CheckBox
    Friend WithEvents dtEnd As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtStart As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX

End Class
