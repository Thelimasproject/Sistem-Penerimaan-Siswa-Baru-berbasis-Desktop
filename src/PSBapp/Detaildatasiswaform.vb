Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Detaildatasiswaform

    Public Shared SelectedID As String = ""

    Sub TampilDetail()
        Try
            Call BukaKoneksi()
            Dim query As String = "SELECT * FROM siswa WHERE nik = '" & SelectedID & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                With DataGridView1
                    If .Columns.Contains("nis") Then .Columns("nis").HeaderText = "NIS"
                    If .Columns.Contains("nama_lengkap") Then .Columns("nama_lengkap").HeaderText = "Nama Lengkap"
                    If .Columns.Contains("nik") Then .Columns("nik").HeaderText = "NIK"
                End With
            Else
                MsgBox("Data siswa tidak ditemukan.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Gagal memuat detail: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AddCellToTable(table As PdfPTable, label As String, value As String, font As iTextSharp.text.Font)
        Dim cellLabel As New PdfPCell(New Phrase(label, font))
        cellLabel.Border = iTextSharp.text.Rectangle.NO_BORDER
        cellLabel.PaddingBottom = 5
        table.AddCell(cellLabel)

        Dim cellValue As New PdfPCell(New Phrase(": " & value, font))
        cellValue.Border = iTextSharp.text.Rectangle.NO_BORDER
        cellValue.PaddingBottom = 5
        table.AddCell(cellValue)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles print.Click
        Try

            Dim folderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KartuSiswa")
            If Not Directory.Exists(folderPath) Then Directory.CreateDirectory(folderPath)
            Dim filePath As String = Path.Combine(folderPath, "Kartu_" & SelectedID & ".pdf")

            ' Membuat Dokumen
            Dim doc As New Document(PageSize.A4, 50, 50, 50, 50)
            PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()

            ' logo
            Dim pathLogo As String = Path.Combine(Application.StartupPath, "logo_sekolah.jpeg")
            If File.Exists(pathLogo) Then
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(pathLogo)
                logo.ScaleAbsolute(60.0F, 60.0F)
                logo.Alignment = Element.ALIGN_CENTER
                doc.Add(logo)
            End If

            Dim headerFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim subHeaderFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim normalFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA, 11)


            Dim p2 As New Paragraph("KARTU PENDAFTARAN SISWA BARU", headerFont)
            p2.Alignment = Element.ALIGN_CENTER
            doc.Add(p2)

            Dim p1 As New Paragraph("SD MUHAMMADIYAH GEMOLONG", subHeaderFont)
            p1.Alignment = Element.ALIGN_CENTER
            doc.Add(p1)

            Dim line As New Paragraph("______________________________________________________")
            line.Alignment = Element.ALIGN_CENTER
            doc.Add(line)
            doc.Add(New Paragraph(" "))


            If DataGridView1.Rows.Count > 0 Then
                Dim row As DataGridViewRow = DataGridView1.Rows(0)
                Dim table As New PdfPTable(2)
                table.WidthPercentage = 90
                table.SetWidths({35, 65})

                AddCellToTable(table, "Nama Lengkap", row.Cells("nama_lengkap").Value.ToString(), normalFont)
                AddCellToTable(table, "Nomor Induk Siswa (NIS)", row.Cells("nis").Value.ToString(), normalFont)
                AddCellToTable(table, "NIK", row.Cells("nik").Value.ToString(), normalFont)
                Dim tglLahir As String = Convert.ToDateTime(row.Cells("tanggal_lahir").Value).ToString("dd MMMM yyyy")
                AddCellToTable(table, "Tempat, Tgl Lahir", row.Cells("tempat_lahir").Value.ToString() & ", " & tglLahir, normalFont)
                AddCellToTable(table, "Alamat", row.Cells("alamat").Value.ToString(), normalFont)
                AddCellToTable(table, "Agama", row.Cells("agama").Value.ToString(), normalFont)
                AddCellToTable(table, "Tinggi Badan", row.Cells("tinggi_badan").Value.ToString(), normalFont)
                AddCellToTable(table, "Berat Badan", row.Cells("berat_badan").Value.ToString(), normalFont)
                AddCellToTable(table, "Pekerjaan Wali", row.Cells("pekerjaan_wali").Value.ToString(), normalFont)
                AddCellToTable(table, "Pekerjaan Ayah", row.Cells("pekerjaan_ayah").Value.ToString(), normalFont)
                AddCellToTable(table, "Pekerjaan Ibu", row.Cells("pekerjaan_ibu").Value.ToString(), normalFont)
                AddCellToTable(table, "Jenis Kelamin", If(row.Cells("jenis_kelamin").Value.ToString() = "L", "Laki-laki", "Perempuan"), normalFont)
                AddCellToTable(table, "No. Telepon", row.Cells("no_telepon").Value.ToString(), normalFont)
                AddCellToTable(table, "Nama Ayah Kandung", row.Cells("Ayah_kandung").Value.ToString(), normalFont)
                AddCellToTable(table, "Nama Ibu Kandung", row.Cells("Ibu_kandung").Value.ToString(), normalFont)


                doc.Add(table)
            End If


            doc.Add(New Paragraph(" "))
            Dim footerTable As New PdfPTable(1)
            footerTable.WidthPercentage = 100
            Dim footerCell As New PdfPCell(New Phrase("Gemolong, " & DateTime.Now.ToString("dd MMMM yyyy") & vbCrLf & "Panitia Pendaftaran," & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "( ____________________ )", normalFont))
            footerCell.HorizontalAlignment = Element.ALIGN_RIGHT
            footerCell.Border = iTextSharp.text.Rectangle.NO_BORDER
            footerTable.AddCell(footerCell)
            doc.Add(footerTable)

            doc.Close()

            'Buka di Browser
            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})

        Catch ex As Exception
            MsgBox("Gagal mencetak: " & ex.Message)
        End Try
    End Sub

    Private Sub Detaildatasiswaform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilDetail()
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Listform.Show()
        Me.Close()
    End Sub
End Class