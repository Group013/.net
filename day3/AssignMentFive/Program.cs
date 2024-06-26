using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMentFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine( "Enter first value");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2=temp;
            Console.WriteLine("After swapping"+ num1 +" "+num2);
            Console.ReadKey();  
        }
    }
}
