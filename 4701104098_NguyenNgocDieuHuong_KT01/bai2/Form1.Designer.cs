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
            this.components = new System.ComponentModel.Container();
            this.lbltuade = new System.Windows.Forms.Label();
            this.lblnhapso = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lbltong = new System.Windows.Forms.Label();
            this.lblsophantu = new System.Windows.Forms.Label();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.txtdaynhap = new System.Windows.Forms.TextBox();
            this.btnnhapso = new System.Windows.Forms.Button();
            this.btnsapxep = new System.Windows.Forms.Button();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttongmang = new System.Windows.Forms.TextBox();
            this.txtsophantu = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltuade
            // 
            this.lbltuade.AutoSize = true;
            this.lbltuade.ForeColor = System.Drawing.Color.Navy;
            this.lbltuade.Location = new System.Drawing.Point(328, 32);
            this.lbltuade.Name = "lbltuade";
            this.lbltuade.Size = new System.Drawing.Size(201, 13);
            this.lbltuade.TabIndex = 0;
            this.lbltuade.Text = "TÍNH TOÁN TRÊN MẢNG SỐ NGUYÊN";
            // 
            // lblnhapso
            // 
            this.lblnhapso.AutoSize = true;
            this.lblnhapso.Location = new System.Drawing.Point(223, 76);
            this.lblnhapso.Name = "lblnhapso";
            this.lblnhapso.Size = new System.Drawing.Size(47, 13);
            this.lblnhapso.TabIndex = 1;
            this.lblnhapso.Text = "Nhập số";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(223, 107);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(74, 13);
            this.lblday.TabIndex = 2;
            this.lblday.Text = "Dãy vừa nhập";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Location = new System.Drawing.Point(302, 158);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(61, 13);
            this.lbltong.TabIndex = 3;
            this.lbltong.Text = "Tổng mảng";
            // 
            // lblsophantu
            // 
            this.lblsophantu.AutoSize = true;
            this.lblsophantu.Location = new System.Drawing.Point(277, 204);
            this.lblsophantu.Name = "lblsophantu";
            this.lblsophantu.Size = new System.Drawing.Size(86, 13);
            this.lblsophantu.TabIndex = 4;
            this.lblsophantu.Text = "Số phần tử chẳn";
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(305, 76);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(159, 20);
            this.txtnhapso.TabIndex = 5;
            this.txtnhapso.TextChanged += new System.EventHandler(this.txtnhapso_TextChanged);
            // 
            // txtdaynhap
            // 
            this.txtdaynhap.Location = new System.Drawing.Point(305, 107);
            this.txtdaynhap.Name = "txtdaynhap";
            this.txtdaynhap.Size = new System.Drawing.Size(268, 20);
            this.txtdaynhap.TabIndex = 6;
            // 
            // btnnhapso
            // 
            this.btnnhapso.Location = new System.Drawing.Point(470, 74);
            this.btnnhapso.Name = "btnnhapso";
            this.btnnhapso.Size = new System.Drawing.Size(103, 23);
            this.btnnhapso.TabIndex = 7;
            this.btnnhapso.Text = "Nhập số";
            this.btnnhapso.UseVisualStyleBackColor = true;
            this.btnnhapso.Click += new System.EventHandler(this.btnnhapso_Click);
            // 
            // btnsapxep
            // 
            this.btnsapxep.Location = new System.Drawing.Point(595, 105);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(97, 23);
            this.btnsapxep.TabIndex = 8;
            this.btnsapxep.Text = "Sắp xếp giảm";
            this.btnsapxep.UseVisualStyleBackColor = true;
            // 
            // btnthuchien
            // 
            this.btnthuchien.Location = new System.Drawing.Point(363, 238);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(75, 23);
            this.btnthuchien.TabIndex = 9;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(470, 238);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttongmang
            // 
            this.txttongmang.Location = new System.Drawing.Point(369, 155);
            this.txttongmang.Name = "txttongmang";
            this.txttongmang.Size = new System.Drawing.Size(204, 20);
            this.txttongmang.TabIndex = 11;
            // 
            // txtsophantu
            // 
            this.txtsophantu.Location = new System.Drawing.Point(369, 197);
            this.txtsophantu.Name = "txtsophantu";
            this.txtsophantu.Size = new System.Drawing.Size(204, 20);
            this.txtsophantu.TabIndex = 12;
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
            this.Controls.Add(this.txtsophantu);
            this.Controls.Add(this.txttongmang);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.btnsapxep);
            this.Controls.Add(this.btnnhapso);
            this.Controls.Add(this.txtdaynhap);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.lblsophantu);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lblnhapso);
            this.Controls.Add(this.lbltuade);
            this.Name = "Form1";
            this.Text = "Câu 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltuade;
        private System.Windows.Forms.Label lblnhapso;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label lblsophantu;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.TextBox txtdaynhap;
        private System.Windows.Forms.Button btnnhapso;
        private System.Windows.Forms.Button btnsapxep;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttongmang;
        private System.Windows.Forms.TextBox txtsophantu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

