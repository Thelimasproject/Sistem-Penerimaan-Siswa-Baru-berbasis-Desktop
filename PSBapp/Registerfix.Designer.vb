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
        Label1.Location = New Point(76, 74)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 112)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(200, 72)
        txtNama.Margin = New Padding(2, 2, 2, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(220, 23)
        txtNama.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(200, 110)
        txtPassword.Margin = New Padding(2, 2, 2, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(220, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(200, 160)
        btnSimpan.Margin = New Padding(2, 2, 2, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(78, 20)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(328, 160)
        btnKembali.Margin = New Padding(2, 2, 2, 2)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(78, 20)
        btnKembali.TabIndex = 5
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Registerfix
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(btnKembali)
        Controls.Add(btnSimpan)
        Controls.Add(txtPassword)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
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
