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
            string s;
            s = Console.ReadLine();
            int Toan, Ly, Hoa;
            Toan = Int32.Parse(Console.ReadLine());
            Ly = Int32.Parse(Console.ReadLine());
            Hoa = Int32.Parse(Console.ReadLine());
            double dtb = (Ly + Hoa + Toan * 2) / 4;
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(dtb);
        }
    }
}