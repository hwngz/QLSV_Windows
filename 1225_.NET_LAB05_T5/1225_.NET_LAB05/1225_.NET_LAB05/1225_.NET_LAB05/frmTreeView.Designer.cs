namespace _1225_.NET_LAB05
{
    partial class frmTreeView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvDS = new System.Windows.Forms.TreeView();
            this.lblPhongban = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.cbo_PhongBan = new System.Windows.Forms.ComboBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.txtMaso = new System.Windows.Forms.TextBox();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhongban);
            this.groupBox1.Controls.Add(this.txtPhongBan);
            this.groupBox1.Controls.Add(this.trvDS);
            this.groupBox1.Controls.Add(this.btnXoaPB);
            this.groupBox1.Controls.Add(this.btnThemPB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // trvDS
            // 
            this.trvDS.Location = new System.Drawing.Point(6, 19);
            this.trvDS.Name = "trvDS";
            this.trvDS.Size = new System.Drawing.Size(207, 271);
            this.trvDS.TabIndex = 0;
            // 
            // lblPhongban
            // 
            this.lblPhongban.AutoSize = true;
            this.lblPhongban.Location = new System.Drawing.Point(13, 316);
            this.lblPhongban.Name = "lblPhongban";
            this.lblPhongban.Size = new System.Drawing.Size(59, 13);
            this.lblPhongban.TabIndex = 1;
            this.lblPhongban.Text = "Phòng ban";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(316, 142);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 23);
            this.btnThemNV.TabIndex = 1;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cbo_PhongBan
            // 
            this.cbo_PhongBan.FormattingEnabled = true;
            this.cbo_PhongBan.Location = new System.Drawing.Point(291, 99);
            this.cbo_PhongBan.Name = "cbo_PhongBan";
            this.cbo_PhongBan.Size = new System.Drawing.Size(353, 21);
            this.cbo_PhongBan.TabIndex = 3;
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Location = new System.Drawing.Point(101, 313);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(100, 20);
            this.txtPhongBan.TabIndex = 2;
            // 
            // txtMaso
            // 
            this.txtMaso.Location = new System.Drawing.Point(291, 19);
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.Size = new System.Drawing.Size(100, 20);
            this.txtMaso.TabIndex = 2;
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(226, 22);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(36, 13);
            this.lblMaSo.TabIndex = 1;
            this.lblMaSo.Text = "Mã số";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(465, 19);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(179, 20);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(400, 22);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(39, 13);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Họ tên";
            this.lblHoten.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(291, 58);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(353, 20);
            this.txtDiachi.TabIndex = 2;
            this.txtDiachi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phòng ban";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(101, 349);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(100, 23);
            this.btnThemPB.TabIndex = 1;
            this.btnThemPB.Text = "Thêm phòng ban";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.Location = new System.Drawing.Point(101, 378);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(100, 23);
            this.btnXoaPB.TabIndex = 1;
            this.btnXoaPB.Text = "Xóa phòng ban";
            this.btnXoaPB.UseVisualStyleBackColor = true;
            this.btnXoaPB.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.cbo_PhongBan);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMaso);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhongban;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.TreeView trvDS;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.ComboBox cbo_PhongBan;
        private System.Windows.Forms.TextBox txtMaso;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
    }
}