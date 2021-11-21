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
        private System.Windows.Forms.CheckedListBox KeysList;
        private System.Windows.Forms.CheckedListBox KeyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;

        //ManageControl mc;
        private User cUser;

        public ManageKeyForm(User u ,Entity.KeyList kList)
        {
            AddKeys(kList);
            cUser = u;
            InitializeComponent();
            //mc = new ManageControl();
        }

        public void AddKeys(Entity.KeyList kList)
        {
            foreach (Entity.Key k in kList.Keys)
            {
                KeysList.Items.Add(k);
            }
        }
        public void Submit()
        {
            int k = 0;
            Display(ManageControl.GetStatus(k));
        }

        public void Save(int index,StatusType status)
        {

            KeyStatus k = new KeyStatus(index,status);
            ManageControl.Update(k);
            Display(k);
        }

        //public void Close() { }

        public void Display(KeyStatus k)
        {

        }

        private void InitializeComponent()
        {
            this.KeysList = new System.Windows.Forms.CheckedListBox();
            this.KeyStatus = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeysList
            // 
            this.KeysList.FormattingEnabled = true;
            this.KeysList.Location = new System.Drawing.Point(72, 81);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(120, 89);
            this.KeysList.TabIndex = 0;
            this.KeysList.SelectedIndexChanged += new System.EventHandler(this.KeysList_SelectedIndexChanged);
            // 
            // KeyStatus
            // 
            this.KeyStatus.FormattingEnabled = true;
            this.KeyStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Assigned"});
            this.KeyStatus.Location = new System.Drawing.Point(72, 277);
            this.KeyStatus.Name = "KeyStatus";
            this.KeyStatus.Size = new System.Drawing.Size(120, 89);
            this.KeyStatus.TabIndex = 1;
            this.KeyStatus.SelectedIndexChanged += new System.EventHandler(this.KeyStatus_SelectedIndexChanged);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageKeyForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeysList);
            this.Controls.Add(this.KeyStatus);
            this.Name = "ManageKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Save(KeysList.SelectedIndex, (StatusType)KeyStatus.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogoutControl.Logout(cUser.UName);
        }

        private void KeyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KeysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = KeysList.SelectedItem.ToString();
        }
    }
}
