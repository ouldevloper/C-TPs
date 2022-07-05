using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_4_exe_1
{
    public partial class myform : Form
    {
        public myform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void selectindex_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            item.Text = (mylist.Items.Count-1).ToString();
            selectindex.Text = (mylist.SelectedIndex+1).ToString();
            t.Text = mylist.SelectedItem.ToString();

        }

        private void t_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void myform_Load(object sender, EventArgs e)
        {

        }
    }
}
