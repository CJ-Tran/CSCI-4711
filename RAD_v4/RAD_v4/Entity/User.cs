using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        /* Properties */
        public string UName { get; private set; } //username
        public AcctType Type { get; private set; } //account type (Admin = 1/Customer = 0), made public to get User type

        public enum AcctType
        {
            Customer = 0,
            Admin = 1
        }//acct type enumeration (this can be int casted)

        public User(string username, AcctType type = AcctType.Customer) //default user is type customer
        {
            this.UName = username;
            this.Type = type;
        }//User()
    }
}
