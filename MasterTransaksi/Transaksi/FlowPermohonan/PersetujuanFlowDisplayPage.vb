Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Imports System.Drawing

Public Class PersetujuanFlowDisplayPage
    Inherits PageTemplate

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Session.activeView IsNot Me Then Return
        Dim dt As New DataTable
        'clear first dunk. hahahaha
        lbl10.Text = ""

        lbl3.Text = "0"
        lbl4.Text = "0"
        lbl5.Text = "0"
        'lbl6.Text = "0"
        'lbl7.Text = "0"
        lbl13.Text = "0"
        lbl9.Text = "0"
        lbl10.Text = "0"
        lbl11.Text = "0"
        lbl14.Text = "0"
        lbl15.Text = "0"
        lblTotalBerkas.Text = "0"

        Utils.executeSP("proc_persetujuan", New Object() {"flow_persetujuan", 0, 0, 0, 0, 0, 0}, dt)
        If dt.Rows.Count > 0 Then
            Dim total As Integer = 0
            For i As Integer = 0 To dt.Rows.Count - 1

                Dim idtb_next_progress As Integer = dt.Rows(i).Item("idtb_next_progress")
                Dim jumlah As Integer = dt.Rows(i).Item("Jumlah")
                total = total + jumlah
                If idtb_next_progress = 10 Then
                    lbl10.Text = jumlah
                ElseIf idtb_next_progress = 3 Then
                    lbl3.Text = jumlah
                ElseIf idtb_next_progress = 4 Then
                    lbl4.Text = CInt(lbl4.Text) + jumlah
                ElseIf idtb_next_progress = 12 Then
                    lbl4.Text = CInt(lbl4.Text) + jumlah
                ElseIf idtb_next_progress = 5 Then
                    lbl5.Text = jumlah
                ElseIf idtb_next_progress = 6 Then
                    'lbl6.Text = jumlah
                ElseIf idtb_next_progress = 7 Then
                    'lbl7.Text = jumlah
                ElseIf idtb_next_progress = 13 Then
                    lbl13.Text = jumlah
                ElseIf idtb_next_progress = 9 Then
                    lbl9.Text = jumlah
                ElseIf idtb_next_progress = 10 Then
                    lbl10.Text = jumlah
                ElseIf idtb_next_progress = 11 Then
                    lbl11.Text = jumlah
                ElseIf idtb_next_progress = 14 Then
                    lbl14.Text = jumlah
                ElseIf idtb_next_progress = 15 Then
                    lbl15.Text = jumlah
                End If
            Next
            lblTotalBerkas.Text = total
        End If

        dt.Dispose()
    End Sub

    Private Sub PersetujuanFlowDisplayPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackgroundImage = My.Resources.bg_flowchart5

        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")

        Timer1_Tick(Nothing, Nothing)
    End Sub

    Sub startWorking()
        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")

        Timer1_Tick(Nothing, Nothing)

    End Sub


    Private Sub cboPilihBundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPilihBundle.SelectedIndexChanged
        If cboPilihBundle.SelectedValue Is Nothing Then
            cboPemohon.SelectedIndex = -1
        Else
            Utils.fillComboBoxUsingSP(cboPemohon, "proc_permohonan_select_for_combobox", New Object() {cboPilihBundle.SelectedValue}, "--Pilih pemohon--")
            If lastPemohon > 1 Then cboPemohon.SelectedIndex = lastPemohon Else cboPemohon.SelectedIndex = 0
        End If
    End Sub
    Dim lastBundle As Integer = -1
    Dim lastPemohon As Integer = -1
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lastBundle = cboPilihBundle.SelectedIndex
        lastPemohon = cboPemohon.SelectedIndex

        Utils.fillComboBox(cboPilihBundle, "idtb_permohonan_bundle", "nomor_bundle", "tb_permohonan_bundle", "--Pilih bundle permohonan--")
        'If lastBundle = -1 Then
        If lastBundle >= 1 Then cboPilihBundle.SelectedIndex = lastBundle


    End Sub

    Private Sub cboPemohon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPemohon.SelectedIndexChanged
        If cboPemohon.SelectedValue IsNot Nothing Then
            Dim idtb_permohonan As String = cboPemohon.SelectedValue
            Dim dt As New DataTable
            Utils.executeSP("proc_permohonan_lacak", New Object() {idtb_permohonan}, dt)
            If dt IsNot Nothing Then
                Dim status_permohonan As String = dt.Rows(0).Item("status_permohonan")
                Dim idtb_next_progress As String = dt.Rows(0).Item("idtb_next_progress")
                Dim clr As Color
                If status_permohonan = "Diproses" Then
                    clr = Color.Blue
                ElseIf status_permohonan = "Diterima" Then
                    clr = Color.Green
                Else
                    clr = Color.Red
                End If

                If idtb_next_progress = 10 Then
                    lbl10_title.ForeColor = clr
                ElseIf idtb_next_progress = 2 Then

                ElseIf idtb_next_progress = 3 Then

                ElseIf idtb_next_progress = 4 Then
                ElseIf idtb_next_progress = 5 Then

                ElseIf idtb_next_progress = 9 Then
                ElseIf idtb_next_progress = 10 Then

                ElseIf idtb_next_progress = 11 Then
                ElseIf idtb_next_progress = 12 Then

                ElseIf idtb_next_progress = 13 Then
                ElseIf idtb_next_progress = 14 Then
                End If
            Else
                MessageBox.Show("Maaf, data permohonan tidak bisa ditemukan")
            End If
        End If
    End Sub
End Class
