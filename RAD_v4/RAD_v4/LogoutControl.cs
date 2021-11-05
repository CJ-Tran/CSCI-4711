using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    public class LogoutControl : Controller
    {
        DBConnector db;
        BoundaryObjects.LoginForm lf;

        public LogoutControl()
        {
            db = new DBConnector();
            lf = new BoundaryObjects.LoginForm(this);
        }

        public void Logout(string n)
        {
            db.SaveLogout(n);
            lf.Display();
        }
    }
}
