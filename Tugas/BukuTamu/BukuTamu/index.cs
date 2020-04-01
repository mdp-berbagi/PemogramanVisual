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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void pesertaBertambah(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totalHadir.Text = (dataBaseView.Rows.Count - 1).ToString();
        }
    }
}
