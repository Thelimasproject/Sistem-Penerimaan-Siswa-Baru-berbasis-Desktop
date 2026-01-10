Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Registerfix
    Public Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha.ComputeHash(bytes)

            Dim sb As New StringBuilder()
            For i As Integer = 0 To hash.Length - 1
                sb.Append(hash(i).ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input
        If txtNama.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Silahkan isi Username dan Password!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Call BukaKoneksi() ' Pastikan Sub BukaKoneksi sudah ada dan conn terkoneksi ke DB

        Try




            Dim query As String = "INSERT INTO user (username, password) VALUES (@user, @pass)"
            Using Cmd As New MySqlCommand(query, conn)
                Cmd.Parameters.AddWithValue("@user", txtNama.Text)
                Cmd.Parameters.AddWithValue("@pass", HashPassword(txtPassword.Text.Trim()))
                Cmd.ExecuteNonQuery()
            End Using

            MsgBox("Registrasi berhasil!", MsgBoxStyle.Information)

            conn.Close()

            ' Kembali ke form login
            Dim f As New Login
            f.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
