﻿namespace Tagihan_Listrik
{
    partial class TemplateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormTitle = new System.Windows.Forms.Label();
            this.labelNoRek = new System.Windows.Forms.Label();
            this.txtNoRek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGolongan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoPelanggan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTagihan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPemakaian = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnUlang = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPemakaian)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.FormTitle);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biar Mudah Kamu Ngitungnya ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.FormTitle.ForeColor = System.Drawing.Color.LavenderBlush;
            this.FormTitle.Location = new System.Drawing.Point(121, 19);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(583, 63);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Aplikasi Tagihan Listrik";
            // 
            // labelNoRek
            // 
            this.labelNoRek.AutoSize = true;
            this.labelNoRek.Location = new System.Drawing.Point(43, 209);
            this.labelNoRek.Name = "labelNoRek";
            this.labelNoRek.Size = new System.Drawing.Size(105, 20);
            this.labelNoRek.TabIndex = 1;
            this.labelNoRek.Text = "No. Rekening";
            // 
            // txtNoRek
            // 
            this.txtNoRek.Location = new System.Drawing.Point(172, 209);
            this.txtNoRek.Name = "txtNoRek";
            this.txtNoRek.Size = new System.Drawing.Size(235, 26);
            this.txtNoRek.TabIndex = 2;
            this.txtNoRek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoRek_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // txtGolongan
            // 
            this.txtGolongan.Location = new System.Drawing.Point(172, 251);
            this.txtGolongan.Name = "txtGolongan";
            this.txtGolongan.Size = new System.Drawing.Size(235, 26);
            this.txtGolongan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Golongan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(208, 294);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(199, 26);
            this.txtTarif.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarif / Kwh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pemakaian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // txtNoPelanggan
            // 
            this.txtNoPelanggan.Location = new System.Drawing.Point(597, 170);
            this.txtNoPelanggan.Name = "txtNoPelanggan";
            this.txtNoPelanggan.Size = new System.Drawing.Size(235, 26);
            this.txtNoPelanggan.TabIndex = 15;
            this.txtNoPelanggan.TextChanged += new System.EventHandler(this.txtNoPelanggan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "No Pelanggan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(598, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Rp.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = ":";
            // 
            // txtTagihan
            // 
            this.txtTagihan.Location = new System.Drawing.Point(633, 212);
            this.txtTagihan.Name = "txtTagihan";
            this.txtTagihan.Size = new System.Drawing.Size(199, 26);
            this.txtTagihan.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(468, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tagihan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(598, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Rp.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(577, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = ":";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(633, 256);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(199, 26);
            this.txtBayar.TabIndex = 22;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(468, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Bayar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(598, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Rp.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(577, 298);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = ":";
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(633, 297);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(199, 26);
            this.txtKembalian.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(468, 297);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Kembalian";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(375, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Kwh";
            // 
            // txtPemakaian
            // 
            this.txtPemakaian.Location = new System.Drawing.Point(171, 335);
            this.txtPemakaian.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPemakaian.Name = "txtPemakaian";
            this.txtPemakaian.Size = new System.Drawing.Size(191, 26);
            this.txtPemakaian.TabIndex = 30;
            this.txtPemakaian.ValueChanged += new System.EventHandler(this.txtPemakaian_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(151, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 20);
            this.label22.TabIndex = 33;
            this.label22.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(42, 170);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 20);
            this.label23.TabIndex = 31;
            this.label23.Text = "Tanggal";
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(172, 170);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(235, 26);
            this.txtTanggal.TabIndex = 34;
            // 
            // btnUlang
            // 
            this.btnUlang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUlang.Location = new System.Drawing.Point(633, 339);
            this.btnUlang.Name = "btnUlang";
            this.btnUlang.Size = new System.Drawing.Size(199, 29);
            this.btnUlang.TabIndex = 35;
            this.btnUlang.Text = "Ulangi";
            this.btnUlang.UseVisualStyleBackColor = true;
            this.btnUlang.Click += new System.EventHandler(this.btnUlang_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 400);
            this.Controls.Add(this.btnUlang);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtPemakaian);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTagihan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNoPelanggan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGolongan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoRek);
            this.Controls.Add(this.labelNoRek);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Tagihan Listrik";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPemakaian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNoRek;
        private System.Windows.Forms.TextBox txtNoRek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGolongan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoPelanggan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTagihan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown txtPemakaian;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker txtTanggal;
        private System.Windows.Forms.Button btnUlang;
        private System.Windows.Forms.ImageList imageList1;
    }
}

