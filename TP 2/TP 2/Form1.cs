using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(t1.Text.Length > 0){
                b2.Enabled = true;
            }
            else if (t2.Text.Length == 0)
            {
                b2.Enabled = false;
            }
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void l4_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Multiplication_CheckedChanged(object sender, EventArgs e)
        {
            if(Multiplication.Checked){
                l4.Text = "*";
                t2.Enabled = true;
            }
        }

        private void operation_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Soustraction_CheckedChanged(object sender, EventArgs e)
        {
            if (Soustraction.Checked) {
                l4.Text = "-";
                t2.Enabled = true;
            }
        }

        private void addition_CheckedChanged(object sender, EventArgs e)
        {
            if (addition.Checked)
            {
                l4.Text = "+";
                t2.Enabled = true;
            }
        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {
            if(Division.Checked){
                l4.Text="/";
                t2.Enabled = true;
            }
        }

        private void Racinecarré_CheckedChanged(object sender, EventArgs e)
        {
            if (Racinecarré.Checked) {
                l4.Text = "sqrt";
                t2.Clear();
                t3.Clear();
                b2.Enabled = true;
                t2.Enabled = false;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (addition.Checked) { 
                t3.Text = (Convert.ToInt32(t1.Text) + Convert.ToInt32(t2.Text)).ToString();
            }
            else if (Soustraction.Checked) {
                t3.Text = (Convert.ToInt32(t1.Text) - Convert.ToInt32(t2.Text)).ToString();
            }
            else if (Multiplication.Checked) {
                t3.Text = (Convert.ToInt32(t1.Text) * Convert.ToInt32(t2.Text)).ToString();
            }
            else if (Division.Checked)
            {
                if (Convert.ToInt32(t2.Text) > 0)
                {
                    t3.Text = (Convert.ToInt32(t1.Text) / Convert.ToInt32(t2.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Please the secound number must be creater than zero", "remamber", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                if (Convert.ToDouble(t1.Text) > 0)
                {
                    t3.Text = (Math.Sqrt(Convert.ToDouble(t1.Text))).ToString();
                }
                else {
                    MessageBox.Show("Please the number must be creater than zero", "remamber", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(t1.Text.Length.ToString());
            if ((t1.Text.Length == 1 || t1.Text.Equals("")) && Racinecarré.Checked==false)
            {
                b2.Enabled = false;
            }
            else if (Racinecarré.Checked)
            {
                b2.Enabled = true;
            }
        }
    }
}
