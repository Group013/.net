using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Customer : Person
    {
        public override string changeAddress(string oldAddress, string newAddress)
        {
            return string.Format($"Customer {Name} has changed his/her address from{oldAddress} to {newAddress}");  
        }

    }
}
