using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Tools tools = new Tools();
        int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(namebox.Text) && !namelist.Items.Contains(namebox.Text) && tools.isValid(namebox.Text)) {
                if (!string.IsNullOrWhiteSpace(amountbox.Text))
                {
                    idlist.Items.Add(id);
                    namelist.Items.Add(namebox.Text);
                    stocklist.Items.Add(amountbox.Text);
                    namebox.Clear();
                    amountbox.ResetText();
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
                
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stocklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rmvbtn_Click(object sender, EventArgs e)
        {

        }

        private void updbtn_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
