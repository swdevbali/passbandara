Imports System.Windows.Forms
Imports MasterModule
Imports TransaksiModule
Imports SwdevIUIcore
Imports SwdevEufrat.Eufrat
Imports SwdevIUIDatabase

Public Class Config

    Public Shared defaultHome As UserControl
    Public Shared phase As ApplicationPhase
    Shared WithEvents masterEventBroadcaster As EventBroadcaster
    Public Shared Sub init()
        'store to session
        Session.loadDatabaseConfigurationFromRegistry()
        Session.serverberkas = UtilsCore.readFromReg("Server", "ServerBerkas", "\\192.168.10.1\berkasbandara")
        SwdevEufrat.Eufrat.MasterMachineIP = UtilsCore.readFromReg("AutoUpdate", "AutoUpdateServer", "\\192.168.10.1")
        Session.AutoUpdateRole = UtilsCore.readFromReg("AutoUpdate", "Status", "slave")
        Session.StartupPath = Application.StartupPath

        'define the status of this application
        phase = ApplicationPhase.Phase0_Development

        'pages factory, for each different projects
        Pages.m_pageFactoryHash.Add(AssemblyName(), New PassBandaraPageFactory)
        Pages.m_pageFactoryHash.Add("SwdevIUIDatabase", New SwdevIUIDatabasePageFactory)
        Pages.m_pageFactoryHash.Add("MasterModule", New MasterPageFactory)
        Pages.m_pageFactoryHash.Add("TransaksiModule", New TransaksiPageFactory)

        Pages.add("databaseSetting", "SwdevIUIDatabase.DatabaseSettingsPage")
        Pages.add("home", AssemblyName() & ".HomePage")
        Pages.add("login", AssemblyName() & ".LoginPage")
        Pages.add("homeFrontliner", AssemblyName() & ".HomeFrontlinerPage")
        Pages.add("homeAdministrator", AssemblyName() & ".HomeAdministratorPage")
        Pages.add("manajemenPengguna", AssemblyName() & ".ManajemenPengguna")
        Pages.add("homePersetujuan", AssemblyName() & ".HomePersetujuanPage")
        Pages.add("FormSetting", AssemblyName() & ".SettingsPage")
        'report 
        Pages.add("reportPage", "SwdevIUIDatabase.ReportViewerPage")
        registerMaster()
        registerTransaction()
        defaultHome = Pages.Item("home") 'homepage before login
        MainWindow.Text = Application.ProductName & " version " & Application.ProductVersion

    End Sub


    Public Shared Function AssemblyName() As String
        Return System.Reflection.Assembly.GetExecutingAssembly.GetName.Name()
    End Function

    Private Shared Sub masterEventBroadcaster_EnterReportPage(ByVal sender As Object, ByVal e As System.EventArgs) Handles masterEventBroadcaster.EnterReportPage
        MainWindow.enterView(sender)
    End Sub
    Shared Function AsPageEntryTemplate(ByVal key As String) As PageEntryTemplate
        Dim entry As PageEntryTemplate
        entry = Pages.Item(key)
        Return entry
    End Function
    Shared Function AsPageListTemplate(ByVal key As String) As PageListTemplate
        Dim entry As PageListTemplate
        entry = Pages.Item(key)
        Return entry
    End Function
    Private Shared Sub registerMaster()
        'master
        Pages.add("PetugasListPage", "MasterModule.PetugasListPage")
        Pages.add("petugasEntryPage", "MasterModule.PetugasEntryPage")
        AsPageListTemplate("PetugasListPage").isEntryEmbedded = True
        AsPageEntryTemplate("petugasEntryPage").InstancePageListTemplate = Pages.Item("PetugasListPage")

        Pages.add("InstansiListPage", "MasterModule.InstansiListPage")
        Pages.add("instansiEntryPage", "MasterModule.InstansiEntryPage")
        AsPageListTemplate("InstansiListPage").isEntryEmbedded = True
        AsPageEntryTemplate("instansiEntryPage").InstancePageListTemplate = Pages.Item("InstansiListPage")

        'Pages.add("AreaListPage", "MasterModule.AreaListPage")
        'Pages.add("AreaEntryPage", "MasterModule.AreaEntryPage")
        'AsPageListTemplate("AreaListPage").isEntryEmbedded = True
        'AsPageEntryTemplate("AreaEntryPage").InstancePageListTemplate = Pages.Item("AreaListPage")

       
        Pages.add("JabatanListPage", "MasterModule.JabatanListPage")
        Pages.add("JabatanEntryPage", "MasterModule.JabatanEntryPage")
        AsPageListTemplate("JabatanListPage").isEntryEmbedded = True
        AsPageEntryTemplate("JabatanEntryPage").InstancePageListTemplate = Pages.Item("JabatanListPage")

        Pages.add("JenisBerkasListPage", "MasterModule.JenisBerkasListPage")
        Pages.add("JenisBerkasEntryPage", "MasterModule.JenisBerkasEntryPage")
        AsPageListTemplate("JenisBerkasListPage").isEntryEmbedded = True
        AsPageEntryTemplate("JenisBerkasEntryPage").InstancePageListTemplate = Pages.Item("JenisBerkasListPage")

        'Pages.add("KodroleListPage", "MasterModule.KodroleListPage")

        'Pages.add("MenuListPage", "MasterModule.MenuListPage")

        Pages.add("PemohonListPage", "MasterModule.PemohonListPage")
        Pages.add("PemohonEntryPage", "MasterModule.PemohonEntryPage")
        AsPageListTemplate("InstansiListPage").isEntryEmbedded = True
        AsPageEntryTemplate("instansiEntryPage").InstancePageListTemplate = Pages.Item("InstansiListPage")

        'Pages.add("PermohonanListPage", "MasterModule.PermohonanListPage")
        'Pages.add("PermohonanEntryPage", "MasterModule.PermohonanEntryPage")
        'AsPageListTemplate("PermohonanListPage").isEntryEmbedded = True
        'AsPageEntryTemplate("PermohonanEntryPage").InstancePageListTemplate = Pages.Item("PermohonanListPage")

        Pages.add("PersetujuanListPage", "MasterModule.PersetujuanListPage")
        'AsPageListTemplate("PersetujuanListPage").isEntryEmbedded = True
        'AsPageEntryTemplate("PersetujuanEntryPage").InstancePageListTemplate = Pages.Item("PersetujuanListPage")

        Pages.add("PrivilegeListPage", "MasterModule.PrivilegeListPage")
        Pages.add("PrivilegeEntryPage", "MasterModule.PrivilegeEntryPage")
        'AsPageListTemplate("PrivilegeListPage").isEntryEmbedded = True
        'AsPageEntryTemplate("PrivilegeEntryPage").InstancePageListTemplate = Pages.Item("PrivilegeListPage")

        'Pages.add("ProfilListPage", "MasterModule.ProfilListPage")

        Pages.add("ProgressListPage", "MasterModule.ProgressListPage")
        Pages.add("ProgressEntryPage", "MasterModule.ProgressEntryPage")
        AsPageListTemplate("ProgressListPage").isEntryEmbedded = True
        AsPageEntryTemplate("ProgressEntryPage").InstancePageListTemplate = Pages.Item("ProgressListPage")

        Pages.add("PermohonanBundleListPage", "MasterModule.PermohonanBundleListPage")
        Pages.add("PermohonanBundleEntryPage", "MasterModule.PermohonanBundleEntryPage")
        AsPageListTemplate("PermohonanBundleListPage").isEntryEmbedded = True
        AsPageEntryTemplate("PermohonanBundleEntryPage").InstancePageListTemplate = Pages.Item("PermohonanBundleListPage")

        Pages.add("hakAkses", "MasterModule.HakAkses")

        Pages.add("ZLogUserListPage", "MasterModule.ZLogUserListPage")
        '=========================================
    End Sub

    Private Shared Sub registerTransaction()
        'wizard permohonan
        'Pages.add("permohonanWizard", "TransaksiModule.PermohonanWizard")

        ''permohonan lama
        'Pages.add("permohonanTransactionPage", "TransaksiModule.PermohonanTransactionPage")
        'Pages.add("permohonanEntryPage", "TransaksiModule.PermohonanEntryPage")
        'AsPageListTemplate("permohonanTransactionPage").isEntryEmbedded = True
        'AsPageEntryTemplate("permohonanEntryPage").InstancePageListTemplate = Pages.Item("permohonanTransactionPage")

        'report gallery
        Pages.add("reportGallery", "TransaksiModule.ReportGallery")
        Pages.add("settingLaporanKinerja", "TransaksiModule.SettingLaporanKinerja")
        Pages.add("settingLaporanPNBP", "TransaksiModule.SettingLaporanPNBP")
        'permohonan baru
        Pages.add("frontlinerPermohonanPage", "TransaksiModule.FrontlinerPermohonanPage")
        Pages.add("pengaturanAwal", "TransaksiModule.PengaturanAwal")
        Pages.add("pemberkasanPermohonan", "TransaksiModule.PemberkasanPermohonan")
        Pages.add("areaWilayahPermohonan", "TransaksiModule.AreaWilayahPermohonan")
        Pages.add("pembayaranPermohonan", "TransaksiModule.PembayaranPermohonan")
        Pages.add("fotoDanPencetakanPermohonan", "TransaksiModule.FotoDanPencetakanPermohonan")
        Pages.add("statistikPermohonan", "TransaksiModule.StatistikPermohonan")


        Pages.add("hirarkiBrowsing", "TransaksiModule.HirarkiBrowsing")

        'permintaan baru : pengecekan dokumen
        Pages.add("cekStatusDokumen", "TransaksiModule.CekStatusDokumen")


        Pages.add("persetujuanTransactionPage", "TransaksiModule.PersetujuanTransactionPage")
        Pages.add("pemberkasanTransactionPage", "TransaksiModule.PemberkasanTransactionPage")
        Pages.add("antrianTransactionPage", "TransaksiModule.AntrianTransactionPage") 'will be popped up
        Pages.add("pembayaranTransactionPage", "TransaksiModule.PembayaranTransactionPage")
        Pages.add("pembayaranEntryPage", "TransaksiModule.PembayaranEntryPage")
        Pages.add("pencetakanIDPage", "TransaksiModule.PencetakanIDPage")
        Pages.add("persetujuanFlowDisplayPage", "TransaksiModule.PersetujuanFlowDisplayPage")
        Pages.add("pencetakanPassTransactionPage", "TransaksiModule.PencetakanPassTransactionPage")
        Pages.add("formPassPage", "TransaksiModule.FormPassPage")

    End Sub


End Class
