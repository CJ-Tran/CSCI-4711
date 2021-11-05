using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class AvailController : Controller
    {
        DBConnector db;
        BoundaryObjects.MainMenu mm;
        BoundaryObjects.LoginForm lf;

        public AvailController()
        {
            db = new DBConnector();
            mm = new BoundaryObjects.MainMenu();
            lf = new BoundaryObjects.LoginForm(this);
        }

        public void Verify(string n, string p)
        {
            if (Validate(db.GetUser(n, p)) == true)
            {
                mm.Open(n, db.GetKeys());

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
