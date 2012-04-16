
Imports SwdevIUICore
Imports SwdevIUIDatabase
Imports System.Windows.Forms
Public Class MigrasiData
    Public iCurrentFoto As Integer = 0
    Public iCurrentPemberkasan As Integer = 0
    Public iCurrentPembayaran As Integer = 0
    Const sPath = "C:\Antrian.lbx"


    Private Sub AntrianForUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.dbname = My.Settings.dbname
        Session.dbhost = My.Settings.dbhost
        Session.dbuser = My.Settings.dbuser
        Session.dbpassword = My.Settings.dbpassword
        Session.dbport = My.Settings.dbport

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogDatabaseSettings.ShowDialog()
    End Sub
    'thanks to http://decoding.wordpress.com/2008/10/11/sql-server-insert-into-with-subquery/
    Private Sub btnMulaiMigrasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulaiMigrasi.Click

        If MessageBox.Show("Proses ini akan mereset isi dari tabel bidangusaha,instansi dan pemohon pada basis data " & Session.dbname & " dengan nilai dari basis data lama. " & vbCrLf & "Apakah Anda akan melanjutkan?", "Migrasi Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
            If Utils.isConnected() Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                Dim targetDb As String = "data_all"
                listMigrasi.Items.Clear()
                listMigrasi.Items.Add(Utils.execQuery("delete from tb_bidangusaha"))
                listMigrasi.Items.Add(Utils.execQuery("insert into tb_bidangusaha(bidangusaha) SELECT distinct kategori FROM " & targetDb & ".company"))

                listMigrasi.Items.Add(Utils.execQuery("delete from tb_instansi"))
                listMigrasi.Items.Add(Utils.execQuery("insert into tb_instansi(lokasi_terminal,luas_ruangan,nomor_sertifikat, masa_berlaku,kegiatan_usaha,alamat,first_code, last_code,nama_instansi,no_telp,no_fax,status,last_number,idtb_bidangusaha) select lokasi_terminal,luas_ruangan,nomor_sertifikat, masa_berlaku,kegiatan_usaha,alamat,first_code, last_code,nama_perusahaan,no_telp,no_fax,status, last_number,idtb_bidangusaha from " & targetDb & ".company c inner join tb_bidangusaha b on c.kategori=b.bidangusaha"))

                listMigrasi.Items.Add(Utils.execQuery("delete from tb_pemohon"))
                listMigrasi.Items.Add(Utils.execQuery("insert into tb_pemohon(nama,alamat,nomor_kode, tgl_dikeluarkan,tipe_kartu,tempat_tgl_lahir,tgl_lahir,kartu_identifikasi,kategori_kartu,masa_berlaku,kode_area_1,kode_area_2,kode_area_3,kode_area_4,kode_area_5,idtb_instansi,jabatan,jenis_kelamin,no_identitas) select nama_lengkap,e.alamat,nomor_kode, tgl_dikeluarkan,tipe_kartu,tempat_tgl_lahir,tgl_lahir,kartu_identifikasi,kategori_kartu,e.masa_berlaku,kode_area_1,kode_area_2,kode_area_3,kode_area_4,kode_area_5,idtb_instansi,jabatan,jenis_kelamin,kartu_identifikasi from " & targetDb & ".employee e inner join tb_instansi i on e.instansi = i.nama_instansi"))


                Me.Cursor = Windows.Forms.Cursors.Default
            End If
        End If

    End Sub
End Class