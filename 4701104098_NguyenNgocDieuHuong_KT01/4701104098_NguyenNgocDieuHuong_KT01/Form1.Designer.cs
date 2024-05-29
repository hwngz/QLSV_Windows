namespace _4701104098_NguyenNgocDieuHuong_KT01
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
            this.lblnhapn = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.btntong = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnhapn
            // 
            this.lblnhapn.AutoSize = true;
            this.lblnhapn.Location = new System.Drawing.Point(185, 109);
            this.lblnhapn.Name = "lblnhapn";
            this.lblnhapn.Size = new System.Drawing.Size(42, 13);
            this.lblnhapn.TabIndex = 0;
            this.lblnhapn.Text = "Nhập n";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(185, 146);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(140, 13);
            this.lblkq.TabIndex = 1;
            this.lblkq.Text = "Kết quả: 1+1/2+1/3+...+1/n";
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(338, 196);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 23);
            this.btntong.TabIndex = 2;
            this.btntong.Text = "Tính tổng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(458, 196);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(338, 109);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(195, 20);
            this.txt1.TabIndex = 4;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(338, 146);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(195, 20);
            this.txt2.TabIndex = 5;
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
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblnhapn);
            this.Name = "Form1";
            this.Text = "Bài1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapn;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

