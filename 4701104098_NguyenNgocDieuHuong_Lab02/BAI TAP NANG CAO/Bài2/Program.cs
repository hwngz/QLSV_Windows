using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mang2Chieu m2c = new Mang2Chieu();
            int[,] arr = m2c.input2chieu();
            m2c.output2chieu(arr);
            m2c.timMaxMin(arr);
            m2c.timMaxMinHang(arr);
            m2c.timMaxMinCheo(arr);
            m2c.phanTuXuatHienNhieu(arr);
        }
    }
}
