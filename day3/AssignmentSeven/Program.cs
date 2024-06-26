using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic salary");
            double basicSalary=double.Parse(Console.ReadLine());
            double HRA = (basicSalary * 20) / 100;
            Console.WriteLine("HRA= "+HRA);
            double DA = (basicSalary * 40) / 100;
            Console.WriteLine("DA= "+DA);
            double GrossSalary=HRA+DA+basicSalary;
            Console.WriteLine("GS= "+GrossSalary);

            double pf=(GrossSalary*10)/100; 
            Console.WriteLine("pf= "+pf);
            double netSalaey=GrossSalary-pf;
            Console.WriteLine("NetSalary="+ netSalaey);
            Console.ReadKey(); 
        }
    }
}
