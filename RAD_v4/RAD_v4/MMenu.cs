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
    public partial class MMenu : Form
    {
        public MMenu()
        {
            InitializeComponent();
        }

        public void AddKeys(Entity.User u, Entity.KeyList kList)
        {
            CheckedListBox.ObjectCollection keys = new CheckedListBox.ObjectCollection(KeysList);

            foreach (Entity.Key k in kList.Keys)
            {
                if(u.Type == Entity.User.AcctType.Admin)
                {
                    keys.Add(k);
                }
                else if (u.Type == Entity.User.AcctType.Customer && k.Status == Entity.StatusType.Available)
                {
                    keys.Add(k);
                }
            }
        }

        private void KeysList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
