using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using Entity;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Controller
{
    static class LoginControl //renamed AvailController to LoginControl
    {
        public static bool Verify(object uName, object pWord) // Deleted Validate(), gave its bool return type to Verify
        {
            if (uName == null || pWord == null)
            {
                return false;
            }//if
            else
            {
                //Take substring(35) b/c object returns "System.Windows.Forms.Text, Textbox: uName" and we only want "uName"
                string validUName = uName.ToString().Substring(35).Trim();
                string validPWord = pWord.ToString().Substring(35).Trim();

                if (validUName == "" || validUName == " " || validPWord == "" || validPWord == " ")
                {
                    return false;
                }//if
                else
                {
                    User user;
                    try
                    {
                        string storedHash;
                        user = DBConnector.GetUser(validUName, out storedHash);
                        byte[] hashBytes = Convert.FromBase64String(storedHash);
                        byte[] salt = new byte[16];
                        Array.Copy(hashBytes, 0, salt, 0, 16);
                        var pbkdf2 = new Rfc2898DeriveBytes(validPWord, salt, 100000);
                        byte[] hash = pbkdf2.GetBytes(20);
                        for (int i = 0; i < 20; i++)
                            if (hashBytes[i + 16] != hash[i])
                                throw new UnauthorizedAccessException("Failed to verify credentials");
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
    }//LoginControl class
}//Controller namespace
