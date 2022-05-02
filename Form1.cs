using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3_ListWF
{
    public partial class Form1 : Form
    {
                
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> listString = new List<string>();
            listString.Add("BMW");
            listString.Add("Mercedes-Benz");
            listString.Add("Audi");
            listString.Add("Tesla");
            listString.Add("Porsche");
           
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls); 
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
            List<string> list2 = new List<string>();
            list2.Add("Lamborghini");
            list2.Add("Ferrari");
            list2.Add("Jaguar");
            list2.Add("Maserati");
            list2.Add("Bugatti");
            listString.AddRange(list2);
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
            listString.RemoveRange(2,6);
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }            
            listString.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }

        private void btnRemByName_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }
            listString.Remove(txtRemByName.Text);
            listBox1.Items.Clear();
            txtRemByName.Clear();
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }
            listString.Sort();
            listBox1.Items.Clear();
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listString.Add(listBox1.Items[i].ToString());
            }
            listString.Reverse();
            listBox1.Items.Clear();
            foreach (string ls in listString)
            {
                listBox1.Items.Add(ls);
            }
        }
    }
}
