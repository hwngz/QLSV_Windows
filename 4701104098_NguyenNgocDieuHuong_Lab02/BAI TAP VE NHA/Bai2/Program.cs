using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaTranVuong mt=new MaTranVuong();
            int[,] arr= mt.nhap();
            mt.xuat(arr);
            mt.duongCheo(arr);
            mt.tongCheo(arr);
            mt.tamGiacTrenDuoi(arr);
            mt.tongTamGiac(arr);
        }
    }
}
