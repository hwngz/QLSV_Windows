using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Bai_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vui long nhap gia tri cua n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap gia tri cua m: ");
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                    count++;
            }
            Console.WriteLine("So luong so chan trong [n, m]: {0}", count);
        }
    }
}
