Imports System.Net

Public Class DoUpateApplication
    Dim countDown As Integer = 4
    Shared wc As New WebClient
    Shared localFile As String
    Shared remoteFile As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        countDown = countDown - 1
        lblUpdate.Text = "Commenching update in ... " & countDown

        If countDown = 0 Then
            Timer1.Enabled = False
            'Dim cmd As String = """" & Application.StartupPath & "\Tools\unrar.exe"""
            'Dim localfile As String = """" & Application.StartupPath & "\AutoUpdate\PassBandaraUpdate.rar"
            'Dim arg As String = "-y e """ & localfile & """"
            'Dim psi1 As New ProcessStartInfo(cmd, arg)
            'psi1.CreateNoWindow = True

            Process.Start("tools\ExtractUpdate.bat")
            countDown = 4
            Timer2.Enabled = True
            Timer2_Tick(Nothing, Nothing)
        End If
    End Sub

    Private Sub DoUpateApplication_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s() As String = System.Environment.GetCommandLineArgs()
        remoteFile = s(1)
        localFile = s(2)
        AddHandler wc.DownloadFileCompleted, AddressOf downloadComplete
        lblUpdate.Text = "Downloading update.."
        wc.DownloadFileAsync(New Uri(remoteFile), localFile)
    End Sub
    Sub downloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Timer1.Enabled = True
        Timer1_Tick(Nothing, Nothing)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        countDown = countDown - 1
        lblUpdate.Text = "Restarting application in .. " & countDown
        If countDown = 0 Then
            Timer2.Enabled = False
            Process.Start(Application.StartupPath & "\PassBandara.exe")
            End
        End If
    End Sub
End Class
