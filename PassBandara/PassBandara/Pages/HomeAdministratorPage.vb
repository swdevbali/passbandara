Imports System.Windows.Forms
Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Drawing

Public Class HomeAdministratorPage
    Inherits PageTemplate

    Private Sub linkPengguna_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MainWindow.enterView(Pages.Item("manajemenPengguna"))
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lvPageActivities = lvAdministratorActivities
        lvPageActivities.View = Windows.Forms.View.Tile

        'Dim gr As Graphics = Me.CreateGraphics
        'MsgBox(gr.DpiX & " - " & gr.DpiY)

    End Sub

    Private Sub cboLvStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLvStyle.SelectedIndexChanged
        Select Case cboLvStyle.SelectedIndex
            Case 0
                lvPageActivities.View = Windows.Forms.View.SmallIcon
            Case 1
                lvPageActivities.View = Windows.Forms.View.LargeIcon

            Case 2
                lvPageActivities.View = Windows.Forms.View.Details

            Case 3
                lvPageActivities.View = Windows.Forms.View.Tile
        End Select
    End Sub

    Private Sub linkLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLogout.LinkClicked
        MainWindow.logout()
    End Sub

    Private Sub linkAntrian_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAntrianForDisplay.LinkClicked
        'AntrianForDisplay.Show()
        Diagnostics.Process.Start(Application.StartupPath & "\AntrianForDisplay.exe")
    End Sub

    Private Sub linkAntrianUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAntrianUser.LinkClicked
        'AntrianForUser.Show()
        Diagnostics.Process.Start(Application.StartupPath & "\AntrianForUser.exe")
    End Sub

    Private Sub linkAntrianPopup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAntrianPopup.LinkClicked
        Dim FormEntry As PageTemplate = Pages.Item("antrianTransactionPage")
        Dim popUp As PopupWindow = New PopupWindow
        popUp.clearControl()
        popUp.Add(FormEntry)
        Dim newsize As Drawing.Size = Drawing.Size.Add(FormEntry.Size, New Drawing.Size(12, 20))
        If newsize.Width < 500 Then newsize.Width = 520
        FormEntry.Dock = DockStyle.Fill
        popUp.Text = "Pemanggilan Antrian"
        popUp.Size = newsize
        popUp.TopMost = True
        popUp.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindow.logout()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'AntrianForDisplay.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim FormEntry As PageTemplate = Pages.Item("antrianTransactionPage")
        Dim popUp As PopupWindow = New PopupWindow
        popUp.clearControl()
        popUp.Add(FormEntry)
        Dim newsize As Drawing.Size = Drawing.Size.Add(FormEntry.Size, New Drawing.Size(12, 20))
        If newsize.Width < 500 Then newsize.Width = 520
        FormEntry.Dock = DockStyle.Fill
        FormEntry.OnEnterView()
        popUp.Text = "Pemanggilan Antrian"
        popUp.Size = newsize
        popUp.TopMost = True
        popUp.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Diagnostics.Process.Start(Application.StartupPath & "\AntrianForUser.exe")
    End Sub

    Private Sub HomeAdministratorPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboLvStyle.SelectedIndex = 3
    End Sub
End Class
