Imports MySql.Data.MySqlClient

Module Koneksi
    Public conn As MySqlConnection

    Public Sub BukaKoneksi()
        conn = New MySqlConnection(
            "server=localhost;port=4306;user id=root;password=;database=db_sekolah"
        )

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
