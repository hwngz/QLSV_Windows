using System;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            for (int i = Math.Min(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                    return i;
            }
            return 0;
        }
        public int BCNN(int a, int b)
        {
            for (int i = 1; i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    return i;
                }
            }
            return 0;
        }
        public bool IsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txta.Text) || !IsNumber(txtb.Text))
            {
                MessageBox.Show("số a hoặc số b không hợp lệ", "Xin nhập lại", MessageBoxButtons.OK);
            }
            else
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                txt_uoc.Text = UCLN(a, b) + "";
                txt_bcnn.Text = BCNN(a, b) + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txt_uoc.Text = "";
            txt_bcnn.Text = "";
        }
    }
}
