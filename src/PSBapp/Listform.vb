Imports MySql.Data.MySqlClient

Public Class Listform


    Sub TampilData()
        Try
            Call BukaKoneksi()

            Dim query As String = "SELECT * FROM pendaftaran"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' Membersihkan kolom lama agar tidak double saat di-refresh
            DataGridView1.Columns.Clear()

            ' Menghubungkan DataTable ke DataGridView
            DataGridView1.DataSource = dt


            DataGridView1.Columns("nama_lengkap").HeaderText = "Nama Lengkap"
            DataGridView1.Columns("nik").HeaderText = "NIK"
            DataGridView1.Columns("no_pendaftaran").HeaderText = "No. Pendaftaran"
            DataGridView1.Columns("tanggal_pendaftaran").HeaderText = "Tanggal"
            DataGridView1.Columns("status").HeaderText = "Status"


            Dim btnDetail As New DataGridViewButtonColumn
            btnDetail.Name = "Detail"
            btnDetail.HeaderText = "Aksi"
            btnDetail.Text = "Detail"
            btnDetail.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(btnDetail)



            Dim btnHapus As New DataGridViewButtonColumn
            btnHapus.Name = "Hapus"
            btnHapus.HeaderText = ""
            btnHapus.Text = "Hapus"
            btnHapus.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(btnHapus)

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event saat tombol di dalam DataGridView diklik
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Validasi: Pastikan yang diklik bukan header kolom
        If e.RowIndex < 0 Then Exit Sub

        'Identifikasi kolom yang diklik
        Dim namaKolom As String = DataGridView1.Columns(e.ColumnIndex).Name

        'Ambil data ID/NIK dari baris yang diklik
        Dim nikSiswa As String = DataGridView1.Rows(e.RowIndex).Cells("nik").Value.ToString()
        Dim noPendaftaran As String = DataGridView1.Rows(e.RowIndex).Cells("no_pendaftaran").Value.ToString()


        If namaKolom = "Detail" Then

            Detaildatasiswaform.SelectedID = nikSiswa
            Detaildatasiswaform.Show()
            Me.Hide()


        ElseIf namaKolom = "Hapus" Then

            Dim konfirmasi = MsgBox("Apakah Anda yakin ingin menghapus data dengan No. Pendaftaran: " & noPendaftaran & "?",
                                MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi Hapus")

            If konfirmasi = MsgBoxResult.Yes Then
                Try
                    Call BukaKoneksi()

                    Dim query As String = "DELETE FROM pendaftaran WHERE no_pendaftaran = '" & noPendaftaran & "'"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()

                    MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information)
                    Call TampilData() ' Refresh tabel
                Catch ex As Exception
                    MsgBox("Gagal menghapus data: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Listform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call TampilData()
        MsgBox("Data berhasil direfresh", MsgBoxStyle.Information, "Info")
    End Sub

    ' --- Navigasi ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inputform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftarulangform.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class