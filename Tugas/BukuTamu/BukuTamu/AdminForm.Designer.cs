namespace BukuTamu
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Header = new System.Windows.Forms.Panel();
            this.clientFormToggle = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalHadir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataBaseView = new System.Windows.Forms.DataGridView();
            this.linkCaraPenggunaan = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTidakHadir = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalTamu = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelTotalTamu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.Header.Controls.Add(this.linkCaraPenggunaan);
            this.Header.Controls.Add(this.clientFormToggle);
            this.Header.Controls.Add(this.panel1);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.Logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1152, 71);
            this.Header.TabIndex = 0;
            // 
            // clientFormToggle
            // 
            this.clientFormToggle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientFormToggle.AutoSize = true;
            this.clientFormToggle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFormToggle.ForeColor = System.Drawing.Color.White;
            this.clientFormToggle.Location = new System.Drawing.Point(783, 7);
            this.clientFormToggle.Name = "clientFormToggle";
            this.clientFormToggle.Size = new System.Drawing.Size(207, 33);
            this.clientFormToggle.TabIndex = 12;
            this.clientFormToggle.Text = "Open Client Form";
            this.clientFormToggle.UseVisualStyleBackColor = true;
            this.clientFormToggle.Click += new System.EventHandler(this.openClientForm);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 20);
            this.panel1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(162, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(150, 36);
            this.Title.TabIndex = 2;
            this.Title.Text = "Buku Tamu";
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackgroundImage = global::BukuTamu.Properties.Resources.logo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(86, -3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(64, 65);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.totalHadir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(168, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // totalHadir
            // 
            this.totalHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalHadir.AutoSize = true;
            this.totalHadir.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHadir.ForeColor = System.Drawing.Color.White;
            this.totalHadir.Location = new System.Drawing.Point(16, 48);
            this.totalHadir.Name = "totalHadir";
            this.totalHadir.Size = new System.Drawing.Size(30, 36);
            this.totalHadir.TabIndex = 5;
            this.totalHadir.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telah Hadir";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 100);
            this.panel5.TabIndex = 3;
            // 
            // dataBaseView
            // 
            this.dataBaseView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataBaseView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataBaseView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name,
            this.address});
            this.dataBaseView.Location = new System.Drawing.Point(92, 215);
            this.dataBaseView.Name = "dataBaseView";
            this.dataBaseView.RowHeadersWidth = 51;
            this.dataBaseView.Size = new System.Drawing.Size(992, 263);
            this.dataBaseView.TabIndex = 10;
            this.dataBaseView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.pesertaBertambah);
            // 
            // linkCaraPenggunaan
            // 
            this.linkCaraPenggunaan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkCaraPenggunaan.AutoSize = true;
            this.linkCaraPenggunaan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkCaraPenggunaan.Location = new System.Drawing.Point(804, 37);
            this.linkCaraPenggunaan.Name = "linkCaraPenggunaan";
            this.linkCaraPenggunaan.Size = new System.Drawing.Size(277, 18);
            this.linkCaraPenggunaan.TabIndex = 13;
            this.linkCaraPenggunaan.Text = "Click ini untuk cara penggunaan Client Form";
            this.linkCaraPenggunaan.Click += new System.EventHandler(this.ShowHelpClientForm);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 100);
            this.panel7.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 36);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tidak Hadir";
            // 
            // labelTidakHadir
            // 
            this.labelTidakHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTidakHadir.AutoSize = true;
            this.labelTidakHadir.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTidakHadir.ForeColor = System.Drawing.Color.White;
            this.labelTidakHadir.Location = new System.Drawing.Point(18, 45);
            this.labelTidakHadir.Name = "labelTidakHadir";
            this.labelTidakHadir.Size = new System.Drawing.Size(30, 36);
            this.labelTidakHadir.TabIndex = 9;
            this.labelTidakHadir.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.labelTidakHadir);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(807, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 100);
            this.panel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Tamu";
            // 
            // labelTotalTamu
            // 
            this.labelTotalTamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.labelTotalTamu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelTotalTamu.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTamu.ForeColor = System.Drawing.Color.White;
            this.labelTotalTamu.Location = new System.Drawing.Point(22, 45);
            this.labelTotalTamu.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.labelTotalTamu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.labelTotalTamu.Name = "labelTotalTamu";
            this.labelTotalTamu.Size = new System.Drawing.Size(158, 38);
            this.labelTotalTamu.TabIndex = 7;
            this.labelTotalTamu.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.labelTotalTamu.Leave += new System.EventHandler(this.leaveTotalTamu);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.labelTotalTamu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(477, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Nama";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 290;
            // 
            // address
            // 
            this.address.HeaderText = "Alamat";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 520;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1152, 510);
            this.Controls.Add(this.dataBaseView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1063, 47);
            this.Name = "AdminForm";
            this.Text = "Buku Tamu";
            this.Load += new System.EventHandler(this.index_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelTotalTamu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalHadir;
        public System.Windows.Forms.CheckBox clientFormToggle;
        private System.Windows.Forms.Label linkCaraPenggunaan;
        public System.Windows.Forms.DataGridView dataBaseView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTidakHadir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown labelTotalTamu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

