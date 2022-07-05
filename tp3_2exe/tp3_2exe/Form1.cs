using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3_2exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {
            if (colorCB.Checked)
            {
                colorGB.Visible = true;
                this.Height = 200;
            }


            else
            { 
                colorGB.Visible = false;
                this.Height = 120;
                this.BackColor = Control.DefaultBackColor;
                black.Checked = false;
                green.Checked = false;
                blue.Checked = false;
            }
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            if (black.Checked)
                this.BackColor = Color.Black;
            else
                this.BackColor = Color.White;
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            if (blue.Checked)
                this.BackColor = Color.Blue;
            else
                this.BackColor = Color.White;
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (green.Checked)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.White;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
