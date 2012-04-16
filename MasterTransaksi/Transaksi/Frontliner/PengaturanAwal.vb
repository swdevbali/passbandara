Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports DevComponents.DotNetBar

'thanks for autocomplete in datagridview http://www.dotnetspider.com/resources/29740-Auto-Complete-For-TextBox-Control.aspx
'thanks for null value in datetimepickerb http://nodedangles.wordpress.com/2010/07/13/datetimepicker-null-value/
Public Class PengaturanAwal
    Inherits PageTemplate
    Public Property sisaKuota As Integer
    Public frontlinerPermohonan As FrontlinerPermohonanPage
    Dim prevRow As DataGridViewRow
    Public jumlahPermohonanAwal As Integer
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        suppresRowAddition = False
        'Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        Utils.fillComboBox(cboInstansiBundle, "idtb_instansi", "nama_instansi", "tb_instansi", "--Pilih instansi baru--")

        'PengaturanAwal = Pages.Item("pengaturanAwal")
        frontlinerPermohonan = Pages.Item("frontlinerPermohonanPage")
        'lblInstansi.Text = PengaturanAwal.cboInstansiBundle.Text
        'lblNomorBundle.Text = PengaturanAwal.txtNomorBundle.Text
        ' lblSisaKuota.Text = PengaturanAwal.sisaKuota

        fillPermohonan()
    End Sub


    'Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'update control saat bundle tertentu dipilih
    '    If cboPilihBundle.SelectedIndex = 0 Then
    '        btnHapusBendel.Enabled = False
    '        txtNomorBundle.Text = ""
    '        If cboInstansiBundle.Items.Count > 0 Then cboInstansiBundle.SelectedIndex = 0
    '        'dtTanggalMasukBundle.Value = Nothing
    '        txtPengurusBundle.Text = ""

    '        txtNomorBundle.Enabled = False
    '        cboInstansiBundle.Enabled = False
    '        dtTanggalMasukBundle.Enabled = False
    '        txtPengurusBundle.Enabled = False
    '        cboStatusBundle.Enabled = False
    '        cboStatusBundle.SelectedIndex = 0
    '        btnUpdateBendel.Enabled = False
    '        'If Session.kodeRole = 2 Then linkTambahBundle.Enabled = True Else linkTambahBundle.Enabled = False
    '    Else
    '        If Session.kodeRole = 2 Then
    '            btnHapusBendel.Enabled = True
    '            txtNomorBundle.Enabled = True
    '            cboInstansiBundle.Enabled = True
    '            dtTanggalMasukBundle.Enabled = True
    '            txtPengurusBundle.Enabled = True
    '            cboStatusBundle.Enabled = True
    '            btnUpdateBendel.Enabled = True
    '            'linkTambahBundle.Enabled = True
    '        End If

    '        Dim dt As New DataTable
    '        Utils.executeSP("proc_permohonan_bundle", New Object() {"selectsingle", cboPilihBundle.SelectedValue, -1, Now.ToString("yyyy-MM-dd"), "", 0, 0}, dt)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            txtNomorBundle.Text = dt.Rows(0).Item("nomor_bundle")

    '            Utils.selectInCombo(cboInstansiBundle, dt.Rows(0).Item("idtb_instansi").ToString)
    '            dtTanggalMasukBundle.Value = dt.Rows(0).Item("tanggal_masuk_proses").ToString
    '            'Utils.selectInCombo(cboAtasNamaBundle, dt.Rows(0).Item("idtb_pemohon_pengurus").ToString)
    '            txtPengurusBundle.Text = dt.Rows(0).Item("pengurus")
    '            cboStatusBundle.Text = dt.Rows(0).Item("Status")
    '            suppresRowAddition = True
    '            numJumlahPermohonan.Value = dt.Rows(0).Item("sisa_kuota")
    '            suppresRowAddition = False
    '        End If
    '        If dt IsNot Nothing Then dt.Dispose()
    '    End If
    'End Sub

    Private Sub linkPersetujuan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim p As PersetujuanTransactionPage = Pages.Item("persetujuanTransactionPage")
        EventBroadcaster.doEnterReportPage(p)
    End Sub

    Public Sub cboInstansiBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstansiBundle.SelectedIndexChanged
        lblSisaKuota.Text = "Sisa Kuota : --"
        If cboInstansiBundle.SelectedValue IsNot Nothing Then

            'QUICKFIX : maaf, langsung aku kopi ke cboPilihBUndle action
            Dim dt As New DataTable
            Utils.executeSP("proc_instansi", New Object() {"selectsingle", cboInstansiBundle.SelectedValue, 0, 0, 0, 0, 0, 0}, dt)
            sisaKuota = dt.Rows(0).Item("Sisa Kuota")
            lblSisaKuota.Text = "Sisa Kuota : " & sisaKuota

        End If
    End Sub

  

    Public suppresRowAddition As Boolean = False
    Private Sub numJumlahPermohonan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numJumlahPermohonan.ValueChanged
        If suppresRowAddition Then Return
        Dim jumlahRowBaru As Integer = numJumlahPermohonan.Value
        Dim perubahanJumlah As Integer = numJumlahPermohonan.Value - jumlahPermohonanAwal

        If perubahanJumlah = -1 Then
            Dim idtb_permohonan As Integer = dgvList.Rows(dgvList.RowCount - 1).Cells("idtb_permohonan").Value
            If idtb_permohonan <> Nothing Then
                If MessageBoxEx.Show("Ada permohonan yang tersimpan pada baris ini, apakah Anda akan menghapusnya?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Utils.exec_SP("proc_permohonan", New Object() {"delete", idtb_permohonan, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
                Else
                    suppresRowAddition = True
                    numJumlahPermohonan.Value = jumlahPermohonanAwal
                    suppresRowAddition = False
                    Return
                End If
            End If
        End If

        If sisaKuota - perubahanJumlah < 0 Then 'jumlahRowBaru > sisaKuota 
            suppresRowAddition = True
            numJumlahPermohonan.Value = jumlahPermohonanAwal
            suppresRowAddition = False
            MsgBox("Maaf, kuota permohonan sudah habis")
            'numJumlahPermohonan.Value = sisaKuota
            Return
        End If
        Dim selisih As Integer
        If jumlahRowBaru < dgvList.Rows.Count Then
            selisih = dgvList.Rows.Count - jumlahRowBaru
            For i As Integer = 0 To selisih - 1
                dgvList.Rows.RemoveAt(dgvList.Rows.Count - 1)
            Next
        Else
            selisih = jumlahRowBaru - dgvList.Rows.Count
            If selisih > 0 Then dgvList.Rows.Add(selisih)
        End If

        'kurangi sisa kuota
        If Not suppresRowAddition And perubahanJumlah <> 0 Then
            Utils.exec_SP("proc_instansi_pengurangan_kuota", New Object() {cboInstansiBundle.SelectedValue, perubahanJumlah})
            Utils.exec_SP("proc_permohonan_bundle_penambahan_jumlah_permohonan", New Object() {frontlinerPermohonan.cboPilihBundle.SelectedValue, perubahanJumlah})
        End If
        jumlahPermohonanAwal = numJumlahPermohonan.Value
        'refresh sisa kuota
        cboInstansiBundle_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Dim isInitialized As Boolean = False
    Sub initializeData()
        If Not isInitialized Then
            isInitialized = True
            frontlinerPermohonan = Pages.Item("frontlinerPermohonanPage")
            Utils.fillAutocomplete(autoPemohon, "proc_pemohon_autocomplete", New Object() {})
            Utils.fillAutocomplete(autoJabatan, "proc_jabatan_pemohon_autocomplete", New Object() {})
            autoSex.Clear()
            autoSex.Add("Pria")
            autoSex.Add("Wanita")
        End If

    End Sub


    Private Sub dgvList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellEndEdit
        If e.ColumnIndex = 2 Then
            If dgvList.CurrentCell.Value Is Nothing Then Return
            dgvList.CurrentRow.Cells("idtb_pemohon").Value = Nothing
            Dim arr As String() = dgvList.CurrentCell.Value.Split("-") 'ASUMSI SISTEM : tidak ada oranyg pakai nama -
            If arr.Length < 2 Then
                'ini data baru.
                'If MessageBox.Show("Data pemohon ini baru. Apakah Anda yakin akan memasukkan data pemohon baru?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                'Else
                'End If
                Exit Sub
            End If

            dgvList.CurrentCell.Value = arr(0)

            Dim dt As New DataTable
            Utils.executeSP("proc_pemohon", New Object() {"selectsingle", arr(1), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, dt)
            dgvList.CurrentRow.Cells("NIP").Value = dt.Rows(0).Item("NIP")
            dgvList.CurrentRow.Cells("Jenis_Kelamin").Value = dt.Rows(0).Item("jenis_kelamin")
            dgvList.CurrentRow.Cells("idtb_pemohon").Value = arr(1)
            dgvList.CurrentRow.Cells("Nama_Pemohon").Value = dgvList.CurrentRow.Cells("Nama_Pemohon").Value.ToString.ToUpper()
            dt.Dispose()
            'dgvList.CurrentRow.Cells("Posisi").Selected = True
        End If
    End Sub
#Region "Autocomplete"
    Private autoPemohon As New AutoCompleteStringCollection
    Private autoJabatan As New AutoCompleteStringCollection
    Private autoSex As New AutoCompleteStringCollection


#End Region
    Private Sub dgvList_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvList.EditingControlShowing
        If dgvList.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteCustomSource = autoPemohon
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        ElseIf dgvList.CurrentCell.ColumnIndex = 3 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteCustomSource = autoSex
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        ElseIf dgvList.CurrentCell.ColumnIndex = 4 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteCustomSource = autoJabatan
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        Else
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.None
            End With
        End If
    End Sub


    Private Sub dgvList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvList.SelectionChanged
        'do the save/update here
        'Dim row As DataGridViewRow = dgvList.CurrentRow
        If prevRow IsNot Nothing AndAlso prevRow.Cells(0).RowIndex > 0 Then
            Dim idtb_permohonan As String = prevRow.Cells("idtb_permohonan").Value
            Dim nip As String = prevRow.Cells("NIP").Value
            Dim nama As String = prevRow.Cells("Nama_Pemohon").Value
            Dim jenis_kelamin As String = prevRow.Cells("Jenis_Kelamin").Value
            Dim posisi As String = prevRow.Cells("Posisi").Value
            'If idtb_permohonan Is Nothing Then
            '    'pemohon harus diciptakan/diambil...

            'Else

            'End If


        End If
        prevRow = dgvList.CurrentRow
    End Sub

  

    Private Sub ReloadAutocompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadAutocompleteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Utils.fillAutocomplete(autoPemohon, "proc_pemohon_autocomplete", New Object() {})
        Utils.fillAutocomplete(autoJabatan, "proc_jabatan_pemohon_autocomplete", New Object() {})
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBatalkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Semua perubahan akan diabaikan, dan data akan diambil kembali dari basis data" & vbCrLf & "Lanjutkan ?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Refresh()
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        btnBatalkan_Click(Nothing, Nothing)
    End Sub

    Public Sub fillPermohonan()
        'reset nilai
        prevRow = Nothing
        'pengaturanAwal.numJumlahPermohonan.Value = 0
        'ambil permohonan
        Dim dt As New DataTable
        Utils.executeSP("proc_permohonan", New Object() {"select", 0, Now.ToString("yyyy-MM-dd"), Now.ToString("yyyy-MM-dd"), Now.ToString("yyyy-MM-dd"), 0, 0, 0, 0, frontlinerPermohonan.cboPilihBundle.SelectedValue, 0, 0, 0, 0, 0}, dt)

        dgvList.Rows.Clear()
        If dt.Rows.Count > 0 Then
            suppresRowAddition = True
            numJumlahPermohonan.Value = dt.Rows.Count
            For Each r As DataRow In dt.Rows
                dgvList.Rows.Add(New Object() {r("ID"), r("nip"), r("Pemohon"), r("Jenis Kelamin"), r("Posisi"), r("idtb_pemohon")})
            Next
            suppresRowAddition = False
        End If

        Dim selisih_jumlah = frontlinerPermohonan.jumlah_permohonan - dt.Rows.Count
        For i As Integer = 0 To selisih_jumlah - 1
            suppresRowAddition = True
            dgvList.Rows.Add()
            suppresRowAddition = False
        Next
        dt.Dispose()

        suppresRowAddition = True
        numJumlahPermohonan.Value = frontlinerPermohonan.jumlah_permohonan
        suppresRowAddition = False


        jumlahPermohonanAwal = numJumlahPermohonan.Value

        
    End Sub

    Private Sub dtTanggalMasukBundle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTanggalMasukBundle.ValueChanged
        Me.dtTanggalMasukBundle.Format = Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalMasukBundle.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub btnUpdatePermohonan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatePermohonan.Click
        'kasus insert dulu ya
        Dim newData As Boolean = False
        Dim adaError As Boolean = False
        Dim iJumlahPermohonan As Integer = 0
        For Each r As DataGridViewRow In dgvList.Rows
            iJumlahPermohonan = iJumlahPermohonan + 1
            'data pemohon
            Dim vidtb_pemohon As String
            Dim tanggalMasuk As String = Now.ToString("yyyy-MM-dd")
            Dim vidtb_instansi As String = cboInstansiBundle.SelectedValue
            Dim vidtb_permohonan_bundle As String = frontlinerPermohonan.cboPilihBundle.SelectedValue


            Dim nip As String = r.Cells("NIP").Value
            Dim nama As String = r.Cells("Nama_Pemohon").Value
            Dim vjenis_kelamin As String = r.Cells("Jenis_Kelamin").Value
            Dim posisi As String = r.Cells("Posisi").Value

            Dim dt As New DataTable

            If r.Cells("idtb_pemohon").Value Is Nothing AndAlso r.Cells("Nama_Pemohon").Value <> "" Then
                'data pemohon baru, masukkan dulu
                Utils.executeSP("proc_pemohon", New Object() {"add", Nothing, nama, "", "", vjenis_kelamin, Nothing, "Baru", Nothing, posisi, Nothing, Nothing, nip}, dt)
                If dt Is Nothing Then
                    MessageBox.Show("Data pemohon pada baris ke " & r.Cells(0).RowIndex & " tidak bisa disimpan. Mohon perbaiki input datanya", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    adaError = True
                    Continue For
                Else
                    vidtb_pemohon = dt.Rows(0).Item(0)
                    newData = True
                End If
            Else
                'insert permohonan dengan kasus pemohon lama
                vidtb_pemohon = r.Cells("idtb_pemohon").Value
                newData = True 'yah, bisa aja dia ngupdate jabatan
                'hanya diupdate secara parsial u/ input data pemohon
                Utils.exec_SP("proc_pemohon_edit_for_input_permohonan", New Object() {vidtb_pemohon, nip, nama, vjenis_kelamin, posisi})

            End If

            Dim vidtb_permohonan As String = r.Cells("idtb_permohonan").Value
            If r.Cells("idtb_permohonan").Value Is Nothing Then
                Utils.exec_SP("proc_permohonan", New Object() {"add", Nothing, tanggalMasuk, Nothing, Nothing, vidtb_pemohon, "Diproses", Nothing, vidtb_instansi, vidtb_permohonan_bundle, "", "", "", posisi, nip})
            Else
                Utils.exec_SP("proc_permohonan", New Object() {"edit", vidtb_permohonan, tanggalMasuk, Nothing, Nothing, vidtb_pemohon, "Diproses", Nothing, vidtb_instansi, vidtb_permohonan_bundle, "", "", "", posisi, nip})
            End If
        Next

        'so we reload it again offcourse
        'If newData Then
        '    Me.Cursor = Cursors.WaitCursor
        '    Utils.fillAutocomplete(autoPemohon, "proc_pemohon_autocomplete", New Object() {})
        '    Utils.fillAutocomplete(autoJabatan, "proc_jabatan_pemohon_autocomplete", New Object() {})
        '    Me.Cursor = Cursors.Default
        'End If
        If Not adaError Then
            'kurangi kuota

            MessageBox.Show("Data berhasil diupdate", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data berhasil diupdate, namun terjadi kesalahan", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        frontlinerPermohonan.cboPilihBundle_SelectedIndexChanged(Nothing, Nothing) 'spy reload data idtb_permohonan yang baru
    End Sub

    Private Sub btnKirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirim.Click
        If frontlinerPermohonan.jumlah_permohonan = 0 Then
            MessageBoxEx.Show("Maaf, tidak ada permohonan yang diinputkan. Silahkan menginputkan permohonan terlebih dahulu", "Airpot Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBoxEx.Show("Setelah Anda mengirimkan berkas permohonan ini ke Kasubag Perencanaan dan Keuangan, maka bundle permohonan ini tidak bisa lagi diedit." & vbCrLf & "Apakah Anda akan melanjutkan?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim fl As FrontlinerPermohonanPage = Pages.Item("frontlinerPermohonanPage")
            Dim pp As PersetujuanTransactionPage = Pages.Item("persetujuanTransactionPage")
            pp.kirimBundleKeLangkahSelanjutnya(fl.cboPilihBundle.Text)
            'previously, dikurangi disini sisa kuotanya
            fl.cboPilihBundle_SelectedIndexChanged(Nothing, Nothing) 'reclick

            MessageBoxEx.Show("Berkas sudah dikirim ke Kasubag Perencanaan dan Keuangan, Anda tidak bisa mengedit permohonan ini lagi", "Airport Pass", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdateBendel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBendel.Click
        Utils.exec_SP("proc_permohonan_bundle", New Object() {"edit", frontlinerPermohonan.cboPilihBundle.SelectedValue, cboInstansiBundle.SelectedValue, dtTanggalMasukBundle.Value.ToString("yyyy-MM-dd"), txtNomorBundle.Text, txtPengurusBundle.Text, cboStatusBundle.Text, txtNomorSurat.Text})
        Dim i As Integer = frontlinerPermohonan.cboPilihBundle.SelectedIndex
        Utils.fillComboBox(frontlinerPermohonan.cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        frontlinerPermohonan.cboPilihBundle.SelectedIndex = i
        MessageBox.Show("Bendel berkas berhasil diupdate", "PassBandara", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnHapusBendel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusBendel.Click
        If MessageBox.Show("Semua permohonan yang berada di dalam bendel ini akan terhapus" & vbCrLf & "Apakah Anda yakin?", "PassBandara", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
            Utils.exec_SP("proc_permohonan_bundle", New Object() {"delete", frontlinerPermohonan.cboPilihBundle.SelectedValue, 0, 0, 0, 0, 0, 0})
            Utils.fillComboBox(frontlinerPermohonan.cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If dgvList.CurrentRow IsNot Nothing Then
            Dim idtb_permohonan As Integer = dgvList.CurrentRow.Cells("idtb_permohonan").Value
            suppresRowAddition = True
            dgvList.Rows.Remove(dgvList.CurrentRow)
            numJumlahPermohonan.Value = numJumlahPermohonan.Value - 1

            Utils.exec_SP("proc_instansi_pengurangan_kuota", New Object() {cboInstansiBundle.SelectedValue, -1})
            Utils.exec_SP("proc_permohonan_bundle_penambahan_jumlah_permohonan", New Object() {frontlinerPermohonan.cboPilihBundle.SelectedValue, -1})

            If idtb_permohonan <> Nothing Then
                Utils.exec_SP("proc_permohonan", New Object() {"delete", idtb_permohonan, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})

            End If
            cboInstansiBundle_SelectedIndexChanged(Nothing, Nothing)
            btnUpdatePermohonan_Click(Nothing, Nothing)
            suppresRowAddition = False
        End If
    End Sub
End Class
