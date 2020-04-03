namespace RestApiExample
{
    partial class ApiInterface
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
            this.table = new System.Windows.Forms.DataGridView();
            this.Country_Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recovered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country_Region,
            this.confirmed,
            this.deaths,
            this.recovered,
            this.active});
            this.table.Location = new System.Drawing.Point(27, 22);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(543, 259);
            this.table.TabIndex = 0;
            // 
            // Country_Region
            // 
            this.Country_Region.HeaderText = "Negara";
            this.Country_Region.Name = "Country_Region";
            this.Country_Region.ReadOnly = true;
            // 
            // confirmed
            // 
            this.confirmed.HeaderText = "Confirmed";
            this.confirmed.Name = "confirmed";
            this.confirmed.ReadOnly = true;
            // 
            // deaths
            // 
            this.deaths.HeaderText = "Deaths";
            this.deaths.Name = "deaths";
            this.deaths.ReadOnly = true;
            // 
            // recovered
            // 
            this.recovered.HeaderText = "Recovered";
            this.recovered.Name = "recovered";
            this.recovered.ReadOnly = true;
            // 
            // active
            // 
            this.active.HeaderText = "Active";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // ApiInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 302);
            this.Controls.Add(this.table);
            this.Name = "ApiInterface";
            this.Text = "API Example";
            this.Load += new System.EventHandler(this.ApiInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country_Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn deaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn recovered;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
    }
}

