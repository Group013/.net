using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char");
            char c=char.Parse(Console.ReadLine());
             Console.WriteLine( $"ASCII value of char {c} is = {(int)c}");
            Console.ReadKey();
        }
    }
}
