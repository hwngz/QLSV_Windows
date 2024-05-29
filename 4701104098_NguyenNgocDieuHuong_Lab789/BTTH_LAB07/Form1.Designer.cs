namespace BTTH_LAB07
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
            this.lbl_chonkhoa = new System.Windows.Forms.Label();
            this.lbl_chonlop = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_ngsinh = new System.Windows.Forms.Label();
            this.lbl_diem = new System.Windows.Forms.Label();
            this.cbo_chonkhoa = new System.Windows.Forms.ComboBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.cbo_chonlop = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_mssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ngsinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_MaMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_tenMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtxt_Ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.gbo_ttsv = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.gbo_ttsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_chonkhoa
            // 
            this.lbl_chonkhoa.AutoSize = true;
            this.lbl_chonkhoa.Location = new System.Drawing.Point(131, 38);
            this.lbl_chonkhoa.Name = "lbl_chonkhoa";
            this.lbl_chonkhoa.Size = new System.Drawing.Size(59, 13);
            this.lbl_chonkhoa.TabIndex = 0;
            this.lbl_chonkhoa.Text = "Chọn khoa";
            // 
            // lbl_chonlop
            // 
            this.lbl_chonlop.AutoSize = true;
            this.lbl_chonlop.Location = new System.Drawing.Point(428, 38);
            this.lbl_chonlop.Name = "lbl_chonlop";
            this.lbl_chonlop.Size = new System.Drawing.Size(49, 13);
            this.lbl_chonlop.TabIndex = 1;
            this.lbl_chonlop.Text = "Chọn lớp";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Location = new System.Drawing.Point(44, 28);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(37, 13);
            this.lbl_MSSV.TabIndex = 2;
            this.lbl_MSSV.Text = "MSSV";
            this.lbl_MSSV.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(298, 32);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(39, 13);
            this.lbl_hoten.TabIndex = 3;
            this.lbl_hoten.Text = "Họ tên";
            // 
            // lbl_ngsinh
            // 
            this.lbl_ngsinh.AutoSize = true;
            this.lbl_ngsinh.Location = new System.Drawing.Point(27, 74);
            this.lbl_ngsinh.Name = "lbl_ngsinh";
            this.lbl_ngsinh.Size = new System.Drawing.Size(54, 13);
            this.lbl_ngsinh.TabIndex = 4;
            this.lbl_ngsinh.Text = "Ngày sinh";
            // 
            // lbl_diem
            // 
            this.lbl_diem.AutoSize = true;
            this.lbl_diem.Location = new System.Drawing.Point(306, 74);
            this.lbl_diem.Name = "lbl_diem";
            this.lbl_diem.Size = new System.Drawing.Size(31, 13);
            this.lbl_diem.TabIndex = 5;
            this.lbl_diem.Text = "Điểm";
            this.lbl_diem.Click += new System.EventHandler(this.lbl_diem_Click);
            // 
            // cbo_chonkhoa
            // 
            this.cbo_chonkhoa.FormattingEnabled = true;
            this.cbo_chonkhoa.Location = new System.Drawing.Point(214, 35);
            this.cbo_chonkhoa.Name = "cbo_chonkhoa";
            this.cbo_chonkhoa.Size = new System.Drawing.Size(152, 21);
            this.cbo_chonkhoa.TabIndex = 6;
            this.cbo_chonkhoa.SelectedIndexChanged += new System.EventHandler(this.cbo_chonkhoa_SelectedIndexChanged);
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(106, 28);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(152, 20);
            this.txt_mssv.TabIndex = 7;
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(371, 71);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(140, 20);
            this.txt_diem.TabIndex = 8;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(371, 25);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(140, 20);
            this.txt_hoten.TabIndex = 10;
            // 
            // cbo_chonlop
            // 
            this.cbo_chonlop.FormattingEnabled = true;
            this.cbo_chonlop.Location = new System.Drawing.Point(496, 35);
            this.cbo_chonlop.Name = "cbo_chonlop";
            this.cbo_chonlop.Size = new System.Drawing.Size(175, 21);
            this.cbo_chonlop.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_mssv,
            this.column_hoten,
            this.column_ngsinh,
            this.column_Diem,
            this.column_MaMH,
            this.column_tenMH});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(134, 239);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(543, 155);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // column_mssv
            // 
            this.column_mssv.Text = "MSSV";
            this.column_mssv.Width = 85;
            // 
            // column_hoten
            // 
            this.column_hoten.Text = "Họ tên";
            this.column_hoten.Width = 117;
            // 
            // column_ngsinh
            // 
            this.column_ngsinh.Text = "Ngày sinh";
            this.column_ngsinh.Width = 107;
            // 
            // column_Diem
            // 
            this.column_Diem.Text = "Điểm";
            // 
            // column_MaMH
            // 
            this.column_MaMH.Text = "Mã MH";
            this.column_MaMH.Width = 79;
            // 
            // column_tenMH
            // 
            this.column_tenMH.Text = "Tên MH";
            this.column_tenMH.Width = 154;
            // 
            // mtxt_Ngaysinh
            // 
            this.mtxt_Ngaysinh.Location = new System.Drawing.Point(106, 71);
            this.mtxt_Ngaysinh.Mask = "00/00/0000";
            this.mtxt_Ngaysinh.Name = "mtxt_Ngaysinh";
            this.mtxt_Ngaysinh.Size = new System.Drawing.Size(152, 20);
            this.mtxt_Ngaysinh.TabIndex = 14;
            this.mtxt_Ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // gbo_ttsv
            // 
            this.gbo_ttsv.Controls.Add(this.btn_xoa);
            this.gbo_ttsv.Controls.Add(this.btn_sua);
            this.gbo_ttsv.Controls.Add(this.btn_them);
            this.gbo_ttsv.Controls.Add(this.txt_diem);
            this.gbo_ttsv.Controls.Add(this.txt_mssv);
            this.gbo_ttsv.Controls.Add(this.lbl_hoten);
            this.gbo_ttsv.Controls.Add(this.mtxt_Ngaysinh);
            this.gbo_ttsv.Controls.Add(this.lbl_diem);
            this.gbo_ttsv.Controls.Add(this.txt_hoten);
            this.gbo_ttsv.Controls.Add(this.lbl_MSSV);
            this.gbo_ttsv.Controls.Add(this.lbl_ngsinh);
            this.gbo_ttsv.Location = new System.Drawing.Point(134, 75);
            this.gbo_ttsv.Name = "gbo_ttsv";
            this.gbo_ttsv.Size = new System.Drawing.Size(549, 158);
            this.gbo_ttsv.TabIndex = 15;
            this.gbo_ttsv.TabStop = false;
            this.gbo_ttsv.Text = "Thông tin sinh viên";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(91, 112);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(248, 112);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(401, 112);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbo_ttsv);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbo_chonlop);
            this.Controls.Add(this.cbo_chonkhoa);
            this.Controls.Add(this.lbl_chonlop);
            this.Controls.Add(this.lbl_chonkhoa);
            this.Name = "Form1";
            this.Text = "frm_quanlisv";
            this.gbo_ttsv.ResumeLayout(false);
            this.gbo_ttsv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chonkhoa;
        private System.Windows.Forms.Label lbl_chonlop;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_ngsinh;
        private System.Windows.Forms.Label lbl_diem;
        private System.Windows.Forms.ComboBox cbo_chonkhoa;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.ComboBox cbo_chonlop;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_mssv;
        private System.Windows.Forms.ColumnHeader column_hoten;
        private System.Windows.Forms.ColumnHeader column_ngsinh;
        private System.Windows.Forms.ColumnHeader column_Diem;
        private System.Windows.Forms.ColumnHeader column_MaMH;
        private System.Windows.Forms.ColumnHeader column_tenMH;
        private System.Windows.Forms.MaskedTextBox mtxt_Ngaysinh;
        private System.Windows.Forms.GroupBox gbo_ttsv;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
    }
}

