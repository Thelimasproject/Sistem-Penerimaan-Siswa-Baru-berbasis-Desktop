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
        GroupBox1.Location = New Point(221, 97)
        GroupBox1.Margin = New Padding(2, 1, 2, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 1, 2, 1)
        GroupBox1.Size = New Size(664, 276)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(2, 17)
        DataGridView1.Margin = New Padding(2, 1, 2, 1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(660, 258)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-178, -45)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIS"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(222, 48)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(234, 21)
        Label12.TabIndex = 15
        Label12.Text = "TAHUN AJARAN 2026/2027"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(222, 27)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(284, 21)
        Label11.TabIndex = 14
        Label11.Text = "SD MUHAMMADIYAH GEMOLONG"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(222, 6)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(291, 21)
        Label10.TabIndex = 13
        Label10.Text = "SISTEM PENERIMAAN SISWA BARU"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(129, 6)
        PictureBox1.Margin = New Padding(2, 1, 2, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(11, 119)
        Button3.Margin = New Padding(2, 1, 2, 1)
        Button3.Name = "Button3"
        Button3.Size = New Size(184, 28)
        Button3.TabIndex = 2
        Button3.Text = "LIST DATA SISWA"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(11, 81)
        Button2.Margin = New Padding(2, 1, 2, 1)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 28)
        Button2.TabIndex = 1
        Button2.Text = "DAFTAR ULANG"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(11, 41)
        Button1.Margin = New Padding(2, 1, 2, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 28)
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
        GroupBox2.Location = New Point(3, 97)
        GroupBox2.Margin = New Padding(2, 1, 2, 1)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2, 1, 2, 1)
        GroupBox2.Size = New Size(213, 276)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(11, 248)
        Button5.Margin = New Padding(2, 1, 2, 1)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 28)
        Button5.TabIndex = 24
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Listform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 382)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Margin = New Padding(2, 1, 2, 1)
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
