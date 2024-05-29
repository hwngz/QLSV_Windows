using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1b
{
    class Bai_1b
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri cua x: ");
            double x = double.Parse(Console.ReadLine());
            double f;
            if (x >= 1)
            {
                f = Math.Sqrt(x * x + 1);
            }
            else if(-1 < x && x < 1)
            {
                f = 3 * x + 5;
            }
            else
            {
                f = x * x + 2 * x - 1;
            }
            f = Math.Round(f, 3);
            Console.WriteLine("f(x) = {0} voi x = {1}", f, x);
        }
    }
}
