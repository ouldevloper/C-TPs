using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3_exe_2
{
    public partial class dia : Form
    {
        public dia()
        {
            InitializeComponent();
        }

        private void Afficher_CheckedChanged(object sender, EventArgs e)
        {
            if (Afficher.Checked)
            {
                this.Height = 200;
                Coleurs.Visible = true;
                
            }
            else {
                this.Height = 80;
                Coleurs.Visible = false;
                this.BackColor = Control.DefaultBackColor;
            }
        }

        private void Quiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (Rouge.Checked) {
                this.BackColor = System.Drawing.Color.Red;
            }
        }

        private void vert_CheckedChanged(object sender, EventArgs e)
        {
            if (vert.Checked) {
                this.BackColor = System.Drawing.Color.Green;    
            }
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue.Checked) {
                this.BackColor = System.Drawing.Color.Blue;        
            }
        }
    }
}
