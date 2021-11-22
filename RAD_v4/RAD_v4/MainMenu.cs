using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;

namespace Boundary
{
    class MainMenu : Form // mainly serves to pick which form is opened
    {
        public void Open(User u, KeyList kList) 
        {
            // opens appropriate menu
            if(u.Type ==  User.AcctType.Customer)
            {
                RequestKeyForm rkf = new RequestKeyForm(u, kList);
            }
            else
            {
                ManageKeyForm mkf = new ManageKeyForm(u,kList);
                mkf.TopMost = true;
                mkf.Visible = true;
                //mkf.Open(kList);
            }
            //Close();
        }
    }
}
