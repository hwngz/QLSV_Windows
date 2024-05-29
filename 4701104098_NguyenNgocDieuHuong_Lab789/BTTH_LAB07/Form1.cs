using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_LAB07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbo_chonkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string slq = "select + from Lop where MaKhoa='" + cbo_chonkhoa.SelectedValue.ToString()'";
            DataSet ds = new DataSet();
            //SqlDataAdapte sqlDataAdapte = new SqlDataAdapte(sql, connection);
            //SqlDataAdapter.Fill(ds);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem list = listView1.SelectedItems[0];
        }

        private void lbl_diem_Click(object sender, EventArgs e)
        {

        }
    }
}
