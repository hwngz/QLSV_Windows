using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_tại_lớp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Bài1 cl1 = new Bài1();
            int[] a = cl1.input();
            cl1.output(a);
            cl1.phanTuLeOViTriChan(a);
            cl1.phanTuAmDauTien(a);
            cl1.timMaxMin(a);
            cl1.tong(a);

            //Bài2 cl2 = new Bài2();
            //int[,] arr = cl2.input2chieu(); ;
            //cl2.output2chieu(arr);
            //cl2.tongDuong(arr);
            //cl2.duongCheo(arr);
            //cl2.tongTamGiacTren(arr);
            //cl2.tongChan(arr);
            //cl2.tongDongI(arr);

            //Bài3 cl3 = new Bài3();
            //string s = cl3.inputChuoi();
            //cl3.ChuHoaDau(s);
            //cl3.ChuHoaChuThuong(s);
            //cl3.DemNguyenAmPhuAm(s);

        }
    }
}
