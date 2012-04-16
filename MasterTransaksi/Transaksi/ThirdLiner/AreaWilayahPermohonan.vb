Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports DevComponents.DotNetBar

Public Class AreaWilayahPermohonan
    Inherits PageTemplate
    Private Sub checkPermohonan(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ButtonItem = sender
        If btn.Checked Then
            cboPilihBundle.Text = btn.Tag
        Else
            cboPilihBundle.SelectedIndex = 0
        End If

    End Sub
    Public Overrides Sub Refresh()
        MyBase.Refresh()
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
    End Sub

    Private Sub cboPemohon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPemohon.SelectedIndexChanged
        If cboPemohon.SelectedValue IsNot Nothing Then
            Dim dt As New DataTable
            Utils.executeSP("proc_permohonan_area_wilayah", New Object() {"select", cboPemohon.SelectedValue, 0, 0}, dt)
            deconstructWilayahKerja(dt.Rows(0).Item("wilayah_kerja"))
            deconstructTerminal(dt.Rows(0).Item("terminal"))
            dt.Dispose()
        End If
    End Sub

    Private Function constructWilayahKerja() As String
        Dim wilayah_kerja As String = ""
        If cboWilayahKerjaA.Checked Then wilayah_kerja = "A|" & wilayah_kerja
        If cboWilayahKerjaB.Checked Then wilayah_kerja = "B|" & wilayah_kerja
        If cboWilayahKerjaC.Checked Then wilayah_kerja = "C|" & wilayah_kerja
        If cboWilayahKerjaG.Checked Then wilayah_kerja = "G|" & wilayah_kerja
        If cboWilayahKerjaGMF.Checked Then wilayah_kerja = "GMF|" & wilayah_kerja

        If cboWilayahKerjaM.Checked Then wilayah_kerja = "M|" & wilayah_kerja
        If cboWilayahKerjaP.Checked Then wilayah_kerja = "P|" & wilayah_kerja
        If cboWilayahKerjaQ.Checked Then wilayah_kerja = "Q|" & wilayah_kerja
        If cboWilayahKerjaR.Checked Then wilayah_kerja = "R|" & wilayah_kerja
        If cboWilayahKerjaS.Checked Then wilayah_kerja = "S|" & wilayah_kerja

        If cboWilayahKerjaT.Checked Then wilayah_kerja = "T|" & wilayah_kerja
        If cboWilayahKerjaV.Checked Then wilayah_kerja = "V|" & wilayah_kerja
        If cboWilayahKerjaX.Checked Then wilayah_kerja = "X|" & wilayah_kerja
        If cboWilayahKerjaY.Checked Then wilayah_kerja = "Y|" & wilayah_kerja
        If cboWilayahKerjaZ.Checked Then wilayah_kerja = "Z|" & wilayah_kerja


        Return wilayah_kerja '.Substring(0, wilayah_kerja.Length - 1)
    End Function

    Private Function constructTerminal() As String
        Dim terminal As String = ""

        If chkT1.Checked Then terminal = "T. I|" & terminal
        If chkT2.Checked Then terminal = "T. II|" & terminal
        If chkT3.Checked Then terminal = "T. III|" & terminal
        Return terminal '.Substring(0, terminal.Length - 1)
    End Function

    Private Sub deconstructWilayahKerja(ByVal wilayah_kerja As String)
        Dim w As String() = wilayah_kerja.Split("|")

        cboWilayahKerjaA.Checked = False
        cboWilayahKerjaB.Checked = False
        cboWilayahKerjaC.Checked = False
        cboWilayahKerjaG.Checked = False
        cboWilayahKerjaGMF.Checked = False

        cboWilayahKerjaM.Checked = False
        cboWilayahKerjaP.Checked = False
        cboWilayahKerjaQ.Checked = False
        cboWilayahKerjaR.Checked = False
        cboWilayahKerjaS.Checked = False

        cboWilayahKerjaT.Checked = False
        cboWilayahKerjaV.Checked = False
        cboWilayahKerjaX.Checked = False
        cboWilayahKerjaY.Checked = False
        cboWilayahKerjaZ.Checked = False

        For Each s As String In w

            If s = "A" Then cboWilayahKerjaA.Checked = True
            If s = "B" Then cboWilayahKerjaB.Checked = True
            If s = "C" Then cboWilayahKerjaC.Checked = True
            If s = "G" Then cboWilayahKerjaG.Checked = True
            If s = "GMF" Then cboWilayahKerjaGMF.Checked = True

            If s = "M" Then cboWilayahKerjaM.Checked = True
            If s = "P" Then cboWilayahKerjaP.Checked = True
            If s = "Q" Then cboWilayahKerjaQ.Checked = True
            If s = "R" Then cboWilayahKerjaR.Checked = True
            If s = "S" Then cboWilayahKerjaS.Checked = True

            If s = "T" Then cboWilayahKerjaT.Checked = True
            If s = "V" Then cboWilayahKerjaV.Checked = True
            If s = "X" Then cboWilayahKerjaX.Checked = True
            If s = "Y" Then cboWilayahKerjaY.Checked = True
            If s = "Z" Then cboWilayahKerjaZ.Checked = True

        Next

    End Sub

    Private Sub deconstructTerminal(ByVal terminal As String)
        Dim t As String() = terminal.Split("|")
        chkT1.Checked = False
        chkT2.Checked = False
        chkT3.Checked = False

        For Each s As String In t
            If s = "T. I" Then
                chkT1.Checked = True
            ElseIf s = "T. II" Then
                chkT2.Checked = True
            ElseIf s = "T. III" Then
                chkT3.Checked = True
            End If
        Next

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim wilayah_kerja As String = constructWilayahKerja()
        Dim terminal As String = constructTerminal()
        Utils.exec_SP("proc_permohonan_area_wilayah", New Object() {"edit", cboPemohon.SelectedValue, terminal, wilayah_kerja})
        MessageBox.Show("Wilayah dan terminal berhasil diupdate", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        'kalau perpanjangan, ambil data yang lama 
        Utils.fillComboBoxUsingSP(cboPemohon, "proc_permohonan_select_for_combobox", New Object() {cboPilihBundle.SelectedValue}, "--Pilih pemohon--")

    End Sub
    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        refreshDataGrid()
    End Sub

    Private Sub AreaWilayahPermohonan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnKirim.Image = My.Resources.bt_disetujui_64
    End Sub

    Private Sub btnKirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirim.Click
        If MessageBoxEx.Show("Setelah proses pengiriman bundle berkas permohonan ini dilakukan, Anda tidak dapat membatalkannya." & vbCrLf & "Apakah Anda yakin?", "Airport Pass", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim p As PersetujuanTransactionPage
            p = Pages.Item("persetujuanTransactionPage")
            p.kirimBundleKeLangkahSelanjutnya(cboPilihBundle.Text)
            Refresh()
        End If

    End Sub
End Class
