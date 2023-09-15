using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int selection = 0;

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

        private void addbtn_Click(object sender, EventArgs e)
        {
            this.addbtn.Visible = false;
            this.rmvbtn.Visible = false;
            this.updbtn.Visible = false;
            this.confirmbtn.Visible = true;
            this.cancelbtn.Visible = true;
            this.namelabel.Visible = true;
            this.namebox.Visible = true;
            this.amountlabel.Visible = true;
            this.amountbox.Visible = true;
            if (namebox.Modified == true)
            {
                selection = 0;
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
            this.addbtn.Visible = false;
            this.rmvbtn.Visible = false;
            this.updbtn.Visible = false;
            this.itemidlabel.Visible = true;
            this.itemidbox.Visible = true;
            this.confirmbtn.Visible = true;
            this.cancelbtn.Visible = true;
            this.namelabel.Visible = false;
            this.namebox.Visible = false;
            this.amountlabel.Visible = false;
            this.amountbox.Visible = false;
            selection = 1;

        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            this.addbtn.Visible = false;
            this.rmvbtn.Visible = false;
            this.updbtn.Visible = false;
            this.confirmbtn.Visible = true;
            this.cancelbtn.Visible = true;
            this.itemidlabel.Visible = true;
            this.itemidbox.Visible = true;
            this.namelabel.Visible = true;
            this.namebox.Visible = true;
            this.amountlabel.Visible = true;
            this.amountbox.Visible = true;
            if (namebox.Modified == true)
            {
                selection = 2;
            }
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            amountbox.ResetText();
            this.addbtn.Visible = true;
            this.rmvbtn.Visible = true;
            this.updbtn.Visible = true;
            this.itemidlabel.Visible = false;
            this.itemidbox.Visible = false;
            this.confirmbtn.Visible = false;
            this.cancelbtn.Visible = false;
            this.namelabel.Visible = false;
            this.namebox.Visible = false;
            this.amountlabel.Visible = false;
            this.amountbox.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void itemidlabel_Click(object sender, EventArgs e)
        {

        }

        private void itemIDupdown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (selection == 0)
            {
                if (string.IsNullOrWhiteSpace(namebox.Text))
                    MessageBox.Show("Error! The name should not be empty!!!");
                else
                if (namelist.Items.Contains(namebox.Text))
                    MessageBox.Show("Error! You cannot add that item. Item already exists!");
                else
                if (string.IsNullOrWhiteSpace(amountbox.Text))
                {
                    MessageBox.Show("Error! The item amount should not be empty!");
                }
                else
                if (int.Parse(amountbox.Text).Equals(0))
                {
                    MessageBox.Show("Error! The item amount should exceed 0");
                }
                else
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
            if (selection == 1)
            {
                if (string.IsNullOrWhiteSpace(itemidbox.Text))
                    MessageBox.Show("Error! The ID box should not be empty!!!");
                else
                if (!idlist.Items.Contains(int.Parse(itemidbox.Text)))
                    MessageBox.Show("Error! You cannot remove something that does not exists!");
                else
                {
                    idlist.Items.RemoveAt(int.Parse(itemidbox.Text));
                    namelist.Items.RemoveAt(int.Parse(itemidbox.Text));
                    stocklist.Items.RemoveAt(int.Parse(itemidbox.Text));
                    idlist.ResetText();
                    namelist.Update();
                    stocklist.Update();
                    namebox.Clear();
                    amountbox.ResetText();
                    id++;
                }
            }
            else if (selection == 2)
            {
                if (string.IsNullOrWhiteSpace(namebox.Text))
                {
                    MessageBox.Show("Error! The name should not be empty!!!");
                }
                else if (namelist.Items.Contains(namebox.Text))
                {
                    MessageBox.Show("Error! You cannot add that item. Item already exists!");
                }
                else if (string.IsNullOrWhiteSpace(amountbox.Text))
                {
                    MessageBox.Show("Error! The item amount should not be empty!");
                }
                else if (int.Parse(amountbox.Text) <= 0)
                {
                    MessageBox.Show("Error! The item amount should exceed 0");
                }
                else
                {
                    int index = namelist.Items.IndexOf(namebox.Text);
                    if (index != -1)
                    {
                        stocklist.Items[index] = amountbox.Text;
                    }
                    else
                    {
                        idlist.Items.Add(itemidbox);
                        namelist.Items.Add(namebox.Text);
                        stocklist.Items.Add(amountbox.Text);
                        id++;
                    }

                    namebox.Clear();
                    amountbox.ResetText();
                }
                /*
                if (string.IsNullOrWhiteSpace(namebox.Text))
                    MessageBox.Show("Error! The name should not be empty!!!");
                else
                if (namelist.Items.Contains(namebox.Text))
                    MessageBox.Show("Error! You cannot add that item. Item already exists!");
                else
                if (string.IsNullOrWhiteSpace(amountbox.Text))
                {
                    MessageBox.Show("Error! The item amount should not be empty!");
                }
                else
                if (int.Parse(amountbox.Text).Equals(0))
                {
                    MessageBox.Show("Error! The item amount should exceed 0");
                }
                else
                {
                    idlist.Items.Add(itemidbox);
                    namelist.Items.Add(namebox.Text);
                    stocklist.Items.Add(amountbox.Text);
                    namebox.Clear();
                    amountbox.ResetText();
                    id++;
                }*/
            }
            else
            {
                /*this.addbtn.Visible = true;
                this.rmvbtn.Visible = true;
                this.updbtn.Visible = true;
                this.confirmbtn.Visible = false;
                this.cancelbtn.Visible = false;
                this.namelabel.Visible = false;
                this.namebox.Visible = false;
                this.amountlabel.Visible = false;
                this.amountbox.Visible = false;*/
            }
            this.addbtn.Visible = true;
            this.rmvbtn.Visible = true;
            this.updbtn.Visible = true;
            this.itemidlabel.Visible = false;
            this.itemidbox.Visible = false;
            this.confirmbtn.Visible = false;
            this.cancelbtn.Visible = false;
            this.namelabel.Visible = false;
            this.namebox.Visible = false;
            this.amountlabel.Visible = false;
            this.amountbox.Visible = false;
        }

        private void idlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
