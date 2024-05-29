using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tuoi = DateTime.Now;
            string name = Console.ReadLine();
            double namsinh = double.Parse(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(namsinh);
            Console.WriteLine(tuoi.Year - namsinh);
            Console.WriteLine(2020 - namsinh);
        }
    }
}