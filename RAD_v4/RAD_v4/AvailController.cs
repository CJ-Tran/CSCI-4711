using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using Entity;

namespace Controller
{
    static class AvailController
    {
        //MainMenu mm;
        //LoginForm lf;

        //public AvailController()
        //{
        //    mm = new MainMenu();
        //    lf = new LoginForm(this);
        //}

        public static void Verify(string n, string p)
        {
            MainMenu mainMenu = new MainMenu();
            LoginForm loginForm = new LoginForm();

            if (Validate(DBConnector.GetUser(n, p)) == true)
            {
                mainMenu.Open(n, DBConnector.GetKeys());
                loginForm.Close();

                // and save user login
            }
            else
            {
                loginForm.Display("Error!");
            }
        }

        public static bool Validate(User u) // changed to bool?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
