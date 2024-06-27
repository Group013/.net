using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Group018\\Desktop\\FileHandling\\logger.txt";
            if (File.Exists(path))
                {
                var fs=File.Create(path);
                fs.Close();
            }
            File.WriteAllText(path, "WelCome to India");
            File.AppendAllText(path, "WelCome to Infoway");
            File.ReadAllText(path);
            Console.ReadKey();
        }
    }
}
