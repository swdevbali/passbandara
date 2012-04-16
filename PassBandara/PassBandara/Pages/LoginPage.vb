Imports System.Windows.Forms

Imports SwdevIUIDatabase
Imports SwdevIUICore
Imports DevComponents.DotNetBar

Public Class LoginPage
    Inherits PageTemplate

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Session.dbname = "" Then
            MessageBox.Show("Maaf, database belum didefinisikan. Silahkan definisikan terlebih dahulu")
            Return
        End If
        If UsernameTextBox.Text <> "" Then
            If PasswordTextBox.Text <> "" Then
                Dim dtPwd As New DataTable
                Dim dt As New DataTable
                Utils.executeSP("proc_petugas_by_password", New Object() {PasswordTextBox.Text}, dtPwd)
                If dtPwd.Rows.Count = 0 Then
                    MessageBox.Show("Maaf, password Anda tidak dikenali")
                    Return
                End If
                Dim pwd As String = PasswordTextBox.Text
                UsernameTextBox.Text = dtPwd.Rows(0).Item(0)


                If Utils.executeSP("proc_petugas", New Object() {"selectlogin", Nothing, UsernameTextBox.Text, pwd, "0", "0", "0", "0"}, dt) Then
                    If dt.Rows.Count > 0 Then
                        'login berhasil, hapus history view
                        MainWindow.history.Clear()
                        Session.username = dt.Rows(0)("username") 'or the usernameTextBox
                        Session.vusername = dt.Rows(0)("namalengkap")
                        Session.password = dt.Rows(0)("pass")
                        Session.kodeRole = dt.Rows(0)("koderole")

                        'TOFIX : ini spy cepet aja
                        Session.valamat = ""
                        Session.vtelepon = ""
                        Session.vfax = ""
                        Session.isLoggedIn = True
                        MainWindow.lblUsername.Text = "Selamat datang, " & Session.vusername
                        Select Case Session.kodeRole
                            Case 1
                                MainWindow.setFirstNavigation(Pages.Item("homeAdministrator"))
                            Case 2
                                MainWindow.setFirstNavigation(Pages.Item("homeFrontliner"))
                            Case 3, 4, 5, 6, 7, 8, 9, 10, 22 'kasir terakhir, dan sptnya ini memang yang terakhir
                                MainWindow.setFirstNavigation(Pages.Item("homePersetujuan"))
                            Case Else
                                MainWindow.setFirstNavigation(Pages.Item("homeFrontliner"))
                                'MessageBox.Show("Peran tidak didefinisikan untuk user ini " & Session.kodeRole)
                        End Select
                        'MainForm.roleid = dt.Rows(0).Item("koderole")
                    Else
                        MessageBox.Show("Username atau password salah. Silahkan coba lagi.")
                    End If
                End If
            Else
                MessageBox.Show("Password belum diisi.")
            End If
        Else
            MessageBox.Show("Username belum diisi.")
        End If
    End Sub
    Sub userClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dt As New DataTable

        Me.UsernameTextBox.Text = sender.tag

    End Sub
    Private Sub LoginPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        'dgUser.DataSource = dt
    End Sub
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        Dim dt As New DataTable

        Utils.executeSP("proc_jabatan", New Object() {"select", 0, 0}, dt)
        BubbleBar1.ButtonBackgroundStretch = False
        BubbleBar1.RecalcLayout()
        BubbleBar1.Refresh()
        tabUsername.Buttons.Clear()
        For Each r As DataRow In dt.Rows
            'If r("Jabatan") <> "Administrator" Then
            Dim b As New BubbleButton
            AddHandler b.Click, AddressOf userClick
            b.TooltipText = r("Jabatan")
            b.Tag = r("Kode Jabatan")
            tabUsername.Buttons.Add(b)
            If r("Kode Jabatan") = 3 Then
                b.Image = My.Resources.j_kepalaotoritas_128
            ElseIf r("Kode Jabatan") = 4 Then
                b.Image = My.Resources.j_kasubagtu_128
            ElseIf r("Kode Jabatan") = 5 Then
                b.Image = My.Resources.j_kasubagperencanaan_128
            ElseIf r("Kode Jabatan") = 2 Then
                b.Image = My.Resources.j_frontliner_128
            ElseIf r("Kode Jabatan") = 9 Then
                b.Image = My.Resources.j_kasir_128
            ElseIf r("Kode Jabatan") = 10 Then
                b.Image = My.Resources.j_secondliner_128
            ElseIf r("Kode Jabatan") = 22 Then
                b.Image = My.Resources.j_thirdliner_128
            ElseIf r("Kode Jabatan") = 23 Then
                b.Image = My.Resources.j_pencetakan_128
            ElseIf r("Kode Jabatan") = 1 Then
                b.Image = My.Resources.j_admin_128
            End If
        Next
    End Sub

    Private Sub dgUser_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgUser.SelectionChanged
        UserNameTextBox.Text = dgUser.CurrentRow.Cells(0).Value
        PasswordTextBox.Text = dgUser.CurrentRow.Cells(0).Value
    End Sub

    Private Sub UserNameTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PasswordTextBox.Text = ""
        PasswordTextBox.Focus()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        PasswordTextBox.Text = ""
        PasswordTextBox.Focus()
    End Sub


    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin_Click(Nothing, Nothing)
        End If
    End Sub
End Class
