namespace Bai_4
{
    internal class Class
    {
        int n;
        int[] a;

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public Class()
        {
            n = 0;
            a = new int[100];
        }
        public void Nhap(int k)
        {
            a[n] = k;
            n++;
        }
        public int Tong()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public int Chan()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
            return sum;
        }
        public void Reset()
        {
            n = 0;
            a = new int[100];
        }
        public int Le()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    sum += a[i];
            }
            return sum;
        }
        public string Xuat()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += a[i].ToString() + " ";
            }
            return s;
        }
    }
}
