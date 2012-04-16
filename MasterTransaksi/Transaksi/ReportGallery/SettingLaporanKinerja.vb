Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports Microsoft.Office.Interop

Public Class SettingLaporanKinerja
    Inherits PageTemplate
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        Utils.fillComboBoxUsingSP(cboJabatan, "proc_jabatan_for_report_rekap", New Object() {}, "--Pilih Jabatan--")
    End Sub
    Private Sub chkBulan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBulan.CheckedChanged
        If chkBulan.Checked Then
            dtEnd.Enabled = False
        Else
            dtEnd.Enabled = True
        End If
    End Sub
    'thanks to http://www.c-sharpcorner.com/UploadFile/bourisaw/ExcelReportsInNet11092005001455AM/ExcelReportsInNet.aspx
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim oXL As Excel.Application = New Excel.Application()
        Dim theWorkbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet
        Dim TemplatePath As String = Session.StartupPath & "\Reports\TemplateLaporanPass.xls"
        Dim SavePath As String = Session.StartupPath & "\Reports\LaporanPass.xls"
        theWorkbook = oXL.Workbooks.Open(TemplatePath, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, "\t", True, False, 0, True)

        'fill da
        worksheet = oXL.ActiveSheet
        worksheet.Cells(6, 1) = "Hello"

        'open the newly created report
        oXL.ActiveWorkbook.SaveCopyAs(SavePath)
        theWorkbook.Close()
        theWorkbook = oXL.Workbooks.Open(SavePath, 0, False, 5, "", "", True, Excel.XlPlatform.xlWindows, "\t", True, False, 0, True)
        oXL.Visible = True

    End Sub

End Class
