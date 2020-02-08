namespace DataAccessWithDataAdaptor
{
    partial class Form2
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
            this.btnCustomersAndOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.btnProdCatagories = new System.Windows.Forms.Button();
            this.btnTotalOrders = new System.Windows.Forms.Button();
            this.btnLINQDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomersAndOrders
            // 
            this.btnCustomersAndOrders.Location = new System.Drawing.Point(640, 34);
            this.btnCustomersAndOrders.Name = "btnCustomersAndOrders";
            this.btnCustomersAndOrders.Size = new System.Drawing.Size(112, 42);
            this.btnCustomersAndOrders.TabIndex = 0;
            this.btnCustomersAndOrders.Text = "Customers And Orders";
            this.btnCustomersAndOrders.UseVisualStyleBackColor = true;
            this.btnCustomersAndOrders.Click += new System.EventHandler(this.btnCustomersAndOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Country";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(196, 44);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(156, 21);
            this.cmbCountries.TabIndex = 3;
            this.cmbCountries.Text = "All Countries";
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // btnProdCatagories
            // 
            this.btnProdCatagories.Location = new System.Drawing.Point(431, 42);
            this.btnProdCatagories.Name = "btnProdCatagories";
            this.btnProdCatagories.Size = new System.Drawing.Size(160, 23);
            this.btnProdCatagories.TabIndex = 4;
            this.btnProdCatagories.Text = "Product And  Catagories";
            this.btnProdCatagories.UseVisualStyleBackColor = true;
            this.btnProdCatagories.Click += new System.EventHandler(this.btnProdCatagories_Click);
            // 
            // btnTotalOrders
            // 
            this.btnTotalOrders.Location = new System.Drawing.Point(640, 126);
            this.btnTotalOrders.Name = "btnTotalOrders";
            this.btnTotalOrders.Size = new System.Drawing.Size(112, 30);
            this.btnTotalOrders.TabIndex = 5;
            this.btnTotalOrders.Text = "Total Orders";
            this.btnTotalOrders.UseVisualStyleBackColor = true;
            this.btnTotalOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLINQDS
            // 
            this.btnLINQDS.Location = new System.Drawing.Point(709, 224);
            this.btnLINQDS.Name = "btnLINQDS";
            this.btnLINQDS.Size = new System.Drawing.Size(75, 23);
            this.btnLINQDS.TabIndex = 6;
            this.btnLINQDS.Text = "LINQToDataSet";
            this.btnLINQDS.UseVisualStyleBackColor = true;
            this.btnLINQDS.Click += new System.EventHandler(this.btnLINQDS_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLINQDS);
            this.Controls.Add(this.btnTotalOrders);
            this.Controls.Add(this.btnProdCatagories);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCustomersAndOrders);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomersAndOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Button btnProdCatagories;
        private System.Windows.Forms.Button btnTotalOrders;
        private System.Windows.Forms.Button btnLINQDS;
    }
}