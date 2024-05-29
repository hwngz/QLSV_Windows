namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBacNhat = new System.Windows.Forms.RadioButton();
            this.rdoBacHai = new System.Windows.Forms.RadioButton();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKetqua = new System.Windows.Forms.TextBox();
            this.btGiai = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(105, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIAI PHUONG TRINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBacNhat);
            this.groupBox1.Controls.Add(this.rdoBacHai);
            this.groupBox1.Location = new System.Drawing.Point(39, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ban vui long chon";
            // 
            // rdoBacNhat
            // 
            this.rdoBacNhat.AutoSize = true;
            this.rdoBacNhat.Location = new System.Drawing.Point(47, 19);
            this.rdoBacNhat.Name = "rdoBacNhat";
            this.rdoBacNhat.Size = new System.Drawing.Size(130, 17);
            this.rdoBacNhat.TabIndex = 0;
            this.rdoBacNhat.TabStop = true;
            this.rdoBacNhat.Text = "Phuong trinh bac nhat";
            this.rdoBacNhat.UseVisualStyleBackColor = true;
            this.rdoBacNhat.CheckedChanged += new System.EventHandler(this.rdoBacNhat_CheckedChanged);
            // 
            // rdoBacHai
            // 
            this.rdoBacHai.AutoSize = true;
            this.rdoBacHai.Location = new System.Drawing.Point(47, 42);
            this.rdoBacHai.Name = "rdoBacHai";
            this.rdoBacHai.Size = new System.Drawing.Size(123, 17);
            this.rdoBacHai.TabIndex = 0;
            this.rdoBacHai.TabStop = true;
            this.rdoBacHai.Text = "Phuong trinh bac hai";
            this.rdoBacHai.UseVisualStyleBackColor = true;
            this.rdoBacHai.CheckedChanged += new System.EventHandler(this.rdoBacHai_CheckedChanged);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(133, 222);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 1;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(133, 248);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 2;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(133, 274);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 3;
            this.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbC.TextChanged += new System.EventHandler(this.tbC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhap a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nhap b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "nhap c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ket qua";
            // 
            // tbKetqua
            // 
            this.tbKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKetqua.Location = new System.Drawing.Point(133, 326);
            this.tbKetqua.Multiline = true;
            this.tbKetqua.Name = "tbKetqua";
            this.tbKetqua.Size = new System.Drawing.Size(271, 46);
            this.tbKetqua.TabIndex = 1;
            // 
            // btGiai
            // 
            this.btGiai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btGiai.Location = new System.Drawing.Point(307, 222);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(97, 44);
            this.btGiai.TabIndex = 4;
            this.btGiai.Text = "Giai";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.btGiai_Click);
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(307, 272);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 43);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btGiai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGiai);
            this.Controls.Add(this.tbKetqua);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giai phuong trinh bac 1-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBacNhat;
        private System.Windows.Forms.RadioButton rdoBacHai;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKetqua;
        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Button btThoat;
    }
}

