using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class User
    {
        public enum AcctType
        {
            Customer = 0,
            Admin = 1
        }

        //Private vars
        //private string uName; 
        //private string pWord; 
        //private AcctType type; 


        // No type provided, defaults to Customer
        public User(string username, string passHash, AcctType type = AcctType.Customer)
        {
            UName = username;
            PWord = passHash;
            Type = type;
        }

        /* Properties */
        public string UName { get; set; } //username

        public string PWord { get; set; } //password hash

        public AcctType Type { get; set; } //account type (Admin = 1/Customer = 0)

    }
}
