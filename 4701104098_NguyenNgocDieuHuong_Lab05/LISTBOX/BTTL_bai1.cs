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
    public partial class BTTL_bai1 : Form
    {
        public BTTL_bai1()
        {
            InitializeComponent();
        }

        private void cbo_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("thoat hay khong", "canh bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "moi ban nhap so");
            else
                this.errorProvider1.Clear();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            if(textbox1.Text != "")
            {
                bool check = true;
                foreach(string num in cbo_capnhat.Items)
                {
                    if (string.Compare(textbox1.Text, num, true) == 0)
                        check = false;

                }   
                if(check)
                {
                    cbo_capnhat.Items.Add(textbox1.Text);
                    textbox1.Clear();
                    textbox1.Focus();
                }    
                else
                {
                    MessageBox.Show(textbox1.Text + "da ton tai\n vui long nhap so khac", "Warning",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textbox1.Clear();
                }    
            }    
        }

        private void cbo_capnhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltb_dsuocso.Items.Clear();
        }
    }
}
