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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.updbtn = new System.Windows.Forms.Button();
            this.rmvbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.namelist = new System.Windows.Forms.ListBox();
            this.idlist = new System.Windows.Forms.ListBox();
            this.stocklist = new System.Windows.Forms.ListBox();
            this.amountbox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.amountbox);
            this.panel1.Controls.Add(this.stocklist);
            this.panel1.Controls.Add(this.idlist);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(288, 69);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(122, 20);
            this.namebox.TabIndex = 10;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // updbtn
            // 
            this.updbtn.Location = new System.Drawing.Point(313, 205);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(75, 23);
            this.updbtn.TabIndex = 9;
            this.updbtn.Text = "Update Item";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // rmvbtn
            // 
            this.rmvbtn.Location = new System.Drawing.Point(313, 176);
            this.rmvbtn.Name = "rmvbtn";
            this.rmvbtn.Size = new System.Drawing.Size(75, 23);
            this.rmvbtn.TabIndex = 8;
            this.rmvbtn.Text = "Remove Item";
            this.rmvbtn.UseVisualStyleBackColor = true;
            this.rmvbtn.Click += new System.EventHandler(this.rmvbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(313, 147);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add Item";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button3_Click);
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
            // idlist
            // 
            this.idlist.FormattingEnabled = true;
            this.idlist.Location = new System.Drawing.Point(6, 20);
            this.idlist.Name = "idlist";
            this.idlist.Size = new System.Drawing.Size(41, 290);
            this.idlist.TabIndex = 15;
            // 
            // stocklist
            // 
            this.stocklist.FormattingEnabled = true;
            this.stocklist.Location = new System.Drawing.Point(233, 20);
            this.stocklist.Name = "stocklist";
            this.stocklist.Size = new System.Drawing.Size(49, 290);
            this.stocklist.TabIndex = 16;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(288, 108);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(122, 20);
            this.amountbox.TabIndex = 17;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button rmvbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox stocklist;
        private System.Windows.Forms.ListBox idlist;
        private System.Windows.Forms.NumericUpDown amountbox;
    }
}

