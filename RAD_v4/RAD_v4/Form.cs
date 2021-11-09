using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerObjects;

namespace BoundaryObjects
{
    public class Form
    {
        LogoutControl logoutCtrl;

        public Form(LogoutControl logoutCtrl)
        {
            this.logoutCtrl = logoutCtrl;
        }

        public Form() { }

        public void Logout()
        {
            string n = "";
            logoutCtrl.Logout(n);
            Close();
        }

        public void Close()
        {

        }
    }
}
