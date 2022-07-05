using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace tp4_parte_2
{
  
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           // //Regex l = new Regex(maylist.Text);
           // Regex l = new Regex(@""+res+"");
           // MatchCollection m = l.Matches (maylist.Items.ToString());
           // foreach (Match x in m)
           // {
           //    // for (int i = 0; i < this.maylist.Items.Count; i++)
           //         //if(Match x 

           //     foreach (Capture c in x.Captures)
           //     {
           //         int n = c.Index;

           //         // string n = c.Value.ToString();
           //         // maylist.SetSelected(n, true);
           //         labres.Text = n.ToString() + " element ";
           //         //  labres.Text = c.Value.ToString();
           //     }
                    
                
           // }
           //// if(m.Value)
           // //for (int i=0; i < listBox1.Items.Count; i++)
           // //{
                 
           // //   // listBox1.StartsWith(textBox1.Text);
                
           // //}
           /* string res = txtrech.Text;
            List<int> lselectedIndex=new List<int>();
            foreach (string s in maylist.Items)
            {
                if(s.Contains(res))
                    lselectedIndex.Add(maylist.Items.IndexOf(s));
            }

            foreach (int i in lselectedIndex)
            {
                maylist.SetSelected(i, true);
               // MessageBox.Show(i.ToString());
            }
            labres.Text = lselectedIndex.Count.ToString();*/

        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            string res = txtrech.Text;
            List<int> lselectedIndex = new List<int>();
            foreach (string s in maylist.Items)
            {
                if (s.Contains(res))
                    lselectedIndex.Add(maylist.Items.IndexOf(s));
            }

            foreach (int i in lselectedIndex)
            {
                maylist.SetSelected(i, true);
                // MessageBox.Show(i.ToString());
            }
            labres.Text = lselectedIndex.Count.ToString();
            if (txtrech.Text == "") {  }
            
        }
        
        
    }
}
