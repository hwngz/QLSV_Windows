using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaphai_Click(object sender, EventArgs e)
        {
            list_phai.Items.Add(list_trai.SelectedItem);
            list_trai.Items.Remove(list_trai.SelectedItem);
        }

        private void btn_qua_phai_all_Click(object sender, EventArgs e)
        {
            list_phai.Items.AddRange(list_trai.Items);
            list_trai.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string[] menu = { "Coc", "Oi", "Xoai", "Man", "Cam" };
            list_phai.Items.AddRange(list_trai.Items);
            list_trai.Items.Clear();*/

        }
    }
}
