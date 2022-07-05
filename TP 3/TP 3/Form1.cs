using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fromage_CheckedChanged(object sender, EventArgs e)
        {
            if (Fromage.Checked)
            {
                list1.Items.Add("Fromage");
            }
        }

        private void Apiritif_CheckedChanged(object sender, EventArgs e)
        {
            if (Apiritif.Checked) {
                list1.Items.Add("Apiritif");
            }
        }

        private void Patage_CheckedChanged(object sender, EventArgs e)
        {
            if (Patage.Checked)
            {
                list1.Items.Add("Patage");
            }
        }

        private void Crudités_CheckedChanged(object sender, EventArgs e)
        {
            if (Crudités.Checked)
            {
                list1.Items.Add("Crudités");
            }
        }

        private void Charcuterie_CheckedChanged(object sender, EventArgs e)
        {
            if (Charcuterie.Checked)
            {
                list1.Items.Add("Charcuterie");
            }
        }

        private void PoletRotis_CheckedChanged(object sender, EventArgs e)
        {
            if (PoletRotis.Checked)
            {
                list1.Items.Add("PoletRotis");
            }
        }

        private void Poisson_CheckedChanged(object sender, EventArgs e)
        {
            if (Poisson.Checked)
            {
                list1.Items.Add("Poisson");
            }
        }

        private void Slade_CheckedChanged(object sender, EventArgs e)
        {
            if (Slade.Checked)
            {
                list1.Items.Add("Slade");
            }
        }

        private void dessert_CheckedChanged(object sender, EventArgs e)
        {
            if (dessert.Checked)
            {
                list1.Items.Add("dessert");
            }
        }

        private void Café_CheckedChanged(object sender, EventArgs e)
        {
            if (Café.Checked)
            {
                list1.Items.Add("Café");
            }
        }

        
    }
}
