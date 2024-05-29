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
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_ngsinh = new System.Windows.Forms.Label();
            this.lbl_diem = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.mtxt_Ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.gbo_ttsv = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chbox_Themlop = new System.Windows.Forms.CheckBox();
            this.gbo_thongtinlop = new System.Windows.Forms.GroupBox();
            this.lbl_tenlop = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_themlop = new System.Windows.Forms.Button();
            this.gbo_ttsv.SuspendLayout();
            this.gbo_thongtinlop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Location = new System.Drawing.Point(44, 28);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(37, 13);
            this.lbl_MSSV.TabIndex = 2;
            this.lbl_MSSV.Text = "MSSV";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(219, 35);
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
            this.lbl_diem.Location = new System.Drawing.Point(227, 77);
            this.lbl_diem.Name = "lbl_diem";
            this.lbl_diem.Size = new System.Drawing.Size(31, 13);
            this.lbl_diem.TabIndex = 5;
            this.lbl_diem.Text = "Điểm";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(106, 28);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(74, 20);
            this.txt_mssv.TabIndex = 7;
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(292, 74);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(78, 20);
            this.txt_diem.TabIndex = 8;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(292, 28);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(78, 20);
            this.txt_hoten.TabIndex = 10;
            // 
            // mtxt_Ngaysinh
            // 
            this.mtxt_Ngaysinh.Location = new System.Drawing.Point(106, 71);
            this.mtxt_Ngaysinh.Mask = "00/00/0000";
            this.mtxt_Ngaysinh.Name = "mtxt_Ngaysinh";
            this.mtxt_Ngaysinh.Size = new System.Drawing.Size(74, 20);
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
            this.gbo_ttsv.Location = new System.Drawing.Point(268, 12);
            this.gbo_ttsv.Name = "gbo_ttsv";
            this.gbo_ttsv.Size = new System.Drawing.Size(375, 158);
            this.gbo_ttsv.TabIndex = 15;
            this.gbo_ttsv.TabStop = false;
            this.gbo_ttsv.Text = "Thông tin sinh viên";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(292, 112);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(171, 112);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(47, 112);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 393);
            this.treeView1.TabIndex = 16;
            // 
            // chbox_Themlop
            // 
            this.chbox_Themlop.AutoSize = true;
            this.chbox_Themlop.Location = new System.Drawing.Point(268, 190);
            this.chbox_Themlop.Name = "chbox_Themlop";
            this.chbox_Themlop.Size = new System.Drawing.Size(70, 17);
            this.chbox_Themlop.TabIndex = 17;
            this.chbox_Themlop.Text = "Thêm lớp";
            this.chbox_Themlop.UseVisualStyleBackColor = true;
            // 
            // gbo_thongtinlop
            // 
            this.gbo_thongtinlop.Controls.Add(this.btn_themlop);
            this.gbo_thongtinlop.Controls.Add(this.textBox1);
            this.gbo_thongtinlop.Controls.Add(this.lbl_tenlop);
            this.gbo_thongtinlop.Location = new System.Drawing.Point(268, 222);
            this.gbo_thongtinlop.Name = "gbo_thongtinlop";
            this.gbo_thongtinlop.Size = new System.Drawing.Size(375, 87);
            this.gbo_thongtinlop.TabIndex = 18;
            this.gbo_thongtinlop.TabStop = false;
            this.gbo_thongtinlop.Text = "Thông tin lớp";
            // 
            // lbl_tenlop
            // 
            this.lbl_tenlop.AutoSize = true;
            this.lbl_tenlop.Location = new System.Drawing.Point(16, 35);
            this.lbl_tenlop.Name = "lbl_tenlop";
            this.lbl_tenlop.Size = new System.Drawing.Size(43, 13);
            this.lbl_tenlop.TabIndex = 0;
            this.lbl_tenlop.Text = "Tên lớp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_themlop
            // 
            this.btn_themlop.Location = new System.Drawing.Point(272, 35);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(75, 23);
            this.btn_themlop.TabIndex = 2;
            this.btn_themlop.Text = "Thêm lớp";
            this.btn_themlop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.gbo_thongtinlop);
            this.Controls.Add(this.chbox_Themlop);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.gbo_ttsv);
            this.Name = "Form1";
            this.Text = "frm_treeview";
            this.gbo_ttsv.ResumeLayout(false);
            this.gbo_ttsv.PerformLayout();
            this.gbo_thongtinlop.ResumeLayout(false);
            this.gbo_thongtinlop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_ngsinh;
        private System.Windows.Forms.Label lbl_diem;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.MaskedTextBox mtxt_Ngaysinh;
        private System.Windows.Forms.GroupBox gbo_ttsv;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chbox_Themlop;
        private System.Windows.Forms.GroupBox gbo_thongtinlop;
        private System.Windows.Forms.Button btn_themlop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_tenlop;
    }
}

