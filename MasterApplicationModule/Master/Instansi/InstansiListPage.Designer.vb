Imports SwdevIUIDatabase

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstansiListPage
    Inherits PageListTemplate

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
        Me.SuspendLayout()
        '
        'InstansiListPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ImageTitle = Global.MasterModule.My.Resources.Resources.process
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "InstansiListPage"
        Me.Size = New System.Drawing.Size(997, 392)
        Me.Title = "Data Instansi"
        Me.ResumeLayout(False)

    End Sub

End Class
