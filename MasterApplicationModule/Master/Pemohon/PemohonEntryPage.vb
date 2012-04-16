
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class PemohonEntryPage
    Inherits PageEntryTemplate

#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtNama.Validating, AddressOf Validation.required
        AddHandler txtAlamat.Validating, AddressOf Validation.required
        AddHandler txtNoIdentitas.Validating, AddressOf Validation.required
        AddHandler cboJenisKelamin.Validating, AddressOf Validation.required
        'AddHandler cboInstansi.Validating, AddressOf Validation.required
        AddHandler cboStatusPemohon.Validating, AddressOf Validation.required
        'AddHandler cboPrivilege.Validating, AddressOf Validation.required
        MyBase.InstancePageListTemplate = Pages.Item("PemohonListPage")
        Utils.fillComboBox(cboInstansi, "idtb_instansi", "nama_instansi", "tb_instansi", "--[OPSIONAL] Pilih instansi terkini--")
        'Utils.fillComboBox(cboPrivilege, "idtb_privilege", "kode_privilege", "tb_privilege", "--[OPSIONAL] Pilih privilege terkini--")

    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtNama.Focus()
    End Sub
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
    Protected Overrides Sub fillEditValue(ByVal dt As System.Data.DataTable)
        MyBase.fillEditValue(dt)
        deconstructWilayahKerja(dt.Rows(0).Item("Wilayah Kerja Terakhir"))
    End Sub

    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        Dim wilayah As String = constructWilayahKerja()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtNama.Text, txtAlamat.Text, txtNoIdentitas.Text, cboJenisKelamin.Text, cboInstansi.SelectedValue, cboStatusPemohon.Text, wilayah, txtJabatan.Text, 0, 0}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        Dim wilayah As String = constructWilayahKerja()
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtNama.Text, txtAlamat.Text, txtNoIdentitas.Text, cboJenisKelamin.Text, cboInstansi.SelectedValue, cboStatusPemohon.Text, wilayah, txtJabatan.Text, 0, 0}
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
#End Region
End Class
