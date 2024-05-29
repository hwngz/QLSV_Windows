
namespace Bai_4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dayvuanhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongpt = new System.Windows.Forms.TextBox();
            this.txt_tongchan = new System.Windows.Forms.TextBox();
            this.txt_tongle = new System.Windows.Forms.TextBox();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.btn_tongle = new System.Windows.Forms.Button();
            this.btn_tongchan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số và Tính Tổng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số ";
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Location = new System.Drawing.Point(149, 66);
            this.txt_nhapso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(114, 26);
            this.txt_nhapso.TabIndex = 2;
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(300, 61);
            this.btn_nhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(112, 36);
            this.btn_nhap.TabIndex = 3;
            this.btn_nhap.Text = "Nhập";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dãy vừa nhập";
            // 
            // txt_dayvuanhap
            // 
            this.txt_dayvuanhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dayvuanhap.Location = new System.Drawing.Point(149, 127);
            this.txt_dayvuanhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dayvuanhap.Name = "txt_dayvuanhap";
            this.txt_dayvuanhap.ReadOnly = true;
            this.txt_dayvuanhap.Size = new System.Drawing.Size(253, 26);
            this.txt_dayvuanhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng các phần tử trong dãy ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng chẵn ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng lẻ";
            // 
            // txt_tongpt
            // 
            this.txt_tongpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongpt.Location = new System.Drawing.Point(248, 184);
            this.txt_tongpt.Name = "txt_tongpt";
            this.txt_tongpt.ReadOnly = true;
            this.txt_tongpt.Size = new System.Drawing.Size(154, 26);
            this.txt_tongpt.TabIndex = 7;
            // 
            // txt_tongchan
            // 
            this.txt_tongchan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongchan.Location = new System.Drawing.Point(130, 252);
            this.txt_tongchan.Name = "txt_tongchan";
            this.txt_tongchan.ReadOnly = true;
            this.txt_tongchan.Size = new System.Drawing.Size(81, 26);
            this.txt_tongchan.TabIndex = 9;
            // 
            // txt_tongle
            // 
            this.txt_tongle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongle.Location = new System.Drawing.Point(315, 252);
            this.txt_tongle.Name = "txt_tongle";
            this.txt_tongle.ReadOnly = true;
            this.txt_tongle.Size = new System.Drawing.Size(87, 26);
            this.txt_tongle.TabIndex = 11;
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Location = new System.Drawing.Point(91, 384);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(102, 35);
            this.btn_tieptuc.TabIndex = 15;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(257, 384);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 35);
            this.btn_thoat.TabIndex = 16;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.Location = new System.Drawing.Point(39, 319);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(102, 35);
            this.btn_tinhtong.TabIndex = 12;
            this.btn_tinhtong.Text = "Tính tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = true;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // btn_tongle
            // 
            this.btn_tongle.Location = new System.Drawing.Point(310, 319);
            this.btn_tongle.Name = "btn_tongle";
            this.btn_tongle.Size = new System.Drawing.Size(102, 35);
            this.btn_tongle.TabIndex = 14;
            this.btn_tongle.Text = "Tổng lẻ";
            this.btn_tongle.UseVisualStyleBackColor = true;
            this.btn_tongle.Click += new System.EventHandler(this.btn_tongle_Click);
            // 
            // btn_tongchan
            // 
            this.btn_tongchan.Location = new System.Drawing.Point(170, 319);
            this.btn_tongchan.Name = "btn_tongchan";
            this.btn_tongchan.Size = new System.Drawing.Size(106, 35);
            this.btn_tongchan.TabIndex = 13;
            this.btn_tongchan.Text = "Tổng chẵn";
            this.btn_tongchan.UseVisualStyleBackColor = true;
            this.btn_tongchan.Click += new System.EventHandler(this.btn_tongchan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 466);
            this.Controls.Add(this.btn_tongchan);
            this.Controls.Add(this.btn_tongle);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.txt_tongle);
            this.Controls.Add(this.txt_tongchan);
            this.Controls.Add(this.txt_tongpt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dayvuanhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.txt_nhapso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Dãy số và tính tổng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhapso;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dayvuanhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongpt;
        private System.Windows.Forms.TextBox txt_tongchan;
        private System.Windows.Forms.TextBox txt_tongle;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Button btn_tongle;
        private System.Windows.Forms.Button btn_tongchan;
    }
}

