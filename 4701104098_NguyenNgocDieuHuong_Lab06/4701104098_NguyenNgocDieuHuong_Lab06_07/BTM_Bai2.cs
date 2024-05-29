using System;
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
    public partial class BTM_Bai2 : Form
    {
        public BTM_Bai2()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtmssv.Text)) || (string.IsNullOrEmpty(txthoten.Text)))
            {
                MessageBox.Show("chưa điền thông tin");
            }
            else
            {
                ListViewItem it = new ListViewItem();
                it.Text = txtmssv.Text;
                lstv1.Items.Add(it);
                ListViewItem.ListViewSubItem sit = new ListViewItem.ListViewSubItem(it, (txthoten.Text));
                it.SubItems.Add(sit);
                txthoten.Clear();
                txtmssv.Clear();
                txtmssv.Focus();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Ban muon xoa khong", "canh bao");
                if (dl == DialogResult.OK)
                {
                    foreach (ListViewItem i in lstv1.SelectedItems)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
            {
                ListViewItem item = lstv1.FocusedItem;
                item.SubItems[0].Text = txtmssv.Text;
                item.SubItems[1].Text = txthoten.Text;
            }
        }
    }
}