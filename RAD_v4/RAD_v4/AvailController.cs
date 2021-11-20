using System;
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

        public static bool Verify(EventArgs uName, EventArgs pWord) // Verify has bool instead of old Validate()
        {
            Boundary.MainMenu mainMenu = new Boundary.MainMenu();
            LoginForm loginForm = new LoginForm();

            string validUName = "";
            string validPWord = "";
            bool validU = false;
            bool validP = false;

            if (uName != null && uName.ToString() != "")
            {
                validUName = uName.ToString();
                validU = true;
            }
            else
            {
                MessageBox.Show("Username is an incorrect type!");
            }
            if (pWord != null && pWord.ToString() != "")
            {
                validPWord = pWord.ToString();
                validP = true;

            }
            else
            {
                MessageBox.Show("Password is an incorrect type!");
            }

            if (validU && validP)
            {
                Save(validUName, validPWord);
                
                mainMenu.Open(validUName, DBConnector.GetKeys());

                return true;

                //loginForm.Close(); //LoginForm closes itself
            }
            else
            {
                return false;
            }
        }

        public static void Save(string userName, string pWord) // changed to void Save() more realistic?
        {
            DBConnector.conn;
            SQLiteCommand cmd = new SQLiteCommand(); // forgot how to check if user is in table so I'll just only add them right now
            cmd.CommandText = "" +
                    "INSERT INTO User" +
                    $"VALUES({userName}, {pWord}, 0);";
            cmd.ExecuteNonQuery();
        }
    }
}
