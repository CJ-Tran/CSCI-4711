using Controller;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_v4
{
    public partial class RequestKeyForm : Form
    {
        /* Class Variables */
        public User user;
        private KeyList KList;

        /* Methods */
        public void Submit(Entity.Key k)
        {
            bool valid = RequestControl.Reserve(user.UName, k.ID);
            if (valid)
            {
                Close();
            }
        }

        public void AddKeys(Entity.User u, Entity.KeyList kList)
        {
            List<Key> temp = new List<Key>();
            foreach (Entity.Key k in kList.Keys)
            {
                if (k.Status == Entity.StatusType.Available)
                {
                    this.KeyList.Items.Add(k.ID);
                    temp.Add(k);
                }
            }
            KList = new KeyList(temp);
        }
        
        /* Constructor & UI Elements */
        public RequestKeyForm(User u, KeyList kList)
        {
            user = u;

            InitializeComponent();
            AddKeys(u, kList);
            Refresh();
            TopMost = true;
            Visible = true;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Close();
            this.Submit(KList.Keys[KeyList.SelectedIndex]);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
            Controller.LogoutControl.Logout(this.user.UName);
        }

        private void KeysList_SelectedIndexChanged(object sender, EventArgs e) { }

        private void RequestKey_Load(object sender, EventArgs e) { }

        private void KeyList_SelectedIndexChanged(object sender, EventArgs e) { }

        private void KeyList_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}
