namespace bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKetQuaMang = new System.Windows.Forms.TextBox();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSapXep = new System.Windows.Forms.GroupBox();
            this.rdSXGiam = new System.Windows.Forms.RadioButton();
            this.rdSXTang = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.rdViTriCanTim = new System.Windows.Forms.RadioButton();
            this.rdGiaTriCanTim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTimDuoc = new System.Windows.Forms.TextBox();
            this.txtViTriCanTim = new System.Windows.Forms.TextBox();
            this.txtGiaTriCanTim = new System.Windows.Forms.TextBox();
            this.grbXoa = new System.Windows.Forms.GroupBox();
            this.rdViTriCanXoa = new System.Windows.Forms.RadioButton();
            this.rdGiatricanxoa = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtViTriCanXoa = new System.Windows.Forms.TextBox();
            this.txtGiaTriCanXoa = new System.Windows.Forms.TextBox();
            this.grbThem = new System.Windows.Forms.GroupBox();
            this.rdGiaTriCanThem = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiaTriCanThem = new System.Windows.Forms.TextBox();
            this.txtViTriCanThem = new System.Windows.Forms.TextBox();
            this.grbTong = new System.Windows.Forms.GroupBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.grbMaxMin = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grbThayThe = new System.Windows.Forms.GroupBox();
            this.rdViTriCanThayThe = new System.Windows.Forms.RadioButton();
            this.rdGiaTriCanThayThr = new System.Windows.Forms.RadioButton();
            this.txtGiaTriCanThayThr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtViTriCanThayThe = new System.Windows.Forms.TextBox();
            this.txtSoThayThe = new System.Windows.Forms.TextBox();
            this.grbSapXep.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbXoa.SuspendLayout();
            this.grbThem.SuspendLayout();
            this.grbTong.SuspendLayout();
            this.grbMaxMin.SuspendLayout();
            this.grbThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng số nguyên";
            // 
            // txtKetQuaMang
            // 
            this.txtKetQuaMang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetQuaMang.Enabled = false;
            this.txtKetQuaMang.Location = new System.Drawing.Point(111, 83);
            this.txtKetQuaMang.Name = "txtKetQuaMang";
            this.txtKetQuaMang.Size = new System.Drawing.Size(224, 20);
            this.txtKetQuaMang.TabIndex = 1;
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(111, 55);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(224, 20);
            this.txtNhapMang.TabIndex = 1;
            this.txtNhapMang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapMang_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(341, 55);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(23, 128);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 49);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(23, 53);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(75, 23);
            this.btnNhapMang.TabIndex = 2;
            this.btnNhapMang.Text = "Nhập mảng:";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new System.EventHandler(this.btnNhapMang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả mảng:";
            // 
            // grbSapXep
            // 
            this.grbSapXep.Controls.Add(this.rdSXGiam);
            this.grbSapXep.Controls.Add(this.rdSXTang);
            this.grbSapXep.Location = new System.Drawing.Point(111, 128);
            this.grbSapXep.Name = "grbSapXep";
            this.grbSapXep.Size = new System.Drawing.Size(305, 49);
            this.grbSapXep.TabIndex = 3;
            this.grbSapXep.TabStop = false;
            this.grbSapXep.Text = "Sắp Xếp";
            // 
            // rdSXGiam
            // 
            this.rdSXGiam.AutoSize = true;
            this.rdSXGiam.Location = new System.Drawing.Point(139, 19);
            this.rdSXGiam.Name = "rdSXGiam";
            this.rdSXGiam.Size = new System.Drawing.Size(89, 17);
            this.rdSXGiam.TabIndex = 4;
            this.rdSXGiam.TabStop = true;
            this.rdSXGiam.Text = "Sắp xếp giảm";
            this.rdSXGiam.UseVisualStyleBackColor = true;
            // 
            // rdSXTang
            // 
            this.rdSXTang.AutoSize = true;
            this.rdSXTang.Location = new System.Drawing.Point(6, 19);
            this.rdSXTang.Name = "rdSXTang";
            this.rdSXTang.Size = new System.Drawing.Size(88, 17);
            this.rdSXTang.TabIndex = 4;
            this.rdSXTang.TabStop = true;
            this.rdSXTang.Text = "Sắp xếp tăng";
            this.rdSXTang.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(341, 83);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.rdViTriCanTim);
            this.grbTimKiem.Controls.Add(this.rdGiaTriCanTim);
            this.grbTimKiem.Controls.Add(this.label3);
            this.grbTimKiem.Controls.Add(this.txtSoTimDuoc);
            this.grbTimKiem.Controls.Add(this.txtViTriCanTim);
            this.grbTimKiem.Controls.Add(this.txtGiaTriCanTim);
            this.grbTimKiem.Location = new System.Drawing.Point(23, 183);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(194, 100);
            this.grbTimKiem.TabIndex = 3;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm";
            // 
            // rdViTriCanTim
            // 
            this.rdViTriCanTim.AutoSize = true;
            this.rdViTriCanTim.Location = new System.Drawing.Point(6, 42);
            this.rdViTriCanTim.Name = "rdViTriCanTim";
            this.rdViTriCanTim.Size = new System.Drawing.Size(84, 17);
            this.rdViTriCanTim.TabIndex = 4;
            this.rdViTriCanTim.TabStop = true;
            this.rdViTriCanTim.Text = "Vị trí cần tìm";
            this.rdViTriCanTim.UseVisualStyleBackColor = true;
            // 
            // rdGiaTriCanTim
            // 
            this.rdGiaTriCanTim.AutoSize = true;
            this.rdGiaTriCanTim.Location = new System.Drawing.Point(6, 19);
            this.rdGiaTriCanTim.Name = "rdGiaTriCanTim";
            this.rdGiaTriCanTim.Size = new System.Drawing.Size(107, 17);
            this.rdGiaTriCanTim.TabIndex = 4;
            this.rdGiaTriCanTim.TabStop = true;
            this.rdGiaTriCanTim.Text = "Tìm giá trị cần tìm";
            this.rdGiaTriCanTim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tìm được là:";
            // 
            // txtSoTimDuoc
            // 
            this.txtSoTimDuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTimDuoc.Enabled = false;
            this.txtSoTimDuoc.Location = new System.Drawing.Point(142, 67);
            this.txtSoTimDuoc.Name = "txtSoTimDuoc";
            this.txtSoTimDuoc.Size = new System.Drawing.Size(46, 20);
            this.txtSoTimDuoc.TabIndex = 1;
            // 
            // txtViTriCanTim
            // 
            this.txtViTriCanTim.Location = new System.Drawing.Point(142, 41);
            this.txtViTriCanTim.Name = "txtViTriCanTim";
            this.txtViTriCanTim.Size = new System.Drawing.Size(46, 20);
            this.txtViTriCanTim.TabIndex = 1;
            // 
            // txtGiaTriCanTim
            // 
            this.txtGiaTriCanTim.Location = new System.Drawing.Point(142, 19);
            this.txtGiaTriCanTim.Name = "txtGiaTriCanTim";
            this.txtGiaTriCanTim.Size = new System.Drawing.Size(46, 20);
            this.txtGiaTriCanTim.TabIndex = 1;
            // 
            // grbXoa
            // 
            this.grbXoa.Controls.Add(this.rdViTriCanXoa);
            this.grbXoa.Controls.Add(this.rdGiatricanxoa);
            this.grbXoa.Controls.Add(this.label11);
            this.grbXoa.Controls.Add(this.txtViTriCanXoa);
            this.grbXoa.Controls.Add(this.txtGiaTriCanXoa);
            this.grbXoa.Location = new System.Drawing.Point(223, 183);
            this.grbXoa.Name = "grbXoa";
            this.grbXoa.Size = new System.Drawing.Size(193, 100);
            this.grbXoa.TabIndex = 3;
            this.grbXoa.TabStop = false;
            this.grbXoa.Text = "Xóa";
            // 
            // rdViTriCanXoa
            // 
            this.rdViTriCanXoa.AutoSize = true;
            this.rdViTriCanXoa.Location = new System.Drawing.Point(6, 42);
            this.rdViTriCanXoa.Name = "rdViTriCanXoa";
            this.rdViTriCanXoa.Size = new System.Drawing.Size(107, 17);
            this.rdViTriCanXoa.TabIndex = 4;
            this.rdViTriCanXoa.TabStop = true;
            this.rdViTriCanXoa.Text = "Tìm vị trí cần xóa";
            this.rdViTriCanXoa.UseVisualStyleBackColor = true;
            // 
            // rdGiatricanxoa
            // 
            this.rdGiatricanxoa.AutoSize = true;
            this.rdGiatricanxoa.Location = new System.Drawing.Point(6, 19);
            this.rdGiatricanxoa.Name = "rdGiatricanxoa";
            this.rdGiatricanxoa.Size = new System.Drawing.Size(111, 17);
            this.rdGiatricanxoa.TabIndex = 4;
            this.rdGiatricanxoa.TabStop = true;
            this.rdGiatricanxoa.Text = "Tìm giá trị cần xóa";
            this.rdGiatricanxoa.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(37, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cần sắp xếp tăng";
            // 
            // txtViTriCanXoa
            // 
            this.txtViTriCanXoa.Location = new System.Drawing.Point(141, 41);
            this.txtViTriCanXoa.Name = "txtViTriCanXoa";
            this.txtViTriCanXoa.Size = new System.Drawing.Size(46, 20);
            this.txtViTriCanXoa.TabIndex = 1;
            // 
            // txtGiaTriCanXoa
            // 
            this.txtGiaTriCanXoa.Location = new System.Drawing.Point(141, 19);
            this.txtGiaTriCanXoa.Name = "txtGiaTriCanXoa";
            this.txtGiaTriCanXoa.Size = new System.Drawing.Size(46, 20);
            this.txtGiaTriCanXoa.TabIndex = 1;
            // 
            // grbThem
            // 
            this.grbThem.Controls.Add(this.rdGiaTriCanThem);
            this.grbThem.Controls.Add(this.label4);
            this.grbThem.Controls.Add(this.label12);
            this.grbThem.Controls.Add(this.txtGiaTriCanThem);
            this.grbThem.Controls.Add(this.txtViTriCanThem);
            this.grbThem.Location = new System.Drawing.Point(23, 289);
            this.grbThem.Name = "grbThem";
            this.grbThem.Size = new System.Drawing.Size(194, 100);
            this.grbThem.TabIndex = 3;
            this.grbThem.TabStop = false;
            this.grbThem.Text = "Thêm";
            // 
            // rdGiaTriCanThem
            // 
            this.rdGiaTriCanThem.AutoSize = true;
            this.rdGiaTriCanThem.Location = new System.Drawing.Point(6, 19);
            this.rdGiaTriCanThem.Name = "rdGiaTriCanThem";
            this.rdGiaTriCanThem.Size = new System.Drawing.Size(117, 17);
            this.rdGiaTriCanThem.TabIndex = 4;
            this.rdGiaTriCanThem.TabStop = true;
            this.rdGiaTriCanThem.Text = "Tìm giá trị cần thêm";
            this.rdGiaTriCanThem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tại vị trí cần thêm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(37, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cần sắp xếp tăng";
            // 
            // txtGiaTriCanThem
            // 
            this.txtGiaTriCanThem.Location = new System.Drawing.Point(142, 19);
            this.txtGiaTriCanThem.Name = "txtGiaTriCanThem";
            this.txtGiaTriCanThem.Size = new System.Drawing.Size(46, 20);
            this.txtGiaTriCanThem.TabIndex = 1;
            // 
            // txtViTriCanThem
            // 
            this.txtViTriCanThem.Location = new System.Drawing.Point(142, 45);
            this.txtViTriCanThem.Name = "txtViTriCanThem";
            this.txtViTriCanThem.Size = new System.Drawing.Size(46, 20);
            this.txtViTriCanThem.TabIndex = 1;
            // 
            // grbTong
            // 
            this.grbTong.Controls.Add(this.txtTongLe);
            this.grbTong.Controls.Add(this.label7);
            this.grbTong.Controls.Add(this.txtTongChan);
            this.grbTong.Controls.Add(this.label6);
            this.grbTong.Controls.Add(this.txtTongMang);
            this.grbTong.Controls.Add(this.label5);
            this.grbTong.Controls.Add(this.btnTong);
            this.grbTong.Location = new System.Drawing.Point(223, 289);
            this.grbTong.Name = "grbTong";
            this.grbTong.Size = new System.Drawing.Size(193, 100);
            this.grbTong.TabIndex = 3;
            this.grbTong.TabStop = false;
            this.grbTong.Text = "tỔNG";
            // 
            // txtTongLe
            // 
            this.txtTongLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongLe.Enabled = false;
            this.txtTongLe.Location = new System.Drawing.Point(80, 67);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(52, 20);
            this.txtTongLe.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng lẻ";
            // 
            // txtTongChan
            // 
            this.txtTongChan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongChan.Enabled = false;
            this.txtTongChan.Location = new System.Drawing.Point(80, 41);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(52, 20);
            this.txtTongChan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng chẵn";
            // 
            // txtTongMang
            // 
            this.txtTongMang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongMang.Enabled = false;
            this.txtTongMang.Location = new System.Drawing.Point(80, 19);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(52, 20);
            this.txtTongMang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng mảng";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(141, 19);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(46, 68);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // grbMaxMin
            // 
            this.grbMaxMin.Controls.Add(this.label9);
            this.grbMaxMin.Controls.Add(this.txtMin);
            this.grbMaxMin.Controls.Add(this.label8);
            this.grbMaxMin.Controls.Add(this.txtMax);
            this.grbMaxMin.Controls.Add(this.btnTim);
            this.grbMaxMin.Location = new System.Drawing.Point(23, 395);
            this.grbMaxMin.Name = "grbMaxMin";
            this.grbMaxMin.Size = new System.Drawing.Size(194, 100);
            this.grbMaxMin.TabIndex = 3;
            this.grbMaxMin.TabStop = false;
            this.grbMaxMin.Text = "Max-Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá trị nhỏ nhất";
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMin.Enabled = false;
            this.txtMin.Location = new System.Drawing.Point(98, 57);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(34, 20);
            this.txtMin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá trị lớn nhất";
            // 
            // txtMax
            // 
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMax.Enabled = false;
            this.txtMax.Location = new System.Drawing.Point(98, 27);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(34, 20);
            this.txtMax.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(142, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(46, 68);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grbThayThe
            // 
            this.grbThayThe.Controls.Add(this.rdViTriCanThayThe);
            this.grbThayThe.Controls.Add(this.rdGiaTriCanThayThr);
            this.grbThayThe.Controls.Add(this.txtGiaTriCanThayThr);
            this.grbThayThe.Controls.Add(this.label10);
            this.grbThayThe.Controls.Add(this.txtViTriCanThayThe);
            this.grbThayThe.Controls.Add(this.txtSoThayThe);
            this.grbThayThe.Location = new System.Drawing.Point(223, 395);
            this.grbThayThe.Name = "grbThayThe";
            this.grbThayThe.Size = new System.Drawing.Size(193, 100);
            this.grbThayThe.TabIndex = 3;
            this.grbThayThe.TabStop = false;
            this.grbThayThe.Text = "Thay Thế";
            // 
            // rdViTriCanThayThe
            // 
            this.rdViTriCanThayThe.AutoSize = true;
            this.rdViTriCanThayThe.Location = new System.Drawing.Point(6, 42);
            this.rdViTriCanThayThe.Name = "rdViTriCanThayThe";
            this.rdViTriCanThayThe.Size = new System.Drawing.Size(109, 17);
            this.rdViTriCanThayThe.TabIndex = 4;
            this.rdViTriCanThayThe.TabStop = true;
            this.rdViTriCanThayThe.Text = "Vị trí cần thay thế";
            this.rdViTriCanThayThe.UseVisualStyleBackColor = true;
            // 
            // rdGiaTriCanThayThr
            // 
            this.rdGiaTriCanThayThr.AutoSize = true;
            this.rdGiaTriCanThayThr.Location = new System.Drawing.Point(6, 19);
            this.rdGiaTriCanThayThr.Name = "rdGiaTriCanThayThr";
            this.rdGiaTriCanThayThr.Size = new System.Drawing.Size(114, 17);
            this.rdGiaTriCanThayThr.TabIndex = 4;
            this.rdGiaTriCanThayThr.TabStop = true;
            this.rdGiaTriCanThayThr.Text = "Giá trị cần thay thế";
            this.rdGiaTriCanThayThr.UseVisualStyleBackColor = true;
            // 
            // txtGiaTriCanThayThr
            // 
            this.txtGiaTriCanThayThr.Location = new System.Drawing.Point(142, 19);
            this.txtGiaTriCanThayThr.Name = "txtGiaTriCanThayThr";
            this.txtGiaTriCanThayThr.Size = new System.Drawing.Size(46, 20);
            this.txtGiaTriCanThayThr.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số thay thế là:";
            // 
            // txtViTriCanThayThe
            // 
            this.txtViTriCanThayThe.Location = new System.Drawing.Point(142, 41);
            this.txtViTriCanThayThe.Name = "txtViTriCanThayThe";
            this.txtViTriCanThayThe.Size = new System.Drawing.Size(46, 20);
            this.txtViTriCanThayThe.TabIndex = 1;
            // 
            // txtSoThayThe
            // 
            this.txtSoThayThe.Location = new System.Drawing.Point(142, 67);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new System.Drawing.Size(46, 20);
            this.txtSoThayThe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(445, 511);
            this.Controls.Add(this.grbThayThe);
            this.Controls.Add(this.grbTong);
            this.Controls.Add(this.grbXoa);
            this.Controls.Add(this.grbMaxMin);
            this.Controls.Add(this.grbThem);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbSapXep);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnNhapMang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.txtKetQuaMang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mảng số nguyên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grbSapXep.ResumeLayout(false);
            this.grbSapXep.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbXoa.ResumeLayout(false);
            this.grbXoa.PerformLayout();
            this.grbThem.ResumeLayout(false);
            this.grbThem.PerformLayout();
            this.grbTong.ResumeLayout(false);
            this.grbTong.PerformLayout();
            this.grbMaxMin.ResumeLayout(false);
            this.grbMaxMin.PerformLayout();
            this.grbThayThe.ResumeLayout(false);
            this.grbThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKetQuaMang;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnNhapMang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbSapXep;
        private System.Windows.Forms.RadioButton rdSXGiam;
        private System.Windows.Forms.RadioButton rdSXTang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.RadioButton rdViTriCanTim;
        private System.Windows.Forms.RadioButton rdGiaTriCanTim;
        private System.Windows.Forms.GroupBox grbXoa;
        private System.Windows.Forms.RadioButton rdViTriCanXoa;
        private System.Windows.Forms.RadioButton rdGiatricanxoa;
        private System.Windows.Forms.GroupBox grbThem;
        private System.Windows.Forms.GroupBox grbTong;
        private System.Windows.Forms.GroupBox grbMaxMin;
        private System.Windows.Forms.GroupBox grbThayThe;
        private System.Windows.Forms.RadioButton rdGiaTriCanThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTimDuoc;
        private System.Windows.Forms.TextBox txtViTriCanTim;
        private System.Windows.Forms.TextBox txtGiaTriCanTim;
        private System.Windows.Forms.TextBox txtViTriCanXoa;
        private System.Windows.Forms.TextBox txtGiaTriCanXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtViTriCanThem;
        private System.Windows.Forms.TextBox txtGiaTriCanThem;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rdViTriCanThayThe;
        private System.Windows.Forms.RadioButton rdGiaTriCanThayThr;
        private System.Windows.Forms.TextBox txtGiaTriCanThayThr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtViTriCanThayThe;
        private System.Windows.Forms.TextBox txtSoThayThe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

