using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaThuc dt1 = new DaThuc();
            dt1.nhapBac();
            dt1.nhapChiSoDaThuc();
            //dt1.xuat();

            DaThuc dt2 = new DaThuc();
            dt2.nhapBac();
            dt2.nhapChiSoDaThuc();
            //dt2.xuat();

            DaThuc dtTong = new DaThuc();
            dtTong=dtTong.tong(dt1,dt2);
            Console.Write("Tong cua 2 da thuc la: ");
            dtTong.xuat();
        }
    }
}
