using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic salary  ");
            double BasicSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total sales above 5000");
            double totalSalesAmount = double.Parse(Console.ReadLine());
            double netSalary;
            double comm;
            
            if(totalSalesAmount>=5000 && totalSalesAmount <= 7500)
            {
                netSalary=totalSalesAmount+BasicSalary;
                Console.WriteLine("NetSalary="+netSalary);
                comm =(totalSalesAmount*3)/ 100;
                Console.WriteLine("NetSalary ="+netSalary+" commission= "+comm);

            }
            else if (totalSalesAmount >=7501 && totalSalesAmount <=10500 )
            {
                netSalary = totalSalesAmount + BasicSalary;
                Console.WriteLine("NetSalary=" + netSalary);
                comm = (totalSalesAmount * 8) / 100;
                Console.WriteLine("NetSalary =" + netSalary + " commission= " + comm);
            }
            else if (totalSalesAmount >= 10501 && totalSalesAmount <= 15000)
            {
                netSalary = totalSalesAmount + BasicSalary;
                Console.WriteLine("NetSalary=" + netSalary);
                comm = (totalSalesAmount * 11) / 100;
                Console.WriteLine("NetSalary =" + netSalary + " commission= " + comm);
            }
            else 
            {
                netSalary = totalSalesAmount + BasicSalary;
                Console.WriteLine("NetSalary=" + netSalary);
                comm = (totalSalesAmount * 15) / 100;
                Console.WriteLine("NetSalary =" + netSalary + " commission= " + comm);
            }

            Console.ReadKey();
        }
    }
}
