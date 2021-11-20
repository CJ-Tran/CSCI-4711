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

        public static void Save(string u, string p) // changed to void Save() more realistic?
        {
            //SQLiteCommand cmd = DBConnector.conn.CreateCommand(); // forgot how to check if user is in table so I'll just only add them right now
             
            DBConnector.conn.Open();
            DBConnector.cmd.CommandText = "" +
                    "INSERT INTO User (UName, PWord, Type)" +
                    $"VALUES(\'{u}\', \'{p}\', 0);";
            DBConnector.cmd.ExecuteNonQuery();
            DBConnector.conn.Close();
        }
    }
}
