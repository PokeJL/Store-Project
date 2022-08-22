using System;

namespace ICT711_Day5_classes
{
    public  interface IPerson
    {  
        public string FName { get; set; }
        public string LName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string GetFullName();
       
    }
}
