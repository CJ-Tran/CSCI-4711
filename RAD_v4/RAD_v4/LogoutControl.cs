using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    public class LogoutControl : Controller
    {
        BoundaryObjects.LoginForm lf;

        public LogoutControl()
        {
            lf = new BoundaryObjects.LoginForm(this);
        }

        public void Logout(string n)
        {
            DBConnector.SaveLogout(n);
            lf.Display();
        }
    }
}
