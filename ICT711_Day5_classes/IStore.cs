using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ICT711_Day5_classes
{
    public interface IStore
    {
        public string StoreName { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// List of all customers
        /// </summary>
        public List<ICustomer> Customers { get; set; }

        /// <summary>
        /// List of all store associates
        /// </summary>
        public List<IAssociate> Associates { get; set; }

        /// <summary>
        /// Store inventory
        /// </summary>
        public Inventory Inventory { get; set; }

        /// <summary>
        /// List of all sales
        /// </summary>
        public List<ISale> Sales { get; set; }
        /// <summary>
        /// The file name to store the associates list. Don't serialize it.
        /// </summary>
        [JsonIgnore]
        static string AssociatesFileName { get; set; } = "associates.json";
        /// <summary>
        /// The file name to store the customers list. Don't serialize it.
        /// </summary>
        [JsonIgnore]
        static string CustomersFileName { get; set; } = "customers.json";
        /// <summary>
        /// The file name to store the inventory list. Don't serialize it.
        /// </summary>
        [JsonIgnore]
        static string InventoryFileName { get; set; } = "inventory.json";
        /// <summary>
        /// The file name to store the sales list. Don't serialize it.
        /// </summary>
        [JsonIgnore]
        static string SalesFileName { get; set; } = "sales.json";

        /// <summary>
        /// Loads all customers
        /// </summary>
        public void LoadCustomers();

        /// <summary>
        /// Saves all customers
        /// </summary>
        public void SaveCustomers();

        /// <summary>
        /// Loads all sales
        /// </summary>
        public void LoadSales();

        /// <summary>
        /// Saves all sales
        /// </summary>
        public void SaveSales();

        /// <summary>
        /// Loads all associates
        /// </summary>
        public void LoadAssociates();

        /// <summary>
        /// Saves all associated
        /// </summary>
        public void SaveAssociates();
        /// <summary>
        /// Loads inventory data
        /// </summary>
        void LoadInventory();
        /// <summary>
        /// Saves Inventory data
        /// </summary>
        void SaveInventory();
    }
}