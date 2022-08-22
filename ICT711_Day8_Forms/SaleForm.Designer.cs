
namespace ICT711_Day8_Forms
{
    partial class SaleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pgGridView = new System.Windows.Forms.DataGridView();
            this.productListGridView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeBTN = new System.Windows.Forms.Button();
            this.totalSumLBL = new System.Windows.Forms.Label();
            this.totalLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(607, 54);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pgGridView
            // 
            this.pgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pgGridView.Location = new System.Drawing.Point(12, 228);
            this.pgGridView.Name = "pgGridView";
            this.pgGridView.ReadOnly = true;
            this.pgGridView.RowTemplate.Height = 25;
            this.pgGridView.Size = new System.Drawing.Size(373, 150);
            this.pgGridView.TabIndex = 6;
            // 
            // productListGridView
            // 
            this.productListGridView.AllowUserToAddRows = false;
            this.productListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Description,
            this.Price,
            this.Quantity});
            this.productListGridView.Location = new System.Drawing.Point(12, 72);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.ReadOnly = true;
            this.productListGridView.RowTemplate.Height = 25;
            this.productListGridView.Size = new System.Drawing.Size(445, 150);
            this.productListGridView.TabIndex = 5;
            this.productListGridView.SelectionChanged += new System.EventHandler(this.productListGridView_SelectionChanged);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.Location = new System.Drawing.Point(545, 355);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 7;
            this.closeBTN.Text = "&Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // totalSumLBL
            // 
            this.totalSumLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSumLBL.AutoSize = true;
            this.totalSumLBL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalSumLBL.Location = new System.Drawing.Point(464, 266);
            this.totalSumLBL.Name = "totalSumLBL";
            this.totalSumLBL.Size = new System.Drawing.Size(24, 37);
            this.totalSumLBL.TabIndex = 9;
            this.totalSumLBL.Text = " ";
            // 
            // totalLBL
            // 
            this.totalLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLBL.AutoSize = true;
            this.totalLBL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLBL.Location = new System.Drawing.Point(391, 266);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(80, 37);
            this.totalLBL.TabIndex = 8;
            this.totalLBL.Text = "Total:";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.totalSumLBL);
            this.Controls.Add(this.totalLBL);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.pgGridView);
            this.Controls.Add(this.productListGridView);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaleForm";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView pgGridView;
        private System.Windows.Forms.DataGridView productListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label totalSumLBL;
        private System.Windows.Forms.Label totalLBL;
    }
}