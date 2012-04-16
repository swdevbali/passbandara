Imports System.Windows.Forms
Imports SwdevIUICore
Imports SwdevIUIDatabase

Public Class DialogDatabaseSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnTestKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnTestKoneksi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestKoneksi.Click


        Session.dbhost = txtHost.Text
        Session.dbport = txtPort.Text
        Session.dbuser = txtUser.Text
        Session.dbpassword = txtPassword.Text
        Session.dbname = txtDatabase.Text

        My.Settings.dbhost = txtHost.Text
        My.Settings.dbname = txtDatabase.Text
        My.Settings.dbpassword = txtPassword.Text
        My.Settings.dbport = txtPort.Text
        My.Settings.dbuser = txtUser.Text
        My.Settings.Save()

        'Utils.init(My.Settings.dbname, My.Settings.dbhost, My.Settings.dbuser, My.Settings.dbpassword, My.Settings.dbport)
        If Utils.isConnected() Then
            MessageBox.Show("OK, connected to database " & Session.dbname & " at " & Session.dbhost)
        Else
            MessageBox.Show("Unable to established connection to database " & Session.dbname & " at " & Session.dbhost)
        End If
    End Sub

    Private Sub DialogDatabaseSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtHost.Text = My.Settings.dbhost
        txtDatabase.Text = My.Settings.dbname
        txtPassword.Text = My.Settings.dbpassword
        txtPort.Text = My.Settings.dbport
        txtUser.Text = My.Settings.dbuser

    End Sub
End Class
