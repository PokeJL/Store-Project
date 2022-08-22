using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public interface IInventory
    {
        /// <summary>
        /// Indexer gets all products that contain the given word in the name
        /// </summary>
        /// <param name="search"></param>
        /// <returns>List<IProduct></returns>
        public List<IProduct> this[string search] { get; }

        /// <summary>
        ///  Indexer using product Id
        /// </summary>
        /// <param name="productId">The Id of the product we want</param>
        /// <returns>Product</returns>
        public IProduct this[int productId] { get; }

        /// <summary>
        /// List of all products
        /// </summary>
        List<Product> Products { get; }
        /// <summary>
        /// Adds the product to the inventory. If it already exists in the inventory, it will add the new quantity. If it doesn't exist, it will add it.
        /// </summary>
        bool AddProduct(Product product);
        /// <summary>
        /// Removes the product from the inventory. If it already exists in the inventory, it will deduct the quantity.
        /// </summary>
        bool RemoveProduct(Product product);

    }
}