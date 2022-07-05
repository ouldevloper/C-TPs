using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4_exe_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void recherch_Click(object sender, EventArgs e)
        {
            //string r = textr.Text;
            //string pattern = "" + r + "";
            ////MessageBox.Show(pattern,"pattern");
            //Regex a = new Regex(pattern);
            //MatchCollection m = a.Matches(mylist.Items.ToString());
            //foreach(Capture o in m){
            //    int index = o.Index;
            //    try
            //    {
            //        mylist.SetSelected(index, true);
            //    }
            //    catch (Exception w) {
            //        MessageBox.Show("Please write somthing first","remamber");
            //    }
                
            //}
            //    res.Text = m.Count + " element trover";

            string recherchval = textr.Text;
            //for (int i = 0; i < mylist.Items.Count;i++ )
            //{
            //    for (int j = 0; j < recherchval.Length; j++) {
            //        for (int h = 0; h < mylist.Items[i].ToString().Length; h++) { 
            //            bool res = false;
            //            char z =
            //            if (mylist.Items[i].ToString().Contains(recherchval)) { 
                        
            //            }
            //        }
            //    }
            //}
            int[] indec = new int[20];
            int counter = 0;
            int i = 0;
            foreach (String s in mylist.Items)
            {
                if (s.Contains(recherchval) && recherchval != null)
                {
                    
                    indec[i] = mylist.Items.IndexOf(s);
                    i++;
                    // mylist.SetSelected(mylist.Items.IndexOf(s), true);

                }
                counter++;
            }
            res.Text = counter + " element trover ";
            foreach(int a in indec){
                mylist.SetSelected(a, true);
            }

        }

        private void textr_TextChanged(object sender, EventArgs e)
        {
            mylist.ClearSelected();
        }
    }
}
