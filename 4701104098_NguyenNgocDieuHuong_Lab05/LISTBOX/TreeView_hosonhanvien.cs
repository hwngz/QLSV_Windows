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
    public partial class TreeView_hosonhanvien : Form
    {
        public TreeView_hosonhanvien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        bool kiemtra(string s)
        {
            foreach(TreeNode str in trv_PB.Nodes)
            {
                if (string.Compare(str.Text, s, true) == 0)
                    return false;
            }
            return true;
        }
        private void btn_thêmPB_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_PB.Text))
            {
                trv_PB.Nodes.Add(txt_PB.Text);
                cbo_phongban.Items.Add(txt_PB.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại");
            txt_PB.Text = "";
            txt_PB.Focus();
        }

        private void TreeView_hosonhanvien_Load(object sender, EventArgs e)
        {
            trv_PB.Nodes.Clear();
            string[] pb = { "Giam doc", "To chuc hanh chinh", "Ke hoach", "Ke toan" };
            foreach (string s in pb)
            {
                trv_PB.Nodes.Add(s);
                cbo_phongban.Items.Add(s);
            }
            cbo_phongban.SelectedIndex = 0;
        }

        private void btn_xoaPB_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co muon xoa khong", "thong bao", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(trv_PB.SelectedNode != null)
                {
                    cbo_phongban.Items.Remove(trv_PB.SelectedNode.Text);
                    trv_PB.Nodes.Remove(trv_PB.SelectedNode);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(TreeNode tn in trv_PB.Nodes)
                if(tn.Text == cbo_phongban.Text)
                {
                    index = tn.Index;
                    break;
                }
            trv_PB.Nodes[index].Nodes.Add(txt_hoten.Text + "(" + txt_maso.Text + ")");
            trv_PB.ExpandAll();
        }
    }
}
