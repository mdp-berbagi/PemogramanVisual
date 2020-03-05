using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pertama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Listener

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toggleGrupTujuan(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void teksNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            String nama, npm;

            nama = teksNama.Text;
            npm = teksNpm.Text;

            this.clearTextBox();

            labelNama.Text = nama;
            labelNpm.Text = npm;

            this.toggleGrupTujuan(true);
            this.toggleGrupSumber(false);
        }

        // Event
        private void clearTextBox()
        {
            teksNama.Text = "";
            teksNpm.Text = "";
        }

        private void clearLabel()
        {
            labelNama.Text = "";
            labelNpm.Text = "";
        }

        private void btnBalikin_Click(object sender, EventArgs e)
        {
            this.clearLabel();
            this.toggleGrupSumber(true);
        }

        private void toggleGrupTujuan(Boolean prop)
        {
            grupTujuan.Enabled = prop;
        }

        private void toggleGrupSumber(Boolean prop)
        {
            grupSumber.Enabled = prop;
        }
    }
}
