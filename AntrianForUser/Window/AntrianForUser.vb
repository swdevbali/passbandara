
Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms

Public Class AntrianForUser
    Public iCurrentFoto As Integer = 0
    Public iCurrentPemberkasan As Integer = 0
    Public iCurrentPembayaran As Integer = 0
    Public iCurrentPendaftaran As Integer = 0

    Dim sPath As String
    Private Sub AntrianForUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            'If getActivationPassword("penutupan antrian") = False Then Exit Sub
            If MsgBox("Apakah antrian ini akan ditutup?", MsgBoxStyle.YesNo, "PassBandara") = MsgBoxResult.Yes Then
                Close()
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F9 Then
            'If getActivationPassword("start/stop antrian") = False Then Exit Sub
            Dim dt As New DataTable
            Utils.executeSP("proc_antrian", New Object() {"select_status", -1}, dt)
            If dt.Rows(0).Item("status_antrian") = "Run" Then
                If MessageBox.Show("Semua antrian akan di-pause. Anda yakin?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Utils.exec_SP("proc_antrian", New Object() {"pause", -1})
                End If
            Else
                If MessageBox.Show("Semua antrian akan di-run. Anda yakin?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Utils.exec_SP("proc_antrian", New Object() {"run", -1})
                End If
            End If


        ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
            'If getActivationPassword("memulai proses antrian") = False Then Exit Sub
            'mulai proses
            'ambil nilai awal dari database. kalau direset operator, baru back to 0
            Dim dt As New DataTable
            'If dt.Rows.Count = 0 Then Return
            Utils.executeSP("proc_antrian", New Object() {"select_pemberkasan", 0}, dt)
            iCurrentPemberkasan = dt.Rows(0).Item("tot_pemberkasan")

            Utils.executeSP("proc_antrian", New Object() {"select_foto", 0}, dt)
            iCurrentFoto = dt.Rows(0).Item("tot_foto")

            Utils.executeSP("proc_antrian", New Object() {"select_pembayaran", 0}, dt)
            iCurrentPembayaran = dt.Rows(0).Item("tot_pembayaran")

            Utils.executeSP("proc_antrian", New Object() {"select_pendaftaran", 0}, dt)
            iCurrentPendaftaran = dt.Rows(0).Item("tot_pendaftaran")
            'updateDisplay()

            Timer2_Tick(Nothing, Nothing)
            Timer2.Enabled = True
        ElseIf e.KeyCode = Windows.Forms.Keys.F12 Then
            'If getActivationPassword("memunculkan titel bar antrian") = False Then Exit Sub
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F11 Then
            'If getActivationPassword("setting koneksi") = False Then Exit Sub
            DialogDatabaseSettings.ShowDialog()

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
        Session.StartupPath = Application.StartupPath()
        Timer1_Tick(Nothing, Nothing)
        sPath = Session.StartupPath & "\Reports\Antrian.lbx"

    End Sub
    Public Sub DoPrint(ByVal antrian As String, ByVal judulAntrian As String)


        Dim objDoc As bpac.Document
        objDoc = CreateObject("bpac.Document")

        If (objDoc.Open(sPath) <> False) Then
            objDoc.GetObject("judulAntrian").Text = judulAntrian
            objDoc.GetObject("objName").Text = antrian
            objDoc.GetObject("objCompany").Text = Now.ToString("dd/MM/yyyy      hh:mm")

            'objDoc.SetMediaByName(objDoc.Printer.GetMediaName, True)
            objDoc.StartPrint("", bpac.PrintOptionConstants.bpoDefault)
            objDoc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault)
            objDoc.EndPrint()
            objDoc.Close()
        End If
    End Sub
    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click
        Timer2.Enabled = False
        Dim dt As New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_status", -1}, dt)
        If dt.Rows(0).Item("status_antrian") = "Pause" Then
            MessageBox.Show("Maaf, antrian sedang non aktif. Silahkan coba beberapa saat lagi", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'If MsgBox("Apakah Anda akan mengambil Antrian untuk bagian Foto?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
        If iCurrentFoto > 999 Then
            iCurrentFoto = 1
        Else
            iCurrentFoto = iCurrentFoto + 1
        End If
        Utils.exec_SP("proc_antrian", New Object() {"update_total_foto", iCurrentFoto})

        updateDisplay()
        DoPrint("F00" & iCurrentFoto, "Antrian Foto")
        'End If
        Timer2.Enabled = True





    End Sub
    Sub updateDisplay()
        Dim jenis_antrian As String
        Dim total_antrian As Integer
        Dim current_antrian As Integer
        Dim dtAntrian As DataTable = New DataTable

        jenis_antrian = "pemberkasan"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)

        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblCurrentPemberkasan.Text = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        'iCurrentPemberkasan = current_antrian

        jenis_antrian = "foto"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblCurrentFoto.Text = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        'iCurrentFoto = current_antrian

        jenis_antrian = "pembayaran"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblCurrentPembayaran.Text = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        'iCurrentPembayaran = current_antrian

        jenis_antrian = "pendaftaran"
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, -1}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblCurrentPendaftaran.Text = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        'iCurrentPendaftaran = current_antrian

    End Sub

    Private Sub btnPemberkasan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPemberkasan.Click
        Timer2.Enabled = False
        Dim dt As New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_status", -1}, dt)
        If dt.Rows(0).Item("status_antrian") = "Pause" Then
            MessageBox.Show("Maaf, antrian sedang non aktif. Silahkan coba beberapa saat lagi", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'If MsgBox("Apakah Anda akan mengambil Antrian untuk bagian pemberkasan?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
        If iCurrentPemberkasan > 999 Then
            iCurrentPemberkasan = 1
        Else
            iCurrentPemberkasan = iCurrentPemberkasan + 1
        End If
        Utils.exec_SP("proc_antrian", New Object() {"update_total_pemberkasan", iCurrentPemberkasan})
        updateDisplay()
        DoPrint("P00" & iCurrentPemberkasan, "Antrian Pemberkasan")
        DoPrint("P00" & iCurrentPemberkasan, "Antrian Pemberkasan")
        ' End If
        Timer2.Enabled = True
    End Sub

    Private Sub btnPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPembayaran.Click
        Timer2.Enabled = False
        Dim dt As New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_status", -1}, dt)
        If dt.Rows(0).Item("status_antrian") = "Pause" Then
            MessageBox.Show("Maaf, antrian sedang non aktif. Silahkan coba beberapa saat lagi", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'If MsgBox("Apakah Anda akan mengambil Antrian untuk bagian pembayaran?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
        If iCurrentPembayaran > 999 Then
            iCurrentPembayaran = 1
        Else
            iCurrentPembayaran = iCurrentPembayaran + 1
        End If
        Utils.exec_SP("proc_antrian", New Object() {"update_total_pembayaran", iCurrentPembayaran})
        updateDisplay()
        DoPrint("K00" & iCurrentPembayaran, "Antrian Pembayaran")
        ' End If
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        updateDisplay()
    End Sub

    Private Sub btnPendaftaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendaftaran.Click
        Timer2.Enabled = False
        Dim dt As New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_status", -1}, dt)
        If dt.Rows(0).Item("status_antrian") = "Pause" Then
            MessageBox.Show("Maaf, antrian sedang non aktif. Silahkan coba beberapa saat lagi", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'If MsgBox("Apakah Anda akan mengambil Antrian untuk bagian pemberkasan?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
        If iCurrentPendaftaran > 999 Then
            iCurrentPendaftaran = 1
        Else
            iCurrentPendaftaran = iCurrentPendaftaran + 1
        End If
        Utils.exec_SP("proc_antrian", New Object() {"update_total_pendaftaran", iCurrentPendaftaran})
        updateDisplay()
        DoPrint("P00" & iCurrentPendaftaran, "Antrian Pendaftaran")
        DoPrint("P00" & iCurrentPendaftaran, "Antrian Pendaftaran")
        ' End If
        Timer2.Enabled = True
    End Sub

    Private Function getActivationPassword(ByVal fungsi As String) As Boolean
        Dim result As String = InputBox("Masukkan Password aktivasi fungsi " & fungsi, "Airport Pass", , )
        If result = "passbandara" Then Return True
        Return False
    End Function

End Class