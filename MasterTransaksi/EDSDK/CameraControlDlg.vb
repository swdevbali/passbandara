'/******************************************************************************
'*                                                                             *
'*   PROJECT : EOS Digital Software Development Kit EDSDK                      *
'*      NAME : CameraController.vb                                             *
'*                                                                             *
'*   Description: This is the Sample code to show the usage of EDSDK.          *
'*                                                                             *
'*                                                                             *
'*******************************************************************************
'*                                                                             *
'*   Written and developed by Camera Design Dept.53                            *
'*   Copyright Canon Inc. 2006 All Rights Reserved                             *
'*                                                                             *
'*******************************************************************************
'*   File Update Information:                                                  *
'*     DATE      Identify    Comment                                           *
'*   -----------------------------------------------------------------------   *
'*   06-03-22    F-001        create first version.                            *
'*                                                                             *
'******************************************************************************/

Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing
Imports SwdevIUICore

Public Class CameraControlDlg
    Inherits System.Windows.Forms.Form
    Implements Observer

#Region "Created by Windows form designer."

    Dim Buffer As Byte()

    Public Sub New()
        MyBase.New()

        InitializeComponent()


    End Sub

    Private Property _Buffer As Object

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TakeBtn As System.Windows.Forms.Button
    Friend WithEvents ISOSpeedCmb As System.Windows.Forms.ComboBox
    Friend WithEvents AvCmb As System.Windows.Forms.ComboBox
    Friend WithEvents TvCmb As System.Windows.Forms.ComboBox
    Private WithEvents AEModeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents MeteringModeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExposureCompCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImageQualityCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnLiveView As System.Windows.Forms.Button
    Friend WithEvents picLiveView As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnTakePicture As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CameraControlDlg))
        Me.TakeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AEModeCmb = New System.Windows.Forms.ComboBox()
        Me.ISOSpeedCmb = New System.Windows.Forms.ComboBox()
        Me.AvCmb = New System.Windows.Forms.ComboBox()
        Me.TvCmb = New System.Windows.Forms.ComboBox()
        Me.MeteringModeCmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExposureCompCmb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.ImageQualityCmb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLiveView = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTakePicture = New System.Windows.Forms.Button()
        Me.picLiveView = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLiveView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TakeBtn
        '
        Me.TakeBtn.Location = New System.Drawing.Point(1140, 167)
        Me.TakeBtn.Name = "TakeBtn"
        Me.TakeBtn.Size = New System.Drawing.Size(96, 52)
        Me.TakeBtn.TabIndex = 0
        Me.TakeBtn.Text = "Take Picture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(855, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AE Mode:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(855, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ISO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(855, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Av:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(855, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tv:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'AEModeCmb
        '
        Me.AEModeCmb.Location = New System.Drawing.Point(958, 24)
        Me.AEModeCmb.Name = "AEModeCmb"
        Me.AEModeCmb.Size = New System.Drawing.Size(166, 21)
        Me.AEModeCmb.TabIndex = 11
        Me.AEModeCmb.Visible = False
        '
        'ISOSpeedCmb
        '
        Me.ISOSpeedCmb.Location = New System.Drawing.Point(958, 128)
        Me.ISOSpeedCmb.Name = "ISOSpeedCmb"
        Me.ISOSpeedCmb.Size = New System.Drawing.Size(166, 21)
        Me.ISOSpeedCmb.TabIndex = 12
        Me.ISOSpeedCmb.Visible = False
        '
        'AvCmb
        '
        Me.AvCmb.Location = New System.Drawing.Point(958, 94)
        Me.AvCmb.Name = "AvCmb"
        Me.AvCmb.Size = New System.Drawing.Size(166, 21)
        Me.AvCmb.TabIndex = 14
        Me.AvCmb.Visible = False
        '
        'TvCmb
        '
        Me.TvCmb.Location = New System.Drawing.Point(958, 59)
        Me.TvCmb.Name = "TvCmb"
        Me.TvCmb.Size = New System.Drawing.Size(166, 21)
        Me.TvCmb.TabIndex = 15
        Me.TvCmb.Visible = False
        '
        'MeteringModeCmb
        '
        Me.MeteringModeCmb.Location = New System.Drawing.Point(958, 162)
        Me.MeteringModeCmb.Name = "MeteringModeCmb"
        Me.MeteringModeCmb.Size = New System.Drawing.Size(166, 21)
        Me.MeteringModeCmb.TabIndex = 17
        Me.MeteringModeCmb.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(855, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Metering Mode:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'ExposureCompCmb
        '
        Me.ExposureCompCmb.Location = New System.Drawing.Point(958, 198)
        Me.ExposureCompCmb.Name = "ExposureCompCmb"
        Me.ExposureCompCmb.Size = New System.Drawing.Size(166, 21)
        Me.ExposureCompCmb.TabIndex = 19
        Me.ExposureCompCmb.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(855, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Exposure Comp:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(1156, 24)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(80, 35)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "Quit"
        Me.ExitBtn.Visible = False
        '
        'InfoTextBox
        '
        Me.InfoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.InfoTextBox.Location = New System.Drawing.Point(855, 274)
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.Size = New System.Drawing.Size(381, 20)
        Me.InfoTextBox.TabIndex = 20
        Me.InfoTextBox.Text = "Info"
        Me.InfoTextBox.Visible = False
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(1140, 240)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(96, 17)
        Me.progressBar.TabIndex = 21
        '
        'ImageQualityCmb
        '
        Me.ImageQualityCmb.Location = New System.Drawing.Point(958, 236)
        Me.ImageQualityCmb.Name = "ImageQualityCmb"
        Me.ImageQualityCmb.Size = New System.Drawing.Size(166, 21)
        Me.ImageQualityCmb.TabIndex = 22
        Me.ImageQualityCmb.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(855, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ImageQuality:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'btnLiveView
        '
        Me.btnLiveView.Location = New System.Drawing.Point(12, 12)
        Me.btnLiveView.Name = "btnLiveView"
        Me.btnLiveView.Size = New System.Drawing.Size(96, 25)
        Me.btnLiveView.TabIndex = 24
        Me.btnLiveView.Text = "Live View"
        '
        'Timer1
        '
        '
        'btnTakePicture
        '
        Me.btnTakePicture.Location = New System.Drawing.Point(114, 12)
        Me.btnTakePicture.Name = "btnTakePicture"
        Me.btnTakePicture.Size = New System.Drawing.Size(96, 25)
        Me.btnTakePicture.TabIndex = 26
        Me.btnTakePicture.Text = "Take Picture"
        '
        'picLiveView
        '
        Me.picLiveView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLiveView.Location = New System.Drawing.Point(12, 43)
        Me.picLiveView.Name = "picLiveView"
        Me.picLiveView.Size = New System.Drawing.Size(365, 217)
        Me.picLiveView.TabIndex = 25
        Me.picLiveView.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1246, 236)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'CameraControlDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(403, 272)
        Me.Controls.Add(Me.picLiveView)
        Me.Controls.Add(Me.btnTakePicture)
        Me.Controls.Add(Me.btnLiveView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ImageQualityCmb)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.InfoTextBox)
        Me.Controls.Add(Me.ExposureCompCmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MeteringModeCmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TvCmb)
        Me.Controls.Add(Me.AvCmb)
        Me.Controls.Add(Me.ISOSpeedCmb)
        Me.Controls.Add(Me.AEModeCmb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.TakeBtn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CameraControlDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camera Canon 500D"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLiveView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "User defined attributes"

    ' Save as class variable, new delegates of event handlers.
    Public inPropertyEventHandler As New  _
                EdsPropertyEventHandler(AddressOf CameraEventListener.handlePropertyEvent)
    Public inObjectEventHandler As New  _
                EdsObjectEventHandler(AddressOf CameraEventListener.handleObjectEvent)
    Public inStateEventHandler As New  _
                EdsStateEventHandler(AddressOf CameraEventListener.handleStateEvent)
    '
    Public Shared controller As CameraController
    Public Shared model As CameraModel
    Public Shared m_cmbTbl As Hashtable = New Hashtable



#End Region

    Dim t As Thread
    Delegate Sub UpdateDelegate( _
        ByVal from As Observable, _
        ByVal msg As Integer, _
        ByVal data As Integer)

    Sub UpdateWindow(ByVal from As Observable, ByVal msg As Integer, ByVal data As Integer) _
        Implements Observer.update

        'Get the name of this thread.
        Dim threadName As String = _
        System.Threading.Thread.CurrentThread.Name()

        '// Make this form be able to be updated by other thread.
        If InvokeRequired Then
            'Create UpdateDelegate
            Dim dlg As New UpdateDelegate(AddressOf UpdateWindow)
            Try
                BeginInvoke(dlg, New Object() {from, msg, data})
            Catch e As Exception
                Return
            Finally
            End Try
            Return
        End If



        Select Case msg
            Case prog '//Progress of image downloading .
                progressBar.Value = data

            Case strt '// Start downloading.
                '//_progress.SetPos(0);

            Case cplt '// Complete downloading.
                progressBar.Value = 0

            Case updt '// Update properties.
                Dim propertyID As Integer = data
                Dim propData As Integer = model.getPropertyUInt32(propertyID)
                UpdateProperty(propertyID, propData)

            Case upls '// Update an available property list.
                Dim propertyID As Integer = data
                Dim desc As EdsPropertyDesc = model.getPropertyDesc(propertyID)
                UpdatePropertyDesc(propertyID, desc)

            Case warn '// Warning
                InfoTextBox.Text = "Device Busy"

            Case errr '// Error
                '// Nothing to do because the first getting property from model 30D is sure to fail. 
                Dim ss As String
                ss = String.Format("%x", data)
                InfoTextBox.Text = ss

            Case clse '// Close
                TakeBtn.Enabled = False
                progressBar.Enabled = False
                InfoTextBox.Enabled = False
                AEModeCmb.Enabled = False
                TvCmb.Enabled = False
                AvCmb.Enabled = False
                ISOSpeedCmb.Enabled = False

        End Select

        If msg <> errr And msg <> warn Then
            InfoTextBox.Text = ""
        End If


    End Sub



    Sub UpdateProperty(ByVal propertyID As Integer, ByVal data As Integer)
        'Dim propList As Hashtable = CameraProperty.g_PropList.Item(propertyID)
        'Select Case propertyID
        '    Case kEdsPropID_AEMode
        '        AEModeCmb.Text = propList.Item(data)
        '    Case kEdsPropID_ISOSpeed
        '        ISOSpeedCmb.Text = propList.Item(data)
        '    Case kEdsPropID_MeteringMode
        '        MeteringModeCmb.Text = propList.Item(data)
        '    Case kEdsPropID_Av
        '        AvCmb.Text = propList.Item(data)
        '    Case kEdsPropID_Tv
        '        TvCmb.Text = propList.Item(data)
        '    Case kEdsPropID_ExposureCompensation
        '        ExposureCompCmb.Text = propList.Item(data)
        '    Case kEdsPropID_ImageQuality
        '        ImageQualityCmb.Text = propList.Item(data)
        'End Select

    End Sub



    Sub UpdatePropertyDesc(ByVal propertyID As Integer, ByVal desc As EdsPropertyDesc)
        Dim err As Integer
        Dim iCnt As Integer
        Dim cmb As ComboBox = m_cmbTbl.Item(propertyID)
        Dim propList As Hashtable = CameraProperty.g_PropList.Item(propertyID)
        Dim propStr As String
        Dim propValueList As ArrayList = New ArrayList

        If cmb Is Nothing Then
            Return
        End If

        cmb.BeginUpdate()
        cmb.Items.Clear()
        For iCnt = 0 To desc.numElements - 1
            propStr = propList(desc.propDesc(iCnt))
            If propStr <> Nothing Then
                err = cmb.Items.Add(propStr)
                propValueList.Add(desc.propDesc(iCnt))
            End If
        Next

        cmb.Tag = propValueList ' Set the property value list

        cmb.EndUpdate()
        If cmb.Items.Count = 0 Then
            cmb.Enabled = False '// No available item.
        Else
            cmb.Enabled = True
        End If

    End Sub



    Public Function cameraModelFactory(ByVal camera As IntPtr, ByVal deviceInfo As EdsDeviceInfo) As CameraModel

        ' if Legacy protocol.
        If deviceInfo.DeviceSubType = 0 Then
            Return New CameraModelLegacy(camera)
        End If

        ' PTP protocol.
        Return New CameraModel(camera)

    End Function



#Region "Window Events"
    Private Sub TakeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeBtn.Click
        '
        ' Release button
        '
        controller.actionPerformed("takepicture")

    End Sub



    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        ' Quit button
        Me.Close()

        'End
    End Sub

#End Region


    Private Sub VBSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim err As Integer = EDS_ERR_OK
        Dim cameraList As IntPtr = Nothing
        Dim camera As IntPtr = Nothing
        Dim count As Integer = 0
        Dim isSDKLoaded As Boolean = False
        Dim propObj As New CameraProperty

        ' connect property id to combobox. 
        'm_cmbTbl.Add(kEdsPropID_AEMode, Me.AEModeCmb)
        'm_cmbTbl.Add(kEdsPropID_ISOSpeed, Me.ISOSpeedCmb)
        'm_cmbTbl.Add(kEdsPropID_Av, Me.AvCmb)
        'm_cmbTbl.Add(kEdsPropID_Tv, Me.TvCmb)
        'm_cmbTbl.Add(kEdsPropID_MeteringMode, Me.MeteringModeCmb)
        'm_cmbTbl.Add(kEdsPropID_ExposureCompensation, Me.ExposureCompCmb)
        'm_cmbTbl.Add(kEdsPropID_ImageQuality, Me.ImageQualityCmb)

        Try
            err = EdsInitializeSDK()
        Catch ex As Exception

            MsgBox("Tidak bisa menginisialisasi kamera")
            Return
        End Try

        If err = EDS_ERR_OK Then

            isSDKLoaded = True

        End If

        If err = EDS_ERR_OK Then

            err = EdsGetCameraList(cameraList)

        End If


        If err = EDS_ERR_OK Then

            err = EdsGetChildCount(cameraList, count)
            If count = 0 Then
                err = EDS_ERR_DEVICE_NOT_FOUND
            End If

        End If

        '// Get the first camera.
        If err = EDS_ERR_OK Then

            err = EdsGetChildAtIndex(cameraList, 0, camera)

        End If


        Dim deviceInfo As EdsDeviceInfo = Nothing

        If err = EDS_ERR_OK Then

            err = EdsGetDeviceInfo(camera, deviceInfo)

            If err = EDS_ERR_OK And IsNothing(camera) = True Then
                err = EDS_ERR_DEVICE_NOT_FOUND
            End If

        End If


        If IsNothing(cameraList) = False Then

            EdsRelease(cameraList)

        End If


        '// Create the camera model 
        If err = EDS_ERR_OK Then

            model = cameraModelFactory(camera, deviceInfo)

            If IsNothing(model) = True Then
                err = EDS_ERR_DEVICE_NOT_FOUND

            End If
        End If


        If err <> EDS_ERR_OK Then

            MessageBox.Show("Cannot detect camera")
            Exit Sub

        End If



        If err = EDS_ERR_OK Then

            '// Create a controller
            controller = New CameraController

            '// Set the model to this controller.
            controller.setCameraModel(model)

            '// Make notify the model updating to the view.
            model.addObserver(Me)

            ' ------------------------------------------------------------------------
            ' ------------------------------------------------------------------------
            ' You should create class instance of delegates of event handlers 
            ' with 'new' expressly if its attribute is Shared, 
            ' because System sometimes do garbage-collect these delegates.
            '
            '
            ' This error occurs.
            '
            ' CallbackOnCollectedDelegate is detected.
            ' Message: Callback was called with
            ' garbage-collected delegate of  
            ' Type() 'VBSample3!VBSample3.EDSDKTypes+EdsPropertyEventHandler::Invoke' 
            ' 
            ' It will be able to make data loss or application clash.
            ' You should stock delegates when you want to send delegate to unmanaged code.
            '
            ' ------------------------------------------------------------------------
            If err = EDS_ERR_OK Then

                err = EdsSetPropertyEventHandler(camera, kEdsPropertyEvent_All, _
                        inPropertyEventHandler, IntPtr.Zero)
            End If

            '// Set ObjectEventHandler
            If err = EDS_ERR_OK Then
                err = EdsSetObjectEventHandler(camera, kEdsObjectEvent_All, _
                    inObjectEventHandler, IntPtr.Zero)

            End If

            '// Set StateEventHandler
            If err = EDS_ERR_OK Then
                err = EdsSetCameraStateEventHandler(camera, kEdsStateEvent_All, _
                    inStateEventHandler, IntPtr.Zero)
            End If

        End If



        If err <> EDS_ERR_OK Then

            If IsNothing(camera) = False Then
                EdsRelease(camera)
                camera = Nothing
            End If

            If (isSDKLoaded) Then
                EdsTerminateSDK()
            End If

            If IsNothing(model) = False Then
                model = Nothing
            End If


            If IsNothing(controller) = False Then
                controller = Nothing
            End If


            'End

        End If



        '//Execute the controller.
        If controller IsNot Nothing Then controller.run()

        p = Pages.Item("pencetakanPassTransactionPage")

        'get image
        'picLiveView.Image = Image.FromFile("C:\eko.jpg")
    End Sub

    Private Sub VBSample_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If controller IsNot Nothing Then controller.actionPerformed("close")

        If Not IsNothing(model) Then
            If IsNothing(model.getCameraObject()) = False Then
                EdsRelease(model.getCameraObject())
            End If
        End If
        Try
            EdsTerminateSDK()
        Catch x As Exception

        End Try

    End Sub

    Private Sub AEModeCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AEModeCmb.SelectionChangeCommitted
        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_AEMode, data)

    End Sub

    Private Sub TvCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TvCmb.SelectionChangeCommitted
        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)
        Dim id As Integer

        'If cmb.Equals(Me.AEModeCmb) Then
        '    id = kEdsPropID_AEMode
        'ElseIf cmb.Equals(Me.TvCmb) Then
        '    id = kEdsPropID_Tv
        'ElseIf cmb.Equals(Me.AvCmb) Then
        '    id = kEdsPropID_Av
        'ElseIf cmb.Equals(Me.ISOSpeedCmb) Then
        '    id = kEdsPropID_ISOSpeed
        'ElseIf cmb.Equals(Me.MeteringModeCmb) Then
        '    id = kEdsPropID_MeteringMode
        'ElseIf cmb.Equals(Me.ExposureCompCmb) Then
        '    id = kEdsPropID_ExposureCompensation
        'Else
        '    Console.WriteLine("What's this?")
        'End If

        id = kEdsPropID_Tv
        controller.actionPerformed("set", id, data)

    End Sub

    Private Sub AvCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvCmb.SelectionChangeCommitted
        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_Av, data)

    End Sub

    Private Sub ISOSpeedCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISOSpeedCmb.SelectionChangeCommitted
        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_ISOSpeed, data)

    End Sub

    Private Sub MeteringModeCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeteringModeCmb.SelectionChangeCommitted

        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_MeteringMode, data)

    End Sub

    Private Sub ExposureCompCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExposureCompCmb.SelectionChangeCommitted
        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_ExposureCompensation, data)

    End Sub


    Private Sub ImageQualityCmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageQualityCmb.SelectionChangeCommitted

        Dim cmb As ComboBox = CType(sender, ComboBox) ' "sender" is the combobox
        Dim propValueList As ArrayList = CType(cmb.Tag, ArrayList)
        Dim data As Integer = propValueList.Item(cmb.SelectedIndex)

        controller.actionPerformed("set", kEdsPropID_ImageQuality, data)

    End Sub

    Public Sub btnLiveView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiveView.Click
        'PreviewOn()
        Dim i As Integer = StartLiveView()
        If i = -1 Then
            Return
        Else
            Timer1.Enabled = True
        End If


    End Sub
    'Imports System.Threading

    Public LiveViewRunning As Boolean = False
    Private LVThread As Thread

    Public Sub PreviewOn()

        LVThread = New Thread(AddressOf LiveView)

        LiveViewRunning = True

        LVThread.Start()

    End Sub
    Dim pCamera As IntPtr
    Friend Sub LiveView()

        While LiveViewRunning
            ' download a live view
            Dim pStream As IntPtr, pImageEvf As IntPtr
            Dim result As UInteger
            result = EDSDK.EdsCreateMemoryStream(0, pStream)
            If EDS_ERR_OK <> result Then
                'Program.log(LogCategory.[Error], "Unable to create a memory stream:{0:X}", result)
                'MessageBox.Show("Unable to create a memory stream")
                Exit Sub
            End If

            result = EDSDK.EdsCreateEvfImageRef(pStream, pImageEvf)
            If result <> EDS_ERR_OK Then
                'Program.log(LogCategory.[Error], "Unable to create EvfImageRef:{0:X}", result)
                'MessageBox.Show("Unable to create EvfImageRef")
                'cmd.result = False
                EDSDK.EdsRelease(pStream)

                Exit Sub
            End If

            pCamera = model.getCameraObject()

            result = EDSDK.EdsDownloadEvfImage(pCamera, pImageEvf)
            If result <> EDS_ERR_OK Then
                'Program.log(LogCategory.[Error], "Unable to download Evf image:{0:X}", result)

                'MessageBox.Show("Unable to download Evf image - " & Hex(result))

                EDSDK.EdsRelease(pStream)
                EDSDK.EdsRelease(pImageEvf)

                Exit Sub
            End If

            'Program.log(LogCategory.Debug, "Downloaded Evf image data.")

            ' extract image data into 

            Dim ipData As IntPtr
            result = EDSDK.EdsGetPointer(pStream, ipData)
            If result <> EDS_ERR_OK Then
                'Program.log(LogCategory.[Error], "EdsGetPointer failed: {0:X}", result)

                MessageBox.Show("EdsGetPointer failed")

                EDSDK.EdsRelease(pStream)
                EDSDK.EdsRelease(pImageEvf)

                Exit Sub
            End If

            Dim len As UInteger
            result = EDSDK.EdsGetLength(pStream, len)
            If result <> EDS_ERR_OK Then
                'Program.log(LogCategory.[Error], "EdsGetLength failed:{0:X}", result)

                MessageBox.Show("EdsGetLength failed")

                EDSDK.EdsRelease(pStream)
                EDSDK.EdsRelease(pImageEvf)
                EDSDK.EdsRelease(ipData)

                Exit Sub
            End If

            Dim buffer() As Byte = New Byte(CInt(len)) {}

            Marshal.Copy(ipData, buffer, 0, CInt(len))
            Dim memStream As New System.IO.MemoryStream(buffer)

            ' get the bitmap

            Dim bitmap As Drawing.Bitmap

            bitmap = bitmap.FromStream(memStream)

            picLiveView.Image = bitmap

            ' cleanup
            memStream.Dispose()
            EDSDK.EdsRelease(pStream)
            EDSDK.EdsRelease(pImageEvf)

            EDSDK.EdsRelease(ipData)

        End While

    End Sub

    Public Function StartLiveView() As Integer
        Dim err As Integer = EDS_ERR_OK
        Dim dataType As EdsDataType = EdsDataType.kEdsDataType_Unknown
        Dim dataSize As Integer = 0

        Dim device As IntPtr = IntPtr.Zero
        If model Is Nothing Then
            MsgBox("Maaf, kamera tidak bisa diinisialisasi")
            Return -1
        End If
        pCamera = model.getCameraObject()
        err = EdsGetPropertySize( _
        Me.pCamera, _
        kEdsPropID_Evf_OutputDevice, _
        0, _
        dataType, _
        dataSize)

        Dim data As Integer
        If dataType = EdsDataType.kEdsDataType_UInt32 Or dataType =
        EdsDataType.kEdsDataType_Int32 Then
            '// Get a property.
            Dim ptr As IntPtr = Marshal.AllocHGlobal(dataSize)

            err = EdsGetPropertyData(Me.pCamera,
            kEdsPropID_Evf_OutputDevice, 0, dataSize, ptr)

            data = Marshal.PtrToStructure(ptr, GetType(Integer))
            Marshal.FreeHGlobal(ptr)
        End If

        If (err = EDS_ERR_OK) Then
            device = EdsEvfOutputDevice.kEdsEvfOutputDevice_PC
            err = EdsSetPropertyData(Me.pCamera,
            kEdsPropID_Evf_OutputDevice, 0, Marshal.SizeOf(device), device)
        End If

        Return err

    End Function


    Public Function DownloadEvfData() As Bitmap
        Dim Err As Integer = EDS_ERR_OK
        Dim stream As IntPtr = IntPtr.Zero
        Dim evfImageRef As IntPtr = IntPtr.Zero

        Try
            Err = EdsCreateMemoryStream(0, stream)
        Catch ex As Exception
            MsgBox("Maaf, kamera tidak bisa menghasilkan gambar")
            Return Nothing
        End Try
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If

        EdsCreateEvfImageRef(stream, evfImageRef)
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If

        Err = EdsDownloadEvfImage(pCamera, evfImageRef)
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If

        Dim Length As Integer
        EdsGetLength(stream, Length)
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If


        Buffer = New Byte(Length) {}
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If


        Dim StreamPointer As IntPtr = IntPtr.Zero
        EdsGetPointer(stream, StreamPointer)
        If (Err <> EDS_ERR_OK) Then
            Return Nothing
        End If


        Marshal.Copy(StreamPointer, Buffer, 0, Length)

        Dim s As New IO.MemoryStream(Buffer)

        Dim Result As System.Drawing.Image = Nothing
        Result = System.Drawing.Image.FromStream(s, True, False)
        'PictureBox1.Image = Result
        Return Result
        ''end
        ''Return
        'If (Err = EDS_ERR_OK) Then
        '    Err = EdsCreateEvfImageRef(stream, evfImageRef)
        'End If

        'If (Err = EDS_ERR_OK) Then
        '    Err = EdsDownloadEvfImage(Me.pCamera, evfImageRef)
        'End If

        'Dim ImageInfo As EdsImageInfo

        'Err = EdsGetImageInfo(evfImageRef,
        'EdsImageSource.kEdsImageSrc_FullView, ImageInfo)
        ''****
        ''******* this returns error 97 EDS_ERR_INVALID_HANDLE
        ''****

        'Dim Filespec As String = IO.Path.GetTempFileName

        'Dim FileStream As IntPtr
        'Err = EdsCreateFileStream(Filespec,
        'EdsFileCreateDisposition.kEdsFileCreateDisposition_CreateAlways,
        'EdsAccess.kEdsAccess_ReadWrite, FileStream)

        'Dim Settings As EdsSaveImageSetting
        'Settings.JPEGQuality = 8

        'Err = EdsSaveImage(evfImageRef,
        'EdsTargetImageType.kEdsTargetImageType_Jpeg, Settings, FileStream)
        ''****
        ''******* this returns error 97 EDS_ERR_INVALID_HANDLE
        ''****
        'EdsRelease(FileStream)

        'If (evfImageRef <> Nothing) Then
        '    Err = EDSDK.EdsRelease(stream)
        '    evfImageRef = IntPtr.Zero
        'End If

        'If (stream <> Nothing) Then
        '    Err = EDSDK.EdsRelease(stream)
        '    stream = IntPtr.Zero
        'End If

        'Return System.Drawing.Image.FromFile(Filespec)

    End Function

    Private Sub doLiveView()


    End Sub
    Dim p As FotoDanPencetakanPermohonan 'PencetakanPassTransactionPage
    Dim pixWidth As Integer = 126 * 2
    Dim pixHeight As Integer = 105 * 2
    Dim p1 As Point
    Dim p2 As Point
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        picLiveView.Image = DownloadEvfData()
        'pan to desired image portion
        'If Not p.beginToDrag Then
        'ukuran gambar width x height = 126 x 105


        Dim g As Graphics = Graphics.FromImage(picLiveView.Image)
        

        g.DrawLine(Pens.Red, CInt((picLiveView.Image.Width - pixWidth) / 2), 0, CInt((picLiveView.Image.Width - pixWidth) / 2), picLiveView.Image.Height)
        g.DrawLine(Pens.Red, CInt((picLiveView.Image.Width - pixWidth) / 2) + pixWidth, 0, CInt((picLiveView.Image.Width - pixWidth) / 2) + pixWidth, picLiveView.Image.Height)

        g.DrawLine(Pens.Red, 0, CInt((picLiveView.Image.Height - pixHeight) / 2), picLiveView.Image.Width, CInt((picLiveView.Image.Height - pixHeight) / 2))
        g.DrawLine(Pens.Red, 0, CInt((picLiveView.Image.Height - pixHeight) / 2) + pixHeight, picLiveView.Image.Width, CInt((picLiveView.Image.Height - pixHeight) / 2) + pixHeight)

        'p.picLiveView.Image = picLiveView.Image
        'End If


    End Sub
    'thanks to image croping tech http://www.vb-helper.com/howto_net_drawimage_copy_part.htmlr
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakePicture.Click
        'PictureBox1.Image.Save("C:\eko.jpg")
        'simpen ke phot masing2 pegawai
        'now, we must get from the hot spot
        If picLiveView.Image Is Nothing Then
            MsgBox("Maaf, kamera belum menghasilkan foto")
            Return
        End If
        Dim fr_bm As New Bitmap(picLiveView.Image)
        p1 = New Point(CInt((picLiveView.Image.Width - pixWidth) / 2), CInt((picLiveView.Image.Height - pixHeight) / 2))
        'p2 = New Point(p1.X + pixWidth, p1.Y + pixHeight)

        'tidak bisa mengambil image dari picturebox u/ digambar :((
        Dim to_bm As New Bitmap(My.Resources.putihg) 'p.picCrop.Image)
        Dim g As Graphics = Graphics.FromImage(to_bm) ' Graphics.FromImage(PictureBox1.Image)
        Dim fr_rect As New Rectangle(p1, New Size(pixWidth, pixHeight)) ' 0, 0, 252, 210)
        Dim to_rect As New Rectangle(0, 0, pixWidth, pixHeight)

        ' Draw from the source to the destination.
        g.DrawImage(fr_bm, to_rect, fr_rect, GraphicsUnit.Pixel)
        'g.DrawString("hai", New Font("Arial", 12), Brushes.BurlyWood, New Point(10, 10))
        p.picCrop.Image = to_bm
        p.picCrop.Image.Save("C:\crop.jpg")
        Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLiveView.Click, PictureBox1.Click

    End Sub
End Class

