Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports DevComponents.DotNetBar

Public Class PemberkasanPermohonan
    Inherits PageTemplate
    Dim pengaturanAwal As PengaturanAwal
    Dim pemberkasanTransactionPage As PemberkasanTransactionPage
    'Dim frontlinerPermohonan As FrontlinerPermohonanPage
    Private Sub checkPermohonan(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ButtonItem = sender
        If btn.Checked Then
            cboPilihBundle.Text = btn.Tag
            btnKirim.Enabled = True
            cboPemohon.Enabled = True
        Else
            cboPilihBundle.SelectedIndex = 0
            btnKirim.Enabled = False
            cboPemohon.Enabled = False
        End If

    End Sub
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        'pengaturanAwal = Pages.Item("pengaturanAwal")
        'frontlinerPermohonan = Pages.Item("frontlinerPermohonanPage")
        'lblInstansi.Text = cboPilihBundle.Text  'CBool pengaturanAwal.cboInstansiBundle.Text
        'lblNomorBundle.Text = pengaturanAwal.txtNomorBundle.Text
        'pemohon2 pada bundle ini
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
        refreshDataGrid()

        sidebarProgress.Refresh()

    End Sub
    Public Overrides Sub refreshDataGrid()
        MyBase.refreshDataGrid()
        If cboPilihBundle.SelectedValue Is Nothing Then
            btnKirim.Enabled = False
            cboPemohon.Enabled = False
        Else
            btnKirim.Enabled = True
            cboPemohon.Enabled = True
        End If
        Utils.fillComboBoxUsingSP(cboPemohon, "proc_permohonan_select_for_combobox", New Object() {cboPilihBundle.SelectedValue}, "--Pilih pemohon")
       
    End Sub
    Private Sub PemberkasanPermohonan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyBase.Refresh()
        
    End Sub

    Private Sub cboPemohon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPemohon.SelectedIndexChanged

        If cboPemohon.SelectedValue IsNot Nothing Then
            pnlPemberkasan.Controls.Clear()
            If Not cboPemohon.SelectedValue Is Nothing Then
                pemberkasanTransactionPage = Pages.Item("pemberkasanTransactionPage")
                pemberkasanTransactionPage.Dock = Windows.Forms.DockStyle.Fill
                pemberkasanTransactionPage.Refresh() 'hm, harus ingat merefresh setiap kali load ini
                pnlPemberkasan.Controls.Add(pemberkasanTransactionPage)
            End If

            pemberkasanTransactionPage.loadBerkasForSelectedPermohonan(cboPemohon.SelectedValue)
        Else

            pnlPemberkasan.Controls.Clear()
        End If

    End Sub

    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged

        refreshDataGrid()
    End Sub

    Private Sub btnKirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirim.Click
        If MessageBoxEx.Show("Setelah proses pengiriman bundle berkas permohonan ini dilakukan, Anda tidak dapat membatalkannya." & vbCrLf & "Apakah Anda yakin?", "Airport Pass", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim p As PersetujuanTransactionPage
            p = Pages.Item("persetujuanTransactionPage")
            p.kirimBundleKeLangkahSelanjutnya(cboPilihBundle.Text)
            Refresh()
        End If
        
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
