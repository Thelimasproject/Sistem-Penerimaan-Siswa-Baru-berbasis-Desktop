using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectcilk
{
    public partial class DasboardForm : Form
    {
        public DasboardForm()
        {
            InitializeComponent();

        }

        private void DasboardForm_Load(object sender, EventArgs e)
        {
            cmbJenisKelamin.Items.Add("Laki-laki");
            cmbJenisKelamin.Items.Add("Perempuan");
            cmbJenisKelamin.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJenisKelamin.Items.AddRange(new string[]
{

});
        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            DasboardForm dashboard = new DasboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnDaftarUlang_Click(object sender, EventArgs e)
        {

        }
    }
}
