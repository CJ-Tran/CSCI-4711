using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class LogoutControl
    {
        public static void Logout(string n)
        {
            ControllerObjects.DBConnector.SaveLogout(n);
            BoundaryObjects.LoginForm.Display();
        }
    }
}
