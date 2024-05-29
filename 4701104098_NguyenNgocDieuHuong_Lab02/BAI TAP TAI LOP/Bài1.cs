using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_tại_lớp
{
    internal class Bài1
    {
        public int[] input()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[{0}]: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        public void output(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + arr[i]);
            }
        }
        public void phanTuLeOViTriChan(int[] arr)
        {
            Console.Write("cac phan tu le o vi tri chan: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

        }
        public void phanTuAmDauTien(int[] arr)
        {
            bool check = false;
            Console.Write("phan tu am dau tien: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    check = true;
                    Console.WriteLine(arr[i]);
                }
            }
            if (!check) Console.WriteLine("Khong Co !!!");
        }

        public void timMaxMin(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
        }

        public void tong(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("tong = " + sum);
        }
    }
}
