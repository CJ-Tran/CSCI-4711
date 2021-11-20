﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using Entity;
using System.Windows.Forms;
using System.Data.SQLite;

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

        public static bool Verify(string uName, string pWord) // Verify has bool instead of old Validate()
        {
            Boundary.MainMenu mainMenu = new Boundary.MainMenu();
            LoginForm loginForm = new LoginForm();

            string validUName = "";
            string validPWord = "";
            bool validU = false;
            bool validP = false;

            if (uName != null && uName.ToString() != "")
            {
                validUName = uName.ToString().Trim().Substring(35); // 36 b/c prefix
                validU = true;
            }
            else
            {
                MessageBox.Show("Username is an incorrect type!");
            }
            if (pWord != null && pWord.ToString() != "")
            {
                validPWord = pWord.ToString().Trim().Substring(36);
                validP = true;

            }
            else
            {
                MessageBox.Show("Password is an incorrect type!");
            }

            if (validU && validP)
                try
                {
                    User user = DBConnector.GetUser(validU, validP);
                    mainMenu.Open(uName, DBConnector.GetKeys());
                    DBConnector.SaveLogin(user);
                    loginForm.Close();

                    mainMenu.Open(validUName, DBConnector.GetKeys());

                    return true;

                    //loginForm.Close(); //LoginForm closes itself
                }//try
                catch(Exception)
                {
                    return false;
                }
            {
                validUName = uName.ToString().Trim().Substring(35); // 36 b/c prefix
                validU = true;
            }
            else
            {
                MessageBox.Show("Username is an incorrect type!");
        public static bool Validate(User user) // changed to bool?
            if (pWord != null && pWord.ToString() != "")
            // comapre to an array of users in DB?
            return true;
            }

            if (validU && validP)
            {
                mainMenu.Open(uName, DBConnector.GetKeys());
                loginForm.Close();

                // and save user login
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
