using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMentEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter year");
             int year=int.Parse(Console.ReadLine()); 
            //int year = 2020;
            if ((year%4==0) && (year % 100 != 0))
            {

                Console.WriteLine($"{year} is leap year");


            }
            else if( year % 400 == 0)
            {
                Console.WriteLine($"{year } is  leap year");

            }
            else
            {
                Console.WriteLine($"{year} is not leap year");
            }
            Console.ReadKey();
        }
    }
}
