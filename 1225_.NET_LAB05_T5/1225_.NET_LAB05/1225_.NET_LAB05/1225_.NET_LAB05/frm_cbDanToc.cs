using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1225_.NET_LAB05
{
    public partial class frm_cbDanToc : Form
    {
        public frm_cbDanToc()
        {
            InitializeComponent();
        }

        private void btn_loadDL_Click(object sender, EventArgs e)
        {
            cbo_dantoc.Items.Clear();
            string[] dantoc = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };
            //foreach (string s in dantoc)
            //{
            //    cbo_dantoc.Items.Add(s);

            //}
            cbo_dantoc.Items.AddRange(dantoc);
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            //if (cbo_dantoc.SelectedIndex >= 0)
            //    lblKetQua.Text = "Dân tộc được chọn: " + cbo_dantoc.SelectedItem.ToString();
            //else
            //    lblKetQua.Text = "Bạn chua chọn dân tộc";
        }

        private void cbo_dantoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_dantoc.SelectedIndex >= 0)
            {
                string s = "Dân tộc được chọn: " + cbo_dantoc.SelectedItem.ToString();
                lblKetQua.Text = "Dân tộc được chọn: " + cbo_dantoc.SelectedItem.ToString();
            }
            }
              
    }
}
