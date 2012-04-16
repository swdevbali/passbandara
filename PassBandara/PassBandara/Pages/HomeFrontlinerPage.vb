Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms

Public Class HomeFrontlinerPage
    Inherits PageTemplate
    Private Sub linkLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MainWindow.logout()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        lvPageActivities = lvAdministratorActivities
        'lvPageActivities.View = Windows.Forms.View.Tile

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

    Private Sub linkLogout_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLogout.LinkClicked
        MainWindow.logout()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindow.logout()
    End Sub

    Private Sub HomeFrontlinerPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboLvStyle.SelectedIndex = 3
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
End Class
