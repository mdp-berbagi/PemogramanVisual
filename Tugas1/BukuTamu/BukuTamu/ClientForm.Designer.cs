namespace BukuTamu
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelHadir = new System.Windows.Forms.Panel();
            this.totalHadir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnShownKeyboard = new System.Windows.Forms.Button();
            this.btnSimpanClient = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelHadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.Header.Controls.Add(this.panel1);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.Logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(979, 115);
            this.Header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 16);
            this.panel1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(150, 29);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(273, 36);
            this.Title.TabIndex = 2;
            this.Title.Text = "Pengisian Buku Tamu";
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackgroundImage = global::BukuTamu.Properties.Resources.logo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(25, -7);
            this.Logo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(106, 110);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panelHadir
            // 
            this.panelHadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panelHadir.Controls.Add(this.totalHadir);
            this.panelHadir.Controls.Add(this.label1);
            this.panelHadir.Controls.Add(this.panel5);
            this.panelHadir.Location = new System.Drawing.Point(604, 144);
            this.panelHadir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelHadir.Name = "panelHadir";
            this.panelHadir.Size = new System.Drawing.Size(334, 116);
            this.panelHadir.TabIndex = 2;
            // 
            // totalHadir
            // 
            this.totalHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalHadir.AutoSize = true;
            this.totalHadir.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHadir.ForeColor = System.Drawing.Color.White;
            this.totalHadir.Location = new System.Drawing.Point(26, 61);
            this.totalHadir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 169);
            this.panel5.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(23, 165);
            this.textName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(523, 26);
            this.textName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alamat :";
            // 
            // textAddress
            // 
            this.textAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textAddress.Location = new System.Drawing.Point(23, 251);
            this.textAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(523, 104);
            this.textAddress.TabIndex = 7;
            // 
            // btnShownKeyboard
            // 
            this.btnShownKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShownKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnShownKeyboard.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShownKeyboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShownKeyboard.Location = new System.Drawing.Point(604, 292);
            this.btnShownKeyboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShownKeyboard.Name = "btnShownKeyboard";
            this.btnShownKeyboard.Size = new System.Drawing.Size(334, 63);
            this.btnShownKeyboard.TabIndex = 8;
            this.btnShownKeyboard.Text = "Keyboard On-Screen";
            this.btnShownKeyboard.UseVisualStyleBackColor = false;
            this.btnShownKeyboard.Click += new System.EventHandler(this.btnShownKeyboard_Click);
            // 
            // btnSimpanClient
            // 
            this.btnSimpanClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimpanClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnSimpanClient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSimpanClient.Location = new System.Drawing.Point(23, 380);
            this.btnSimpanClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSimpanClient.Name = "btnSimpanClient";
            this.btnSimpanClient.Size = new System.Drawing.Size(334, 63);
            this.btnSimpanClient.TabIndex = 9;
            this.btnSimpanClient.Text = "Simpan";
            this.btnSimpanClient.UseVisualStyleBackColor = false;
            this.btnSimpanClient.Click += new System.EventHandler(this.btnSimpanClick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btnSimpanClient);
            this.Controls.Add(this.btnShownKeyboard);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.panelHadir);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengisian Buku Tamu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelHadir.ResumeLayout(false);
            this.panelHadir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelHadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label totalHadir;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnShownKeyboard;
        private System.Windows.Forms.Button btnSimpanClient;
    }
}