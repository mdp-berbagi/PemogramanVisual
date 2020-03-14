namespace Simple_Post
{
    partial class ipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ipos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputHarga = new System.Windows.Forms.TextBox();
            this.inputBelanja = new System.Windows.Forms.ListView();
            this.inputProduk = new System.Windows.Forms.ComboBox();
            this.inputJumlah = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputTotalBiaya = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // inputHarga
            // 
            resources.ApplyResources(this.inputHarga, "inputHarga");
            this.inputHarga.Name = "inputHarga";
            // 
            // inputBelanja
            // 
            resources.ApplyResources(this.inputBelanja, "inputBelanja");
            this.inputBelanja.HideSelection = false;
            this.inputBelanja.Name = "inputBelanja";
            this.inputBelanja.UseCompatibleStateImageBehavior = false;
            // 
            // inputProduk
            // 
            resources.ApplyResources(this.inputProduk, "inputProduk");
            this.inputProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputProduk.FormattingEnabled = true;
            this.inputProduk.Name = "inputProduk";
            this.inputProduk.SelectedIndexChanged += new System.EventHandler(this.inputProduk_SelectedIndexChanged);
            // 
            // inputJumlah
            // 
            resources.ApplyResources(this.inputJumlah, "inputJumlah");
            this.inputJumlah.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputJumlah.Name = "inputJumlah";
            this.inputJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inputTotalBiaya
            // 
            resources.ApplyResources(this.inputTotalBiaya, "inputTotalBiaya");
            this.inputTotalBiaya.Name = "inputTotalBiaya";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // ipos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputTotalBiaya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputJumlah);
            this.Controls.Add(this.inputProduk);
            this.Controls.Add(this.inputBelanja);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ipos";
            this.Load += new System.EventHandler(this.ipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputHarga;
        private System.Windows.Forms.ListView inputBelanja;
        private System.Windows.Forms.ComboBox inputProduk;
        private System.Windows.Forms.NumericUpDown inputJumlah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputTotalBiaya;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

