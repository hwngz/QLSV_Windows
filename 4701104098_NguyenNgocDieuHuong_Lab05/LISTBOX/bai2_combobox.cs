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
    public partial class bai2_combobox : Form
    {
        public bai2_combobox()
        {
            InitializeComponent();
            lbl_ketqua.Visible = false;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_loaddt_Click(object sender, EventArgs e)
        {
            cbo_dt.Items.Clear();
            string[] dt = { "Kinh", "Hoa", "K'Me", "Khac" };
            cbo_dt.Items.AddRange(dt);
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc đã được chọn: ";
            if(cbo_dt.SelectedIndex >= 0)
            {
                lbl_ketqua.Text = s + cbo_dt.SelectedItem.ToString();
                //lbl_ketqua.Text = s;
                lbl_ketqua.Visible = true;
            }
            else
            {
                lbl_ketqua.Text = "Bạn chưa có dân tộc";
            } 
        }
    }
}
