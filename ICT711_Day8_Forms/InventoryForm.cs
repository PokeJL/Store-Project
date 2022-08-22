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
    public partial class InventoryForm : Form
    {
        public Inventory currentInventory { get; set; }
        public Product selectedProduct { get; set; }
        private ProductView selectedPG { get; set; }
        public List<Sale> salesList { get; set; }
        public int cID { get; set; }
        public int aID { get; set; }
        public bool buying { get; set; }
        private int sID;
        private Sale cart;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            inventoryGridView.DataSource = currentInventory.Products;
            if (buying == true)
            {
                closeBTN.Enabled = false;
                closeBTN.Visible = false;
                finishBTN.Enabled = true;
                finishBTN.Visible = true;
                purchaseBTN.Enabled = true;
                purchaseBTN.Visible = true;
                backBTN.Enabled = true;
                backBTN.Visible = true;

                for (int i = 1; ; i++)
                {
                    if (salesList.Any(sl => sl.Id == i) == false)
                    {
                        sID = i;
                        break;
                    }
                }

                cart = new Sale(sID, DateTime.Now, cID, aID, (SaleStatus)0);
            }
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

        private void inventoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)((DataGridView)sender).CurrentRow.DataBoundItem;
            if (selectedProduct.GetType() == typeof(Product)) 
            {;
                pgGridView.Columns.Clear();
                pgGridView.DataSource = null;

                return; 
            }
            else if (selectedProduct.GetType() == typeof(ProductGarment))
            {
                ProductGarment prod;
                List<ProductView> pv = new List<ProductView>();
                prod = (ProductGarment)((ProductGarment)selectedProduct).Clone();
                try
                {
                    if (prod.SizePriceQuantity["S"].quantity != 0)
                        pv.Add(new ProductView("S", prod.SizePriceQuantity["S"].price, prod.SizePriceQuantity["S"].quantity));
                }
                catch { }
                try
                {
                    if (prod.SizePriceQuantity["M"].quantity != 0)
                        pv.Add(new ProductView("M", prod.SizePriceQuantity["M"].price, prod.SizePriceQuantity["M"].quantity));
                }
                catch { }
                try
                {
                    if (prod.SizePriceQuantity["L"].quantity != 0)
                        pv.Add(new ProductView("L", prod.SizePriceQuantity["L"].price, prod.SizePriceQuantity["L"].quantity));
                }
                catch { }
                pgGridView.DataSource = pv;
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void purchaseBTN_Click(object sender, EventArgs e)
        {
            if (selectedProduct.GetType() == typeof(ProductGarment))
            {
                bool found = false;
                int index = 0;
                ProductGarment temp;
                
                for (int i = 0; i < cart.ProductsList.Count; i++)
                {
                    if (cart.ProductsList[i].ProductId == selectedProduct.ProductId)
                    {
                        found = true;
                        index = i;
                        break;
                    }
                }
                if (found)
                {
                    temp = (ProductGarment)((ProductGarment)cart.ProductsList[index]).Clone();
                    temp.AddQuantity(selectedPG.Size, 1, selectedPG.Price);
                }
                else
                {
                    temp = new ProductGarment(selectedProduct.ProductId, selectedProduct.ProductName,
                            selectedProduct.Description);
                    temp.AddQuantity(selectedPG.Size, 1, selectedPG.Price);
                }
                cart.AddProduct(temp, currentInventory);
            }
            else
                cart.AddProduct(selectedProduct, currentInventory);

            inventoryGridView.Update();
            inventoryGridView.Refresh();
        }

        private void pgGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedPG = (ProductView)((DataGridView)sender).CurrentRow.DataBoundItem;
        }

        private void finishBTN_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;
            using (CheckOutForm cof = new CheckOutForm())
            {
                cof.sendList = salesList;
                cof.saleList = cart;
                cof.inventory = currentInventory;
                if (cof.ShowDialog() == DialogResult.OK)
                {
                    salesList = cof.sendList;
                    currentInventory = cof.inventory;
                    DialogResult = DialogResult.OK; //Return OK
                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }

        private void addInvBTN_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 79, 125, 176);
            ActiveForm.Opacity = .50;
            using (Store_Project.ICT711_Day8_Forms.InventoryAddForm iaf = new Store_Project.ICT711_Day8_Forms.InventoryAddForm())
            {
                //cof.sendList = salesList;
                //cof.saleList = cart;
                //cof.inventory = currentInventory;
                if (iaf.ShowDialog() == DialogResult.OK)
                {
                    //salesList = cof.sendList;
                    //currentInventory = cof.inventory;
                    DialogResult = DialogResult.OK; //Return OK
                }
            }
            ActiveForm.BackColor = Color.FromArgb(255, 153, 180, 209);
            ActiveForm.Opacity = 1;
        }
    }
}
