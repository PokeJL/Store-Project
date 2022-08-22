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
    public partial class CheckOutForm : Form
    {
        public Sale saleList { get; set; }
        public Sale selectedSale { get; set; }
        private Product selectedProduct;
        public List<Sale> sendList { get; set; }
        public Inventory inventory { get; set; }
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            productListGridView.AutoGenerateColumns = false;
            productListGridView.DataSource = saleList.ProductsList;
            totalSumLBL.Text = saleList.GetTotal().ToString();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            saleList.RemoveProduct(saleList.ProductsList[productListGridView.CurrentCell.RowIndex], inventory);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = saleList.ProductsList;
            productListGridView.DataSource = bSource;
            totalSumLBL.Text = saleList.GetTotal().ToString();
            pgGridView.Columns.Clear();
            pgGridView.DataSource = null;
        }

        class ProductView /*(string s, decimal d, int q)*/
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

        private void productListGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectedProduct = (Product)((DataGridView)sender).CurrentRow.DataBoundItem;
            }
            catch
            {
                selectedProduct = null;
            }

            if (selectedProduct != null)
            {
                if (selectedProduct.GetType() == typeof(Product))
                {
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
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkOutBTN_Click(object sender, EventArgs e)
        {
            sendList.Add(saleList);
            DialogResult = DialogResult.OK; //Return OK
        }
    }
}
