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
        private System.Windows.Forms.ListBox KeyStatus;
        private System.Windows.Forms.Label KeyStatusLbl;
        private System.Windows.Forms.Label SelectKeyLbl;
        private System.Windows.Forms.Label SelectKeyInfo;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label KeyDetailsLbl;
        private ListBox KeysList;

        //ManageControl mc;
        private User cUser;
        private Label ManageKeysLbl;
        private KeyList KList;

        public ManageKeyForm(User u, Entity.KeyList kList)
        {

            cUser = u;
            KList = kList;
            InitializeComponent();
            AddKeys(kList);
            //mc = new ManageControl();
        }

        public void AddKeys(Entity.KeyList kList)
        {
            KeysList.Items.Clear(); //clear it of any default values before adding
            foreach (Entity.Key k in kList.Keys)
            {
                KeysList.Items.Add(k.ID); //only show KeyID in SelectKey menu
            }
        }
        public void Submit() //UNUSED
        {
            int k = 0;
            Display(ManageControl.GetStatus(k));
        }

        public void Save(int index, StatusType status)
        {

            KeyStatus k = new KeyStatus(index, status);
            ManageControl.Update(k);
            //Refresh(); 
            //Display(k); // call KeyList_SelectedIndexChanged() better?
        }

        //public void Close() { }

        public void Display(KeyStatus k) // UNUSED
        {

        }

        private void InitializeComponent()
        {
            this.KeyStatus = new System.Windows.Forms.ListBox();
            this.KeyStatusLbl = new System.Windows.Forms.Label();
            this.SelectKeyLbl = new System.Windows.Forms.Label();
            this.KeyDetailsLbl = new System.Windows.Forms.Label();
            this.SelectKeyInfo = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.KeysList = new System.Windows.Forms.ListBox();
            this.ManageKeysLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyStatus
            // 
            this.KeyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyStatus.FormattingEnabled = true;
            this.KeyStatus.ItemHeight = 20;
            this.KeyStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Assigned"});
            this.KeyStatus.Location = new System.Drawing.Point(75, 296);
            this.KeyStatus.Name = "KeyStatus";
            this.KeyStatus.Size = new System.Drawing.Size(120, 84);
            this.KeyStatus.TabIndex = 1;
            this.KeyStatus.SelectedIndexChanged += new System.EventHandler(this.KeyStatus_SelectedIndexChanged);
            // 
            // KeyStatusLbl
            // 
            this.KeyStatusLbl.AutoSize = true;
            this.KeyStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyStatusLbl.Location = new System.Drawing.Point(70, 264);
            this.KeyStatusLbl.Name = "KeyStatusLbl";
            this.KeyStatusLbl.Size = new System.Drawing.Size(132, 29);
            this.KeyStatusLbl.TabIndex = 2;
            this.KeyStatusLbl.Text = "Key Status:";
            this.KeyStatusLbl.Click += new System.EventHandler(this.KeyStatusLbl_Click);
            // 
            // SelectKeyLbl
            // 
            this.SelectKeyLbl.AutoSize = true;
            this.SelectKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectKeyLbl.Location = new System.Drawing.Point(70, 101);
            this.SelectKeyLbl.Name = "SelectKeyLbl";
            this.SelectKeyLbl.Size = new System.Drawing.Size(134, 29);
            this.SelectKeyLbl.TabIndex = 3;
            this.SelectKeyLbl.Text = "Select Key:";
            // 
            // KeyDetailsLbl
            // 
            this.KeyDetailsLbl.AutoSize = true;
            this.KeyDetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDetailsLbl.Location = new System.Drawing.Point(348, 101);
            this.KeyDetailsLbl.Name = "KeyDetailsLbl";
            this.KeyDetailsLbl.Size = new System.Drawing.Size(134, 29);
            this.KeyDetailsLbl.TabIndex = 4;
            this.KeyDetailsLbl.Text = "Key Details";
            // 
            // SelectKeyInfo
            // 
            this.SelectKeyInfo.AutoSize = true;
            this.SelectKeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectKeyInfo.Location = new System.Drawing.Point(349, 142);
            this.SelectKeyInfo.Name = "SelectKeyInfo";
            this.SelectKeyInfo.Size = new System.Drawing.Size(117, 20);
            this.SelectKeyInfo.TabIndex = 5;
            this.SelectKeyInfo.Text = "(Select a key...)";
            this.SelectKeyInfo.Click += new System.EventHandler(this.SelectKeyInfo_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(353, 335);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(83, 45);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(545, 335);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(83, 45);
            this.LogoutBtn.TabIndex = 7;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // KeysList
            // 
            this.KeysList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeysList.FormattingEnabled = true;
            this.KeysList.ItemHeight = 20;
            this.KeysList.Items.AddRange(new object[] {
            "roomKey"});
            this.KeysList.Location = new System.Drawing.Point(75, 142);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(129, 84);
            this.KeysList.TabIndex = 8;
            this.KeysList.SelectedIndexChanged += new System.EventHandler(this.KeysList_SelectedIndexChanged_1);
            // 
            // ManageKeysLbl
            // 
            this.ManageKeysLbl.AutoSize = true;
            this.ManageKeysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageKeysLbl.Location = new System.Drawing.Point(69, 49);
            this.ManageKeysLbl.Name = "ManageKeysLbl";
            this.ManageKeysLbl.Size = new System.Drawing.Size(172, 31);
            this.ManageKeysLbl.TabIndex = 9;
            this.ManageKeysLbl.Text = "ManageKeys";
            // 
            // ManageKeyForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 471);
            this.Controls.Add(this.ManageKeysLbl);
            this.Controls.Add(this.KeysList);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SelectKeyInfo);
            this.Controls.Add(this.KeyDetailsLbl);
            this.Controls.Add(this.SelectKeyLbl);
            this.Controls.Add(this.KeyStatusLbl);
            this.Controls.Add(this.KeyStatus);
            this.Name = "ManageKeyForm";
            this.Load += new System.EventHandler(this.ManageKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save(KeysList.SelectedIndex, (StatusType)KeyStatus.SelectedIndex);
            Refresh();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
            LogoutControl.Logout(cUser.UName);
        }

        private void KeyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void SelectKeyInfo_Click(object sender, EventArgs e)
        {

        }

        private void KeysList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectKeyInfo.Text = KList.Keys[KeysList.SelectedIndex].ToString(); //use ToString to display all info
        }

        private void KeyStatusLbl_Click(object sender, EventArgs e)
        {

        }

        private void ManageKeyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
