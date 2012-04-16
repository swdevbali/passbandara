Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar

Public Class PembayaranPermohonan
    Inherits PageTemplate

    Dim total_uang As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    Dim totalUangValue As CrystalDecisions.Shared.ParameterDiscreteValue

    'Dim pengaturanAwal As PengaturanAwal
    'Dim frontlinerPermohonan As FrontlinerPermohonanPage
    Dim iLastPermohonanBundle As Integer = 0
    Dim suppressTabCreation As Boolean = False
    Private Sub checkPermohonan(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ButtonItem = sender
        If btn.Checked Then
            suppressTabCreation = True
            cboPilihBundle.Text = btn.Tag
            suppressTabCreation = False
        Else
            cboPilihBundle.SelectedIndex = 0
        End If

    End Sub
    Public Overrides Sub Refresh()

        MyBase.Refresh()
        If Not suppressTabCreation Then
            'ini dicopy paste dari persetujuan
            Dim dtProgress As New DataTable
            Utils.executeSP("proc_progress_by_jabatan", New Object() {Session.kodeRole}, dtProgress)
            dtProgress.Dispose()

            sidebarProgress.Panels.Clear()
            For Each r As DataRow In dtProgress.Rows
                Dim panelItem As New SideBarPanelItem
                panelItem.WordWrap = True
                panelItem.Text = r("nama_progress")
                panelItem.Tag = r("idtb_progress")
                'AddHandler panelItem.ExpandChange, AddressOf onExpandPanel
                sidebarProgress.Panels.Add(panelItem)
                'todo the bundle
                Dim dtProgress2 As New DataTable
                Utils.executeSP("proc_bundle_by_progress", New Object() {r("idtb_progress")}, dtProgress2)
                Dim count As Integer = 0
                For Each r2 As DataRow In dtProgress2.Rows
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
                dtProgress2.Dispose()
                panelItem.Text = panelItem.Text & " (" & count & ")"
            Next

            sidebarProgress.Panels(0).Expanded = True
            Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle")
            'refreshDataGrid()

            sidebarProgress.Refresh()
        End If
        
    End Sub
    Dim totalBiaya As Integer
    Sub doPembayaran()
        'pencetakan... 
        Dim REPORT_NAME As String = "rptPembayaran.rpt"
        Dim strReportPath As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim errmsg As String = ""

        strReportPath = Application.StartupPath & "\Reports\" & REPORT_NAME
        Try
            If Utils.executeSP("proc_rptPembayaran", New Object() {cboPilihBundle.SelectedValue}, dt) Then
                If dt IsNot Nothing Then
                    Dim clsView As New clsReportPreview(dt, strReportPath)
                    AddHandler clsView.PopulateReport, AddressOf populateReport
                    clsView.ShowReport()
                    ds.Dispose()
                End If
            End If


            Me.Cursor = Cursors.Default
            If errmsg <> "" Then
                MsgBox(errmsg)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub populateReport(ByRef CR As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim crParameterDiscreteValue As ParameterDiscreteValue
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldLocation As ParameterFieldDefinition
        Dim crParameterValues As ParameterValues

        crParameterFieldDefinitions = CR.DataDefinition.ParameterFields

        crParameterFieldLocation = crParameterFieldDefinitions.Item("total_uang")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = totalBiaya
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        crParameterFieldLocation = crParameterFieldDefinitions.Item("deskripsi")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = lblDeskripsiBiaya.Text
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        crParameterFieldLocation = crParameterFieldDefinitions.Item("nomor_kuitansi")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = cboPilihBundle.Text 'TODO mungkin mau yg lain
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
    End Sub

    Public Overrides Sub refreshDataGrid()
        MyBase.refreshDataGrid()
        'pengaturanAwal = Pages.Item("pengaturanAwal")
        'frontlinerPermohonan = Pages.Item("frontlinerPermohonanPage")
        Utils.fillComboBox(cboInstansi, "idtb_instansi", "nama_instansi", "tb_instansi", "--Pilih instansi baru--")
        'If iLastPermohonanBundle > 0 Then cboPilihBundle.SelectedIndex = iLastPermohonanBundle
        If cboPilihBundle.SelectedValue Is Nothing Then
            lblDeskripsiBiaya.Text = "--"
            lblJumlahPermohonan.Text = "--"
            lblJumlahPermohonanLolos.Text = "--"
            lblKategoriInstansi.Text = "--"
            lblNomorBundle.Text = "--"
            lblStatusPembayaran.Text = "--"
            lblTarifInstansi.Text = "--"
            dgvList.DataSource = Nothing
            Return
        End If

        'PengaturanAwal = Pages.Item("pengaturanAwal")
        Dim dt2 As New DataTable
        Utils.executeSP("proc_instansi_by_bundle", New Object() {cboPilihBundle.SelectedValue}, dt2)

        cboInstansi.Text = dt2.Rows(0).Item(0)
        dt2.Dispose()
        lblNomorBundle.Text = cboPilihBundle.Text  'PengaturanAwal.txtNomorBundle.Text

        Dim dt As New DataTable
        Utils.executeSP("proc_instansi_tarif", New Object() {"select", cboInstansi.SelectedValue, 0, 0}, dt)
        If dt.Rows.Count = 0 Then Return
        lblKategoriInstansi.Text = dt.Rows(0).Item("kategori")
        lblTarifInstansi.Text = dt.Rows(0).Item("harga")
        Dim tarifInstansi As Integer = dt.Rows(0).Item("harga")

        Utils.executeSP("proc_permohonan_jumlah_status", New Object() {cboPilihBundle.SelectedValue}, dt)

        Dim jumlah_diproses As Integer = 0
        Dim jumlah_diterima As Integer = 0
        Dim jumlah_ditolak As Integer = 0
        Dim jumlah_permohonan As Integer = 0

        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                If r.Item("status_permohonan") = "Diproses" Then
                    jumlah_diproses = r.Item("jumlah")
                ElseIf r.Item("status_permohonan") = "Diterima" Then
                    jumlah_diterima = r.Item("jumlah")
                ElseIf r.Item("status_permohonan") = "Ditolak" Then
                    jumlah_ditolak = r.Item("jumlah")
                End If
            Next
        End If
        jumlah_diterima = jumlah_diterima + jumlah_diproses  'ini karena diterima hanya setelah dicetak
        jumlah_permohonan = jumlah_diterima + jumlah_ditolak
        lblJumlahPermohonan.Text = jumlah_permohonan & " orang"
        lblJumlahPermohonanLolos.Text = jumlah_diterima & " orang"


        totalBiaya = jumlah_diterima * tarifInstansi
        lblDeskripsiBiaya.Text = jumlah_diterima & " x @ Rp. " & tarifInstansi & " = Rp. " & totalBiaya

        Utils.executeSP("proc_permohonan_bundle", New Object() {"selectsingle", cboPilihBundle.SelectedValue, 0, 0, 0, 0, 0, 0}, dt)
        lblStatusPembayaran.Text = dt.Rows(0).Item("status_pembayaran")

        dgvList.Columns.Clear()
        dgvList.DataSource = Nothing
        Utils.executeSP("proc_permohonan", New Object() {"select_for_kasir", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, cboPilihBundle.SelectedValue, Nothing, Nothing, Nothing, Nothing, 0}, dt)
        dgvList.DataSource = dt
        dgvList.Columns(0).Visible = False
        dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        iLastPermohonanBundle = cboPilihBundle.SelectedIndex
    End Sub
    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        refreshDataGrid()
    End Sub




    Private Sub btnPembayaran_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPembayaran.Click
        Dim status_pembayaran As String = lblStatusPembayaran.Text

        If status_pembayaran = "Belum dibayar" Then
            If MessageBox.Show("Permohonan ini belum dibayar. Apakah Anda akan mencatatkan permohonan ini sebagai sudah terbayar dan mencetak kuitansinya?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                Utils.exec_SP("proc_permohonan_bundle_sudah_dibayar", New Object() {cboPilihBundle.SelectedValue})
                doPembayaran()

                'majukan flow persetujuannya TODO TODO TODO
                Dim p As PersetujuanTransactionPage
                p = Pages.Item("persetujuanTransactionPage")
                p.kirimBundleKeLangkahSelanjutnya(cboPilihBundle.Text)
                Cursor = Cursors.Default
            End If
        Else
            'ini akan tidak ada, karena menggunkan sidebarProgress
            If MessageBox.Show("Permohonan ini sudah dibayar. Apakah Anda akan mencetak kembali kuitansinya?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                doPembayaran()
                Dim p As PersetujuanTransactionPage
                p = Pages.Item("persetujuanTransactionPage")
                p.kirimBundleKeLangkahSelanjutnya(cboPilihBundle.Text)
                Cursor = Cursors.Default
            End If
        End If
    End Sub
End Class
