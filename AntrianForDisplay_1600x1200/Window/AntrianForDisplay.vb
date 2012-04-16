Imports SwdevIUIDatabase
Imports SwdevIUICore

Public Class AntrianForDisplay
    Dim antrian1 As Integer = 0
    Dim antrian2 As Integer = 0
    Dim antrian3 As Integer = 0
    Dim antrian4 As Integer = 0
    Private Sub Antrian_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            If MsgBox("Tutup antrian?", MsgBoxStyle.YesNo, "PassBandara") = MsgBoxResult.Yes Then
                Close()


            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F1 Then
            antrian1 = antrian1 + 1
            lblAntrianPendaftaran.Text = antrian1
        ElseIf e.KeyCode = Windows.Forms.Keys.F2 Then
            antrian2 = antrian2 + 1
            lblAntrianPemberkasan.Text = antrian2
        ElseIf e.KeyCode = Windows.Forms.Keys.F3 Then
            antrian3 = antrian3 + 1
            lblAntrianPembayaran.Text = antrian3
        ElseIf e.KeyCode = Windows.Forms.Keys.F12 Then
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
            Timer2_Tick(Nothing, Nothing)
            Timer2.Enabled = False
        ElseIf e.KeyCode = Windows.Forms.Keys.F11 Then
            DialogDatabaseSettings.ShowDialog()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToString("dd-MM-yyyy   HH:MM:ss")
    End Sub

    Private Sub Antrian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.dbname = My.Settings.dbname
        Session.dbhost = My.Settings.dbhost
        Session.dbuser = My.Settings.dbuser
        Session.dbpassword = My.Settings.dbpassword
        Session.dbport = My.Settings.dbport
        Timer1_Tick(Nothing, Nothing)
        'Timer2_Tick(Nothing, Nothing)
        Timer2.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim jenis_antrian As String
        Dim total_antrian As Integer
        Dim current_antrian As Integer
        Dim dtAntrian As DataTable = New DataTable

        jenis_antrian = "pemberkasan"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        If dtAntrian.Rows.Count = 0 Then Return

        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblAntrianPemberkasan.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)

        jenis_antrian = "foto"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblAntrianFoto.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)

        jenis_antrian = "pembayaran"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblAntrianPembayaran.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)

        jenis_antrian = "pendaftaran"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblAntrianPendaftaran.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)


        dtAntrian.Dispose()
    End Sub
End Class