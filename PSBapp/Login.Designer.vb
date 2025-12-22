<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        GroupBox1 = New GroupBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(159, 24)
        GroupBox1.Margin = New Padding(2, 1, 2, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 1, 2, 1)
        GroupBox1.Size = New Size(586, 332)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 6.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        LinkLabel1.Location = New Point(223, 266)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(62, 11)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Buat Akun Baru"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(258, 290)
        Button1.Margin = New Padding(2, 1, 2, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 27)
        Button1.TabIndex = 12
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 6.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        CheckBox1.Location = New Point(380, 263)
        CheckBox1.Margin = New Padding(2, 1, 2, 1)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(79, 15)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(223, 242)
        TextBox2.Margin = New Padding(2, 1, 2, 1)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(240, 23)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(223, 213)
        TextBox1.Margin = New Padding(2, 1, 2, 1)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(141, 246)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 217)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_19_12_2025_214823_www_bing_com
        PictureBox1.Location = New Point(249, 46)
        PictureBox1.Margin = New Padding(2, 1, 2, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 382)
        Controls.Add(GroupBox1)
        Margin = New Padding(2, 1, 2, 1)
        Name = "Login"
        Text = "LOGIN"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
