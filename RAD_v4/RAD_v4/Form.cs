using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Windows.Forms;

namespace Boundary
{
    public class Form : System.Windows.Forms.Form
    {
        //LogoutControl logoutCtrl;

        //public Form(LogoutControl logoutCtrl)
        //{
        //    this.logoutCtrl = logoutCtrl;
        //}

        public Form() { }

        public void Logout()
        {
            string n = "";
            LogoutControl.Logout(n);
            Close();
        }

        public void Close()
        {
            //Application.ExitThread();
        }
    }
}
