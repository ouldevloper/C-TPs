using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opSelectio_Click(object sender, EventArgs e)
        {
        //    if (op1.Checked)
        //    {
        //        lbchoix1.BackColor = Color.YellowGreen;
        //        lbchoix1.Text = "Bouton N 1";
        //    }

        //    if (op2.Checked)
        //    {
        //        lbchoix1.BackColor = Color.YellowGreen;
        //        lbchoix1.Text = "Bouton N 2";
        //    }
            
        //    if (op3.Checked)
        //    {
        //        lbchoix1.BackColor = Color.YellowGreen;
        //        lbchoix1.Text = "Bouton N 3";
        //    }

        //    if (opt1.Checked)
        //    {
        //        lbchoix2.BackColor = Color.YellowGreen;
        //        lbchoix2.Text = "Bouton N 1";
        //    }

        //    if (opt2.Checked)
        //    {
        //        lbchoix2.BackColor = Color.YellowGreen;
        //        lbchoix2.Text = "Bouton N 2";
        //    }

        //    if (op3.Checked)
        //    {
        //        lbchoix2.BackColor = Color.YellowGreen;
        //        lbchoix2.Text = "Bouton N 3";
        //    }

        //}

        //private void op1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (!op1.Checked)
        //    {
        //        lbchoix1.BackColor = Color.White;
        //        lbchoix1.Text = "";
        //    }
        //}

        //private void op2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (!op2.Checked)
        //    {
        //        lbchoix1.BackColor = Color.White;
        //        lbchoix1.Text = "";
        //    }
        //}

        //private void op3_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (!op3.Checked)
        //    {
        //        lbchoix1.BackColor = Color.White;
        //        lbchoix1.Text = "";
        //    }
            lbchoix1.Text=
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            if (!opt1.Checked)
            {
                lbchoix2.BackColor = Color.White;
                lbchoix2.Text = "";
            }
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            if (!opt2.Checked)
            {
                lbchoix2.BackColor = Color.White;
                lbchoix2.Text = "";
            }
        }

        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            if (!opt3.Checked)
            {
                lbchoix2.BackColor = Color.White;
                lbchoix2.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
