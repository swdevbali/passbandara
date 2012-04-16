Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports DevComponents.DotNetBar

Public Class FotoDanPencetakanPermohonan
    Inherits PageTemplate
    'Dim 'pengaturanAwal As PengaturanAwal
    Dim nomor_pass As Object
    Private Sub checkPermohonan(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ButtonItem = sender
        If btn.Checked Then
            ' suppressTabCreation = True
            cboPilihBundle.Text = btn.Tag
            'suppressTabCreation = False
        Else
            cboPilihBundle.SelectedIndex = 0
        End If

    End Sub
    'Dim frontlinerPermohonan As FrontlinerPermohonanPage
    Public Overrides Sub Refresh()
        'ini dicopy paste dari persetujuan
        Dim dtProgress As New DataTable
        Utils.executeSP("proc_progress_by_jabatan", New Object() {Session.kodeRole}, dtProgress)
        dtProgress.Dispose()

        sidebarProgress.Panels.Clear()
        For Each r As DataRow In dtProgress.Rows
            Dim panelItem As New SideBarPanelItem
            panelItem.WordWrap = True
            panelItem.Text = r("nama_progress")
            panelItem.Tag = r("idtb_progress")
            'AddHandler panelItem.ExpandChange, AddressOf onExpandPanel
            sidebarProgress.Panels.Add(panelItem)
            'todo the bundle
            Dim dtProgress2 As New DataTable
            Utils.executeSP("proc_bundle_by_progress", New Object() {r("idtb_progress")}, dtProgress2)
            Dim count As Integer = 0
            For Each r2 As DataRow In dtProgress2.Rows
                Dim btn2 As New ButtonItem
                btn2.AccessibleRole = Windows.Forms.AccessibleRole.RadioButton
                btn2.AutoCheckOnClick = True
                btn2.OptionGroup = r("idtb_progress")
                AddHandler btn2.CheckedChanged, AddressOf checkPermohonan
                btn2.Text = r2("nama_instansi") & " - " & r2("nomor_bundle")
                btn2.Tag = r2("nomor_bundle")
                panelItem.SubItems.Add(btn2)
                count = count + 1
            Next
            dtProgress2.Dispose()
            panelItem.Text = panelItem.Text & " (" & count & ")"
        Next

        sidebarProgress.Panels(0).Expanded = True
        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle")
        'refreshDataGrid()

        sidebarProgress.Refresh()
        refreshDataGrid()
    End Sub
    Public Overrides Sub refreshDataGrid()
        MyBase.refreshDataGrid()
        'lblInstansi.Text = cboInstansiBundle.Text
        lblNomorBundle.Text = cboPilihBundle.Text
        Utils.fillComboBoxUsingSP(cboPemohon, "proc_permohonan_select_for_combobox", New Object() {cboPilihBundle.SelectedValue}, "--Pilih pemohon")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As New CameraControlDlg
        c.Show()
    End Sub

    Private Sub cboPemohon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPemohon.SelectedIndexChanged
        If cboPemohon.SelectedValue Is Nothing Then
            lblMasaBerlaku.Text = "--"
            lblJenisKartu.Text = "--"
            lblStatusPermohonan.Text = "--"

            Return
        End If
        Dim dt As New DataTable
        Utils.executeSP("proc_permohonan", New Object() {"selectsingle", cboPemohon.SelectedValue, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, dt)
        lblStatusPermohonan.Text = dt.Rows(0).Item("Status Pemohon")
        rowPermohonan = dt.Rows(0)
        If lblStatusPermohonan.Text = "Baru" Then
            lblJenisKartu.Text = "Bulanan"
        Else
            lblJenisKartu.Text = "Tahunan"
        End If
        lblMasaBerlaku.Text = dt.Rows(0).Item("Tgl Berlaku").ToString
        nomor_pass = dt.Rows(0).Item("Nomor Pass")
        dt.Dispose()
    End Sub

    Private Sub btnCetakPassBulanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakPassBulanan.Click
        If lblJenisKartu.Text = "Bulanan" Then


            Dim strReportPath As String
            Dim dt As New DataTable
            Dim errmsg As String = ""

            strReportPath = Application.StartupPath & "\Reports\rptPassBulanan.rpt"
            Try
                If Utils.executeSP("proc_pass_bulanan", New Object() {nomor_pass}, dt) Then
                    If dt IsNot Nothing Then
                        Dim clsView As New clsReportPreview(dt, strReportPath)
                        clsView.ShowReport()

                    End If
                End If


                Me.Cursor = Cursors.Default
                If errmsg <> "" Then
                    MsgBox(errmsg)
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        Else
            doCetakTahunan()
        End If
    End Sub

    Dim rowPermohonan As DataRow
    Private Sub doCetakTahunan()
        Dim oWord As Word.Application
        Dim oDoc As Word.Document


        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add("C:\passtemplate.docx")
        'tanggal
        Dim bulanTahun As String = Now.ToString("MMM yyyy")
        oDoc.Content.Find.Execute(FindText:="SEP 2012", ReplaceWith:=bulanTahun, Replace:=Word.WdReplace.wdReplaceAll)
        'wilayah

        oDoc.Content.Find.Execute(FindText:="A1", ReplaceWith:="C", Replace:=Word.WdReplace.wdReplaceAll)
        oDoc.Content.Find.Execute(FindText:="A2", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)
        oDoc.Content.Find.Execute(FindText:="A3", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)
        oDoc.Content.Find.Execute(FindText:="A4", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)
        oDoc.Content.Find.Execute(FindText:="A5", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

        'nama pemohon
        oDoc.Content.Find.Execute(FindText:="NAMAPEMOHON", ReplaceWith:=rowPermohonan.Item("Pemohon"), Replace:=Word.WdReplace.wdReplaceAll)
        'instansi pemohon
        oDoc.Content.Find.Execute(FindText:="INSTANSIX", ReplaceWith:=rowPermohonan.Item("Instansi"), Replace:=Word.WdReplace.wdReplaceAll)
        'terminal
        oDoc.Content.Find.Execute(FindText:="TERMINALX", ReplaceWith:="TERMINAL", Replace:=Word.WdReplace.wdReplaceAll)
        oDoc.Content.Find.Execute(FindText:="TermX", ReplaceWith:="1,2", Replace:=Word.WdReplace.wdReplaceAll)
        'nomor pass
        oDoc.Content.Find.Execute(FindText:="NPASS", ReplaceWith:=rowPermohonan.Item("Nomor Pass"), Replace:=Word.WdReplace.wdReplaceAll)

        'picture
        'thanks to http://bytes.com/topic/visual-basic-net/answers/379262-word-automation-insert-picture
        'thanks to http://www.vbforums.com/showthread.php?t=652814
        'thanks to sizing image http://social.msdn.microsoft.com/Forums/en-US/worddev/thread/ba847533-4c2a-4967-aef5-150cebeb483d

        'oDoc.Content.InlineShapes.AddPicture(FileName:="C:\Pangandaran2011\ela.jpg", LinkToFile:=False, SaveWithDocument:=True)
        oDoc.Bookmarks("FOTO").Range.Select()
        Dim foto As Object = oWord.Selection.InlineShapes.AddPicture(FileName:="C:\crop.jpg", LinkToFile:=False, SaveWithDocument:=True)
        foto.width = oWord.InchesToPoints(1.32)
        Dim pixWidth As Integer = oWord.PointsToPixels(foto.width)
        foto.height = oWord.InchesToPoints(1.1)
        Dim pixHeight As Integer = oWord.PointsToPixels(foto.height)
        'oDoc.PrintOut(Range:=Word.WdPrintOutRange.wdPrintAllDocument, Item:=Word.WdPrintOutItem.wdPrintDocumentContent, Copies:=1, Background:=False)

        oDoc.Bookmarks("BARCODE").Range.Select()
        Dim barcode As Object = oWord.Selection.InlineShapes.AddPicture(FileName:="C:\Barcode.jpg", LinkToFile:=False, SaveWithDocument:=True)
        barcode.width = oWord.MillimetersToPoints(44.48) '2.16)
        'barcode.height = oWord.InchesToPoints(0.38)

    End Sub

    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        refreshDataGrid()
    End Sub
End Class
