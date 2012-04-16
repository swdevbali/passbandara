Imports SwdevIUICore
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports RootSection

Public Class FrontlinerPermohonanPage
    Inherits PageTemplate
    Dim activeTab As PageTemplate
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        'If activeTab IsNot Nothing Then activeTab.Refresh()
        linkTambahBundle.Visible = False
        Dim p As PageTemplate
        If Session.kodeRole = Jabatan.FRONTLINER Then
            linkTambahBundle.Visible = True
            pnlKlien.Controls.Clear()
            p = Pages.Item("pengaturanAwal")
            p.Refresh()
            p.Dock = DockStyle.Fill
            pnlKlien.Controls.Add(Pages.Item("pengaturanAwal"))
        ElseIf Session.kodeRole = Jabatan.SECONDLINER Then
            pnlKlien.Controls.Clear()
            p = Pages.Item("pemberkasanPermohonan")
            p.Refresh()
            p.Dock = DockStyle.Fill
            pnlKlien.Controls.Add(p)
        ElseIf Session.kodeRole = Jabatan.THIRDLINER Then
            pnlKlien.Controls.Clear()
            p = Pages.Item("areaWilayahPermohonan")
            p.Refresh()
            p.Dock = DockStyle.Fill
            pnlKlien.Controls.Add(p)
        ElseIf Session.kodeRole = Jabatan.KASIR Then
            pnlKlien.Controls.Clear()
            p = Pages.Item("pembayaranPermohonan")
            p.Refresh()
            p.Dock = DockStyle.Fill
            pnlKlien.Controls.Add(p)
        ElseIf Session.kodeRole = Jabatan.FOTO_DAN_PENCETAKAN Then
            pnlKlien.Controls.Clear()
            p = Pages.Item("fotoDanPencetakanPermohonan")
            p.Dock = DockStyle.Fill
            p.Refresh()
            pnlKlien.Controls.Add(p)
        End If

    End Sub


    Private Sub btnStatistik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlKlien.Controls.Clear()
        Dim c As StatistikPermohonan = Pages.Item("statistikPermohonan")
        c.Refresh() 'TODO : oiya, apa nih, beda refresh dan OnEnterView, sptnya konsep dan maksudnya sama
        c.Dock = Windows.Forms.DockStyle.Fill
        pnlKlien.Controls.Add(c)
    End Sub

    Public jumlah_permohonan As Integer
    Public Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        'update control saat bundle tertentu dipilih
        jumlah_permohonan = 0

        Dim pa As PengaturanAwal = Pages.Item("pengaturanAwal")
        With pa
            .jumlahPermohonanAwal = 0
            If cboPilihBundle.SelectedIndex = 0 Then
                .dgvList.Enabled = False
                .btnHapusBendel.Enabled = False
                .txtNomorBundle.Text = ""
                If .cboInstansiBundle.Items.Count > 0 Then .cboInstansiBundle.SelectedIndex = 0
                .dtTanggalMasukBundle.CustomFormat = " "
                .txtPengurusBundle.Text = ""
                .txtNomorSurat.Text = ""

                .txtNomorBundle.Enabled = False
                .cboInstansiBundle.Enabled = False
                .dtTanggalMasukBundle.Enabled = False
                .txtPengurusBundle.Enabled = False
                .cboStatusBundle.Enabled = False
                .cboStatusBundle.SelectedIndex = 0
                .btnUpdateBendel.Enabled = False
                .suppresRowAddition = True
                .numJumlahPermohonan.Value = 0
                .suppresRowAddition = False
                .numJumlahPermohonan.Enabled = False
                .lblSudahDikirim.Text = ""
                .txtNomorSurat.Enabled = False
                .dgvList.Rows.Clear()
            Else

                Dim dt As New DataTable
                Utils.executeSP("proc_permohonan_bundle", New Object() {"selectsingle", cboPilihBundle.SelectedValue, -1, Now.ToString("yyyy-MM-dd"), "", 0, 0, 0}, dt)
                .numJumlahPermohonan.Value = 0
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                    jumlah_permohonan = dt.Rows(0).Item("jumlah_permohonan")
                    If IsDBNull(dt.Rows(0).Item("idtb_next_progress")) Or (Not IsDBNull(dt.Rows(0).Item("idtb_next_progress")) AndAlso dt.Rows(0).Item("idtb_next_progress") = Progress.PENDAFTARAN) Then
                        .btnHapusBendel.Enabled = True
                        .txtNomorBundle.Enabled = True
                        .cboInstansiBundle.Enabled = True
                        .dtTanggalMasukBundle.Enabled = True
                        .txtPengurusBundle.Enabled = True
                        .cboStatusBundle.Enabled = True
                        .btnUpdateBendel.Enabled = True
                        .numJumlahPermohonan.Enabled = True
                        .btnKirim.Enabled = True
                        .btnUpdatePermohonan.Enabled = True
                        .txtNomorSurat.Enabled = True
                        .dgvList.Enabled = True
                        .ButtonX1.Enabled = True
                        .lblSudahDikirim.Text = "Berkas belum dikirim ke Kasubag Perencanaan dan Keuangan, Anda masih bisa mengedit bundle permohonan ini"
                    Else
                        .btnHapusBendel.Enabled = False
                        .txtNomorBundle.Enabled = False
                        .cboInstansiBundle.Enabled = False
                        .dtTanggalMasukBundle.Enabled = False
                        .txtPengurusBundle.Enabled = False
                        .cboStatusBundle.Enabled = False
                        .btnUpdateBendel.Enabled = False
                        .numJumlahPermohonan.Enabled = False
                        .btnKirim.Enabled = False
                        .btnUpdatePermohonan.Enabled = False
                        .txtNomorSurat.Enabled = False
                        .dgvList.Enabled = False
                        .ButtonX1.Enabled = False
                        .lblSudahDikirim.Text = "Berkas sudah dikirim ke Kasubag Perencanaan dan Keuangan, Anda tidak bisa mengedit bundle permohonan ini"
                    End If

                    .txtNomorBundle.Text = dt.Rows(0).Item("nomor_bundle")
                    Utils.selectInCombo(.cboInstansiBundle, dt.Rows(0).Item("idtb_instansi").ToString)
                    .dtTanggalMasukBundle.CustomFormat = "yyyy/MM/dd"
                    .dtTanggalMasukBundle.Value = dt.Rows(0).Item("tanggal_masuk_proses").ToString
                    .txtPengurusBundle.Text = dt.Rows(0).Item("pengurus")
                    .cboStatusBundle.Text = dt.Rows(0).Item("Status")
                    .cboInstansiBundle_SelectedIndexChanged(Nothing, Nothing) 'sisa kuota baru
                    .txtNomorSurat.Text = dt.Rows(0).Item("nomor_surat")
                End If
                If dt IsNot Nothing Then dt.Dispose()
            End If
        End With
        pa.initializeData() 'TODO : konsep u/ semua page : dipastikan dipanggil=>tidak mesti refresh
        pa.fillPermohonan()
        If Session.kodeRole = Jabatan.SECONDLINER Then
            Pages.Item("pemberkasanPermohonan").Refresh()
        ElseIf Session.kodeRole = Jabatan.SECONDLINER Then
            Pages.Item("pemberkasanPermohonan").Refresh()
        ElseIf Session.kodeRole = Jabatan.THIRDLINER Then
            Pages.Item("areaWilayahPermohonan").Refresh()
        ElseIf Session.kodeRole = Jabatan.KASIR Then
            Pages.Item("pembayaranPermohonan").Refresh()
        ElseIf Session.kodeRole = Jabatan.FOTO_DAN_PENCETAKAN Then
            Pages.Item("fotoDanPencetakanPermohonan").Refresh()
        End If
    End Sub

    Private Sub linkTambahBundle_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTambahBundle.LinkClicked
        Dim FormEntry As PageEntryTemplate = Pages.Item("PermohonanBundleEntryPage")
        Dim popUp As PopupWindow = New PopupWindow
        Dim listPage As PageListTemplate = Pages.Item("PermohonanBundleListPage")
        popUp.Font = FormEntry.Font

        FormEntry.InstancePageListTemplate.isEntryEmbedded = False
        FormEntry.InstancePageTemplate = Me
        FormEntry.PROCEDURE_MASTER = "proc_permohonan_bundle"
        FormEntry.Dock = DockStyle.Fill
        FormEntry.FormMode = PageEntryTemplate.FormModeEnum.ADD
        FormEntry.prepareForAddition()
        listPage.isEntryEmbedded = False

        popUp.clearControl()
        popUp.Add(FormEntry)
        Dim newsize As Drawing.Size = FormEntry.Size  'Drawing.Size.Add(FormEntry.Size, New Drawing.Size(12, 20))
        'If newsize.Width < 500 Then newsize.Width = 520

        popUp.Text = Application.ProductName
        popUp.Size = newsize
        popUp.ShowDialog()
        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        Dim pa As PengaturanAwal = Pages.Item("pengaturanAwal")
        Utils.fillComboBox(pa.cboInstansiBundle, "idtb_instansi", "nama_instansi", "tb_instansi", "--Pilih instansi baru--")
        If FormEntry.result = DialogResult.OK Then
            cboPilihBundle.SelectedIndex = cboPilihBundle.Items.Count - 1
        End If


        'TODO : Focus to where?
    End Sub

    Private Sub btnNextModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub linkEditBundle_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        pnlKlien.Controls.Clear()
        pnlKlien.Controls.Add(Pages.Item("pengaturanAwal"))
        pnlKlien.Controls(0).Dock = DockStyle.Fill
    End Sub
End Class
