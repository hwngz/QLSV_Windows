using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string Donvi(int n)
        {
            string s = "";
            if (n == 1)
                s += "Một ";
            if (n == 2)
                s += "Hai ";
            if (n == 3)
                s += "Ba ";
            if (n == 4)
                s += "Bốn";
            if (n == 5)
                s += "Năm ";
            if (n == 6)
                s += "Sáu ";
            if (n == 7)
                s += "Bảy ";
            if (n == 8)
                s += "Tám ";
            if (n == 9)
                s += "Chín ";
            return s;
        }
        static string Chuc(int n)
        {
            string s = "";
            if (n == 1)
                s += "Mười ";
            if (n == 2)
                s += "Hai Mươi ";
            if (n == 3)
                s += "Ba Mươi ";
            if (n == 4)
                s += "Bốn Mươi ";
            if (n == 5)
                s += "Năm Mươi ";
            if (n == 6)
                s += "Sáu Mươi ";
            if (n == 7)
                s += "Bảy Mươi ";
            if (n == 8)
                s += "Tám Mươi ";
            if (n == 9)
                s += "Chín Mươi ";
            return s;
        }
        static int Dem(int n)
        {
            int tmp = n;
            int dem = 0;
            while (tmp != 0)
            {
                tmp = tmp / 10;
                dem++;
            }
            return dem;
        }

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txt_nhap.Text);
            Dem(n);
            if (Dem(n) == 1)
            {
                txt_xuat.Text = Donvi(n);
            }
            else if (Dem(n) == 2)
            {
                int donvi = n % 10;
                int chuc = n / 10;
                if (donvi == 5)
                    txt_xuat.Text = Chuc(chuc) + "Lăm";
                else if (donvi == 1 && chuc != 1)
                    txt_xuat.Text = Chuc(chuc) + "Mốt";
                else
                    txt_xuat.Text = Chuc(chuc) + Donvi(donvi);
            }
            else if (Dem(n) == 3)
            {
                int tram = n / 100;
                int chuc = (n / 10) % 10;
                int donvi = n % 10;
                if (chuc == 0 && donvi != 0)
                {
                    txt_xuat.Text = Donvi(tram) + "Trăm " + "Linh " + Donvi(donvi);
                }
                else
                {
                    if (donvi == 5)
                        txt_xuat.Text = Donvi(tram) + "Trăm " + Chuc(chuc) + "Lăm";
                    else if (donvi == 1 && chuc != 1)
                        txt_xuat.Text = Donvi(tram) + "Trăm " + Chuc(chuc) + "Mốt";
                    else
                        txt_xuat.Text = Donvi(tram) + "Trăm " + Chuc(chuc) + Donvi(donvi);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cc == DialogResult.Yes)
                Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_nhap.Clear();
            txt_xuat.Clear();
            txt_nhap.Focus();
        }
    }
}
