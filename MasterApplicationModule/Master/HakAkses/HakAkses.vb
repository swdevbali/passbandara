
Imports System.Windows.Forms
Imports SwdevIUIDatabase
Imports SwdevIUIcore

Public Class HakAkses
    Inherits PageTemplate

    Dim arrMenuItem() As ToolStripMenuItem
    Dim roleid As String


    Private Sub CreateMenu()
        Dim dtmenu As New DataTable
        If Utils.executeSP("proc_z_getrolemenu", New Object() {"all", 0}, dtmenu) Then
            'If Utils.executeSP("proc_z_getmenuform", New Object() {"get"}, dsmenu) Then
            If dtmenu.Rows.Count > 0 Then
                For Each row As DataRow In dtmenu.Rows
                    If IsDBNull(row("header")) Then
                        'If row("namaform") <> "Separator" Then
                        Dim node As New TreeNode
                        node.Text = row("menuname")
                        node.Tag = row("formname")
                        node.Name = row("menuid")
                        TreeMenu.Nodes.Add(node)
                        'End If
                    Else
                        Dim nodes() As TreeNode
                        nodes = TreeMenu.Nodes.Find(row("header"), True)
                        'MessageBox.Show(nodes.Count.ToString)
                        If nodes.Count() = 1 Then
                            'If row("namaform") <> "Separator" Then
                            Dim node As New TreeNode
                            node.Text = row("menuname")
                            node.Tag = row("formname")
                            node.Name = row("menuid")
                            nodes(0).Nodes.Add(node)
                            'End If
                        End If
                    End If
                Next
            End If
        End If
        'TreeMenu.ExpandAll()
        TreeMenu.CollapseAll()
        TreeMenu.Width = 200
    End Sub

    Private Sub GetMenuItems(ByVal menu As ToolStripMenuItem, ByRef masternode As TreeNode)
        'MessageBox.Show(menu.DropDownItems.Count)
        If menu.DropDownItems.Count > 0 Then
            For Each item As ToolStripMenuItem In menu.DropDownItems
                Dim node As New TreeNode
                node.Text = item.Text
                node.Name = "Node" & item.Name
                GetMenuItems(item, node)
                masternode.Nodes.Add(node)
            Next
        End If
    End Sub




    Private Sub SimpanRoleMenu()
        Me.Cursor = Cursors.WaitCursor
        'If Utils.exec_SP("proc_z_setrole", New Object() {"edit", roleid, TextRole.Text}) Then
        'If Utils.exec_SP("proc_z_deleterolemenu", New Object() {roleid}) Then
        For Each node As TreeNode In TreeMenu.Nodes
            If node.Nodes.Count > 0 Then
                SetMenuItem(roleid, node)
            End If
            If node.Checked = True Then
                If Utils.exec_SP("proc_z_setrolemenu", New Object() {roleid, node.Name}) = False Then
                    MessageBox.Show("Simpan menu gagal.")
                    Return
                End If

                For Each node2 As TreeNode In node.Nodes
                    If node2.Checked = True Then
                        If Utils.exec_SP("proc_z_setrolemenu", New Object() {roleid, node2.Name}) = False Then
                            MessageBox.Show("Simpan menu gagal.")
                            Return
                        End If
                    Else
                        Utils.exec_SP("proc_z_setrolemenu_delete", New Object() {roleid, node2.Name})
                    End If
                Next
            Else
                Utils.exec_SP("proc_z_setrolemenu_delete", New Object() {roleid, node.Name})
            End If
        Next
        'End If
        ' End If
        Me.Cursor = Cursors.Default
        MessageBox.Show("Data sudah disimpan.")
        Dim dtrole As New DataTable
        If Utils.executeSP("proc_z_getrole", New Object() {0, ""}, dtrole) Then
            If dtrole IsNot Nothing Then
                DGViewRole.DataSource = dtrole
            End If
        End If
    End Sub

    Private Sub SetMenuItem(ByVal roleid, ByRef node)
        If node.Nodes.Count > 0 Then
            For Each childnode As TreeNode In node.Nodes
                SetMenuItem(roleid, childnode)
                If childnode.Checked = True Then
                    If Utils.exec_SP("proc_z_setrolemenu", New Object() {roleid, childnode.Name}) = False Then
                        MessageBox.Show("Simpan menu gagal.")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub UncheckNode(ByRef node)
        If node.Nodes.Count > 0 Then
            For Each childnode As TreeNode In node.Nodes
                UncheckNode(childnode)
                childnode.Checked = False
            Next
        End If
    End Sub



    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim retval As Integer = MessageBox.Show("Apakah anda yakin akan menghapus role " & DGViewRole.Item(1, DGViewRole.CurrentRow.Index).Value & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If retval = DialogResult.Yes Then
            For Each nodes As TreeNode In TreeMenu.Nodes
                If nodes.Nodes.Count > 0 Then
                    UncheckNode(nodes)
                End If
                nodes.Checked = False
            Next
            If Utils.exec_SP("proc_z_setrole", New Object() {"delete", roleid, ""}) Then
                Dim dtrole As New DataTable
                If Utils.executeSP("proc_z_getrole", New Object() {0, ""}, dtrole) Then
                    If dtrole IsNot Nothing Then
                        DGViewRole.DataSource = dtrole
                        DGViewRole.ClearSelection()
                    End If
                End If
            End If
            roleid = 0
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        SimpanRoleMenu()
    End Sub



    Private Sub RolemenuListPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtrole As New DataTable
        If Utils.executeSP("proc_z_getrole", New Object() {0, ""}, dtrole) Then
            If dtrole IsNot Nothing Then
                DGViewRole.DataSource = dtrole
            End If
        End If
        TreeMenu.CheckBoxes = True
        DGViewRole.Columns(DGViewRole.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'For Each menuitem As ToolStripMenuItem In MainGeneralLedger.MenuStrip.Items
        '    Dim node As New TreeNode
        '    node.Text = menuitem.Text
        '    node.Name = "Node" & menuitem.Name
        '    If menuitem.DropDownItems.Count > 0 Then
        '        GetMenuItems(menuitem, node)
        '    End If
        '    TreeMenu.Nodes.Add(node)
        'Next
        CreateMenu()
        TreeMenu.ExpandAll()
    End Sub

    Private Sub DGViewRole_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGViewRole.SelectionChanged
        For Each nodes As TreeNode In TreeMenu.Nodes
            If nodes.Nodes.Count > 0 Then
                UncheckNode(nodes)
            End If
            nodes.Checked = False
        Next
        Dim dtmenu As New DataTable
        roleid = DGViewRole.CurrentRow.Cells(0).Value.ToString
        'TextRole.Text = DGViewRole.CurrentRow.Cells(1).Value.ToString
        If Utils.executeSP("proc_z_getrolemenu", New Object() {"role", roleid}, dtmenu) Then
            If dtmenu IsNot Nothing Then
                If dtmenu.Rows(0).Item(0).ToString = "NO_DATA_FOUND TO SELECT" Then
                    'MessageBox.Show("NO_DATA_FOUND TO SELECT")
                Else
                    For Each row As DataRow In dtmenu.Rows
                        Dim nodes() As TreeNode
                        nodes = TreeMenu.Nodes.Find(row.Item("menuid").ToString(), True)
                        If nodes.Count = 1 Then
                            TreeMenu.SelectedNode = nodes(0)
                            TreeMenu.SelectedNode.Checked = True
                            TreeMenu.Refresh()
                        End If
                    Next
                End If

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DGViewRole.Focus()
        Timer1.Enabled = False
    End Sub
End Class
