using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Product : IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public static object tempList { get; internal set; }

        public Product()
        {
            // Initialize the ProductId with a random value
            this.ProductId = new Random().Next();
        }

        // Parametrized constructor
        public Product(int productId, string productName, string description, 
            decimal price, int quantity)
        {
            // Initialize the local variables using the given parameters     
            //throw new NotImplementedException();
            ProductId = productId;
            ProductName = productName;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        // Cloning constructor
        public Product(Product product)
        {
            // Initialize the local variables using the given Object
            //throw new NotImplementedException();
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            Description = product.Description;
            Price = product.Price;
            Quantity = product.Quantity;
        }

        // Parametrized constructor
        public Product(string productName, string description, decimal price, int quantity)
        {
            // Initialize the ProductId with a random value
            // Initialize the local variables using the given parameters
            //throw new NotImplementedException();
            ProductId = new Random().Next();
            ProductName = productName;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        /// <summary>
        /// Calculates the subtotal.
        /// Allows overriding
        /// </summary>
        /// <returns>The subtotal = Price * Quantity</returns>
        public virtual decimal GetSubTotal()
        {
            //calculate the subtotal and return it
            //throw new NotImplementedException();
            return (decimal)(Price * Quantity);
        }

        /// <summary>
        /// Overload the "+" operator to add the quantity
        /// </summary>
        /// <param name="product1">The first product to be added</param>
        /// <param name="product2">The second product to be added</param>
        /// <returns>If the two inputs are the same product, then return the first after adding the quantity. 
        /// If not same product, throw an Exception</returns>
        public static Product operator + (Product product1, Product product2)
        {
            // Check if the products are same by checking the IDs of both inputs
            // If not same IDs
            // throw new Exception("Can't add two different products.");
            // If same products
            // return product1 with the added quantity from product 2;
            //throw new NotImplementedException();
            if (product1.ProductId != product2.ProductId)
                throw new ArgumentException("Can't add two different products.");
            else
                product1.Quantity = product1.Quantity + product2.Quantity;
            return product1;
        }

        /// <summary>
        /// Overload the "-" operator to subtract the quantity
        /// </summary>
        /// <param name="product1">The first product</param>
        /// <param name="product2">The second product</param>
        /// <returns>If the two inputs are the same product, then return the first after subtracting the quantity of the second. 
        /// If not same product, throw an Exception</returns>
        public static Product operator -(Product product1, Product product2)
        {
            // Check if the products are same
            if (product1.ProductId != product2.ProductId)
                throw new Exception("Can't subtract two different products.");
            // Check if the quantity is enough
            if (product1.Quantity < product2.Quantity)
                throw new ArgumentOutOfRangeException("Quantity",
                    product2.Quantity, "There is not enough quantity.");

            product1.Quantity -= product2.Quantity;
            return product1;
        }
    }
}