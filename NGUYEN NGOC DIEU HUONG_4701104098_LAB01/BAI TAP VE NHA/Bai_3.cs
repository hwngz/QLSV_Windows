using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Bai_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vui long nhap gia tri n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach cac so le nho hon n: ");
            for(int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
