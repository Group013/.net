using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    internal class Customer
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        
        public string City { get; set; }
        public Customer() { }
        public Customer(int customerId, string name, string city)
        {
            customerId = customerId;
            Name = name;
            City = city;
        }
    }
}
