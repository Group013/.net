using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal abstract class Person
{
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }

        public string City { get; set; }
        public Person()
        {
            Console.WriteLine("abstract class constructor");
        }
        public abstract string changeAddress(string oldAddress, string newAddress);
       
    }
}
