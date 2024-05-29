using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; Console.Write("Nhap so luong ptu: "); n= int.Parse(Console.ReadLine());
            int[] arr=new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap gia tri cua arr[{0}]: ",i);
                arr[i]=int.Parse(Console.ReadLine());
            }

            int sum = 0;
            if (arr[0] > arr[1]) sum+=arr[0];
            if (arr[arr.Length-1] > arr[arr.Length-2]) sum+=arr[arr.Length-1];
            for (int i = 1; i < arr.Length-1; i++)
            {
                if(arr[i-1] < arr[i] && arr[i+1] < arr[i])
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Tong phan tu cuc dai = "+sum);

        }

    }
}
