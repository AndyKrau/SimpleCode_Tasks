using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public void GetFillInfo()
        {
            Console.WriteLine(this.FirstName +" "+ this.LastName);
            Console.WriteLine(this.Address.Country + " " + this.Address.City);
        }
    }
}
