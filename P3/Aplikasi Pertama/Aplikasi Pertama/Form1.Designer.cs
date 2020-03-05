namespace Aplikasi_Pertama
{
    partial class Form1
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
            this.grupSumber = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.teksNpm = new System.Windows.Forms.TextBox();
            this.teksNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupTujuan = new System.Windows.Forms.GroupBox();
            this.btnBalikin = new System.Windows.Forms.Button();
            this.labelNpm = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grupSumber.SuspendLayout();
            this.grupTujuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupSumber
            // 
            this.grupSumber.Controls.Add(this.btnSimpan);
            this.grupSumber.Controls.Add(this.teksNpm);
            this.grupSumber.Controls.Add(this.teksNama);
            this.grupSumber.Controls.Add(this.label4);
            this.grupSumber.Controls.Add(this.label3);
            this.grupSumber.Controls.Add(this.label2);
            this.grupSumber.Controls.Add(this.label1);
            this.grupSumber.Location = new System.Drawing.Point(14, 9);
            this.grupSumber.Name = "grupSumber";
            this.grupSumber.Size = new System.Drawing.Size(308, 362);
            this.grupSumber.TabIndex = 0;
            this.grupSumber.TabStop = false;
            this.grupSumber.Text = "Sumber";
            this.grupSumber.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(229, 21);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(57, 47);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // teksNpm
            // 
            this.teksNpm.Location = new System.Drawing.Point(65, 48);
            this.teksNpm.MaxLength = 10;
            this.teksNpm.Name = "teksNpm";
            this.teksNpm.Size = new System.Drawing.Size(155, 20);
            this.teksNpm.TabIndex = 5;
            // 
            // teksNama
            // 
            this.teksNama.Location = new System.Drawing.Point(65, 23);
            this.teksNama.MaxLength = 20;
            this.teksNama.Name = "teksNama";
            this.teksNama.Size = new System.Drawing.Size(155, 20);
            this.teksNama.TabIndex = 4;
            this.teksNama.TextChanged += new System.EventHandler(this.teksNama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grupTujuan
            // 
            this.grupTujuan.Controls.Add(this.btnBalikin);
            this.grupTujuan.Controls.Add(this.labelNpm);
            this.grupTujuan.Controls.Add(this.labelNama);
            this.grupTujuan.Controls.Add(this.label5);
            this.grupTujuan.Controls.Add(this.label6);
            this.grupTujuan.Controls.Add(this.label7);
            this.grupTujuan.Controls.Add(this.label8);
            this.grupTujuan.Location = new System.Drawing.Point(337, 9);
            this.grupTujuan.Name = "grupTujuan";
            this.grupTujuan.Size = new System.Drawing.Size(308, 362);
            this.grupTujuan.TabIndex = 1;
            this.grupTujuan.TabStop = false;
            this.grupTujuan.Text = "Tujuan";
            this.grupTujuan.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBalikin
            // 
            this.btnBalikin.Location = new System.Drawing.Point(230, 21);
            this.btnBalikin.Name = "btnBalikin";
            this.btnBalikin.Size = new System.Drawing.Size(57, 47);
            this.btnBalikin.TabIndex = 10;
            this.btnBalikin.Text = "Balikin";
            this.btnBalikin.UseVisualStyleBackColor = true;
            this.btnBalikin.Click += new System.EventHandler(this.btnBalikin_Click);
            // 
            // labelNpm
            // 
            this.labelNpm.AutoSize = true;
            this.labelNpm.Location = new System.Drawing.Point(59, 52);
            this.labelNpm.Name = "labelNpm";
            this.labelNpm.Size = new System.Drawing.Size(0, 13);
            this.labelNpm.TabIndex = 9;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(59, 27);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(0, 13);
            this.labelNama.TabIndex = 8;
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "NPM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 384);
            this.Controls.Add(this.grupTujuan);
            this.Controls.Add(this.grupSumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Aplikasi Pertama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupSumber.ResumeLayout(false);
            this.grupSumber.PerformLayout();
            this.grupTujuan.ResumeLayout(false);
            this.grupTujuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupSumber;
        private System.Windows.Forms.GroupBox grupTujuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksNpm;
        private System.Windows.Forms.TextBox teksNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label labelNpm;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBalikin;
    }
}

