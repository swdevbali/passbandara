
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class ProgressEntryPage
    Inherits PageEntryTemplate

#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtNamaProgress.Validating, AddressOf Validation.required
        AddHandler cboJabatan.Validating, AddressOf Validation.required
        MyBase.InstancePageListTemplate = Pages.Item("ProgressListPage")
        Utils.fillComboBox(cboJabatan, "koderole", "role", "tb_jabatan", "--Pilih jabatan--")
    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtNamaProgress.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtNamaProgress.Text, cboJabatan.SelectedValue}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtNamaProgress.Text, cboJabatan.SelectedValue}
    End Sub
#End Region
End Class
