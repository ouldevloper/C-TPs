using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_5_exe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!txt1.Text.Equals("")) {
                if (!lstlist.Items.Contains(txt1.Text))
                {
                    lstlist.Items.Add(txt1.Text);
                    txt1.Text = "";
                    txt1.Focus();
                }
                else {
                    txt1.Text = "";
                    txt1.Focus();
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstlist.Items.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstlist.SelectedIndex = Convert.ToInt32(txt2.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lstlist.Items.Clear();
            txtitem.Text = "";
            t4.Text = "";
            t5.Text = "";
            txt2.Clear();
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            
                try {
                    string val = lstlist.SelectedItem.ToString();
                    //MessageBox.Show(val);
                    lstlist.Items.Remove(val);
                }
                catch (Exception r) {
                    MessageBox.Show("Please select an Item","Inform",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            
        }

        private void lstlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstlist.Items.Count > 0)
            {
                if (lstlist.SelectedIndex > 0) {
                    txt2.Text = Convert.ToString(lstlist.SelectedIndex);
                }
                txtitem.Text = Convert.ToString(lstlist.Items.Count);
                t4.Text = Convert.ToString(lstlist.SelectedIndex);
                try
                {
                    t5.Text = lstlist.SelectedItem.ToString();
                }
                catch (Exception r) {
                    txtitem.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                }
                
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
