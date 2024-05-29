using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_tại_lớp
{
    internal class Bài3
    {
        public string inputChuoi()
        {
            string s;
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();
            return s;
        }
        public void ChuoiDoiXung(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - 1 - i])
                {
                    Console.WriteLine("Khong doi xung");
                    return;
                }
            }
            Console.WriteLine("Doi xung");
        }
        public void ChuHoaDau(string s)
        {
            s=s.Trim();
            char[] charArray = s.ToCharArray();
            bool foundSpace = true;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (Char.IsLetter(charArray[i]))
                {
                    if (foundSpace)
                    {
                        charArray[i] = Char.ToUpper(charArray[i]);
                        foundSpace = false;
                    }
                }
                else
                {
                    //if (charArray[i+1]==' ')
                    foundSpace = true;
                }
            }
            s = new string(charArray);
            Console.WriteLine("Viet hoa chu dau: {0}", s);

        }
        public void ChuHoaChuThuong(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((int)charArray[i] >= (int)'a' && charArray[i] <= (int)'z')
                {
                    charArray[i] = Char.ToUpper(charArray[i]);
                }
                else
                {
                    charArray[i] = Char.ToLower(charArray[i]);
                }
            }
            s = new string(charArray);
            Console.WriteLine("Chuoi s moi: {0}", s);
        }

        public void DemNguyenAmPhuAm(string s)
        {
            s = s.ToLower();
            int nguyenam = 0,
                khoangtrang = 0,
                phuam = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'u' || s[i] == 'e' || s[i] == 'o' || s[i] == 'a' || s[i] == 'i')
                {
                    nguyenam++;
                }
                else if (s[i] == ' ')
                {
                    khoangtrang++;
                }
                else
                {
                    phuam++;
                }
            }
            Console.WriteLine("Nguyen am: {0}\nPhu am: {1}\nKhoang trang: {2}", nguyenam, phuam, khoangtrang);
        }
    }
}
