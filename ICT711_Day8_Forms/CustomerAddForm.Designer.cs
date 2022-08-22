namespace ICT711_Day8_Forms
{
    partial class CustomerAddForm
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
            this.associateIDTXT = new System.Windows.Forms.TextBox();
            this.associateIDLBL = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.phoneNumberTXT = new System.Windows.Forms.TextBox();
            this.lNameTXT = new System.Windows.Forms.TextBox();
            this.fNameTXT = new System.Windows.Forms.TextBox();
            this.emailLBL = new System.Windows.Forms.Label();
            this.phoneNumberLBL = new System.Windows.Forms.Label();
            this.lNameLBL = new System.Windows.Forms.Label();
            this.fNameLBL = new System.Windows.Forms.Label();
            this.customerIDTXT = new System.Windows.Forms.TextBox();
            this.customerIDLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // associateIDTXT
            // 
            this.associateIDTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.associateIDTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.associateIDTXT.Location = new System.Drawing.Point(109, 41);
            this.associateIDTXT.Name = "associateIDTXT";
            this.associateIDTXT.ReadOnly = true;
            this.associateIDTXT.Size = new System.Drawing.Size(253, 23);
            this.associateIDTXT.TabIndex = 7;
            // 
            // associateIDLBL
            // 
            this.associateIDLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.associateIDLBL.AutoSize = true;
            this.associateIDLBL.Location = new System.Drawing.Point(11, 44);
            this.associateIDLBL.Name = "associateIDLBL";
            this.associateIDLBL.Size = new System.Drawing.Size(74, 15);
            this.associateIDLBL.TabIndex = 53;
            this.associateIDLBL.Text = "Associate ID:";
            // 
            // addBTN
            // 
            this.addBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBTN.Location = new System.Drawing.Point(206, 204);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 4;
            this.addBTN.Text = "&Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.Location = new System.Drawing.Point(287, 204);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 5;
            this.closeBTN.Text = "&Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // emailTXT
            // 
            this.emailTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTXT.Location = new System.Drawing.Point(109, 157);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(253, 23);
            this.emailTXT.TabIndex = 3;
            // 
            // phoneNumberTXT
            // 
            this.phoneNumberTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTXT.Location = new System.Drawing.Point(109, 128);
            this.phoneNumberTXT.Name = "phoneNumberTXT";
            this.phoneNumberTXT.Size = new System.Drawing.Size(253, 23);
            this.phoneNumberTXT.TabIndex = 2;
            // 
            // lNameTXT
            // 
            this.lNameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameTXT.Location = new System.Drawing.Point(109, 99);
            this.lNameTXT.Name = "lNameTXT";
            this.lNameTXT.Size = new System.Drawing.Size(253, 23);
            this.lNameTXT.TabIndex = 1;
            // 
            // fNameTXT
            // 
            this.fNameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameTXT.Location = new System.Drawing.Point(109, 70);
            this.fNameTXT.Name = "fNameTXT";
            this.fNameTXT.Size = new System.Drawing.Size(253, 23);
            this.fNameTXT.TabIndex = 0;
            // 
            // emailLBL
            // 
            this.emailLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(12, 160);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(39, 15);
            this.emailLBL.TabIndex = 43;
            this.emailLBL.Text = "Email:";
            // 
            // phoneNumberLBL
            // 
            this.phoneNumberLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLBL.AutoSize = true;
            this.phoneNumberLBL.Location = new System.Drawing.Point(12, 131);
            this.phoneNumberLBL.Name = "phoneNumberLBL";
            this.phoneNumberLBL.Size = new System.Drawing.Size(91, 15);
            this.phoneNumberLBL.TabIndex = 42;
            this.phoneNumberLBL.Text = "Phone Number:";
            // 
            // lNameLBL
            // 
            this.lNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameLBL.AutoSize = true;
            this.lNameLBL.Location = new System.Drawing.Point(12, 102);
            this.lNameLBL.Name = "lNameLBL";
            this.lNameLBL.Size = new System.Drawing.Size(66, 15);
            this.lNameLBL.TabIndex = 38;
            this.lNameLBL.Text = "Last Name:";
            // 
            // fNameLBL
            // 
            this.fNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameLBL.AutoSize = true;
            this.fNameLBL.Location = new System.Drawing.Point(11, 73);
            this.fNameLBL.Name = "fNameLBL";
            this.fNameLBL.Size = new System.Drawing.Size(67, 15);
            this.fNameLBL.TabIndex = 37;
            this.fNameLBL.Text = "First Name:";
            // 
            // customerIDTXT
            // 
            this.customerIDTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDTXT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerIDTXT.Location = new System.Drawing.Point(109, 12);
            this.customerIDTXT.Name = "customerIDTXT";
            this.customerIDTXT.ReadOnly = true;
            this.customerIDTXT.Size = new System.Drawing.Size(253, 23);
            this.customerIDTXT.TabIndex = 6;
            // 
            // customerIDLBL
            // 
            this.customerIDLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDLBL.AutoSize = true;
            this.customerIDLBL.Location = new System.Drawing.Point(12, 15);
            this.customerIDLBL.Name = "customerIDLBL";
            this.customerIDLBL.Size = new System.Drawing.Size(76, 15);
            this.customerIDLBL.TabIndex = 55;
            this.customerIDLBL.Text = "Customer ID:";
            // 
            // CustomerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 237);
            this.Controls.Add(this.customerIDTXT);
            this.Controls.Add(this.customerIDLBL);
            this.Controls.Add(this.associateIDTXT);
            this.Controls.Add(this.associateIDLBL);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.phoneNumberTXT);
            this.Controls.Add(this.lNameTXT);
            this.Controls.Add(this.fNameTXT);
            this.Controls.Add(this.emailLBL);
            this.Controls.Add(this.phoneNumberLBL);
            this.Controls.Add(this.lNameLBL);
            this.Controls.Add(this.fNameLBL);
            this.Name = "CustomerAddForm";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustomerAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox associateIDTXT;
        private System.Windows.Forms.Label associateIDLBL;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.TextBox phoneNumberTXT;
        private System.Windows.Forms.TextBox lNameTXT;
        private System.Windows.Forms.TextBox fNameTXT;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label phoneNumberLBL;
        private System.Windows.Forms.Label lNameLBL;
        private System.Windows.Forms.Label fNameLBL;
        private System.Windows.Forms.TextBox customerIDTXT;
        private System.Windows.Forms.Label customerIDLBL;
    }
}