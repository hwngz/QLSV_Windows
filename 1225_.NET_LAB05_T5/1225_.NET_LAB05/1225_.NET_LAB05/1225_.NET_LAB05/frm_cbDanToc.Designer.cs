namespace _1225_.NET_LAB05
{
    partial class frm_cbDanToc
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
            this.btn_loadDL = new System.Windows.Forms.Button();
            this.cbo_dantoc = new System.Windows.Forms.ComboBox();
            this.lblDantoc = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loadDL
            // 
            this.btn_loadDL.Location = new System.Drawing.Point(12, 12);
            this.btn_loadDL.Name = "btn_loadDL";
            this.btn_loadDL.Size = new System.Drawing.Size(153, 23);
            this.btn_loadDL.TabIndex = 0;
            this.btn_loadDL.Text = "Load dữ liệu Combobox";
            this.btn_loadDL.UseVisualStyleBackColor = true;
            this.btn_loadDL.Click += new System.EventHandler(this.btn_loadDL_Click);
            // 
            // cbo_dantoc
            // 
            this.cbo_dantoc.FormattingEnabled = true;
            this.cbo_dantoc.Location = new System.Drawing.Point(89, 51);
            this.cbo_dantoc.Name = "cbo_dantoc";
            this.cbo_dantoc.Size = new System.Drawing.Size(121, 21);
            this.cbo_dantoc.TabIndex = 1;
            this.cbo_dantoc.SelectedIndexChanged += new System.EventHandler(this.cbo_dantoc_SelectedIndexChanged);
            // 
            // lblDantoc
            // 
            this.lblDantoc.AutoSize = true;
            this.lblDantoc.Location = new System.Drawing.Point(38, 54);
            this.lblDantoc.Name = "lblDantoc";
            this.lblDantoc.Size = new System.Drawing.Size(45, 13);
            this.lblDantoc.TabIndex = 2;
            this.lblDantoc.Text = "Dân tộc";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(119, 93);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(65, 23);
            this.btn_hienthi.TabIndex = 0;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(31, 121);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 3;
            // 
            // frm_cbDanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblDantoc);
            this.Controls.Add(this.cbo_dantoc);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.btn_loadDL);
            this.Name = "frm_cbDanToc";
            this.Text = "frm_cbDanToc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadDL;
        private System.Windows.Forms.ComboBox cbo_dantoc;
        private System.Windows.Forms.Label lblDantoc;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lblKetQua;
    }
}