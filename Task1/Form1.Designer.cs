namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemidbox = new System.Windows.Forms.NumericUpDown();
            this.itemidlabel = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.amountbox = new System.Windows.Forms.NumericUpDown();
            this.stocklist = new System.Windows.Forms.ListBox();
            this.idlist = new System.Windows.Forms.ListBox();
            this.amountlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.updbtn = new System.Windows.Forms.Button();
            this.rmvbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.namelist = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemidbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountbox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemidbox);
            this.panel1.Controls.Add(this.itemidlabel);
            this.panel1.Controls.Add(this.cancelbtn);
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.amountbox);
            this.panel1.Controls.Add(this.stocklist);
            this.panel1.Controls.Add(this.idlist);
            this.panel1.Controls.Add(this.amountlabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Controls.Add(this.updbtn);
            this.panel1.Controls.Add(this.rmvbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.namelist);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 313);
            this.panel1.TabIndex = 6;
            // 
            // itemidbox
            // 
            this.itemidbox.Location = new System.Drawing.Point(288, 133);
            this.itemidbox.Name = "itemidbox";
            this.itemidbox.Size = new System.Drawing.Size(122, 20);
            this.itemidbox.TabIndex = 22;
            this.itemidbox.Visible = false;
            this.itemidbox.ValueChanged += new System.EventHandler(this.itemIDupdown_ValueChanged);
            // 
            // itemidlabel
            // 
            this.itemidlabel.AutoSize = true;
            this.itemidlabel.Location = new System.Drawing.Point(288, 117);
            this.itemidlabel.Name = "itemidlabel";
            this.itemidlabel.Size = new System.Drawing.Size(41, 13);
            this.itemidlabel.TabIndex = 21;
            this.itemidlabel.Text = "Item ID";
            this.itemidlabel.Visible = false;
            this.itemidlabel.Click += new System.EventHandler(this.itemidlabel_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(350, 277);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(50, 23);
            this.cancelbtn.TabIndex = 20;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Visible = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(291, 277);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(53, 23);
            this.confirmbtn.TabIndex = 19;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Visible = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(288, 90);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(122, 20);
            this.amountbox.TabIndex = 17;
            this.amountbox.Visible = false;
            // 
            // stocklist
            // 
            this.stocklist.FormattingEnabled = true;
            this.stocklist.Location = new System.Drawing.Point(233, 20);
            this.stocklist.Name = "stocklist";
            this.stocklist.Size = new System.Drawing.Size(49, 290);
            this.stocklist.TabIndex = 16;
            // 
            // idlist
            // 
            this.idlist.FormattingEnabled = true;
            this.idlist.Location = new System.Drawing.Point(6, 20);
            this.idlist.Name = "idlist";
            this.idlist.Size = new System.Drawing.Size(41, 290);
            this.idlist.TabIndex = 15;
            this.idlist.SelectedIndexChanged += new System.EventHandler(this.idlist_SelectedIndexChanged);
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(288, 74);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(43, 13);
            this.amountlabel.TabIndex = 14;
            this.amountlabel.Text = "Amount";
            this.amountlabel.Visible = false;
            this.amountlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(288, 35);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 13;
            this.namelabel.Text = "Name";
            this.namelabel.Visible = false;
            this.namelabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(288, 51);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(122, 20);
            this.namebox.TabIndex = 10;
            this.namebox.Visible = false;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // updbtn
            // 
            this.updbtn.Location = new System.Drawing.Point(313, 230);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(75, 23);
            this.updbtn.TabIndex = 9;
            this.updbtn.Text = "Update Item";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // rmvbtn
            // 
            this.rmvbtn.Location = new System.Drawing.Point(313, 201);
            this.rmvbtn.Name = "rmvbtn";
            this.rmvbtn.Size = new System.Drawing.Size(75, 23);
            this.rmvbtn.TabIndex = 8;
            this.rmvbtn.Text = "Remove Item";
            this.rmvbtn.UseVisualStyleBackColor = true;
            this.rmvbtn.Click += new System.EventHandler(this.rmvbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(313, 172);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add Item";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // namelist
            // 
            this.namelist.FormattingEnabled = true;
            this.namelist.Location = new System.Drawing.Point(53, 20);
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(174, 290);
            this.namelist.TabIndex = 0;
            this.namelist.SelectedIndexChanged += new System.EventHandler(this.stocklist_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Inventory Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemidbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox namelist;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button rmvbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox stocklist;
        private System.Windows.Forms.ListBox idlist;
        private System.Windows.Forms.NumericUpDown amountbox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.NumericUpDown itemidbox;
        private System.Windows.Forms.Label itemidlabel;
    }
}

