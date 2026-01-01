<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registerfix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtNama = New TextBox()
        txtPassword = New TextBox()
        btnSimpan = New Button()
        btnKembali = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(108, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(286, 120)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(312, 31)
        txtNama.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(286, 183)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(312, 31)
        txtPassword.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(286, 267)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(468, 267)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 34)
        btnKembali.TabIndex = 5
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Registerfix
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKembali)
        Controls.Add(btnSimpan)
        Controls.Add(txtPassword)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Registerfix"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKembali As Button
End Class
