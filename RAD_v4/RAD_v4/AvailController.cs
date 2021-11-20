using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using Entity;
using System.Windows.Forms;

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

        public static void Verify(EventArgs uName, EventArgs pWord)
        {
            Boundary.MainMenu mainMenu = new Boundary.MainMenu();
            LoginForm loginForm = new LoginForm();

            string validUName = "";
            string validPWord = "";

            if (uName != null && uName is string && uName.ToString() != "")
            {
                validUName = uName.ToString();
            }
            else
            {
                MessageBox.Show("Username is an incorrect type!");
            }
            if (pWord != null && pWord is string && pWord.ToString() != "")
            {
                validPWord = pWord.ToString();

            }
            else
            {
                MessageBox.Show("Password is an incorrect type!");
            }


            if (Validate(DBConnector.GetUser(validUName, validPWord)) == true)
            {
                mainMenu.Open(validUName, DBConnector.GetKeys());
                loginForm.Close();

                // and save user login
            }
            else
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
