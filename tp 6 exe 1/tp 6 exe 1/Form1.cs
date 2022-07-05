using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_6_exe_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (nup1.Value - nup2.Value >= 0)
            {
                nper.Text = (nup1.Value - nup2.Value).ToString();
                nper.Visible = true;
            }
            else {
                nper.Visible = false;
            }
        }

        private void nup2_ValueChanged(object sender, EventArgs e)
        {
            if (nup1.Value - nup2.Value >= 0)
            {
                nper.Text = (nup1.Value - nup2.Value).ToString();
                nper.Visible = true;
            }
            else
            {
                nper.Visible = false;
            }
        }

        private void d1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d= DateTime.Now;
            d1.MinDate = d;
            if (d2.Value.CompareTo(d1.Value) > 0)
            {
                dd.Text = d2.Value.Subtract(d1.Value).TotalDays.ToString();
            }
            else {
               // MessageBox.Show("please your first date must be bigger than a secound date","Inform",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            

        }

        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("vous étes sure!!", "inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (a == DialogResult.OK)
            {
                ListViewItem ls = new ListViewItem();
                ls.Text = txt1.Text;
                //ls.SubItems.Add(txt1.Text);
                lv.Items.Add(ls);
                ls.SubItems.Add(d1.Text);
                ls.SubItems.Add(d2.Text);
                ls.SubItems.Add((nup1.Value).ToString());
                ls.SubItems.Add((nup2.Value).ToString());
                txt1.Clear();
                dd.Text = "";
                nper.Text = "";
                nup1.Value = nup1.Minimum;
                nup2.Value = nup2.Minimum;
               
            }
            else {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text.Length > 0)
            {
                ok.Enabled = true;
            }
            else {
                ok.Enabled = false;
            }
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            this.Text = txt1.Text;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem r in lv.CheckedItems)
            {
                r.Remove();

            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void d2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            d2.MinDate = d;
            if (d2.Value.CompareTo(d1.Value) > 0)
            {
                dd.Text = d2.Value.Subtract(d1.Value).TotalDays.ToString();
            }
            else
            {
                //MessageBox.Show("please your first date must be bigger than a secound date", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
