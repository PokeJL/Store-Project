using ICT711_Day5_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Project.ICT711_Day8_Forms
{
    public partial class InventoryAddForm : Form
    {
        //private List<List<string>> pg;
        public Inventory inventory;
        public List<Inventory> inventoryList { get; set; }
        List<ProductView> pv = new List<ProductView>();

        private bool editMode;
        private int selectedRow;
        public InventoryAddForm()
        {
            InitializeComponent();
            //pg = new List<List<string>>();
            inventory = new Inventory();
            editMode = false;
            object[] clothesSizes = new object[4];
            clothesSizes[0] = "Select Size";
            clothesSizes[1] = "S";
            clothesSizes[2] = "M";
            clothesSizes[3] = "L";
            sizeCB.Items.AddRange(clothesSizes);
            sizeCB.SelectedIndex = 0;
        }

        class ProductView
        {
            private string s;
            private decimal p;
            private int q;

            public ProductView(string v, decimal price, int quantity)
            {
                this.s = v;
                this.p = price;
                this.q = quantity;
            }

            public string Size { get { return this.s; } }
            public decimal Price { get { return this.p; } }
            public int Quantity { get { return this.q; } }
        }

        private void finishBTN_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (inventoryList != null)
            {
                for (int i = 1; ; i++)
                {
                    for (int m = 0; inventoryList.Count > 0; m++)
                    {
                        if (inventoryList.Any(il => il.Products[m].ProductId == i) == false)
                        {
                            id = i;
                            break;
                        }
                    }
                    if (id != 0)
                        break;
                }
            }
            else
                id = 1;

            if (garmentCheckBox.Checked)
            {
                ProductGarment product = new ProductGarment(id, productNameTXT.Text.ToString(), descriptionTXT.Text.ToString());
                for (int i = 0; i < pv.Count; i++)
                {
                    product.AddQuantity(pv[i].Size, pv[i].Quantity, pv[i].Price);
                }
                inventory.AddProduct(product);
            }
            else
            {
                Product product = new Product(id, productNameTXT.Text.ToString(), descriptionTXT.Text.ToString(), Convert.ToDecimal(priceTXT.Text), Convert.ToInt32(quantatyTXT.Text));
                inventory.AddProduct(product);
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string s = null;
            bool selected = true;
            bool inList = false;

            if (editMode)
                sizeCB.SelectedIndex = selectedRow;

            if (sizeCB.SelectedIndex == 1)
                s = "S";
            else if (sizeCB.SelectedIndex == 2)
                s = "M";
            else if (sizeCB.SelectedIndex == 3)
                s = "L";
            else
            {
                MessageBox.Show("Please select a size.");
                selected = false;
            }

            if (editMode)
            {
                editBTN.Enabled = true;
                finishBTN.Enabled = true;
                garmentCheckBox.Enabled = true;
                editMode = false;

                addBTN.Text = "Add Garment";
                deleteBTN.Text = "Delete Garment";

                pv[selectedRow] = new ProductView(s, Convert.ToDecimal(priceTXT.Text), Convert.ToInt32(quantatyTXT.Text));

                BindingSource bSource = new BindingSource();
                bSource.DataSource = pv;
                garmentViewDGV.DataSource = bSource;
            }
            else if (selected)
            {
                for (int i = 0; i < pv.Count; i++)
                {
                    if (pv[i].Size == s)
                    {
                        inList = true;
                        break;
                    }
                }

                if (inList == false)
                {
                    pv.Add(new ProductView(s, Convert.ToDecimal(priceTXT.Text), Convert.ToInt32(quantatyTXT.Text)));
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = pv;
                    garmentViewDGV.DataSource = bSource;
                }
                else
                {
                    MessageBox.Show("Selected size already added delete item and re add.");
                }
            }
        }

        private void InventoryAddForm_Load(object sender, EventArgs e)
        {
            garmentViewDGV.DataSource = pv;
        }

        private void garmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (garmentCheckBox.Checked)
            {
                addBTN.Enabled = true;
                editBTN.Enabled = true;
                deleteBTN.Enabled = true;
                garmentViewDGV.Enabled = true;
                sizeCB.Enabled = true;
            }
            else
            {
                addBTN.Enabled = false;
                editBTN.Enabled = false;
                deleteBTN.Enabled = false;
                garmentViewDGV.Enabled = false;
                sizeCB.Enabled = false;
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            int s;
            selectedRow = garmentViewDGV.Rows.GetRowCount(DataGridViewElementStates.Selected);
            selectedRow = pv[pv.IndexOf(garmentViewDGV.Rows.GetRowCount(DataGridViewElementStates))];
            selectedRow = garmentViewDGV.SelectedRows[];

            if (pv[selectedRow].Size == "S")
                s = 1;
            else if (pv[selectedRow].Size == "M")
                s= 2;
            else
                s = 3;

            sizeCB.SelectedItem = s;
            editMode = true;

            editBTN.Enabled = false;
            finishBTN.Enabled = false;
            garmentCheckBox.Enabled = false;

            addBTN.Text = "Done Edit";
            deleteBTN.Text = "Cancel Edit";

            priceTXT.Text = pv[selectedRow].Price.ToString();
            quantatyTXT.Text = pv[selectedRow].Quantity.ToString();
        }
    }
}
