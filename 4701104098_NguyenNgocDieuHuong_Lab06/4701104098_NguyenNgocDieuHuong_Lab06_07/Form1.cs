﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4701104098_NguyenNgocDieuHuong_Lab06_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                DateTime now = DateTime.Now;
                label1.Text = now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
