using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Post
{
    public partial class ipos : Form
    {
        private int harga;

        private byte activeProduct;
        private object[] product;

        public ipos()
        {
            InitializeComponent();
        }

        private void productSetter()
        {

            var newData = new Dictionary<string, object>();
            newData.Add("Name", "HDD Toshiba 1TB - 300Q");
            newData.Add("Price", 680000);

            this.product[0] = newData;

            newData = new Dictionary<string, object>();
            newData.Add("Name", "HDD WD Blue 1TB");
            newData.Add("Price", 150000);

            this.product[1] = newData;

            newData = new Dictionary<string, object>();
            newData.Add("Name", "Sandisk Ultra 64GB");
            newData.Add("Price", 100000);

            this.product[2] = newData;
        }


        /**
         * 
         * Inisialisasii ini produkmu di sini
         * 
         * @return void
         */
        private void isiProduk()
        {

            inputProduk.Items.Clear();
            // inputProduk.Items.Add("HDD Toshiba 1TB - 300Q");
            // inputProduk.Items.Add("HDD WD Blue 1TB");
            // inputProduk.Items.Add("Sandisk Ultra 64GB");

            foreach (Dictionary<string, object> row in this.product)
            {
                inputProduk.Items.Add(row["Name"]);
            }
        }

        /**
         * 
         * Format List View untuk input Belanja
         * 
         * @return void
         */
        private void formaterInputBelanja()
        {
            // Kolomnya
            inputBelanja.Columns.Add("No", 50, HorizontalAlignment.Center);
            inputBelanja.Columns.Add("Produk", 330, HorizontalAlignment.Left);
            inputBelanja.Columns.Add("Harga (Rp)", 120, HorizontalAlignment.Left);
            inputBelanja.Columns.Add("Jumlah", 80, HorizontalAlignment.Center);
            inputBelanja.Columns.Add("Sub Total", 120, HorizontalAlignment.Right);


            inputBelanja.GridLines = true;
            inputBelanja.View = View.Details;
        }

        /**
         * 
         * Reset formulirnya di sini
         * 
         * @return void
         */
        private void resetForm()
        {
            this.isiProduk();
            this.harga = 0;

            inputJumlah.Enabled = false;
            inputJumlah.Value = 1;
            inputHarga.Clear();
        }

        /**
         * 
         * Event kalau form sudah kebuat
         * 
         * @return void
         */
        private void ipos_Load(object sender, EventArgs e)
        {
            this.formaterInputBelanja();
            this.resetForm();
            this.productSetter();
        }

        /**
         * 
         * Event Pemilihan Produk
         * 
         * @return void
         */
        private void inputProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int terpilih = inputProduk.SelectedIndex;
            if (terpilih == 0)
            {
                this.harga = 680000;
            }
            else if (terpilih == 1)
            {
                this.harga = 150000;
            }
            else if (terpilih == 2)
            {
                this.harga = 100000;
            }

            inputHarga.Text = this.harga.ToString("#,##0");
            inputJumlah.Enabled = true;
        }

        /**
         * 
         * Kalau Add ke Click
         * 
         * @return void
         */
        private void button1_Click(object sender, EventArgs e)
        {
            String listKeBrp = (inputBelanja.Items.Count + 1).ToString();
            ListViewItem item = new ListViewItem(listKeBrp);

            Decimal subTotal = inputJumlah.Value * harga;

            item.SubItems.Add(inputProduk.Text);
            item.SubItems.Add(inputHarga.Text);
            item.SubItems.Add((inputJumlah.Value).ToString());
            item.SubItems.Add(subTotal.ToString("#,##0"));

            inputBelanja.Items.Add(item);

            int total = 0;
            for (int i=0; i < inputBelanja.Items.Count; i++)
            {
                total = total + Convert.ToInt32(inputBelanja.Items[i].SubItems[4].Text.Replace(".", ""));
            }

            inputTotalBiaya.Text = total.ToString("#,##0");

            this.resetForm();
        }
    }
}
