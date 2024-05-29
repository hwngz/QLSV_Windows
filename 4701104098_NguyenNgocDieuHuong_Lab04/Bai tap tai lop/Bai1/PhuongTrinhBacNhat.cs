namespace WindowsFormsApp1
{
    internal class PhuongTrinhBacNhat
    {
        public float a, b;

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
        public string giaiPTB1()
        {
            //ax+b=0
            if (a == 0 && b != 0) return "Phuong Trinh Vo Nghiem!";
            else if (b == 0 && a == 0) return "Phuong Trinh Vo So Nghiem!";
            float kq = (float)-b / a;
            return "Phuong Trinh Co Nghiem x = " + kq.ToString();
        }
    }
}
