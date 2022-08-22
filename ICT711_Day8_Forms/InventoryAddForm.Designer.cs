namespace Store_Project.ICT711_Day8_Forms
{
    partial class InventoryAddForm
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
            this.productNameLBL = new System.Windows.Forms.Label();
            this.descriptionLBL = new System.Windows.Forms.Label();
            this.priceLBL = new System.Windows.Forms.Label();
            this.quantityLBL = new System.Windows.Forms.Label();
            this.sizeCB = new System.Windows.Forms.ComboBox();
            this.sizeLBL = new System.Windows.Forms.Label();
            this.garmentViewDGV = new System.Windows.Forms.DataGridView();
            this.productNameTXT = new System.Windows.Forms.TextBox();
            this.descriptionTXT = new System.Windows.Forms.TextBox();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.quantatyTXT = new System.Windows.Forms.TextBox();
            this.garmentCheckBox = new System.Windows.Forms.CheckBox();
            this.finishBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.garmentViewDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLBL
            // 
            this.productNameLBL.AutoSize = true;
            this.productNameLBL.Location = new System.Drawing.Point(12, 9);
            this.productNameLBL.Name = "productNameLBL";
            this.productNameLBL.Size = new System.Drawing.Size(87, 15);
            this.productNameLBL.TabIndex = 0;
            this.productNameLBL.Text = "Product Name:";
            // 
            // descriptionLBL
            // 
            this.descriptionLBL.AutoSize = true;
            this.descriptionLBL.Location = new System.Drawing.Point(12, 38);
            this.descriptionLBL.Name = "descriptionLBL";
            this.descriptionLBL.Size = new System.Drawing.Size(70, 15);
            this.descriptionLBL.TabIndex = 1;
            this.descriptionLBL.Text = "Description:";
            // 
            // priceLBL
            // 
            this.priceLBL.AutoSize = true;
            this.priceLBL.Location = new System.Drawing.Point(12, 67);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(36, 15);
            this.priceLBL.TabIndex = 2;
            this.priceLBL.Text = "Price:";
            // 
            // quantityLBL
            // 
            this.quantityLBL.AutoSize = true;
            this.quantityLBL.Location = new System.Drawing.Point(12, 96);
            this.quantityLBL.Name = "quantityLBL";
            this.quantityLBL.Size = new System.Drawing.Size(56, 15);
            this.quantityLBL.TabIndex = 3;
            this.quantityLBL.Text = "Quantity:";
            // 
            // sizeCB
            // 
            this.sizeCB.Enabled = false;
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.Location = new System.Drawing.Point(105, 171);
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(121, 23);
            this.sizeCB.TabIndex = 4;
            // 
            // sizeLBL
            // 
            this.sizeLBL.AutoSize = true;
            this.sizeLBL.Location = new System.Drawing.Point(12, 174);
            this.sizeLBL.Name = "sizeLBL";
            this.sizeLBL.Size = new System.Drawing.Size(30, 15);
            this.sizeLBL.TabIndex = 5;
            this.sizeLBL.Text = "Size:";
            // 
            // garmentViewDGV
            // 
            this.garmentViewDGV.AllowUserToAddRows = false;
            this.garmentViewDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.garmentViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garmentViewDGV.Enabled = false;
            this.garmentViewDGV.Location = new System.Drawing.Point(12, 213);
            this.garmentViewDGV.Name = "garmentViewDGV";
            this.garmentViewDGV.RowTemplate.Height = 25;
            this.garmentViewDGV.Size = new System.Drawing.Size(240, 150);
            this.garmentViewDGV.TabIndex = 6;
            // 
            // productNameTXT
            // 
            this.productNameTXT.Location = new System.Drawing.Point(105, 6);
            this.productNameTXT.Name = "productNameTXT";
            this.productNameTXT.Size = new System.Drawing.Size(100, 23);
            this.productNameTXT.TabIndex = 7;
            // 
            // descriptionTXT
            // 
            this.descriptionTXT.Location = new System.Drawing.Point(105, 35);
            this.descriptionTXT.Name = "descriptionTXT";
            this.descriptionTXT.Size = new System.Drawing.Size(100, 23);
            this.descriptionTXT.TabIndex = 8;
            // 
            // priceTXT
            // 
            this.priceTXT.Location = new System.Drawing.Point(105, 64);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(100, 23);
            this.priceTXT.TabIndex = 9;
            // 
            // quantatyTXT
            // 
            this.quantatyTXT.Location = new System.Drawing.Point(105, 93);
            this.quantatyTXT.Name = "quantatyTXT";
            this.quantatyTXT.Size = new System.Drawing.Size(100, 23);
            this.quantatyTXT.TabIndex = 10;
            // 
            // garmentCheckBox
            // 
            this.garmentCheckBox.AutoSize = true;
            this.garmentCheckBox.Location = new System.Drawing.Point(12, 146);
            this.garmentCheckBox.Name = "garmentCheckBox";
            this.garmentCheckBox.Size = new System.Drawing.Size(117, 19);
            this.garmentCheckBox.TabIndex = 11;
            this.garmentCheckBox.Text = "Product Garment";
            this.garmentCheckBox.UseVisualStyleBackColor = true;
            this.garmentCheckBox.CheckedChanged += new System.EventHandler(this.garmentCheckBox_CheckedChanged);
            // 
            // finishBTN
            // 
            this.finishBTN.Location = new System.Drawing.Point(13, 395);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(86, 23);
            this.finishBTN.TabIndex = 12;
            this.finishBTN.Text = "Finish";
            this.finishBTN.UseVisualStyleBackColor = true;
            this.finishBTN.Click += new System.EventHandler(this.finishBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Enabled = false;
            this.addBTN.Location = new System.Drawing.Point(258, 213);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(98, 23);
            this.addBTN.TabIndex = 13;
            this.addBTN.Text = "Add Garment";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Enabled = false;
            this.editBTN.Location = new System.Drawing.Point(258, 242);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(98, 23);
            this.editBTN.TabIndex = 14;
            this.editBTN.Text = "Edit Garment";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Enabled = false;
            this.deleteBTN.Location = new System.Drawing.Point(258, 271);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(98, 23);
            this.deleteBTN.TabIndex = 15;
            this.deleteBTN.Text = "Delete Garment";
            this.deleteBTN.UseVisualStyleBackColor = true;
            // 
            // InventoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.finishBTN);
            this.Controls.Add(this.garmentCheckBox);
            this.Controls.Add(this.quantatyTXT);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.descriptionTXT);
            this.Controls.Add(this.productNameTXT);
            this.Controls.Add(this.garmentViewDGV);
            this.Controls.Add(this.sizeLBL);
            this.Controls.Add(this.sizeCB);
            this.Controls.Add(this.quantityLBL);
            this.Controls.Add(this.priceLBL);
            this.Controls.Add(this.descriptionLBL);
            this.Controls.Add(this.productNameLBL);
            this.Name = "InventoryAddForm";
            this.Text = "InventoryAddForm";
            this.Load += new System.EventHandler(this.InventoryAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.garmentViewDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productNameLBL;
        private Label descriptionLBL;
        private Label priceLBL;
        private Label quantityLBL;
        private ComboBox sizeCB;
        private Label sizeLBL;
        private DataGridView garmentViewDGV;
        private TextBox productNameTXT;
        private TextBox descriptionTXT;
        private TextBox priceTXT;
        private TextBox quantatyTXT;
        private CheckBox garmentCheckBox;
        private Button finishBTN;
        private Button addBTN;
        private Button editBTN;
        private Button deleteBTN;
    }
}