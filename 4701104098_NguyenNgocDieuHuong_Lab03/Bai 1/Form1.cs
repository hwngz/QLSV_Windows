using System;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txta.Text.Trim()) || !IsNumber(txtb.Text.Trim()))
            {
                MessageBox.Show("Số nhập vào không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                TinhToan dt = new TinhToan(a, b);
                txtketqua.Text = dt.Chia().ToString();
            }
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

        private void btncong_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txta.Text.Trim()) || !IsNumber(txtb.Text.Trim()))
            {
                MessageBox.Show("Số nhập vào không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                TinhToan dt = new TinhToan(a, b);
                txtketqua.Text = dt.Cong().ToString();
            }
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txta.Text.Trim()) || !IsNumber(txtb.Text.Trim()))
            {
                MessageBox.Show("Số nhập vào không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                TinhToan dt = new TinhToan(a, b);
                txtketqua.Text = dt.Tru().ToString();
            }
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txta.Text.Trim()) || !IsNumber(txtb.Text.Trim()))
            {
                MessageBox.Show("Số nhập vào không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                TinhToan dt = new TinhToan(a, b);
                txtketqua.Text = dt.Nhan().ToString();
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!IsNumber(ctr.Text.Trim()))
                this.errorProvider1.SetError(ctr, "Nhập số");
            else this.errorProvider1.Clear();


        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!IsNumber(ctr.Text.Trim()))
                this.errorProvider1.SetError(ctr, "Nhập số");
            else this.errorProvider1.Clear();
        }
    }
}
