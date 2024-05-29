using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4701104098_NguyenNgocDieuHuong_Lab06_07
{
    public partial class B1BTVN : Form
    {
        int phut;
        int giay;
        public B1BTVN()
        {
            InitializeComponent();
        }
       // private int counter = 60;
        private void btn_batdau_Click(object sender, EventArgs e)
        {
            phut = int.Parse(lbl_phut.Text);
            giay = int.Parse(lbl_giay.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (phut == 0)
                timer1.Stop();

            giay--;
            if (giay == 0)
            {
                phut -= 1;
                giay = 60;

            }

            lbl_giay.Text = giay.ToString();
            lbl_phut.Text = phut.ToString();

        }
    }
}
