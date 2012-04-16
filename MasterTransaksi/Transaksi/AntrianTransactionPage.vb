Imports SwdevIUICore
Imports SwdevIUIDatabase

Public Class AntrianTransactionPage
    Inherits PageTemplate

    Dim total_antrian As Integer
    Private Sub cboAntrian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAntrian.SelectedIndexChanged
        Dim jenis_antrian As String = cboAntrian.Text.ToLower()
        Dim dtAntrian As DataTable
        dtAntrian = New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, Nothing}, dtAntrian)
        lblTotalAntrian.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian) & "/" & dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        updateDisplay()
        dtAntrian.Dispose()
    End Sub
    Dim suaraTerkini As String
    Private Sub btnProsesAntrian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProsesAntrian.Click
        Dim jenis_antrian As String = cboAntrian.Text.ToLower
        Utils.exec_SP("proc_antrian", New Object() {"proses_antrian_" & jenis_antrian, Nothing})
        UpdateDisplay()

        'the sound
        Me.AxWindowsMediaPlayer1.currentPlaylist.clear()

        Dim antriansuara As String = ""
        Dim loket As String = ""


        If cboAntrian.SelectedIndex = 0 Then
            antriansuara = "antrianfoto"
            loket = "MenujuKeloketFoto"
        ElseIf cboAntrian.SelectedIndex = 1 Then
            antriansuara = "antrianberkas"
            loket = "MenujuKeloketBerkas"
        ElseIf cboAntrian.SelectedIndex = 2 Then
            antriansuara = "antriankasir"
            loket = "MenujuKeloketKasir"
        Else
            antriansuara = "antrianpendaftaran"
            loket = "MenujuKeloketPendaftaran"
        End If
        suaraTerkini = " " & antriansuara & " " + Terbilang(current_antrian) + " " & loket & " "
        'Label3.Text = tes
        play(suaraTerkini)

    End Sub
    Dim current_antrian As Integer
    Sub updateDisplay()
        Dim jenis_antrian As String = cboAntrian.Text.ToLower
        Dim total_antrian As Integer

        If jenis_antrian = "" Then Return
        Dim dtAntrian As DataTable = New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, Nothing}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblTotalAntrian.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian) & "/" & dtAntrian.Rows(0).Item("tot_" & jenis_antrian)


        If current_antrian < total_antrian Then
            btnProsesAntrian.Enabled = True
        Else
            btnProsesAntrian.Enabled = False
        End If

        If current_antrian = 0 Then
            btnBatalkanProsesAntrian.Enabled = False
        End If

        dtAntrian.Dispose()

    End Sub

    Private Sub btnBatalkanProsesAntrian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalkanProsesAntrian.Click
        Dim jenis_antrian As String = cboAntrian.Text.ToLower
        Dim total_antrian As Integer
        Dim current_antrian As Integer

        Dim dtAntrian As DataTable = New DataTable
        Utils.executeSP("proc_antrian", New Object() {"select_" & jenis_antrian, Nothing}, dtAntrian)
        total_antrian = dtAntrian.Rows(0).Item("tot_" & jenis_antrian)
        current_antrian = dtAntrian.Rows(0).Item("cur_" & jenis_antrian)
        lblTotalAntrian.Text = dtAntrian.Rows(0).Item("cur_" & jenis_antrian) & "/" & dtAntrian.Rows(0).Item("tot_" & jenis_antrian)

        Utils.exec_SP("proc_antrian", New Object() {"batalkan_" & jenis_antrian, Nothing})
        updateDisplay()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        updateDisplay()
    End Sub

    Private Sub btnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitialize.Click
        If MsgBox("Antrian akan direset dari 0. Akan melanjutkan?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
            Dim jenis_antrian As String = cboAntrian.Text.ToLower
            Utils.exec_SP("proc_antrian", New Object() {"reset_" & jenis_antrian, Nothing})
            updateDisplay()
        End If
    End Sub
    Private Function BikinMedia(ByVal nFile As String) As Object

        ' Dim song = Me.AxWindowsMediaPlayer1.newMedia("C:\audio\tiga.wav") ' + Me.AxWindowsMediaPlayer1.newMedia("C:\audio\" & nFile.ToLower & ".wav")
        Dim song = Me.AxWindowsMediaPlayer1.newMedia(Session.StartupPath & "\AntrianSuara\" & nFile.ToLower & ".wav")

        Return song
    End Function

    Private Function Terbilang(ByVal i As Integer) As String
        Dim angka() As String = {"Nol", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", _
        "Delapan", "Sembilan", "Sepuluh", "Sebelas"}

        Dim hasil As String = " "
        Select Case i
            Case 1 To 11
                hasil &= angka(i)
            Case 12 To 19
                hasil &= angka(i Mod 10) & " Belas"
            Case 20 To 99
                hasil &= Terbilang(Int(i / 10)) & " Puluh " & Terbilang(i Mod 10)
            Case 100 To 199
                hasil &= "Seratus " & Terbilang(i Mod 100)
            Case 200 To 999
                hasil &= Terbilang(Int(i / 100)) & " Ratus " & Terbilang(i Mod 100)
        End Select

        Return hasil.Trim
    End Function
    Private Sub AntrianTransactionPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AxWindowsMediaPlayer1.settings.autoStart = False
        Me.AxWindowsMediaPlayer1.Hide()
        OnEnterView()
    End Sub
    Public Overrides Sub OnEnterView()
        MyBase.OnEnterView()

        If Session.kodeRole = 23 Then
            cboAntrian.SelectedIndex = 0
            lblNamaAntrian.Text = "Total Antrian Foto"
        ElseIf Session.kodeRole = 10 Then
            cboAntrian.SelectedIndex = 1
            lblNamaAntrian.Text = "Total Antrian Berkas"
        ElseIf Session.kodeRole = 9 Then
            cboAntrian.SelectedIndex = 2
            lblNamaAntrian.Text = "Total Antrian Kasir"
        ElseIf Session.kodeRole = 2 Then
            cboAntrian.SelectedIndex = 3
            lblNamaAntrian.Text = "Total Antrian Pendaftaran"
        End If
    End Sub
    Private Sub btnPanggilKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanggilKembali.Click
        play(suaraTerkini)
    End Sub

    Private Sub play(ByVal suaraTerkini As String)
        Dim arr() As String = suaraTerkini.Split(" ") 'Terbilang(TextBox1.Text).Split(" ")
        For Each value As String In arr
            Dim song = BikinMedia(value)
            Me.AxWindowsMediaPlayer1.currentPlaylist.appendItem(song)
            'TextBox2.Text = tes
        Next
        Me.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

End Class
