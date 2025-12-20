<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listform
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
        Dim GroupBox1 As GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listform))
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(410, 207)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1233, 589)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(1227, 551)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-331, -95)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 32)
        Label1.TabIndex = 0
        Label1.Text = "NIS"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(413, 102)
        Label12.Name = "Label12"
        Label12.Size = New Size(461, 45)
        Label12.TabIndex = 15
        Label12.Text = "TAHUN AJARAN 2026/2027"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(413, 57)
        Label11.Name = "Label11"
        Label11.Size = New Size(567, 45)
        Label11.TabIndex = 14
        Label11.Text = "SD MUHAMMADIYAH GEMOLONG"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(413, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(583, 45)
        Label10.TabIndex = 13
        Label10.Text = "SISTEM PENERIMAAN SISWA BARU"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(240, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(20, 254)
        Button3.Name = "Button3"
        Button3.Size = New Size(341, 59)
        Button3.TabIndex = 2
        Button3.Text = "LIST DATA SISWA"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(20, 172)
        Button2.Name = "Button2"
        Button2.Size = New Size(341, 59)
        Button2.TabIndex = 1
        Button2.Text = "DAFTAR ULANG"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(20, 88)
        Button1.Name = "Button1"
        Button1.Size = New Size(341, 59)
        Button1.TabIndex = 0
        Button1.Text = "INPUT DATA CALON SISWA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Location = New Point(5, 207)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(396, 589)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(20, 530)
        Button5.Name = "Button5"
        Button5.Size = New Size(158, 59)
        Button5.TabIndex = 24
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Listform
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1648, 814)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Listform"
        Text = "LIST DATA SISWA"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
End Class
