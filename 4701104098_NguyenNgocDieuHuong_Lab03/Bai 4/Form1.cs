using System;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class tt = new Class();

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            string s = txt_nhapso.Text;
            int x = int.Parse(s);
            tt.Nhap(x);
            txt_dayvuanhap.Text = tt.Xuat();
            txt_nhapso.Clear();
            txt_nhapso.Focus();
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            txt_tongpt.Text = tt.Tong().ToString();
        }

        private void btn_tongchan_Click(object sender, EventArgs e)
        {
            txt_tongchan.Text = tt.Chan().ToString();
        }

        private void btn_tongle_Click(object sender, EventArgs e)
        {
            txt_tongle.Text = tt.Le().ToString();
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {

            txt_dayvuanhap.Text = "";
            tt.Reset();
            txt_tongchan.Text = "";
            txt_tongle.Text = "";
            txt_tongpt.Text = "";


        }
    }
}
