namespace ICT711_Day8_Forms
{
    partial class CheckOutForm
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
            this.productListGridView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.checkOutBTN = new System.Windows.Forms.Button();
            this.pgGridView = new System.Windows.Forms.DataGridView();
            this.totalLBL = new System.Windows.Forms.Label();
            this.totalSumLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productListGridView
            // 
            this.productListGridView.AllowUserToAddRows = false;
            this.productListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Description,
            this.Price,
            this.Quantity});
            this.productListGridView.Location = new System.Drawing.Point(12, 12);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.RowTemplate.Height = 25;
            this.productListGridView.Size = new System.Drawing.Size(445, 150);
            this.productListGridView.TabIndex = 0;
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
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBTN.Location = new System.Drawing.Point(174, 362);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 4;
            this.backBTN.Text = "&Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBTN.Location = new System.Drawing.Point(93, 362);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(75, 23);
            this.removeBTN.TabIndex = 3;
            this.removeBTN.Text = "&Remove";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // checkOutBTN
            // 
            this.checkOutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkOutBTN.Location = new System.Drawing.Point(12, 362);
            this.checkOutBTN.Name = "checkOutBTN";
            this.checkOutBTN.Size = new System.Drawing.Size(75, 23);
            this.checkOutBTN.TabIndex = 2;
            this.checkOutBTN.Text = "&Check Out";
            this.checkOutBTN.UseVisualStyleBackColor = true;
            this.checkOutBTN.Click += new System.EventHandler(this.checkOutBTN_Click);
            // 
            // pgGridView
            // 
            this.pgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pgGridView.Location = new System.Drawing.Point(53, 168);
            this.pgGridView.Name = "pgGridView";
            this.pgGridView.RowTemplate.Height = 25;
            this.pgGridView.Size = new System.Drawing.Size(373, 150);
            this.pgGridView.TabIndex = 1;
            // 
            // totalLBL
            // 
            this.totalLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLBL.AutoSize = true;
            this.totalLBL.Location = new System.Drawing.Point(12, 333);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(35, 15);
            this.totalLBL.TabIndex = 5;
            this.totalLBL.Text = "Total:";
            // 
            // totalSumLBL
            // 
            this.totalSumLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalSumLBL.AutoSize = true;
            this.totalSumLBL.Location = new System.Drawing.Point(53, 333);
            this.totalSumLBL.Name = "totalSumLBL";
            this.totalSumLBL.Size = new System.Drawing.Size(10, 15);
            this.totalSumLBL.TabIndex = 6;
            this.totalSumLBL.Text = " ";
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 390);
            this.Controls.Add(this.totalSumLBL);
            this.Controls.Add(this.totalLBL);
            this.Controls.Add(this.pgGridView);
            this.Controls.Add(this.checkOutBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.productListGridView);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productListGridView;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button checkOutBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridView pgGridView;
        private System.Windows.Forms.Label totalLBL;
        private System.Windows.Forms.Label totalSumLBL;
    }
}