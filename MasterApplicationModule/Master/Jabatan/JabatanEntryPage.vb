Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class JabatanEntryPage
    Inherits PageEntryTemplate

#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtRole.Validating, AddressOf Validation.required
        MyBase.InstancePageListTemplate = Pages.Item("JabatanListPage")

    End Sub
    Sub refreshDependantControl()
        Dim p As PetugasEntryPage = Pages.Item("petugasEntryPage")
        p.prepareDependantControl()
    End Sub
    Public Overrides Sub doAfterInsertNewData()
        MyBase.doAfterInsertNewData()
        refreshDependantControl() 'todo using observer might be perfect
    End Sub
    Public Overrides Sub doAfterUpdateData()
        MyBase.doAfterUpdateData()
        refreshDependantControl()
    End Sub
    Public Overrides Sub prepareFirstFocus()
        txtRole.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", Nothing, txtRole.Text}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, txtRole.Text}
    End Sub
#End Region
End Class
