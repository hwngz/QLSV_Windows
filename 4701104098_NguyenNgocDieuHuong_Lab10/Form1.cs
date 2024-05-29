using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4701104098_NguyenNgocDieuHuong_Lab10
{

    public partial class FrmBTM : Form
    {
        private SqlConnection conn = new SqlConnection (@"Data Source=DESKTOP-J30HRO0\MSSQLSERVER01;Integrated Security=True");
        private DataSet ds_QLSV = new DataSet ();
        private DataAdapter da_DSSV;
        public FrmBTM()
        {
            InitializeComponent();

        }
        //Phương thức load dữ liệu cho Datagridview
       
        void LoadDuLieuKhoa()
        {

            string strsel = "SELECT * FROM DSSV";
            da_DSSV = new SqlDataAdapter(strsel, conn);
            //da_DSSV.Fill(ds_QLSV, "DSSV");
            dataGridView1.DataSource = ds_QLSV.Tables["DSSV"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["DSSV"].Columns[0];
            ds_QLSV.Tables["DSSV"].PrimaryKey = key;
        }

        // sự kiện Load của form
        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            LoadDuLieuKhoa();
            //Tất cả textbox bị vô hiệu hóa
            txtMaKhoa.Enabled = txt_tenkhoa.Enabled = false;
            //Các button Sửa, xóa, Lưu bị vô hiệu hóa
            btn_sua.Enabled = btn_xoa.Enabled = btn_luu.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // các textbox có hiệu lực
            txtMaKhoa.Enabled = txt_tenkhoa.Enabled = true;
            // button lưu có hiệu lực
            btn_luu.Enabled = true;
            // dấu nháy xuất hiện ở txtmakhoa
            txt_tenkhoa.Focus();
            // xóa dữ liệu hiện tại trên các textbox
            txtMaKhoa.Clear();
            txt_tenkhoa.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // button xóa và sửa có hiệu lực
            
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btn_sua.Enabled = btn_xoa.Enabled = true;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            // các textbox có hiệu lực trừ mã khoa
            txt_tenkhoa.Enabled = true;
            txtMaKhoa.Enabled = false;
        }

        //Sự kiện click của button Lưu
        private void btn_luu_Click(object sender, EventArgs e)
        {

            //Kiểm tra thông tin vừa nhập hoặc sửa cho phù hợp
            if (txtMaKhoa.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Mã Khoa");
                txtMaKhoa.Focus();
                return;
            }
            if (txt_tenkhoa.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Tên Khoa");
                txt_tenkhoa.Focus();
                return;
            }
            if (txtMaKhoa.Enabled == true) // Thêm
            {
                DataRow insert_New = ds_QLSV.Tables["Khoa"].NewRow();
                insert_New["MaKhoa"] = txtMaKhoa.Text;
                insert_New["TenKhoa"] = txt_tenkhoa.Text;
                ds_QLSV.Tables["Khoa"].Rows.Add(insert_New);
            }
            else // Sửa
            {
                DataRow update_New = ds_QLSV.Tables["Khoa"].Rows.Find (txtMaKhoa.Text);
                if (update_New != null)
                {
                    update_New["TenKhoa"] = txt_tenkhoa.Text;
                }
            }
            //SqlCommandBuilder cmb = new SqlCommandBuilder(da_Khoa);
            //da_Khoa.Update(ds_QLSV, "Khoa");
            MessageBox.Show("Thành công");
            btn_luu.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //nếu đồng ý xóa
                DataTable dt_lop = new DataTable();
                // kiểm tra khóa ngoại trong bảng lớp
                SqlDataAdapter da_lop = new SqlDataAdapter("select * from Lop where makhoa = ‘" + txtMaKhoa.Text + "’", conn);
                da_lop.Fill(dt_lop);
                if (dt_lop.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    return;
                }
                // Nếu cập nhật dữ liệu
                DataRow update_New = ds_QLSV.Tables["Khoa"].Rows.Find(txtMaKhoa.Text);
                if (update_New != null)
                {
                    update_New.Delete();
                }
                //SqlCommandBuilder cmb = new SqlCommandBuilder(da_Khoa);
                //da_Khoa.Update(ds_QLSV, "Khoa");
                MessageBox.Show("Thành công");
            }
        }
    }
}    