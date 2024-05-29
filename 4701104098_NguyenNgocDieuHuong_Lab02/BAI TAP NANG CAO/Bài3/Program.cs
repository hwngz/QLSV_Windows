using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XauChuoi xc = new XauChuoi();
            Console.Write("Nhap ho ten cua ban: ");
            string s =Console.ReadLine();
            //Console.WriteLine("ten cua ban: {0}", s);

            xc.xoaKhoangTrang(ref s);
            xc.demTu(s);
            xc.getHo(s);
            xc.getTen(s);
            xc.getLot(s);
        }
    }
}
