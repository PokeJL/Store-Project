using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public interface ISale
    {
        int Id { get; set; }
        /// <summary>
        /// Sale Date
        /// </summary>
        System.DateTime Date { get; set; }
        /// <summary>
        /// Id if the customer
        /// </summary>
        int CustomerId { get; set; }
        /// <summary>
        /// Id of the associate
        /// </summary>
        int AssociateId { get; set; }
        /// <summary>
        /// List of all purchased products
        /// </summary>
        List<Product> ProductsList { get; }

        /// <summary>
        /// The status of the sale.
        /// </summary>
        SaleStatus Status { get; set; }

        /// <summary>
        /// Adds a product to the sale. Checks first if there is enough inventory of this product. If yes, then adds it and deducts the quantity from the inventory.
        /// </summary>
        /// <returns>Returns the quantity added, or 0 of failed</returns>
        /// <param name="product">Object of the product to add to the sale</param>
        /// <param name="inventory">The inventory list. This relation is called association (using)</param>
        int AddProduct(Product product, IInventory inventory);

        /// <summary>
        /// Removes product from the sale. Adds the removed quantity to the inventory. Adds the quantity to the inventory.
        /// </summary>
        /// <returns>The removed quantity</returns>
        /// <param name="product">The product to be removes</param>
        /// <param name="inventory">The inventory list. This relation is called association (using)</param>
        int RemoveProduct(Product product, IInventory inventory);

        /// <summary>
        /// Gets the sale total
        /// </summary>
        decimal GetTotal();
       
    }

    public enum SaleStatus
    {
        Complete,
        Cancelled,
        Pending,
        Returned
    }
}