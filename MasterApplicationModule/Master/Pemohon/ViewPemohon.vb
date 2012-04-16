Imports System.Windows.Forms

Public Class ViewPemohon
#Region "dragForm"
    'thanks to http://www.codeguru.com/forum/showthread.php?t=273022
    Dim a As Integer
    Dim b As Integer
    Dim newPoint As Drawing.Point
    Private Sub startOfDrag(ByVal sender As Object, ByVal e As MouseEventArgs)
        a = MousePosition.X - ParentForm.Location.X
        b = MousePosition.Y - ParentForm.Location.Y
    End Sub

    Private Sub drag(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            newPoint = MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            ParentForm.Location = newPoint
        End If
    End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.ParentForm.Close()
    End Sub

    Sub PopUp(ByVal dataRow As DataRow)
        Dim f As New Form
        Fill(dataRow)

        AddHandler GroupPanel1.MouseDown, AddressOf startOfDrag
        AddHandler GroupPanel1.MouseMove, AddressOf drag
        f.StartPosition = FormStartPosition.CenterScreen
        f.BackColor = Drawing.Color.Purple
        f.TransparencyKey = Drawing.Color.Purple
        f.Opacity = 90
        f.AllowTransparency = True
        f.FormBorderStyle = FormBorderStyle.None
        f.Size = Me.Size
        f.Controls.Add(Me)
        f.Show()
        f.TopMost = True
    End Sub

    Sub Fill(ByVal dataRow As DataRow)
        lblNamaPegawai.Text = dataRow("nama")
        lblAlamat.Text = dataRow("alamat")
    End Sub


End Class
