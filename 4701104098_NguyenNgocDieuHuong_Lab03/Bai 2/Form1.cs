using System;
using System.Windows.Forms;

namespace Bài_tập_về_nhà_winfom
{
    public partial class Form1 : Form
    {
        bool emailCheck = false;
        bool accountCheck = false;
        bool passCheck = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string output = "Your Account Name: " + txtAccount.Text;
            output += "\nYour Password: " + txtPass.Text;
            if (txtPass.Text != txtPassConfirm.Text)
                MessageBox.Show("Please Enter Your Password Again", "Password Not Correctly !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (!accountCheck)
                MessageBox.Show("Please Enter Your Account Name", "Account Name Not Correctly !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (!emailCheck)
                MessageBox.Show("Please Enter Your Email Again", "Email Not Correctly !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (!passCheck)
                MessageBox.Show("Please Enter Your Email", "Password Not Correctly !!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                MessageBox.Show(output, "SIGN UP SUCCESSFULLY");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            //@gmail.com
            string tmp = "";
            if (ctr.Text.Length >= 10)
                tmp = ctr.Text.Substring(ctr.Text.Length - 10);
            if (tmp != "@gmail.com" || ctr.Text.Length < 10)
                this.errorProvider.SetError(ctr, "Correct Format is xxx@gmail.com");
            else
            {
                this.errorProvider.Clear();
                emailCheck = true;
            }
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider.SetError(ctr, "Please Enter Your Account Name !!!");
            else
            {
                this.errorProvider.Clear();
                accountCheck = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtPass.Text.Trim().Length == 0)
                this.errorProvider.SetError(ctr, "Please Enter Your Password !!!");
            else
            {
                this.errorProvider.Clear();
                passCheck = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("DO YOU WANT TO EXIT?", "EIXT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
