Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class InstansiEntryPage
    Inherits PageEntryTemplate
#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtNamaInstansi.Validating, AddressOf Validation.required
        AddHandler txtKuotaMaksimal.Validating, AddressOf Validation.required
        AddHandler cboKategori.Validating, AddressOf Validation.required
        AddHandler txtSisaKuota.Validating, AddressOf Validation.required
        Utils.fillComboBox(cboBidangUsaha, "idtb_bidangusaha", "bidangusaha", "tb_bidangusaha", "--[OPSIONAL] Pilih bidang usaha--")
    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtNamaInstansi.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtNamaInstansi.Text, txtAlamat.Text, txtKuotaMaksimal.Text, cboKategori.Text, cboBidangUsaha.SelectedValue, txtSisaKuota.Text}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtNamaInstansi.Text, txtAlamat.Text, txtKuotaMaksimal.Text, cboKategori.Text, cboBidangUsaha.SelectedValue, txtSisaKuota.Text}
    End Sub
#End Region

   
End Class
