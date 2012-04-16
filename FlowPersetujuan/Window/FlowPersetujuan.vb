
Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports TransaksiModule
Public Class FlowPersetujuan

    Private Sub AntrianForUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            If MsgBox("Apakah Flow Persetujuan ini akan ditutup?", MsgBoxStyle.YesNo, "PassBandara") = MsgBoxResult.Yes Then
                Close()
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
            Timer2.Enabled = True
        ElseIf e.KeyCode = Windows.Forms.Keys.F12 Then
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F11 Then
            DialogDatabaseSettings.ShowDialog()
            PersetujuanFlowDisplayPage1.startWorking()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToString("dd-MM-yyyy          hh:mm:ss")
    End Sub

    Private Sub AntrianForUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.dbname = My.Settings.dbname
        Session.dbhost = My.Settings.dbhost
        Session.dbuser = My.Settings.dbuser
        Session.dbpassword = My.Settings.dbpassword
        Session.dbport = My.Settings.dbport
        Session.activeView = PersetujuanFlowDisplayPage1
        'PersetujuanFlowDisplayPage1.startWorking()
    End Sub

End Class