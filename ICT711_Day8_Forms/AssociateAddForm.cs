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
    public partial class AssociateAddForm : Form
    {
        public Associate sendAssociate;
        public List<Associate> associates { get; set; }
        private int aID;
        public AssociateAddForm()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Unsaved changes will be lost. Discard changes?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Close();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string errorT = null;

            if (fNameTXT.Text != string.Empty ||
                lNameTXT.Text != string.Empty ||
                phoneNumberTXT.Text != string.Empty ||
                emailTXT.Text != string.Empty ||
                departmentTXT.Text != string.Empty ||
                jobDescriptionTXT.Text != string.Empty ||
                managerIDTXT.Text != string.Empty)
            {

                try
                {
                    Convert.ToInt32(managerIDTXT.Text);
                }
                catch
                {
                    errorT += "Manager ID is not a number.\n";
                }

                if (phoneNumberTXT.Text.Length != 10)
                    errorT += "Phone number must be 10 digits.\n";

                if (!emailTXT.Text.Contains("@") && !emailTXT.Text.Contains("."))
                    errorT += "Email must contain a '.' and a '@'";

                if (errorT == null)
                {
                    sendAssociate = new Associate(aID, fNameTXT.Text.ToString(), lNameTXT.Text.ToString(),
                        phoneNumberTXT.Text.ToString(), emailTXT.Text.ToString(), departmentTXT.Text.ToString(),
                        jobDescriptionTXT.Text.ToString(), Convert.ToInt32(managerIDTXT.Text));

                    DialogResult = DialogResult.OK; //Return OK
                    Close(); //Close form
                }
            }
            else
                errorT = "One or more fields are empty.";

            if (errorT != null)
                MessageBox.Show(errorT);
        }

        private void AssociateAddForm_Load(object sender, EventArgs e)
        {
            if (associates != null)
            {
                for (int i = 1; ; i++)
                {
                    if (associates.Any(al => al.AssociateId == i) == false)
                    {
                        aID = i;
                        break;
                    }
                }
            }
            else
                aID = 1;

            associateIDTXT.Text = aID.ToString();
        }
    }
}
