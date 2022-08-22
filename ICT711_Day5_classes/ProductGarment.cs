using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public class ProductGarment : Product, ICloneable
    {
        /// <summary>
        /// Structure to hold the prices and the quantities
        /// </summary>
        public struct SQuantityPrice { public decimal price { get; set; } public int quantity { get; set; } }

        /// <summary>
        /// Dictionary of Prices & Quantities for different sizes
        /// </summary>
        public Dictionary<string, SQuantityPrice> SizePriceQuantity 
                    { get; set; } = new Dictionary<string, SQuantityPrice>();

        public ProductGarment()
        {
            
        }

        // Parametrized constructor
        public ProductGarment(int productId, string productName, string description): 
            base (productId, productName, description, 0m, 0)
        {
            
        }

       
        // Parametrized constructor
        public ProductGarment(string productName, string description) :
            base(productName, description, 0m, 0)
        {
            
        }

        /// <summary>
        /// Adds new quantity to the list with a price
        /// </summary>
        /// <param name="size">The size to add to</param>
        /// <param name="quantiry">integer quantity</param>
        /// <param name="price">The price</param>
        public void AddQuantity(string size, int quantiry, decimal price)
        {
            SQuantityPrice qp;
            SizePriceQuantity.TryGetValue(size, out qp) ;       // Try to Load the quantity if the size exists
            qp.price = price;
            qp.quantity += quantiry;
            SizePriceQuantity[size] = qp;
        }

        // Overrides the parent method
        public override decimal GetSubTotal()
        {
            decimal sub = 0m;
            foreach(var val in SizePriceQuantity.Values)
            {
                sub += val.price * val.quantity;
            }
            return sub;
        }

        /// <summary>
        /// Create a clone of this object. Implements the Clone in ICloneable 
        /// </summary>
        /// <returns>A new object which is a clone of the current object</returns>
        public object Clone()
        {
            ProductGarment pg = new ProductGarment() {
                ProductId = this.ProductId,
                Description = this.Description,
                ProductName = this.ProductName,
                SizePriceQuantity = new Dictionary<string, SQuantityPrice>(this.SizePriceQuantity)
               };
            return pg;
        }

        /// <summary>
        /// Overload the "+" operator to add the quantity
        /// </summary>
        /// <param name="product1">The first ProductGarment to be added</param>
        /// <param name="product2">The second ProductGarment to be added</param>
        /// <returns>If the two inputs are the same product, then return the first after adding the quantities. 
        /// If not same product, throw an Exception</returns>
        public static ProductGarment operator +(ProductGarment product1, ProductGarment product2)
        {
            // Check if the products are same
            if (product1.ProductId != product2.ProductId)
                throw new Exception("Can't add two different products.");
            foreach(var pq in product2.SizePriceQuantity)
            {
                product1.AddQuantity(pq.Key, pq.Value.quantity, pq.Value.price);
            }
            
            return product1;
        }

        /// <summary>
        /// Overload the "-" operator to subtract the quantity
        /// </summary>
        /// <param name="product1">The first product</param>
        /// <param name="product2">The second product</param>
        /// <returns>If the two inputs are the same product, then return the first after subtracting the quantity of the second. 
        /// If not same product, throw an Exception</returns>
        public static ProductGarment operator -(ProductGarment product1, ProductGarment product2)
        {
            // Check if the products are same
            if (product1.ProductId != product2.ProductId)
                throw new Exception("Can't subtract two different products.");
            foreach (var pq in product2.SizePriceQuantity)
            {
                // Check if the quantity is enough
                if (product1.SizePriceQuantity[pq.Key].quantity < product2.SizePriceQuantity[pq.Key].quantity)
                    throw new ArgumentOutOfRangeException("Quantity",
                        product1.SizePriceQuantity[pq.Key].quantity, "There is not enough quantity.");

                product1.AddQuantity(pq.Key, -1*pq.Value.quantity, pq.Value.price);
            }
            
            return product1;
        }
    }
}