
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class JenisBerkasEntryPage
    Inherits PageEntryTemplate

#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtJenisBerkas.Validating, AddressOf Validation.required
    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtJenisBerkas.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtJenisBerkas.Text, CInt(cboWajib.Checked)}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtJenisBerkas.Text, CInt(cboWajib.Checked)}
    End Sub
    'idtb_pemohon as ID, nama,no_identitas, jenis_kelamin, idtb_instansi, status_pemohon, idtb_privilege
#End Region
End Class
