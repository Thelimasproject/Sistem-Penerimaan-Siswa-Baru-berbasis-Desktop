Imports Org.BouncyCastle.Asn1.Cmp
Imports MySql.Data.MySqlClient


Public Class Inputform

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbJK.Items.Clear
        cmbJK.Items.Add("L")
        cmbJK.Items.Add("P")



        cmbagm.Items.Clear()
        cmbagm.Items.Add("Islam")
        cmbagm.Items.Add("Kristen")
        cmbagm.Items.Add("Katolik")
        cmbagm.Items.Add("Hindu")
        cmbagm.Items.Add("Buddha")
        cmbagm.Items.Add("konghucu")

        cmbAyah.Items.Clear()
        cmbAyah.Items.Add("Petani")
        cmbAyah.Items.Add("Wiraswasta")
        cmbAyah.Items.Add("PNS")
        cmbAyah.Items.Add("Guru")
        cmbAyah.Items.Add("Dokter")
        cmbAyah.Items.Add("Buruh")
        cmbAyah.Items.Add("Lain-lain")

        cmbIbu.Items.Clear()
        cmbIbu.Items.Add("Ibu Rumah Tangga")
        cmbIbu.Items.Add("Wiraswasta")
        cmbIbu.Items.Add("PNS")
        cmbIbu.Items.Add("Guru")
        cmbIbu.Items.Add("Dokter")
        cmbIbu.Items.Add("Buruh")
        cmbIbu.Items.Add("Lain-lain")

        cmbWali.Items.Clear()
        cmbWali.Items.Add("Wiraswasta")
        cmbWali.Items.Add("PNS")
        cmbWali.Items.Add("Guru")
        cmbWali.Items.Add("Dokter")
        cmbWali.Items.Add("Buruh")
        cmbWali.Items.Add("Lain-lain")

    End Sub

    ' ===== MENU =====
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNama.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftarulangform.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Listform.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        Try
            Call BukaKoneksi()
            MessageBox.Show("Koneksi ke database BERHASIL")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi GAGAL: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim trans As MySqlTransaction = Nothing
        Dim nisBaru As Integer


        Try
            Call BukaKoneksi()
            Dim sqlMax As String = "SELECT IFNULL(MAX(nis),0)+1 FROM siswa"
            Using cmdMax As New MySqlCommand(sqlMax, conn)
                nisBaru = Convert.ToInt32(cmdMax.ExecuteScalar())
            End Using

            Dim sql As String = "INSERT INTO siswa 
        (nama_lengkap,nis, nik, tempat_lahir, tanggal_lahir, alamat, tinggi_badan, berat_badan, jenis_kelamin, agama, no_telepon,  Ayah_kandung, Ibu_kandung, Wali, Pekerjaan_ayah, Pekerjaan_ibu, Pekerjaan_wali )
        VALUES
        (@nama,@nis, @nik, @tempat, @tgl, @alamat, @tinggi, @berat, @jk, @agama, @no_telepon, @Ayah_kandung,@Ibu_kandung, @Wali, @Pekerjaan_ayah, @Pekerjaan_ibu, @Pekerjaan_wali )"

            Using cmd As New MySqlCommand(sql, conn, trans)

                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@nis", nisBaru)
                cmd.Parameters.AddWithValue("@nik", txtNIK.Text)
                cmd.Parameters.AddWithValue("@tempat", txtTempat.Text)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value)
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
                cmd.Parameters.AddWithValue("@tinggi", txtTinggi.Text)
                cmd.Parameters.AddWithValue("@berat", txtBerat.Text)
                cmd.Parameters.AddWithValue("@jk", cmbJK.Text)
                cmd.Parameters.AddWithValue("@agama", cmbagm.Text)
                cmd.Parameters.AddWithValue("@no_telepon", txtNo_Telepon.Text)
                cmd.Parameters.AddWithValue("@Ayah_kandung", txtAyah_kandung.Text)
                cmd.Parameters.AddWithValue("@Ibu_kandung", txtIbu_kandung.Text)
                cmd.Parameters.AddWithValue("@Wali", txtWali.Text)
                cmd.Parameters.AddWithValue("@Pekerjaan_ayah", cmbAyah.Text)
                cmd.Parameters.AddWithValue("@Pekerjaan_ibu", cmbIbu.Text)
                cmd.Parameters.AddWithValue("@Pekerjaan_wali", cmbWali.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' ================= INSERT TABEL PENDAFTARAN =================
            Dim sqlDaftar As String = "INSERT INTO pendaftaran 
    ( tanggal_pendaftaran, status)
    VALUES
    ( @tgl_daftar, @status)"

            Using cmdDaftar As New MySqlCommand(sqlDaftar, conn, trans)

                cmdDaftar.Parameters.AddWithValue("@tgl_daftar", Date.Now)


                cmdDaftar.ExecuteNonQuery()
            End Using
            MessageBox.Show("Data berhasil disimpan")

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub cmbStatus_DragEnter(sender As Object, e As DragEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJK.SelectedIndexChanged, cmbagm.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNIK.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtBerat.TextChanged, txtNo_Telepon.TextChanged, txtAyah_kandung.TextChanged, txtIbu_kandung.TextChanged, txtWali.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click, Label19.Click, Label20.Click, Label22.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class
