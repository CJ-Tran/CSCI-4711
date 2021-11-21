using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Entity;

namespace Boundary
{
    class ManageKeyForm : Form
    {
        private System.Windows.Forms.CheckedListBox KeyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ListBox KeysList;
        private System.Windows.Forms.Label label3;

        //ManageControl mc;

        public ManageKeyForm()
        {
            InitializeComponent();
            //mc = new ManageControl();
        }

        public void AddKeys()
        {

            foreach (Entity.Key k in KeyList.Keys)
            {
                KeysList.Items.Add(k);
            }
        }
        public void Submit()
        {
            int k = 0;
            Display(ManageControl.GetStatus(k));
        }

        public void Save()
        {
            int temp = 0;
            KeyStatus k = new KeyStatus(temp);
            ManageControl.Update(k);
            Display(k);
        }

        //public void Close() { }

        public void Display(KeyStatus k)
        {

        }

        private void InitializeComponent()
        {
            this.KeyStatus = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KeyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // KeyStatus
            // 
            this.KeyStatus.FormattingEnabled = true;
            this.KeyStatus.Location = new System.Drawing.Point(72, 277);
            this.KeyStatus.Name = "KeyStatus";
            this.KeyStatus.Size = new System.Drawing.Size(120, 89);
            this.KeyStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.KeysList.FormattingEnabled = true;
            this.KeysList.ItemHeight = 16;
            this.KeysList.Location = new System.Drawing.Point(72, 81);
            this.KeysList.Name = "listBox1";
            this.KeysList.Size = new System.Drawing.Size(120, 84);
            this.KeysList.TabIndex = 8;
            // 
            // ManageKeyForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 471);
            this.Controls.Add(this.KeysList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyStatus);
            this.Name = "ManageKeyForm";
            this.Load += new System.EventHandler(this.ManageKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageKeyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
