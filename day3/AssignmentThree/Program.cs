using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter subject number :");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int avg;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter subject marks");
                int m = int.Parse(Console.ReadLine());
                sum += m;


            }
            Console.WriteLine("sum of 5 subjects=" + sum);
            avg=sum/n;
            Console.WriteLine("average of 5 subjects :"+avg);
            Console.ReadKey();
        }
    }
}
