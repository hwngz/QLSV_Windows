using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri cua x: ");
            double x = double.Parse(Console.ReadLine());
            double f;
            if(x > 0)
            {
                f = 3 * x + Math.Sqrt(x);
            }
            else
            {
                f = Math.Pow(Math.E, x) + 4;
            }
            f = Math.Round(f, 3);
            Console.WriteLine("f(x) = {0} voi x = {1}", f, x);
        }
    }
}
