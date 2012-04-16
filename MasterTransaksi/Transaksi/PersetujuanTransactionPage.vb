Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Drawing
Imports System.Windows.Forms
Imports RootSection
Imports DevComponents.DotNetBar
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class PersetujuanTransactionPage
    Inherits PageTemplate
    Protected hashCheckedRowIndex As New Hashtable
    Friend suppressConfirmation As Boolean
    Private Property persetujuan_select As String

    Public Overrides Sub Refresh()
        MyBase.Refresh()


        Dim dt As New DataTable
        Utils.executeSP("proc_progress_by_jabatan", New Object() {Session.kodeRole}, dt)
        dt.Dispose()

        sidebarProgress.Panels.Clear()
        For Each r As DataRow In dt.Rows
            Dim panelItem As New SideBarPanelItem
            panelItem.WordWrap = True
            panelItem.Text = r("nama_progress")
            panelItem.Tag = r("idtb_progress")
            AddHandler panelItem.ExpandChange, AddressOf onExpandPanel
            sidebarProgress.Panels.Add(panelItem)
            'todo the bundle
            Dim dt2 As New DataTable
            Utils.executeSP("proc_bundle_by_progress", New Object() {r("idtb_progress")}, dt2)
            Dim count As Integer = 0
            For Each r2 As DataRow In dt2.Rows
                Dim btn2 As New ButtonItem
                btn2.AccessibleRole = Windows.Forms.AccessibleRole.RadioButton
                btn2.AutoCheckOnClick = True
                btn2.OptionGroup = r("idtb_progress")
                AddHandler btn2.CheckedChanged, AddressOf checkPermohonan
                btn2.Text = r2("nama_instansi") & " - " & r2("nomor_bundle")
                btn2.Tag = r2("nomor_bundle")
                panelItem.SubItems.Add(btn2)
                count = count + 1
            Next
            dt2.Dispose()
            panelItem.Text = panelItem.Text & " (" & count & ")"
        Next

        sidebarProgress.Panels(0).Expanded = True
        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle")
        refreshDataGrid()

        sidebarProgress.Refresh()
    End Sub
    Dim cbHeader As DataGridViewColumnHeaderCheckBoxCell
    Overrides Sub refreshDataGrid()
        If cboPilihBundle.SelectedValue Is Nothing Then
            dgvList.DataSource = Nothing
            Return
        End If

        Dim dt As New DataTable

        'TOFIX: mungkin bs buat proc yg argumennya jabatan, ntar di IF disana ;(
        If Session.kodeRole = Jabatan.FRONTLINER Then
            persetujuan_select = "select_cek_kuota_dan_pengambilan_blanko"
        ElseIf Session.kodeRole = Jabatan.SECONDLINER Then
            persetujuan_select = "select_kelengkapan_berkas"
        ElseIf Session.kodeRole = Jabatan.THIRDLINER Then
            persetujuan_select = "select_petugas_thirdliner"
        ElseIf Session.kodeRole = Jabatan.KASUBAG_PERENCANAAN_DAN_KEUANGAN Then
            persetujuan_select = "select_kasubag_perencanaan_dan_keuangan"
        ElseIf Session.kodeRole = Jabatan.KABAG_TATA_USAHA Then
            persetujuan_select = "select_kasubag_tu"
        ElseIf Session.kodeRole = Jabatan.KEPALA_OTORITAS_BANDARA Then
            persetujuan_select = "select_kepala_kantor"
        ElseIf Session.kodeRole = Jabatan.KASIR Then
            persetujuan_select = "select_kasir"
        ElseIf Session.kodeRole = Jabatan.FOTO_DAN_PENCETAKAN Then
            persetujuan_select = "select_foto_dan_pencetakan"
        End If
        hashCheckedRowIndex.Clear()
        dgvList.Columns.Clear()
        dgvList.DataSource = Nothing
        Utils.executeSP("proc_persetujuan_by_bundle", New Object() {persetujuan_select, cboPilihBundle.SelectedValue}, dt)
        dgvList.DataSource = dt
        dgvList.Columns(0).Visible = False
        dgvList.Columns(1).Visible = False
        dgvList.Columns(dgvList.Columns.Count - 1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

        If dt.Rows.Count > 0 Then
            'add the checkbox column
            Dim colCB As New DataGridViewCheckBoxColumn 'colCB = new DataGridViewCheckBoxColumn();
            'cbHeader = new DatagridViewCheckBoxHeaderCell();
            cbHeader = New DataGridViewColumnHeaderCheckBoxCell
            AddHandler cbHeader.BeginToCheckColumnHeader, AddressOf DoBeginToCheckColumnHeader
            AddHandler cbHeader.CheckBoxCellChangeValue, AddressOf DoCheckBoxCellChangeValue

            colCB.HeaderCell = cbHeader
            dgvList.Columns.Insert(0, colCB)
            dgvList.Columns(0).ReadOnly = False
            dgvList.ReadOnly = False
        End If
    End Sub

    'Private Sub PersetujuanTransactionPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'PermohonanExtendedPanel1.Dock = DockStyle.Fill
    '    PermohonanExtendedPanel1.dgvList = Me.dgvList
    '    PermohonanExtendedPanel1.fromPermohonan = False

    '    'pnlExtended.Controls.Add(p)
    'End Sub

    Public Sub SetujuiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim isDisetujui As Boolean
        If Not suppressConfirmation Then
            Dim result As MsgBoxResult = MessageBoxEx.Show("Proses Bundle Permohonan ini?" & vbCrLf & "Anda tidak bisa membatalkan proses yang sudah dilakukan", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = MsgBoxResult.No Or result = MsgBoxResult.No Then Return
        End If

        Dim dt As New DataTable
        For Each dgvr As DataGridViewRow In dgvList.Rows
            Dim kode_permohonan_progress As String = IIf(IsDBNull(dgvr.Cells(1).Value), Nothing, dgvr.Cells(1).Value)
            Dim kode_permohonan As String = IIf(IsDBNull(dgvr.Cells(2).Value), Nothing, dgvr.Cells(2).Value)
            Dim tanggal As String = Now.ToString("yyyy-MM-dd")
            Utils.executeSP("proc_permohonan", New Object() {"selectsingle", kode_permohonan, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, dt)

            If hashCheckedRowIndex.ContainsKey(dgvr.Cells(0).RowIndex) Then isDisetujui = True Else isDisetujui = False

            If isDisetujui Then
                If kode_permohonan_progress Is Nothing Then 'ini adalah langkah awal  : pendaftaran. Diarahhkan langsung ke KASUBAG u/ persetujuan
                    Utils.exec_SP("proc_persetujuan", New Object() {"mulai_persetujuan", 0, 0, 0, 0, kode_permohonan, 0})
                Else
                    Utils.exec_SP("proc_persetujuan", New Object() {"persetujuan", kode_permohonan_progress, tanggal, Session.username, "Diterima", 0, 0})
                    majukanPermohonanKeLangkahSelanjutnya(kode_permohonan_progress, kode_permohonan, dt)
                End If
            Else
                Dim keterangan As String = "Ditolak oleh " & Session.vusername & " pada " & Now.ToString("dd-MM-yyyy")
                Utils.exec_SP("proc_permohonan_permohonan_ditolak", New Object() {kode_permohonan, keterangan})
            End If
        Next
        dt.Dispose()


        Refresh()
        'refreshDataGrid()
        'End If
    End Sub
    Sub doCetakPengambilanBlanko()
        'pencetakan... 
        'Dim p As PermohonanTransactionPage = Pages.Item("permohonanTransactionPage")
        Dim REPORT_NAME As String = "rptPengambilanBlanko.rpt"
        Dim strReportPath As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim errmsg As String = ""

        strReportPath = Application.StartupPath & "\Reports\" & REPORT_NAME
        Try
            'If Utils.executeSP("proc_rptPembayaran", New Object() {cboPilihBundle.SelectedValue}, dt) Then
            'If dt IsNot Nothing Then
            Dim clsView As New clsReportPreview(strReportPath)
            AddHandler clsView.PopulateReport, AddressOf populateReportPengambilanBlanko
            clsView.ShowReport()
            ds.Dispose()
            'End If
            'End If


            Me.Cursor = Cursors.Default
            If errmsg <> "" Then
                MsgBox(errmsg)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub majukanPermohonanKeLangkahSelanjutnya(ByVal kode_permohonan_progress As String, ByVal kode_permohonan As String, ByVal dt As DataTable)
        Dim tanggal As String = Now.ToString("yyyy-MM-dd")


        Utils.executeSP("proc_permohonan", New Object() {"selectsingle", kode_permohonan, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0}, dt)
        Dim tahapProses As String = dt.Rows(0).Item("Tahap proses").ToString 'lihat next progress sekarang
        Dim status As String = dt.Rows(0).Item("Status Pemohon").ToString
        Dim idtb_instansi As String = dt.Rows(0).Item("idtb_instansi")

        'perhatikan, bahwa frontliner tidak memajukan langkah, tapi memulai langkah. Jadi dia tidak disini.., Begitu FL menginputkan data, langsung statusnya ke pengecekan kuota/pendaftaran.
        'ups, ada perubahan baru. Frontliner juga mengembalikan blanko
        If Session.kodeRole = Jabatan.FRONTLINER Then
            If dt.Rows(0).Item("idtb_next_progress") = Progress.PENGAMBILAN_BLANKO Then
                'print penerimaan blanko
                doCetakPengambilanBlanko()
                Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PENGECEKAN_KELENGKAPAN_BERKAS}) 'ke perencanaan dan keuangan step ke 2
            End If
        ElseIf Session.kodeRole = Jabatan.KEPALA_OTORITAS_BANDARA Then
            Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PEMBAYARAN}) 'ke kasir
        ElseIf Session.kodeRole = Jabatan.SECONDLINER Then 'persetjuan berkas
            'jika pemohon baru, majukan ke screening.
            If status.Equals("Baru") Or ((dt.Rows(0).Item("Wilayah Kerja Terakhir") <> "" And dt.Rows(0).Item("Wilayah Kerja") <> "") AndAlso dt.Rows(0).Item("Wilayah Kerja Terakhir") = dt.Rows(0).Item("Wilayah Kerja")) Then 'TODO better way
                'baru, screening
                Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.SCREENING_AND_SECURITY_AWARENESS}) 'ke screening.. oalah jan, sakjane podo ki karo sing mbiyen
            Else 'perpanjangan
                Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PERSETUJUAN_KASUBAG_VERIFIKASI_ADMINISTRASI}) 'ke perencanaan dan keuangan step ke 2
            End If
        ElseIf Session.kodeRole = Jabatan.THIRDLINER Then

            Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PERSETUJUAN_KASUBAG_VERIFIKASI_ADMINISTRASI}) 'baru, arahkan ke kasubag lagi
            'kalau sudah lewat 3rdliner, maka set id yg khusus 3rdliner ke null
            Utils.exec_SP("proc_permohonan_bundle_release_from_thirdliner", New Object() {kode_permohonan}) 'baru, arahkan ke kasubag lagi

        ElseIf Session.kodeRole = Jabatan.KASUBAG_PERENCANAAN_DAN_KEUANGAN Then
            'persetujuan kasubag ini ada 2, jika sekarang stepnya 4, kasubag u/ blanko, maka majukan ke step kelengkapan berkas
            If dt.Rows(0).Item("idtb_next_progress") = Progress.PERSETUJUAN_KASUBAG_PENGAMBILAN_BLANKO Then
                Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PENGAMBILAN_BLANKO}) 'ke kelengkapan berkas, diganti ke ngambil blanko dulu
            ElseIf dt.Rows(0).Item("idtb_next_progress") = Progress.PERSETUJUAN_KASUBAG_VERIFIKASI_ADMINISTRASI Then
                Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PERSETUJUAN_KABAG_TU}) 'ke TU
            End If
        ElseIf Session.kodeRole = Jabatan.KABAG_TATA_USAHA Then
            Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.PERSETUJUAN_KELAPA_OTORITAS}) 'ke persetujuan final ke kepala otoritas, perpanjangan 
        ElseIf Session.kodeRole = Jabatan.KASIR Then 'kasir
            Utils.exec_SP("proc_persetujuan", New Object() {"next_step", 0, tanggal, Nothing, "Diterima", kode_permohonan, Progress.FOTO_DAN_PENCETAKAN}) 'ke pencetakan
        ElseIf Session.kodeRole = Jabatan.FOTO_DAN_PENCETAKAN Then 'selesai di cetak
            Utils.exec_SP("proc_permohonan_permohonan_diterima", New Object() {kode_permohonan, idtb_instansi, 0})
        End If
        dt.Dispose()
    End Sub
    'Function aksiPersetujuan(ByVal aksi As String) As Boolean
    '    Dim kode_permohonan_progress As String = dgvList.CurrentRow.Cells(1).Value
    '    Dim kode_permohonan As String = dgvList.CurrentRow.Cells(2).Value
    '    Dim tanggal As String = Now.ToString("yyyy-MM-dd")
    '    If MsgBox("Apakah permohonan akan diloloskan untuk tahap ini?", MsgBoxStyle.YesNoCancel, "PassBandara") = MsgBoxResult.Yes Then
    '        Utils.exec_SP("proc_persetujuan", New Object() {"persetujuan", kode_permohonan_progress, tanggal, Session.username, aksi, 0, 0})
    '        'move to next step
    '        Return True
    '    Else
    '        'ditolak
    '        Utils.exec_SP("proc_permohonan_permohonan_ditolak", New Object() {kode_permohonan})
    '        Return False
    '    End If
    'End Function

    'Public Sub TolakToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TolakToolStripMenuItem.Click
    '    If dgvList.CurrentRow IsNot Nothing Then
    '        aksiPersetujuan("Ditolak")
    '        refreshDataGrid()
    '    End If
    'End Sub



    Public Shared Sub PemberkasanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'display pemberkasan u/ permohonan ini
        Dim pemberkasanEntry As PemberkasanTransactionPage = Pages.Item("pemberkasanTransactionPage")
        'pemberkasanEntry.
        Dim popUp As PopupWindow = New PopupWindow
        popUp.clearControl()
        popUp.Add(pemberkasanEntry)
        Dim newsize As Size = Drawing.Size.Add(pemberkasanEntry.Size, New Size(12, 20))
        If newsize.Width < 500 Then newsize.Width = 520
        pemberkasanEntry.Dock = DockStyle.Fill
        popUp.Text = Application.ProductName
        popUp.Size = newsize
        popUp.TopMost = False
        popUp.ShowDialog()
    End Sub


    Private Sub DoBeginToCheckColumnHeader()
        'Throw New NotImplementedException
        hashCheckedRowIndex.Clear()
    End Sub
    Private Sub DoCheckBoxCellChangeValue(ByVal e As DataGridViewCellEventArgs)

        If dgvList.Rows(e.RowIndex).Cells(0).Value Then
            hashCheckedRowIndex.Add(e.RowIndex, dgvList.Rows(e.RowIndex))
        Else
            hashCheckedRowIndex.Remove(e.RowIndex)
        End If
    End Sub
    Sub tolakPermohonan()

        Dim dt As New DataTable
        For Each dgvr As DataGridViewRow In dgvList.Rows
            Dim kode_permohonan_progress As String = IIf(IsDBNull(dgvr.Cells(1).Value), Nothing, dgvr.Cells(1).Value)
            Dim kode_permohonan As String = IIf(IsDBNull(dgvr.Cells(2).Value), Nothing, dgvr.Cells(2).Value)
            Dim tanggal As String = Now.ToString("yyyy-MM-dd")
            Utils.exec_SP("proc_permohonan", New Object() {"permohonan_ditolak", kode_permohonan, Nothing, Nothing, Nothing, 0, Nothing, Nothing, 0, Nothing, Nothing, Nothing, Nothing, 0})
        Next
        dt.Dispose()
    End Sub

    Private Sub dgvList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellContentClick
        If (e.ColumnIndex = 0) Then
            dgvList.Rows(e.RowIndex).Cells(0).Value = Not dgvList.Rows(e.RowIndex).Cells(0).Value
            hashCheckedRowIndex.Remove(e.RowIndex)

            If dgvList.Rows(e.RowIndex).Cells(0).Value Then
                hashCheckedRowIndex.Add(e.RowIndex, dgvList.Rows(e.RowIndex))

            End If

        End If


    End Sub

    Private Sub dgvList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvList.SelectionChanged
        If dgvList.CurrentRow IsNot Nothing Then

            If dgvList.Columns(0).CellType.Name <> "DataGridViewCheckBoxCell" Then Return
            Dim kode_permohonan_progress As String = IIf(IsDBNull(dgvList.CurrentRow.Cells(1).Value), Nothing, dgvList.CurrentRow.Cells(1).Value)
            Dim kode_permohonan As String = IIf(IsDBNull(dgvList.CurrentRow.Cells(2).Value), Nothing, dgvList.CurrentRow.Cells(2).Value)

            'If kode_permohonan_progress Is Nothing Then Return
            'cek tahap permohonan ini
            Dim dt As New DataTable
            Utils.executeSP("proc_permohonan", New Object() {"selectsingle", kode_permohonan, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, 0}, dt)
            Dim tahapProses As String = dt.Rows(0).Item("Tahap proses").ToString 'lihat next progress sekarang

            'If tahapProses.Equals("Pengecekan Kelengkapan Berkas") Then
            'PemberkasanToolStripMenuItem.Visible = True

            'Else
            '   PemberkasanToolStripMenuItem.Visible = False
            'End If


            dt.Dispose()
        End If
    End Sub

    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        refreshDataGrid()
    End Sub

    Sub centangSemua()
        ' cbHeader.Checked = True
        DoBeginToCheckColumnHeader()
        For Each r As DataGridViewRow In dgvList.Rows
            r.Cells(0).Value = True
            hashCheckedRowIndex.Add(r.Cells(0).RowIndex, dgvList.Rows(r.Cells(0).RowIndex))
        Next

    End Sub

    Sub kirimBundleKeLangkahSelanjutnya(ByVal nomorBundle As String)
        'tadi disini refresh()
        Refresh()
        'hashCheckedRowIndex.Clear()
        cboPilihBundle.Text = nomorBundle
        centangSemua()
        suppressConfirmation = True 'untuk menyetujui secara programming
        SetujuiToolStripMenuItem_Click(Nothing, Nothing)
        suppressConfirmation = False

    End Sub

    Private Sub checkPermohonan(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ButtonItem = sender
        If btn.Checked Then
            cboPilihBundle.Text = btn.Tag
        Else
            cboPilihBundle.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnKirimKe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimKe.Click
        SetujuiToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub onExpandPanel(ByVal sender As Object, ByVal e As EventArgs)
        Dim p As SideBarPanelItem = sender
        If p.Expanded Then
            'next step u/ progress d hardcode dulu aja y
            If p.Tag = Progress.PERSETUJUAN_KASUBAG_PENGAMBILAN_BLANKO Then
                btnKirimKe.Text = "Kirim ke Pengambilan Blanko di Frontliner"
            ElseIf p.Tag = Progress.PENGAMBILAN_BLANKO Then
                btnKirimKe.Text = "Kirim ke Pengecekan Kelengkapan berkas di Secondliner"
            ElseIf p.Tag = Progress.PENGECEKAN_KELENGKAPAN_BERKAS Then
                btnKirimKe.Text = "Kirim ke Proses Screening/Verifikasi Administrasi Kasubag Perencanaan dan Keuangan"
            ElseIf p.Tag = Progress.SCREENING_AND_SECURITY_AWARENESS Then
                btnKirimKe.Text = "Kirim ke Verifikasi Kasubag Perencanaan dan Keuangan"
            ElseIf p.Tag = Progress.PERSETUJUAN_KASUBAG_VERIFIKASI_ADMINISTRASI Then
                btnKirimKe.Text = "Kirim ke Kabag Tata Usaha"
            ElseIf p.Tag = Progress.PERSETUJUAN_KABAG_TU Then
                btnKirimKe.Text = "Kirim ke Kepala Kantor"
            ElseIf p.Tag = Progress.PERSETUJUAN_KELAPA_OTORITAS Then
                btnKirimKe.Text = "Kirim ke Kasir"
                'setelah ini, tidak pakai form persetujuan ini
            End If
        End If

    End Sub

    Private Sub populateReportPengambilanBlanko(ByRef CR As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim crParameterDiscreteValue As ParameterDiscreteValue
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldLocation As ParameterFieldDefinition
        Dim crParameterValues As ParameterValues

        crParameterFieldDefinitions = CR.DataDefinition.ParameterFields

        Dim dt As New DataTable
        Dim nama As String
        Utils.executeSP("proc_permohonan_bundle", New Object() {"selectsingle", cboPilihBundle.SelectedValue, 0, 0, 0, 0, 0, 0}, dt)

        nama = dt.Rows(0).Item("pengurus")
        crParameterFieldLocation = crParameterFieldDefinitions.Item("pengurus")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = nama
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim hari As String = "Pada hari ini " & Now.ToString("dddd") & ", Tanggal " & Now.ToString("dd-MM-yyyy") & ", Jam : " & Now.ToString("HH:MM") & " WIB" & vbCrLf & _
                             "Telah diterima berkas permohonan Pas Orang/Kendaraan, TIM* dengan data sbb :"
        crParameterFieldLocation = crParameterFieldDefinitions.Item("hari")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = hari
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim dt2 As New DataTable
        Utils.executeSP("proc_permohonan_count_by_bundle", New Object() {cboPilihBundle.SelectedValue}, dt2)
        Dim jumlah As String = dt2.Rows(0).Item(0)
        crParameterFieldLocation = crParameterFieldDefinitions.Item("jumlah")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = jumlah
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim instansi As String = dt.Rows(0).Item("nama_instansi")
        crParameterFieldLocation = crParameterFieldDefinitions.Item("instansi")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = instansi
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim handphone As String = dt.Rows(0).Item("handphone")
        crParameterFieldLocation = crParameterFieldDefinitions.Item("handphone")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = handphone
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim telepon_kantor As String = dt.Rows(0).Item("no_telp")
        crParameterFieldLocation = crParameterFieldDefinitions.Item("telepon_kantor")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = telepon_kantor
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim status_pas As String = "Perpanjangan / Baru*"
        crParameterFieldLocation = crParameterFieldDefinitions.Item("status_pas")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = status_pas
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        Dim petugas As String = Session.vusername
        crParameterFieldLocation = crParameterFieldDefinitions.Item("petugas")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = petugas
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

    End Sub

    
End Class
