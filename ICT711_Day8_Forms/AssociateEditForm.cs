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
    public partial class AssociateEditForm : Form
    {
        public Associate associateEdit { get; set; }
        public Associate sendAssociate;
        public AssociateEditForm()
        {
            InitializeComponent();
        }

        private void AssociateEditForm_Load(object sender, EventArgs e)
        {
            fNameTXT.Text = associateEdit.FName.ToString();
            lNameTXT.Text = associateEdit.LName.ToString();
            departmentTXT.Text = associateEdit.Department.ToString();
            jobDescriptionTXT.Text = associateEdit.JobDescription.ToString();
            managerIDTXT.Text = associateEdit.ManagerId.ToString();
            phoneNumberTXT.Text = associateEdit.Tel.ToString();
            emailTXT.Text = associateEdit.Email.ToString();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            sendAssociate = new Associate(associateEdit.AssociateId, fNameTXT.Text.ToString(), lNameTXT.Text.ToString(),
                phoneNumberTXT.Text.ToString(), emailTXT.Text.ToString(), departmentTXT.Text.ToString(),
                jobDescriptionTXT.Text.ToString(), Convert.ToInt32(managerIDTXT.Text));
            DialogResult = DialogResult.OK; //Return OK
            Close(); //Close form
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            int mID;
            try
            {
                mID = Convert.ToInt32(managerIDTXT.Text);
            }
            catch
            {
                mID = associateEdit.ManagerId;
            }

            sendAssociate = new Associate(associateEdit.AssociateId, fNameTXT.Text.ToString(), lNameTXT.Text.ToString(),
                phoneNumberTXT.Text.ToString(), emailTXT.Text.ToString(), departmentTXT.Text.ToString(),
                jobDescriptionTXT.Text.ToString(), mID);

            if (associateEdit.FName != sendAssociate.FName ||
                associateEdit.LName != sendAssociate.LName ||
                associateEdit.Department != sendAssociate.Department ||
                associateEdit.JobDescription != sendAssociate.JobDescription ||
                associateEdit.ManagerId != sendAssociate.ManagerId ||
                associateEdit.Tel != sendAssociate.Tel ||
                associateEdit.Email != sendAssociate.Email)
            {
                DialogResult dialogResult = MessageBox.Show("Unsaved changes will be lost. Discard changes?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Close();
            }
            else
                Close();
        }
    }
}
