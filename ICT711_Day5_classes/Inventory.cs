using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Inventory : IInventory
    {
        public List<Product> Products { get; } = new List<Product>();

        public Inventory()
        {

        }

        public List<IProduct> this[string search]
        {
            get 
            {
                List<IProduct> temp = new List<IProduct>();

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductName.Contains(search))
                        temp.Add(Products[i]);
                }

                return temp; 
            }
        }

        public IProduct this[int productId]
        {
            get
            {
                int found = 0;
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductId == productId)
                    {
                        found = i;
                        return Products[i];
                    }
                }

                return null;
            }
        }

        public bool AddProduct(Product product)
        {
            int index = 0;
            bool found = false;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductId == product.ProductId)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found == true)
            {
                Products[index].Quantity += product.Quantity;
            }
            else
            {
                Products.Add(product);
            }
            return found;
            //throw new NotImplementedException();
        }

        public bool RemoveProduct(Product product)
        {
            int index = 0;
            bool found = false;
            string temp = "There is not enough quantity.";

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductId == product.ProductId)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found == true && Products[index].Quantity - product.Quantity > 0/*Products.Count != 0 && Products.Contains(product)*/)
            {
                Products[index].Quantity -= product.Quantity;
                found = true;
            }
            else if (found == true && Products[index].Quantity - product.Quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(temp), "There is not enough quantity.");
            }
            else if (found == true && Products[index].Quantity - product.Quantity == 0)
            {
                found = true;
                Products.Remove(product);
            }
            else if (found == false)
                throw new Exception("Product is not in inventory.");

            return found;
            //throw new NotImplementedException();
        }

        public static Inventory operator +(Inventory inventory, Product product)
        {
            int index = 0;
            bool found = false;

            for (int i = 0; i < inventory.Products.Count; i++)
            {
                if (inventory.Products[i].ProductId == product.ProductId)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found == true)
            {
                inventory.Products[index].Quantity += product.Quantity;
            }
            else
            {
                inventory.Products.Add(product);
            }
            return inventory;
        }

        public static Inventory operator -(Inventory inventory, Product product)
        {
            int index = 0;
            bool found = false;
            string temp = "There is not enough quantity.";

            for (int i = 0; i < inventory.Products.Count; i++)
            {
                if (inventory.Products[i].ProductId == product.ProductId)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found == true && inventory.Products[index].Quantity - product.Quantity > 0/*Products.Count != 0 && Products.Contains(product)*/)
            {
                inventory.Products[index].Quantity -= product.Quantity;
                found = true;
            }
            else if (found == true && inventory.Products[index].Quantity - product.Quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(temp), "There is not enough quantity.");
            }
            else if (found == true && inventory.Products[index].Quantity - product.Quantity == 0)
            {
                found = true;
                inventory.Products.Remove(product);
            }
            else if (found == false)
                throw new ArgumentException("Product is not in inventory.");

            return inventory;
        }
    }
}