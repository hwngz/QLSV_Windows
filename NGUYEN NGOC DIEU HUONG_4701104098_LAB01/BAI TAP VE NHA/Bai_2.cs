using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Bai_2
    {
        static bool Check(int x)
        {
            int y = x % 10;
            x = x / 10;
            if(x != y)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach so co 2 chu so khac nhau doi mot: ");
            for(int i = 10; i <= 99; i++)
            {
                if (Check(i))
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
