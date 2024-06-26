using AbstractDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cs= new Customer();
            cs.Id = 1;
            cs.Name = "ashvi";
            cs.Address = "PUNE";
            cs.City = "PUNE";

            Console.WriteLine(cs.changeAddress(cs.Address, "Solapur"));
            Console.ReadKey();
        }
    }
}
