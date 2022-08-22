namespace ICT711_Day8_Forms
{
    partial class AssociatesForm
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
            this.associatesGridView = new System.Windows.Forms.DataGridView();
            this.AssociateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameLBL = new System.Windows.Forms.Label();
            this.lNameLBL = new System.Windows.Forms.Label();
            this.departmentLBL = new System.Windows.Forms.Label();
            this.jobDescriptionLBL = new System.Windows.Forms.Label();
            this.managerIDLBL = new System.Windows.Forms.Label();
            this.phoneNumberLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.fNameTXT = new System.Windows.Forms.TextBox();
            this.lNameTXT = new System.Windows.Forms.TextBox();
            this.departmentTXT = new System.Windows.Forms.TextBox();
            this.jobDescriptionTXT = new System.Windows.Forms.TextBox();
            this.managerIDTXT = new System.Windows.Forms.TextBox();
            this.phoneNumberTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.continueBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.associatesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // associatesGridView
            // 
            this.associatesGridView.AllowUserToAddRows = false;
            this.associatesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.associatesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.associatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssociateId,
            this.FName,
            this.LName});
            this.associatesGridView.Location = new System.Drawing.Point(12, 12);
            this.associatesGridView.Name = "associatesGridView";
            this.associatesGridView.RowTemplate.Height = 25;
            this.associatesGridView.Size = new System.Drawing.Size(350, 213);
            this.associatesGridView.TabIndex = 0;
            this.associatesGridView.SelectionChanged += new System.EventHandler(this.associatesGridView_SelectionChanged);
            // 
            // AssociateId
            // 
            this.AssociateId.DataPropertyName = "AssociateId";
            this.AssociateId.HeaderText = "Associate ID";
            this.AssociateId.Name = "AssociateId";
            this.AssociateId.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "First Name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Last Name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // fNameLBL
            // 
            this.fNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameLBL.AutoSize = true;
            this.fNameLBL.Location = new System.Drawing.Point(11, 234);
            this.fNameLBL.Name = "fNameLBL";
            this.fNameLBL.Size = new System.Drawing.Size(67, 15);
            this.fNameLBL.TabIndex = 13;
            this.fNameLBL.Text = "First Name:";
            // 
            // lNameLBL
            // 
            this.lNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameLBL.AutoSize = true;
            this.lNameLBL.Location = new System.Drawing.Point(12, 263);
            this.lNameLBL.Name = "lNameLBL";
            this.lNameLBL.Size = new System.Drawing.Size(66, 15);
            this.lNameLBL.TabIndex = 14;
            this.lNameLBL.Text = "Last Name:";
            // 
            // departmentLBL
            // 
            this.departmentLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentLBL.AutoSize = true;
            this.departmentLBL.Location = new System.Drawing.Point(12, 292);
            this.departmentLBL.Name = "departmentLBL";
            this.departmentLBL.Size = new System.Drawing.Size(73, 15);
            this.departmentLBL.TabIndex = 15;
            this.departmentLBL.Text = "Department:";
            // 
            // jobDescriptionLBL
            // 
            this.jobDescriptionLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDescriptionLBL.AutoSize = true;
            this.jobDescriptionLBL.Location = new System.Drawing.Point(12, 321);
            this.jobDescriptionLBL.Name = "jobDescriptionLBL";
            this.jobDescriptionLBL.Size = new System.Drawing.Size(91, 15);
            this.jobDescriptionLBL.TabIndex = 16;
            this.jobDescriptionLBL.Text = "Job Description:";
            // 
            // managerIDLBL
            // 
            this.managerIDLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerIDLBL.AutoSize = true;
            this.managerIDLBL.Location = new System.Drawing.Point(12, 350);
            this.managerIDLBL.Name = "managerIDLBL";
            this.managerIDLBL.Size = new System.Drawing.Size(71, 15);
            this.managerIDLBL.TabIndex = 17;
            this.managerIDLBL.Text = "Manager ID:";
            // 
            // phoneNumberLBL
            // 
            this.phoneNumberLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLBL.AutoSize = true;
            this.phoneNumberLBL.Location = new System.Drawing.Point(12, 379);
            this.phoneNumberLBL.Name = "phoneNumberLBL";
            this.phoneNumberLBL.Size = new System.Drawing.Size(91, 15);
            this.phoneNumberLBL.TabIndex = 18;
            this.phoneNumberLBL.Text = "Phone Number:";
            // 
            // emailLBL
            // 
            this.emailLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(12, 408);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(39, 15);
            this.emailLBL.TabIndex = 19;
            this.emailLBL.Text = "Email:";
            // 
            // fNameTXT
            // 
            this.fNameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fNameTXT.Location = new System.Drawing.Point(109, 231);
            this.fNameTXT.Name = "fNameTXT";
            this.fNameTXT.ReadOnly = true;
            this.fNameTXT.Size = new System.Drawing.Size(253, 23);
            this.fNameTXT.TabIndex = 1;
            // 
            // lNameTXT
            // 
            this.lNameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lNameTXT.Location = new System.Drawing.Point(109, 260);
            this.lNameTXT.Name = "lNameTXT";
            this.lNameTXT.ReadOnly = true;
            this.lNameTXT.Size = new System.Drawing.Size(253, 23);
            this.lNameTXT.TabIndex = 2;
            // 
            // departmentTXT
            // 
            this.departmentTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.departmentTXT.Location = new System.Drawing.Point(109, 289);
            this.departmentTXT.Name = "departmentTXT";
            this.departmentTXT.ReadOnly = true;
            this.departmentTXT.Size = new System.Drawing.Size(253, 23);
            this.departmentTXT.TabIndex = 3;
            // 
            // jobDescriptionTXT
            // 
            this.jobDescriptionTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDescriptionTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.jobDescriptionTXT.Location = new System.Drawing.Point(109, 318);
            this.jobDescriptionTXT.Name = "jobDescriptionTXT";
            this.jobDescriptionTXT.ReadOnly = true;
            this.jobDescriptionTXT.Size = new System.Drawing.Size(253, 23);
            this.jobDescriptionTXT.TabIndex = 4;
            // 
            // managerIDTXT
            // 
            this.managerIDTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerIDTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.managerIDTXT.Location = new System.Drawing.Point(109, 347);
            this.managerIDTXT.Name = "managerIDTXT";
            this.managerIDTXT.ReadOnly = true;
            this.managerIDTXT.Size = new System.Drawing.Size(253, 23);
            this.managerIDTXT.TabIndex = 5;
            // 
            // phoneNumberTXT
            // 
            this.phoneNumberTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.phoneNumberTXT.Location = new System.Drawing.Point(109, 376);
            this.phoneNumberTXT.Name = "phoneNumberTXT";
            this.phoneNumberTXT.ReadOnly = true;
            this.phoneNumberTXT.Size = new System.Drawing.Size(253, 23);
            this.phoneNumberTXT.TabIndex = 6;
            // 
            // emailTXT
            // 
            this.emailTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailTXT.Location = new System.Drawing.Point(109, 405);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.ReadOnly = true;
            this.emailTXT.Size = new System.Drawing.Size(253, 23);
            this.emailTXT.TabIndex = 7;
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.Location = new System.Drawing.Point(287, 452);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 10;
            this.closeBTN.Text = "&Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBTN.Location = new System.Drawing.Point(206, 452);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(75, 23);
            this.editBTN.TabIndex = 9;
            this.editBTN.Text = "&Edit";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBTN.Location = new System.Drawing.Point(125, 452);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 8;
            this.addBTN.Text = "&Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // continueBTN
            // 
            this.continueBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueBTN.Enabled = false;
            this.continueBTN.Location = new System.Drawing.Point(3, 426);
            this.continueBTN.Name = "continueBTN";
            this.continueBTN.Size = new System.Drawing.Size(75, 23);
            this.continueBTN.TabIndex = 11;
            this.continueBTN.Text = "Continue";
            this.continueBTN.UseVisualStyleBackColor = true;
            this.continueBTN.Visible = false;
            this.continueBTN.Click += new System.EventHandler(this.continueBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBTN.Enabled = false;
            this.backBTN.Location = new System.Drawing.Point(3, 455);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Visible = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // AssociatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 488);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.continueBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.phoneNumberTXT);
            this.Controls.Add(this.managerIDTXT);
            this.Controls.Add(this.jobDescriptionTXT);
            this.Controls.Add(this.departmentTXT);
            this.Controls.Add(this.lNameTXT);
            this.Controls.Add(this.fNameTXT);
            this.Controls.Add(this.emailLBL);
            this.Controls.Add(this.phoneNumberLBL);
            this.Controls.Add(this.managerIDLBL);
            this.Controls.Add(this.jobDescriptionLBL);
            this.Controls.Add(this.departmentLBL);
            this.Controls.Add(this.lNameLBL);
            this.Controls.Add(this.fNameLBL);
            this.Controls.Add(this.associatesGridView);
            this.Name = "AssociatesForm";
            this.Text = "Associates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssociatesForm_FormClosing);
            this.Load += new System.EventHandler(this.AssociatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associatesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView associatesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.Label fNameLBL;
        private System.Windows.Forms.Label lNameLBL;
        private System.Windows.Forms.Label departmentLBL;
        private System.Windows.Forms.Label jobDescriptionLBL;
        private System.Windows.Forms.Label managerIDLBL;
        private System.Windows.Forms.Label phoneNumberLBL;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.TextBox fNameTXT;
        private System.Windows.Forms.TextBox lNameTXT;
        private System.Windows.Forms.TextBox departmentTXT;
        private System.Windows.Forms.TextBox jobDescriptionTXT;
        private System.Windows.Forms.TextBox managerIDTXT;
        private System.Windows.Forms.TextBox phoneNumberTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button continueBTN;
        private System.Windows.Forms.Button backBTN;
    }
}