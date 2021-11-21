using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Entity;
//using System.Windows.Forms;

namespace Boundary
{
    public class RequestKeyForm : Form
    {
        public User user;

        public RequestKeyForm(User u, KeyList kList)
        {
            user = u;

            RAD_v4.RequestKey rk = new RAD_v4.RequestKey(this);
            rk.AddKeys(u, kList);
            rk.Refresh();
            rk.TopMost = true;
            rk.Visible = true;
        }

        public void Submit(object sender)
        {
            bool valid = RequestControl.Reserve(user.UName, int.Parse(sender.ToString().Substring(35))); 
            if (valid)
            {
                Close();
            }
        }
    }
}
