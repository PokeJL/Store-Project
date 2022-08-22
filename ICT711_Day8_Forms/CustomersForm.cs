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
using Store_Project;

namespace ICT711_Day8_Forms
{
    public partial class CustomersForm : Form
    {
        Store store;
        Customer selectedCustomer = null;
        public CustomersForm()
        {
            InitializeComponent();
            Store.AssociatesFileName = "associates_data.json";
            Store.CustomersFileName = "customers_data.json";
            Store.InventoryFileName = "inventory_data.json";
            Store.SalesFileName = "sales_data.json";
            store = new Store();
        }
        class SaleView { public int Id; public DateTime 
                Date { get; set; } public decimal Total { get; set; } }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedCustomer = (Customer)((DataGridView)sender).CurrentRow.DataBoundItem;
            if (selectedCustomer is null) return;   // Make sure there is a current selection
            mainAssociateLLBL.Text = selectedCustomer.GetAssociate(store.Associates);

            // Get the current user purchases and convert the list to SaleView type
            List<SaleView> ss = selectedCustomer.GetPurchases(store.Sales).ConvertAll(s =>
                new SaleView{ Id= s.Id, Date = s.Date, Total= s.GetTotal() });
            // Connect the SaleView list to dataGridView2
            purchasesGridView.DataSource = ss;
        }

        private void eStore_Load(object sender, EventArgs e)
        {
            store.LoadCustomers();
            store.LoadAssociates();
            store.LoadSales();
            store.LoadInventory();
            customersGridView.AutoGenerateColumns = false;
            // Connect the customers list to dataGridView1
            customersGridView.DataSource = store.Customers.ConvertAll(c => (Customer)c);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var salev = (SaleView)grid.Rows[e.RowIndex].DataBoundItem;
                Sale sale = (Sale)store.Sales.Find(s => s.Id == salev.Id);
                using (SaleForm sf = new SaleForm())
                {
                    ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
                    ActiveForm.Opacity = .50;
                    sf.SelectedSale = sale;
                    sf.Sales = store.Sales;
                    sf.cID = selectedCustomer.CustomerId;
                    sf.ID = sale.Id;
                    //sf.ShowDialog();
                    if (sf.ShowDialog() == DialogResult.OK)
                    {

                    }
                    ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
                    ActiveForm.Opacity = 1;
                }
                //MessageBox.Show($"ID-{sale.Id}: {sale.Status}, {sale.Date}", "Sale");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save all data
            store.SaveCustomers();
            store.SaveAssociates();
            store.SaveInventory();
            store.SaveSales();
        }

        private void inventoryBTN_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;
            using (InventoryForm invf = new InventoryForm())
            {
                invf.currentInventory = store.Inventory;
                //invf.ShowDialog();
                if(invf.ShowDialog() == DialogResult.OK)
                {

                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;

        }

        private void associatesBTN_Click(object sender, EventArgs e)
        {
            bool associateAdded = false;

            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;

            associateAdded = NoAssociate();

            if (associateAdded)
            {
                using (AssociatesForm af = new AssociatesForm())
                {
                    
                    af.AssociatesList = store.Associates.ConvertAll(a => (Associate)a);
                    af.selction = af.AssociatesList[0].AssociateId;
                    if (af.ShowDialog() == DialogResult.OK)
                    {
                        store.Associates = af.AssociatesList.ConvertAll(a => (IAssociate)a);
                    }  
                }
            }

            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }

        private void purchaseBTN_Click(object sender, EventArgs e)
        {
            string message = null;

            if (store.Associates.Count != 0 && store.Customers.Count != 0 && store.Inventory.Products.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Create a purchase for {0} {1}?", selectedCustomer.FName, selectedCustomer.LName), "Continue", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
                    ActiveForm.Opacity = .50;
                    using (AssociatesForm af = new AssociatesForm())
                    {
                        af.AssociatesList = store.Associates.ConvertAll(a => (Associate)a);
                        af.cID = selectedCustomer.CustomerId;
                        af.SaleList = store.Sales.ConvertAll(a => (Sale)a);
                        af.buying = true;
                        af.selction = af.AssociatesList[0].AssociateId;
                        af.currentInventory = store.Inventory;
                        if (af.ShowDialog() == DialogResult.OK)
                        {
                            store.Sales = af.SaleList.ConvertAll(a => (ISale)a);
                            store.Inventory = af.currentInventory;

                            BindingSource bSource = new BindingSource();
                            List<SaleView> ss = selectedCustomer.GetPurchases(store.Sales).ConvertAll(s =>
                                new SaleView { Id = s.Id, Date = s.Date, Total = s.GetTotal() });
                            bSource.DataSource = ss;
                            purchasesGridView.DataSource = bSource;
                        }
                    }
                    ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
                    ActiveForm.Opacity = 1;
                }
            }
            else
            {
                if (store.Associates.Count == 0)
                    message += "There are no associates added.\n";
                if (store.Customers.Count == 0)
                    message += "There are no customers added.\n";
                if (store.Inventory.Products.Count == 0)
                    message += "There are no inventory in stock.";

                MessageBox.Show(message);
            }
        }

        private void mainAssociateLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedCustomer is null) return;
            // Get the associate ID for the current customer
            int associateID = selectedCustomer.MainAssociateId;
            // Get the associate infomation
            Associate associate = (Associate)store.Associates.Find(a => a.AssociateId == associateID);
            //Show the associate data
            //MessageBox.Show($"{associate.AssociateId}:{associate.GetFullName()}, " +
            //    $"{associate.Department}\n{associate.Email}, {associate.Tel}", "Customer Associate");
            using (AssociatesForm af = new AssociatesForm())
            {
                ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
                ActiveForm.Opacity = .50;
                af.AssociatesList = store.Associates.ConvertAll(a => (Associate)a);
                af.selction = associate.AssociateId;
                af.locked = true;
                if (af.ShowDialog() == DialogResult.OK)
                {
                    store.Associates = af.AssociatesList.ConvertAll(a => (IAssociate)a);
                }
                ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
                ActiveForm.Opacity = 1;
            }
        }

        private void addCustomerBTN_Click(object sender, EventArgs e)
        {
            bool list1 = false;
            ActiveForm.BackColor= Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;

            list1 = NoAssociate();

            if (list1)
            {
                using (AssociatesForm af = new AssociatesForm())
                {
                    af.customerList = store.Customers.ConvertAll(c => (Customer)c);
                    af.assSelect = true;
                    af.AssociatesList = store.Associates.ConvertAll(a => (Associate)a);
                    af.selction = af.AssociatesList[0].AssociateId;
                    if (af.ShowDialog() == DialogResult.OK)
                    {
                        store.Customers = af.customerList.ConvertAll(cl => (ICustomer)cl);
                        customersGridView.DataSource = store.Customers.ConvertAll(c => (Customer)c);
                    }
                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }

        private bool NoAssociate()
        {
            bool added = false;

            if (store.Associates.Count == 0)
            {
                using AssociateAddForm af = new AssociateAddForm();
                if (af.ShowDialog() == DialogResult.OK)
                {
                    store.Associates = new List<Associate>().ConvertAll(a => (IAssociate)a);
                    store.Associates.Add(af.sendAssociate);
                    added = true;
                }
            }
            else
                added = true;

            return added;
        }
    }
}
