Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports System.IO
Imports System.Net

Public Class PemberkasanTransactionPage
    Inherits PageTemplate

    Property idtb_permohonan As String
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        lblPath.Text = "Berkas akan disimpan ke " & Session.serverberkas
    End Sub

    'Private Sub PemberkasanTransactionPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    '
    '    refreshDataGrid()
    'End Sub
    Public Overrides Sub refreshDataGrid()
        MyBase.refreshDataGrid()
        'QUICK SHOW. TODO FIX THIS
        'Dim dt2 As New DataTable
        'Utils.executeSP("proc_berkas", New Object() {"select", 0, 0, 0, Nothing}, dt2)
        'dgBerkas.DataSource = dt2
        'dgBerkas.Columns(0).Visible = False
        'dgBerkas.Columns(1).Visible = False
        'dgBerkas.Columns(dgBerkas.ColumnCount - 1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        loadBerkasForSelectedPermohonan(idtb_permohonan)
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Pilih file berkas pemohon"
        OpenFileDialog1.InitialDirectory = "C:\" 'TODO change and store in config

        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        lblNamaFile.Text = OpenFileDialog1.FileName.ToString()

    End Sub

    Private Sub btnStartUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartUpload.Click
        'QUICKFIX : copy to shared R/W folder for this user only \\192.168.137.1\berkasbandara
        Try
            Dim fileName As String = Path.GetFileName(lblNamaFile.Text)
            File.Copy(lblNamaFile.Text, Session.serverberkas & "\" & fileName)
            'TODO : handle same
            lblNamaFile.Text = "Pilih file yang akan diupload"
            Utils.exec_SP("proc_permohonanberkas", New Object() {"add", 0, idtb_permohonan, fileName}) 'to dumpy permohonan
            'create thumbnail
            'System.Diagnostics.Process.Start("C:\Program Files\ImageMagick-6.7.4-Q16\convert", "-density 600x600 -resize 300x400 -quality 90 " & Session.serverberkas & "\" & fileName & "[1] " & Session.serverberkas & "\" & fileName & ".png")
            refreshDataGrid()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam mengkopi berkas : " & ex.Message, MsgBoxStyle.OkCancel, "PassBandara")
        End Try

        ''TOFIX: Metode upload via webserver
        'Dim fileToUpload As String = lblNamaFile.Text
        'Dim uploadUrl As String = "http://localhost/passbandara/index.php"
        'Dim rdr As FileStream = New FileStream(fileToUpload, FileMode.Open)
        'Dim req As HttpWebRequest = WebRequest.Create(uploadUrl)
        'req.Method = "POST"
        'req.ContentLength = rdr.Length
        'req.AllowWriteStreamBuffering = True

        'Dim reqStream As Stream = req.GetRequestStream()

        'Dim inData() As Byte
        'ReDim inData(rdr.Length)


        'Dim bytesRead As Integer = rdr.Read(inData, 0, rdr.Length)


        'reqStream.Write(inData, 0, rdr.Length)

        'rdr.Close()
        'req.GetResponse()


        'reqStream.Close()
    End Sub


    Private Sub dgBerkas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim filename As String = dgBerkas.Rows(e.RowIndex).Cells("Filename").Value
        'Dim fullpath As String = Session.serverberkas & "\" & filename
        'System.Diagnostics.Process.Start(fullpath)
    End Sub

    Sub loadBerkasForSelectedPermohonan(ByVal vidtb_permohonan As String)
        idtb_permohonan = vidtb_permohonan
        Dim dt As New DataTable

        'thanks for this subquery article 
        dgvList.Columns.Clear()
        Utils.executeSP("proc_permohonanberkas_for_permohonan", New Object() {idtb_permohonan}, dt)
        dgvList.DataSource = dt
        dgvList.Columns(0).Visible = False
        dgvList.Columns(dgvList.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



        Dim berkasLengkap As Boolean = True
        Dim dt2 As New DataTable

        Utils.executeSP("proc_permohonanberkas_kelengkapan", New Object() {idtb_permohonan}, dt2)
        dgvKelengkapanBerkas.Columns.Clear()
        dgvKelengkapanBerkas.DataSource = dt2
        dgvKelengkapanBerkas.Columns("idtb_jenisberkas_kelengkapan").Visible = False
        dgvKelengkapanBerkas.Columns("idtb_jenisberkas").Visible = False

        For i As Integer = 0 To dgvKelengkapanBerkas.Columns.Count - 1
            dgvKelengkapanBerkas.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next


        'add the checkbox
        Dim c As New DataGridViewCheckBoxColumn
        c.HeaderText = "Lengkap"
        c.Name = "Lengkap"
        dgvKelengkapanBerkas.Columns.Add(c)
        For Each row As DataGridViewRow In dgvKelengkapanBerkas.Rows
            If Not IsDBNull(row.Cells("idtb_jenisberkas_kelengkapan").Value) Then
                If row.Cells("Wajib").Value And row.Cells("idtb_jenisberkas_kelengkapan").Value Then
                    row.Cells("Lengkap").Value = True
                Else
                    row.Cells("Lengkap").Value = False
                    berkasLengkap = False
                End If
            End If

            If IsDBNull(row.Cells("idtb_jenisberkas_kelengkapan").Value) And row.Cells("Wajib").Value Then
                berkasLengkap = False
            End If
        Next

        dgvKelengkapanBerkas.Columns(0).ReadOnly = True
        dgvKelengkapanBerkas.Columns("Wajib").ReadOnly = True
        dgvKelengkapanBerkas.Columns("Lengkap").ReadOnly = False
        dgvKelengkapanBerkas.Columns(dgvKelengkapanBerkas.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If berkasLengkap Then lblStatusBerkas.Text = "BERKAS LENGKAP" Else lblStatusBerkas.Text = "BERKAS BELUM LENGKAP"
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub dgvList_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvList.DataError

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvList.CurrentRow IsNot Nothing Then
            Dim kode As String = dgvList.CurrentRow.Cells(0).Value
            If MessageBox.Show("Berkas ini akan dihapus dari server. Anda yakin?", "PassBandara", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                Utils.exec_SP("proc_permohonanberkas", New Object() {"delete", kode, 0, 0})
                Dim filename As String = dgvList.CurrentRow.Cells("Berkas").Value
                File.Delete(Session.serverberkas & "\" & fileName)
                refreshDataGrid()
            End If
        Else
            MessageBox.Show("Pilih berkas terlebih dahulu")
        End If
    End Sub
    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim filename As String = dgvList.Rows(e.RowIndex).Cells("Berkas").Value
        Dim fullpath As String = Session.serverberkas & "\" & filename
        System.Diagnostics.Process.Start(fullpath)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub dgvKelengkapanBerkas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKelengkapanBerkas.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim idtb_jenisberkas_kelengkapan As String
            If IsDBNull(dgvKelengkapanBerkas.Rows(e.RowIndex).Cells("idtb_jenisberkas_kelengkapan").Value) Then
                idtb_jenisberkas_kelengkapan = ""
            Else
                idtb_jenisberkas_kelengkapan = dgvKelengkapanBerkas.Rows(e.RowIndex).Cells("idtb_jenisberkas_kelengkapan").Value
            End If

            Dim idtb_jenisberkas As String = dgvKelengkapanBerkas.Rows(e.RowIndex).Cells("idtb_jenisberkas").Value
            'insert it
            Utils.exec_SP("proc_jenisberkas_kelengkapan", New Object() {"delete", idtb_jenisberkas_kelengkapan, 0, 0})
            dgvKelengkapanBerkas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not dgvKelengkapanBerkas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If dgvKelengkapanBerkas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                Utils.exec_SP("proc_jenisberkas_kelengkapan", New Object() {"add", 0, idtb_jenisberkas, idtb_permohonan})
            End If

        End If
            refreshDataGrid()
    End Sub

    Private Sub btnChangePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePath.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            lblPath.Text = FolderBrowserDialog1.SelectedPath
            Session.serverberkas = lblPath.Text
            EventBroadcaster.doSettingsChange()
        End If
    End Sub

  
End Class
