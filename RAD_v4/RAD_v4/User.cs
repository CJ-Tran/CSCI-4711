using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class User
    {
        /* Properties */
        private string UName { get; set; } //username

        private AcctType Type { get; set; } //account type (Admin = 1/Customer = 0)

        public enum AcctType
        {
            Customer = 0,
            Admin = 1
        }

        // No type provided, defaults to Customer
        public User(string username, AcctType type = AcctType.Customer)
        {
            this.UName = username;
            this.Type = type;
        }
        public string GetName()
        {
            return this.UName;
        }
        

    }
}
