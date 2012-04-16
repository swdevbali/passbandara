Imports SwdevIUICore

Public Class ReportGallery
    Inherits PageTemplate

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        pnlKlien.Controls.Clear()
        Pages.Item("settingLaporanKinerja").Dock = Windows.Forms.DockStyle.Fill
        Pages.Item("settingLaporanKinerja").Refresh()
        pnlKlien.Controls.Add(Pages.Item("settingLaporanKinerja"))
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        pnlKlien.Controls.Clear()
        Pages.Item("settingLaporanKinerja").Dock = Windows.Forms.DockStyle.Fill
        Pages.Item("settingLaporanKinerja").Refresh()
        pnlKlien.Controls.Add(Pages.Item("settingLaporanPNBP"))
    End Sub

    Private Sub ReportGallery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SideBarPanelItem1.Expanded = True
    End Sub
End Class
