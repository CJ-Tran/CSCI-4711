using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoundaryObjects;
using EntityObjects;

namespace ControllerObjects
{
    class AvailController : Controller
    {
        MainMenu mm;
        LoginForm lf;

        public AvailController()
        {
            mm = new MainMenu();
            lf = new LoginForm(this);
        }

        public void Verify(string n, string p)
        {
            if (Validate(DBConnector.GetUser(n, p)) == true)
            {
                mm.Open(n, DBConnector.GetKeys());

                lf.Close();

                // and save user login
            }
            else
            {
                lf.Display("Error!");
            }
        }

        public bool Validate(User u) // changed to bool?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
