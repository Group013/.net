using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ImpGenerateXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CustomerOrderDocument = new XElement("Customers" ,new XElement("Customer",new XAttribute("CustomerId","100"),
                new XAttribute("CustomerName","Neha"),new XAttribute("City","pune"),new XElement("Orders",new XAttribute("orderId","1"),new XAttribute("OrderDate","22/1/2020")),new XElement("product")));
            Console.WriteLine(CustomerOrderDocument);
            Console.ReadKey();

        }
    }
}
