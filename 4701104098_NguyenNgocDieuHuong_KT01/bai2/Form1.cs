using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnhapso_Click(object sender, EventArgs e)
        {
            txtdaynhap.Text = (txtdaynhap.Text).Insert(txtdaynhap.Text.Length, txtnhapso.Text + " ");

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("thoat khong ban", "Thoat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void txtnhapso_TextChanged(object sender, EventArgs e)
        {
            if (txtnhapso.Text.Length > 0 && !txtnhapso.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(txtnhapso, "chỉ cho nhập số thôi");
            }
            else
            {
                this.errorProvider1.Clear();

                //txtdaynhap.Text = (txtdaynhap.Text).Insert(txtdaynhap.Text.Length, txtnhapso.Text + " ");
            }


        }
    }
}
