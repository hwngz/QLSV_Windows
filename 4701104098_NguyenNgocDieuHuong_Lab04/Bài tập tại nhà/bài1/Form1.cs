using System;
using System.Windows.Forms;

namespace bài1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int tienPhong()
        {
            if (rdoPhongdon.Checked) return 300000;
            if (rdoPhongdoi.Checked) return 350000;
            if (rdoPhongba.Checked) return 400000;
            return 0;
        }

        public int tienDichvu()
        {
            int sum = 0;
            if (cbAnsang.Checked) sum += 15000;
            if (cbTivi.Checked) sum += 10000;
            if (cbInternet.Checked) sum += 10000;
            if (cbMaynuocnong.Checked) sum += 10000;
            if (cbKaraoke.Checked) sum += 50000;
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoVaTen.Focus();
            btnNhapmoi.Enabled = false;
            btnThanhtoan.Enabled = false;
            btnTongket.Enabled = false;
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoVaTen, "Vui long nhap ten khach hang!");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (rdoPhongdon.Checked || rdoPhongdoi.Checked || rdoPhongba.Checked && txtSoNgayO.Text.Trim() != "")
                btnThanhtoan.Enabled = true;
        }

        private void rdoPhongdon_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Trim() != "" && txtSoNgayO.Text.Trim() != "")
            {
                btnThanhtoan.Enabled = true;
            }
        }

        private void rdoPhongdoi_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Trim() != "" && txtSoNgayO.Text.Trim() != "")
            {
                btnThanhtoan.Enabled = true;
            }
        }

        private void rdoPhongba_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Trim() != "" && txtSoNgayO.Text.Trim() != "")
            {
                btnThanhtoan.Enabled = true;
            }
        }

        int soKhach = 0;
        int tongTien = 0;
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int tien = tienPhong() * Convert.ToInt32(txtSoNgayO.Text) + tienDichvu();
            txtThanhTien.Text = tien.ToString() + " VND";
            btnThanhtoan.Enabled = false;
            btnNhapmoi.Enabled = true;
            btnTongket.Enabled = true;
            soKhach++;
            tongTien += tien;
        }

        private void btnNhapmoi_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();
            txtThanhTien.Clear();
            txtTongtien.Clear();
            txtSoluotnguoi.Clear();
            rdoPhongba.Checked = false;
            rdoPhongdoi.Checked = false;
            rdoPhongdon.Checked = false;
            cbTivi.Checked = false;
            cbMaynuocnong.Checked = false;
            cbKaraoke.Checked = false;
            cbInternet.Checked = false;
            cbAnsang.Checked = false;
            btnThanhtoan.Enabled = false;
            btnNhapmoi.Enabled = false;
            btnTongket.Enabled = false;
        }

        private void btnTongket_Click(object sender, EventArgs e)
        {
            txtSoluotnguoi.Text = soKhach.ToString();
            txtTongtien.Text = tongTien.ToString() + " VND";
            soKhach = 0; tongTien = 0;
            btnTongket.Enabled = false;

        }

        private void txtSoNgayO_TextChanged(object sender, EventArgs e)
        {
            if (txtSoNgayO.Text.Trim().Length > 0 && txtHoVaTen.Text.Trim().Length > 0
                && rdoPhongdon.Checked || rdoPhongdoi.Checked || rdoPhongba.Checked)
            {
                btnThanhtoan.Enabled = true;
            }
        }

        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat chuong trinh ?", "exit", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
