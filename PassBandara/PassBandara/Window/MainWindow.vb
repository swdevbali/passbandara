Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports PassBandara.WinApi
Imports System.Drawing


Imports SwdevIUIDatabase
Imports SwdevIUICore
Imports SwdevEufrat

Public Class MainWindow

#Region "Zune Window"
#Region "Fields"
    Private dwmMargins As Dwm.MARGINS
    Private _marginOk As Boolean
    Private _aeroEnabled As Boolean = False
#End Region
#Region "Ctor"
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        InitializeComponent()

        DoubleBuffered = True

        'lblTitle.Text = Application.ProductName
        tabHeader.setCloseButton(closeButton)

    End Sub
#End Region
#Region "Props"
    Public ReadOnly Property AeroEnabled() As Boolean
        Get
            Return _aeroEnabled
        End Get
    End Property
#End Region
#Region "Methods"
    Public Shared Function LoWord(ByVal dwValue As Integer) As Integer
        Return dwValue And &HFFFF
    End Function
    ''' <summary>
    ''' Equivalent to the HiWord C Macro
    ''' </summary>
    ''' <param name="dwValue"></param>
    ''' <returns></returns>
    Public Shared Function HiWord(ByVal dwValue As Integer) As Integer
        Return (dwValue >> 16) And &HFFFF
    End Function


    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dwm.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
    End Sub

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        Dim WM_NCCALCSIZE As Integer = &H83
        Dim WM_NCHITTEST As Integer = &H84
        Dim result As IntPtr

        Dim dwmHandled As Integer = Dwm.DwmDefWindowProc(m.HWnd, m.Msg, m.WParam, m.LParam, result)

        If dwmHandled = 1 Then
            m.Result = result
            Exit Sub
        End If

        If m.Msg = WM_NCCALCSIZE AndAlso CInt(m.WParam) = 1 Then
            Dim nccsp As NCCALCSIZE_PARAMS = _
              DirectCast(Marshal.PtrToStructure(m.LParam, _
              GetType(NCCALCSIZE_PARAMS)), NCCALCSIZE_PARAMS)

            ' Adjust (shrink) the client rectangle to accommodate the border:
            nccsp.rect0.Top += 0
            nccsp.rect0.Bottom += 0
            nccsp.rect0.Left += 0
            nccsp.rect0.Right += 0

            If Not _marginOk Then
                'Set what client area would be for passing to DwmExtendIntoClientArea. Also remember that at least one of these values NEEDS TO BE > 1, else it won't work.
                dwmMargins.cyTopHeight = 0
                dwmMargins.cxLeftWidth = 0
                dwmMargins.cyBottomHeight = 3
                dwmMargins.cxRightWidth = 0
                _marginOk = True
            End If

            Marshal.StructureToPtr(nccsp, m.LParam, False)

            m.Result = IntPtr.Zero
        ElseIf m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = 0 Then
            m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam)
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Private Function HitTestNCA(ByVal hwnd As IntPtr, ByVal wparam _
                                      As IntPtr, ByVal lparam As IntPtr) As IntPtr
        Dim HTNOWHERE As Integer = 0
        Dim HTCLIENT As Integer = 1
        Dim HTCAPTION As Integer = 2
        Dim HTGROWBOX As Integer = 4
        Dim HTSIZE As Integer = HTGROWBOX
        Dim HTMINBUTTON As Integer = 8
        Dim HTMAXBUTTON As Integer = 9
        Dim HTLEFT As Integer = 10
        Dim HTRIGHT As Integer = 11
        Dim HTTOP As Integer = 12
        Dim HTTOPLEFT As Integer = 13
        Dim HTTOPRIGHT As Integer = 14
        Dim HTBOTTOM As Integer = 15
        Dim HTBOTTOMLEFT As Integer = 16
        Dim HTBOTTOMRIGHT As Integer = 17
        Dim HTREDUCE As Integer = HTMINBUTTON
        Dim HTZOOM As Integer = HTMAXBUTTON
        Dim HTSIZEFIRST As Integer = HTLEFT
        Dim HTSIZELAST As Integer = HTBOTTOMRIGHT

        Dim p As New Point(LoWord(CInt(lparam)), HiWord(CInt(lparam)))

        Dim topleft As Rectangle = RectangleToScreen(New Rectangle(0, 0, _
                                   dwmMargins.cxLeftWidth, dwmMargins.cxLeftWidth))

        If topleft.Contains(p) Then
            Return New IntPtr(HTTOPLEFT)
        End If

        Dim topright As Rectangle = _
          RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, 0, _
          dwmMargins.cxRightWidth, dwmMargins.cxRightWidth))

        If topright.Contains(p) Then
            Return New IntPtr(HTTOPRIGHT)
        End If

        Dim botleft As Rectangle = _
           RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
           dwmMargins.cxLeftWidth, dwmMargins.cyBottomHeight))

        If botleft.Contains(p) Then
            Return New IntPtr(HTBOTTOMLEFT)
        End If

        Dim botright As Rectangle = _
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
            Height - dwmMargins.cyBottomHeight, _
            dwmMargins.cxRightWidth, dwmMargins.cyBottomHeight))

        If botright.Contains(p) Then
            Return New IntPtr(HTBOTTOMRIGHT)
        End If

        Dim top As Rectangle = _
            RectangleToScreen(New Rectangle(0, 0, Width, dwmMargins.cxLeftWidth))

        If top.Contains(p) Then
            Return New IntPtr(HTTOP)
        End If

        Dim cap As Rectangle = _
            RectangleToScreen(New Rectangle(0, dwmMargins.cxLeftWidth, _
            Width, dwmMargins.cyTopHeight - dwmMargins.cxLeftWidth))

        If cap.Contains(p) Then
            Return New IntPtr(HTCAPTION)
        End If

        Dim left As Rectangle = _
            RectangleToScreen(New Rectangle(0, 0, dwmMargins.cxLeftWidth, Height))

        If left.Contains(p) Then
            Return New IntPtr(HTLEFT)
        End If

        Dim right As Rectangle = _
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
            0, dwmMargins.cxRightWidth, Height))

        If right.Contains(p) Then
            Return New IntPtr(HTRIGHT)
        End If

        Dim bottom As Rectangle = _
            RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
            Width, dwmMargins.cyBottomHeight))

        If bottom.Contains(p) Then
            Return New IntPtr(HTBOTTOM)
        End If

        Return New IntPtr(HTCLIENT)
    End Function

    Private Const BorderWidth As Integer = 6

    Private _resizeDir As ResizeDirection = ResizeDirection.None



    Public Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Width - BorderWidth > e.Location.X AndAlso e.Location.X > BorderWidth AndAlso e.Location.Y > BorderWidth Then
                MoveControl(Me.Handle)
            Else
                If Me.WindowState <> FormWindowState.Maximized Then
                    ResizeForm(resizeDir)
                End If
            End If
        End If
    End Sub

    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 4
        TopRight = 8
        Right = 16
        BottomRight = 32
        Bottom = 64
        BottomLeft = 128
    End Enum

    Private Property resizeDir() As ResizeDirection
        Get
            Return _resizeDir
        End Get
        Set(ByVal value As ResizeDirection)
            _resizeDir = value

            'Change cursor
            Select Case value
                Case ResizeDirection.Left
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Right
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Top
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.Bottom
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.BottomLeft
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.TopRight
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.BottomRight
                    Me.Cursor = Cursors.SizeNWSE

                Case ResizeDirection.TopLeft
                    Me.Cursor = Cursors.SizeNWSE

                Case Else
                    Me.Cursor = Cursors.Default
            End Select
        End Set
    End Property

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Calculate which direction to resize based on mouse position

        If e.Location.X < BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopLeft

        ElseIf e.Location.X < BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomLeft

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomRight

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopRight

        ElseIf e.Location.X < BorderWidth Then
            resizeDir = ResizeDirection.Left

        ElseIf e.Location.X > Me.Width - BorderWidth Then
            resizeDir = ResizeDirection.Right

        ElseIf e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.Top

        ElseIf e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.Bottom

        Else
            resizeDir = ResizeDirection.None
        End If
    End Sub

    Private Sub MoveControl(ByVal hWnd As IntPtr)
        ReleaseCapture()
        SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub ResizeForm(ByVal direction As ResizeDirection)
        Dim dir As Integer = -1
        Select Case direction
            Case ResizeDirection.Left
                dir = HTLEFT
            Case ResizeDirection.TopLeft
                dir = HTTOPLEFT
            Case ResizeDirection.Top
                dir = HTTOP
            Case ResizeDirection.TopRight
                dir = HTTOPRIGHT
            Case ResizeDirection.Right
                dir = HTRIGHT
            Case ResizeDirection.BottomRight
                dir = HTBOTTOMRIGHT
            Case ResizeDirection.Bottom
                dir = HTBOTTOM
            Case ResizeDirection.BottomLeft
                dir = HTBOTTOMLEFT
        End Select

        If dir <> -1 Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, dir, 0)
        End If

    End Sub

    <DllImport("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14
#End Region
#End Region


#Region "MS Inductive User Interface"
    Public history As New ArrayList
    Dim currentView As PageTemplate = Nothing
    Dim iCurrentView As Integer = 0


    Private Sub MainWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SplashScreen.Show()
        'globalInit()
        'Config.init()
        'checkAutoUpdate()
        'SplashScreen.Close()
        'checkDatabaseStatus()
        'enterView(Pages.Item("home"))
    End Sub

    'Public Sub initMenu()
    '    'file
    '    Dim mnuFile As FlatMenuItem = New FlatMenuItem
    '    mnuFile.Text = "File"
    '    Dim mnuExit As FlatMenuItem = New FlatMenuItem
    '    mnuExit.Text = "Exit"
    '    AddHandler mnuExit.Click, AddressOf doExit
    '    mnuFile.MenuItems.Add(mnuExit)
    '    flatMenu.MenuItems.Add(mnuFile)

    '    'go
    '    Dim mnuGo As FlatMenuItem = New FlatMenuItem
    '    mnuGo.Text = "Go"
    '    Dim mnuBack As FlatMenuItem = New FlatMenuItem
    '    mnuBack.Text = "Back"
    '    AddHandler mnuBack.Click, AddressOf btnPrev_Click
    '    mnuGo.MenuItems.Add(mnuBack)
    '    Dim mnuForward As FlatMenuItem = New FlatMenuItem
    '    mnuForward.Text = "Forward"
    '    AddHandler mnuForward.Click, AddressOf btnNext_Click
    '    mnuGo.MenuItems.Add(mnuForward)
    '    mnuGo.MenuItems.AddSeparator()
    '    Dim mnuHome As FlatMenuItem = New FlatMenuItem
    '    mnuHome.Text = "Home"
    '    AddHandler mnuHome.Click, AddressOf btnHome_Click
    '    mnuGo.MenuItems.Add(mnuHome)
    '    flatMenu.MenuItems.Add(mnuGo)

    '    'help
    '    Dim mnuHelp As FlatMenuItem = New FlatMenuItem
    '    mnuHelp.Text = "Help"
    '    Dim mnuAbout As FlatMenuItem = New FlatMenuItem
    '    mnuAbout.Text = "About"
    '    AddHandler mnuAbout.Click, AddressOf doAbout
    '    mnuHelp.MenuItems.Add(mnuAbout)
    '    flatMenu.MenuItems.Add(mnuHelp)
    'End Sub
    Private Sub linkMinimize_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub linkMax_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMax.LinkClicked
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub linkClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        End
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
            btnMaximize.Text = "Max"
        Else
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.Text = "Restore"
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
    'Public Sub CloseTab(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
    '    If e.KeyCode = Keys.Escape Then
    '        Dim pnl As TabPage = sender
    '        tabUtama.TabPages.Remove(pnl)
    '    End If
    'End Sub
    Public Sub enterView(ByVal view As PageTemplate, Optional ByVal skipHistory As Boolean = False)
        'save current view to stack, so that we can navigate back to this view
        If Not currentView Is Nothing Then
            history.Add(currentView)
        End If

        If Not view Is Nothing Then
            view.Refresh() 'knapa ini direfresh??? dafuq?
            view.OnEnterView()
            pnlUtama.Controls.Clear()
            pnlUtama.Controls.Add(view)


            view.AutoScroll = True
            view.Dock = DockStyle.Fill
            view.BorderStyle = BorderStyle.None
            AddHandler view.MouseDown, AddressOf Form1_MouseDown
            currentView = view

            tabHeader.add(view)
            tabHeader.selectTab(view)

            If Not skipHistory Then 'skip if we come to this view using navigational button
                history.Add(view) 'this way, currentView is added to list
                iCurrentView = history.Count - 1

            End If
        End If
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        Form1_MouseDown(sender, e)
    End Sub


    Public Sub logout()
        If MessageBox.Show("Anda yakin akan logout?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            lblUsername.Text = ""
            Session.isLoggedIn = False
            'Main.defaultHome = Pages.home
            'TODO : clear additional items here
            history.Clear()
            tabHeader.clearNode()
            enterView(Pages.Item("home"))
        End If
    End Sub


    Private Sub doExit()
        End
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If iCurrentView > 0 Then
            iCurrentView = iCurrentView - 1
            enterView(history(iCurrentView), True)
            tabHeader.goBack()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If iCurrentView < history.Count - 1 Then
            iCurrentView = iCurrentView + 1
            enterView(history(iCurrentView), True)
        End If
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        setFirstNavigation(Config.defaultHome)
    End Sub

    Public Sub doAbout()
        AboutBox.ShowDialog()
    End Sub

    Public Sub setFirstNavigation(ByRef page As PageTemplate)
        history.Clear()
        tabHeader.clearNode()
        createActivities(page)
        enterView(page)

        Config.defaultHome = page
    End Sub

    Private Sub createActivities(ByRef page As PageTemplate)
        Dim dtmenu As New DataTable
        Dim groups As Hashtable = New Hashtable
        If page.lvPageActivities IsNot Nothing Then page.lvPageActivities.Items.Clear()
        If Utils.executeSP("proc_z_getrolemenu", New Object() {"role", Session.kodeRole}, dtmenu) Then
            If dtmenu.Rows.Count > 0 Then
                If page.lvPageActivities IsNot Nothing Then
                    'page.lvPageActivities.View = View.SmallIcon 'defaulted, change to user saved
                    page.lvPageActivities.HoverSelection = True
                    page.lvPageActivities.HotTracking = True
                    page.lvPageActivities.Activation = ItemActivation.OneClick
                    page.lvPageActivities.Groups.Clear()
                    AddHandler page.lvPageActivities.ItemActivate, AddressOf activateActivity

                End If
                For Each row As DataRow In dtmenu.Rows
                    If IsDBNull(row("header")) Then
                        If page.lvPageActivities IsNot Nothing Then
                            Dim group As ListViewGroup = New ListViewGroup(row("menuname"))
                            page.lvPageActivities.Groups.Add(group)
                            groups.Add("" & row("menuid"), group)
                        End If
                    Else
                        If page.lvPageActivities IsNot Nothing Then
                            Dim item As ListViewItem = page.lvPageActivities.Items.Add(row("menuname"), CInt(row("imageid")))
                            Dim groupId As String = row("menuid")
                            groupId = groupId.Substring(0, 1)
                            item.Tag = row("formname")
                            item.Group = groups(groupId)
                            item.SubItems.Add(row("description"))


                            'End If
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub activateActivity(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If currentView.lvPageActivities IsNot Nothing Then
            Dim item As ListViewItem = currentView.lvPageActivities.SelectedItems(0)

            If Pages.Item(item.Tag) Is Nothing Then
                MsgBox("Application Error : no page defined for action : " & item.Tag)
            Else
                enterView(Pages.Item(item.Tag))
            End If
        End If
    End Sub
    'learnt from http://stackoverflow.com/questions/2594608/asp-net-vb-user-control-raising-an-event-on-the-calling-page
    Private Sub breadCumb_EnterPage(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim page As PageTemplate = sender
        enterView(page, True)
    End Sub
#End Region

#Region "Database Application Specific"

    Public Sub checkDatabaseStatus()
        If Utils.isConnected() Then
            picDatabaseStatus.Image = My.Resources.database_up
            lblDatabaseStatus.Text = Session.dbname & "@" & Session.dbhost
        Else
            If Session.dbname = "" Then
                lblDatabaseStatus.Text = "<NOT DEFINED YET>@" & Session.dbhost
            Else
                lblDatabaseStatus.Text = Session.dbname & "@" & Session.dbhost
            End If
            picDatabaseStatus.Image = My.Resources.database_down
        End If


    End Sub


    Private Sub lblDatabaseStatus_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblDatabaseStatus.LinkClicked
        enterView(Pages.Item("databaseSetting"))
    End Sub
#End Region


    Private Sub breadCumb_EnterPage(ByVal page As SwdevIUICore.PageTemplate, ByVal eventArgs As System.EventArgs) Handles tabHeader.EnterPage
        enterView(page, True)
    End Sub


    Private Sub tabHeader_EnterHomePage() Handles tabHeader.EnterHomePage
        enterView(Config.defaultHome)
    End Sub

    Private Sub DoEnterReportPage(ByVal sender As Object, ByVal e As EventArgs)
        Dim page As PageTemplate = sender
        enterView(page)
    End Sub

    Private Sub DoSettingsChange(ByVal sender As Object, ByVal e As EventArgs)
        'lets care about the server berkas here
        'My.Settings.serverberkas = Session.serverberkas
        'My.Settings.Save()

    End Sub

    Private Sub CloseApplication(ByVal sender As Object, ByVal e As EventArgs)
        End
    End Sub

    Public Sub checkAutoUpdate()
        Eufrat.MasterMachineIP = UtilsCore.readFromReg("AutoUpdate", "AutoUpdateServer", "\\192.168.10.1")
        'hanya slave yang mengecek setiap startup, master akan diupdate via internet secara manual
        If Session.AutoUpdateRole.Equals("slave") Then
            If Not Eufrat.autoUpdateServerOnline() Then
                SplashScreen.Timer1.Enabled = True
                Return
            End If

            If Not Eufrat.isApplicationNewest() Then
                Me.Hide()
                SplashScreen.Hide()
                BringToFront()
                If MessageBox.Show("Versi terbaru aplikasi ini tersedia. Apakah Anda akan mengupdate aplikasi ini?", "Airport Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Hide()
                    Eufrat.doAutoUpdate()
                Else
                    SplashScreen.Timer1.Enabled = True
                    'Show()
                End If
            Else
                SplashScreen.Timer1.Enabled = True
            End If
        Else
            SplashScreen.Timer1.Enabled = True
        End If
    End Sub

    Public Sub globalInit()
        lblUsername.Text = ""
        AddHandler EventBroadcaster.EnterDatabaseStatusChange, AddressOf checkDatabaseStatus
        AddHandler EventBroadcaster.EnterReportPage, AddressOf DoEnterReportPage 'handle broadcast event
        AddHandler EventBroadcaster.SettingsChange, AddressOf DoSettingsChange
        AddHandler EventBroadcaster.CloseApplication, AddressOf CloseApplication
        Text = Application.ProductName & " version " & Application.ProductVersion
        Session.applicationName = Application.ProductName
    End Sub

End Class