using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Program
    {

        public static void addition(int a, int b) {
            int s = a + b;
            Console.WriteLine("Sum "+ s );
        }
        static void Main(string[] args)
        {
            Program.addition(4, 5);
            Console.ReadKey();

        }
    }
}
