Public Class Listform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inputform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftarulangform.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Data direfresh")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
