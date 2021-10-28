using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class AvailController
    {
        public static void Verify(string n, string p)
        {
            if (Validate(Controller.DBConnector.GetUser(n, p)) == true)
            {
                Boundary.MainMenu.Open(n, Controller.DBConnector.GetKeys());

                Boundary.LoginForm.Close();

                // and save user login
            }
            else
            {
                Boundary.LoginForm.Display("Error!");
            }
        }

        public static bool Validate(Entity.User u) // changed to booL?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
