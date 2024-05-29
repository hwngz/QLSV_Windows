namespace _4701104098_NguyenNgocDieuHuong_Lab06_07
{
    partial class FrmBTMb3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_nhapdoantext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 173);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_nhapdoantext
            // 
            this.lbl_nhapdoantext.AutoSize = true;
            this.lbl_nhapdoantext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhapdoantext.Location = new System.Drawing.Point(230, 63);
            this.lbl_nhapdoantext.Name = "lbl_nhapdoantext";
            this.lbl_nhapdoantext.Size = new System.Drawing.Size(107, 18);
            this.lbl_nhapdoantext.TabIndex = 1;
            this.lbl_nhapdoantext.Text = "Nhập đoạn text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmBTMb3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nhapdoantext);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmBTMb3";
            this.Text = "Save file dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_nhapdoantext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}