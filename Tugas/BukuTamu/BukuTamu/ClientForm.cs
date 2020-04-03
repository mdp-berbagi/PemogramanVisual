using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class ClientForm : Form
    {
        AdminForm parent;

        public ClientForm(AdminForm ownerForm)
        {
            this.parent = ownerForm;
            InitializeComponent();
        }

        public void CloseAllKeyboard()
        {
            Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
            foreach (Process onscreenProcess in oskProcessArray)
            {
                onscreenProcess.Kill();
            }
        }

        public void ActiveKeyboard()
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            
            System.Diagnostics.Process.Start(onScreenKeyboardPath);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.cleanForm();
        }

        private void btnShownKeyboard_Click(object sender, EventArgs e)
        {
            this.CloseAllKeyboard();
            this.ActiveKeyboard();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            parent.clientFormToggle.Checked = false;
        }

        private void btnSimpanClick(object sender, EventArgs e)
        {

            int count = parent.dataBaseView.Rows.Count - 1;
            
            parent.dataBaseView.Rows.Add();
            parent.dataBaseView.Rows[count].Cells[1].Value = textName.Text;
            parent.dataBaseView.Rows[count].Cells[2].Value = textAddress.Text;

            this.cleanForm();
        }

        private void cleanForm()
        {
            textName.Text = "";
            textAddress.Text = "";
        }
    }
}
