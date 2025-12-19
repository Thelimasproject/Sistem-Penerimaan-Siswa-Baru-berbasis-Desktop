namespace projectcilk
{
    partial class loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxlogo = new PictureBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPasword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.Screenshot_19_12_2025_214823_www_bing_com;
            pictureBoxlogo.Location = new Point(321, 94);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(120, 120);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 0;
            pictureBoxlogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 217);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPasword
            // 
            txtPasword.Location = new Point(261, 288);
            txtPasword.Name = "txtPasword";
            txtPasword.PlaceholderText = "********";
            txtPasword.Size = new Size(260, 23);
            txtPasword.TabIndex = 4;
            txtPasword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(338, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // loginform
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPasword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(pictureBoxlogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += loginform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxlogo;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPasword;
        private Button btnLogin;
    }
}
