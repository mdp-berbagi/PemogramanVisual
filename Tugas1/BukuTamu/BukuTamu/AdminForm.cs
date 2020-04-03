using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class AdminForm : Form
    {

        private ClientForm clientForm = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            this.dataBaseView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.setTidakHadir();
        }

        private void pesertaBertambah(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.setTidakHadir();

            this.peletakanNomorUrut();

            this.setTotalPeserta();
        }

        private void peletakanNomorUrut()
        {
            int totalBaris = dataBaseView.Rows.Count;
            int nomorUrut = totalBaris - 1;
            int barisTujuan = totalBaris - 2;

            dataBaseView.Rows[barisTujuan].Cells[0].Value = nomorUrut.ToString();
        }

        private void setTidakHadir()
        {
            int totalBaris = dataBaseView.Rows.Count;
            int nomorUrut = totalBaris - 1;
            int totalTamu = Decimal.ToInt32(labelTotalTamu.Value);

            int totalHadir = totalTamu - nomorUrut;

            labelTidakHadir.Text = totalHadir > 0 
                ? (totalTamu - nomorUrut).ToString() 
                : (totalHadir < 0 ? "Tamu Berlebihan" : "Tidak Ada");
        }

        public void setTotalPeserta()
        {
            int totalBaris = dataBaseView.Rows.Count;
            String totalTamu = (totalBaris - 1).ToString();
            totalHadir.Text = totalTamu;
            if(clientForm != null)
            {
                clientForm.totalHadir.Text = totalTamu;
            }
            
        }

        private void openClientForm(object sender, EventArgs e)
        {

            if (clientFormToggle.Checked)
            {
                clientForm = new ClientForm(this);
                clientForm.Show();
                this.setTotalPeserta();
            }
            else
            {
                clientForm.Close();
            }
        }

        private void ShowHelpClientForm(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cara Penggunaan : \n" +
                "\n* Pastikan kamu punya extend layar" +
                "\n* Kamu Centang Client Formnya" +
                "\n* Pindahkan Form ke Layar Extend untuk tamu" +
                "\n* Doble Click barnya untuk fullscreen" +
                "\n* Jika perlu aktifkan Keyboard layout untuk layar touchscreen" +
                "\n* Jika ingin di tutup Client, hapus Centang Client Formnya dari layarmu atau gunakan ALT + F4 pada formnya"
                , 
                "Cara menggunakan Client Form"
                ,
                MessageBoxButtons.OK
                ,
                MessageBoxIcon.Information
            );
        }

        private void leaveTotalTamu(object sender, EventArgs e)
        {
            this.setTidakHadir();
        }
    }
}
