using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_5_exe_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<Produit, double> produittable = new Dictionary<Produit, double>();
        private void Form1_Load(object sender, EventArgs e)
        {
            couleur.Items.Add("red");
            couleur.Items.Add("green");
            couleur.Items.Add("blue");
            ccouleur.Items.Add("red");
            ccouleur.Items.Add("green");
            ccouleur.Items.Add("blue");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            

            string name = txt1.Text;
            string c = couleur.SelectedItem.ToString();
            int count = (int)nud1.Value;
            double prix = (double)nud2.Value;
            produittable.Add(new Produit(name,c,count),prix);
            carticle.Items.Add(name);
            
        }

        private void carticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string art = carticle.SelectedItem.ToString();
            foreach (Produit p in produittable.Keys) {
                if (p.Name.Equals(art)) {
                    ccouleur.SelectedItem = p.Couleur.ToString();
                }
            }
        }

        private void nud1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud3_ValueChanged(object sender, EventArgs e)
        {
            mantant.Text = ((int)nud3.Value * (double)nud2.Value).ToString() + " DH";
        }
    }
}
