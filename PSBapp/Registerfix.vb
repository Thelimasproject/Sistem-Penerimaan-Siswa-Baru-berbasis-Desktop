Imports MySql.Data.MySqlClient

Public Class Registerfix

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input
        If txtNama.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Silahkan isi Username dan Password!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Call BukaKoneksi() ' Pastikan Sub BukaKoneksi sudah ada dan conn terkoneksi ke DB

        Try
            Dim query As String = "INSERT INTO user (nama, password) VALUES (@user, @pass)"
            Using Cmd As New MySqlCommand(query, conn)
                Cmd.Parameters.AddWithValue("@user", txtNama.Text)
                Cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
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
End Class
