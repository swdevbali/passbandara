Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUICore

Public Class PermohonanBundleEntryPage
    Inherits PageEntryTemplate


#Region "Framework Specific"
    Public Sub New()
        InitializeComponent()
        CONTROL_CONTAINER = New Control() {tableData}
        Validation.ErrorProvider1 = ErrorProvider1
        AddHandler txtNomorBundle.Validating, AddressOf Validation.required
        Utils.fillComboBox(cboInstansi, "idtb_instansi", "nama_instansi", "tb_instansi", "--Pilih instansi--")

    End Sub
    Protected Overrides Sub enableNewValue()
        MyBase.enableNewValue()
        Dim dt As New DataTable
        Utils.executeSP("proc_generate_nomor_bundle", New Object() {}, dt)
        txtNomorBundle.Text = dt.Rows(0).Item(0)
        dt.Dispose()
    End Sub
    Public Overrides Sub prepareFirstFocus()
        cboInstansi.Focus()
    End Sub
    Public Overrides Sub prepareSelectSingleRowParameter(ByVal kode As String)
        SELECT_SINGLE_ROW_PARAMETER = New Object() {"selectsingle", kode, Nothing, Nothing, Nothing, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareInsertParameter()
        INSERT_PARAMETER = New Object() {"add", -1, cboInstansi.SelectedValue, dtProses.Value.ToString("yyyy-MM-dd"), txtNomorBundle.Text, txtPengurus.Text, "Sedang diproses", txtNomorSurat.Text}
    End Sub
    Public Overrides Sub prepareUpdateParameter(ByVal idkodelama As String)
        UPDATE_PARAMETER = New Object() {"edit", idkodelama, cboInstansi.SelectedValue.Text, dtProses.Value.ToString("yyyy-MM-dd"), txtNomorBundle.Text, txtPengurus.Text, "Sedang diproses", txtNomorSurat.Text}
    End Sub
#End Region

    Private Sub linkInstansi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInstansi.LinkClicked
        Dim FormEntry As PageEntryTemplate = Pages.Item("instansiEntryPage")
        Dim popUp As PopupWindow = New PopupWindow
        popUp.clearControl()
        popUp.Add(FormEntry)
        Dim newsize As Drawing.Size = Drawing.Size.Add(FormEntry.Size, New Drawing.Size(12, 20))
        If newsize.Width < 500 Then newsize.Width = 520
        Dim listPage As PageListTemplate = Pages.Item("InstansiListPage")
        listPage.isEntryEmbedded = False
        FormEntry.PROCEDURE_MASTER = "proc_instansi"
        FormEntry.Dock = DockStyle.Fill
        FormEntry.FormMode = PageEntryTemplate.FormModeEnum.ADD
        FormEntry.InstancePageTemplate = Me
        FormEntry.prepareForAddition()
        popUp.Text = Application.ProductName
        popUp.Size = newsize
        popUp.ShowDialog()
        Utils.fillComboBox(cboInstansi, "idtb_instansi", "nama_instansi", "tb_instansi", "--Pilih instansi baru--")

    End Sub
End Class
