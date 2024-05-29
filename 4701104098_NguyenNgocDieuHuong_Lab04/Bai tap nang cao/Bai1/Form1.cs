using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int tienNuoc()
        {
            if (rdCafeden.Checked)
                return 20000;
            if (rdCafeda.Checked)
                return 25000;
            if (rdCafesua.Checked)
                return 25000;
            if (rdCafesuada.Checked)
                return 30000;
            if (rdCafekem.Checked)
                return 35000;
            return 0;
        }

        public int tienDoAn()
        {
            int sum = 0;
            if (cbBanhmytrung.Checked)
                sum += 15000;
            if (cbBanhmyca.Checked)
                sum += 15000;
            if (cbMytomtrung.Checked)
                sum += 20000;
            if (cbMyxaobo.Checked)
                sum += 30000;
            if (cbMycay.Checked)
                sum += 50000;
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btTinhtien.Enabled = false;
            btNhaplai.Enabled = false;
            btThanhtoan.Enabled = false;
        }

        private void tbTenkhach_Leave(object sender, EventArgs e)
        {
            if (tbTenkhach.Text.Trim().Length == 0)
            {
                //MessageBox.Show("Nhap ten khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //tbTenkhach.Focus();
                errorProvider1.SetError(tbTenkhach, "Vui long nhap ten khach hang !");
            }
            else
                errorProvider1.Clear();
        }

        private void tbSokhach_TextChanged(object sender, EventArgs e)
        {
            if (tbSokhach.Text.Length > 0 && !tbSokhach.Text.All(char.IsDigit))
            {
                MessageBox.Show("Chi duoc nhap so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSokhach.Text = tbSokhach.Text.Substring(0, tbSokhach.Text.Length - 1);
            }
        }

        private float tongThanhToan = 0;
        private int tongKhachHang = 0;

        private void btTinhtien_Click(object sender, EventArgs e)
        {
            tongKhachHang++;
            float tinhtien = tienDoAn() + tienNuoc();
            if (cbSinhVien.Checked) tinhtien -= tinhtien * (float)0.2;
            tongThanhToan += tinhtien;
            btNhaplai.Enabled = true;
            btThanhtoan.Enabled = true;
            MessageBox.Show("Tien phai tra: " + tinhtien.ToString() + "VND", "Tinh tien", MessageBoxButtons.OK);
            btTinhtien.Enabled = false;
        }

        private void btNhaplai_Click(object sender, EventArgs e)
        {
            tbTenkhach.Clear();
            tbTenkhach.Focus();
            if (cbSinhVien.Checked) cbSinhVien.Checked = false;
            rdCafeda.Checked = false;
            rdCafeden.Checked = false;
            rdCafekem.Checked = false;
            rdCafesua.Checked = false;
            rdCafesuada.Checked = false;
            cbBanhmyca.Checked = false;
            cbBanhmytrung.Checked = false;
            cbMycay.Checked = false;
            cbMytomtrung.Checked = false;
            cbMyxaobo.Checked = false;
            btThanhtoan.Enabled = false;
            btNhaplai.Enabled = false;
            btTinhtien.Enabled = false;
            tbTongkhach.Clear();
            tbTongtien.Clear();
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            tbTongkhach.Text = tongKhachHang.ToString();
            tbTongtien.Text = tongThanhToan.ToString() + "VND";
            tongKhachHang = 0;
            tongThanhToan = 0;
            btThanhtoan.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdCafeden_CheckedChanged(object sender, EventArgs e)
        {
            if (tbTenkhach.Text.Trim().Length > 0)
                btTinhtien.Enabled = true;
        }

        private void tbTenkhach_TextChanged(object sender, EventArgs e)
        {
            if (rdCafeda.Checked) btTinhtien.Enabled = true;
            if (rdCafeden.Checked) btTinhtien.Enabled = true;
            if (rdCafesua.Checked) btTinhtien.Enabled = true;
            if (rdCafekem.Checked) btTinhtien.Enabled = true;
            if (rdCafesuada.Checked) btTinhtien.Enabled = true;
            if (cbBanhmyca.Checked) btTinhtien.Enabled = true;
            if (cbBanhmytrung.Checked) btTinhtien.Enabled = true;
            if (cbMyxaobo.Checked) btTinhtien.Enabled = true;
            if (cbMycay.Checked) btTinhtien.Enabled = true;
            if (cbMytomtrung.Checked) btTinhtien.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void FoodDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (tbTenkhach.Text.Trim().Length > 0)
                btTinhtien.Enabled = true;
        }
    }
}