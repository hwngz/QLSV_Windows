using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1225_.NET_LAB05
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            
            //string s = lst_Trai.SelectedItem.ToString();
            lst_Phai.Items.Add(lst_Trai.SelectedItem);
            lst_Trai.Items.Remove(lst_Trai.SelectedItem);
        }

        private void btnPhaiALL_Click(object sender, EventArgs e)
        {
            //Dua tat ca cac phan tu tu Listbox Phai qua Trai
            lst_Phai.Items.AddRange(lst_Trai.Items);
            //Delete all items lstTrai
            lst_Trai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            lst_Trai.Items.Add(lst_Phai.SelectedItem);
            lst_Phai.Items.RemoveAt(lst_Phai.SelectedIndex);
        }
    }
}
