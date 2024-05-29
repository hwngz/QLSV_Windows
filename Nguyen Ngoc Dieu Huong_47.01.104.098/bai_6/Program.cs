using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tenKhachHang = Console.ReadLine();
            double chiSoCu = double.Parse(Console.ReadLine());
            double chiSoMoi = double.Parse(Console.ReadLine());
            double tieuThu = chiSoMoi - chiSoCu;
            double tienDien = tieuThu * 1532;
            Console.WriteLine("HOA DON TIEN DIEN");
            Console.WriteLine("Khach hang: " + tenKhachHang);
            Console.WriteLine("Chi so cu: " + chiSoCu);
            Console.WriteLine("Chi so moi: " + chiSoMoi);
            Console.WriteLine("Tieu thu: " + tieuThu);
            Console.WriteLine("Tien dien: " + tienDien);
            Console.WriteLine("Yeu cau tiet kiem dien");
        }
    }
}