namespace ICT711_Day8_Forms
{
    partial class CustomersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.purchasesGridView = new System.Windows.Forms.DataGridView();
            this.detailsBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryBTN = new System.Windows.Forms.Button();
            this.associatesBTN = new System.Windows.Forms.Button();
            this.purchaseBTN = new System.Windows.Forms.Button();
            this.mainAssociateLLBL = new System.Windows.Forms.LinkLabel();
            this.addCustomerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.FName,
            this.LName,
            this.Tel,
            this.Email,
            this.RegisteredOn});
            this.customersGridView.Location = new System.Drawing.Point(12, 42);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.RowTemplate.Height = 27;
            this.customersGridView.Size = new System.Drawing.Size(776, 255);
            this.customersGridView.TabIndex = 0;
            this.customersGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "ID";
            this.CustomerId.Name = "CustomerId";
            // 
            // FName
            // 
            this.FName.DataPropertyName = "Fname";
            this.FName.HeaderText = "First Name";
            this.FName.Name = "FName";
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Last Name";
            this.LName.Name = "LName";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // RegisteredOn
            // 
            this.RegisteredOn.DataPropertyName = "RegisteredOn";
            this.RegisteredOn.HeaderText = "Registered On";
            this.RegisteredOn.Name = "RegisteredOn";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Associate";
            // 
            // purchasesGridView
            // 
            this.purchasesGridView.AllowUserToAddRows = false;
            this.purchasesGridView.AllowUserToDeleteRows = false;
            this.purchasesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.purchasesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailsBtn});
            this.purchasesGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.purchasesGridView.Location = new System.Drawing.Point(168, 303);
            this.purchasesGridView.MultiSelect = false;
            this.purchasesGridView.Name = "purchasesGridView";
            this.purchasesGridView.ReadOnly = true;
            this.purchasesGridView.RowTemplate.Height = 27;
            this.purchasesGridView.Size = new System.Drawing.Size(407, 109);
            this.purchasesGridView.TabIndex = 1;
            this.purchasesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // detailsBtn
            // 
            this.detailsBtn.HeaderText = "";
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.ReadOnly = true;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseColumnTextForButtonValue = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(643, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 24);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customers";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Purchases";
            // 
            // inventoryBTN
            // 
            this.inventoryBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryBTN.Location = new System.Drawing.Point(689, 332);
            this.inventoryBTN.Name = "inventoryBTN";
            this.inventoryBTN.Size = new System.Drawing.Size(92, 23);
            this.inventoryBTN.TabIndex = 6;
            this.inventoryBTN.Text = "&Inventory";
            this.inventoryBTN.UseVisualStyleBackColor = true;
            this.inventoryBTN.Click += new System.EventHandler(this.inventoryBTN_Click);
            // 
            // associatesBTN
            // 
            this.associatesBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.associatesBTN.Location = new System.Drawing.Point(591, 332);
            this.associatesBTN.Name = "associatesBTN";
            this.associatesBTN.Size = new System.Drawing.Size(92, 23);
            this.associatesBTN.TabIndex = 5;
            this.associatesBTN.Text = "&Associates";
            this.associatesBTN.UseVisualStyleBackColor = true;
            this.associatesBTN.Click += new System.EventHandler(this.associatesBTN_Click);
            // 
            // purchaseBTN
            // 
            this.purchaseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseBTN.Location = new System.Drawing.Point(689, 303);
            this.purchaseBTN.Name = "purchaseBTN";
            this.purchaseBTN.Size = new System.Drawing.Size(92, 23);
            this.purchaseBTN.TabIndex = 4;
            this.purchaseBTN.Text = "&Purchase";
            this.purchaseBTN.UseVisualStyleBackColor = true;
            this.purchaseBTN.Click += new System.EventHandler(this.purchaseBTN_Click);
            // 
            // mainAssociateLLBL
            // 
            this.mainAssociateLLBL.ActiveLinkColor = System.Drawing.Color.Black;
            this.mainAssociateLLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainAssociateLLBL.AutoSize = true;
            this.mainAssociateLLBL.LinkColor = System.Drawing.Color.Black;
            this.mainAssociateLLBL.Location = new System.Drawing.Point(94, 427);
            this.mainAssociateLLBL.Name = "mainAssociateLLBL";
            this.mainAssociateLLBL.Size = new System.Drawing.Size(16, 15);
            this.mainAssociateLLBL.TabIndex = 2;
            this.mainAssociateLLBL.TabStop = true;
            this.mainAssociateLLBL.Text = "...";
            this.mainAssociateLLBL.VisitedLinkColor = System.Drawing.Color.Black;
            this.mainAssociateLLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainAssociateLLBL_LinkClicked);
            // 
            // addCustomerBTN
            // 
            this.addCustomerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerBTN.Location = new System.Drawing.Point(591, 303);
            this.addCustomerBTN.Name = "addCustomerBTN";
            this.addCustomerBTN.Size = new System.Drawing.Size(92, 23);
            this.addCustomerBTN.TabIndex = 3;
            this.addCustomerBTN.Text = "Add &Customer";
            this.addCustomerBTN.UseVisualStyleBackColor = true;
            this.addCustomerBTN.Click += new System.EventHandler(this.addCustomerBTN_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.addCustomerBTN);
            this.Controls.Add(this.mainAssociateLLBL);
            this.Controls.Add(this.purchaseBTN);
            this.Controls.Add(this.associatesBTN);
            this.Controls.Add(this.inventoryBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.purchasesGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersGridView);
            this.Name = "CustomersForm";
            this.Text = "eStore";
            this.Load += new System.EventHandler(this.eStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView purchasesGridView;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inventoryBTN;
        private System.Windows.Forms.Button associatesBTN;
        private System.Windows.Forms.Button purchaseBTN;
        private System.Windows.Forms.LinkLabel mainAssociateLLBL;
        private System.Windows.Forms.Button addCustomerBTN;
        private System.Windows.Forms.DataGridViewButtonColumn detailsBtn;
    }
}

