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
    public partial class CustomerAddForm : Form
    {
        public int aID { get; set; }
        private int cID;
        public List<Customer> customerList { get; set; }
        private Customer customer;
        public CustomerAddForm()
        {
            InitializeComponent();
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; ; i++)
            {
                if (customerList.Any(cl => cl.CustomerId == i) == false)
                {
                    cID = i;
                    break;
                }
            }

            customerIDTXT.Text = cID.ToString();
            associateIDTXT.Text = aID.ToString();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string errorT = null;

            if (fNameTXT.Text != string.Empty ||
                lNameTXT.Text != string.Empty ||
                phoneNumberTXT.Text != string.Empty ||
                emailTXT.Text != string.Empty)
            {

                if (phoneNumberTXT.Text.Length != 10)
                    errorT += "Phone number must be 10 digits.\n";

                if (!emailTXT.Text.Contains("@") && !emailTXT.Text.Contains("."))
                    errorT += "Email must contain a '.' and a '@'";

                if (errorT == null)
                {
                    customer = new Customer(cID, fNameTXT.Text.ToString(), lNameTXT.Text.ToString(),
                        phoneNumberTXT.Text.ToString(), emailTXT.Text.ToString());

                    customer.MainAssociateId = aID;

                    customerList.Add(customer);

                    DialogResult = DialogResult.OK; //Return OK
                    Close(); //Close form
                }
            }
            else
                errorT = "One or more fields are empty.";

            if (errorT != null)
                MessageBox.Show(errorT);
        }
    }
}
