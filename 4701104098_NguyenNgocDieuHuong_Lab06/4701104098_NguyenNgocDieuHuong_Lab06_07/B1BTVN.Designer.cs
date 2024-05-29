namespace _4701104098_NguyenNgocDieuHuong_Lab06_07
{
    partial class B1BTVN
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
            this.btn_batdau = new System.Windows.Forms.Button();
            this.lbl_phut = new System.Windows.Forms.Label();
            this.lbl_giay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_batdau
            // 
            this.btn_batdau.Location = new System.Drawing.Point(265, 91);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(75, 23);
            this.btn_batdau.TabIndex = 0;
            this.btn_batdau.Text = "Bắt đầu";
            this.btn_batdau.UseVisualStyleBackColor = true;
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // lbl_phut
            // 
            this.lbl_phut.AutoSize = true;
            this.lbl_phut.Location = new System.Drawing.Point(262, 149);
            this.lbl_phut.Name = "lbl_phut";
            this.lbl_phut.Size = new System.Drawing.Size(19, 13);
            this.lbl_phut.TabIndex = 1;
            this.lbl_phut.Text = "30";
            // 
            // lbl_giay
            // 
            this.lbl_giay.AutoSize = true;
            this.lbl_giay.Location = new System.Drawing.Point(329, 149);
            this.lbl_giay.Name = "lbl_giay";
            this.lbl_giay.Size = new System.Drawing.Size(19, 13);
            this.lbl_giay.TabIndex = 2;
            this.lbl_giay.Text = "60";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // B1BTVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_giay);
            this.Controls.Add(this.lbl_phut);
            this.Controls.Add(this.btn_batdau);
            this.Name = "B1BTVN";
            this.Text = "Đồng hồ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_batdau;
        private System.Windows.Forms.Label lbl_phut;
        private System.Windows.Forms.Label lbl_giay;
        private System.Windows.Forms.Timer timer1;
    }
}