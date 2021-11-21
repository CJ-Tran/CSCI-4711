using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;

namespace Controller
{
    public static class LogoutControl 
    {
        //LoginForm lf;

        //public LogoutControl()
        //{
        //    LoginForm lf = new LoginForm(this);
        //}

        public static void Logout(string name)
        {
            DBConnector.SaveLogout(name);
            DBConnector.Initialize(); //reinitialize db to open a new connection
            LoginForm lf = new LoginForm();
            lf.Open();
        }
    }
}
