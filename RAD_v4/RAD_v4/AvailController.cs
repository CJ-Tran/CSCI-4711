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

        public static bool Verify(object uName, object pWord) // Verify has bool instead of old Validate()
        {
            Boundary.MainMenu mainMenu = new Boundary.MainMenu();
            LoginForm loginForm = new LoginForm();

            string validUName = "";
            string validPWord = "";
            bool validU = false;
            bool validP = false;

            if (uName != null && uName.ToString().Trim() != "" && uName.ToString().Trim() != " ")
            {
                validUName = uName.ToString().Substring(35).Trim(); // 36 b/c prefix
                validU = true;
            }
            else
            {
                MessageBox.Show("Username is an incorrect type!");
            }
            if (pWord != null && pWord.ToString().Trim() != " " && pWord.ToString().Trim() != " ")
            {
                validPWord = pWord.ToString().Substring(36).Trim();
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
            }
            else
            {
                return false;
            }
        }

        public static void Save(string u, string p) // changed to void Save() more realistic?
        {
            DBConnector.conn.Open();
            DBConnector.cmd.CommandText = "" +
                    "INSERT INTO User (UName, PWord, Type)" +
                    $"VALUES(\'{u}\', \'{p}\', 0);";
            DBConnector.cmd.ExecuteNonQuery();
            DBConnector.conn.Close();
        }
    }
}
