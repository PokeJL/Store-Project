using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Sale : ISale
    {
        List<Product> prods = new List<Product>();

        public Sale()
        {
            Id = new Random().Next();
        }

        public Sale(int customerId, int associateId, SaleStatus status)
        {
            CustomerId = customerId;
            AssociateId = associateId;
            Status = status;
        }

        public Sale(int id, DateTime date, int customerId, int associateId, SaleStatus status)
        {
            Id = id;
            Date = date;
            CustomerId = customerId;
            AssociateId = associateId;
            Status = status;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int AssociateId { get; set; }

        public List<Product> ProductsList 
        {
            get 
            {
                //if ((prods.Count == 0))
                //    return new List<Product>();
                //else
                    return prods;
            } 
        }

        public SaleStatus Status { get; set; }

        public int AddProduct(Product product, IInventory inventory)
        {
            ProductGarment prod = new ProductGarment();
            Product temp;
            int index = 0;
            int pIndex = 0;
            bool enter = false;
            bool found = false;
            //int amount = 0;
            //if (product.Quantity > 0)
            //{
            //    prods.Add(product);
            //    inventory.RemoveProduct(product);
            //    index = prods.IndexOf(product);
            //    amount = prods[index].Quantity;
            //}
            //else
            //{
            //    amount = 0;
            //}

            //return amount;

            //int index = 0;

            for (int i = 0; i < inventory.Products.Count; i++)
            {
                if (inventory.Products[i].ProductId == product.ProductId)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            try
            {
                if (found == true)
                {
                    prod = (ProductGarment)((ProductGarment)inventory[inventory.Products[index].ProductId]).Clone();
                    enter = true;
                }
            }
            catch { }
            found = false;
            if (inventory.Products[index].Quantity > 0 && enter == false /*|| enter == true*/)
            {
                //prods.Add(product);
                //prods[prods.IndexOf(product)].Quantity += 1;
                //inventory.Products[index].Quantity -= prods[prods.IndexOf(product)].Quantity;
                ////index = prods.IndexOf(product);
                //return prods[prods.IndexOf(product)].Quantity;

                for (int i = 0; i < prods.Count; i++)
                {
                    if (prods[i].ProductId == product.ProductId)
                    {
                        found = true;
                        pIndex = i;
                        break;
                    }
                }

                if(found == true)
                {
                    prods[pIndex].Quantity += 1;
                    inventory.Products[index].Quantity -= 1;
                }
                else
                {
                    temp = new Product (inventory.Products[index].ProductId, inventory.Products[index].ProductName,
                        inventory.Products[index].Description, inventory.Products[index].Price,
                        1);

                    prods.Add(temp);
                    //pIndex = prods.IndexOf(product);
                    //prods[pIndex].Quantity = 0;
                    //prods[pIndex].Quantity += 1;
                    inventory.Products[index].Quantity -= 1;
                }
                return prods[pIndex].Quantity;
            }
            else if (enter == true)
            {
                found = false;
                //prods.Add(product);
                for (int i = 0; i < prods.Count; i++)
                {
                    if (prods[i].ProductId == product.ProductId)
                    {
                        found = true;
                        pIndex = i;
                        break;
                    }
                }

                if (found == true)
                    prods[pIndex] = product;
                else
                {
                    prods.Add(product);
                    pIndex = prods.Count - 1;
                }
                return prods[pIndex].Quantity;
            }
            else return 0;
            //throw new NotImplementedException();
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            for(int i = 0; i < prods.Count; i++)
            {
                total += prods[i].GetSubTotal();
            }
            return total;
            //throw new NotImplementedException();
        }

        public int RemoveProduct(Product product, IInventory inventory)
        {
            //throw new NotImplementedException();
            int index = 0;
            int amount = 0;
            bool found = false;

            //for(int i =0; i < prods.Count; i++)
            //{
            //    if(prods[i].ProductId == product.ProductId)
            //    {
            //        index = i;
            //        found = true;
            //        break;
            //    }
            //}

            //if(found == true /*&& prods[index].Quantity > 0*/)
            //{
                amount = prods[index].Quantity;
                //prods[index].Quantity -= 1;
                prods.Remove(product);
                inventory.AddProduct(product);
            //}
            //else
            //{
            //    amount = 0;
            //}

            return amount;
        }
    }
}