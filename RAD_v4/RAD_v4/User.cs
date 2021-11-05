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
        private string uName; //username
        private string pWord; //password hash
        private AcctType type; //account type (Admin/Customer)


        // No type provided, defaults to Customer
        public User(string username, string passHash, AcctType type = AcctType.Customer) 
        {
            uName = username;
            pWord = passHash;
            this.type = type;
        }

        /* Getters & Setters */
        public string GetUName()
        {
            return uName;
        }
        public void SetUName(string name)
        {
            uName = name;
        }

        public string GetPWord()
        {
            return pWord;
        }
        public void SetPWord(string p)
        {
            pWord = p;
        }

        public new AcctType GetType() //0 for customer, 1 for admin
        {
            return type;
        }
        public void SetType(AcctType t)
        {
            type = t;
        }
    }
}
