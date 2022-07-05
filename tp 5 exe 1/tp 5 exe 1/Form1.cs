using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_5_exe_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch1.Checked)
            {
                mylist.SelectionMode = SelectionMode.MultiExtended;
            }
            else {
                mylist.SelectionMode = SelectionMode.One;
            }
        }

        private void lcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = lcheck.CheckedItems.Count;
            lres.Text = Convert.ToString(sum)+" element(s) cochee(s)";
            foreach (string m in lcheck.CheckedItems)
            {
                if (Mois.Items.Contains(m))
                {
                    Mois.Items.Remove(m);
                }
                Mois.Items.Add(m);
            }
            for (int i = 0; i < lcheck.Items.Count;i++ ) {
                if(lcheck.GetItemCheckState(i) == CheckState.Unchecked){
                    Mois.Items.Remove(lcheck.Items[i]);
                }
            }
            
        }

        private void mylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string m in mylist.SelectedItems)
            {
                
                if (mylist.SelectionMode == SelectionMode.One)
                {
                    Mois.Items.Clear();
                    Mois.Items.Add(m);
                }
                else if (mylist.SelectionMode == SelectionMode.MultiExtended)
                {
                    if (!Mois.Items.Contains(m))
                    {
                        Mois.Items.Add(m);
                    }
                }
                
                //if (!Mois.Items.Contains(m))
                //{
                //    Mois.Items.Add(m);
                //}
            }
           

            
        }

        private void lcheck_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void com_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                foreach(string m in com.Items){
                 if(Mois.Items.Contains(m)){
                     Mois.Items.Remove(m);
                 }   
                }
                Mois.Items.Add(com.SelectedItem.ToString());
            }

        private void Mois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
        }
    
}
