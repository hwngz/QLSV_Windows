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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            string[] dantoc = { "Giám đốc", "Tổ chức - Hành chính", "Kế hoạch - Tài chính", "Kế toán", "Khảo thí" };
         //add item for cbo
            cbo_PhongBan.Items.AddRange(dantoc);
            cbo_PhongBan.SelectedIndex = 1;
        //add item for TrvDS
            foreach (string item in dantoc)
            {
                trvDS.Nodes.Add(item);
            }
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            //Kiểm tra phòng ban có tồn tài trước đó hay không?
            if(Kiemtra(txtPhongBan.Text))
            {
                MessageBox.Show("Phòng ban đã tồn tại");
                return;
            }
           cbo_PhongBan.Items.Add(txtPhongBan.Text);
           trvDS.Nodes.Add(txtPhongBan.Text);
        }

        private bool Kiemtra(string phong)
        {
            foreach (var item in cbo_PhongBan.Items)
            {
                if(string.Compare(phong,item.ToString(),true) == 0)
                {
                    return true;
                }
            }
            return false;
	
            
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            //Tim index của trvDS có tên hiển thị trùng với tên hiển thị trên cbo
            int index = -1;
            foreach (TreeNode node in trvDS.Nodes)
            {
                if(node.Text == cbo_PhongBan.Text)
                {
                    index = node.Index;
                    break;
                }
            }

            string InfoPerson = txtHoten.Text + "(" + txtMaso.Text + ")";
            trvDS.Nodes[index].Nodes.Add(InfoPerson);
            trvDS.ExpandAll();
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            if(trvDS.SelectedNode != null)
            {
                cbo_PhongBan.Items.Remove(trvDS.SelectedNode.Text);
                trvDS.Nodes.Remove(trvDS.SelectedNode);
            }
        }
    }
}
