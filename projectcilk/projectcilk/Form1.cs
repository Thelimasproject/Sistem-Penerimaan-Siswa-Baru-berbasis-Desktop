namespace projectcilk
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPasword.Text;

            // Validasi kosong
            if (email == "" || password == "")
            {
                MessageBox.Show(
                    "Email dan Password tidak boleh kosong!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Login sederhana (hardcode)
            if (email == "admin@gmail.com" && password == "123456")
            {
                MessageBox.Show(
                    "Login Berhasil!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

              
                DasboardForm dashboard = new DasboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Email atau Password salah!",
                    "Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
