namespace projectcilk
{
    partial class FormDaftarUlang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            btnDaftarUlang = new Button();
            btnInput = new Button();
            label2 = new Label();
            panelContent = new Panel();
            groupBox1 = new GroupBox();
            btnSimpan = new Button();
            rdbBelum = new RadioButton();
            rdbBayar = new RadioButton();
            txtNilaiSeleksi = new TextBox();
            lblTanggalDaftar = new Label();
            lblNamaSiswa = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1188, 200);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 37);
            label1.Name = "label1";
            label1.Size = new Size(328, 75);
            label1.TabIndex = 2;
            label1.Text = "SISTEM PENERIMAAN SISWA BARU\r\nSD MUHAMMADIYAH GEMOLONG\r\nTAHUN AJARAN 2026/2027";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_19_12_2025_214823_www_bing_com;
            pictureBox1.Location = new Point(20, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnDaftarUlang);
            panel1.Controls.Add(btnInput);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 502);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(31, 178);
            button3.Name = "button3";
            button3.Size = new Size(151, 23);
            button3.TabIndex = 3;
            button3.Text = "LIST DATA SISWA";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnDaftarUlang
            // 
            btnDaftarUlang.BackColor = Color.Silver;
            btnDaftarUlang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDaftarUlang.Location = new Point(31, 132);
            btnDaftarUlang.Name = "btnDaftarUlang";
            btnDaftarUlang.Size = new Size(151, 23);
            btnDaftarUlang.TabIndex = 3;
            btnDaftarUlang.Text = "DAFTAR ULANG";
            btnDaftarUlang.UseVisualStyleBackColor = false;
            btnDaftarUlang.Click += button2_Click;
            // 
            // btnInput
            // 
            btnInput.BackColor = Color.Silver;
            btnInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnInput.Location = new Point(12, 86);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(189, 23);
            btnInput.TabIndex = 3;
            btnInput.Text = "INPUT DATA CALON SISWA";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(67, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "MENU";
            label2.Click += label2_Click_1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(groupBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 200);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(968, 502);
            panelContent.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSimpan);
            groupBox1.Controls.Add(rdbBelum);
            groupBox1.Controls.Add(rdbBayar);
            groupBox1.Controls.Add(txtNilaiSeleksi);
            groupBox1.Controls.Add(lblTanggalDaftar);
            groupBox1.Controls.Add(lblNamaSiswa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(50, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar Ulang";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(49, 217);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // rdbBelum
            // 
            rdbBelum.AutoSize = true;
            rdbBelum.Location = new Point(431, 160);
            rdbBelum.Name = "rdbBelum";
            rdbBelum.Size = new Size(65, 21);
            rdbBelum.TabIndex = 3;
            rdbBelum.TabStop = true;
            rdbBelum.Text = "belum";
            rdbBelum.UseVisualStyleBackColor = true;
            rdbBelum.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbBayar
            // 
            rdbBayar.AutoSize = true;
            rdbBayar.Location = new Point(312, 160);
            rdbBayar.Name = "rdbBayar";
            rdbBayar.Size = new Size(60, 21);
            rdbBayar.TabIndex = 3;
            rdbBayar.TabStop = true;
            rdbBayar.Text = "bayar";
            rdbBayar.UseVisualStyleBackColor = true;
            // 
            // txtNilaiSeleksi
            // 
            txtNilaiSeleksi.Location = new Point(319, 125);
            txtNilaiSeleksi.Name = "txtNilaiSeleksi";
            txtNilaiSeleksi.Size = new Size(177, 25);
            txtNilaiSeleksi.TabIndex = 2;
            txtNilaiSeleksi.TextChanged += txtNilaiSeleksi_TextChanged;
            // 
            // lblTanggalDaftar
            // 
            lblTanggalDaftar.AutoSize = true;
            lblTanggalDaftar.Location = new Point(326, 92);
            lblTanggalDaftar.Name = "lblTanggalDaftar";
            lblTanggalDaftar.Size = new Size(12, 17);
            lblTanggalDaftar.TabIndex = 1;
            lblTanggalDaftar.Text = ":";
            // 
            // lblNamaSiswa
            // 
            lblNamaSiswa.AutoSize = true;
            lblNamaSiswa.Location = new Point(326, 52);
            lblNamaSiswa.Name = "lblNamaSiswa";
            lblNamaSiswa.Size = new Size(12, 17);
            lblNamaSiswa.TabIndex = 1;
            lblNamaSiswa.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 162);
            label6.Name = "label6";
            label6.Size = new Size(155, 17);
            label6.TabIndex = 0;
            label6.Text = "Konfirmasi Pembayaran";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 128);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 0;
            label5.Text = "Input Nilai Seleksi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 95);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 0;
            label4.Text = "Tanggal Pendaftaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 62);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 0;
            label3.Text = "Nama Siswa";
            label3.Click += label3_Click;
            // 
            // FormDaftarUlang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1188, 702);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "FormDaftarUlang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daftar Ulang";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Button button3;
        private Button btnDaftarUlang;
        private Button btnInput;
        private Panel panelContent;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton rdbBayar;
        private TextBox txtNilaiSeleksi;
        private Button btnSimpan;
        private RadioButton rdbBelum;
        private Label lblTanggalDaftar;
        private Label lblNamaSiswa;
    }
}