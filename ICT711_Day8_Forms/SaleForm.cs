using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICT711_Day5_classes;

namespace ICT711_Day8_Forms
{
    public partial class SaleForm : Form
    {
        public List<ISale> Sales { get; set; }
        public Sale SelectedSale { get; set; }
        public Sale selectedItem { get; set; }
        public Product selectedProduct { get; set; }
        private List<Sale> saleList;
        private List<Sale> saleList2 = new List<Sale>();
        public int cID { get; set; }
        public int ID { get; set; }
        public SaleForm()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            saleList = Sales.ConvertAll(s => (Sale)s);
            for (int i = 0; i < saleList.Count; i++)
            {
                if (saleList[i].CustomerId == cID && saleList[i].Id == ID)
                    saleList2.Add(saleList[i]);
            }
            dataGridView1.DataSource = saleList2;
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            productListGridView.AutoGenerateColumns = false;
            selectedItem = (Sale)((DataGridView)sender).CurrentRow.DataBoundItem;
            productListGridView.DataSource = selectedItem.ProductsList;
            totalSumLBL.Text = selectedItem.GetTotal().ToString();
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

        private void productListGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)((DataGridView)sender).CurrentRow.DataBoundItem;
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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
