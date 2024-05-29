using System;
using System.Windows.Forms;

namespace May_tinh_bo_tui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double n, m;
        private string dau;
        private string nho1, nho2;

        private void button1_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            txt_hienthi.Text += num.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dau = button.Text;
            nho1 = txt_hienthi.Text;
            lblHien_thi.Text = txt_hienthi.Text + dau;
            txt_hienthi.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_ketqua_Click(object sender, EventArgs e)
        {
            nho2 = txt_hienthi.Text;
            lblHien_thi.Text += nho2;
            n = double.Parse(nho1);
            m = double.Parse(nho2);
            if (dau == "+")
            {
                double tong = n + m;
                txt_hienthi.Clear();
                txt_hienthi.Text = tong + "";
            }
            else if (dau == "-")
            {
                double hieu = n - m;
                txt_hienthi.Clear();
                if (hieu < 0)
                {
                    hieu = Math.Abs(hieu);
                    txt_hienthi.Text = hieu + "-";
                }
                else
                    txt_hienthi.Text = hieu + "";
            }
            else if (dau == "*")
            {
                double nhan = n * m;
                txt_hienthi.Clear();
                txt_hienthi.Text = nhan + "";
            }
            else if (dau == "/")
            {
                double chia = n / m;
                txt_hienthi.Clear();
                txt_hienthi.Text = chia + "";
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            txt_hienthi.Clear();
            lblHien_thi.Text = "";
            txt_hienthi.Focus();
        }
    }
}