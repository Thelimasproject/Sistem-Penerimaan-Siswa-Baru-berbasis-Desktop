Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class Login

    ' Tombol LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbPasswordHash As String = ""
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan isi Username dan Password!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Call BukaKoneksi()

        Dim query As String = "SELECT * FROM `user`   WHERE username=@user AND password=@pass"
        Cmd = New MySqlCommand(query, conn)
        Cmd.Parameters.AddWithValue("@user", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

        Rd = Cmd.ExecuteReader()


        If Rd.HasRows Then
            MsgBox("Login berhasil!", MsgBoxStyle.Information)
            Rd.Close()
            conn.Close()
            Inputform.Show()
            Me.Hide()
            Call Terbuka()
        Else
            MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
            Rd.Close()
            conn.Close()
        End If

    End Sub

    Sub Terbuka()
        ' nanti buka menu utama
    End Sub

    ' Tombol REGISTER
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim f As New Registerfix
        f.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not chkShow.Checked
    End Sub
End Class
