namespace _1225_.NET_LAB05
{
    partial class frmListBox
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
            this.lst_Trai = new System.Windows.Forms.ListBox();
            this.lst_Phai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnPhaiALL = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Trai
            // 
            this.lst_Trai.FormattingEnabled = true;
            this.lst_Trai.ItemHeight = 18;
            this.lst_Trai.Items.AddRange(new object[] {
            "Oi",
            "Coc",
            "Dao",
            "Man",
            "Cam"});
            this.lst_Trai.Location = new System.Drawing.Point(16, 37);
            this.lst_Trai.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Trai.Name = "lst_Trai";
            this.lst_Trai.Size = new System.Drawing.Size(188, 310);
            this.lst_Trai.TabIndex = 0;
            // 
            // lst_Phai
            // 
            this.lst_Phai.FormattingEnabled = true;
            this.lst_Phai.ItemHeight = 18;
            this.lst_Phai.Location = new System.Drawing.Point(348, 37);
            this.lst_Phai.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Phai.Name = "lst_Phai";
            this.lst_Phai.Size = new System.Drawing.Size(188, 310);
            this.lst_Phai.TabIndex = 0;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(239, 55);
            this.btnQuaPhai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(66, 32);
            this.btnQuaPhai.TabIndex = 1;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnPhaiALL
            // 
            this.btnPhaiALL.Location = new System.Drawing.Point(239, 115);
            this.btnPhaiALL.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhaiALL.Name = "btnPhaiALL";
            this.btnPhaiALL.Size = new System.Drawing.Size(66, 32);
            this.btnPhaiALL.TabIndex = 1;
            this.btnPhaiALL.Text = ">>";
            this.btnPhaiALL.UseVisualStyleBackColor = true;
            this.btnPhaiALL.Click += new System.EventHandler(this.btnPhaiALL_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(239, 172);
            this.btnQuaTrai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(66, 32);
            this.btnQuaTrai.TabIndex = 1;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaTraiALL
            // 
            this.btnQuaTraiALL.Location = new System.Drawing.Point(239, 232);
            this.btnQuaTraiALL.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuaTraiALL.Name = "btnQuaTraiALL";
            this.btnQuaTraiALL.Size = new System.Drawing.Size(66, 32);
            this.btnQuaTraiALL.TabIndex = 1;
            this.btnQuaTraiALL.Text = "<<";
            this.btnQuaTraiALL.UseVisualStyleBackColor = true;
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 372);
            this.Controls.Add(this.btnQuaTraiALL);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnPhaiALL);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.lst_Phai);
            this.Controls.Add(this.lst_Trai);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListBox";
            this.Text = "Sử dụng Listbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Trai;
        private System.Windows.Forms.ListBox lst_Phai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnPhaiALL;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiALL;
    }
}

