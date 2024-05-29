using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4701104098_NguyenNgocDieuHuong_KT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // bool f = true;

        private void btntong_Click(object sender, EventArgs e)
        {
            //if (f)
           // {
                int n = int.Parse(txt1.Text);
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    
                    sum += (double)1 / i;
                }
                txt2.Text = sum.ToString();
           // }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("thoat khong ban", "Thoat", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r == DialogResult.Yes)  
            this.Close();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;  
            if(txt1.Text.Length > 0 && !txt1.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(txt1, "chỉ cho nhập số thôi");
            }
            else
            {
                this.errorProvider1.Clear();
            } 
        }
    }
}
