using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_4_exe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
        }

        private void Removeall_Click(object sender, EventArgs e)
        {

        }

        private void addtolist_Click(object sender, EventArgs e)
        {
            if (list1.SelectedItem != null) {
                list2.Items.Add(list1.SelectedItem.ToString());
                list1.Items.Remove(list1.SelectedItem.ToString());
            }
            
        }

        private void removefromlist_Click(object sender, EventArgs e)
        {
            if (list2.SelectedItem != null)
            {
                list1.Items.Add(list2.SelectedItem.ToString());
                list2.Items.Remove(list2.SelectedItem.ToString());
            }
        }

        private void addalltolist_Click(object sender, EventArgs e)
        {
            
            foreach(string a in list1.Items){
                list2.Items.Add(a);
            }
            list1.Items.Clear();
        }

        private void removetolist_Click(object sender, EventArgs e)
        {
            foreach (string a in list2.Items)
            {
                list1.Items.Add(a);
            }
            list2.Items.Clear();
        }

        private void atoz_Click(object sender, EventArgs e)
        {
            if (list1.SelectedIndex != null) {
                int i = list1.SelectedIndex;
                string val = list1.Items[i].ToString();
                //string val2=list1.Items.IndexOf(i-1).ToString();
                list1.Items[i] = list1.Items[i - 1].ToString();
                list1.Items[i - 1] = val;
                if (list1.SelectedIndex != 0)
                {
                    list1.SelectedIndex--;
                }
                list1.Sorted = false;
            }
        }

        private void atoz1_Click(object sender, EventArgs e)
        {
            if (list2.Items.Count > 0)
            {
                if (!list2.Sorted)
                {
                    list2.Sorted = true;
                }
            }
        }

        private void AZ_Click(object sender, EventArgs e)
        {
            //if (list1.Items.Count > 0)
            //{
            //    if (!list1.Sorted)
            //    {
            //        list1.Sorted = true;
            //    }
            //}


            if (list1.Items.Count > 0)
            {
                bool s;
                do
                {
                    int counter = list1.Items.Count - 1;
                    s = false;
                    while (counter > 0)
                    {

                        if (list1.Items[counter].ToString().CompareTo(list1.Items[counter - 1].ToString()) < 0)
                        {
                            object t = list1.Items[counter];
                            list1.Items[counter] = list1.Items[counter - 1];
                            list1.Items[counter - 1] = t; s = true;
                        }
                        counter--;
                    }
                } while (s == true);
            }
        }

        private void ZA_Click(object sender, EventArgs e)
        {
            if (list1.Items.Count > 0)
            {
                bool s;
                do{
                    int counter = list1.Items.Count - 1;
                    s = false;
                    while(counter>0){
                   
                    if (list1.Items[counter].ToString().CompareTo(list1.Items[counter - 1].ToString()) > 0)
                    {
                        object t = list1.Items[counter];
                        list1.Items[counter] = list1.Items[counter - 1];
                        list1.Items[counter - 1] = t; s = true;
                    }
                    counter--;
                    }
                }while(s == true);
            }
        }

        private void AZ1_Click(object sender, EventArgs e)
        {
            if (list2.Items.Count > 0)
            {
                if (!list2.Sorted)
                {
                    list2.Sorted = true;
                }
            }
        }

        private void ztoa_Click(object sender, EventArgs e)
        {
            if(list1.SelectedIndex != null){
                int i = list1.SelectedIndex;
                string val = list1.Items[i].ToString();
                //string val2=list1.Items.IndexOf(i-1).ToString();
                list1.Items[i] = list1.Items[i + 1].ToString();
                list1.Items[i+1] = val;
                if (list1.SelectedIndex != list1.Items.Count)
                {
                    list1.SelectedIndex++;
                }
            }
            
        }
    }
}
