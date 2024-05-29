using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("nhap x: ");
            x = int.Parse(Console.ReadLine());

            int y = 3 * x*x + 4 * x - 7;
            Console.WriteLine("ket qua y = {0}", y);
        }
    }
}
