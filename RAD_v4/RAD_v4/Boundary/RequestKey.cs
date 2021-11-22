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
    public partial class RequestKey : Form
    {
        private KeyList KList;
        Boundary.RequestKeyForm rkf;
        //Object selectedKey;

        public RequestKey(Boundary.RequestKeyForm reqForm)
        {
            InitializeComponent();
            this.rkf = reqForm;
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
            //rkf = new Boundary.RequestKeyForm(u, kList);
        }

        private void KeysList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequestKey_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Close();
            rkf.Submit(KList.Keys[KeyList.SelectedIndex]);

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
           Close();
           Controller.LogoutControl.Logout(rkf.user.UName);
        }

        private void KeyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedKey = sender;
        }

        private void KeyList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
