using System;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mang mang = new Mang();
        private void btnNhapMang_Click(object sender, System.EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                mang.list.Clear();
                string s = txtNhapMang.Text.Trim();
                string s1 = "";
                int i = s.IndexOf(' ');
                if (i == -1)
                    mang.list.Add(int.Parse(txtNhapMang.Text));
                else
                {
                    while (i != -1)
                    {
                        s1 = s.Substring(0, i);
                        mang.list.Add(int.Parse(s1));
                        s = s.Substring(i + 1);
                        string tmp = "";
                        i = s.IndexOf(' ');
                    }
                    mang.list.Add(int.Parse(s));
                }
                txtKetQuaMang.Text = mang.xuat();
            }
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtNhapMang.Clear();
            txtKetQuaMang.Clear();
            rdSXGiam.Checked = false;
            rdSXTang.Checked = false;
            rdViTriCanTim.Checked = false;
            rdGiaTriCanTim.Checked = false;
            txtSoTimDuoc.Clear();
            rdGiatricanxoa.Checked = false;
            rdViTriCanXoa.Checked = false;
            rdGiaTriCanThem.Checked = false;
            txtViTriCanThem.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtTongLe.Clear();
            txtMax.Clear();
            txtMin.Clear();
            rdGiaTriCanThayThr.Checked = false;
            rdViTriCanThayThe.Checked = false;
            txtSoThayThe.Clear();
            mang.list.Clear();
            txtGiaTriCanTim.Clear();
            txtViTriCanTim.Clear();
            txtGiaTriCanXoa.Clear();
            txtViTriCanXoa.Clear();
            txtGiaTriCanThem.Clear();
            txtGiaTriCanThayThr.Clear();
            txtViTriCanThayThe.Clear();
            txtSoThayThe.Clear();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnThucHien_Click(object sender, System.EventArgs e)
        {
            if (rdSXTang.Checked)
            {
                mang.sapXepTang();
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdSXGiam.Checked)
            {
                mang.sapXepGiam();
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdGiaTriCanTim.Checked)
            {
                if (mang.timKiemGiaTri(int.Parse(txtGiaTriCanTim.Text)))
                    MessageBox.Show(txtGiaTriCanTim.Text + " Co Ton Tai Trong Mang !!!", "Thong bao", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khong Tim Thay " + txtGiaTriCanTim.Text, "Thong Bao", MessageBoxButtons.OK);
            }
            if (rdViTriCanTim.Checked)
            {
                txtSoTimDuoc.Text = mang.timKiemViTri(int.Parse(txtViTriCanTim.Text));
            }
            if (rdGiatricanxoa.Checked)
            {
                mang.xoaGiaTri(int.Parse(txtGiaTriCanXoa.Text));
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdViTriCanXoa.Checked)
            {
                mang.xoaViTri(int.Parse(txtViTriCanXoa.Text));
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdGiaTriCanThem.Checked)
            {
                mang.them(int.Parse(txtGiaTriCanThem.Text), int.Parse(txtViTriCanThem.Text));
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdGiaTriCanThayThr.Checked)
            {
                mang.thayTheGiaTri(int.Parse(txtGiaTriCanThayThr.Text), int.Parse(txtSoThayThe.Text));
                txtKetQuaMang.Text = mang.xuat();
            }
            if (rdViTriCanThayThe.Checked)
            {
                mang.thayTheViTri(int.Parse(txtViTriCanThayThe.Text), int.Parse(txtSoThayThe.Text));
                txtKetQuaMang.Text = mang.xuat();
            }
            rdViTriCanTim.Checked = false;
            rdGiaTriCanTim.Checked = false;
            rdGiatricanxoa.Checked = false;
            rdViTriCanXoa.Checked = false;
            rdGiaTriCanThem.Checked = false;
            rdGiaTriCanThayThr.Checked = false;
            rdViTriCanThayThe.Checked = false;
        }

        private void btnTim_Click(object sender, System.EventArgs e)
        {
            txtMax.Text = mang.max();
            txtMin.Text = mang.min();
        }

        private void btnTong_Click(object sender, System.EventArgs e)
        {
            txtTongChan.Text = mang.tongChan();
            txtTongLe.Text = mang.tongLe();
            txtTongMang.Text = mang.tong();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat ?", "EXIT", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtNhapMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }
    }
}
