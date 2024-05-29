using System;

namespace WindowsFormsApp1
{
    internal class PhuongTrinhBacHai
    {
        public float a, b, c;
        public float A
        {
            get { return a; }
            set { a = value; }
        }
        public float B
        {
            get { return b; }
            set { b = value; }
        }
        public float C
        {
            get { return c; }
            set { c = value; }
        }

        public string giaiPTB2() //ax2+bx+c=0
        {
            float delta = (-4 * b) / (2 * a * c);
            float x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
            float x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return "Phuong trinh vo so nghiem!";
                    else
                        return "Phuong trinh vo nghiem!";
                }
                else return "Nghiem duy nhat x = " + ((float)-c / b).ToString();
            }
            else
            {
                if (delta > 0)
                    return "Phuong trinh co 2 nghiem:\n x1 = " + Math.Round(x1, 2) + "\n x2 = " + Math.Round(x2, 2);
                else if (delta == 0)
                    return "Phuong trinh co nghiem kep x1=x2=" + Math.Round(x1, 2);
                else
                    return "Phuong trinh vo nghiem!";
            }

        }
    }
}
