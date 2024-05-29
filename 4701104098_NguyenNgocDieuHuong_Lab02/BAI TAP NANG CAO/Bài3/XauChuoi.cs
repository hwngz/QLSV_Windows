using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài3
{
    internal class XauChuoi
    {
        public void xoaKhoangTrang(ref string s)
        {
            s = s.Trim();
            while (s.IndexOf("  ") != -1)
            {
                s = s.Replace("  ", " ");
            }
            Console.WriteLine("Sau khi xoa khoang trang: "+s);
        }
        public void demTu(string s)
        {
            int count = 0;
            char[] charArray=s.ToCharArray();
            for(int i=0; i<s.Length; i++)
            {
                if(charArray[i]!=' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Chuoi S co {0} tu.", count);
        }
        public void getHo(string s)
        {
            int space= s.IndexOf(' ');
            string ho=s.Substring(0, space);
            Console.WriteLine("Ho: " + ho);
        }
        public void getTen(string s)
        {
            int space = s.LastIndexOf(' ');
            string ten=s.Substring(space+1);
            Console.WriteLine("Ten: " + ten);
        }

        public void getLot(string s)
        {
            int space1 = s.IndexOf(' ');
            int space2 = s.LastIndexOf(' ');
            string lot=s.Substring(space1+1, space2-space1);
            Console.WriteLine("Lot: " + lot);
        }
    }
}
