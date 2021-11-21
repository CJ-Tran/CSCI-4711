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
        Boundary.RequestKeyForm rkf;

        public RequestKey()
        {
            InitializeComponent();
        }

        public void AddKeys(Entity.User u, Entity.KeyList kList)
        {
            CheckedListBox.ObjectCollection keys = new CheckedListBox.ObjectCollection(KeysList);
            //keys.Clear();

            foreach (Entity.Key k in kList.Keys)
            {
                if (u.Type == Entity.User.AcctType.Admin) // can get rid of since we don't deal with admin here
                {
                    keys.Add(k);
                }
                else if (u.Type == Entity.User.AcctType.Customer && k.Status == Entity.StatusType.Available)
                {
                    keys.Add(k);
                }
            }

            rkf = new Boundary.RequestKeyForm(u, kList);
        }

        private void KeysList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequestKey_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            rkf.Submit(sender);

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Controller.LogoutControl.Logout(rkf.user.UName);
        }
    }
}
