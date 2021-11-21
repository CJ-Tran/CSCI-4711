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
    static class LoginControl //rename AvailController to LoginControl
    {
        public static bool Verify(object uName, object pWord) // Verify has bool instead of old Validate()
        {
            if (uName == null || pWord == null)
            {
                return false;
            }//fi
            else
            {
                //Take substring(35) b/c object returns "System.Windows.Forms.Text, Textbox: uName" and we only want "uName"
                string validUName = uName.ToString().Substring(35).Trim();
                string validPWord = pWord.ToString().Substring(35).Trim();

                if (validUName == "" || validUName == " " || validPWord == "" || validPWord == " ")
                {
                    return false;
                }//fi
                else
                {
                    User user = new User();
                    try
                    {
                        user = DBConnector.GetUser(validUName, validPWord);
                        DBConnector.SaveLogin(user);
                    }//try
                    catch (Exception)
                    {
                        return false;
                    }//catch
                    Boundary.MainMenu mainMenu = new Boundary.MainMenu();
                    mainMenu.Open(user, DBConnector.GetKeys()); //passing user instead of the name to check for type on MainMenu

                    return true;
                }//else
            }//else
        }//Verify()
    }//AvailController class
}//Controller namespace
