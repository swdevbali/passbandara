Imports SwdevIUICore

Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        'Timer1_Tick(Nothing, Nothing)
    End Sub
    Dim countDown As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        countDown = countDown + 1
        If countDown = 1 Then
            lblProgress.Text = "Inisialisasi aplikasi..."
            MainWindow.globalInit()
        ElseIf countDown = 2 Then
            lblProgress.Text = "Inisialisasi konfigurasi basis data.."
            Config.init()
        ElseIf countDown = 3 Then

            lblProgress.Text = "Memeriksa AutoUpdate.."
        ElseIf countDown = 4 Then
            Timer1.Enabled = False
            MainWindow.checkAutoUpdate()
        ElseIf countDown = 5 Then
            lblProgress.Text = "Memeriksa status server basis data.."
            MainWindow.checkDatabaseStatus()
            'TODO : warning kalau database offline, but u/ sekarang tidak perlu dulu
        ElseIf countDown = 6 Then
            lblProgress.Text = "Inisialisasi selesai."
        ElseIf countDown = 7 Then
            MainWindow.Show()
            MainWindow.enterView(Pages.Item("home"))
            Timer1.Enabled = False
            Close()
        End If
    End Sub
End Class
