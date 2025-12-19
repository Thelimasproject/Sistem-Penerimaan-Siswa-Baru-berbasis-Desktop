namespace projectcilk
{
    partial class DasboardForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btnListData = new Button();
            btnDaftarUlang = new Button();
            btnInput = new Button();
            label2 = new Label();
            panelContent = new Panel();
            groupBox1 = new GroupBox();
            cmbJenisKelamin = new ComboBox();
            dtpTanggalLahir = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBerat = new TextBox();
            txtTinggi = new TextBox();
            txtAlamat = new TextBox();
            txtTempatLahir = new TextBox();
            txtNama = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 200);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 75);
            label1.TabIndex = 2;
            label1.Text = "SISTEM PENERIMAAN SISWA BARU \r\nSD MUHAMMADIYAH GEMOLONG\r\nTAHUN AJARAN 2026/2027";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_19_12_2025_214823_www_bing_com;
            pictureBox1.Location = new Point(31, 25);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.Controls.Add(btnListData);
            panelMenu.Controls.Add(btnDaftarUlang);
            panelMenu.Controls.Add(btnInput);
            panelMenu.Controls.Add(label2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 200);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 550);
            panelMenu.TabIndex = 1;
            // 
            // btnListData
            // 
            btnListData.BackColor = Color.Silver;
            btnListData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListData.Location = new Point(31, 178);
            btnListData.Name = "btnListData";
            btnListData.Size = new Size(151, 23);
            btnListData.TabIndex = 4;
            btnListData.Text = "LIST DATA SISWA";
            btnListData.UseVisualStyleBackColor = false;
            // 
            // btnDaftarUlang
            // 
            btnDaftarUlang.BackColor = Color.Silver;
            btnDaftarUlang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftarUlang.Location = new Point(31, 132);
            btnDaftarUlang.Name = "btnDaftarUlang";
            btnDaftarUlang.Size = new Size(151, 23);
            btnDaftarUlang.TabIndex = 3;
            btnDaftarUlang.Text = "DAFTAR ULANG";
            btnDaftarUlang.UseVisualStyleBackColor = false;
            btnDaftarUlang.Click += btnDaftarUlang_Click;
            // 
            // btnInput
            // 
            btnInput.BackColor = Color.Silver;
            btnInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInput.Location = new Point(12, 86);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(189, 23);
            btnInput.TabIndex = 2;
            btnInput.Text = "INPUT DATA CALON SISWA";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 0;
            label2.Text = "MENU";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(groupBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 200);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1037, 550);
            panelContent.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbJenisKelamin);
            groupBox1.Controls.Add(dtpTanggalLahir);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBerat);
            groupBox1.Controls.Add(txtTinggi);
            groupBox1.Controls.Add(txtAlamat);
            groupBox1.Controls.Add(txtTempatLahir);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(50, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Diri Pendaftar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.FormattingEnabled = true;
            cmbJenisKelamin.Location = new Point(305, 258);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(121, 25);
            cmbJenisKelamin.TabIndex = 3;
            cmbJenisKelamin.SelectedIndexChanged += cmbJenisKelamin_SelectedIndexChanged;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(305, 126);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(200, 25);
            dtpTanggalLahir.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 266);
            label9.Name = "label9";
            label9.Size = new Size(93, 17);
            label9.TabIndex = 1;
            label9.Text = "Jenis Kelamin";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 228);
            label8.Name = "label8";
            label8.Size = new Size(82, 17);
            label8.TabIndex = 1;
            label8.Text = "Berat Badan";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 197);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 1;
            label7.Text = "Tinggi Badan";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 166);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 1;
            label6.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 135);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 1;
            label5.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 104);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 1;
            label4.Text = "Tempat Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 73);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 1;
            label3.Text = "Nama Lengkap";
            label3.Click += label3_Click;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(305, 220);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(100, 25);
            txtBerat.TabIndex = 0;
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(305, 189);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(100, 25);
            txtTinggi.TabIndex = 0;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(305, 158);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(100, 25);
            txtAlamat.TabIndex = 0;
            // 
            // txtTempatLahir
            // 
            txtTempatLahir.Location = new Point(305, 96);
            txtTempatLahir.Name = "txtTempatLahir";
            txtTempatLahir.Size = new Size(100, 25);
            txtTempatLahir.TabIndex = 0;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(305, 65);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(100, 25);
            txtNama.TabIndex = 0;
            // 
            // DasboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Location = new Point(130, 30);
            Margin = new Padding(5);
            Name = "DasboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dasboard";
            WindowState = FormWindowState.Maximized;
            Load += DasboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContent.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelMenu;
       
       
        private Label label2;
        private Panel panelContent;
        private GroupBox groupBox1;
        private ComboBox cmbJenisKelamin;
        private DateTimePicker dtpTanggalLahir;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBerat;
        private TextBox txtTinggi;
        private TextBox txtAlamat;
        private TextBox txtTempatLahir;
        private TextBox txtNama;
        private Button btnDaftarUlang;
        private Button btnInput;
        private Button btnListData;
    }
}