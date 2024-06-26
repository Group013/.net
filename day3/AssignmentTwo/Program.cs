using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter subject number :");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter subject marks");
                int m = int.Parse(Console.ReadLine());
                sum += m;
                

            }
            Console.WriteLine("sum of  subjects="+sum);
            Console.ReadKey();

        }
    }
}
