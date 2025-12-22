Public Class Daftarulangform

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    ' ===== MENU =====
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inputform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Listform.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
