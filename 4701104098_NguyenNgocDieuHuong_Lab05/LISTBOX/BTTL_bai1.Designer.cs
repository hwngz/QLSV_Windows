namespace LISTBOX
{
    partial class BTTL_bai1
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
            this.lbl_nhapso = new System.Windows.Forms.Label();
            this.lbl_dsuocso = new System.Windows.Forms.Label();
            this.btn_Capnhat = new System.Windows.Forms.Button();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_soluong = new System.Windows.Forms.Button();
            this.btn_soluongsnt = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.cbo_capnhat = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ltb_dsuocso = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nhapso
            // 
            this.lbl_nhapso.AutoSize = true;
            this.lbl_nhapso.Location = new System.Drawing.Point(155, 62);
            this.lbl_nhapso.Name = "lbl_nhapso";
            this.lbl_nhapso.Size = new System.Drawing.Size(47, 13);
            this.lbl_nhapso.TabIndex = 0;
            this.lbl_nhapso.Text = "Nhập số";
            // 
            // lbl_dsuocso
            // 
            this.lbl_dsuocso.AutoSize = true;
            this.lbl_dsuocso.Location = new System.Drawing.Point(508, 62);
            this.lbl_dsuocso.Name = "lbl_dsuocso";
            this.lbl_dsuocso.Size = new System.Drawing.Size(115, 13);
            this.lbl_dsuocso.TabIndex = 1;
            this.lbl_dsuocso.Text = "Danh sách các ước số";
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Location = new System.Drawing.Point(281, 100);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_Capnhat.TabIndex = 2;
            this.btn_Capnhat.Text = "&Cập nhật";
            this.btn_Capnhat.UseVisualStyleBackColor = true;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(511, 164);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(189, 23);
            this.btn_tong.TabIndex = 3;
            this.btn_tong.Text = "&Tổng các ước số";
            this.btn_tong.UseVisualStyleBackColor = true;
            // 
            // btn_soluong
            // 
            this.btn_soluong.Location = new System.Drawing.Point(510, 206);
            this.btn_soluong.Name = "btn_soluong";
            this.btn_soluong.Size = new System.Drawing.Size(190, 23);
            this.btn_soluong.TabIndex = 4;
            this.btn_soluong.Text = "&Số lượng các ước số chẳn";
            this.btn_soluong.UseVisualStyleBackColor = true;
            // 
            // btn_soluongsnt
            // 
            this.btn_soluongsnt.Location = new System.Drawing.Point(510, 247);
            this.btn_soluongsnt.Name = "btn_soluongsnt";
            this.btn_soluongsnt.Size = new System.Drawing.Size(190, 23);
            this.btn_soluongsnt.TabIndex = 5;
            this.btn_soluongsnt.Text = "Số lượng các ước số nguyên tố";
            this.btn_soluongsnt.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(281, 247);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Th&oát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(149, 103);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(126, 20);
            this.textbox1.TabIndex = 7;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbo_capnhat
            // 
            this.cbo_capnhat.FormattingEnabled = true;
            this.cbo_capnhat.Location = new System.Drawing.Point(149, 144);
            this.cbo_capnhat.Name = "cbo_capnhat";
            this.cbo_capnhat.Size = new System.Drawing.Size(207, 21);
            this.cbo_capnhat.TabIndex = 8;
            this.cbo_capnhat.SelectedIndexChanged += new System.EventHandler(this.cbo_capnhat_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ltb_dsuocso
            // 
            this.ltb_dsuocso.FormattingEnabled = true;
            this.ltb_dsuocso.Location = new System.Drawing.Point(511, 79);
            this.ltb_dsuocso.Name = "ltb_dsuocso";
            this.ltb_dsuocso.Size = new System.Drawing.Size(189, 69);
            this.ltb_dsuocso.TabIndex = 9;
            // 
            // BTTL_bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltb_dsuocso);
            this.Controls.Add(this.cbo_capnhat);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_soluongsnt);
            this.Controls.Add(this.btn_soluong);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.btn_Capnhat);
            this.Controls.Add(this.lbl_dsuocso);
            this.Controls.Add(this.lbl_nhapso);
            this.Name = "BTTL_bai1";
            this.Text = "combobox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nhapso;
        private System.Windows.Forms.Label lbl_dsuocso;
        private System.Windows.Forms.Button btn_Capnhat;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_soluong;
        private System.Windows.Forms.Button btn_soluongsnt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.ComboBox cbo_capnhat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox ltb_dsuocso;
    }
}