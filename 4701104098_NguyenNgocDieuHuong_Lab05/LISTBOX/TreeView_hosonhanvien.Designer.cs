namespace LISTBOX
{
    partial class TreeView_hosonhanvien
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
            this.lbl_phongban_tren = new System.Windows.Forms.Label();
            this.lbl_phongban_duoi = new System.Windows.Forms.Label();
            this.lbl_maso = new System.Windows.Forms.Label();
            this.lbl_hoso = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_phongban = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_PB = new System.Windows.Forms.TextBox();
            this.btn_thêmPB = new System.Windows.Forms.Button();
            this.btn_xoaPB = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.trv_PB = new System.Windows.Forms.TreeView();
            this.cbo_phongban = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_phongban_tren
            // 
            this.lbl_phongban_tren.AutoSize = true;
            this.lbl_phongban_tren.Location = new System.Drawing.Point(68, 32);
            this.lbl_phongban_tren.Name = "lbl_phongban_tren";
            this.lbl_phongban_tren.Size = new System.Drawing.Size(59, 13);
            this.lbl_phongban_tren.TabIndex = 0;
            this.lbl_phongban_tren.Text = "Phòng ban";
            // 
            // lbl_phongban_duoi
            // 
            this.lbl_phongban_duoi.AutoSize = true;
            this.lbl_phongban_duoi.Location = new System.Drawing.Point(68, 235);
            this.lbl_phongban_duoi.Name = "lbl_phongban_duoi";
            this.lbl_phongban_duoi.Size = new System.Drawing.Size(59, 13);
            this.lbl_phongban_duoi.TabIndex = 1;
            this.lbl_phongban_duoi.Text = "Phòng ban";
            this.lbl_phongban_duoi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_maso
            // 
            this.lbl_maso.AutoSize = true;
            this.lbl_maso.Location = new System.Drawing.Point(343, 67);
            this.lbl_maso.Name = "lbl_maso";
            this.lbl_maso.Size = new System.Drawing.Size(36, 13);
            this.lbl_maso.TabIndex = 2;
            this.lbl_maso.Text = "Mã số";
            // 
            // lbl_hoso
            // 
            this.lbl_hoso.AutoSize = true;
            this.lbl_hoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoso.ForeColor = System.Drawing.Color.Red;
            this.lbl_hoso.Location = new System.Drawing.Point(342, 25);
            this.lbl_hoso.Name = "lbl_hoso";
            this.lbl_hoso.Size = new System.Drawing.Size(166, 20);
            this.lbl_hoso.TabIndex = 3;
            this.lbl_hoso.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(515, 67);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(39, 13);
            this.lbl_hoten.TabIndex = 4;
            this.lbl_hoten.Text = "Họ tên";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(343, 124);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(40, 13);
            this.lbl_diachi.TabIndex = 5;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // lbl_phongban
            // 
            this.lbl_phongban.AutoSize = true;
            this.lbl_phongban.Location = new System.Drawing.Point(324, 171);
            this.lbl_phongban.Name = "lbl_phongban";
            this.lbl_phongban.Size = new System.Drawing.Size(59, 13);
            this.lbl_phongban.TabIndex = 6;
            this.lbl_phongban.Text = "Phòng ban";
            this.lbl_phongban.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(397, 64);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(100, 20);
            this.txt_maso.TabIndex = 8;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(572, 64);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(100, 20);
            this.txt_hoten.TabIndex = 9;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(397, 124);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(275, 20);
            this.txt_diachi.TabIndex = 10;
            // 
            // txt_PB
            // 
            this.txt_PB.Location = new System.Drawing.Point(152, 235);
            this.txt_PB.Name = "txt_PB";
            this.txt_PB.Size = new System.Drawing.Size(166, 20);
            this.txt_PB.TabIndex = 12;
            // 
            // btn_thêmPB
            // 
            this.btn_thêmPB.Location = new System.Drawing.Point(152, 274);
            this.btn_thêmPB.Name = "btn_thêmPB";
            this.btn_thêmPB.Size = new System.Drawing.Size(166, 23);
            this.btn_thêmPB.TabIndex = 13;
            this.btn_thêmPB.Text = "Thêm phòng ban";
            this.btn_thêmPB.UseVisualStyleBackColor = true;
            this.btn_thêmPB.Click += new System.EventHandler(this.btn_thêmPB_Click);
            // 
            // btn_xoaPB
            // 
            this.btn_xoaPB.Location = new System.Drawing.Point(152, 303);
            this.btn_xoaPB.Name = "btn_xoaPB";
            this.btn_xoaPB.Size = new System.Drawing.Size(166, 23);
            this.btn_xoaPB.TabIndex = 14;
            this.btn_xoaPB.Text = "Xóa phòng ban";
            this.btn_xoaPB.UseVisualStyleBackColor = true;
            this.btn_xoaPB.Click += new System.EventHandler(this.btn_xoaPB_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(397, 212);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(499, 212);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 16;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // trv_PB
            // 
            this.trv_PB.Location = new System.Drawing.Point(71, 64);
            this.trv_PB.Name = "trv_PB";
            this.trv_PB.Size = new System.Drawing.Size(253, 149);
            this.trv_PB.TabIndex = 17;
            // 
            // cbo_phongban
            // 
            this.cbo_phongban.FormattingEnabled = true;
            this.cbo_phongban.Location = new System.Drawing.Point(397, 171);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new System.Drawing.Size(275, 21);
            this.cbo_phongban.TabIndex = 18;
            // 
            // TreeView_hosonhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.trv_PB);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoaPB);
            this.Controls.Add(this.btn_thêmPB);
            this.Controls.Add(this.txt_PB);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.lbl_phongban);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.lbl_hoso);
            this.Controls.Add(this.lbl_maso);
            this.Controls.Add(this.lbl_phongban_duoi);
            this.Controls.Add(this.lbl_phongban_tren);
            this.Name = "TreeView_hosonhanvien";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_hosonhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phongban_tren;
        private System.Windows.Forms.Label lbl_phongban_duoi;
        private System.Windows.Forms.Label lbl_maso;
        private System.Windows.Forms.Label lbl_hoso;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_phongban;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_PB;
        private System.Windows.Forms.Button btn_thêmPB;
        private System.Windows.Forms.Button btn_xoaPB;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TreeView trv_PB;
        private System.Windows.Forms.ComboBox cbo_phongban;
    }
}