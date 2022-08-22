namespace ICT711_Day8_Forms
{
    partial class InventoryForm
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
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgGridView = new System.Windows.Forms.DataGridView();
            this.closeBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.finishBTN = new System.Windows.Forms.Button();
            this.purchaseBTN = new System.Windows.Forms.Button();
            this.addInvBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Description,
            this.Price,
            this.Quantity});
            this.inventoryGridView.Location = new System.Drawing.Point(12, 12);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.ReadOnly = true;
            this.inventoryGridView.RowTemplate.Height = 25;
            this.inventoryGridView.Size = new System.Drawing.Size(545, 150);
            this.inventoryGridView.TabIndex = 0;
            this.inventoryGridView.SelectionChanged += new System.EventHandler(this.inventoryGridView_SelectionChanged);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            // pgGridView
            // 
            this.pgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pgGridView.Location = new System.Drawing.Point(91, 181);
            this.pgGridView.Name = "pgGridView";
            this.pgGridView.ReadOnly = true;
            this.pgGridView.RowTemplate.Height = 25;
            this.pgGridView.Size = new System.Drawing.Size(373, 150);
            this.pgGridView.TabIndex = 1;
            this.pgGridView.SelectionChanged += new System.EventHandler(this.pgGridView_SelectionChanged);
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.Location = new System.Drawing.Point(482, 308);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "&Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBTN.Enabled = false;
            this.backBTN.Location = new System.Drawing.Point(10, 308);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 5;
            this.backBTN.Text = "&Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Visible = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // finishBTN
            // 
            this.finishBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finishBTN.Enabled = false;
            this.finishBTN.Location = new System.Drawing.Point(10, 279);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(75, 23);
            this.finishBTN.TabIndex = 4;
            this.finishBTN.Text = "&Finish";
            this.finishBTN.UseVisualStyleBackColor = true;
            this.finishBTN.Visible = false;
            this.finishBTN.Click += new System.EventHandler(this.finishBTN_Click);
            // 
            // purchaseBTN
            // 
            this.purchaseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.purchaseBTN.Enabled = false;
            this.purchaseBTN.Location = new System.Drawing.Point(10, 250);
            this.purchaseBTN.Name = "purchaseBTN";
            this.purchaseBTN.Size = new System.Drawing.Size(75, 23);
            this.purchaseBTN.TabIndex = 3;
            this.purchaseBTN.Text = "&Purchase";
            this.purchaseBTN.UseVisualStyleBackColor = true;
            this.purchaseBTN.Visible = false;
            this.purchaseBTN.Click += new System.EventHandler(this.purchaseBTN_Click);
            // 
            // addInvBTN
            // 
            this.addInvBTN.Location = new System.Drawing.Point(482, 279);
            this.addInvBTN.Name = "addInvBTN";
            this.addInvBTN.Size = new System.Drawing.Size(75, 23);
            this.addInvBTN.TabIndex = 6;
            this.addInvBTN.Text = "Add";
            this.addInvBTN.UseVisualStyleBackColor = true;
            this.addInvBTN.Click += new System.EventHandler(this.addInvBTN_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 355);
            this.Controls.Add(this.addInvBTN);
            this.Controls.Add(this.purchaseBTN);
            this.Controls.Add(this.finishBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.pgGridView);
            this.Controls.Add(this.inventoryGridView);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridView pgGridView;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button finishBTN;
        private System.Windows.Forms.Button purchaseBTN;
        private Button addInvBTN;
    }
}