using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài1
{
    internal class DaThuc
    {
        int bac;
        int[] chiSoDaThuc;

        
        
        public void nhapBac()
        {
            Console.Write("Nhap bac cua da thuc: ");
            bac=Convert.ToInt16(Console.ReadLine());
        }
        public void nhapChiSoDaThuc()
        {
            chiSoDaThuc = new int[bac];
            for(int i=0; i< bac; i++)
            {
                Console.Write("Nhap chi so cua X^{0}: ",i+1);
                //chiSoDaThuc[i] = Convert.ToInt16(Console.ReadLine());
                chiSoDaThuc[i]=int.Parse(Console.ReadLine());
            }
        }

        public void xuat()
        {
            //Console.Write("Da Thuc: ");
            for(int i=bac-1; i>=0; i--)
            {
                if(chiSoDaThuc[i]!=0)
                    Console.Write("{0}x^{1}", chiSoDaThuc[i], bac--);
                if (chiSoDaThuc[i] > 0&& i>0) 
                    Console.Write(" + ");
            }Console.WriteLine();
        }

        public DaThuc tong(DaThuc dt1, DaThuc dt2)
        {
            DaThuc temp=new DaThuc();
            int bacMax = ((dt1.bac > dt2.bac) ? dt1.bac : dt2.bac);
            int bacMin = ((dt1.bac < dt2.bac) ? dt1.bac : dt2.bac);
            temp.bac = bacMax;
            temp.chiSoDaThuc=new int[bacMax];

            for (int i=0; i < bacMin; i++)
            {
                temp.chiSoDaThuc[i] = dt1.chiSoDaThuc[i] + dt2.chiSoDaThuc[i];
            }

            if (dt1.bac == bacMax)
            {
                for (int i = bacMin; i < bacMax; i++)
                {
                    temp.chiSoDaThuc[i] = dt1.chiSoDaThuc[i];
                }
            }
            else
            {
                for (int i = bacMin; i < bacMax; i++)
                {
                    temp.chiSoDaThuc[i] = dt2.chiSoDaThuc[i];
                }
            }

            return temp;
        }
    }
}
