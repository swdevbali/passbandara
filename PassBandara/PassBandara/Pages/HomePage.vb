Imports SwdevIUIcore

Public Class HomePage
    Inherits PageTemplate

    Private Sub linkSettings_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSettings.LinkClicked
        MainWindow.enterView(Pages.Item("databaseSetting"))
    End Sub

    Private Sub linkLogin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        MainWindow.enterView(Pages.Item("login"))
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MainWindow.enterView(Pages.Item("masterPetugas"))
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MainWindow.enterView(Pages.Item("transaksiRegistrasi"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindow.enterView(Pages.Item("login"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MainWindow.enterView(Pages.Item("databaseSetting"))
    End Sub
End Class
