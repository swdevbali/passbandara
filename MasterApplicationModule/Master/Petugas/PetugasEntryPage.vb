
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class PetugasEntryPage
    Inherits PageEntryTemplate
#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtUsername.Validating, AddressOf Validation.required
        AddHandler txtNamaLengkap.Validating, AddressOf Validation.required
        prepareDependantControl() 'TODO TODO about synch to others
    End Sub
    Sub prepareDependantControl()
        Utils.fillComboBox(cboKodeRole, "koderole", "role", "tb_jabatan", "--Pilih jabatan--")

    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtUsername.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", Nothing, kode, Nothing, Nothing, Nothing, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtUsername.Text, txtPassword.Text, txtNamaLengkap.Text, cboKodeRole.SelectedValue, txtAlamat.Text, txtHandphone.Text}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        If txtPassword.Text <> "" Then
            UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtUsername.Text, txtPassword.Text, txtNamaLengkap.Text, cboKodeRole.SelectedValue, txtAlamat.Text, txtHandphone.Text}
        Else
            UPDATE_PARAMETER = New Object() {"editnopass", idkodelama, txtUsername.Text, txtPassword.Text, txtNamaLengkap.Text, cboKodeRole.SelectedValue, txtAlamat.Text, txtHandphone.Text}
        End If
    End Sub
#End Region

End Class
