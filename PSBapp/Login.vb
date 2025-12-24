Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan isi Username dan Password !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' BUKA KONEKSI (sesuai Koneksi.vb)
        Call BukaKoneksi()

        Dim query As String = "SELECT * FROM `user` WHERE KodeAdmin=@user AND PwdAdmin=@pass"
        Cmd = New MySqlCommand(query, conn)

        Cmd.Parameters.AddWithValue("@user", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

        Rd = Cmd.ExecuteReader()

        If Rd.HasRows Then
            Rd.Read()
            Me.Close()
            Call Terbuka()
        Else
            MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
        End If

        Rd.Close()
        conn.Close()

    End Sub

    Sub Terbuka()

    End Sub
End Class
