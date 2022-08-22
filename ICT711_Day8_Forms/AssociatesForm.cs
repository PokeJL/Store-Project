using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICT711_Day5_classes;

namespace ICT711_Day8_Forms
{
    public partial class AssociatesForm : Form
    {
        public List<Associate> AssociatesList { get; set; }
        public Associate selectedAssociate { get; set; }
        public int selction { get; set; }
        public bool locked { get; set; }
        public bool buying { get; set; }
        public bool assSelect { get; set; }
        public int cID { get; set; }
        public List<Sale> SaleList { get; set; }
        public List<Customer> customerList { get; set; }
        public Inventory currentInventory { get; set; }
        public AssociatesForm()
        {
            InitializeComponent();
        }

        private void AssociatesForm_Load(object sender, EventArgs e)
        {
            associatesGridView.AutoGenerateColumns = false;
            associatesGridView.DataSource = AssociatesList;



            associatesGridView.CurrentCell = associatesGridView[0, AssociatesList.IndexOf(AssociatesList.Single(al => al.AssociateId == selction))];
            selectedAssociate = AssociatesList[AssociatesList.IndexOf(AssociatesList.Single(al => al.AssociateId == selction))];
            fNameTXT.Text = selectedAssociate.FName.ToString();
            lNameTXT.Text = selectedAssociate.LName.ToString();
            departmentTXT.Text = selectedAssociate.Department.ToString();
            jobDescriptionTXT.Text = selectedAssociate.JobDescription.ToString();
            managerIDTXT.Text = selectedAssociate.ManagerId.ToString();
            phoneNumberTXT.Text = selectedAssociate.Tel.ToString();
            emailTXT.Text = selectedAssociate.Email.ToString();
            if (locked == true)
            {
                associatesGridView.Rows[AssociatesList.IndexOf(AssociatesList.Single(al => al.AssociateId == selction))].Cells[1].Selected = true;
                associatesGridView.Rows[AssociatesList.IndexOf(AssociatesList.Single(al => al.AssociateId == selction))].Cells[2].Selected = true;
                associatesGridView.Enabled = false;
                addBTN.Enabled = false;
                addBTN.Visible = false;

                associatesGridView.DefaultCellStyle.BackColor = Color.Black;
            }
            else if (buying == true || assSelect == true)
            {
                closeBTN.Visible = false;
                closeBTN.Enabled = false;
                addBTN.Visible = false;
                addBTN.Enabled = false;
                editBTN.Visible = false;
                editBTN.Enabled = false;
                continueBTN.Visible = true;
                continueBTN.Enabled = true;
                backBTN.Visible = true;
                backBTN.Enabled = true;
            }
        }

        private void associatesGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectedAssociate = (Associate)((DataGridView)sender).CurrentRow.DataBoundItem;
            }
            catch { }
            fNameTXT.Text = selectedAssociate.FName.ToString();
            lNameTXT.Text = selectedAssociate.LName.ToString();
            departmentTXT.Text = selectedAssociate.Department.ToString();
            jobDescriptionTXT.Text = selectedAssociate.JobDescription.ToString();
            managerIDTXT.Text = selectedAssociate.ManagerId.ToString();
            phoneNumberTXT.Text = selectedAssociate.Tel.ToString();
            emailTXT.Text = selectedAssociate.Email.ToString();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //Return OK
            Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;
            using (AssociateEditForm aef = new AssociateEditForm())
            {
                aef.associateEdit = selectedAssociate;
                if(aef.ShowDialog() == DialogResult.OK)
                {
                    AssociatesList[AssociatesList.IndexOf(selectedAssociate)] = aef.sendAssociate;
                    associatesGridView.Update();
                    associatesGridView.Refresh();

                    fNameTXT.Text = aef.sendAssociate.FName.ToString();
                    lNameTXT.Text = aef.sendAssociate.LName.ToString();
                    departmentTXT.Text = aef.sendAssociate.Department.ToString();
                    jobDescriptionTXT.Text = aef.sendAssociate.JobDescription.ToString();
                    managerIDTXT.Text = aef.sendAssociate.ManagerId.ToString();
                    phoneNumberTXT.Text = aef.sendAssociate.Tel.ToString();
                    emailTXT.Text = aef.sendAssociate.Email.ToString();
                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;
            using (AssociateAddForm aaf = new AssociateAddForm())
            {
                aaf.associates = AssociatesList;
                if (aaf.ShowDialog() == DialogResult.OK)
                {
                    AssociatesList.Add(aaf.sendAssociate);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = AssociatesList;
                    associatesGridView.DataSource = bSource;
                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }

        private void AssociatesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK; //Return OK
        }

        private void continueBTN_Click(object sender, EventArgs e)
        {
            if (buying == true)
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Is {0} {1} the corrent associate?", selectedAssociate.FName, selectedAssociate.LName), "Continue", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
                    ActiveForm.Opacity = .50;
                    using (InventoryForm inv = new InventoryForm())
                    {
                        inv.cID = cID;
                        inv.aID = selectedAssociate.AssociateId;
                        inv.salesList = SaleList;
                        inv.buying = true;
                        inv.currentInventory = currentInventory;
                        if (inv.ShowDialog() == DialogResult.OK)
                        {
                            SaleList = inv.salesList;
                            currentInventory = inv.currentInventory;
                            DialogResult = DialogResult.OK; //Return OK
                        }
                    }
                    ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
                    ActiveForm.Opacity = 1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Is {0} {1} going to be the main associate?", selectedAssociate.FName, selectedAssociate.LName), "Continue", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
                    ActiveForm.Opacity = .50;
                    using (CustomerAddForm caf = new CustomerAddForm())
                    {
                        caf.customerList = customerList;
                        caf.aID = selectedAssociate.AssociateId;
                        if (caf.ShowDialog() == DialogResult.OK)
                        {
                            customerList = caf.customerList;
                            DialogResult = DialogResult.OK; //Return OK
                        }
                    }
                    ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
                    ActiveForm.Opacity = 1;
                }
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
