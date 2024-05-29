namespace bài1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDichvu = new System.Windows.Forms.GroupBox();
            this.cbAnsang = new System.Windows.Forms.CheckBox();
            this.cbKaraoke = new System.Windows.Forms.CheckBox();
            this.grbTiennghi = new System.Windows.Forms.GroupBox();
            this.cbMaynuocnong = new System.Windows.Forms.CheckBox();
            this.cbTivi = new System.Windows.Forms.CheckBox();
            this.cbInternet = new System.Windows.Forms.CheckBox();
            this.grbLoaiPhong = new System.Windows.Forms.GroupBox();
            this.rdoPhongba = new System.Windows.Forms.RadioButton();
            this.rdoPhongdoi = new System.Windows.Forms.RadioButton();
            this.rdoPhongdon = new System.Windows.Forms.RadioButton();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbTongket = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtSoluotnguoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNhapmoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongket = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grbDichvu.SuspendLayout();
            this.grbTiennghi.SuspendLayout();
            this.grbLoaiPhong.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbTongket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL THANH THANH - TRẢ PHÒNG";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grbDichvu);
            this.panel1.Controls.Add(this.grbTiennghi);
            this.panel1.Controls.Add(this.grbLoaiPhong);
            this.panel1.Controls.Add(this.txtSoNgayO);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHoVaTen);
            this.panel1.Location = new System.Drawing.Point(-4, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 376);
            this.panel1.TabIndex = 0;
            // 
            // grbDichvu
            // 
            this.grbDichvu.Controls.Add(this.cbAnsang);
            this.grbDichvu.Controls.Add(this.cbKaraoke);
            this.grbDichvu.Location = new System.Drawing.Point(320, 212);
            this.grbDichvu.Name = "grbDichvu";
            this.grbDichvu.Size = new System.Drawing.Size(129, 149);
            this.grbDichvu.TabIndex = 0;
            this.grbDichvu.TabStop = false;
            this.grbDichvu.Text = "Dịch vụ";
            // 
            // cbAnsang
            // 
            this.cbAnsang.AutoSize = true;
            this.cbAnsang.Location = new System.Drawing.Point(6, 95);
            this.cbAnsang.Name = "cbAnsang";
            this.cbAnsang.Size = new System.Drawing.Size(65, 17);
            this.cbAnsang.TabIndex = 1;
            this.cbAnsang.Text = "Ăn sáng";
            this.cbAnsang.UseVisualStyleBackColor = true;
            // 
            // cbKaraoke
            // 
            this.cbKaraoke.AutoSize = true;
            this.cbKaraoke.Location = new System.Drawing.Point(6, 54);
            this.cbKaraoke.Name = "cbKaraoke";
            this.cbKaraoke.Size = new System.Drawing.Size(66, 17);
            this.cbKaraoke.TabIndex = 0;
            this.cbKaraoke.Text = "Karaoke";
            this.cbKaraoke.UseVisualStyleBackColor = true;
            // 
            // grbTiennghi
            // 
            this.grbTiennghi.Controls.Add(this.cbMaynuocnong);
            this.grbTiennghi.Controls.Add(this.cbTivi);
            this.grbTiennghi.Controls.Add(this.cbInternet);
            this.grbTiennghi.Location = new System.Drawing.Point(169, 212);
            this.grbTiennghi.Name = "grbTiennghi";
            this.grbTiennghi.Size = new System.Drawing.Size(129, 149);
            this.grbTiennghi.TabIndex = 0;
            this.grbTiennghi.TabStop = false;
            this.grbTiennghi.Text = "Tiện nghi";
            // 
            // cbMaynuocnong
            // 
            this.cbMaynuocnong.AutoSize = true;
            this.cbMaynuocnong.Location = new System.Drawing.Point(6, 112);
            this.cbMaynuocnong.Name = "cbMaynuocnong";
            this.cbMaynuocnong.Size = new System.Drawing.Size(100, 17);
            this.cbMaynuocnong.TabIndex = 2;
            this.cbMaynuocnong.Text = "Máy nước nóng";
            this.cbMaynuocnong.UseVisualStyleBackColor = true;
            // 
            // cbTivi
            // 
            this.cbTivi.AutoSize = true;
            this.cbTivi.Location = new System.Drawing.Point(6, 36);
            this.cbTivi.Name = "cbTivi";
            this.cbTivi.Size = new System.Drawing.Size(43, 17);
            this.cbTivi.TabIndex = 0;
            this.cbTivi.Text = "Tivi";
            this.cbTivi.UseVisualStyleBackColor = true;
            // 
            // cbInternet
            // 
            this.cbInternet.AutoSize = true;
            this.cbInternet.Location = new System.Drawing.Point(6, 75);
            this.cbInternet.Name = "cbInternet";
            this.cbInternet.Size = new System.Drawing.Size(62, 17);
            this.cbInternet.TabIndex = 1;
            this.cbInternet.Text = "Internet";
            this.cbInternet.UseVisualStyleBackColor = true;
            // 
            // grbLoaiPhong
            // 
            this.grbLoaiPhong.Controls.Add(this.rdoPhongba);
            this.grbLoaiPhong.Controls.Add(this.rdoPhongdoi);
            this.grbLoaiPhong.Controls.Add(this.rdoPhongdon);
            this.grbLoaiPhong.Location = new System.Drawing.Point(23, 212);
            this.grbLoaiPhong.Name = "grbLoaiPhong";
            this.grbLoaiPhong.Size = new System.Drawing.Size(129, 149);
            this.grbLoaiPhong.TabIndex = 0;
            this.grbLoaiPhong.TabStop = false;
            this.grbLoaiPhong.Text = "Loại phòng";
            // 
            // rdoPhongba
            // 
            this.rdoPhongba.AutoSize = true;
            this.rdoPhongba.Location = new System.Drawing.Point(6, 112);
            this.rdoPhongba.Name = "rdoPhongba";
            this.rdoPhongba.Size = new System.Drawing.Size(74, 17);
            this.rdoPhongba.TabIndex = 2;
            this.rdoPhongba.TabStop = true;
            this.rdoPhongba.Text = "Phòng bar";
            this.rdoPhongba.UseVisualStyleBackColor = true;
            this.rdoPhongba.CheckedChanged += new System.EventHandler(this.rdoPhongba_CheckedChanged);
            // 
            // rdoPhongdoi
            // 
            this.rdoPhongdoi.AutoSize = true;
            this.rdoPhongdoi.Location = new System.Drawing.Point(6, 74);
            this.rdoPhongdoi.Name = "rdoPhongdoi";
            this.rdoPhongdoi.Size = new System.Drawing.Size(74, 17);
            this.rdoPhongdoi.TabIndex = 1;
            this.rdoPhongdoi.TabStop = true;
            this.rdoPhongdoi.Text = "Phòng đôi";
            this.rdoPhongdoi.UseVisualStyleBackColor = true;
            this.rdoPhongdoi.CheckedChanged += new System.EventHandler(this.rdoPhongdoi_CheckedChanged);
            // 
            // rdoPhongdon
            // 
            this.rdoPhongdon.AutoSize = true;
            this.rdoPhongdon.Location = new System.Drawing.Point(7, 35);
            this.rdoPhongdon.Name = "rdoPhongdon";
            this.rdoPhongdon.Size = new System.Drawing.Size(78, 17);
            this.rdoPhongdon.TabIndex = 0;
            this.rdoPhongdon.TabStop = true;
            this.rdoPhongdon.Text = "Phòng đơn";
            this.rdoPhongdon.UseVisualStyleBackColor = true;
            this.rdoPhongdon.CheckedChanged += new System.EventHandler(this.rdoPhongdon_CheckedChanged);
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(123, 142);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(100, 20);
            this.txtSoNgayO.TabIndex = 2;
            this.txtSoNgayO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoNgayO.TextChanged += new System.EventHandler(this.txtSoNgayO_TextChanged);
            this.txtSoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayO_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(123, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(346, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày ở:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(123, 44);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(197, 20);
            this.txtHoVaTen.TabIndex = 0;
            this.txtHoVaTen.TextChanged += new System.EventHandler(this.txtHoVaTen_TextChanged);
            this.txtHoVaTen.Leave += new System.EventHandler(this.txtHoVaTen_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grbTongket);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnNhapmoi);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnTongket);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Location = new System.Drawing.Point(488, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 380);
            this.panel2.TabIndex = 1;
            // 
            // grbTongket
            // 
            this.grbTongket.Controls.Add(this.label6);
            this.grbTongket.Controls.Add(this.label5);
            this.grbTongket.Controls.Add(this.txtTongtien);
            this.grbTongket.Controls.Add(this.txtSoluotnguoi);
            this.grbTongket.Location = new System.Drawing.Point(36, 145);
            this.grbTongket.Name = "grbTongket";
            this.grbTongket.Size = new System.Drawing.Size(263, 149);
            this.grbTongket.TabIndex = 3;
            this.grbTongket.TabStop = false;
            this.grbTongket.Text = "Thông tin tổng kết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượt người:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.BackColor = System.Drawing.Color.White;
            this.txtTongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongtien.Enabled = false;
            this.txtTongtien.ForeColor = System.Drawing.Color.Black;
            this.txtTongtien.Location = new System.Drawing.Point(99, 89);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(146, 20);
            this.txtTongtien.TabIndex = 2;
            // 
            // txtSoluotnguoi
            // 
            this.txtSoluotnguoi.BackColor = System.Drawing.Color.White;
            this.txtSoluotnguoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoluotnguoi.Enabled = false;
            this.txtSoluotnguoi.ForeColor = System.Drawing.Color.Black;
            this.txtSoluotnguoi.Location = new System.Drawing.Point(99, 47);
            this.txtSoluotnguoi.Name = "txtSoluotnguoi";
            this.txtSoluotnguoi.Size = new System.Drawing.Size(146, 20);
            this.txtSoluotnguoi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành tiền:";
            // 
            // btnNhapmoi
            // 
            this.btnNhapmoi.Location = new System.Drawing.Point(117, 24);
            this.btnNhapmoi.Name = "btnNhapmoi";
            this.btnNhapmoi.Size = new System.Drawing.Size(75, 23);
            this.btnNhapmoi.TabIndex = 1;
            this.btnNhapmoi.Text = "Nhập mới";
            this.btnNhapmoi.UseVisualStyleBackColor = true;
            this.btnNhapmoi.Click += new System.EventHandler(this.btnNhapmoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(36, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongket
            // 
            this.btnTongket.Location = new System.Drawing.Point(36, 116);
            this.btnTongket.Name = "btnTongket";
            this.btnTongket.Size = new System.Drawing.Size(75, 23);
            this.btnTongket.TabIndex = 2;
            this.btnTongket.Text = "Tổng kết";
            this.btnTongket.UseVisualStyleBackColor = true;
            this.btnTongket.Click += new System.EventHandler(this.btnTongket_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(36, 24);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhtoan.TabIndex = 0;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.ForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.Location = new System.Drawing.Point(84, 53);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(197, 20);
            this.txtThanhTien.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trả phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDichvu.ResumeLayout(false);
            this.grbDichvu.PerformLayout();
            this.grbTiennghi.ResumeLayout(false);
            this.grbTiennghi.PerformLayout();
            this.grbLoaiPhong.ResumeLayout(false);
            this.grbLoaiPhong.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbTongket.ResumeLayout(false);
            this.grbTongket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTongket;
        private System.Windows.Forms.GroupBox grbTiennghi;
        private System.Windows.Forms.GroupBox grbLoaiPhong;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhapmoi;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDichvu;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtSoluotnguoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbInternet;
        private System.Windows.Forms.RadioButton rdoPhongba;
        private System.Windows.Forms.RadioButton rdoPhongdoi;
        private System.Windows.Forms.RadioButton rdoPhongdon;
        private System.Windows.Forms.CheckBox cbMaynuocnong;
        private System.Windows.Forms.CheckBox cbTivi;
        private System.Windows.Forms.CheckBox cbAnsang;
        private System.Windows.Forms.CheckBox cbKaraoke;
        private System.Windows.Forms.Button btnTongket;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

