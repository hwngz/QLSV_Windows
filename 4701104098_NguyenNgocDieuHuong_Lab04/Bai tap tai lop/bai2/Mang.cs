using System.Collections.Generic;
using System.Linq;

namespace bai2
{
    internal class Mang
    {
        public List<int> list = new List<int>();
        public void nhap(int x)
        {
            list.Add(x);
        }
        public void sapXepTang()
        {
            list.Sort();
        }

        public void sapXepGiam()
        {
            list.Sort();
            list.Reverse();
        }

        public string xuat()
        {
            string s = "";
            foreach (int x in list)
            {
                s += x.ToString() + " ";
            }
            return s;
        }

        public void them(int data, int index)
        {
            list.Insert(index, data);
        }
        public void xoaGiaTri(int data)
        {
            list.Remove(data);
        }
        public void xoaViTri(int index)
        {
            list.RemoveAt(index);
        }
        public bool timKiemGiaTri(int data)
        {
            foreach (int x in list)
            {
                if (x == data) return true;
            }
            return false;
        }
        public string timKiemViTri(int index)
        {
            if (index < list.Count && index >= 0)
                return list[index].ToString();
            else
                return "NaN";
        }
        public string tong()
        {
            return list.Sum().ToString();
        }
        public string tongChan()
        {
            int sum = 0;
            foreach (int x in list)
            {
                if (x % 2 == 0) sum += x;
            }
            return sum.ToString();
        }
        public string tongLe()
        {
            int sum = 0;
            foreach (int x in list)
            {
                if (x % 2 != 0) sum += x;
            }
            return sum.ToString();
        }
        public string max()
        {
            return list.Max().ToString();
        }
        public string min()
        {
            return list.Min().ToString();
        }
        public void thayTheGiaTri(int data, int newdata)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == data)
                {
                    list[i] = newdata;
                    break;
                }
            }
        }
        public void thayTheViTri(int index, int newdata)
        {
            list[index] = newdata;
        }
    }
}
