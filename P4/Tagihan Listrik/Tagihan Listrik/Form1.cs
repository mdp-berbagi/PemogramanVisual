using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tagihan_Listrik
{
    public partial class TemplateForm : Form
    {

        public TemplateForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /**
         *  Events
         *  
         *  Make event here
         *  
         */

        private void reset()
        {
            txtNoRek.Enabled = true;
            txtGolongan.Enabled = false;
            txtTarif.Enabled = false;
            txtPemakaian.Enabled = false;
            txtNoPelanggan.Enabled = false;
            txtTagihan.Enabled = false;
            txtBayar.Enabled = false;
            txtKembalian.Enabled = false;

            btnUlang.Enabled = false;

            txtNoPelanggan.Focus();

            txtNoRek.Clear();
            txtGolongan.Clear();
            txtTarif.Clear();
            txtPemakaian.Value = 0;
            txtNoPelanggan.Clear();
            txtTagihan.Clear();
            txtBayar.Clear();
            txtKembalian.Clear();
        }

        private void afterNoRekInput()
        {
            txtNoRek.Enabled = false;
            txtPemakaian.Enabled = true;
            txtNoPelanggan.Enabled = false;
            txtBayar.Enabled = true;

            btnUlang.Enabled = true;

            txtPemakaian.Focus();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            this.reset();
        }

        private void txtNoRek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                this.afterNoRekInput();
                this.getGolongan();
            }
        }

        private void btnUlang_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private String getGolongan()
        {

            String kodeGolongan = txtNoRek.Text.Substring(0, 3);

            if (kodeGolongan == "EKS")
            {
                return "Eksekutif";
            }

            if (kodeGolongan == "BIS") 
            {
                return "Bisnis";
            }

            if (kodeGolongan == "EKO")
            {
                return "Ekonomi";
            }

            MessageBox.Show(
                "Maaf, Ada Kesalahan Pada Nomor Rekening", 
                "Perhatian",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            this.reset();

            return "";
        }
    }
}
