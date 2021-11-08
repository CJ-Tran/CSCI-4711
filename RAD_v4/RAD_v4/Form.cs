using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    public class Form
    {
        ControllerObjects.LogoutControl logoutCtrl;

        public Form(ControllerObjects.LogoutControl logoutCtrl)
        {
            this.logoutCtrl = logoutCtrl;
        }

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
