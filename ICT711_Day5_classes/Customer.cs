using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Customer : Person, ICustomer
    {
        // Default constructor.
        public Customer()
        {
            // Initialize the customerId with a random value
            this.CustomerId = new Random().Next();
        }

        // This constructor passes all parameters to the base class (Person)
        public Customer(string fname, string lname, string tel, string email)
            : base(fname, lname, tel, email)
        {
            // Initialize the customerId with a random value
            this.CustomerId = new Random().Next();
        }

        // This constructor initializes the CustomerId, 
        // and passes the other parameters to the base class (Person)
        public Customer(int customerId, string fname, string lname, string tel, string email) 
            : base(fname, lname, tel, email)
        {
            this.CustomerId = customerId;
        }

        // Read only property. You can only initialize it here or in the constructor 
        public int CustomerId { get; set; }
        
        // Returns the customer associate's ID
        public int MainAssociateId { get; set; }

        // Read only property. You can only initialize it here or in the constructor 
        public DateTime RegisteredOn { get; set; } = DateTime.Now;
        //=> throw new NotImplementedException()
        
        public string GetAssociate(List<IAssociate> associates)
        {
            return associates.Find(a => a.AssociateId == MainAssociateId).GetFullName();
            //throw new NotImplementedException();
        }

        public List<ISale> GetPurchases(List<ISale> sales)
        {
            return sales.Where(s => s.CustomerId == CustomerId).ToList();
            //throw new NotImplementedException();
        }
    }
}