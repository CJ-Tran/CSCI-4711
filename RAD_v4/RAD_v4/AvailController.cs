using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class AvailController : Controller
    {
        BoundaryObjects.MainMenu mm;
        BoundaryObjects.LoginForm lf;

        public AvailController()
        {
            mm = new BoundaryObjects.MainMenu();
            lf = new BoundaryObjects.LoginForm(this);
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

        public bool Validate(EntityObjects.User u) // changed to bool?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
