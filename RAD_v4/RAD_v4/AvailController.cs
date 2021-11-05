using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class AvailController : Controller
    {
        public static void Verify(string n, string p)
        {
            if (Validate(ControllerObjects.DBConnector.GetUser(n, p)) == true)
            {
                BoundaryObjects.MainMenu.Open(n, ControllerObjects.DBConnector.GetKeys());

                BoundaryObjects.LoginForm.Close();

                // and save user login
            }
            else
            {
                BoundaryObjects.LoginForm.Display("Error!");
            }
        }

        public static bool Validate(EntityObjects.User u) // changed to booL?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
