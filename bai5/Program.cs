using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai = ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong = ");
            int r = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(" * ");
                }
                if (i < d)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
