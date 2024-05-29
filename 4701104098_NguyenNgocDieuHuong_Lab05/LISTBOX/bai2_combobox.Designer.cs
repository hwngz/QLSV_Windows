namespace LISTBOX
{
    partial class bai2_combobox
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
            this.btn_loaddt = new System.Windows.Forms.Button();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.lbl_ketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loaddt
            // 
            this.btn_loaddt.Location = new System.Drawing.Point(279, 56);
            this.btn_loaddt.Name = "btn_loaddt";
            this.btn_loaddt.Size = new System.Drawing.Size(159, 23);
            this.btn_loaddt.TabIndex = 0;
            this.btn_loaddt.Text = "Load dữ liệu Combobox";
            this.btn_loaddt.UseVisualStyleBackColor = true;
            this.btn_loaddt.Click += new System.EventHandler(this.btn_loaddt_Click);
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(377, 156);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi.TabIndex = 1;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Location = new System.Drawing.Point(276, 123);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(45, 13);
            this.lbl_dt.TabIndex = 2;
            this.lbl_dt.Text = "Dân tộc";
            this.lbl_dt.Click += new System.EventHandler(this.lbl_Click);
            // 
            // cbo_dt
            // 
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(335, 120);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(149, 21);
            this.cbo_dt.TabIndex = 3;
            // 
            // lbl_ketqua
            // 
            this.lbl_ketqua.AutoSize = true;
            this.lbl_ketqua.Location = new System.Drawing.Point(239, 217);
            this.lbl_ketqua.Name = "lbl_ketqua";
            this.lbl_ketqua.Size = new System.Drawing.Size(0, 13);
            this.lbl_ketqua.TabIndex = 4;
            // 
            // bai2_combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ketqua);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.btn_loaddt);
            this.Name = "bai2_combobox";
            this.Text = "bai2_combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loaddt;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Label lbl_ketqua;
    }
}