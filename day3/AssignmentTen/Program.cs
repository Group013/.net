using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no");
            int n2 = int.Parse(Console.ReadLine());
            int ch;
            do
            {

                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice");
                ch=int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        int sum=n1+n2;
                        Console.WriteLine("ADDItion= "+sum);
                        break;
                    case 2:
                        int sub = n1 - n2;
                        Console.WriteLine("sub= " + sub);
                        break;
                    case 3:
                        int mul = n1 * n2;
                        Console.WriteLine("Mul= " + mul);
                        break;
                    case 4:
                        int div = n1 / n2;
                        Console.WriteLine("div= " + div);
                        break;
                    case 5:
                        Console.WriteLine("exit!!!");
                        break;


                }

            } while (ch != 5);
            Console.ReadKey();  
        }
    }
}
