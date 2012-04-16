Imports SwdevIUICore
Imports System.Drawing

Public Class StatistikPermohonan
    Inherits PageTemplate
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Pie1.Shadow.Color = Color.Silver
        Pie1.Shadow.Height = 30
        Pie1.Shadow.Width = 50
        Pie1.Shadow.Visible = True



    End Sub

    Private Sub StatistikPermohonan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Pie1.Clear()
        Pie1.Add(210, "Diterima - Sudah dicetak")
        Pie1.Add(57, "Diterima - Belum dicetak")
        Pie1.Add(57, "Ditolak")
        Pie1.Add(112, "Diproses")


    End Sub
End Class
