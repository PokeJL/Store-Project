using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
//using Newtonsoft.Json.Serialization;

namespace ICT711_Day5_classes
{
    public class Store : IStore 
    {
        List<ICustomer> customers = new List<ICustomer>();
        List<IAssociate> associates = new List<IAssociate>();
        List<ISale> sales = new List<ISale>();
        Inventory inventory = new Inventory();

        public string StoreName { get; set; }
        public string Address { get; set; }
        public List<ICustomer> Customers 
        { 
            get 
            { 
                return customers;
            }
            
            set
            {
                customers = value;
            }
        }
        public List<IAssociate> Associates 
        {
            get
            {
                return associates;
            }

            set
            {
                associates = value;
            }
        }
        public Inventory Inventory 
        { 
            get
            {
                return inventory;
            }
            
            set
            {
                inventory = value;
            }
        }
        public List<ISale> Sales 
        {
            get 
            {
                return sales;   
            }

            set
            {
                sales = value;
            } 
        }
        //[JsonIgnore]
        public static string AssociatesFileName { get; set; } = "associates.json";
        //[JsonIgnore]
        public static string CustomersFileName { get; set; } = "customers.json";
        //[JsonIgnore]
        public static string InventoryFileName { get; set; } = "inventory.json";
        //[JsonIgnore]
        public static string SalesFileName { get; set; } = "sales.json";

        public Store()
        {
            
        }
        public void LoadAssociates()
        {
            if(!File.Exists(AssociatesFileName))
            {
                Associates = new List<Associate>().ConvertAll(a => (IAssociate)a);
                return;
            }
            string jsonString = File.ReadAllText(AssociatesFileName);
            var ass = JsonConvert.DeserializeObject<List<Associate>>(jsonString,
             new JsonSerializerSettings
             {
                 TypeNameHandling = TypeNameHandling.Auto
             });
            Associates = ass.ConvertAll(c => (IAssociate)c);   // Typecasting of each element
            return;

            //throw new NotImplementedException();
        }

        public void LoadCustomers()
        {
            if (!File.Exists(CustomersFileName))
            {
                Customers = new List<Customer>().ConvertAll(a => (ICustomer)a);
                return;
            }
            string jsonString = File.ReadAllText(CustomersFileName);
            var cs = JsonConvert.DeserializeObject<List<Customer>>(jsonString,
             new JsonSerializerSettings
             {
                 TypeNameHandling = TypeNameHandling.Auto
             });
            Customers = cs.ConvertAll(c => (ICustomer)c);
            return;

            //throw new NotImplementedException();
        }

        public void LoadInventory()
        {
            if (!File.Exists(InventoryFileName))
            {
                Inventory = new Inventory();
                return;
            }
            string jsonString = File.ReadAllText(InventoryFileName);
            Inventory = JsonConvert.DeserializeObject<Inventory>(jsonString, new JsonSerializerSettings
             {
                 TypeNameHandling = TypeNameHandling.Auto
             });
            return;
        }

        public void LoadSales()
        {
            if (!File.Exists(SalesFileName))
            {
                Sales = new List<Sale>().ConvertAll(a => (ISale)a);
                return;
            }
            string jsonString = File.ReadAllText(SalesFileName);
            var ss = JsonConvert.DeserializeObject<List<Sale>>(jsonString,
             new JsonSerializerSettings
             {
                 TypeNameHandling = TypeNameHandling.Auto
             });
            Sales = ss.ConvertAll(s => (ISale)s);   // Typecasting of each element

            //throw new NotImplementedException();
        }

        public void SaveAssociates()
        {
            string jsonString = JsonConvert.SerializeObject(Associates, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(AssociatesFileName, jsonString);
            return;

            //throw new NotImplementedException();
        }

        public void SaveCustomers()
        {
            string jsonString = JsonConvert.SerializeObject(Customers, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(CustomersFileName, jsonString);
            return;

            //throw new NotImplementedException();
        }

        public void SaveInventory()
        {
            string jsonString = JsonConvert.SerializeObject(Inventory, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(InventoryFileName, jsonString);
            return;
            //throw new NotImplementedException();
        }

        public void SaveSales()
        {
            string jsonString = JsonConvert.SerializeObject(Sales, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(SalesFileName, jsonString);
            return;
            //throw new NotImplementedException();
        }
    }
}