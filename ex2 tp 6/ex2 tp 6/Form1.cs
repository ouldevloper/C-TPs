using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ex2_tp_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("pour enregistre tapper le button ok ");
                ListViewGroup g1 = new ListViewGroup();
              //  g1.Header = combogeure.SelectedItem.ToString();
                g1.Header = combogeure.Text;
                listView1.Groups.Add(g1);

                ListViewItem a1 = new ListViewItem();
                a1.Group = g1;
                a1.Text = texttitre.Text;
                a1.ImageIndex = 0;
                a1.SubItems.Add(textnomination.Text);
                a1.SubItems.Add(num1.Value.ToString());
                listView1.Items.Add(a1);
                foreach (ListViewGroup a in listView1.Groups)
                {
                  if(a.Header.Equals(combogeure.Text))
                  {
                

                      a1.Group = a;
                    
                      listView1.Items.Add(a1);
                      
                  }
                    else 
                  {
                     

                      ListViewGroup g2 = new ListViewGroup();
                      g2.Header = combogeure .Text;
                      
                      a1.Group = g2;
                      
                      listView1.Items.Add(a1);
                  }
                
                }
            }
            catch (Exception ex) {  }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////ce bout de code permet d’ouvrir un dialogue et créer une instance d’image a partir
            ////de l’image sélectionner
            //DialogResult result = openFileDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    Image img = Image.FromFile(openFileDialog1.FileName);
            //}
        }

        private void combogeure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonsmall_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void buttonlarge_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void buttondetails_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
