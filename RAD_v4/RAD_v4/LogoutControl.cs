using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoundaryObjects;

namespace ControllerObjects
{
    public class LogoutControl : Controller
    {
        LoginForm lf;

        public LogoutControl()
        {
            lf = new LoginForm(this);
        }

        public void Logout(string n)
        {
            DBConnector.SaveLogout(n);
            lf.Display();
        }
    }
}
