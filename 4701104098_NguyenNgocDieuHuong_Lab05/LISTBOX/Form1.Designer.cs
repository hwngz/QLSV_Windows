namespace LISTBOX
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
            this.list_trai = new System.Windows.Forms.ListBox();
            this.list_phai = new System.Windows.Forms.ListBox();
            this.btn_quaphai = new System.Windows.Forms.Button();
            this.btn_qua_phai_all = new System.Windows.Forms.Button();
            this.btn_quatrai = new System.Windows.Forms.Button();
            this.btn_qua_trai_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_trai
            // 
            this.list_trai.FormattingEnabled = true;
            this.list_trai.Items.AddRange(new object[] {
            "Cốc",
            "Ổi",
            "Xoài",
            "Mận",
            "Cam"});
            this.list_trai.Location = new System.Drawing.Point(202, 21);
            this.list_trai.Name = "list_trai";
            this.list_trai.Size = new System.Drawing.Size(120, 212);
            this.list_trai.TabIndex = 0;
            // 
            // list_phai
            // 
            this.list_phai.FormattingEnabled = true;
            this.list_phai.Location = new System.Drawing.Point(421, 21);
            this.list_phai.Name = "list_phai";
            this.list_phai.Size = new System.Drawing.Size(120, 212);
            this.list_phai.TabIndex = 1;
            // 
            // btn_quaphai
            // 
            this.btn_quaphai.Location = new System.Drawing.Point(340, 50);
            this.btn_quaphai.Name = "btn_quaphai";
            this.btn_quaphai.Size = new System.Drawing.Size(75, 23);
            this.btn_quaphai.TabIndex = 2;
            this.btn_quaphai.Text = ">";
            this.btn_quaphai.UseVisualStyleBackColor = true;
            this.btn_quaphai.Click += new System.EventHandler(this.btn_quaphai_Click);
            // 
            // btn_qua_phai_all
            // 
            this.btn_qua_phai_all.Location = new System.Drawing.Point(340, 102);
            this.btn_qua_phai_all.Name = "btn_qua_phai_all";
            this.btn_qua_phai_all.Size = new System.Drawing.Size(75, 23);
            this.btn_qua_phai_all.TabIndex = 3;
            this.btn_qua_phai_all.Text = ">>";
            this.btn_qua_phai_all.UseVisualStyleBackColor = true;
            this.btn_qua_phai_all.Click += new System.EventHandler(this.btn_qua_phai_all_Click);
            // 
            // btn_quatrai
            // 
            this.btn_quatrai.Location = new System.Drawing.Point(340, 142);
            this.btn_quatrai.Name = "btn_quatrai";
            this.btn_quatrai.Size = new System.Drawing.Size(75, 23);
            this.btn_quatrai.TabIndex = 4;
            this.btn_quatrai.Text = "<";
            this.btn_quatrai.UseVisualStyleBackColor = true;
            // 
            // btn_qua_trai_all
            // 
            this.btn_qua_trai_all.Location = new System.Drawing.Point(340, 185);
            this.btn_qua_trai_all.Name = "btn_qua_trai_all";
            this.btn_qua_trai_all.Size = new System.Drawing.Size(75, 23);
            this.btn_qua_trai_all.TabIndex = 5;
            this.btn_qua_trai_all.Text = "<<";
            this.btn_qua_trai_all.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_qua_trai_all);
            this.Controls.Add(this.btn_quatrai);
            this.Controls.Add(this.btn_qua_phai_all);
            this.Controls.Add(this.btn_quaphai);
            this.Controls.Add(this.list_phai);
            this.Controls.Add(this.list_trai);
            this.Name = "Form1";
            this.Text = "Sử dụng Listbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_trai;
        private System.Windows.Forms.ListBox list_phai;
        private System.Windows.Forms.Button btn_quaphai;
        private System.Windows.Forms.Button btn_qua_phai_all;
        private System.Windows.Forms.Button btn_quatrai;
        private System.Windows.Forms.Button btn_qua_trai_all;
    }
}

