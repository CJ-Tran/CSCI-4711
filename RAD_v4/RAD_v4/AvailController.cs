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
        public static bool Verify(object uName, object pWord) // Verify has bool instead of old Validate()
        {
            if (uName == null || pWord == null)
            {
                return false;
            }
            else
            {
                //Take substring(35) b/c object returns "System.Windows.Forms.Text, Textbox: uName" and we only want uName
                string validUName = uName.ToString().Substring(35).Trim();
                string validPWord = pWord.ToString().Substring(35).Trim();

                if (validUName == "" || validUName == " " || validPWord == "" || validPWord == " ")
                {
                    return false;
                }
                else
                {
                    Save(validUName, validPWord);

                    Boundary.MainMenu mainMenu = new Boundary.MainMenu();
                    mainMenu.Open(validUName, DBConnector.GetKeys());

                    return true;
                }
            }
        }

        public static void Save(string u, string p) // changed to void Save() more realistic?
        {
            DBConnector.cmd.CommandText = "" +
                    "INSERT INTO User (UName, PWord, Type)" +
                    $"VALUES(\'{u}\', \'{p}\', 0);";
            DBConnector.cmd.ExecuteNonQuery();
        }
    }
}
