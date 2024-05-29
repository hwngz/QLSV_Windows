using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_tại_lớp
{
    internal class Bài2
    {
        public int[,] input2chieu()
        {
            int n, m;
            Console.Write("Nhap so dong: "); n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: "); m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Nhap arr[{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        public void output2chieu(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        public void tongDuong(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0) sum += arr[i, j];

                }
            }
            Console.WriteLine("tong so duong: {0}", sum);
        }
        public void duongCheo(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine("Tong duong cheo chinh: {0}", sum);
        }
        public void tongTamGiacTren(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        sum += arr[i, j];
                    }

                }
            }
            Console.WriteLine("Tong tam giac tren: " + sum);
        }
        public void tongChan(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0) sum += arr[i, j];

                }
            }
            Console.WriteLine("Tong phan tu chan: " + sum);
        }
        public void tongDongI(int[,] arr)
        {
            int sum = 0;
            Console.Write("Nhap dong muon tinh tong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[n, i];
            }
            Console.WriteLine("Tong dong {0} la: {1}", n, sum);
        }
    }
}
