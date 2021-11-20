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

        public static void Verify(string uName, string pWord)
        {
            MainMenu mainMenu = new MainMenu();
            LoginForm loginForm = new LoginForm();
            try
            {
                User user = DBConnector.GetUser(uName, pWord);
                mainMenu.Open(uName, DBConnector.GetKeys());
                DBConnector.SaveLogin(user);
                loginForm.Close();

                // and save user login
            }
            catch(Exception)
            {
                loginForm.Display("Error!");
            }
        }

        public static bool Validate(User user) // changed to bool?
        {
            // comapre to an array of users in DB?
            return true;
        }
    }
}
