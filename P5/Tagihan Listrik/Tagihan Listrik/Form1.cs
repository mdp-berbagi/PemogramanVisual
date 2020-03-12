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
        Double tarif = 0;
        String noPelanggan = "";
        String kodeGolongan = "";
        Double tagihan = 0;
        Double bayar = 0;

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
            txtTarif.Text = "0";
            txtPemakaian.Value = 0;
            txtNoPelanggan.Clear();
            txtTagihan.Text = "0";
            txtBayar.Clear();
            txtKembalian.Clear();

            this.tarif = 0;
            this.noPelanggan = "";
            this.kodeGolongan = "";
            this.tagihan = 0;
            this.bayar = 0;
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

                if (txtNoRek.Text.Trim().Length < 3)
                {
                    MessageBox.Show(
                        "Maaf, Nomor Rekening tidak boleh kurang dari 3",
                        "Perhatian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    this.reset();
                }
                else
                {
                    this.afterNoRekInput();
                    txtGolongan.Text = this.getGolongan();


                }
                
            }
        }

        private void btnUlang_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void setTarif(Double tarifBaru)
        {
            this.tarif = tarifBaru;

            txtTarif.Text = this.tarif.ToString("#, ##0");
        }

        private void showNoPel()
        {
            this.noPelanggan = txtNoRek.Text.Replace(this.kodeGolongan, "");
            txtNoPelanggan.Text = noPelanggan;
        }

        private String getGolongan()
        {

            this.kodeGolongan = txtNoRek.Text.Substring(0, 3);
            this.showNoPel();

            if (this.kodeGolongan == "EKS")
            {
                this.setTarif(2500);
                return "Eksekutif";
            }

            if (this.kodeGolongan == "BIS") 
            {
                this.setTarif(2000);
                return "Bisnis";
            }

            if (this.kodeGolongan == "EKO")
            {
                this.setTarif(1500);
                return "Ekonomi";
            }

            this.reset();

            MessageBox.Show(
                "Nomor awalan rekening kamu salah, coba benerin", 
                "Kamu Salah Kode Rekening..",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            

            return "";
        }

        private void txtPemakaian_ValueChanged(object sender, EventArgs e)
        {
            tagihan = tarif * Convert.ToDouble(txtPemakaian.Value);
            txtTagihan.Text = tagihan.ToString("#,##0");
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if(txtBayar.TextLength <= 0)
            {
                txtBayar.Text = "0";
            }
            else
            {
                this.bayar = Convert.ToDouble(txtBayar.Text);
                txtBayar.Text = this.bayar.ToString("#,##0");

                if (this.bayar < this.tagihan)
                {

                }
            }

            
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoPelanggan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
