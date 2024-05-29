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

        private void Form1_Load(object sender, EventArgs e)
        {
            btGiai.Enabled = false;
            tbKetqua.Enabled = false;
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                PhuongTrinhBacNhat ptb1 = new PhuongTrinhBacNhat();
                ptb1.a = float.Parse(tbA.Text);
                ptb1.b = float.Parse(tbB.Text);
                tbKetqua.Text = ptb1.giaiPTB1();
            }
            if (rdoBacHai.Checked)
            {
                PhuongTrinhBacHai ptb2 = new PhuongTrinhBacHai();
                ptb2.a = float.Parse(tbA.Text);
                ptb2.b = float.Parse(tbB.Text);
                ptb2.c = float.Parse(tbC.Text);
                tbKetqua.Text = ptb2.giaiPTB2();
            }

        }

        private void rdoBacHai_CheckedChanged(object sender, EventArgs e)
        {
            tbC.Enabled = true;
            if (tbA.Text != "" && tbB.Text != "" && tbC.Text != "")
                btGiai.Enabled = true;
            else
                btGiai.Enabled = false;
        }

        private void rdoBacNhat_CheckedChanged(object sender, EventArgs e)
        {
            tbC.Clear();
            tbC.Enabled = false;
            if (tbA.Text != "" && tbB.Text != "")
                btGiai.Enabled = true;
            else
                btGiai.Enabled = false;
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
            if (rdoBacHai.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "" && tbC.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
            if (rdoBacHai.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "" && tbC.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
        }

        private void tbC_TextChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
            if (rdoBacHai.Checked)
            {
                if (tbA.Text != "" && tbB.Text != "" && tbC.Text != "")
                    btGiai.Enabled = true;
                else
                    btGiai.Enabled = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}