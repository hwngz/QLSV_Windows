namespace Bai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenkhach = new System.Windows.Forms.TextBox();
            this.tbSokhach = new System.Windows.Forms.TextBox();
            this.cbSinhVien = new System.Windows.Forms.CheckBox();
            this.grbThucAn = new System.Windows.Forms.GroupBox();
            this.cbMycay = new System.Windows.Forms.CheckBox();
            this.cbMyxaobo = new System.Windows.Forms.CheckBox();
            this.cbMytomtrung = new System.Windows.Forms.CheckBox();
            this.cbBanhmyca = new System.Windows.Forms.CheckBox();
            this.cbBanhmytrung = new System.Windows.Forms.CheckBox();
            this.btTinhtien = new System.Windows.Forms.Button();
            this.btNhaplai = new System.Windows.Forms.Button();
            this.btThanhtoan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTongkhach = new System.Windows.Forms.TextBox();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdCafeden = new System.Windows.Forms.RadioButton();
            this.rdCafeda = new System.Windows.Forms.RadioButton();
            this.rdCafekem = new System.Windows.Forms.RadioButton();
            this.rdCafesua = new System.Windows.Forms.RadioButton();
            this.rdCafesuada = new System.Windows.Forms.RadioButton();
            this.grbNuocUong = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThucAn.SuspendLayout();
            this.grbNuocUong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀFÊ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten khach hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "So khach hang";
            // 
            // tbTenkhach
            // 
            this.tbTenkhach.Location = new System.Drawing.Point(133, 64);
            this.tbTenkhach.Name = "tbTenkhach";
            this.tbTenkhach.Size = new System.Drawing.Size(478, 20);
            this.tbTenkhach.TabIndex = 1;
            this.tbTenkhach.TextChanged += new System.EventHandler(this.tbTenkhach_TextChanged);
            this.tbTenkhach.Leave += new System.EventHandler(this.tbTenkhach_Leave);
            // 
            // tbSokhach
            // 
            this.tbSokhach.Location = new System.Drawing.Point(133, 93);
            this.tbSokhach.Name = "tbSokhach";
            this.tbSokhach.Size = new System.Drawing.Size(478, 20);
            this.tbSokhach.TabIndex = 2;
            this.tbSokhach.TextChanged += new System.EventHandler(this.tbSokhach_TextChanged);
            // 
            // cbSinhVien
            // 
            this.cbSinhVien.AutoSize = true;
            this.cbSinhVien.Location = new System.Drawing.Point(133, 129);
            this.cbSinhVien.Name = "cbSinhVien";
            this.cbSinhVien.Size = new System.Drawing.Size(80, 17);
            this.cbSinhVien.TabIndex = 3;
            this.cbSinhVien.Text = "Sinh Vien ?";
            this.cbSinhVien.UseVisualStyleBackColor = true;
            // 
            // grbThucAn
            // 
            this.grbThucAn.Controls.Add(this.cbMycay);
            this.grbThucAn.Controls.Add(this.cbMyxaobo);
            this.grbThucAn.Controls.Add(this.cbMytomtrung);
            this.grbThucAn.Controls.Add(this.cbBanhmyca);
            this.grbThucAn.Controls.Add(this.cbBanhmytrung);
            this.grbThucAn.Location = new System.Drawing.Point(365, 166);
            this.grbThucAn.Name = "grbThucAn";
            this.grbThucAn.Size = new System.Drawing.Size(201, 119);
            this.grbThucAn.TabIndex = 5;
            this.grbThucAn.TabStop = false;
            this.grbThucAn.Text = "Thuc an";
            // 
            // cbMycay
            // 
            this.cbMycay.AutoSize = true;
            this.cbMycay.Location = new System.Drawing.Point(123, 54);
            this.cbMycay.Name = "cbMycay";
            this.cbMycay.Size = new System.Drawing.Size(60, 17);
            this.cbMycay.TabIndex = 6;
            this.cbMycay.Text = "My cay";
            this.cbMycay.UseVisualStyleBackColor = true;
            this.cbMycay.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // cbMyxaobo
            // 
            this.cbMyxaobo.AutoSize = true;
            this.cbMyxaobo.Location = new System.Drawing.Point(123, 20);
            this.cbMyxaobo.Name = "cbMyxaobo";
            this.cbMyxaobo.Size = new System.Drawing.Size(75, 17);
            this.cbMyxaobo.TabIndex = 6;
            this.cbMyxaobo.Text = "My xao bo";
            this.cbMyxaobo.UseVisualStyleBackColor = true;
            this.cbMyxaobo.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // cbMytomtrung
            // 
            this.cbMytomtrung.AutoSize = true;
            this.cbMytomtrung.Location = new System.Drawing.Point(7, 87);
            this.cbMytomtrung.Name = "cbMytomtrung";
            this.cbMytomtrung.Size = new System.Drawing.Size(87, 17);
            this.cbMytomtrung.TabIndex = 6;
            this.cbMytomtrung.Text = "My tom trung";
            this.cbMytomtrung.UseVisualStyleBackColor = true;
            this.cbMytomtrung.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // cbBanhmyca
            // 
            this.cbBanhmyca.AutoSize = true;
            this.cbBanhmyca.Location = new System.Drawing.Point(7, 54);
            this.cbBanhmyca.Name = "cbBanhmyca";
            this.cbBanhmyca.Size = new System.Drawing.Size(82, 17);
            this.cbBanhmyca.TabIndex = 6;
            this.cbBanhmyca.Text = "Banh my ca";
            this.cbBanhmyca.UseVisualStyleBackColor = true;
            this.cbBanhmyca.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // cbBanhmytrung
            // 
            this.cbBanhmytrung.AutoSize = true;
            this.cbBanhmytrung.Location = new System.Drawing.Point(7, 20);
            this.cbBanhmytrung.Name = "cbBanhmytrung";
            this.cbBanhmytrung.Size = new System.Drawing.Size(94, 17);
            this.cbBanhmytrung.TabIndex = 6;
            this.cbBanhmytrung.Text = "Banh my trung";
            this.cbBanhmytrung.UseVisualStyleBackColor = true;
            this.cbBanhmytrung.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // btTinhtien
            // 
            this.btTinhtien.Location = new System.Drawing.Point(34, 309);
            this.btTinhtien.Name = "btTinhtien";
            this.btTinhtien.Size = new System.Drawing.Size(97, 39);
            this.btTinhtien.TabIndex = 6;
            this.btTinhtien.Text = "Tinh tien";
            this.btTinhtien.UseVisualStyleBackColor = true;
            this.btTinhtien.Click += new System.EventHandler(this.btTinhtien_Click);
            // 
            // btNhaplai
            // 
            this.btNhaplai.Location = new System.Drawing.Point(192, 309);
            this.btNhaplai.Name = "btNhaplai";
            this.btNhaplai.Size = new System.Drawing.Size(97, 39);
            this.btNhaplai.TabIndex = 7;
            this.btNhaplai.Text = "Nhap lai";
            this.btNhaplai.UseVisualStyleBackColor = true;
            this.btNhaplai.Click += new System.EventHandler(this.btNhaplai_Click);
            // 
            // btThanhtoan
            // 
            this.btThanhtoan.Location = new System.Drawing.Point(342, 309);
            this.btThanhtoan.Name = "btThanhtoan";
            this.btThanhtoan.Size = new System.Drawing.Size(97, 39);
            this.btThanhtoan.TabIndex = 8;
            this.btThanhtoan.Text = "Thanh toan";
            this.btThanhtoan.UseVisualStyleBackColor = true;
            this.btThanhtoan.Click += new System.EventHandler(this.btThanhtoan_Click);
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Location = new System.Drawing.Point(487, 309);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 39);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tong tien thanh toan";
            // 
            // tbTongkhach
            // 
            this.tbTongkhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTongkhach.Enabled = false;
            this.tbTongkhach.Location = new System.Drawing.Point(240, 354);
            this.tbTongkhach.Name = "tbTongkhach";
            this.tbTongkhach.Size = new System.Drawing.Size(371, 20);
            this.tbTongkhach.TabIndex = 10;
            // 
            // tbTongtien
            // 
            this.tbTongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTongtien.Enabled = false;
            this.tbTongtien.Location = new System.Drawing.Point(240, 383);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(371, 20);
            this.tbTongtien.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tong khach hang";
            // 
            // rdCafeden
            // 
            this.rdCafeden.AutoSize = true;
            this.rdCafeden.Location = new System.Drawing.Point(8, 19);
            this.rdCafeden.Name = "rdCafeden";
            this.rdCafeden.Size = new System.Drawing.Size(67, 17);
            this.rdCafeden.TabIndex = 5;
            this.rdCafeden.TabStop = true;
            this.rdCafeden.Text = "cafe den";
            this.rdCafeden.UseVisualStyleBackColor = true;
            this.rdCafeden.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // rdCafeda
            // 
            this.rdCafeda.AutoSize = true;
            this.rdCafeda.Location = new System.Drawing.Point(120, 19);
            this.rdCafeda.Name = "rdCafeda";
            this.rdCafeda.Size = new System.Drawing.Size(61, 17);
            this.rdCafeda.TabIndex = 5;
            this.rdCafeda.TabStop = true;
            this.rdCafeda.Text = "cafe da";
            this.rdCafeda.UseVisualStyleBackColor = true;
            this.rdCafeda.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // rdCafekem
            // 
            this.rdCafekem.AutoSize = true;
            this.rdCafekem.Location = new System.Drawing.Point(120, 54);
            this.rdCafekem.Name = "rdCafekem";
            this.rdCafekem.Size = new System.Drawing.Size(69, 17);
            this.rdCafekem.TabIndex = 5;
            this.rdCafekem.TabStop = true;
            this.rdCafekem.Text = "cafe kem";
            this.rdCafekem.UseVisualStyleBackColor = true;
            this.rdCafekem.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // rdCafesua
            // 
            this.rdCafesua.AutoSize = true;
            this.rdCafesua.Location = new System.Drawing.Point(8, 54);
            this.rdCafesua.Name = "rdCafesua";
            this.rdCafesua.Size = new System.Drawing.Size(66, 17);
            this.rdCafesua.TabIndex = 5;
            this.rdCafesua.TabStop = true;
            this.rdCafesua.Text = "cafe sua";
            this.rdCafesua.UseVisualStyleBackColor = true;
            this.rdCafesua.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // rdCafesuada
            // 
            this.rdCafesuada.AutoSize = true;
            this.rdCafesuada.Location = new System.Drawing.Point(8, 87);
            this.rdCafesuada.Name = "rdCafesuada";
            this.rdCafesuada.Size = new System.Drawing.Size(81, 17);
            this.rdCafesuada.TabIndex = 5;
            this.rdCafesuada.TabStop = true;
            this.rdCafesuada.Text = "cafe sua da";
            this.rdCafesuada.UseVisualStyleBackColor = true;
            this.rdCafesuada.CheckedChanged += new System.EventHandler(this.FoodDrink_CheckedChanged);
            // 
            // grbNuocUong
            // 
            this.grbNuocUong.Controls.Add(this.rdCafesuada);
            this.grbNuocUong.Controls.Add(this.rdCafesua);
            this.grbNuocUong.Controls.Add(this.rdCafekem);
            this.grbNuocUong.Controls.Add(this.rdCafeda);
            this.grbNuocUong.Controls.Add(this.rdCafeden);
            this.grbNuocUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbNuocUong.Location = new System.Drawing.Point(59, 166);
            this.grbNuocUong.Name = "grbNuocUong";
            this.grbNuocUong.Size = new System.Drawing.Size(200, 119);
            this.grbNuocUong.TabIndex = 4;
            this.grbNuocUong.TabStop = false;
            this.grbNuocUong.Text = "Nuoc uong";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 443);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThanhtoan);
            this.Controls.Add(this.btNhaplai);
            this.Controls.Add(this.btTinhtien);
            this.Controls.Add(this.grbThucAn);
            this.Controls.Add(this.grbNuocUong);
            this.Controls.Add(this.cbSinhVien);
            this.Controls.Add(this.tbTongtien);
            this.Controls.Add(this.tbSokhach);
            this.Controls.Add(this.tbTongkhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTenkhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thanh toán tiền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThucAn.ResumeLayout(false);
            this.grbThucAn.PerformLayout();
            this.grbNuocUong.ResumeLayout(false);
            this.grbNuocUong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenkhach;
        private System.Windows.Forms.TextBox tbSokhach;
        private System.Windows.Forms.CheckBox cbSinhVien;
        private System.Windows.Forms.GroupBox grbThucAn;
        private System.Windows.Forms.Button btTinhtien;
        private System.Windows.Forms.Button btNhaplai;
        private System.Windows.Forms.Button btThanhtoan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTongkhach;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.CheckBox cbMycay;
        private System.Windows.Forms.CheckBox cbMyxaobo;
        private System.Windows.Forms.CheckBox cbMytomtrung;
        private System.Windows.Forms.CheckBox cbBanhmyca;
        private System.Windows.Forms.CheckBox cbBanhmytrung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdCafeden;
        private System.Windows.Forms.RadioButton rdCafeda;
        private System.Windows.Forms.RadioButton rdCafekem;
        private System.Windows.Forms.RadioButton rdCafesua;
        private System.Windows.Forms.RadioButton rdCafesuada;
        private System.Windows.Forms.GroupBox grbNuocUong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

