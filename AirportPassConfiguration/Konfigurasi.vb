
Imports SwdevIUICore

Public Class Konfigurasi
    Private Sub Konfigurasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Session.applicationName = "Airport Pass Management System"
        Session.loadDatabaseConfigurationFromRegistry()
        txtServerBerkas.Text = UtilsCore.readFromReg("Server", "ServerBerkas", "\\192.168.10.1\berkasbandara")
        Dim statusAutoUpdate As String = UtilsCore.readFromReg("AutoUpdate", "Status", "Slave")
        If statusAutoUpdate = "master" Then
            optMaster.Checked = True
        Else
            optSlave.Checked = True
        End If
        txtAutoUpdatePath.Text = UtilsCore.readFromReg("AutoUpdate", "AutoUpdateServer", "\\192.168.10.1")
        DatabaseSettingsPage1.prepareDisplay()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        DatabaseSettingsPage1.saveDatabaseSetting()
        UtilsCore.saveToReg("Server", "ServerBerkas", txtServerBerkas.Text)
        Dim statusAutoUpdate As String
        If optMaster.Checked Then
            statusAutoUpdate = "master"
        Else
            statusAutoUpdate = "slave"
        End If
        UtilsCore.saveToReg("AutoUpdate", "AutoUpdateServer", txtAutoUpdatePath.Text)
        UtilsCore.saveToReg("AutoUpdate", "Status", statusAutoUpdate)
        MessageBox.Show("Pengaturan sudah disimpan")
    End Sub
End Class