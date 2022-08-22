using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Associate : Person, IAssociate
    {
        // Default constructor. Doesn't initialize any values
        public Associate()
        {
            // Initialize the AssociateId with a random value
            this.AssociateId = new Random().Next();
        }

        // This constructor passes all parameters to the base class (Person)
        public Associate(string fname, string lname, string tel, string email)
            : base(fname, lname, tel, email)
        {
            // Initialize the AssociateId with a random value
            this.AssociateId = new Random().Next();
        }


        /// This constructor initializes the AssociateId, Department, JobDescription and ManagerId
        /// Department, JobDescription and ManagerId have default values if not given
        /// and passes the other parameters to the base class (Person)
        public Associate(int associateId, string fname, string lname, string tel, string email,
            string department = "General", string jobDescription = "Sales", int managerId = 0)
            : base(fname, lname, tel, email)
        {
            this.AssociateId = associateId;
            this.Department = department;
            this.JobDescription = jobDescription;
            this.ManagerId = managerId;
        }

        // Read only property. Can only be set here or in the constructor
        public int AssociateId { get; set; }
        public string Department { get; set; }
        public string JobDescription { get; set; }
        public int ManagerId { get; set; }

        public string GetManager(List<IAssociate> associateList)
        {
            return associateList.First(a => a.AssociateId == this.ManagerId)?
                .GetFullName();
            throw new NotImplementedException();
        }
    }
}