Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports DevComponents.AdvTree
Imports MasterModule

Public Class HirarkiBrowsing
    Inherits PageTemplate
    Public Overrides Sub Refresh()
        MyBase.Refresh()

    End Sub
    Private Sub advTree2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tree.Click

    End Sub

    Private Sub advTree2_BeforeExpand(ByVal sender As System.Object, ByVal e As DevComponents.AdvTree.AdvTreeNodeCancelEventArgs) Handles tree.BeforeExpand
        If Not e.Node.TagString.Contains("expanded") Then
            If e.Node Is nodePemerintahan Or e.Node Is nodePenerbangan Or e.Node Is nodeNonPenerbangan Or e.Node Is nodeUmum Then
                e.Node.Nodes.Clear()
                Dim dt As New DataTable
                Utils.executeSP("proc_instansi_by_kategori", New Object() {e.Node.Text}, dt)
                Cursor = Windows.Forms.Cursors.WaitCursor
                For Each r As DataRow In dt.Rows
                    Dim nd As New Node
                    Dim ndChild As New Node
                    nd.Image = My.Resources.m_instansi_32
                    ndChild.Text = "Dummy"
                    nd.TagString = "nodeInstansi|" & r.Item("idtb_instansi")
                    nd.Cells.Add(New Cell(r.Item("alamat")))
                    nd.Nodes.Add(ndChild)
                    nd.Text = r.Item("nama_instansi")
                    e.Node.Nodes.Add(nd)
                Next
                e.Node.TagString = "expanded"
                Cursor = Windows.Forms.Cursors.Default
                dt.Dispose()
            ElseIf e.Node.TagString.Contains("nodeInstansi") Then
                e.Node.Nodes.Clear()
                Dim idtb_instansi = e.Node.TagString.Split("|")(1)
                Dim dt As New DataTable
                Utils.executeSP("proc_pemohon_by_instansi", New Object() {idtb_instansi}, dt)
                Cursor = Windows.Forms.Cursors.WaitCursor
                For Each r As DataRow In dt.Rows
                    Dim nd As New Node
                    nd.TagString = "nodePemohon|" & r.Item("idtb_pemohon")
                    nd.Cells.Add(New Cell(r.Item("alamat")))
                    nd.Text = r.Item("nama")
                    nd.Image = My.Resources.m_berkaspemohon_32
                    e.Node.Nodes.Add(nd)
                Next
                e.Node.TagString = e.Node.TagString & "|expanded"
                Cursor = Windows.Forms.Cursors.Default
                dt.Dispose()

            End If
        End If
    End Sub

   
    Private Sub tree_NodeClick(ByVal sender As System.Object, ByVal e As DevComponents.AdvTree.TreeNodeMouseEventArgs) Handles tree.NodeClick
        Dim nd As Node = tree.SelectedNodes(0)
        If nd.TagString.Contains("nodeInstansi") Then
            Dim idtb_instansi As String = nd.TagString.Split("|")(1)
            Dim dt As New DataTable
            Utils.executeSP("proc_instansi_by_id", New Object() {idtb_instansi}, dt)
            Dim vInstansi As New ViewInstansi
            vInstansi.Fill(dt.Rows(0))
            pnlViewer.Controls.Clear()
            vInstansi.Dock = Windows.Forms.DockStyle.Fill
            pnlViewer.Controls.Add(vInstansi)
        ElseIf nd.TagString.Contains("nodePemohon") Then
            Dim idtb_pemohon As String = nd.TagString.Split("|")(1)
            Dim dt As New DataTable
            Utils.executeSP("proc_pemohon_by_id", New Object() {idtb_pemohon}, dt)
            Dim vPemohon As New ViewPemohon
            vPemohon.Fill(dt.Rows(0))
            pnlViewer.Controls.Clear()
            vPemohon.Dock = Windows.Forms.DockStyle.Fill
            pnlViewer.Controls.Add(vPemohon)
        End If
    End Sub

    Private Sub btnPopupDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopupDialog.Click

    End Sub
End Class
