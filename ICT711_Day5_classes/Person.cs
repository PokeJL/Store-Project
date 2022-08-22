using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public class Person : IPerson
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Tel { get; set; }

        private string _email = "";
        public string Email { get => _email.ToLower();
            set{    // Check if email is valid
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Contains("@") && value.Contains(".")) _email = value;
                    else throw new Exception("Invalid email address!!");
                }
            } 
        }

        /// <summary>
        /// Default constructor. Doesn't initialize any values. 
        /// Needed to be able to create a new object without initializing it
        /// e.g.: Person p = new Person();
        /// </summary>
        public Person()
        {

        }
        /// <summary>
        /// Constructor that takes parameters
        /// Person p = new Person("John", "Smith", "403000000", "email@server.com");
        /// </summary>
        /// <param name="fname">Customer First name</param>
        /// <param name="lname">Customer last name</param>
        /// <param name="tel">Phone number</param>
        /// <param name="email">Email address</param>
        public Person(string fname, string lname, string tel, string email)
        {
            // Initializing the properties with the given parameter values
            this.FName = fname;
            this.LName = lname;
            this.Tel = tel;
            this.Email = email;
        }
        public string GetFullName()
        {
            return FName + " " + LName;
        }
    }
}
