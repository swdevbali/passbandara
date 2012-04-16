
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class PemohonListPage
    Inherits PageListTemplate

    Public Sub New()
        InitializeComponent()
        MyBase.PROCEDURE_MASTER = "proc_pemohon"
        MyBase.PROCEDURE_SEARCH = "proc_pemohon_search"
        'MyBase.SELECT_PARAMETER = New Object() {"select", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
        MyBase.FORM_ENTRY_NAME = "PemohonEntryPage"
        MyBase.isEntryEmbedded = True

        defaultAllColumn("tb_pemohon")
    End Sub
    Protected Overrides Sub prepareSelectParamater()
        MyBase.prepareSelectParamater()
        MyBase.SELECT_PARAMETER = New Object() {"select", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, MyBase.getPageStart(), MyBase.pageLength}

    End Sub
    Overrides Sub prepareSearchParameter(ByVal namakolom As String, ByVal katakunci As String)
        'default to this (old Cosmedic)
        SEARCH_PARAMETER = New Object() {"search", "tb_pemohon." & namakolom, katakunci, getPageStart(), pageLength}
    End Sub

    Public Overrides Sub prepareDeleteParameter(ByVal kode As String)
        DELETE_PARAMETER = New Object() {"delete", kode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, MyBase.getPageStart(), MyBase.pageLength}
    End Sub
    Public Overrides Sub prepareReport(ByVal clsView As clsReportPreview)
        MyBase.prepareReport(clsView)
        clsView.SetParameter("namaklinik", Session.username.ToUpper)
        clsView.SetParameter("alamat", Session.valamat.ToString.ToUpper)
        clsView.SetParameter("telepon", "Telp." & Session.vtelepon)
        clsView.SetParameter("fax", "Fax." & Session.vfax)
        clsView.SetParameter("petugas", Session.vusername.ToString.ToUpper)
    End Sub

    Private Sub PemohonListPage_EnterReportPage(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnterReportPage
        Dim page As PageTemplate = sender
        EventBroadcaster.doEnterReportPage(page)
    End Sub
    Protected Overrides Sub prepareCountParameter()
        MyBase.prepareCountParameter()
        MyBase.COUNT_PARAMETER = New Object() {"select_count", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}

    End Sub
    Protected Overrides Sub prepareCountPencarianParameter(ByVal namakolom As String, ByVal katakunci As String)
        COUNT_PARAMETER = New Object() {"count", "tb_pemohon." & namakolom, katakunci, Nothing, Nothing}
    End Sub
  

End Class
