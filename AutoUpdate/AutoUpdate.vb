Imports System.Net
Imports System.IO

'thanks for progress downdload http://www.c-sharpcorner.com/uploadfile/kirtan007/how-to-download-file-and-showing-its-progress-in-progress-bar/
'thanks for credential http://www.vbforums.com/showthread.php?t=511894


Public Class AutoUpdate
    Dim updateFileNameTarget As String
    Dim isDownloading As Boolean = False
    Dim wc As New WebClient
    Dim cancelDownload As Boolean = False
    Private Sub btnStartUpdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartUpdte.Click
        If btnStartUpdte.Text = "&Close" Then End
        If optFromInternet.Checked Then
            lblPercent.Text = ""
            lblDownloading.Text = ""
            lblDownloading.Text = ""
            pbDownloadStatus.Value = 0
            cancelDownload = False

            If isDownloading Then
                cancelDownload = True
                btnStartUpdte.Text = "&Start"
                isDownloading = Not isDownloading
                wc.CancelAsync()
            Else
                btnStartUpdte.Text = "&Stop"
                isDownloading = Not isDownloading
                Try
                    If File.Exists(updateFileNameTarget) Then
                        File.Delete(updateFileNameTarget)
                    End If
                    lblDownloading.Text = "Downloading " & My.Settings.path
                    wc.DownloadFileAsync(New Uri(My.Settings.path), updateFileNameTarget)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        ElseIf optFromFile.Checked Then
            If txtFileName.Text = "" Or Not File.Exists(txtFileName.Text) Then
                MessageBox.Show("File update belum ditentukan atau tidak ada", "AutoUpdate PassBandara", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                updateFileNameTarget = txtFileName.Text
                patchAndextract()
            End If
        ElseIf optFromLAN.Checked Then
            If My.Computer.Network.Ping(txtIP.Text) Then
                wc.DownloadFileAsync(New Uri(txtIP.Text & "\AutoUpdate"), updateFileNameTarget)
            Else
                MessageBox.Show("Komputer pada IP " & txtIP.Text & " tidak bisa dideteksi")
            End If
        End If
    End Sub

    Private Sub progressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        pbDownloadStatus.Value = e.ProgressPercentage
        lblPercent.Text = e.ProgressPercentage & "%"
        'Dim s As String 's itu apa
        's = "" 's itu isinya apa
        's = s & "halo"
    End Sub

    Private Sub downloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If Not cancelDownload Then
            btnStartUpdte.Text = "&Start"
            isDownloading = False
            If pbDownloadStatus.Value < 100 Then
                lblDownloading.Text = "Tidak bisa menyelesaikan proses download ke " & updateFileNameTarget
                MsgBox("Terjadi kesalahan dalam mendownload update. Mohon periksa koneksi Anda")
            Else
                lblDownloading.Text = "Download completed at " & updateFileNameTarget
                patchAndextract()
                MsgBox("Sekarang semua komputer slave akan mendapatkan update baru ini jika mereka merestart aplikasi")
                btnStartUpdte.Text = "&Close"
            End If
            'extract()
        End If
    End Sub

    Private Sub AutoUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        updateFileNameTarget = "C:\AutoUpdate\PassBandaraUpdate.delta"

        If (Not System.IO.Directory.Exists("C:\AutoUpdate\")) Then
            System.IO.Directory.CreateDirectory("C:\AutoUpdate\")
        End If
        AddHandler wc.DownloadFileCompleted, AddressOf downloadComplete
        AddHandler wc.DownloadProgressChanged, AddressOf progressChanged

    End Sub

    Private Sub optFromFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFromFile.CheckedChanged
        btnBrowse.Enabled = True
        'btnStartUpdte.Enabled = False
        txtIP.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFromInternet.CheckedChanged
        btnBrowse.Enabled = False
        txtIP.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFromLAN.CheckedChanged
        btnBrowse.Enabled = False
        txtIP.Enabled = True
        txtIP.Focus()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            txtFileName.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub patchAndextract()
        Dim cmd As String

        cmd = """" & Application.StartupPath & "\Tools\ProcessUpdate.bat"""
        Process.Start(cmd)
    End Sub

End Class
