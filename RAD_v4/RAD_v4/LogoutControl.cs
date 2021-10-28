using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class LogoutControl
    {
        public static void Logout(string n)
        {
            Controller.DBConnector.SaveLogout(n);
            Boundary.LoginForm.Display();
        }
    }
}
