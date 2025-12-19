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
    public partial class FormDaftarUlang : Form
    {
        public FormDaftarUlang()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDaftarUlang frm = new FormDaftarUlang();
            frm.Show();
            this.Hide();
        }

        private void FormDaftarUlang_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiSeleksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nilaiSeleksi = txtNilaiSeleksi.Text.Trim();

            // Validasi input nilai seleksi tidak kosong
            if (string.IsNullOrEmpty(nilaiSeleksi))
            {
                MessageBox.Show("Nilai Seleksi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNilaiSeleksi.Focus();
                return;
            }

            // Validasi status pembayaran
            if (!rdbBayar.Checked && !rdbBelum.Checked)
            {
                MessageBox.Show("Silakan pilih status pembayaran!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proses simpan data (nanti bisa ke database)
            string statusBayar = rdbBayar.Checked ? "Bayar" : "Belum";
            MessageBox.Show($"Data berhasil disimpan.\nNilai Seleksi: {nilaiSeleksi}\nStatus Pembayaran: {statusBayar}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtNilaiSeleksi.Clear();
            rdbBayar.Checked = false;
            rdbBelum.Checked = false;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            DasboardForm dashboard = new DasboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
