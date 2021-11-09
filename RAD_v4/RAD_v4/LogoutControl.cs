using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoundaryObjects;

namespace ControllerObjects
{
    public static class LogoutControl 
    {
        //LoginForm lf;

        //public LogoutControl()
        //{
        //    LoginForm lf = new LoginForm(this);
        //}

        public static void Logout(string n)
        {
            DBConnector.SaveLogout(n);
            LoginForm lf = new LoginForm();
            lf.Display();
        }
    }
}
