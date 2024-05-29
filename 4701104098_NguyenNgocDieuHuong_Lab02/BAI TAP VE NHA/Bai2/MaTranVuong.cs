using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class MaTranVuong
    {
        public int[,] nhap()
        {
            Console.Write("Nhap cap cua ma tran: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap arr[{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }
            return arr;
        }
        public void xuat(int[,] arr)
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

        public void duongCheo(int[,] arr)
        {
            Console.Write("Duong Cheo Chinh: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i,i] + " ");
            }
            Console.Write("\nDuong Cheo Phu: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i+1 + j+1 == arr.GetLength(0)+1)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
            }Console.WriteLine();
        }
        public void tongCheo(int [,] arr)
        {
            int sumChinh = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sumChinh += arr[i, i];
            }
            Console.WriteLine("Tong duong cheo chinh = {0}", sumChinh);

            int sumPhu = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i + 1 + j + 1 == arr.GetLength(0) + 1)
                    {
                        sumPhu += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Tong duong cheo phu = {0}", sumPhu);
        }

        public void tamGiacTrenDuoi(int[,] arr)
        {
            Console.Write("Phan tu tam giac tren: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(0); j++)
                {
                    if (i < j)
                    {
                        Console.Write(arr[i, j]+" ");
                    }
                }
            }Console.WriteLine();

            Console.Write("Phan tu tam giac duoi: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i > j)
                    {
                        Console.Write(arr[i, j]+" ");
                    }
                }
            }
            Console.WriteLine();
        }
        public void tongTamGiac(int[,] arr)
        {
            int sumTren = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i < j)
                    {
                        sumTren += arr[i, j];
                    }
                }
            }
            Console.WriteLine("tong tam giac tren: "+sumTren);

            int sumDuoi = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i > j)
                    {
                        sumDuoi+=arr[i, j];
                    }
                }
            }
            Console.WriteLine("tong tam giac duoi: " + sumDuoi);
        }


    }
}
