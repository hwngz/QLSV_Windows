using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài2
{
    internal class Mang2Chieu
    {
        public int[,] input2chieu()
        {
            int n, m;
            Console.Write("Nhap so dong: "); n = Convert.ToInt32(Console.ReadLine()); Console.Clear();
            Console.Write("Nhap so cot: "); m = Convert.ToInt32(Console.ReadLine()); Console.Clear();
            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Nhap arr[{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }
            return arr;
        }
        public void output2chieu(int[,] arr)
        {
            Console.Write("Ma Tran\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        public void timMaxMin(int[,] arr)
        {
            int max = arr[0, 0];
            int min = arr[0, 0];
            int[,] index = new int[2, 2];


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        index[0, 0] = i; index[0, 1] = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        index[1, 0] = i; index[1, 1] = j;
                    }
                }
            }
            Console.WriteLine("gia tri max={0} tai arr[{1},{2}]", max, index[0, 0], index[0, 1]);
            Console.WriteLine("gia tri min={0} tai arr[{1},{2}]", min, index[1, 0], index[1, 1]);
        }
        public void timMaxMinHang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[0, 0];
                int min = arr[0, 0];
                int[,] index = new int[2, 2];
                Console.WriteLine("Dong thu {0}", i + 1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        index[0, 0] = i; index[0, 1] = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        index[1, 0] = i; index[1, 1] = j;
                    }
                }
                Console.WriteLine("\tmax={0} tai arr[{1},{2}]", max, index[0, 0], index[0, 1]);
                Console.WriteLine("\tmin={0} tai arr[{1},{2}]", min, index[1, 0], index[1, 1]);
            }

        }
        public void timMaxMinCheo(int[,] arr)
        {
            int max = arr[0, 0];
            int min = arr[0, 0];
            int[] index = new int[2];
            Console.WriteLine("Duong Cheo Chinh");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, i] > max)
                {
                    max = arr[i, i];
                    index[0] = i;
                }
                if (arr[i, i] < min)
                {
                    min = arr[i, i];
                    index[1] = i;
                }
            }
            Console.WriteLine("\tmax={0} tai arr[{1},{2}]", max, index[0], index[0]);
            Console.WriteLine("\tmin={0} tai arr[{1},{2}]", min, index[1], index[1]);
        }
        public void phanTuXuatHienNhieu(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tanSuat = new int[1000];
                int max = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    tanSuat[arr[i, j]]++;
                    if (arr[i, j] > max) max = arr[i, j];

                }
                int f = tanSuat[0], fIndex = 0;
                for (int k = 0; k <= max; k++)
                {
                    if (tanSuat[k] > f)
                    {
                        f = tanSuat[k];
                        fIndex = k;
                    }
                }
                Console.WriteLine("Phan Tu Xuat Hien Nhieu Nhat Tai Dong {0}: {1}, {2} lan.", i + 1, fIndex,f);
            }
        }
        
    }
}

