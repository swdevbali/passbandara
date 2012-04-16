
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class ProgressListPage
    Inherits PageListTemplate

    Public Sub New()
        InitializeComponent()
        MyBase.PROCEDURE_MASTER = "proc_progress"
        MyBase.PROCEDURE_SEARCH = "proc_searchall"
        MyBase.SELECT_PARAMETER = New Object() {"select", Nothing, Nothing, Nothing}
        MyBase.FORM_ENTRY_NAME = "ProgressEntryPage"
        defaultAllColumn("tb_progress")
        MyBase.isEntryEmbedded = True
    End Sub
    Public Overrides Sub prepareSearchParameter(ByVal namakolom As String, ByVal katakunci As String)
        SEARCH_PARAMETER = New Object() {" idtb_progress as ID, nama_progress as `Nama progress`", "tb_progress", namakolom, katakunci}
    End Sub
    Public Overrides Sub prepareDeleteParameter(ByVal kode As String)
        DELETE_PARAMETER = New Object() {"delete", kode, Nothing, Nothing}
    End Sub
    Public Overrides Sub prepareReport(ByVal clsView As clsReportPreview)
        MyBase.prepareReport(clsView)
        clsView.SetParameter("namaklinik", Session.username.ToUpper)
        clsView.SetParameter("alamat", Session.valamat.ToString.ToUpper)
        clsView.SetParameter("telepon", "Telp." & Session.vtelepon)
        clsView.SetParameter("fax", "Fax." & Session.vfax)
        clsView.SetParameter("petugas", Session.vusername.ToString.ToUpper)
    End Sub

    Private Sub ProgressListPage_EnterReportPage(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnterReportPage
        Dim page As PageTemplate = sender
        EventBroadcaster.doEnterReportPage(page)
    End Sub

    Private Sub dgvList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class
