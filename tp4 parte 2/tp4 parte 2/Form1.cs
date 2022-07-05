using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace tp4_parte_2
{
    public partial class Form1 : Form
    {
        List<string> l = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);

                //int i=listBox1.SelectedIndex;

                //    if(i>0)
                //    {
                //        listBox2.Text = listBox1.Items[i].ToString();
                //    }
            }
            catch (Exception ex) { MessageBox.Show("plz selected your chois tanks !!", "MESSAGE3"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception x) { MessageBox.Show("plz selected your chois tanks !!", "MESSAGE3"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i].ToString());


                }
                listBox1.Items.Clear();
            }
            catch (Exception ex) { MessageBox.Show("plz selected your chois tanks !!", "MESSAGE3"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i].ToString());
                }
                listBox2.Items.Clear();
            }
            catch (Exception ex) { MessageBox.Show("plz selected your chois tanks !!", "MESSAGE3"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // string a, b;
            /*  if (listBox1.SelectedIndex.Equals(true))
              {
                  l.Add(listBox1.SelectedIndex);
                

                  l.Sort();
                  listBox1.Items.Add(l.ToString());
              }*/
            int i; 
            string b;
            i = listBox1.SelectedIndex;
            try
            {
                 b = listBox1.SelectedItem.ToString();
            
            listBox1.Items[i] = listBox1.Items[i - 1].ToString();
            listBox1.Items[i - 1] = b;
            }
            catch (Exception ex) { MessageBox.Show("selected one elements"); }
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex--;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* for (int i = 0; i < listBox1.Items.Count; i++)
             {
                 listBox1.Items.Insert( i+1, listBox1.SelectedItem);
                 listBox1.Items.Remove(listBox1.SelectedItem);
             }*/

            int i; string b;
            try
            {
            i = listBox1.SelectedIndex;
            b = listBox1.SelectedItem.ToString();
            //if (listBox1.SelectedIndex != null)
            //{
            listBox1.Items[i] = listBox1.Items[i + 1].ToString();
            listBox1.Items[i + 1] = b;
            }
            catch (Exception ex) { MessageBox.Show("selected one elements"); }
            //  }
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex++;
            }
            /*listBox1.Items.RemoveAt(i);
            listBox1.Items.Insert(listBox1.Items.Count + 1, a.ToString());*/
            // listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*  for (int i = 0; i < listBox1.Items.Count; i++)
              {
                  listBox1.Items[i--].ToString();
              }*/

            listBox1.Sorted = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
             /* listBox1.Sorted = true;
             for (int i = listBox1.Items.Count-1; i > 0; i--)
             {

                 l.Add(listBox1.Items[i].ToString());

             }
             foreach (string item in  l)
             {
                 listBox1.Items.Add(item.ToString()); 
             }*/
            bool s;
            do
            {
                int counter = listBox1.Items.Count - 1;
                s = false;
                while (counter > 0)
                {
                    if (listBox1.Items[counter].ToString().CompareTo(listBox1.Items[counter - 1].ToString()) > 0)
                    {
                        object t = listBox1.Items[counter];
                        listBox1.Items[counter] = listBox1.Items[counter - 1];
                        listBox1.Items[counter - 1] = t;
                        s = true;
                    }
                    counter--;
                }
            } while (s == true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i; string b;
            try
            {
              i = listBox2.SelectedIndex;
              b = listBox2.SelectedItem.ToString();
              listBox2.Items[i] = listBox2.Items[i - 1].ToString();
              listBox2.Items[i - 1] = b;
            }
            catch (Exception ex) { MessageBox.Show("selected one elements"); }
              if (listBox2.SelectedIndex > 0)
              {
                  listBox2.SelectedIndex--;
              }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i; string b;
            try
            {
            i = listBox2.SelectedIndex;
            b = listBox2.SelectedItem.ToString();
            listBox2.Items[i] = listBox2.Items[i + 1].ToString();
            listBox2.Items[i + 1] = b;
            }
            catch (Exception ex) { MessageBox.Show("selected one elements"); }
            if (listBox2.SelectedIndex > 0)
            {
                listBox2.SelectedIndex++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool s;
            do
            {
                int counter = listBox1.Items.Count - 1;
                s = false;
                while (counter > 0)
                {
                    if (listBox1.Items[counter].ToString().CompareTo(listBox1.Items[counter - 1].ToString()) > 0)
                    {
                        object t = listBox1.Items[counter];
                        listBox1.Items[counter] = listBox1.Items[counter - 1];
                        listBox1.Items[counter - 1] = t;
                        s = true;
                    }
                    counter--;
                }
            } while (s == true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("au revoir !!");
            Close();
        }
    }

}