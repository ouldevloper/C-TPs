using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3_exe_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choix1_Enter(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            foreach (RadioButton r in choix1.Controls)
            {
                if (r.Checked)
                    label1.Text = r.Tag.ToString();
            }
            foreach (RadioButton r in Choix2.Controls)
            {
                if (r.Checked)
                    label2.Text = r.Tag.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
